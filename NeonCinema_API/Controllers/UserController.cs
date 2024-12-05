﻿    using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeonCinema_API.Controllers.Service;
using NeonCinema_API.SendMail;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.DataTransferObject.User.Request;
using NeonCinema_Application.Interface.Users;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly ISendMailService _emailService;
        private readonly NeonCinemasContext _context;
        private readonly IUserServices _userService;
        public UserController(IUserRepository us, ISendMailService emailService, NeonCinemasContext context, IUserServices userService)
        {
            _userRepository = us;
            _emailService = emailService;
            _context = context;
            _userService = userService;
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
        [Authorize]
        [HttpGet("user-check-tickets")]
        public async Task<IActionResult> GetUserTickets(CancellationToken cancellationToken)
        {
            try
            {
                var user = HttpContext.User;
                if (!user.Identity.IsAuthenticated)
                {
                    return Unauthorized("Người dùng chưa đăng nhập.");
                }
                var userIdClaim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdClaim))
                {
                    return BadRequest("Không thể xác định người dùng.");
                }
                var userId = Guid.Parse(userIdClaim);
                var bills = await _context.BillDetails
            .Include(b => b.BillTickets)
                .ThenInclude(bt => bt.Tickets)
                    .ThenInclude(t => t.Screenings)
                        .ThenInclude(s => s.ShowTime)
            .Include(b => b.BillTickets)
                .ThenInclude(bt => bt.Tickets)
                    .ThenInclude(t => t.Movies)
            .Include(b => b.BillTickets)
                .ThenInclude(bt => bt.Tickets)
                    .ThenInclude(t => t.Seat)
            .Where(b => b.UserID == userId)
            .ToListAsync(cancellationToken);
                if (bills == null || bills.Count == 0)
                {
                    return NotFound("Người dùng chưa đặt vé nào.");
                }
                var result = bills.Select(bill => new
                {
                    BillCode = bill.BillCode,
                    TotalPrice = bill.TotalPrice,
                    Tickets = bill.BillTickets.Select(bt => new
                    {
                        MovieName = bt.Tickets?.Movies?.Name ?? "Không có thông tin phim",
                        SeatNumber = bt.Tickets?.Seat?.SeatNumber ?? "Không có thông tin ghế",
                        ScreeningTime = bt.Tickets?.Screenings?.ShowTime?.StartTime.ToString(@"hh\:mm") ?? "Không có thông tin thời gian chiếu"
                    })

                });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [HttpGet("admin-check-bills")]
        public async Task<IActionResult> AdminCheckBills(AdminCheckBillClient request, CancellationToken cancellationToken)
        {
            try
            {
                var user = HttpContext.User;
                if (!user.Identity.IsAuthenticated)
                {
                    return Unauthorized("Người dùng chưa đăng nhập.");
                }

                var userIdClaim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdClaim))
                {
                    return BadRequest("Không thể xác định người dùng.");
                }
                var userRoleClaim = user.FindFirst(c => c.Type == ClaimTypes.Role)?.Value;
                if (userRoleClaim != "25d7afcb-949b-4717-a961-b50f2e18657d")
                {
                    return Unauthorized("Bạn không có quyền truy cập.");
                }
                var userId = Guid.Parse(request.ID);
                var bills = await _context.BillDetails
                    .Include(b => b.BillTickets)
                        .ThenInclude(bt => bt.Tickets)
                            .ThenInclude(t => t.Screenings)
                                .ThenInclude(s => s.ShowTime)
                    .Include(b => b.BillTickets)
                        .ThenInclude(bt => bt.Tickets)
                            .ThenInclude(t => t.Movies)
                    .Include(b => b.BillTickets)
                        .ThenInclude(bt => bt.Tickets)
                            .ThenInclude(t => t.Seat)
                    .Where(b => b.UserID == userId)
                    .ToListAsync(cancellationToken);
                if (bills == null || bills.Count == 0)
                {
                    return NotFound("Không có hóa đơn nào cho người dùng này.");
                }
                var result = bills.Select(bill => new
                {
                    BillID = bill.ID,
                    TotalPrice = bill.TotalPrice,
                    BillCode = bill.BillCode,
                    Tickets = bill.BillTickets.Select(bt => new
                    {
                        TicketID = bt.Tickets.ID,
                        MovieName = bt.Tickets.Movies?.Name ?? "Không có thông tin phim",
                        SeatNumber = bt.Tickets.Seat?.SeatNumber ?? "Không có thông tin ghế",
                        ScreeningTime = bt.Tickets.Screenings?.ShowTime != null
                            ? bt.Tickets.Screenings.ShowTime.StartTime.ToString(@"hh\:mm")
                            : "Không có thông tin thời gian chiếu",
                        Price = bt.Tickets.Price,
                        TicketStatus = bt.Tickets.Status.ToString()
                    })
                });
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [HttpPut("Forgot-Password")]
        public async Task<ActionResult> ForgotPass([FromBody] Forgotpass request)
        {
            try
            {
                var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
                if (user == null)
                {
                    return NotFound("Email không tồn tại trong hệ thống.");
                }
                string newPassword = GenerateRandomPassword();
                user.PassWord = Hash.Encrypt(newPassword);
                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                var emailContent = NeonCinema_API.SendMail.Template.CreateUser.ForgotPassword(user.FullName, newPassword);

                // Gửi email
                await _emailService.SendEmailAsync(request.Email, "Thông tin mật khẩu mới", emailContent);
                return Ok("Mật khẩu mới đã được gửi tới email của bạn.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }
        private string GenerateRandomPassword(int length = 8)
        {
            var random = new Random();
            var password = new StringBuilder();
            const string validChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()";

            for (int i = 0; i < length; i++)
            {
                password.Append(validChars[random.Next(validChars.Length)]);
            }

            return password.ToString();
        }

        [Authorize]
        [HttpPut("Changer-Password")]
        public async Task<ActionResult> ChangerPassword([FromBody] ClientChangerPass request)
        {
            try
            {
                var user = HttpContext.User;
                if (!user.Identity.IsAuthenticated)
                {
                    return Unauthorized("Người dùng chưa đăng nhập.");
                }
                var userIdClaim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdClaim))
                {
                    return BadRequest("Không thể xác định người dùng.");
                }
                var userId = Guid.Parse(userIdClaim);
                var account = await _context.Users.FindAsync(userId);
                if (account == null)
                {
                    return NotFound("Người dùng không tồn tại.");
                }
                if (request.Currenpassword != Hash.Decrypt(account.PassWord))
                {
                    return BadRequest("mật khẩu hiện tại không chính xác");
                }
                if (string.IsNullOrWhiteSpace(request.Newpassword))
                {
                    return BadRequest("Mật khẩu mới không được để trống.");
                }
                if(request.Newpassword != request.Confirmpasss)
                {
                    return BadRequest("Mật khẩu mới và mật khẩu xác nhận không khớp");
                }
                if (request.Newpassword == Hash.Decrypt(account.PassWord))
                {
                    return BadRequest("mật khẩu mới không được trùng với mật khẩu hiện tại");
                }
                account.PassWord = Hash.Encrypt(request.Newpassword);
                _context.Users.Update(account);
                await _context.SaveChangesAsync();

                return Ok("Đổi mật khẩu thành công.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }



        [Authorize]
        [HttpPost("Check-Current-Password")]
        public async Task<ActionResult> CheckCurrentPassword([FromBody] CheckPass request)
        {
            try
            {
                var user = HttpContext.User;
                if (!user.Identity.IsAuthenticated)
                {
                    return Unauthorized("Người dùng chưa đăng nhập.");
                }
                var userIdClaim = user.FindFirst(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdClaim))
                {
                    return BadRequest("Không thể xác định người dùng.");
                }
                var userId = Guid.Parse(userIdClaim);
                var account = await _context.Users.FindAsync(userId);
                
                if (account == null)
                {
                    return NotFound("Người dùng không tồn tại.");
                }
                if (request.password != Hash.Decrypt(account.PassWord))
                {
                    return BadRequest("Mật khẩu hiện tại không chính xác.");
                }
                
                return Ok("Mật khẩu đúng.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [Authorize]
        [HttpGet("getfrofile")]
        public async Task<ActionResult> GetFrofile()
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userIdString))
            {
                return Unauthorized("Không tìm thấy người dùng.");
            }
            if (!Guid.TryParse(userIdString, out Guid userId))
            {
                return BadRequest("ID người dùng không hợp lệ.");
            }
            var userProfile = await _userService.GetUserProfileAsync(userId);
            if (userProfile == null)
            {
                return NotFound("Không tìm thấy thông tin người dùng.");
            }

            return Ok(userProfile);
        }


        [Authorize]
        [HttpPut("UpdateProfile")]
        public async Task<IActionResult> UpdateProfile([FromBody] UpdateUserProfileRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Dữ liệu không hợp lệ.");
            }
            try
            {
                var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(userIdClaim))
                {
                    return Unauthorized("Người dùng chưa đăng nhập.");
                }
                var userId = Guid.Parse(userIdClaim);
                var updatedUser = await _userService.UpdateProfileAsync(userId, request);
                return Ok(new
                {
                    Message = "Cập nhật hồ sơ thành công.",
                    Data = updatedUser
                });
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new
                {
                    Message = ex.Message
                });
            }
            catch (Exception ex)
            {
                return BadRequest(new
                {
                    Message = "Đã xảy ra lỗi trong quá trình cập nhật.",
                    Error = ex.Message
                });
            }
        }
    }
    public class CheckPass
    {
        public string password { get; set; }
    }


}
