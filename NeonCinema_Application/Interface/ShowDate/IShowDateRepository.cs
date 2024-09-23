
using NeonCinema_Application.DataTransferObject.ShowDate;

using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.ShowDate
{
    public interface IShowDateRepository
    {
        public Task<List<ShowDateDTO>> GetAllShiftChange(CancellationToken cancellationToken);
        public Task<ShowDateDTO> GetByIDShiftChange(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateShiftChange(ShowDateCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateShiftChange(Guid id, ShowDateUpdateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteShiftChange(Guid id, CancellationToken cancellationToken); // Thêm phương thức xóa
    }
}
