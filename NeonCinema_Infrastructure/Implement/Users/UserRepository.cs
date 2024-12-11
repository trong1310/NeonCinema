using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Interface.Users;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
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
		public async Task<CreateClientResponse> CreateClient(UserCreateRequest request, CancellationToken cancellationToken)
		{
			var generatedPassword = GenerateRandomPassword();
			try
			{
				var newUser = new NeonCinema_Domain.Database.Entities.Users
				{
					ID = Guid.NewGuid(),
					FullName = request.FullName,
					PassWord = request.PassWord == null ? Hash.Encrypt(generatedPassword) : Hash.Encrypt(request.PassWord),
					PhoneNumber = request.PhoneNumber,
					Email = request.Email,
					Gender = request.Gender ?? true,
					Images = request.Images, // Lưu tên hình ảnh
					DateOrBriht = request.DateOrBriht,
					Adderss = request.Adderss == null ? "" : request.Adderss,
					CreatedTime = DateTime.UtcNow,
					Status = NeonCinema_Domain.Enum.EntityStatus.Active,
					RoleID = Guid.Parse("BA820C64-1A81-4C44-80EA-47038C930C3B"),
				};


				await _context.Users.AddAsync(newUser);
				await _context.SaveChangesAsync(cancellationToken);
				var rankMember = new RankMember
				{
					ID = Guid.NewGuid(),
					Rank = "Member",
					MinPoint = 0,
					UserID = newUser.ID,
					StarDate = (DateTime)newUser.CreatedTime,
					Status = EntityStatus.Active,


				};
				await _context.RankMembers.AddAsync(rankMember);
				await _context.SaveChangesAsync();

                return new CreateClientResponse
                {
                    HttpResponse = new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("Tạo người dùng thành công!")
                    },
                    GeneratedPassword = generatedPassword
                };
            }
			catch (Exception ex)
			{
                return new CreateClientResponse
                {
                    HttpResponse = new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Có lỗi xảy ra: " + ex.Message)
                    },
                    GeneratedPassword = null
                };
            }
		}
        public async Task<CreateClientResponse> CreateUser(UserCreateRequest request, CancellationToken cancellationToken)
        {
            var generatedPassword = GenerateRandomPassword();
            try
            {
                var newUser = new NeonCinema_Domain.Database.Entities.Users
                {
                    ID = Guid.NewGuid(),
                    FullName = request.FullName,
                    PassWord = request.PassWord == null ? Hash.Encrypt(generatedPassword) : Hash.Encrypt(request.PassWord),
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                    Gender = request.Gender ?? true,
                    Images = request.Images, // Lưu tên hình ảnh
                    DateOrBriht = request.DateOrBriht,
                    Adderss = request.Adderss,
                    CreatedTime = DateTime.UtcNow,
                    Status = NeonCinema_Domain.Enum.EntityStatus.Active,
                    RoleID = Guid.Parse("56BECE24-BA60-4B2B-801C-B68CFC8CCF9D"),
                };


                await _context.Users.AddAsync(newUser);
                await _context.SaveChangesAsync(cancellationToken);
                var rankMember = new RankMember
                {
                    ID = Guid.NewGuid(),
                    Rank = "Member",
                    MinPoint = 0,
                    UserID = newUser.ID,
                    StarDate = (DateTime)newUser.CreatedTime,
                    Status = EntityStatus.Active,


                };
                await _context.RankMembers.AddAsync(rankMember);
                await _context.SaveChangesAsync();

                return new CreateClientResponse
                {
                    HttpResponse = new HttpResponseMessage(HttpStatusCode.OK)
                    {
                        Content = new StringContent("Tạo người dùng thành công!")
                    },
                    GeneratedPassword = generatedPassword
                };
            }
            catch (Exception ex)
            {
                return new CreateClientResponse
                {
                    HttpResponse = new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Có lỗi xảy ra: " + ex.Message)
                    },
                    GeneratedPassword = null
                };
            }
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
			var obj = await _context.Users.FirstOrDefaultAsync(x => x.ID == id);
			return _map.Map<UserDTO>(obj);
		}


		//Create Client
		private string GenerateRandomPassword()
		{
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			var random = new Random();
			return new string(Enumerable.Repeat(chars, 10) // Độ dài mật khẩu là 10 ký tự
				.Select(s => s[random.Next(s.Length)])
				.ToArray());
		}

	}
}
