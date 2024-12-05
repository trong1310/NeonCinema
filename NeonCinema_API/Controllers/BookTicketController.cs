using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Implement.BookTickets;
using System.Net;

namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class BookTicketController : ControllerBase
    {
        private readonly BookTicketResp _bookTicketResp;
        private readonly IMapper _mapper;
        private readonly NeonCinemasContext _context;
        public BookTicketController(BookTicketResp bookTicketResp, IMapper map,NeonCinemasContext context)
        {
            _bookTicketResp = bookTicketResp;
            _mapper = map;
            _context = context;
        }
        // Đặt vé cho khách hàng
        [HttpPost("book-ticket")]
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
        public async Task<IActionResult> GetScreeningMovies(Guid movieId,DateTime?showDate)
        {
            try
            {
                var screeningMovies = await _bookTicketResp.GetScreeningMovies(movieId,showDate);
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


	}
}
