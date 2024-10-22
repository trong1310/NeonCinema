using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.Interface.Room;
using System.Net;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IRoomRepository _roomRepository;

        public RoomController(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        // POST: api/Room
        [HttpPost("create")]
        public async Task<IActionResult> CreateRoom([FromBody] RoomCreateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Request cannot be null.");
            }
            
           
            var response = await _roomRepository.CreateRoom(request, cancellationToken);
            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }

        // GET: api/Room
        [HttpGet("getall")]
        public async Task<IActionResult> GetAllRooms(CancellationToken cancellationToken)
        {
            var rooms = await _roomRepository.GetAllRooms(cancellationToken);
            return Ok(rooms);
        }

        // GET: api/Room/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomById(Guid id, CancellationToken cancellationToken)
        {
            var room = await _roomRepository.GetByIDRoom(id, cancellationToken);
            if (room == null)
                return NotFound();

            return Ok(room);
        }

        // PUT: api/Room/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRoom(Guid id, [FromBody] RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _roomRepository.UpdateRoom(id, request, cancellationToken);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
                return Ok();

            return StatusCode((int)response.StatusCode, response.ReasonPhrase);
        }

    }
}
