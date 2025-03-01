﻿using iText.StyledXmlParser.Jsoup.Parser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NeonCinema_API.Controllers.Service;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System.Collections.Concurrent;
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
        private string _secretKey;
        
        //	private readonly IReCapchaRepositories _captcha;
        public LoginController(NeonCinemasContext context ,IConfiguration configuration)
        {
			_configuration = configuration;
			_context = context;
            _secretKey = configuration["Jwt:Secret"];

            //    _captcha = captcha;
        }
		private async Task<UserLoginDTO> GetUser(string emailOrPhone, string password)
		{
			var user = await _context.Users.FirstOrDefaultAsync(
				x => x.PhoneNumber == emailOrPhone  && x.PassWord == Hash.Encrypt(password)
				);
           
            var userRole = await _context.Roles.FirstOrDefaultAsync(x => x.ID == user.RoleID);
            return new UserLoginDTO
            {
                Email = user.Email,
                FullName = user.FullName,
                RoleName = userRole.RoleName,
                PhoneNumber = user.PhoneNumber,
                ID = user.ID,
                Address = user.Adderss,
                Gender = user.Gender,   
                DateOfBirth = user.DateOrBriht.ToString(),
                Password = user.PassWord,
                Images = user.Images,
            };
		}
        private string GenerateJwtToken(UserLoginDTO user)
        {
            // Lấy key từ cấu hình để mã hóa JWT
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            // Tạo claims với thông tin người dùng
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.ID.ToString()),
                new Claim(ClaimTypes.Name, user.FullName),
                new Claim(ClaimTypes.Role, user.RoleName),
                //new Claim(ClaimTypes.StreetAddress, user.Address),
                new Claim(ClaimTypes.Email, user.Email),
                //new Claim(ClaimTypes.DateOfBirth, user.DateOfBirth),
                new Claim(ClaimTypes.MobilePhone, user.PhoneNumber)   ,
				new Claim("Images", user.Images),

			};

            // Tạo token với các thông tin trên
            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:Issuer"], 
                audience: _configuration["JWT:Audience"], 
                claims: claims,
                expires: DateTime.Now.AddDays(20),   
                signingCredentials: creds); 

            // Trả về chuỗi JWT
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                if (string.IsNullOrEmpty(request.EmailOrPhone) || string.IsNullOrEmpty(request.Password))
                {
                    return BadRequest("Vui lòng nhập Email/Số điện thoại và mật khẩu.");
                }
                var userLogin = await GetUser(request.EmailOrPhone, request.Password);
                if (userLogin == null)
                {
                    return Unauthorized("Thông tin đăng nhập không chính xác.");
                }
                var oldToken = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                if (!string.IsNullOrEmpty(oldToken))
                {
                    TokenValidationMiddleware.RemoveToken(oldToken);
                }
                var newToken = GenerateJwtToken(userLogin);
                return Ok(new { Token = newToken });
            }
            catch (Exception ex)
            {
                return BadRequest($"Đã xảy ra lỗi: {ex.Message}");
            }
        }



        [HttpGet("current")]
        public  IActionResult GetCurrentUser()
        {
            var user = HttpContext.User;
            if (user.Identity.IsAuthenticated)
            {
                var userDto = new UserLoginDTO
                {
                    ID = Guid.Parse(user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value),
                    FullName = user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/name")?.Value,
                    Email = user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress")?.Value,
                    RoleName = user.FindFirst(c => c.Type == "http://schemas.microsoft.com/ws/2008/06/identity/claims/role")?.Value,
                    PhoneNumber = user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/mobilephone")?.Value,
                    //Address = user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/streetaddress")?.Value,
                    //DateOfBirth = user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/dateofbirth")?.Value,
					//Gender = user.FindFirst(c => c.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/gender")?.Value == "Nam"

				};
                return Ok(userDto);
            }
            return Unauthorized();
        }

        [Authorize]
        [HttpPut("logout")]
        public ActionResult LogOut()
        {
            try
            {
                // Lấy token từ header
                var token = HttpContext.Request.Headers["Authorization"].ToString().Replace("Bearer ", "");
                if (string.IsNullOrEmpty(token))
                {
                    return BadRequest("Token không hợp lệ.");
                }

                // Thu hồi token
                TokenValidationMiddleware.RevokeToken(token);

                return Ok("Đăng xuất thành công.");
            }
            catch (Exception ex)
            {
                return BadRequest($"Có lỗi xảy ra: {ex.Message}");
            }
        }


    }
}
