
using NeonCinema_Application.DataTransferObject.ShowTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.ShowTime
{
    public interface IShowTimeRepository
    {
        Task<List<ShowTimeDTO>> GetAllShowTime(CancellationToken cancellationToken);
        Task<ShowTimeDTO> GetByIDShowTime(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> CreateShowTime(ShowTimeCreateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateShowTime(Guid id, ShowTimeUpdateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteShowTime(Guid id, CancellationToken cancellationToken);
    }
}
