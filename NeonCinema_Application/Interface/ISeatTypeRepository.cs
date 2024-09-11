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
        Task<PaginationResponse<SeatType>> GetAllAsync(PaginationRequest request);
        Task<SeatType> GetByIdAsync(Guid id);
        Task AddAsync(SeatType seatType);
        Task UpdateAsync(SeatType seatType);
        Task DeleteAsync(Guid id);
    }
}
