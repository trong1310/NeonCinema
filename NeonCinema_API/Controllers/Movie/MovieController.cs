using AutoMapper;
using Bogus.Hollywood.DataSets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Interface.Movie;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers.Movie
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepositories _reps;
        private readonly IMapper _map;
        public MovieController(IMovieRepositories reps, IMapper map)
        {
            _map = map;
            _reps = reps;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get([FromQuery]ViewMovieRequest request , CancellationToken cancellationToken)
        {
            var obj = await _reps.GetAll(request, cancellationToken);
            return Ok(obj);
        }
        [HttpPost ("Create")]
        public async Task <IActionResult> Create([FromForm] CreateMovieRequest request, CancellationToken cancellationToken)
        {
            var obj = await _reps.Create(request,cancellationToken);
            return Ok(obj);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateMovieRequest request, CancellationToken cancellationToken)
        {
            var obj = await _reps.Update(_map.Map<NeonCinema_Domain.Database.Entities.Movies>(request), cancellationToken);
            return Ok(obj);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(DeleteMovieRequest request, CancellationToken cancellationToken)
        {
            var obj = await _reps.Delete(_map.Map<NeonCinema_Domain.Database.Entities.Movies>(request), cancellationToken);
            return Ok(obj);
        }
       
       
    }
}
