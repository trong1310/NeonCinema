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

		public async Task<bool> CreatePromotionAsync(PromotionCreateRequest input)
		{
            try
            {
                var result = await _client.PostAsJsonAsync("https://localhost:7211/api/Promotion/post", input);


                if (result.IsSuccessStatusCode) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
			}
            catch (Exception ex) 
            {
                return false;
            }

		}

		public async Task<bool> DeletePromotionAsync(Guid id)
		{
			try
			{
				var result = await _client.DeleteAsync($"https://localhost:7211/api/Promotion/delete?id={id}" );


				if (result.IsSuccessStatusCode)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public async Task<List<PromotionDTO>> GetPromotionListAsync()
        {
            
            var result = await _client.GetFromJsonAsync<List<PromotionDTO>>("https://localhost:7211/api/Promotion/get-all");

            return result;
        }
	}
}
