using NeonCinema_Application.DataTransferObject.TicketPrice;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface
{
    public interface ITicketPriceRepository
    {
        Task<List<TicketPriceDTO>> GetTicketPricesAsync();
        Task<TicketPriceDTO> GetTicketPriceByIdAsync(Guid id);
        Task<HttpResponseMessage> UpdateTicketPriceAsync(TicketPriceDTO ticketPrice);
        Task<HttpResponseMessage> SetupPrice(TicketPriceCreateRequest ticketPrice);
    }
}
