using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Application.Interface.Point;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Points
{
    public class PointRepositories : IPointRepositories
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;
        public PointRepositories(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PointDTO>> GetAllPoints(CancellationToken cancellationToken)
        {
            var points = await _context.Points.ToListAsync(cancellationToken);
            return _mapper.Map<List<PointDTO>>(points);
        }

        public async Task<PointDTO> GetPointById(Guid id, CancellationToken cancellationToken)
        {
            var point = await _context.Points.FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
            if (point == null) return null;
            return _mapper.Map<PointDTO>(point);
        }

        public async Task CreatePoint(CreatePointRequest request, CancellationToken cancellationToken)
        {
            var fixedUserId = new Guid("278e7b46-fdb4-4609-a785-f3f637b14754");
            var fixedRoleId = new Guid("25d7afcb-949b-4717-a961-b50f2e18657d");

            // Kiểm tra xem User với UserID cố định có tồn tại không
            var userExists = await _context.Users.AnyAsync(u => u.ID == fixedUserId, cancellationToken);

            // Nếu không tồn tại thì tạo User giả
            if (!userExists)
            {
                var fakeUser = new Users
                {
                    ID = fixedUserId, // Sử dụng UserID cố định
                    FullName = "Fake User",
                    Email = "fakeuser@example.com",
                    PassWord = "password123",
                    DateOrBriht = DateTime.Now,
                    Adderss = "123 Fake Street",
                    Gender = "Not Specified",
                    RoleID = fixedRoleId // Sử dụng RoleID cố định
                };

                _context.Users.Add(fakeUser);
                await _context.SaveChangesAsync(cancellationToken);
            }

            // Tạo đối tượng Point từ request
            var point = _mapper.Map<Point>(request);

            // Gán UserID cố định vào đối tượng Point
            point.UserID = fixedUserId;

            // Thêm Point vào context và lưu thay đổi
            _context.Points.Add(point);
            await _context.SaveChangesAsync(cancellationToken);
        }


        public async Task UpdatePoint(Guid id, UpdatePointRequest request, CancellationToken cancellationToken)
        {
            var point = await _context.Points.FindAsync(id);
            if (point == null) return;

            _mapper.Map(request, point);
            _context.Points.Update(point);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeletePoint(Guid id, CancellationToken cancellationToken)
        {
            var point = await _context.Points.FindAsync(id);
            if (point == null) return;

            _context.Points.Remove(point);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
