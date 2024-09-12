using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.ShiftChange;
using NeonCinema_Application.Interface.ShiftChange;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.ShiftChange
{
    public class ShiftChangeRepository : IShiftChangeRepository
    {
        private readonly NeonCinemasContext _context;
        public ShiftChangeRepository(NeonCinemasContext ct)
        {
            _context = ct;
        }
        public async Task<HttpResponseMessage> CreateShiftChange(ShiftChangeCreateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra các trường không được để trống
            if (request.ID == Guid.Empty || string.IsNullOrEmpty(request.ShiftName) || string.IsNullOrEmpty(request.NewShift) ||
                request.RequetDate == DateTime.MinValue || request.WorkShiftID == Guid.Empty)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("All fields must be filled.")
                };
            }

            // Kiểm tra nếu ShiftChange trùng lặp
            var existingShiftChange = await _context.ShiftChange
                .Where(s => s.WorkShiftID == request.WorkShiftID && s.RequetDate == request.RequetDate)
                .FirstOrDefaultAsync(cancellationToken);

            if (existingShiftChange != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("A shift change for this work shift on the same date already exists.")
                };
            }

            // Tạo ShiftChange mới
            var newShiftChange = new NeonCinema_Domain.Database.Entities.ShiftChange
            {
                ID = Guid.NewGuid(),
                ShiftName = request.ShiftName,
                NewShift = request.NewShift,
                RequetDate = request.RequetDate,
                Status = request.Status,
                WorkShiftID = request.WorkShiftID
            };

            _context.ShiftChange.Add(newShiftChange);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Shift change created successfully.")
            };
        }

        public async Task<List<ShiftChangeDTO>> GetAllShiftChange(CancellationToken cancellationToken)
        {
            return await _context.ShiftChange
               .Select(s => new ShiftChangeDTO
               {
                   ID = s.ID,
                   ShiftName = s.ShiftName,
                   NewShift = s.NewShift,
                   RequetDate = s.RequetDate,
                   Status = s.Status,
                   WorkShiftID = s.WorkShiftID
               })
               .ToListAsync(cancellationToken);
        }

        public async Task<ShiftChangeDTO> GetByIDShiftChange(Guid id, CancellationToken cancellationToken)
        {
            var shiftChange = await _context.ShiftChange
                .Where(s => s.ID == id)
                .Select(s => new ShiftChangeDTO
                {
                    ID = s.ID,
                    ShiftName = s.ShiftName,
                    NewShift = s.NewShift,
                    RequetDate = s.RequetDate,
                    Status = s.Status,
                    WorkShiftID = s.WorkShiftID
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (shiftChange == null)
            {
                throw new KeyNotFoundException("Shift change not found.");
            }

            return shiftChange;
        }

        public async Task<HttpResponseMessage> UpdateShiftChange(Guid id, ShiftChangeUpdateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra nếu ShiftChange không tồn tại
            var existingShiftChange = await _context.ShiftChange.FirstOrDefaultAsync(s => s.ID == id, cancellationToken);
            if (existingShiftChange == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Shift change not found.")
                };
            }

            // Kiểm tra các trường không được để trống
            if (string.IsNullOrEmpty(request.ShiftName) || string.IsNullOrEmpty(request.NewShift) ||
                request.RequetDate == DateTime.MinValue || request.WorkShiftID == Guid.Empty)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("All fields must be filled.")
                };
            }

            // Cập nhật ShiftChange
            existingShiftChange.ShiftName = request.ShiftName;
            existingShiftChange.NewShift = request.NewShift;
            existingShiftChange.RequetDate = request.RequetDate;
            existingShiftChange.Status = request.Status;
            existingShiftChange.WorkShiftID = request.WorkShiftID;

            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Shift change updated successfully.")
            };
        }
    }
}
