using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Extention.Utili;
using NeonCinema_Infrastructure.Implement.BookTickets;
using NeonCinema_Infrastructure.Services;
using System.Net;
using System.Text.Json;
using System.Threading;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookTicketController : ControllerBase
	{
		private readonly BookTicketResp _bookTicketResp;
		private readonly IMapper _mapper;
		private readonly NeonCinemasContext _context;
		private readonly EmailServices _emailServices;
		public BookTicketController(BookTicketResp bookTicketResp, IMapper map, NeonCinemasContext context, EmailServices emailServices)
		{
			_bookTicketResp = bookTicketResp;
			_mapper = map;
			_context = context;
			_emailServices = emailServices;
		}
		// Đặt vé cho khách hàng
		[HttpPost("book-ticket")]
		//	[Authorize]
		public async Task<IActionResult> BookTicket([FromBody] CreateBookTicketRequest request, CancellationToken cancellationToken)
		{
			try
			{
				var billResp = await _bookTicketResp.BookTicketCounter(request, cancellationToken);
				return Ok(billResp);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
			}
		}

		// Lấy thông tin lịch chiếu cho phim
		[HttpGet("screening")]
		public async Task<IActionResult> GetScreeningMovies(Guid movieId, DateTime? showDate)
		{
			try
			{
				var screeningMovies = await _bookTicketResp.GetScreeningMovies(movieId, showDate);
				if (screeningMovies == null)
				{
					return NotFound("Không tìm thấy lịch chiếu cho phim này");
				}
				return Ok(screeningMovies);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
			}
		}

		// Lấy thông tin tài khoản người dùng theo số điện thoại
		[HttpGet("account/{phone}")]
		public async Task<IActionResult> GetAccountByPhone(string? phone, CancellationToken cancellationToken)
		{
			try
			{
				var user = await _bookTicketResp.GetAccountByPhone(phone, cancellationToken);
				if (user == null)
				{
					return NotFound("Không tìm thấy tài khoản với số điện thoại này");
				}
				return Ok(user);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
			}
		}

		[HttpGet("choose-screning")]
		public async Task<IActionResult> ChooseScrening([FromQuery] Guid id)
		{
			try
			{
				var screeningMovies = await _bookTicketResp.ChooseScreeningMovies(id);
				if (screeningMovies == null)
				{
					return NotFound("không tìm thấy phòng cho lịch");
				}
				return Ok(screeningMovies);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
			}
		}

		[HttpGet("/stream-seat-status")] 
		public async Task UpdateStatusSeat(Guid id)
		{
			Response.ContentType = "text/event-stream"; // Định nghĩa kiểu trả về
			Response.Headers["Cache-Control"] = "no-cache";
			Response.Headers["Connection"] = "keep-alive";

			var cancellationToken = HttpContext.RequestAborted;

			try
			{
				while (!cancellationToken.IsCancellationRequested)
				{
					// Lấy danh sách ghế mới được bán
					var soldSeats = await GetRecentlySoldSeatsAsync(id);

					if (soldSeats.Any())
					{
						// Serialize danh sách ghế dưới dạng JSON
						var eventData = JsonSerializer.Serialize(soldSeats, new JsonSerializerOptions
						{
							PropertyNamingPolicy = JsonNamingPolicy.CamelCase
						});

						await Response.WriteAsync($"data: {eventData}\n\n");
						await Response.Body.FlushAsync();
					}
					await Task.Delay(1000);
				}
			}
			catch (TaskCanceledException)
			{
				
			}
			finally
			{
				Response.Body.Close();
			}
		}

		private async Task<List<SeatShowTimeDTO>> GetRecentlySoldSeatsAsync(Guid Id)
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
				.Where(x => x.RoomID == screenings.RoomID).Where(x => x.seatEnum == seatEnum.Sold)
				.Where(x => x.ShowDate == screenings.ShowDate).Select(x => new SeatShowTimeDTO
				{
					ID = x.SeatID,
					Status = x.seatEnum
				}).ToListAsync();
			return seatShowTime;
		}
		[HttpPost("client-bookticket")]
		public async Task<IActionResult> ClientBookTicket([FromBody] CreateBookTicketRequest request, CancellationToken cancellationToken)
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
					seat.seatEnum = NeonCinema_Domain.Enum.seatEnum.Selected;

				}
				_context.SeatShowTimeStatuss.UpdateRange(selectedSeats);
				//	tinhs gia ve
				var seatTypes = screening.Rooms.Seats.ToDictionary(
								 s => s.ID,
								 s => s.SeatTypes?.SeatTypeName ?? "Unknown"
							 );
				var bill = new Bill
				{
					ID = Guid.NewGuid(),
					BillCode = Uliti.GenerateBillCode(),
					Status = NeonCinema_Domain.Enum.ticketEnum.waiting_for_payment,
					CreatedTime = DateTime.Now,
					UserID = request.AccountID ?? null,
					CreatedBy = request.CreateBy,
					PromotionID = request.Voucher ?? null,
					AfterDiscount = 0,
				};
				var startTime = screening.ShowTime.StartTime;
				var showDate = screening.ShowDate;
				var ticketPriceSetting = await _context.TicketPriceSettings
				.FirstOrDefaultAsync(x => x.ID == Guid.Parse("4BAB0DA1-D912-4A87-8E21-CB7A665657D3"));
				var flims = await _context.Movies.Where(x => x.ID == request.MovieId).FirstOrDefaultAsync();
				var type = await _context.MoviesType.Where(x => x.ID == flims.MovieTypeID).FirstOrDefaultAsync();
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
					if (type != null)
					{
						if (type.MovieTypeName.Contains("3D".Trim()))
						{
							basePrice += ticketPriceSetting.Surcharge3D;
						}
						if (type.MovieTypeName.Contains("4D".Trim()))
						{
							basePrice += ticketPriceSetting.Surcharge4D;
						}
					}
					return new Ticket
					{
						ID = Guid.NewGuid(),
						ScreningID = (Guid)request.ScreeningID,
						Code = Uliti.GenerateBillCode(),
						SeatID = seatId,
						CreatedTime = DateTime.Now,
						MovieID = (Guid)request.MovieId,
						Price = basePrice,
						BillId = bill.ID,

					};
				}).ToList();
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
				//bill.TotalPrice += (decimal)bill.Surcharge;
				//bill.AfterDiscount += (decimal)bill.Surcharge;

				double discount = 0;
				if (request.Point > 0)
				{
					discount = (double)request.Point * 0.5;
					bill.AfterDiscount -= (decimal)discount;
					//var rankMember = await _context.RankMembers.Where(x => x.UserID == bill.UserID).FirstOrDefaultAsync();
					//rankMember.MinPoint -= (double)request.Point;
				}
				if (request.Voucher != null)
				{
					var voucher = await _context.Promotions.Where(x => x.ID == request.Voucher).FirstOrDefaultAsync();
					if (voucher != null)
					{
						var accountVoucher = await _context.PromotionUsers.Where(x => x.PromotionID == voucher.ID).FirstOrDefaultAsync();

						decimal discountAmount = bill.TotalPrice * ((decimal)voucher.DiscountPercentage / 100);

						if (discountAmount > (decimal)voucher.AmountMax)
						{
							bill.AfterDiscount -= (decimal)voucher.AmountMax;
						}
						else
						{
							bill.AfterDiscount -= discountAmount;
						}

					}
				}
				bill.TotalPoint = (double)(bill.TotalPrice - bill.AfterDiscount);
				double convertPoint = (double)bill.AfterDiscount * 6.8 / 100;

				//if (request.AccountID != null)
				//{
				//	var pendingPoint = new PendingPoint
				//	{
				//		ID = Guid.NewGuid(),
				//		UserID = (Guid)bill.UserID,
				//		Point = convertPoint,
				//		ApplyDate = DateTime.UtcNow.AddDays(1),// coonjg sau 1 ngayf
				//		CreatedTime = DateTime.UtcNow,
				//		BillID = bill.ID
				//	};
				//	await _context.PendingPoint.AddAsync(pendingPoint);
				//}
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
				var acc = await _context.Users.Where(x => x.ID == bill.CreatedBy).Select(x => x.FullName).FirstOrDefaultAsync();
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
					Voucher = billresp.TotalPrice - billresp.AfterDiscount,
					Films = flims?.Name,
					FilmsType = type.MovieTypeName,
					CreatedBy = acc ?? "NhanVien1",
					Surcharge = billresp.Surcharge
				};
				//if (resp.Email != null)
				//{
				//	await _emailServices.GenerateBillEmail(resp);
				//}
				return Ok(resp);
			}
			catch (Exception ex)
			{
				await transaction.RollbackAsync();
				return null;
			}
		}
		[HttpPost("payment-faild")]
		public async Task<IActionResult> PaymentFaild([FromBody] Guid billId)
		{
			try
			{
				var bill = await _context.BillDetails.Where(x => x.ID == billId).FirstOrDefaultAsync();
				if (bill == null)
				{
					return NotFound();
				}
				if (bill.Status == ticketEnum.paid)
				{
					return BadRequest("Hóa đơn đã thanh toán không thể xóa");
				}
				var ticket = await _context.Tickets.Where(x => x.BillId == bill.ID).ToListAsync();
				var combo = await _context.BillCombos.Where(x => x.BillID == bill.ID).ToListAsync();
				var seat = await _context.SeatShowTimeStatuss.Where(x => ticket.Select(a => a.SeatID).Contains(x.SeatID)).ToListAsync();

				foreach (var item in seat)
				{
					item.seatEnum = seatEnum.Available;
				}
				_context.SeatShowTimeStatuss.UpdateRange(seat);
				_context.BillCombos.RemoveRange(combo);
				_context.Tickets.RemoveRange(ticket);
				_context.BillDetails.Remove(bill);
				await _context.SaveChangesAsync();
				return Ok();
			}
			catch (Exception ex)
			{
				throw new Exception($"{ex.Message} : {ex.StackTrace}");
			}

		}
		[HttpPost("payment-success")]
		public async Task<IActionResult> PaymentSuccess(Guid billId, double point)
		{

			try
			{
				// Kiểm tra xem bill có tồn tại không
				var bill = await _context.BillDetails.Include(x => x.Promotions)
				.Include(b => b.BillCombos)
					.ThenInclude(bc => bc.FoodCombo)
				.Include(b => b.Users)
				.Include(x => x.Ticket)
						.ThenInclude(t => t.Seat).Where(x => x.ID == billId).FirstOrDefaultAsync();
				if (bill == null)
				{
					return NotFound("Không tìm thấy hóa đơn.");
				}

				// Lấy danh sách ghế

				var ticket = await _context.Tickets.Where(x => x.BillId == bill.ID).ToListAsync();
				var seat = await _context.SeatShowTimeStatuss.Where(x => ticket.Select(a => a.SeatID).Contains(x.SeatID)).ToListAsync();

				foreach (var item in seat)
				{
					if (item.seatEnum == seatEnum.Sold)
					{
						return BadRequest("Ghế đã có người đặt trước đó rồi vui lòng thử lại");
					}
					else
					{
						item.seatEnum = seatEnum.Sold;
					}
				}
				bill.Status = ticketEnum.checkin;

				_context.BillDetails.Update(bill);
				_context.SeatShowTimeStatuss.UpdateRange(seat);
				await _context.SaveChangesAsync();

				// Tính điểm thưởng
				double convertPoint = (double)bill.AfterDiscount * 6.8 / 100;
				var pendingPoint = new PendingPoint
				{
					ID = Guid.NewGuid(),
					UserID = (Guid)bill.UserID,
					Point = convertPoint,
					ApplyDate = DateTime.UtcNow.AddDays(1),
					CreatedTime = DateTime.UtcNow,
					BillID = bill.ID
				};
				await _context.PendingPoint.AddAsync(pendingPoint);

				// Cập nhật điểm thành viên
				var rankMember = await _context.RankMembers.Where(x => x.UserID == bill.UserID).FirstOrDefaultAsync();
				if (rankMember != null)
				{
					rankMember.MinPoint -= (double)point;
				}
				_context.RankMembers.Update(rankMember);
				var accountVoucher = await _context.PromotionUsers.Where(x => x.PromotionID == bill.PromotionID).FirstOrDefaultAsync();
				if (accountVoucher != null)
				{
					accountVoucher.Status = NeonCinema_Domain.Enum.PromotionStatus.Used;
					_context.PromotionUsers.Update(accountVoucher);
				}
				var acc = await _context.Users.Where(x => x.ID == bill.CreatedBy).Select(x => x.FullName).FirstOrDefaultAsync();
				var flims = await _context.Movies.Where(x => ticket.Select(a => a.MovieID).Contains(x.ID)).FirstOrDefaultAsync();
				var type = await _context.MoviesType.Where(x => x.ID == flims.MovieTypeID).FirstOrDefaultAsync();
				await _context.SaveChangesAsync();
				var resp = new BillResp
				{
					Id = bill.ID,
					BillCode = bill.BillCode,
					BillCombo = bill.BillCombos?.Select(cb => new BillComboResp
					{
						ComboName = cb.FoodCombo?.Content ?? "N/A",
						Quantity = cb.Quantity,
						Prices = cb.FoodCombo.TotalPrice
					}).ToList() ?? new List<BillComboResp>(),
					TicketResp = bill.Ticket?.Select(tic => new TicketResp
					{
						SeatNumber = tic.Seat.SeatNumber,
						TicketID = tic.ID,
						Prices = tic.Price,
						ShowTime = tic.Screenings?.ShowTime?.StartTime.ToString(),
					}).ToList() ?? new List<TicketResp>(),
					CreatedAt = bill.CreatedTime ?? DateTime.MinValue,
					CustomerName = bill.Users?.FullName,
					Email = bill.Users?.Email,
					TotalPrice = bill.TotalPrice,
					AfterPrice = bill.AfterDiscount,
					Voucher = bill.TotalPrice - bill.AfterDiscount,
					Films = flims?.Name,
					FilmsType = type.MovieTypeName,
					CreatedBy = acc ?? "NhanVien1",
					Surcharge = bill.Surcharge
				};
				await _emailServices.GenerateBillEmail(resp);
				return Ok("Thanh toán thành công.");
			}
			catch (Exception ex)
			{
				// Log lỗi và trả về lỗi chi tiết
				Console.WriteLine($"Lỗi: {ex.Message}");
				return null;
			}
		}

	}

}