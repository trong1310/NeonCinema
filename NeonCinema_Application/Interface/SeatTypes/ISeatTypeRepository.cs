using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.SeatType
{
    public interface ISeatTypeRepository
    {
        Task<PaginationResponse<NeonCinema_Domain.Database.Entities.SeatType>> GetAllAsync(PaginationRequest request);
        Task<NeonCinema_Domain.Database.Entities.SeatType> GetByIdAsync(Guid id);
        Task AddAsync(NeonCinema_Domain.Database.Entities.SeatType seatType);
        Task UpdateAsync(NeonCinema_Domain.Database.Entities.SeatType seatType);
        Task DeleteAsync(Guid id);
    }
}
