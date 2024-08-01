using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface ITicketRepository
    {
        Task<bool> CreateTicket(Ticket ticket, CancellationToken cancellationToken);
        Task<bool> UpdateTicket(Ticket ticket, CancellationToken cancellationToken);
        Task<bool> DeleteTicket(Guid id, CancellationToken cancellationToken);
        Task<List<TicketDTO>> GetAllTicket(CancellationToken cancellationToken);
        Task<TicketDTO> GetTicketById(Guid id, CancellationToken cancellationToken);
    }
}
