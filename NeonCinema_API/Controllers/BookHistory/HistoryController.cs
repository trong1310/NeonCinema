using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.Interface.IBookingHistory;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;

namespace NeonCinema_API.Controllers.BookHistory
{
	[Route("api/[controller]")]
	[ApiController]
	public class HistoryController : ControllerBase
	{
		private readonly IHistoryRepository _service;
		private readonly NeonCinemasContext _context;
		public HistoryController(IHistoryRepository service, NeonCinemasContext context)
		{
			_service = service;
			_context = context;
		}
		[HttpGet("bookings/{userId}")]
		public async Task<IActionResult> GetBookingHistory(Guid userId)
		{
			var history = await _service.GetBookingHistoryAsync(userId);
			return Ok(history);
		}

		[HttpGet("bills/{userId}")]
		public async Task<IActionResult> GetBillHistory(Guid userId)
		{
			var history = await _service.GetBillHistoryAsync(userId);
			return Ok(history);
		}
		[HttpGet("admin/bookings")]
		public async Task<IActionResult> GetAllBookingHistory([FromQuery] string userName = null, [FromQuery] string movieName = null)
		{
			var history = await _service.GetAllBookingHistoryAsync();

			// Bộ lọc theo tên người dùng hoặc tên phim nếu có
			if (!string.IsNullOrEmpty(userName))
			{
				history = history.Where(h => h.UserName.Contains(userName, StringComparison.OrdinalIgnoreCase)).ToList();
			}
			if (!string.IsNullOrEmpty(movieName))
			{
				history = history.Where(h => h.MovieName.Contains(movieName, StringComparison.OrdinalIgnoreCase)).ToList();
			}

			return Ok(history);
		}

		[HttpGet("admin/bills")]
		public async Task<IActionResult> GetAllBillHistory([FromQuery] string userName = null)
		{
			var history = await _service.GetAllBillHistoryAsync();

			// Bộ lọc theo tên người dùng nếu có
			if (!string.IsNullOrEmpty(userName))
			{
				history = history.Where(h => h.UserName.Contains(userName, StringComparison.OrdinalIgnoreCase)).ToList();
			}

			return Ok(history);
		}
		// PUT: api/History/updateStatusToPaid/{billId}
		[HttpPut("updateStatusToPaid/{billId}")]
		public async Task<IActionResult> UpdateStatusToPaid(Guid billId)
		{
			// Tìm hóa đơn theo billId
			var bill = await _context.BillDetails.FindAsync(billId);
			if (bill == null)
			{
				return NotFound("Không tìm thấy Bill với ID này.");
			}

			// Chỉ cho phép chuyển từ checkin -> paid
			if (bill.Status == ticketEnum.checkin)
			{
				bill.Status = ticketEnum.paid;
				_context.Update(bill);
				await _context.SaveChangesAsync();
				return Ok(); // 200 OK
			}

			return BadRequest("Bill không ở trạng thái checkin.");
		}






	}
}
