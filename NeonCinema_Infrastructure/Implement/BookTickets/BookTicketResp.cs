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
				var screening = await _context.Screening
					.Include(x => x.Rooms)
						.ThenInclude(r => r.Seats)
					.FirstOrDefaultAsync(x => x.ID == request.ScreeningID);

				if (screening == null)
					throw new Exception("Lịch chiếu không tồn tại.");
				var unavailableSeats = screening.Rooms.Seats
					.Where(s => request.SeatID.Contains(s.ID) && s.Status == NeonCinema_Domain.Enum.seatEnum.Available)
					.Select(s => s.SeatNumber)
					.ToList();
				foreach (var seatId in request.SeatID)
				{
					var seat = screening.Rooms.Seats.FirstOrDefault(s => s.ID == seatId);
					if (seat != null)
						seat.Status = NeonCinema_Domain.Enum.seatEnum.Available;
				}
				var ticketPrices = await _context.TicketPrice.Include(x=>x.Seats).Where(x=> request.SeatID.Contains(x.SeatID)).ToListAsync();
				var tickets = request.SeatID.Select(seatId =>
				{
					var ticketPrice = ticketPrices.FirstOrDefault(x => x.SeatID == seatId);

					if (ticketPrice == null)
					{
						throw new Exception($"Không tìm thấy giá vé cho ghế có ID: {seatId}");
					}

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
				await	_context.Tickets.AddRangeAsync(tickets);
				await _context.SaveChangesAsync();
				Bill bill = new Bill();
				bill.ID = Guid.NewGuid();
				bill.BillCode = Uliti.GenerateBillCode();
				bill.Status = NeonCinema_Domain.Enum.ticketEnum.checkin;
				bill.CreatedTime = DateTime.Now;
				await _context.AddAsync(bill);
				var billTicket = tickets.Select(x => new BillTicket
				{
					BillId = bill.ID,
					TicketId = x.ID,
					CreatedTime = x.CreatedTime,
				}).ToList();
				await _context.BillTickets.AddRangeAsync(billTicket);
				var billCombo = request.BillCombos.Select(x => new BillCombo
				{
					BillID = bill.ID,
					FoodComboID = x.FoodComboId,
					CreatedTime = DateTime.Now,
					Quantity = x.Quantity,
					
				}).ToList();
				await _context.BillCombos.AddRangeAsync(billCombo);
				var priceTicket = tickets.Sum(x => x.Price);
				var foodComboId = request.BillCombos.Select(x=>x.FoodComboId).ToList();
				var foodComboPrices = await _context.FoodCombos
										.Where(fc => foodComboId.Contains(fc.ID))
										.ToListAsync();
				var priceCombo = request.BillCombos.Sum(x =>
				{
					var comboPrice = foodComboPrices.FirstOrDefault(fc => fc.ID == x.FoodComboId)?.TotalPrice ?? 0;
					return comboPrice * x.Quantity;
				});
				bill.TotalPrice = priceTicket + priceCombo;
				await _context.SaveChangesAsync();
				// Commit transaction
				await transaction.CommitAsync();

				return new HttpResponseMessage(HttpStatusCode.OK);		
			}
			catch (Exception ex)
			{
				await transaction.RollbackAsync();
				return new HttpResponseMessage(HttpStatusCode.InternalServerError)
				{
					Content = new StringContent($"Đã xảy ra lỗi: {ex.Message}")
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
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatID == x.ID)
					.Select(tp => tp.Price)
					.FirstOrDefault();

				return new SeatDto
				{
					ID = x.ID,
					SeatNumber = x.SeatNumber,
					SeatType = x.SeatTypes.SeatTypeName,
					Price = ticketPrice
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
