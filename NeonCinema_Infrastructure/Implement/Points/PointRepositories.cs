using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Application.Interface.Point;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            var fixedUserId = new Guid("5D15604A-41BE-452B-89F5-127895E8A387");
            var fixedRoleId = new Guid("BA820C64-1A81-4C44-80EA-47038C930C3B");

            // Kiểm tra xem User với UserID cố định có tồn tại không
            

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
