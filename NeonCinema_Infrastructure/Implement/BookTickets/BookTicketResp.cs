using Com.CloudRail.SI.ServiceCode.Commands;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.Utili;
using System.Net;
using System.Threading;

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

				// Lấy thông tin lịch chiếu và phòng
				var screening = await _context.Screening
					.Include(x => x.Rooms)
						.ThenInclude(r => r.Seats)
					.FirstOrDefaultAsync(x => x.ID == request.ScreeningID, cancellationToken);

				if (screening == null)
				{
					throw new KeyNotFoundException("Lịch chiếu không tồn tại.");
				}

				// Lấy trạng thái của các ghế trong phòng và giờ chiếu
				var seats = await _context.SeatShowTimeStatuss
					.Include(x => x.Seat)
						.ThenInclude(x => x.SeatTypes)
					.Where(x => x.ShowtimeId == screening.ShowTimeID && x.RoomID == screening.RoomID)
					.Where(x => x.ShowDate == screening.ShowDate)
					.Where(x => request.SeatID.Contains(x.SeatID))
					.ToListAsync(cancellationToken);

				// Kiểm tra ghế không khả dụng
				var unavailableSeats = seats
					.Where(x => request.SeatID.Contains(x.SeatID) && x.seatEnum != NeonCinema_Domain.Enum.seatEnum.Available)
					.Select(x => x.Seat.SeatNumber)
					.ToList();

				if (unavailableSeats.Count() > 0)
				{
					throw new InvalidOperationException($"Ghế không khả dụng: {string.Join(", ", unavailableSeats)}");
				}
				var selectedSeats = seats.Where(x => request.SeatID.Contains(x.SeatID)).ToList();
				foreach (var seat in selectedSeats)
				{
					seat.seatEnum = NeonCinema_Domain.Enum.seatEnum.Sold;
				}
				_context.SeatShowTimeStatuss.UpdateRange(selectedSeats);
				await _context.SaveChangesAsync();
				var seatTypes = selectedSeats.ToDictionary(s => s.SeatID, s => s.Seat.SeatTypes.ID);
				var ticketPrices = await _context.TicketPrice
					.Where(tp => seatTypes.Values.Contains(tp.SeatTypeID))
					.ToListAsync(cancellationToken);
				var tickets = request.SeatID.Select(seatId =>
				{
					var seatTypeId = _context.SeatTypes.AsNoTracking().Select(x => x.ID).ToList();
					var ticketPrice = ticketPrices.First(tp => seatTypeId.Contains(tp.SeatTypeID));
					return new Ticket
					{
						ID = Guid.NewGuid(),
						ScreningID = (Guid)request.ScreeningID,
						SeatID = seatId,
						CreatedTime = DateTime.Now,
						MovieID = (Guid)request.MovieId,
						Price = ticketPrice.Price
					};
				}).ToList();

				await _context.Tickets.AddRangeAsync(tickets, cancellationToken);
				await _context.SaveChangesAsync();

				// Tạo hóa đơn
				var bill = new Bill
				{
					ID = Guid.NewGuid(),
					BillCode = Uliti.GenerateBillCode(),
					Status = NeonCinema_Domain.Enum.ticketEnum.checkin,
					CreatedTime = DateTime.Now,
					UserID = request.AccountID,
					TotalPrice = tickets.Sum(t => t.Price)
				};

				// Tính tổng giá nếu có combo
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
							FoodComboID = (Guid)bc.FoodComboId,
							CreatedTime = DateTime.Now,
							Quantity = (int)bc.Quantity
						};
					}).ToList();

					await _context.BillCombos.AddRangeAsync(billCombos, cancellationToken);

					bill.TotalPrice += billCombos.Sum(bc => foodComboPrices.First(fc => fc.ID == bc.FoodComboID).TotalPrice * bc.Quantity);
				}

				await _context.BillDetails.AddAsync(bill, cancellationToken);

				// Lưu thông tin vé vào hóa đơn
				var billTickets = tickets.Select(ticket => new BillTicket
				{
					BillId = bill.ID,
					TicketId = ticket.ID,
					CreatedTime = ticket.CreatedTime
				}).ToList();

				await _context.BillTickets.AddRangeAsync(billTickets, cancellationToken);
				await _context.SaveChangesAsync();

				// Cập nhật điểm thành viên
				if (request.AccountID != null)
				{
					var accountBook = await _context.RankMembers.FirstOrDefaultAsync(x => x.UserID == bill.UserID, cancellationToken);
					if (accountBook != null)
					{
						double convertPoint = (double)bill.TotalPrice * 6.8 / 100;
						accountBook.MinPoint += convertPoint;

						// Cập nhật hạng thành viên
						if (accountBook.MinPoint <= 60000) accountBook.Rank = "Thành viên";
						else if (accountBook.MinPoint <= 150000) accountBook.Rank = "Bạc";
						else if (accountBook.MinPoint <= 300000) accountBook.Rank = "Vàng";
						else accountBook.Rank = "Kim cương";

						accountBook.ModifiedTime = DateTime.UtcNow;
						_context.RankMembers.Update(accountBook);
						await _context.SaveChangesAsync();
					}
				}

				await transaction.CommitAsync();

				// Lấy thông tin hóa đơn
				var billresp = await _context.BillDetails
					.Include(b => b.BillCombos)
						.ThenInclude(bc => bc.FoodCombo)
					.Include(b => b.Users)
					.Include(b => b.BillTickets)
						.ThenInclude(bt => bt.Tickets)
							.ThenInclude(t => t.Seat)
					.FirstOrDefaultAsync(b => b.ID == bill.ID, cancellationToken);

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
					CustomerName = billresp.Users?.FullName ?? "Khách lẻ",
					TotalPrice = billresp.TotalPrice,
				};
			}
			catch (Exception ex)
			{
				await transaction.RollbackAsync();
				throw new Exception($"Đã xảy ra lỗi: {ex.Message}", ex);
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
				.Where(x => x.MovieID == MovieId && x.ShowDate.Date >= date.Date).Where(x => x.ShowTime.StartTime >= currentTime)
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
			var screenings = await _context!.Screening
							.Include(x => x.ShowTime)
							.Include(x => x.Rooms)
								.ThenInclude(s => s.Seats!)
									.ThenInclude(x => x.SeatTypes)
							.Where(x => x.ID == Id)
							.FirstOrDefaultAsync();
			var seatShowTime = await _context.SeatShowTimeStatuss
				.Include(x => x.ShowTime)
				.Include(x => x.Room)
				.Include(x => x.Seat).Where(x => x.ShowtimeId == screenings.ShowTimeID)
				.Where(x => x.RoomID == screenings.RoomID)
				.Where(x => x.ShowDate == screenings.ShowDate).ToListAsync();
			var seats = seatShowTime.Select(x =>
			{
				// Lấy giá dựa trên SeatTypeID thay vì SeatID
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatTypeID == x.Seat.SeatTypes.ID) // Sửa: Lấy giá theo SeatTypeID
					.Select(tp => tp.Price)
					.FirstOrDefault();

				return new SeatDto
				{
					ID = x.Seat.ID,
					SeatNumber = x.Seat.SeatNumber,
					SeatType = x.Seat.SeatTypes.SeatTypeName,
					Status = x.seatEnum,
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
				return obj == null ? null : new RankMemberResp()
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
