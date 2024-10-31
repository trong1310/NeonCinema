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
        public async Task<HttpResponseMessage> CreateClient(UserCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var newUser = new NeonCinema_Domain.Database.Entities.Users
                {
                    ID = Guid.NewGuid(),
                    FullName = request.FullName,
                    PassWord = Hash.Encrypt(request.PassWord),
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                    Gender = request.Gender ?? true,
                    Images = request.Images, // Lưu tên hình ảnh
                    DateOrBriht = request.DateOrBriht,
                    Adderss = request.Adderss,
                    Status = NeonCinema_Domain.Enum.EntityStatus.Active,
                    RoleID = Guid.Parse("BA820C64-1A81-4C44-80EA-47038C930C3B"),
                };


                _context.Users.Add(newUser);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Tạo người dùng thành công!")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
                };
            }
        }
        public async Task<HttpResponseMessage> CreateUser(UserCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var newUser = new NeonCinema_Domain.Database.Entities.Users
                {
                    ID = Guid.NewGuid(),
                    FullName = request.FullName,
                    PassWord = Hash.Encrypt(request.PassWord),
                    PhoneNumber = request.PhoneNumber,
                    Email = request.Email,
                    Gender = request.Gender ?? true,
                    Images = request.Images, // Lưu tên hình ảnh
                    DateOrBriht = request.DateOrBriht,
                    Adderss = request.Adderss,
                    Status = NeonCinema_Domain.Enum.EntityStatus.Active,
                    RoleID = Guid.Parse("56BECE24-BA60-4B2B-801C-B68CFC8CCF9D"), 
                };

                
                _context.Users.Add(newUser);
                await _context.SaveChangesAsync(cancellationToken);
            
                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Tạo người dùng thành công!")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("có lỗi xảy ra" + ex.Message)
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
            var obj = await _context.Users.FirstOrDefaultAsync(x=>x.ID == id);
            return _map.Map<UserDTO>(obj);
        }


        //Create Client

       
    }
}
