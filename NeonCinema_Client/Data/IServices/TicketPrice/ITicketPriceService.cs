using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.TicketPrice;

namespace NeonCinema_Client.Data.IServices.TicketPrice
{
    public interface ITicketPriceService
    {
        Task<List<TicketPriceDTO>> GetTicketPricesAsync();
        Task<List<ScreeningDTO>> GetAllScreening();
        Task<TicketPriceDTO> GetTicketPriceByIdAsync(Guid id);
        Task<HttpResponseMessage> UpdateTicketPriceAsync(TicketPriceDTO ticketPrice);
        Task<HttpResponseMessage> SetupPrice(TicketPriceDTO ticketPrice);
    }
}
