using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface ISeatTypeRepository
    {
        Task <List<SeatTypeDTO>> GetAllAsync(CancellationToken cancellationToken);
        Task<SeatType> GetByIdAsync(Guid id);
        Task AddAsync(SeatType seatType);
        public Task<HttpResponseMessage> UpdateSeatType(Guid id, UpdateSeatTypeDTO request, CancellationToken cancellationToken);
        Task DeleteAsync(Guid id);
    }
}
