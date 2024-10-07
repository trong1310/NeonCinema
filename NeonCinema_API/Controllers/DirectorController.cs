using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepositories _reps;

        public DirectorController(IDirectorRepositories rep)
        {
            _reps = rep;
        }
        [HttpGet("Get-All")]
        public async Task<IActionResult> GetAll([FromQuery] ViewDirectorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var drts = await _reps.GetAllDirector(cancellationToken);
                return Ok(drts);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // 2. Get Director by ID
        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetDirectorById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var DRT = await _reps.GetDirectorById(id, cancellationToken);
                if (DRT == null)
                {
                    return NotFound($"director with ID {id} not found.");
                }
                return Ok(DRT);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // 3. Create Director
        [HttpPost("CreateDirector")]
        public async Task<IActionResult> CreateDirector([FromBody] CreateDirectorRequest request, CancellationToken cancellationToken)
        {
            // Validate the request
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Directly pass the request to the repository without mapping
                var createDRTResponse = await _reps.CreateDirector(request, cancellationToken);

                return CreatedAtAction(nameof(GetDirectorById), new { id = createDRTResponse.ID }, createDRTResponse);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // 4. Update Director
        [HttpPut("UpdateDirector/{id}")]
        public async Task<IActionResult> UpdateDirector(Guid id, [FromBody] UpdateDirectorRequest request, CancellationToken cancellationToken)
        {
            if (id != request.ID || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedDRTrResponse = await _reps.UpdateDirector(id, request, cancellationToken);
                return Ok(updatedDRTrResponse);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


    }
}
