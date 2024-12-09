using NeonCinema_Application.DataTransferObject.Screening;

using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface IScreeningRepository
    {
        Task<HttpResponseMessage> CreateScreening(ScreeningCreateRequest screening, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateScreening(ScreeningUpdateRequest screening, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteScreening(Guid id, CancellationToken cancellationToken);
        Task<PaginationResponse<ScreeningDTO>> GetAllScreening(ViewScreningRequest request,CancellationToken cancellationToken);
        Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> CreateSSS(SeatShowTimeStatusDTO input, CancellationToken ctoken);
    }
}
