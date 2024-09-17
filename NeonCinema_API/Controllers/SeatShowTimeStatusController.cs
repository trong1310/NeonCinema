using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.SeatShowTimeStatus;
using NeonCinema_Application.Interface.SeatShowTimeStatus;
using NeonCinema_Application.Pagination;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatShowTimeStatusController : ControllerBase
    {
        private readonly ISeatShowTimeStatusRepository _seatShowTimeStatusRepository;

        public SeatShowTimeStatusController(ISeatShowTimeStatusRepository seatShowTimeStatusRepository)
        {
            _seatShowTimeStatusRepository = seatShowTimeStatusRepository;
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request)
        {
            // Kiểm tra số trang và kích thước trang có hợp lệ không
            if (request.PageNumber <= 0 || request.PageSize <= 0)
            {
                return BadRequest("PageNumber and PageSize must be greater than zero.");
            }

            var response = await _seatShowTimeStatusRepository.GetAllAsync(request);
            return Ok(response);
        }

        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("Invalid ID.");
            }

            var seatShowTimeStatus = await _seatShowTimeStatusRepository.GetByIdAsync(id);
            return Ok(seatShowTimeStatus);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Add([FromBody] CreateSeatShowTimeStatusDTO createSeatShowTimeStatusDTO)
        {
            if (createSeatShowTimeStatusDTO.SeatID == Guid.Empty || createSeatShowTimeStatusDTO.ShowTime == null)
            {
                return BadRequest("SeatId and ShowTimeId cannot be empty.");
            }
            if (createSeatShowTimeStatusDTO.Status == null)
            {
                return BadRequest("Status is required.");
            }

            await _seatShowTimeStatusRepository.AddAsync(createSeatShowTimeStatusDTO);
            return Ok(new { message = "Seat_ShowTime_Status added successfully" });
        }

        [HttpPut("update-showtime")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSeatShowTimeStatusDTO updateSeatShowTimeStatusDTO)
        {
            if (id != updateSeatShowTimeStatusDTO.ID)
            {
                return BadRequest("ID mismatch.");
            }
            if (updateSeatShowTimeStatusDTO.SeatID == Guid.Empty || updateSeatShowTimeStatusDTO.ShowTime == null)
            {
                return BadRequest("SeatId and ShowTimeId cannot be empty.");
            }
            if (updateSeatShowTimeStatusDTO.Status == null)
            {
                return BadRequest("Status is required.");
            }

            await _seatShowTimeStatusRepository.UpdateAsync(updateSeatShowTimeStatusDTO);
            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            if (id == Guid.Empty)
            {
                return BadRequest("Invalid ID.");
            }

            await _seatShowTimeStatusRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
