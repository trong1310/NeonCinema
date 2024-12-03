    using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_API.SendMail;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.Users;
using System.Net;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ISendMailService _emailService;
        public UserController(IUserRepository us, ISendMailService emailService)
        {
            _userRepository = us;
            _emailService = emailService;
        }


        [HttpPost("create-client")]
        public async Task<IActionResult> CreateClient([FromBody] UserCreateRequest request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.CreateClient(request, cancellationToken);
            if (result.HttpResponse.StatusCode == HttpStatusCode.OK)
            {
                var password = string.IsNullOrEmpty(request.PassWord)
                      ? result.GeneratedPassword
                      : request.PassWord;
                // Nội dung email
                var emailContent = NeonCinema_API.SendMail.Template.CreateUser.CreateClient(request.FullName, request.Email, password);

                // Gửi email
                await _emailService.SendEmailAsync(request.Email, "Tạo tài khoản thành công", emailContent);
            }
            return Ok(result);
        }


        [HttpPost("create")]
        public async Task<IActionResult> CreateUser([FromBody]UserCreateRequest request, CancellationToken cancellationToken)
        {
            var result = await _userRepository.CreateUser(request, cancellationToken);
            if (result.HttpResponse.StatusCode == HttpStatusCode.OK)
            {
                var password = string.IsNullOrEmpty(request.PassWord)
                      ? result.GeneratedPassword
                      : request.PassWord;
                // Nội dung email
                var emailContent = NeonCinema_API.SendMail.Template.CreateUser.CreateStaff(request.FullName, request.Email, password);

                // Gửi email
                await _emailService.SendEmailAsync(request.Email, "Tạo tài khoản thành công", emailContent);
            }
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
