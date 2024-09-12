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
        [HttpGet]
        
        public async Task<ActionResult<List<RoomDTO>>> GetAllRooms(CancellationToken cancellationToken)
        {
            try
            {
                var rooms = await _roomRepository.GetAllRoom(cancellationToken);
                return Ok(rooms);
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (ex)
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi khi lấy danh sách phòng.");
            }
        }
        // GET: api/room/{id}
        [HttpGet("{id}")]
        
        public async Task<ActionResult<RoomDTO>> GetRoomById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var room = await _roomRepository.GetByIDRoom(id, cancellationToken);
                return Ok(room);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Phòng không tìm thấy.");
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (ex)
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi khi lấy thông tin phòng.");
            }
        }
        // POST: api/room
        [HttpPost]
        
        public async Task<ActionResult> CreateRoom([FromBody] RoomCreateRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var response = await _roomRepository.CreateRoom(request, cancellationToken);
                if (response.StatusCode == HttpStatusCode.Created)
                {
                    return CreatedAtAction(nameof(GetRoomById), new { id = request.ID }, request);
                }
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (ex)
                 //Console.WriteLine($"Error occurred: {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi khi tạo phòng.");
            }
        }
        // PUT: api/room/{id}
        [HttpPut("{id}")]
        
        public async Task<ActionResult> UpdateRoom(Guid id, [FromBody] RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var response = await _roomRepository.UpdateRoom(id, request, cancellationToken);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return Ok("Phòng đã được cập nhật thành công.");
                }
                return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Phòng không tìm thấy.");
            }
            catch (Exception ex)
            {
                // Ghi log lỗi (ex)
                return StatusCode(StatusCodes.Status500InternalServerError, "Đã xảy ra lỗi khi cập nhật phòng.");
            }
        }
    }
}
