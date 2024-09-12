using NeonCinema_Application.DataTransferObject.ShiftChange;
using NeonCinema_Application.DataTransferObject.WorkShift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.ShiftChange
{
    public interface IShiftChangeRepository
    {
        public Task<List<ShiftChangeDTO>> GetAllShiftChange(CancellationToken cancellationToken);
        public Task<ShiftChangeDTO> GetByIDShiftChange(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateShiftChange(ShiftChangeCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateShiftChange(Guid id, ShiftChangeUpdateRequest request, CancellationToken cancellationToken);
    }
}
