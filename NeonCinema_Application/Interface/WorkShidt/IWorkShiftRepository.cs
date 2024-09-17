using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.WorkShift;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.WorkShidt
{
    public interface IWorkShiftRepository
    {
        public Task<List<WorkShiftDTO>> GetAllWorkShift(CancellationToken cancellationToken);
        public Task<WorkShiftDTO> GetByIDWorkShift(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateWorkShift(WorkShiftCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateWorkShift(Guid id, WorkShiftUpdateRequest request, CancellationToken cancellationToken);
    }
}
