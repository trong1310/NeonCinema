using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Implement.Seats;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly ISeatRepository _repo;

        private readonly IMapper _mapper;
        public SeatController(ISeatRepository repo, IMapper mapper)
        {
                _repo = repo;
            _mapper = mapper;
        }
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request)
        {
            var seats = await _repo.GetAllAsync(request); // Get PaginationResponse<TicketSeatDTO>

            // Map only the list of seats (Data) to SeatDTO
            var seatDtos = _mapper.Map<List<SeatDTO>>(seats.Data);

            // Return the PaginationResponse, with the mapped Data (seatDtos)
            var result = new PaginationResponse<SeatDTO>
            {
                PageNumber = seats.PageNumber,
                PageSize = seats.PageSize,
                HasNext = seats.HasNext,
                Data = seatDtos
            };

            return Ok(result);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var seat = await _repo.GetByIdAsync(id);
            if (seat == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<SeatDTO>(seat);
            return Ok(result);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] CreateSeatDTO createSeatDTO)
        {
            var seat = _mapper.Map<Seat>(createSeatDTO);
            await _repo.AddAsync(seat);
            return CreatedAtAction(nameof(GetById), new { id = seat.ID }, seat);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSeatDTO updateSeatDTO)
        {
            var seat = await _repo.GetByIdAsync(id);
            if (seat == null)
            {
                return NotFound();
            }
            _mapper.Map(updateSeatDTO, seat);
            await _repo.UpdateAsync(seat);
            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _repo.DeleteAsync(id);
            return NoContent();
        }
    }
}
