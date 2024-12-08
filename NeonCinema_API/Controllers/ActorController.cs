using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ActorMoives;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Implement.Acotr;
using NeonCinema_Infrastructure.Implement.ActorMovies;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly ActorResp _reps;
        private readonly ActorMoviesResp _actormovies;

        public ActorController(ActorResp rep, ActorMoviesResp actorMoviesResp)
        {
            _actormovies = actorMoviesResp;
            _reps = rep;
        }
        [HttpGet("getactor")]
        public async Task<IActionResult> GetActor([FromQuery] ViewActorRequest request, CancellationToken cancellationToken)
        {
            var obj = await _reps.Get(request, cancellationToken);
            return Ok(obj);
        }
		[HttpGet("get-actor-byflims")]
		public async Task<IActionResult> FilterActorByFilms([FromQuery]Guid movieID,  CancellationToken cancellationToken)
		{
			var obj = await _actormovies.GetActorsByFilmAsync(movieID,cancellationToken);
			return Ok(obj);
		}
		[HttpPost("createActormovies")]
        public async Task<IActionResult> CreateActorMovie([FromBody] CreateActorMoviesRequest request, CancellationToken cancellationToken)
        {
            var obj = await _actormovies.CreateActorMovies(request, cancellationToken);
            return Ok(obj);
        }
        [HttpPost("createActor")]
        public async Task<IActionResult> CreateActor(CreateActorRequest request, CancellationToken cancellationToken)
        {
            var obj = await _reps.CreateActor(request, cancellationToken);
            return Ok(obj);
        }
		[HttpPost("update-movie-actors/{movieId}")]
		public async Task<IActionResult> UpdateMovieActors(Guid movieId, [FromBody] List<Guid> actorIds)
		{
			if (actorIds == null || !actorIds.Any())
			{
				return BadRequest("Danh sách diễn viên không hợp lệ.");
			}

			var result = await _actormovies.UpdateMovieActorsAsync(movieId, actorIds);

			if (result)
			{
				return Ok(new { Message = "Cập nhật danh sách diễn viên thành công." });
			}

			return BadRequest("Cập nhật danh sách diễn viên thất bại.");
		}
	}
}
