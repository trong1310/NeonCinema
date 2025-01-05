using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeonCinema_API.Controllers.Service;
using NeonCinema_Application.DataTransferObject.ActorMoives;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
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
        private readonly NeonCinemasContext _context;

        public ActorController(ActorResp rep, ActorMoviesResp actorMoviesResp, NeonCinemasContext context)
        {
            _actormovies = actorMoviesResp;
            _reps = rep;
            _context = context;
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
        public async Task<IActionResult> CreateActor([FromBody] ActorCreateRequest request)
        {
            try
            {
                var actor = new Actor()
                {
                    ID = Guid.NewGuid(),
                    Name = request.Name,
                    Sex = request.Sex,
                    Status = EntityStatus.Inactive
                };
                await _context.Actor.AddAsync(actor);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Tạo diễn viên thành công!", Name = actor.Name });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [HttpPut("Update-Actor")]
        public async Task<IActionResult> UpdateActor([FromBody] UpdateActorRequests request)
        {
            try
            {
                var actor = await _context.Actor.FirstOrDefaultAsync(x => x.ID == request.id);
                actor.Name = request.name;
                actor.Sex = request.sex;
                actor.Status = request.status;
                _context.Actor.Update(actor);
                await _context.SaveChangesAsync();
                return Ok(new { message = "Cập nhật diễn viên thành công!"});
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [HttpGet("GetAll-Actor")]
        public async Task<IActionResult> GetAllActor()
        {
            try
            {
                var actor = await _context.Actor.Where(x => x.Status != EntityStatus.Locked).ToListAsync();
                return Ok(actor);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [HttpGet("Get-Actor-Id")]
        public async Task<IActionResult> GetIdActoe(Guid Id)
        {
            var actor = await _context.Actor.FirstOrDefaultAsync(x => x.ID == Id);
            return Ok(actor);
        }
	}
}
