using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShowRelease;
using NeonCinema_Application.Interface.ShowReleases;
using NeonCinema_Application.Pagination;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowReleaseController : ControllerBase
    {
        private readonly IShowReleaseRepository _showReleaseRepository;

        public ShowReleaseController(IShowReleaseRepository showReleaseRepository)
        {
            _showReleaseRepository = showReleaseRepository;
        }

        // Get all ShowReleases with pagination
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request)
        {
            var result = await _showReleaseRepository.GetAllAsync(request);
            return Ok(result);
        }

        // Get ShowRelease by ID
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var showRelease = await _showReleaseRepository.GetByIdAsync(id);
            if (showRelease == null)
            {
                return NotFound("ShowRelease not found.");
            }
            return Ok(showRelease);
        }

        // Create new ShowRelease
        [HttpPost("create-ShowRelease")]
        public async Task<IActionResult> Create(CreateShowReleaseDTO createDto)
        {
            if (!createDto.IsValid())
            {
                return BadRequest("Invalid data.");
            }

            await _showReleaseRepository.AddAsync(createDto);
            return CreatedAtAction(nameof(GetById), new { id = createDto.MovieID }, createDto);
        }

        // Update existing ShowRelease
        [HttpPut("update-showrelease")]
        public async Task<IActionResult> Update(Guid id, UpdateShowReleaseDTO updateDto)
        {
            if (!updateDto.IsValid())
            {
                return BadRequest("Invalid data.");
            }

            var existingShowRelease = await _showReleaseRepository.GetByIdAsync(id);
            if (existingShowRelease == null)
            {
                return NotFound("ShowRelease not found.");
            }

            await _showReleaseRepository.UpdateAsync(updateDto);
            return NoContent();
        }

        // Delete ShowRelease by ID
        [HttpDelete("delete-showralease")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var showRelease = await _showReleaseRepository.GetByIdAsync(id);
            if (showRelease == null)
            {
                return NotFound("ShowRelease not found.");
            }

            await _showReleaseRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
