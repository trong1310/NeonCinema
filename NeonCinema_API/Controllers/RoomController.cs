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
        [HttpPost("create")]
        public async Task<IActionResult> CreateRoom([FromBody] RoomCreateRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _roomRepository.CreateRoom(request, cancellationToken);
            if (response.StatusCode == HttpStatusCode.Created)
                return CreatedAtAction(nameof(GetRoomById), new { id = request.CinemasId }, null);

            return StatusCode((int)response.StatusCode, "Failed to create room");
        }

        [HttpGet("all")]
        public async Task<IActionResult> GetAllRooms(CancellationToken cancellationToken)
        {
            var rooms = await _roomRepository.GetAllRooms(cancellationToken);
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoomById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var room = await _roomRepository.GetByIDRoom(id, cancellationToken);
                return Ok(room);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Room not found");
            }
        }

        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateRoom(Guid id, [FromBody] RoomUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var response = await _roomRepository.UpdateRoom(id, request);
            if (response.StatusCode == HttpStatusCode.OK)
                return Ok("Room updated successfully");

            return StatusCode((int)response.StatusCode, "Failed to update room");
        }


        [HttpGet("GetSeatsByRoomId/{roomId}")]
        public async Task<IActionResult> GetSeatsByRoomId(Guid roomId, CancellationToken cancellationToken)
        {
            if (roomId == Guid.Empty)
            {
                return BadRequest("Invalid room ID");
            }

            try
            {
                
                var seats = await _roomRepository.GetSeatsByRoomId(roomId, cancellationToken);

                if (seats == null || seats.Count == 0)
                {
                    return NotFound("No seats found for this room.");
                }

                return Ok(seats);  
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, $"An error occurred: {ex.Message}");
            }
        }

    }
}
