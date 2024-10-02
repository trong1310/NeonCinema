using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorRepositories _reps;

        public ActorController(IActorRepositories rep)
        {
            _reps = rep;
        }

        [HttpGet("Get-All")]
        public async Task<IActionResult> GetAll([FromQuery] ViewActorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var actors = await _reps.GetAllActor(cancellationToken);
                return Ok(actors);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost("CreateActor")]
        public async Task<IActionResult> CreateActor([FromBody] CreateActorRequest request, CancellationToken cancellationToken)
        {
            // Validate the request
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Directly pass the request to the repository without mapping
                var createdActorResponse = await _reps.CreateActor(request, cancellationToken);

                return CreatedAtAction(nameof(GetActorById), new { id = createdActorResponse.ID }, createdActorResponse);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("UpdateActor/{id}")]
        public async Task<IActionResult> UpdateActor(Guid id, [FromBody] UpdateActorRequest request, CancellationToken cancellationToken)
        {
            if (id != request.ID || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedActorResponse = await _reps.UpdateActor(id, request, cancellationToken);
                return Ok(updatedActorResponse);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetActorById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var actor = await _reps.GetActorById(id, cancellationToken);
                if (actor == null)
                {
                    return NotFound($"Actor with ID {id} not found.");
                }
                return Ok(actor);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
