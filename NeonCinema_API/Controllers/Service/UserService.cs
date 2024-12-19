
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;

namespace NeonCinema_API.Controllers.Service
{
    public class UserService : IUserServicesss
    {
        private readonly NeonCinemasContext _context;
        public UserService(NeonCinemasContext context)
        {
            _context = context;
        }
        //public async Task<(int TotalPoints, decimal TotalSpent)> GetUserStatsAsync(Guid userId)
        //{
           
        //}
        public async Task<UserProfile> GetUserProfileAsync(Guid userId)
        {
            var user = await _context.Users
             .Where(u => u.ID == userId).FirstOrDefaultAsync();
            var rank = await _context.RankMembers.Where(x=>x.UserID == user.ID).Select(x=>x.MinPoint).FirstOrDefaultAsync();
            var results = new UserProfile()
            {
                ID = userId,
                Address = user?.Adderss,
                DateOfBirth = user?.DateOrBriht.ToString(),
                Email = user?.Email,
                FullName = user?.FullName,
                Gender = user?.Gender,
                Images = user?.Images,
                PhoneNumber = user?.PhoneNumber,
                Ponit = rank,
            };
             return results;
        }

       

        public async Task<Users> UpdateProfileAsync(Guid userId, UpdateUserProfileRequest request)
        {
            if (userId == Guid.Empty)
            {
                throw new UnauthorizedAccessException("Người dùng chưa đăng nhập.");
            }
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                throw new Exception("Người dùng không tồn tại.");
            }
            if (!string.IsNullOrEmpty(request.FullName))
            {
                user.FullName = request.FullName;
            }
            if (!string.IsNullOrEmpty(request.Email) && request.Email != user.Email)
            {
                var emailExists = await _context.Users.AnyAsync(u => u.Email == request.Email && u.ID != userId);
                if (emailExists)
                {
                    throw new Exception("Email đã tồn tại.");
                }
                user.Email = request.Email;
            }
            if (!string.IsNullOrEmpty(request.PhoneNumber) && request.PhoneNumber != user.PhoneNumber)
            {
                var phoneExists = await _context.Users.AnyAsync(u => u.PhoneNumber == request.PhoneNumber && u.ID != userId);
                if (phoneExists)
                {
                    throw new Exception("Số điện thoại đã tồn tại.");
                }
                user.PhoneNumber = request.PhoneNumber;
            }
            if (request.DateOfBirth != DateTime.MinValue && request.DateOfBirth != user.DateOrBriht)
            {
                user.DateOrBriht = request.DateOfBirth;
            }

            if (!string.IsNullOrEmpty(request.Address))
            {
                user.Adderss = request.Address;
            }

            if (!string.IsNullOrEmpty(request.Images))
            {
                user.Images = request.Images;
            }
            
            _context.Users.Update(user);

            try
            {
                await _context.SaveChangesAsync();
                return user;
            }
            catch (Exception ex)
            {
                throw new Exception($"Đã xảy ra lỗi khi cập nhật: {ex.Message}");
            }
        }
    }
}
