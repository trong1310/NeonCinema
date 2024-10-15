using NeonCinema_Application.Pagination;
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
        Task<PaginationResponse<Seat>> GetAllAsync(PaginationRequest request);
        Task<Seat> GetByIdAsync(Guid id);
        Task AddAsync(Seat seat);
        Task UpdateAsync(Seat seat);
        Task DeleteAsync(Guid id);
        
    }
}
