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
        [HttpGet("get-by-id")]
        public async Task<IActionResult> GetByIDUser(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIDUser(id, cancellationToken);
            if (user == null)
            {
                return NotFound($"Không tìm thấy người dùng với số điện thoại {id}.");
            }
           

            return Ok(user);
        }

    }
}
