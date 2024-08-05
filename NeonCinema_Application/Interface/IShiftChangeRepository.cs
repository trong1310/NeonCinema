using NeonCinema_Application.DataTransferObject.ShiftChanges;
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
    public interface IShiftChangeRepository
    {
        Task<HttpResponseMessage> CreateShiftChanges(ShiftChange shiftChange, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateShiftChanges(ShiftChange shiftChange, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteShiftChanges(ShiftChange shiftChange, CancellationToken cancellationToken);
        Task<PaginationResponse<ShiftChangesDTO>> GetAllShiftChanges(ShiftChangesViewRequets requets, CancellationToken cancellationToken);
    }
}
