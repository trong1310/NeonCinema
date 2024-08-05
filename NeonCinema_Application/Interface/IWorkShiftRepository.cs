using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IWorkShiftRepository
    {
        Task<HttpResponseMessage> CreateWorkShift(WorkShift workshift, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateWorkShift(WorkShift workshift, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteWorkShift(WorkShift workshift, CancellationToken cancellationToken);
        Task<PaginationResponse<WorkShiftDTO>> GetAllWorkShift(WorkShiftViewRequets requets, CancellationToken cancellationToken);
    }
}
