using NeonCinema_Application.DataTransferObject.TicketPriceSetting;
using NeonCinema_Client.Data.IServices.TicketPriceSetting;

namespace NeonCinema_Client.Data.Services.TicketPriceSetting
{
	public class TicketPriceSettingService : ITicketPriceSettingService
	{
		private readonly HttpClient _httpClient;
        public TicketPriceSettingService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
		public async Task<TicketPriceSettingDTO> GetByIdAsync(Guid id)
		{
			var response = await _httpClient.GetAsync($"api/TicketPriceSetting/{id}");
			if (!response.IsSuccessStatusCode)
			{
				throw new Exception($"Không thể lấy thông tin giá vé. Mã lỗi: {response.StatusCode}");
			}

			return await response.Content.ReadFromJsonAsync<TicketPriceSettingDTO>();
		}

		// Phương thức Update
		public async Task<HttpResponseMessage> Update(TicketPriceSettingDTO request)
		{
            var respones = await _httpClient.PutAsJsonAsync("https://localhost:7211/api/TicketPriceSetting", request);
            return respones;
        }
	}
}
