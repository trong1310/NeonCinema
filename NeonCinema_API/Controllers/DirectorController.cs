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
               
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        
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
                
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        
        [HttpPost("CreateDirector")]
        public async Task<IActionResult> CreateDirector([FromBody] CreateDirectorRequest request, CancellationToken cancellationToken)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var createDRTResponse = await _reps.CreateDirector(request, cancellationToken);

                return Ok(createDRTResponse);
            }
            catch (Exception ex)
            {
                
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        
        [HttpPut("UpdateDirector/{id}")]
        public async Task<IActionResult> UpdateDirector(Guid id, [FromBody] UpdateDirectorRequest request, CancellationToken cancellationToken)
        {
            if (id != request.ID)
            {
                return BadRequest("The ID in the request does not match the ID in the route.");
            }

            try
            {
                var response = await _reps.UpdateDirector(id, request, cancellationToken);
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    return NotFound(response.Content.ReadAsStringAsync().Result);
                }
                return Ok(response.Content.ReadAsStringAsync().Result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }


    }
}
