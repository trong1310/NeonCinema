using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.Interface.Movies;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers.Movies
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieTypeController : ControllerBase
	{
		private readonly IMovieTypeRepositories _reps;
		private readonly IMapper _map;
        public MovieTypeController(IMovieTypeRepositories reps, IMapper map)
		{
            _reps = reps;
			_map = map;
        }
		[HttpGet("Get-All")]
		public async Task<IActionResult> GetAll(MovieTypeDTO request, CancellationToken cancellationToken) 
		{
			var obj = await _reps.GetAll(request, cancellationToken);
			return Ok(obj);
		}
		[HttpPost("Create")]
		public async Task<IActionResult> Create(CreateMovieTypeRequest request, CancellationToken cancellationToken) 
		{
			var obj = await _reps.Create(_map.Map<MovieType>(request), cancellationToken);
			return Ok(obj);

		}
		[HttpPut("Update")]
		public async Task<IActionResult> Update(UpdateMovieTypeRequest request, CancellationToken cancellationToken)
		{
			var obj = await _reps.Update(_map.Map<MovieType>(request), cancellationToken);
			return Ok(obj);
		}
		[HttpDelete]
		public async Task<IActionResult> Delete(DeleteMovieTypeRequest request, CancellationToken cancellationToken)
		{
			var obj = await _reps.Delete(_map.Map<MovieType>(request), cancellationToken);
			return Ok(obj);

		}
	}
}
