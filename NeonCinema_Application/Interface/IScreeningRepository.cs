using NeonCinema_Application.DataTransferObject.Screenings;
using NeonCinema_Application.DataTransferObject.Ticket;
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
        Task<HttpResponseMessage> CreateScreening(Screening screening, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateScreening(Screening screening, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteScreening(Screening screening, CancellationToken cancellationToken);
        Task<List<ScreeningDTO>> GetAllScreening(CancellationToken cancellationToken);
        Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken);
    }
}
