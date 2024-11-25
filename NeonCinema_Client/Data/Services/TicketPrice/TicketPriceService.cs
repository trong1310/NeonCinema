using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.TicketPrice;
using NeonCinema_Client.Data.IServices.TicketPrice;
using System.Threading;

namespace NeonCinema_Client.Data.Services.TicketPriceService
{
    public class TicketPriceService : ITicketPriceService
    {
        private readonly HttpClient _httpClient;

        public TicketPriceService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // Thêm giá vé mới
        public async Task<HttpResponseMessage> SetupPrice(TicketPriceDTO ticketPrice)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/TicketPrice/create", ticketPrice);
                return result;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Có lỗi : " + ex.Message)
                };
            }
        }

        // Cập nhật giá vé
        public async Task<HttpResponseMessage> UpdateTicketPriceAsync(TicketPriceDTO ticketPrice)
        {
            try
            {
                var result = await _httpClient.PutAsJsonAsync("https://localhost:7211/api/TicketPrice/update", ticketPrice);
                return result;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Có lỗi : " + ex.Message)
                };
            }
        }

        // Lấy tất cả giá vé
        public async Task<List<TicketPriceDTO>> GetTicketPricesAsync()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<TicketPriceDTO>>("https://localhost:7211/api/TicketPrice/get-all");
                return result;
            }
            catch (Exception ex)
            {
                return new List<TicketPriceDTO>();
            }
        }

        // Lấy giá vé theo ID
        public async Task<TicketPriceDTO> GetTicketPriceByIdAsync(Guid id)
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<TicketPriceDTO>($"https://localhost:7211/api/TicketPrice/get-by-id/{id}");
                return result;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<List<ScreeningDTO>> GetAllScreening()
        {
            try
            {
                var result = await _httpClient.GetFromJsonAsync<List<ScreeningDTO>>("https://localhost:7211/api/TicketPrice/get-screening");
                return result;
            }
            catch (Exception ex)
            {
                return new List<ScreeningDTO>();
            }
        }
    }
}