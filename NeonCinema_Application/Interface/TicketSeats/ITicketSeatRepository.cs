using NeonCinema_Application.DataTransferObject.TicketSeats;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.TicketSeats
{
    public interface ITicketSeatRepository
    {
        Task<PaginationResponse<TicketSeatDTO>> GetAllAsync(PaginationRequest request);
        Task<TicketSeatDTO> GetByIdAsync(Guid id);
        Task AddAsync(CreateTicketSeatDTO dto);
        Task UpdateAsync(UpdateTicketSeatDTO dto);
        Task DeleteAsync(Guid id);
    }
}
