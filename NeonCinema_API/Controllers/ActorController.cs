using AutoMapper;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorRepositories _reps;
        private readonly IMapper _map;
        public ActorController(IActorRepositories rep,IMapper mapper)
        {
            _reps = rep;
            _map = mapper;
        }
        [HttpGet("Get-All")]
        public async Task<IActionResult> GetAll([FromQuery]ViewActorRequest request,CancellationToken cancellationToken)
        {
            try
            {
                var actor = await _reps.GetAllActor(request, cancellationToken);
                return Ok(actor);
            }
            catch (Exception ex) 
            {
                return Content(ex.Message);
            }
        }
      
        [HttpPost("CreateActor")]
        public async Task<IActionResult> CreateActor([FromBody] CreateActorRequest request, CancellationToken cancellationToken) 
        {
            try
            {
                var obj = await _reps.CreateActor(_map.Map<Actor>(request),cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpPut("UpdateActor")]
        public async Task<IActionResult> UpdateActor([FromBody] UpdateActorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.UpdateActor(_map.Map<Actor>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
        [HttpDelete("DeleteActor")]
        public async Task<IActionResult> DeleteActor([FromBody]  DeleteActorRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _reps.DeleteActor(_map.Map<Actor>(request), cancellationToken);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
