using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShowDate;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.ShowTime;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowTimeController : ControllerBase
    {
        private readonly IShowTimeRepository _showTimeRepository;
        private readonly IMapper _mapper;

        public ShowTimeController(IShowTimeRepository showTimeRepository, IMapper mapper)
        {
            _showTimeRepository = showTimeRepository;
            _mapper = mapper;
        }

        // GET: api/showtime/get-all-showtime
        [HttpGet("get-all-showtime")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var result = await _showTimeRepository.GetAllShowTime(cancellationToken);
            return Ok(result);
        }

        // POST: api/showtime/create-showtime
        [HttpPost("create-showtime")]
        public async Task<IActionResult> Create([FromBody] ShowTimeCreateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Invalid data.");
            }

            try
            {
                var response = await _showTimeRepository.CreateShowTime(request, cancellationToken);
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return BadRequest($"Error occurred: {ex.Message}");
            }
        }

        // PUT: api/showtime/update-showtime/{id}
        [HttpPut("update-showtime/{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ShowTimeUpdateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Invalid data.");
            }

            try
            {
                var response = await _showTimeRepository.UpdateShowTime(id, request, cancellationToken);
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return BadRequest($"Error occurred: {ex.Message}");
            }
        }

        // DELETE: api/showtime/delete-showtime/{id}
        [HttpDelete("delete-showtime/{id}")]
        public async Task<IActionResult> Delete(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _showTimeRepository.DeleteShowTime(id, cancellationToken);
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                return BadRequest($"Error occurred: {ex.Message}");
            }
        }

        // GET: api/showtime/get-showtime-by-id/{id}
        [HttpGet("get-showtime-by-id/{id}")]
        public async Task<IActionResult> GetShowTime(Guid id, CancellationToken cancellationToken)
        {
            var result = await _showTimeRepository.GetByIDShowTime(id, cancellationToken);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
