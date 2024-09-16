using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class LoginController : ControllerBase
	{
		private readonly IConfiguration _configuration;
		private readonly NeonCinemasContext _context;
	//	private readonly IReCapchaRepositories _captcha;
        public LoginController(IConfiguration configuration)
        {
			_configuration = configuration;
			_context = new NeonCinemasContext();
        //    _captcha = captcha;
        }
		private async Task<LoginDTO> GetUser(string emailOrPhone, string password)
		{
			var user = await _context.Users.FirstOrDefaultAsync(
				x => x.PhoneNumber == emailOrPhone || x.Email == emailOrPhone);
			var userRole = await _context.Roles.FirstOrDefaultAsync(x => x.ID == user.RoleID);
			return new LoginDTO
			{
				Email = user.Email,
				FullName = user.FullName,
				RoleName = userRole.RoleName,
				PhoneNumber = user.PhoneNumber,
				ID = user.ID,
			};
		}
		private string GenerateJwtToken(LoginDTO user)
		{
			var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
			var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

			var claims = new[]
			{
			new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
			new Claim(ClaimTypes.Name, user.FullName),
			new Claim(ClaimTypes.Role, user.RoleName),
			new Claim(ClaimTypes.OtherPhone , user.PhoneNumber),
		};

			var token = new JwtSecurityToken(
				_configuration["JWT:Issuer"],
				_configuration["JWT:Audience"],
				claims,
				expires: DateTime.Now.AddMinutes(120),
				signingCredentials: creds);

			return new JwtSecurityTokenHandler().WriteToken(token);
		}
		[HttpPost("Login")]
		public async Task<IActionResult> Login([FromBody] LoginRequest request)
		{
			try
			{
				
				if (String.IsNullOrEmpty(request.EmailOrPhone) || String.IsNullOrEmpty(request.Password))
				{
					return BadRequest("Vui lòng nhập Email/Số điện thoại và mật khẩu.");
				}
                //var captchaClient = request.ReCaptcha;
                //var checkCaptcha = await _captcha.VerifyToken(captchaClient);
                //if (!checkCaptcha)
                //{
                //    return ("Captcha không đúng vui lòng thử lại");
                //}
                var userLogin = await GetUser(request.EmailOrPhone,request.Password);
				if (userLogin == null )
				{
					return Unauthorized();
				}
				var token = GenerateJwtToken(userLogin);
				return Ok( token);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}
    }
}
