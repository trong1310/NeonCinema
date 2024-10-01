using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.Users;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository us)
        {
            _userRepository = us;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromForm] UserCreateRequest request, CancellationToken cancellationToken)
        {

            var result = await _userRepository.CreateUser(request, cancellationToken);

            return Ok(result);
        }
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateUser(Guid id, [FromBody] UserUpdateRequest request, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userRepository.UpdateUser(id, request, cancellationToken);
            if (result.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound(result.Content.ReadAsStringAsync().Result);
            }

            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return BadRequest(result.Content.ReadAsStringAsync().Result);
            }

            return Ok("Cập nhật người dùng thành công!");
        }
        [HttpGet("get-all")]
        
        public async Task<IActionResult> GetAllUser(CancellationToken cancellationToken)
        {
            var users = await _userRepository.GetAllUser(cancellationToken);
            if (users == null || users.Count == 0)
            {
                return NotFound("Không có người dùng nào.");
            }

            return Ok(users);
        }
        [HttpGet("get-by-phone/{phoneNumber}")]
        public async Task<IActionResult> GetByIDUser(string phoneNumber, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIDUser(phoneNumber, cancellationToken);
            if (user == null)
            {
                return NotFound($"Không tìm thấy người dùng với số điện thoại {phoneNumber}.");
            }
           

            return Ok(user);
        }

    }
}
