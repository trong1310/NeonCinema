using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.CinemasType;
using NeonCinema_Application.Interface.CinemasType;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Cinemastype
{
    public class CinemasTypeRepository : ICinemasTypeRepository
    {
        private readonly NeonCinemasContext _context;
        public CinemasTypeRepository(NeonCinemasContext ct)
        {
            _context = ct;
        }
        public async Task<HttpResponseMessage> CreateCinemasType(CinemasTypeCreateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra xem các trường có bị trống không
            if (string.IsNullOrWhiteSpace(request.Name))
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Tên loại rạp không được để trống.")
                };
            }

            // Kiểm tra trùng lặp tên loại rạp
            var existingCinemaType = await _context.CinemasTypes
                .FirstOrDefaultAsync(x => x.Name == request.Name, cancellationToken);

            if (existingCinemaType != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("Loại rạp này đã tồn tại.")
                };
            }

            // Tạo mới loại rạp
            var cinemaType = new CinemasType
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Status = request.Status
            };

            _context.CinemasTypes.Add(cinemaType);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public async Task<List<CinemasTypeDTO>> GetAllCinemasType(CancellationToken cancellationToken)
        {
            var cinemasTypes = await _context.CinemasTypes
                .Select(x => new CinemasTypeDTO
                {
                    Id = x.Id,
                    Name = x.Name,
                    Status = x.Status
                })
                .ToListAsync(cancellationToken);

            return cinemasTypes;
        }

        public async Task<CinemasTypeDTO> GetByIDRCinemasType(Guid id, CancellationToken cancellationToken)
        {
            var cinemaType = await _context.CinemasTypes
                 .Where(x => x.Id == id)
                 .Select(x => new CinemasTypeDTO
                 {
                     Id = x.Id,
                     Name = x.Name,
                     Status = x.Status
                 })
                 .FirstOrDefaultAsync(cancellationToken);

            if (cinemaType == null)
            {
                return null; // hoặc xử lý thông báo lỗi tùy theo yêu cầu của bạn
            }

            return cinemaType;
        }

        public async Task<HttpResponseMessage> UpdateCinemasType(Guid id, CinemasTypeUpdateRequest request, CancellationToken cancellationToken)
        {
            var cinemaType = await _context.CinemasTypes.FindAsync(new object[] { id }, cancellationToken);

            if (cinemaType == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Loại rạp không tồn tại.")
                };
            }

            // Kiểm tra trùng lặp tên loại rạp
            var existingCinemaType = await _context.CinemasTypes
                .FirstOrDefaultAsync(x => x.Name == request.Name && x.Id != id, cancellationToken);

            if (existingCinemaType != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("Loại rạp này đã tồn tại.")
                };
            }

            // Cập nhật thông tin
            cinemaType.Name = request.Name;
            cinemaType.Status = request.Status;

            _context.CinemasTypes.Update(cinemaType);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
