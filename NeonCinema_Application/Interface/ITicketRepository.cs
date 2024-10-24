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
        Task<HttpResponseMessage> CreateTicket(TicketPrice ticket, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateTicket(TicketPrice ticket, CancellationToken cancellationToken);
        Task<HttpResponseMessage> DeleteTicket(TicketPrice ticket, CancellationToken cancellationToken);
        Task<TicketDTO> GetTicketById(Guid id, CancellationToken cancellationToken);
    }
}
