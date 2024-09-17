using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.DataTransferObject.Countrys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Cinemas
{
    public interface ICinemasRepository
    {
        public Task<List<CinemasDTO>> GetAllCinemas(CancellationToken cancellationToken);
        public Task<CinemasDTO> GetByIDRCinemas(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateCinemas(CinemasCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateCinemas(Guid id, CinemasUpdateRequest request, CancellationToken cancellationToken);
    }
}
