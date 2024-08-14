
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Seats
{
    public interface ISeatRepository
    {
        Task<HttpResponseMessage> Create(Seat seat, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(Seat seat, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(Seat seat, CancellationToken cancellationToken);
        Task<List<SeatDTO>> GetAll(CancellationToken cancellationToken);
        Task<SeatDTO> GetById(Guid id, Guid roomid, CancellationToken cancellationToken);
    }
}
