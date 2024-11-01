//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NeonCinema_Application.DataTransferObject.Actors;
//using NeonCinema_Application.Interface.Actors;
//using NeonCinema_Domain.Database.Entities;
//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace NeonCinema_API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ActorController : ControllerBase
//    {
//        private readonly IActorRepositories _reps;

//        public ActorController(IActorRepositories rep)
//        {
//            _reps = rep;
//        }
//        [HttpGet("GetAll")]
        
//        public async Task<ActionResult<List<ActorDTO>>> GetAllActors(CancellationToken cancellationToken)
//        {
//            var actors = await _reps.GetAllActor(cancellationToken);
//            return Ok(actors);
//        }
//        [HttpGet("{id}")]
//        public async Task<ActionResult<ActorDTO>> GetActorById(Guid id, CancellationToken cancellationToken)
//        {
//            var actor = await _reps.GetActorById(id, cancellationToken);
//            if (actor == null)
//            {
//                return NotFound("Actor not found.");
//            }
//            return Ok(actor);
//        }



//        [HttpPost("Create")]
        
//        public async Task<ActionResult<ActorDTO>> CreateActor([FromBody] CreateActorRequest request, CancellationToken cancellationToken)
//        {
//            var createdActor = await _reps.CreateActor(request, cancellationToken);
//            return CreatedAtAction(nameof(GetActorById), new { id = createdActor.ID }, createdActor);
//        }


//        [HttpPut("Update/{id}")]

//        public async Task<ActionResult> UpdateActor(Guid id, [FromBody] UpdateActorRequest request, CancellationToken cancellationToken)
//        {
//            var response = await _reps.UpdateActor(id, request, cancellationToken);
//            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
//            {
//                return NotFound("Actor not found.");
//            }
//            return Ok("Actor updated successfully.");
//        }
//        [HttpDelete("Delete")]
        
//        public async Task<ActionResult> DeleteActor([FromBody] DeleteActorRequest request, CancellationToken cancellationToken)
//        {
//            var response = await _reps.DeleteActor(request, cancellationToken);
//            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
//            {
//                return NotFound("Actor not found.");
//            }
//            return Ok("Actor deleted successfully.");
//        }
//    }
//}
