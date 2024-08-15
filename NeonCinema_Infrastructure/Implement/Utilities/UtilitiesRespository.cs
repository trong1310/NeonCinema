using MailKit.Security;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MimeKit;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Application.Interface.Utilities;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Utilities
{
    public class UtilitiesRespository : IUtilitiesRepository
    {
        private readonly NeonCenimaContext _context;
        private readonly IConfiguration _configuration;
        public UtilitiesRespository(NeonCenimaContext context, IConfiguration configuration)
        {
            _configuration = configuration;
            _context = context;
        }
        public async Task<HttpResponseMessage> ChangePassword(ChangePasswordRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var objChangePass = await _context.Customers.AsNoTracking().FirstOrDefaultAsync(x => x.PassWord == requets.Password);
                if (objChangePass != null)
                {
                 
                    if (Hash.Decrypt(objChangePass.PassWord) == requets.Password)
                    {
                        objChangePass.PassWord = Hash.Encrypt(objChangePass.PassWord);
                        _context.Customers.Update(objChangePass);
                        await _context.SaveChangesAsync();
                        return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                        {
                            Content = new StringContent("Change Password Sucsessfully")
                        };
                    }
                }
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("password is incorrect")
                };


            }
            catch (Exception ex) 
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<bool> ConFirmCode(ConfirmCodeRequets requets, CancellationToken cancellationToken)
        {

            try
            {
                var obj = await _context.Customers.FirstOrDefaultAsync(x => x.CustomerID == requets.Id);
                if ((obj!.ConfirmCode == requets.Code) && (DateTime.UtcNow.AddMinutes(-5) < obj.SeenTime))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public async Task<HttpResponseMessage> ForgotPassWord(ForgotPassWordRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _context.Customers.FirstOrDefaultAsync(x => x.CustomerID == requets.Id);
                if (requets.ConfirmPassWord != requets.PassWord)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("password is incorrect ")
                    };
                }
                obj.PassWord = Hash.Encrypt(requets.PassWord);
                _context.Customers.Update(obj);
                await _context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Forgot Password Successfully")
                };
            }
            catch (Exception ex) 
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<string> ResetPassWord(ForgotPassWordRequets requets, CancellationToken cancellationToken)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"])); // tạo mã khóa bảo mật , chuyển qua dạng byte
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256); // xác định  cách đoạn mã token trên được dki  bằng thuật toán HMACSHA



            var claim = new[] // tạo ra 1 mảng claim
            {
                new Claim(JwtRegisteredClaimNames.Sub,requets.Id.ToString()), // chuy.ển đối kiểu dữ liệu của id sang string để gán giá trị cho claim
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()), // 

            };
           
            var token = new JwtSecurityToken(
                    issuer: "vantrongvt1310@gmail.com",
                    audience: requets.Email,
                    claims: claim,
                    expires: DateTime.UtcNow.AddMinutes(10), // token co thời hạn 10p
                    signingCredentials: credentials
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> SendMail(SendMaillRequest request, string token)
        {
            try
            {
                var create = new List<Customers>()
                {
                   
                };
                var obj = _context.Customers.AsNoTracking().FirstOrDefault(x => x.CustomerID == request.Id);
                var email = "vantrongvt1310@gmail.com";
                var resetUrl = $"https://yourdomain.com/reset-password?token={token}";
                var message = new MimeMessage();
                var bodyBuilder = new BodyBuilder();
                message.From.Add(new MailboxAddress("Từ", email));
                message.To.Add(new MailboxAddress("Tới", request.Email));
                message.Subject = "Xác nhận Reset mật khẩu";
                bodyBuilder.HtmlBody = $@"
                     <p>Xin chào, {obj.CustomerName}</p>
                    <p>Yêu cầu đặt lại mật khẩu của bạn đã được xử lý, vui lòng bấm vào nút dưới đây để đổi lại mật khẩu của mình </p>
                     <a href=""{resetUrl}"">
                      <p> Email này chỉ có hiệu lực trong vòng 10 phút. Bạn lòng không chia sẻ đường link cho ai khác để bảo vệ tài khoản của mình</p> ";

                message.Body = bodyBuilder.ToMessageBody();
                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    client.Authenticate(email, "YourSecretKey001122");
                    client.Send(message);
                    client.Disconnect(true);
                }
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
