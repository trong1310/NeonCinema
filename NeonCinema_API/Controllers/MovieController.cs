using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;  

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _reps;
        private readonly IMapper _mapper;
        public MovieController(IMovieRepository reps, IMapper mapper)
        {
            _mapper = mapper;

            _reps = reps;
        }
        [HttpGet("getall-mmovies")]
        public async Task<IActionResult> GetAllMovies([FromQuery] MovieViewRequets requets, CancellationToken cancellationToken)
        {
            var result = await _reps.GetAllMovies(requets, cancellationToken);
            return Ok(result);
        }
        [HttpPost("create-movies")]
        public async Task<IActionResult> Create([FromBody] MovieCreateRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.CreateMovie(_mapper.Map<Movies>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut("update-movies")]
        public async Task<IActionResult> Update([FromBody] MovieUpdateRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.UpdateMovie(_mapper.Map<Movies>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody] MovieDeleteRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.DeleteMovie(_mapper.Map<Movies>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
