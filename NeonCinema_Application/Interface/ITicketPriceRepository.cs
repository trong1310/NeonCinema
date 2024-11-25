using NeonCinema_Application.DataTransferObject.Screening;
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
        Task<List<TicketPriceDTO>> GetAllTicketPrices();
        Task<List<ScreeningDTO>> GetAllScreening();
        Task<TicketPriceDTO> GetTicketPriceById(Guid id);
        Task<HttpResponseMessage> UpdateTicketPrice(TicketPriceDTO ticketPrice);
        Task<HttpResponseMessage> CreateTicketPrice(TicketPriceCreateRequest ticketPrice);
    }
}
