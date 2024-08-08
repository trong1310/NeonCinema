using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.MovieType;
using NeonCinema_Application.Interface.Moviess;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieTypeController : ControllerBase
    {
        private readonly IMovieTypeRepository _reps;
        private readonly IMapper _map;
        [HttpGet("Getall-MovieType")]
        public async Task<IActionResult> GetAll([FromQuery] MovieTypeDTO request , CancellationToken cancellationToken)
        {
            var movieTypes = await _reps.GetAll(cancellationToken);
            return Ok(movieTypes);

        }
        [HttpPost("Create-MovieType")]
        public async Task<IActionResult> Create([FromBody]MovieTypeCreateRequest request , CancellationToken cancellationToken)
        {
            var movieType = _reps.Create(_map.Map<MovieType>(request), cancellationToken);
            return Ok(movieType);
        }
        [HttpPost("Update-MovieType")]
        public async Task<IActionResult> Update([FromBody] MovieTypeUpdateRequest request, CancellationToken cancellationToken)
        {
            var movieType = _reps.Update(_map.Map<MovieType>(request), cancellationToken);
            return Ok(movieType);
        }
        [HttpPost("Delete-MovieType")]
        public async Task<IActionResult> Delete([FromBody] MovieTypeDeleteRequets request, CancellationToken cancellationToken)
        {
            var movieType = _reps.Delete(_map.Map<MovieType>(request), cancellationToken);
            return Ok(movieType);
        }
    }
}
