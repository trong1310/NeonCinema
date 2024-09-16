using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.TicketSeats;
using NeonCinema_Application.Interface.TicketSeats;
using NeonCinema_Application.Pagination;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketSeatController : ControllerBase
    {
        private readonly ITicketSeatRepository _ticketSeatRepository;

        public TicketSeatController(ITicketSeatRepository ticketSeatRepository)
        {
            _ticketSeatRepository = ticketSeatRepository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request)
        {
            var ticketSeats = await _ticketSeatRepository.GetAllAsync(request);
            return Ok(ticketSeats);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var ticketSeat = await _ticketSeatRepository.GetByIdAsync(id);
            return Ok(ticketSeat);
        }

        [HttpPost("add-ticketseat")]
        public async Task<IActionResult> Create([FromBody] CreateTicketSeatDTO dto)
        {
            try
            {
                await _ticketSeatRepository.AddAsync(dto);
                return CreatedAtAction(nameof(GetById), new { id = dto.SeatID }, dto);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPut("update-ticketseat")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateTicketSeatDTO dto)
        {
            try
            {
                if (id != dto.ID)
                {
                    return BadRequest(new { message = "ID mismatch" });
                }

                await _ticketSeatRepository.UpdateAsync(dto);
                return NoContent();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }

        [HttpDelete("delete-ticketseat")]
        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _ticketSeatRepository.DeleteAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }
}
