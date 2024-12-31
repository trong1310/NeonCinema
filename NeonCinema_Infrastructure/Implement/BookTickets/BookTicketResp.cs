using Com.CloudRail.SI.ServiceCode.Commands;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.Utili;
using NeonCinema_Infrastructure.Services;
using System.Net;

namespace NeonCinema_Infrastructure.Implement.BookTickets
{
	public class BookTicketResp
	{
		private readonly NeonCinemasContext _context;
		private readonly EmailServices _emailServices;
		public BookTicketResp(NeonCinemasContext context, EmailServices emailServices)
		{
			_context = context;
			_emailServices = emailServices;
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
							.ThenInclude(s => s.SeatTypes)
					.Include(x => x.ShowTime).Where(x => x.Deleted == false)
					.FirstOrDefaultAsync(x => x.ID == request.ScreeningID, cancellationToken);
				if (screening == null)
				{
					throw new KeyNotFoundException("Lịch chiếu không tồn tại.");
				}
				var seats = await _context.SeatShowTimeStatuss
					.Include(x => x.Seat)
						.ThenInclude(x => x.SeatTypes)
					.Where(x =>
						x.ShowtimeId == screening.ShowTimeID &&
						x.RoomID == screening.RoomID &&
						x.ShowDate == screening.ShowDate &&
						request.SeatID.Contains(x.SeatID))
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
				// tinhs gia ve
				var seatTypes = screening.Rooms.Seats.ToDictionary(
								s => s.ID,
								s => s.SeatTypes?.SeatTypeName ?? "Unknown"
							);
				var bill = new Bill
				{
					ID = Guid.NewGuid(),
					BillCode = Uliti.GenerateBillCode(),
					Status = NeonCinema_Domain.Enum.ticketEnum.checkin,
					CreatedTime = DateTime.Now,
					UserID = request.AccountID ?? null,
					CreatedBy = request.CreateBy,
					TotalPoint = request.Point,
					PromotionID = request.Voucher,
					AfterDiscount = 0,
				};
				var startTime = screening.ShowTime.StartTime;
				var showDate = screening.ShowDate;
				var ticketPriceSetting = await _context.TicketPriceSettings
				.FirstOrDefaultAsync(x => x.ID == Guid.Parse("4BAB0DA1-D912-4A87-8E21-CB7A665657D3"));
				var tickets = request.SeatID.Select(seatId =>
				{
					decimal basePrice = 0;

					// Xác định giá cơ bản theo ngày trong tuần và giờ chiếu
					if (showDate.DayOfWeek == DayOfWeek.Monday ||
						showDate.DayOfWeek == DayOfWeek.Tuesday ||
						showDate.DayOfWeek == DayOfWeek.Wednesday ||
						showDate.DayOfWeek == DayOfWeek.Thursday)
					{
						basePrice = startTime < new TimeSpan(17, 0, 0)
							? ticketPriceSetting.PriceBefore17hWeekDay
							: ticketPriceSetting.PriceAfter17hWeekDay;
					}
					else if (showDate.DayOfWeek == DayOfWeek.Friday ||
							 showDate.DayOfWeek == DayOfWeek.Saturday ||
							 showDate.DayOfWeek == DayOfWeek.Sunday)
					{
						basePrice = startTime < new TimeSpan(17, 0, 0)
							? ticketPriceSetting.PriceBefore17hWeekeend
							: ticketPriceSetting.PriceAfter17hWeekeend;
					}

					// Thêm phụ phí cho loại ghế
					string seatTypeName = seatTypes[seatId];
					if (seatTypeName == "Ghế Vip")
					{
						basePrice += ticketPriceSetting.SurchargeVIP;
					}
					else if (seatTypeName == "Ghế đôi")
					{
						basePrice += ticketPriceSetting.SurchargeCouple;
					}

					return new Ticket
					{
						ID = Guid.NewGuid(),
						ScreningID = (Guid)request.ScreeningID,
						Code =Uliti.GenerateBillCode(),
						SeatID = seatId,
						CreatedTime = DateTime.Now,
						MovieID = (Guid)request.MovieId,
						Price = basePrice,
						BillId = bill.ID,

					};
				}).ToList();
				var flims = await _context.Movies.Where(x => x.ID == request.MovieId).FirstOrDefaultAsync();
				var type = await _context.MoviesType.Where(x => x.ID == flims.MovieTypeID).FirstOrDefaultAsync();
				if (type != null)
				{
					if (type.MovieTypeName.Contains("3D".Trim()))
					{
						bill.Surcharge = ticketPriceSetting.Surcharge3D;
					}
					if (type.MovieTypeName.Contains("2D".Trim()))
					{
						bill.Surcharge = ticketPriceSetting.Surcharge4D;
					}
				}
				await _context.Tickets.AddRangeAsync(tickets, cancellationToken);

				// Create bill

				await _context.BillDetails.AddAsync(bill, cancellationToken);
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
							FoodComboID = (Guid)bc.FoodComboId,
							CreatedTime = DateTime.Now,
							Quantity = (int)bc.Quantity
						};
					}).ToList();

					await _context.BillCombos.AddRangeAsync(billCombos, cancellationToken);

					bill.TotalPrice += tickets.Sum(t => t.Price) + billCombos.Sum(bc => foodComboPrices.First(fc => fc.ID == bc.FoodComboID).TotalPrice * bc.Quantity);
					bill.AfterDiscount += bill.TotalPrice;
				}
				else
				{
					bill.TotalPrice += tickets.Sum(t => t.Price);
					bill.AfterDiscount += bill.TotalPrice;
				}
				bill.TotalPrice += (decimal)bill.Surcharge;
				bill.AfterDiscount += (decimal)bill.Surcharge;
				double discount = 0;
				if (request.Point > 0)
				{
					discount = (double)request.Point * 0.5;
					bill.AfterDiscount -= (decimal)discount;
					var rankMember = await _context.RankMembers.Where(x => x.UserID == bill.UserID).FirstOrDefaultAsync();
					rankMember.MinPoint -= (double)request.Point;
				}
				if (request.Voucher != null)
				{
					var voucher = await _context.Promotions.Where(x => x.ID == request.Voucher).FirstOrDefaultAsync();

					if (voucher != null)
					{
						var accountVoucher = await _context.PromotionUsers.Where(x => x.PromotionID == voucher.ID).FirstOrDefaultAsync();
						if (voucher.DiscountAmount != null)
						{
							bill.AfterDiscount -= (decimal)voucher.DiscountAmount;

						}
						if (voucher.DiscountPercentage != null)
						{
							decimal discountAmount = bill.TotalPrice * ((decimal)voucher.DiscountPercentage / 100);
							bill.AfterDiscount -= discountAmount;
						}
						accountVoucher.Status = NeonCinema_Domain.Enum.PromotionStatus.Used;
						_context.PromotionUsers.Update(accountVoucher);
					}
				}
				double convertPoint = (double)bill.AfterDiscount * 6.8 / 100;

				if (request.AccountID != null)
				{
					var pendingPoint = new PendingPoint
					{
						ID = Guid.NewGuid(),
						UserID = (Guid)bill.UserID,
						Point = convertPoint,
						ApplyDate = DateTime.UtcNow.AddDays(1),// coonjg sau 1 ngayf
						CreatedTime = DateTime.UtcNow,
						BillID = bill.ID
					};
					await _context.PendingPoint.AddAsync(pendingPoint);
				}
				await _context.SaveChangesAsync(cancellationToken);
				var billresp = await _context.BillDetails
				.Include(x => x.Promotions)
				.Include(b => b.BillCombos)
					.ThenInclude(bc => bc.FoodCombo)
				.Include(b => b.Users)
				.Include(x => x.Ticket)
						.ThenInclude(t => t.Seat)
				.Where(b => b.ID == bill.ID)
				.FirstOrDefaultAsync();

				if (billresp == null)
				{
					throw new Exception("Không tìm thấy hóa đơn trong cơ sở dữ liệu.");
				}
				var acc = await _context.Users.Where(x => x.ID == bill.CreatedBy).Select(x=>x.FullName).FirstOrDefaultAsync();
				await transaction.CommitAsync(cancellationToken);
				var resp = new BillResp
				{
					Id = billresp.ID,
					BillCode = billresp.BillCode,
					BillCombo = billresp.BillCombos?.Select(cb => new BillComboResp
					{
						ComboName = cb.FoodCombo?.Content ?? "N/A",
						Quantity = cb.Quantity,
						Prices = cb.FoodCombo.TotalPrice
					}).ToList() ?? new List<BillComboResp>(),
					TicketResp = billresp.Ticket?.Select(tic => new TicketResp
					{
						SeatNumber = tic.Seat.SeatNumber,
						TicketID = tic.ID,
						Prices = tic.Price,
						ShowTime = tic.Screenings?.ShowTime?.StartTime.ToString(),
					}).ToList() ?? new List<TicketResp>(),
					CreatedAt = billresp.CreatedTime ?? DateTime.MinValue,
					CustomerName = billresp.Users?.FullName,
					Email = billresp.Users?.Email,
					TotalPrice = billresp.TotalPrice,
					AfterPrice = billresp.AfterDiscount,
					Voucher =billresp.TotalPrice-billresp.AfterDiscount,
					Films = flims?.Name,
					FilmsType = type.MovieTypeName,
					CreatedBy = acc ?? "NhanVien1",
					Surcharge = billresp.Surcharge
				};
				if (resp.Email != null)
				{
					await _emailServices.GenerateBillEmail(resp);
				}
				return resp;
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
						.Include(x => x.Movies) // Include Movie để truy cập MovieType
			.ThenInclude(movie => movie.MovieTypes) // Include MovieType để lấy MovieTypeName
				.Where(x => x.MovieID == MovieId && x.ShowDate.Date >= date.Date)
				.Where(x => x.Deleted == false)
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
			var screeningDtos = screenings.Select(screening => new ScreeningMoviesDto
			{
				Id = screening.ID,
				RoomName = screening.Rooms.Name,
				ShowDate = screening.ShowDate,
				ShowTime = screening.ShowTime.StartTime,
				MoviesID = screening.MovieID,
				Sub = screening.Movies?.Sub, // Lấy thông tin phụ đề từ Movie
				MovieTypeName = screening.Movies?.MovieTypes?.MovieTypeName // Lấy thông tin loại phim từ Movie
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
							.Where(x => x.ID == Id).Where(x => x.Deleted == false)
							.FirstOrDefaultAsync();
			var seatShowTime = await _context.SeatShowTimeStatuss
				.Include(x => x.ShowTime)
				.Include(x => x.Room)
				.Include(x => x.Seat).ThenInclude(x => x.SeatTypes).Where(x => x.ShowtimeId == screenings.ShowTimeID)
				.Where(x => x.RoomID == screenings.RoomID)
				.Where(x => x.ShowDate == screenings.ShowDate).ToListAsync();
			var seatTypes = screenings.Rooms.Seats.ToDictionary(s => s.ID, s => s.SeatTypes.SeatTypeName);
			var startTime = screenings.ShowTime.StartTime;
			var showDate = screenings.ShowDate;
			var ticketPriceSetting = await _context.TicketPriceSettings
			.FirstOrDefaultAsync(x => x.ID == Guid.Parse("4BAB0DA1-D912-4A87-8E21-CB7A665657D3"));
			var seats = seatShowTime.Select(x =>
			{
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatTypeID == x.Seat.SeatTypes.ID)
					.Select(tp => tp.Price)
					.FirstOrDefault();
				decimal basePrice = 0;
				if (showDate.DayOfWeek == DayOfWeek.Monday ||
					showDate.DayOfWeek == DayOfWeek.Tuesday ||
					showDate.DayOfWeek == DayOfWeek.Wednesday ||
					showDate.DayOfWeek == DayOfWeek.Thursday)
				{
					basePrice = startTime < new TimeSpan(17, 0, 0)
						? ticketPriceSetting.PriceBefore17hWeekDay
						: ticketPriceSetting.PriceAfter17hWeekDay;
				}
				else if (showDate.DayOfWeek == DayOfWeek.Friday ||
						 showDate.DayOfWeek == DayOfWeek.Saturday ||
						 showDate.DayOfWeek == DayOfWeek.Sunday)
				{
					basePrice = startTime < new TimeSpan(17, 0, 0)
						? ticketPriceSetting.PriceBefore17hWeekeend
						: ticketPriceSetting.PriceAfter17hWeekeend;
				}

				// Thêm phụ phí cho loại ghế
				string seatTypeName = x.Seat.SeatTypes.SeatTypeName;
				if (seatTypeName == "Ghế Vip")
				{
					basePrice += ticketPriceSetting.SurchargeVIP;
				}
				else if (seatTypeName == "Ghế đôi")
				{
					basePrice += ticketPriceSetting.SurchargeCouple;
				}

				return new SeatDto
				{
					ID = x.Seat.ID,
					SeatNumber = x.Seat.SeatNumber,
					SeatType = x.Seat.SeatTypes.SeatTypeName,
					Status = x.seatEnum,
					Price = basePrice // Gán giá lấy được từ bảng TicketPrice
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
