using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.Interface.IBookingHistory;

namespace NeonCinema_API.Controllers.BookHistory
{
	[Route("api/[controller]")]
	[ApiController]
	public class HistoryController : ControllerBase
	{
		private readonly IHistoryRepository _service;
		public HistoryController(IHistoryRepository service)
		{
			_service = service;
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
		




	}
}
