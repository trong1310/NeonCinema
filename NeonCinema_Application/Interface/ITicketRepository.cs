using Azure.Messaging;
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
        Task<HttpResponseMessage> CreateTicket(Ticket ticket, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateTicket(Ticket ticket, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteTicket(Ticket ticket, CancellationToken cancellationToken);
        Task<List<TicketDTO>> GetAllTicket(CancellationToken cancellationToken);
        Task<TicketDTO> GetTicketById(Guid id, CancellationToken cancellationToken);
    }
}
