using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Application.Interface.WorkShidt;
using System.Net;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkShiftController : ControllerBase
    {
        private readonly IWorkShiftRepository _repo;
        public WorkShiftController(IWorkShiftRepository repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public async Task<IActionResult> CreateWorkShift([FromBody] WorkShiftCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.CreateWorkShift(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return CreatedAtAction(nameof(GetByIDWorkShift), new { id = response.Content.ReadAsStringAsync().Result }, request);
            }

            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWorkShift(Guid id, [FromBody] WorkShiftUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.UpdateWorkShift(id, request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.Content.ReadAsStringAsync().Result);
            }

            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllWorkShift(CancellationToken cancellationToken)
        {
            var workShifts = await _repo.GetAllWorkShift(cancellationToken);
            return Ok(workShifts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDWorkShift(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var workShift = await _repo.GetByIDWorkShift(id, cancellationToken);
                return Ok(workShift);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Work shift not found.");
            }
        }
    }
}
