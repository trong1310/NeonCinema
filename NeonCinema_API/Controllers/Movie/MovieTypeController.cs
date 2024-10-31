using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers.Movie
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieTypeController : ControllerBase
    {
        private readonly IMovieTypeRepositories _reps;

        public MovieTypeController(IMovieTypeRepositories repo)
        {
            _reps = repo;
        }
        [HttpGet("Get-All")]
        public async Task<IActionResult> GetAll([FromQuery] CancellationToken cancellationToken)
        {
            try
            {
                var mvt = await _reps.GetAllMovieType(cancellationToken);
                return Ok(mvt);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost("CreateMovieType")]
        public async Task<IActionResult> CreateMovieType([FromBody] CreateMovieTypeRequest request, CancellationToken cancellationToken)
        {
            // Validate the request
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Directly pass the request to the repository without mapping
                var createMovieTypeResponse = await _reps.CreateMovieType(request, cancellationToken);

                return CreatedAtAction(nameof(GetMovieeTypeById), new { id = createMovieTypeResponse.ID }, createMovieTypeResponse);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetMovieeTypeById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var MVT = await _reps.GetMovieTypeById(id, cancellationToken);
                if (MVT == null)
                {
                    return NotFound($"Actor with ID {id} not found.");
                }
                return Ok(MVT);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPut("UpdateMovieTYpe/{id}")]
        public async Task<IActionResult> UpdateMVT(Guid id, [FromBody] UpdateMovieTypeRequest request, CancellationToken cancellationToken)
        {
            if (id != request.ID || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedActorResponse = await _reps.UpdateMovieType(id, request, cancellationToken);
                return Ok(updatedActorResponse);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
