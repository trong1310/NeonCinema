using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Seats
{
    public interface ISeatTypeRepository
    {
        Task<HttpResponseMessage> Create(SeatType seatT, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Update(SeatType seatT, CancellationToken cancellationToken);
        Task<HttpResponseMessage> Delete(SeatType seatT, CancellationToken cancellationToken);
        Task<List<SeatTypeDTO>> GetAll(CancellationToken cancellationToken);
        Task<SeatTypeDTO> GetById(Guid id, CancellationToken cancellationToken);
    }
}
