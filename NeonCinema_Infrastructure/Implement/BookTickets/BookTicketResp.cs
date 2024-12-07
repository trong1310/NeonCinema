using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
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
		public async Task<BillResp> BookTicketCounter(CreateBookTicketRequest request, CancellationToken cancellationToken)
		{
			using var transaction = await _context.Database.BeginTransactionAsync();
			try
			{
				// Validate input
				if (request.SeatID == null || !request.SeatID.Any())
				{
					throw new ArgumentException("Danh sách ghế không hợp lệ.");
				}

				var screening = await _context.Screening
					.Include(x => x.Rooms)
						.ThenInclude(r => r.Seats)
					.FirstOrDefaultAsync(x => x.ID == request.ScreeningID, cancellationToken);

				if (screening == null)
					if (screening == null)
					{
						throw new KeyNotFoundException("Lịch chiếu không tồn tại.");
					}
				// Check seat availability
				var seats = screening.Rooms.Seats
					.Where(s => request.SeatID.Contains(s.ID))
					.ToList();

				if (seats.Any(s => s.Status == NeonCinema_Domain.Enum.seatEnum.Sold && s.Status == NeonCinema_Domain.Enum.seatEnum.Maintenance))
				{
					var unavailableSeats = seats.Where(s => s.Status != NeonCinema_Domain.Enum.seatEnum.Available)
												.Select(s => s.SeatNumber);
					if (unavailableSeats.Any())
					{
						throw new InvalidOperationException($"Ghế không khả dụng: {string.Join(", ", unavailableSeats)}");
					}
				}

				// Update seat status to Sold
				foreach (var seat in seats)
				{
					seat.Status = NeonCinema_Domain.Enum.seatEnum.Sold;
					_context.UpdateRange(seat);
					await _context.SaveChangesAsync();
				}

				// tinhs gia ve
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
						ScreningID = (Guid)request.ScreeningID,
						SeatID = seatId,
						CreatedTime = DateTime.Now,
						MovieID =(Guid) request.MovieId,
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
					CreatedTime = DateTime.Now,
					UserID = request.AccountID ?? null,
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
							FoodComboID =(Guid) bc.FoodComboId,
							CreatedTime = DateTime.Now,
							Quantity =(int) bc.Quantity
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
				double convertPoint =(double) bill.TotalPrice * 6.8 / 100;

				if(request.AccountID != null)
				{
					var accountBook = await _context.RankMembers.Where(x => x.UserID == bill.UserID).FirstOrDefaultAsync();
					accountBook.MinPoint += (double)convertPoint;
					if (accountBook.MinPoint >= 0 && accountBook.MinPoint <= 60000)
					{
						accountBook.Rank = "Thành viên";
					}
					else if (accountBook.MinPoint > 60000 && accountBook.MinPoint <= 150000)
					{
						accountBook.Rank = "Bạc";
					}
					else if (accountBook.MinPoint > 150000 && accountBook.MinPoint <= 300000)
					{
						accountBook.Rank = "vàng";
					}
					else if (accountBook.MinPoint > 300000)
					{
						accountBook.Rank = "Kim cương";
					}
					accountBook.ModifiedTime = DateTime.UtcNow;
					_context.RankMembers.Update(accountBook);
					await _context.SaveChangesAsync();
				}
				var billresp = await _context.BillDetails
						.Include(b => b.BillCombos)
							.ThenInclude(bc => bc.FoodCombo)
						.Include(b => b.Users)
						.Include(b => b.BillTickets)
							.ThenInclude(bt => bt.Tickets)
								.ThenInclude(t => t.Seat)
						.Where(b => b.ID == bill.ID)
						.FirstOrDefaultAsync();

				if (billresp == null)
				{
					throw new Exception("Không tìm thấy hóa đơn trong cơ sở dữ liệu.");
				}

				return new BillResp
				{
					Id = billresp.ID,
					BillCode = billresp.BillCode,
					BillCombo = billresp.BillCombos?.Select(cb => new BillComboResp
					{
						ComboName = cb.FoodCombo?.Content ?? "N/A",
						Quantity = cb.Quantity,
					}).ToList() ?? new List<BillComboResp>(),
					BillTickets = billresp.BillTickets?.Select(tk => new BillTicketResp
					{
						BillTicketID = tk.BillId,
						SeatNumber = tk.Tickets?.Seat?.SeatNumber ?? "N/A",
					}).ToList() ?? new List<BillTicketResp>(),
					CreatedAt = billresp.CreatedTime ?? DateTime.MinValue,
					CustomerName = billresp.Users?.FullName ?? "Khách hàng không xác định",
					TotalPrice = billresp.TotalPrice,
				};

			}
			catch (Exception ex)
			{
				await transaction.RollbackAsync();
				throw new Exception($"{ex.Message} : {ex.StackTrace}");
			}
		}

		public async Task<List<ScreeningMoviesDto>> GetScreeningMovies(Guid MovieId, DateTime? showDate)
		{
			TimeSpan currentTime = DateTime.Now.TimeOfDay;
			var date = DateTime.Now;

			// Lấy danh sách các lịch chiếu của phim
			var screenings = await _context!.Screening
				.Include(x => x.ShowTime)
				.Include(x => x.Rooms)
					.ThenInclude(s => s.Seats!)
						.ThenInclude(x => x.SeatTypes)
				.Where(x => x.MovieID == MovieId && x.ShowDate.Date >= date.Date)
				.OrderBy(x => x.ShowDate.Date)
				.ThenBy(x => x.ShowTime.StartTime)
				.ToListAsync();

			if (screenings == null || !screenings.Any())
				return new List<ScreeningMoviesDto>();
			if (showDate.HasValue)
			{
				screenings = screenings.Where(x => x.ShowDate.Date == showDate.Value.Date && x.ShowDate.Month == showDate.Value.Month && x.ShowDate.Year == showDate.Value.Year).ToList();
			}
			// Ánh xạ từng lịch chiếu thành DTO
			var screeningDtos = screenings.Select(screening =>
			{
				return new ScreeningMoviesDto
				{
					Id = screening.ID,
					RoomName = screening.Rooms.Name,
					ShowDate = screening.ShowDate,
					ShowTime = screening.ShowTime.StartTime,
					MoviesID = screening.MovieID,
				};
			}).ToList();

			return screeningDtos;
		}

		public async Task<ScreeningMoviesDto> ChooseScreeningMovies(Guid Id)
		{
			TimeSpan currentTime = DateTime.Now.TimeOfDay;
			var date = DateTime.Now;
			var screenings = await _context!.Screening
							.Include(x => x.ShowTime)
							.Include(x => x.Rooms)
								.ThenInclude(s => s.Seats!)
									.ThenInclude(x => x.SeatTypes)
							.Where(x => x.ID == Id)
							.FirstOrDefaultAsync();
			var seats = screenings.Rooms!.Seats!.Select(x =>
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
				MoviesID = screenings.MovieID,
				Id = screenings.ID,
				RoomName = screenings.Rooms.Name,
				ShowDate = screenings.ShowDate,
				ShowTime = screenings.ShowTime.StartTime,
				Seats = seats,
			};
			return dto;
		}
		public async Task<RankMemberResp> GetAccountByPhone(string? phone, CancellationToken cancellationToken)
		{
			try
			{

				var obj = await _context.RankMembers.Include(x => x.Users).Where(x => x.Users.PhoneNumber == phone).FirstOrDefaultAsync();
				if (obj == null)
				{
					return null;
				}
				return  obj == null ? null : new RankMemberResp()
				{
					Id = obj.ID,
					AccountName = obj.Users.FullName,
					AccountId = obj.UserID,
					Point = obj.MinPoint,
					Rank = obj.Rank,
				};

			}
			catch (Exception ex)
			{
				throw new Exception();
			}
		}

	}
}
