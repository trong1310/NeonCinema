using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.Users;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _map;
        public UserRepository(NeonCinemasContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }
        public async Task<HttpResponseMessage> CreateUser(UserCreateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra các trường thông tin đầu vào
            if (string.IsNullOrEmpty(request.FullName) || string.IsNullOrEmpty(request.PhoneNumber) ||
                string.IsNullOrEmpty(request.Email) || 
                string.IsNullOrEmpty(request.Adderss))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Các trường không được để trống!")
                };
            }

            // Kiểm tra nếu người dùng đã tồn tại
            var existingUser = await _context.Users
                .FirstOrDefaultAsync(u => u.PhoneNumber == request.PhoneNumber || u.Email == request.Email, cancellationToken);

            if (existingUser != null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Số điện thoại hoặc email đã tồn tại!")
                };
            }

            // Tạo thư mục để lưu trữ hình ảnh nếu chưa tồn tại
            string fileRoot = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
            if (!Directory.Exists(fileRoot))
            {
                Directory.CreateDirectory(fileRoot);
            }

            // Lưu hình ảnh người dùng
            string userImageFileName = Guid.NewGuid() + Path.GetExtension(request.Images.FileName);
            string userImagePath = Path.Combine(fileRoot, userImageFileName);
            using (var fileStream = new FileStream(userImagePath, FileMode.Create))
            {
                await request.Images.CopyToAsync(fileStream);
            }

            // Tạo đối tượng người dùng mới
            var newUser = new NeonCinema_Domain.Database.Entities.Users
            {
                FullName = request.FullName,
                PassWord = Hash.Encrypt(request.PassWord),
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Gender = request.Gender,
                Images = $"{userImageFileName}", // Lưu tên hình ảnh
                DateOrBriht = request.DateOrBriht,
                Adderss = request.Adderss,
                Status = request.Status,
                RoleID = request.RoleID /*== Guid.Empty ? new Guid("25d7afcb-949b-4717-a961-b50f2e18657d") : request.RoleID // Mặc định RoleID*/
            };

            // Thêm người dùng vào cơ sở dữ liệu và lưu thay đổi
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync(cancellationToken);
            newUser.PassWord = ""; // Đặt lại mật khẩu trước khi trả về phản hồi

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Tạo người dùng thành công!")
            };
        }

        public async Task<HttpResponseMessage> UpdateUser(Guid id, UserUpdateRequest request, CancellationToken cancellationToken)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Người dùng không tồn tại!")
                };
            }

            if (string.IsNullOrEmpty(request.FullName) || string.IsNullOrEmpty(request.PhoneNumber) ||
                string.IsNullOrEmpty(request.Email) || 
                string.IsNullOrEmpty(request.Adderss))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Các trường không được để trống!")
                };
            }

            user.FullName = request.FullName;
            user.PhoneNumber = request.PhoneNumber;
            user.Email = request.Email;
            user.Gender = request.Gender;
            user.Images = request.Images;
            user.Adderss = request.Adderss;
            user.Status = request.Status;
            user.RoleID = request.RoleID;

            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Cập nhật người dùng thành công!")
            };
        }
        public async Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken)
        {
            var users = await _context.Users
                .Select(u => new UserDTO
                {
                    ID = u.ID,
                    FullName = u.FullName,
                    PhoneNumber = u.PhoneNumber,
                    Email = u.Email,
                    Gender = u.Gender,
                    Images = u.Images,
                    DateOrBriht = u.DateOrBriht,
                    Adderss = u.Adderss,
                    
                    Status = u.Status,
                    RoleID = u.RoleID
                }).ToListAsync(cancellationToken);

            return users;
        }
        public async Task<UserDTO> GetByIDUser(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _context.Users.FirstOrDefaultAsync(x=>x.ID == id);
            return _map.Map<UserDTO>(obj);
        } 
    }
}
