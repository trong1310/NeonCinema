using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.Utili;
using System.Net;

namespace NeonCinema_Infrastructure.Implement.BookTickets
{
	public class BookTicketResp
	{
		private readonly NeonCinemasContext _context;
		public BookTicketResp(NeonCinemasContext context)
		{
			_context = context;
		}
		public async Task<HttpResponseMessage> BookTicketCounter(CreateBookTicketRequest request, CancellationToken cancellationToken)
		{
			using var transaction = await _context.Database.BeginTransactionAsync();
			try
			{
				// Validate input
				if (request.SeatID == null || !request.SeatID.Any())
					return new HttpResponseMessage(HttpStatusCode.BadRequest)
					{
						Content = new StringContent("Danh sách ghế không hợp lệ.")
					};

				var screening = await _context.Screening
					.Include(x => x.Rooms)
						.ThenInclude(r => r.Seats)
					.FirstOrDefaultAsync(x => x.ID == request.ScreeningID, cancellationToken);

				if (screening == null)
					return new HttpResponseMessage(HttpStatusCode.NotFound)
					{
						Content = new StringContent("Lịch chiếu không tồn tại.")
					};

				// Check seat availability
				var seats = screening.Rooms.Seats
					.Where(s => request.SeatID.Contains(s.ID))
					.ToList();

				if (seats.Any(s => s.Status != NeonCinema_Domain.Enum.seatEnum.Available))
				{
					var unavailableSeats = seats.Where(s => s.Status != NeonCinema_Domain.Enum.seatEnum.Available)
												.Select(s => s.SeatNumber);
					return new HttpResponseMessage(HttpStatusCode.Conflict)
					{
						Content = new StringContent($"Ghế không khả dụng: {string.Join(", ", unavailableSeats)}")
					};
				}

				// Update seat status to Sold
				foreach (var seat in seats)
				{
					seat.Status = NeonCinema_Domain.Enum.seatEnum.Sold;
					_context.UpdateRange(seat);
					await _context.SaveChangesAsync();
				}

				// Calculate ticket price
				var seatTypes = seats.ToDictionary(s => s.ID, s => s.SeatTypeID);
				var ticketPrices = await _context.TicketPrice
					.Where(tp => seatTypes.Values.Contains(tp.SeatTypeID))
					.ToListAsync(cancellationToken);

				var tickets = request.SeatID.Select(seatId =>
				{
					var seatTypeId = seatTypes[seatId];
					var ticketPrice = ticketPrices.First(tp => tp.SeatTypeID == seatTypeId);

					return new Ticket
					{
						ID = Guid.NewGuid(),
						ScreningID = request.ScreeningID,
						SeatID = seatId,
						CreatedTime = DateTime.Now,
						MovieID = request.MovieId,
						Price = ticketPrice.Price
					};
				}).ToList();

				await _context.Tickets.AddRangeAsync(tickets, cancellationToken);
				await _context.SaveChangesAsync();

				// Create bill
				var bill = new Bill
				{
					ID = Guid.NewGuid(),
					BillCode = Uliti.GenerateBillCode(),
					Status = NeonCinema_Domain.Enum.ticketEnum.checkin,
					CreatedTime = DateTime.Now
				};
				await _context.BillDetails.AddAsync(bill, cancellationToken);

				// Add bill tickets
				var billTickets = tickets.Select(ticket => new BillTicket
				{
					BillId = bill.ID,
					TicketId = ticket.ID,
					CreatedTime = ticket.CreatedTime
				}).ToList();

				await _context.BillTickets.AddRangeAsync(billTickets, cancellationToken);

				// Add bill combos
				if (request.BillCombos != null && request.BillCombos.Any())
				{
					var foodComboPrices = await _context.FoodCombos
						.Where(fc => request.BillCombos.Select(bc => bc.FoodComboId).Contains(fc.ID))
						.ToListAsync(cancellationToken);

					var billCombos = request.BillCombos.Select(bc =>
					{
						var comboPrice = foodComboPrices.First(fc => fc.ID == bc.FoodComboId).TotalPrice;
						return new BillCombo
						{
							BillID = bill.ID,
							FoodComboID = bc.FoodComboId,
							CreatedTime = DateTime.Now,
							Quantity = bc.Quantity
						};
					}).ToList();

					await _context.BillCombos.AddRangeAsync(billCombos, cancellationToken);

					bill.TotalPrice = tickets.Sum(t => t.Price) +
									  billCombos.Sum(bc => foodComboPrices.First(fc => fc.ID == bc.FoodComboID).TotalPrice * bc.Quantity);
				}
				else
				{
					bill.TotalPrice = tickets.Sum(t => t.Price);
				}

				await _context.SaveChangesAsync();
				await transaction.CommitAsync();

				return new HttpResponseMessage(HttpStatusCode.OK)
				{
					Content = new StringContent("Đặt vé thành công.")
				};
			}
			catch (Exception ex)
			{
				await transaction.RollbackAsync();
				// Log error (e.g., using Serilog)
				return new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent("Đã xảy ra lỗi. Vui lòng thử lại sau.")
				};
			}
		}

		public async Task<ScreeningMoviesDto> GetScreeningMovies(Guid MovieId)
		{
			TimeSpan currentTime = DateTime.Now.TimeOfDay;
			var date = DateTime.Now;
			var screenings = await _context!.Screening
							.Include(x => x.ShowTime)
							.Include(x => x.Rooms)
								.ThenInclude(s => s.Seats!)
									.ThenInclude(x => x.SeatTypes)
							.Where(x => x.MovieID == MovieId)
							.ToListAsync();

			var upcomingScreening = screenings
				.Where(x => x.ShowTime.StartTime >= currentTime && x.ShowDate.Date >= date.Date)
				.OrderBy(x => x.ShowDate.Date)
				.ThenBy(x => x.ShowTime.StartTime)
				.FirstOrDefault();

			if (upcomingScreening == null) return null;

			var seats = upcomingScreening.Rooms!.Seats!.Select(x =>
			{
				// Lấy giá dựa trên SeatTypeID thay vì SeatID
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatTypeID == x.SeatTypeID) // Sửa: Lấy giá theo SeatTypeID
					.Select(tp => tp.Price)
					.FirstOrDefault();

				return new SeatDto
				{
					ID = x.ID,
					SeatNumber = x.SeatNumber,
					SeatType = x.SeatTypes.SeatTypeName,
					Status = x.Status,
					Price = ticketPrice // Gán giá lấy được từ bảng TicketPrice
				};
			}).ToList();
			var dto = new ScreeningMoviesDto()
			{
				Id = upcomingScreening.ID,
				RoomName = upcomingScreening.Rooms.Name,
				ShowDate = upcomingScreening.ShowDate,
				ShowTime = upcomingScreening.ShowTime.StartTime,
				Seats = seats,
			};
			return dto;
		}
		public async Task<UserDTO> GetAccountByPhone(string phone, CancellationToken cancellationToken)
		{
			try
			{

				var obj = await _context.Users.Where(x => x.PhoneNumber == phone).FirstOrDefaultAsync();
				return new UserDTO()
				{
					ID = obj.ID,
					PhoneNumber = obj.PhoneNumber,
					Adderss = obj.Adderss,
					DateOrBriht = obj.DateOrBriht,
					Email = obj.Email,
					FullName = obj.FullName,
					Gender = obj.Gender,
					Images = obj.Images,
					PassWord = obj.PassWord,
					RoleID = obj.RoleID,
					Status = obj.Status,
				};
			}
			catch (Exception ex)
			{
				throw new Exception();
			}
		}

	}
}
