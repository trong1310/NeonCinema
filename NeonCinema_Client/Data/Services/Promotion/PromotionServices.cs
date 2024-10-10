using NeonCinema_Application.DataTransferObject.Promotions;
using NeonCinema_Client.Data.IServices.Promotion;

namespace NeonCinema_Client.Data.Services.Promotion
{
    public class PromotionServices : IPromotionServices
    {
        private readonly HttpClient _client;
        public PromotionServices(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<PromotionDTO>> GetPromotionListAsync()
        {
            
            var result = await _client.GetFromJsonAsync<List<PromotionDTO>>("https://localhost:7211/api/Promotion/get-all");

            return result;
        }
    }
}
