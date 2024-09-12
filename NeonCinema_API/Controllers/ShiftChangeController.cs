using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShiftChange;
using NeonCinema_Application.Interface.ShiftChange;
using System.Net;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftChangeController : ControllerBase
    {
        private readonly IShiftChangeRepository _repo;

        public ShiftChangeController(IShiftChangeRepository repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> CreateShiftChange([FromBody] ShiftChangeCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.CreateShiftChange(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Created)
            {
                return CreatedAtAction(nameof(GetByIDShiftChange), new { id = request.ID }, request);
            }
            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }

        [HttpGet]
        public async Task<ActionResult<List<ShiftChangeDTO>>> GetAllShiftChange(CancellationToken cancellationToken)
        {
            var shiftChanges = await _repo.GetAllShiftChange(cancellationToken);
            return Ok(shiftChanges);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ShiftChangeDTO>> GetByIDShiftChange(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var shiftChange = await _repo.GetByIDShiftChange(id, cancellationToken);
                return Ok(shiftChange);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Shift change not found.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShiftChange(Guid id, [FromBody] ShiftChangeUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.UpdateShiftChange(id, request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(await response.Content.ReadAsStringAsync());
            }
            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }
    }
}
