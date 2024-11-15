using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Implement.BookTickets;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookTicketController : ControllerBase
    {
        private readonly BookTicketResp _reps;
        private readonly IMapper _mapper;
        public BookTicketController(BookTicketResp reps,IMapper map)
        {
           _reps = reps;
            _mapper = map;
        }
        [HttpPost("Bookticket")]
        public async Task<IActionResult> BookTicket([FromBody]CreateBookTicketRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var respone = await _reps.BookTicketCounter(request, cancellationToken);
                return Ok(respone);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("ScreeningByflims")]
		public async Task<IActionResult> ScreeningByFilms([FromQuery] Guid moviesID, CancellationToken cancellationToken)
		{
			try
			{
                var respone = await _reps.GetScreeningMovies(moviesID);
				return Ok(respone);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
		[HttpGet("AccountByPhone")]
		public async Task<IActionResult> AccountByPhone([FromQuery] string phone, CancellationToken cancellationToken)
		{
			try
			{
				var respone = await _reps.GetAccountByPhone(phone,cancellationToken);
				return Ok(respone);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

	}
}
