//using NeonCinema_Domain.Enum;
//using NeonCinema_Infrastructure.Database.AppDbContext;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
//namespace NeonCinema_Infrastructure.VerifyCodeAndActivateAccount
//{
//    public class UserService
//    {
//        private readonly NeonCinemasContext _context;

//        public UserService(NeonCinemasContext context)
//        {
//            _context = context;
//        }

//        public async Task<HttpResponseMessage> VerifyCodeAndActivateAccount(string phoneNumber, string enteredCode, CancellationToken cancellationToken)
//        {
//            // Tìm người dùng dựa trên số điện thoại
//            var user = await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phoneNumber, cancellationToken);
//            if (user == null)
//            {
//                return new HttpResponseMessage(HttpStatusCode.NotFound) { Content = new StringContent("Người dùng không tồn tại.") };
//            }

//            // Kiểm tra mã xác nhận
//            if (user.ConfirmCode != enteredCode)
//            {
//                return new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Mã xác nhận không chính xác.") };
//            }

//            // Kiểm tra thời gian hiệu lực của mã xác nhận
//            var expirationTime = user.SeenTime?.AddMinutes(1);
//            if (DateTimeOffset.Now > expirationTime)
//            {
//                return new HttpResponseMessage(HttpStatusCode.BadRequest) { Content = new StringContent("Mã xác nhận đã hết hạn.") };
//            }

//            // Kích hoạt tài khoản
//            user.Status = EntityStatus.Active;
//            user.ConfirmCode = null; // Xóa mã xác nhận sau khi kích hoạt

//            _context.Users.Update(user);
//            await _context.SaveChangesAsync(cancellationToken);

//            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Tài khoản đã được kích hoạt thành công.") };
//        }
//    }

//}
