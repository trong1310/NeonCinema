using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Implement.BookTickets;
using System.Net;
using System.Text.Json;
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
		public BookTicketController(BookTicketResp bookTicketResp, IMapper map, NeonCinemasContext context)
		{
			_bookTicketResp = bookTicketResp;
			_mapper = map;
			_context = context;
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

		[HttpGet("/stream-seat-status")] // Đặt đường dẫn API
		//[Authorize]		
		
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

						await Response.WriteAsync($"data: {eventData}\n\n", cancellationToken);
						await Response.Body.FlushAsync(cancellationToken);
					}

					// Tạm dừng 1 giây trước khi gửi dữ liệu tiếp theo
					await Task.Delay(1000, cancellationToken);
				}
			}
			catch (TaskCanceledException)
			{
				// Xử lý khi yêu cầu bị hủy bỏ
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

	}
}
