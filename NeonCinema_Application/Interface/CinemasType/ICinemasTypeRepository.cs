using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.DataTransferObject.CinemasType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.CinemasType
{
    public interface ICinemasTypeRepository
    {
        public Task<List<CinemasTypeDTO>> GetAllCinemasType(CancellationToken cancellationToken);
        public Task<CinemasTypeDTO> GetByIDRCinemasType(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateCinemasType(CinemasTypeCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateCinemasType(Guid id, CinemasTypeUpdateRequest request, CancellationToken cancellationToken);
    }
}
