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
        [HttpPost]
        [Route("create")]
        public async Task<IActionResult> CreateRoom([FromBody] RoomCreateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Request cannot be null.");
            }
            // Gán CinemaID mặc định
            request.CinemasID = Guid.Parse("6cf8d373-0533-484c-bcc3-63801334fff6");
            var response = await _roomRepository.CreateRoom(request, cancellationToken);
            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }

        [HttpGet]
        [Route("all")]
        public async Task<IActionResult> GetAllRooms(CancellationToken cancellationToken)
        {
            var rooms = await _roomRepository.GetAllRooms(cancellationToken);
            return Ok(rooms); // Trả về danh sách phòng
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRoomById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var room = await _roomRepository.GetByIDRoom(id, cancellationToken);
                return Ok(room); // Trả về thông tin phòng
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Room with ID {id} not found."); // Trả về 404 nếu không tìm thấy
            }
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateRoom(Guid id, [FromBody] RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var response = await _roomRepository.UpdateRoom(id, request, cancellationToken);
            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }

    }
}
