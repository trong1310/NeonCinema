using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Application.Interface.WorkShidt;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.WorkShift
{
    public class WorkShiftRepository : IWorkShiftRepository
    {
        private readonly NeonCinemasContext _context;
        public WorkShiftRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> CreateWorkShift(WorkShiftCreateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra các trường không được để trống
            if (request.UserID == Guid.Empty || request.WorkDate == DateTime.MinValue ||
                request.TimeStar == DateTime.MinValue || request.TimeEnd == DateTime.MinValue)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("All fields must be filled.")
                };
            }

            // Kiểm tra nếu WorkDate nhỏ hơn ngày hiện tại
            if (request.WorkDate < DateTime.Today)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Work date must be today or a future date.")
                };
            }

            // Kiểm tra TimeStar phải nhỏ hơn TimeEnd
            if (request.TimeStar >= request.TimeEnd)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Start time must be earlier than end time.")
                };
            }

            // Kiểm tra không trùng lặp ca làm việc cho cùng một người
            var existingWorkShift = await _context.WorkShift
                .Where(w => w.UserID == request.UserID && w.WorkDate == request.WorkDate &&
                            w.TimeStar == request.TimeStar && w.TimeEnd == request.TimeEnd)
                .FirstOrDefaultAsync(cancellationToken);

            if (existingWorkShift != null)
            {
                return new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    Content = new StringContent("A work shift for this user at the same time already exists.")
                };
            }

            // Tạo ca làm việc mới
            var newWorkShift = new NeonCinema_Domain.Database.Entities.WorkShift
            {
                ID = Guid.NewGuid(),
                WorkDate = request.WorkDate,
                TimeStar = request.TimeStar,
                TimeEnd = request.TimeEnd,
                Status = request.Status,
                UserID = request.UserID
            };

            _context.WorkShift.Add(newWorkShift);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Work shift created successfully.")
            };
        }

        public async Task<List<WorkShiftDTO>> GetAllWorkShift(CancellationToken cancellationToken)
        {
            return await _context.WorkShift
               .Select(w => new WorkShiftDTO
               {
                   ID = w.ID,
                   WorkDate = w.WorkDate,
                   TimeStar = w.TimeStar,
                   TimeEnd = w.TimeEnd,
                   Status = w.Status,
                   UserID = w.UserID
               })
               .ToListAsync(cancellationToken);
        }

        public async Task<WorkShiftDTO> GetByIDWorkShift(Guid id, CancellationToken cancellationToken)
        {
            var workShift = await _context.WorkShift
                .Where(w => w.ID == id)
                .Select(w => new WorkShiftDTO
                {
                    ID = w.ID,
                    WorkDate = w.WorkDate,
                    TimeStar = w.TimeStar,
                    TimeEnd = w.TimeEnd,
                    Status = w.Status,
                    UserID = w.UserID
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (workShift == null)
            {
                throw new KeyNotFoundException("Work shift not found.");
            }

            return workShift;
        }

        public async Task<HttpResponseMessage> UpdateWorkShift(Guid id, WorkShiftUpdateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra nếu WorkShift không tồn tại
            var existingWorkShift = await _context.WorkShift.FirstOrDefaultAsync(w => w.ID == id, cancellationToken);
            if (existingWorkShift == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Work shift not found.")
                };
            }

            // Kiểm tra các trường không được để trống
            if (request.UserID == Guid.Empty || request.WorkDate == DateTime.MinValue ||
                request.TimeStar == DateTime.MinValue || request.TimeEnd == DateTime.MinValue)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("All fields must be filled.")
                };
            }

            // Kiểm tra nếu WorkDate nhỏ hơn ngày hiện tại
            if (request.WorkDate < DateTime.Today)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Work date must be today or a future date.")
                };
            }

            // Kiểm tra TimeStar phải nhỏ hơn TimeEnd
            if (request.TimeStar >= request.TimeEnd)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Start time must be earlier than end time.")
                };
            }

            // Cập nhật WorkShift
            existingWorkShift.WorkDate = request.WorkDate;
            existingWorkShift.TimeStar = request.TimeStar;
            existingWorkShift.TimeEnd = request.TimeEnd;
            existingWorkShift.Status = request.Status;
            existingWorkShift.UserID = request.UserID;

            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Work shift updated successfully.")
            };
        }
    }
}
