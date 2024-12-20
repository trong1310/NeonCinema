using NeonCinema_Application.DataTransferObject.FoodCombos;
using System.Net.Http.Json;

namespace NeonCinema_Client.Data.Services
{
	public class FoodComboServices
	{
		private readonly HttpClient _httpClient;
		public FoodComboServices(HttpClient http)
		{
			_httpClient = http;
		}
		public async Task<List<FoodComboDTO>> GetAllFoodCombo()
		{
			try
			{
				var respones = await _httpClient.GetFromJsonAsync<List<FoodComboDTO>>("https://localhost:7211/api/FoodCombo/get-all-foodcombo");
				return respones;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error {ex.Message} :{ex.StackTrace}");
			}

		}
		public async Task<FoodComboDTO> DetailCombo(Guid id)
		{
			try
			{
				var respones = await _httpClient.GetFromJsonAsync<FoodComboDTO>($"https://localhost:7211/api/FoodCombo/get-foodcombo-by-id?id={id}");
				return respones;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error {ex.Message} :{ex.StackTrace}");
			}
		}
		public async Task<FoodComboDTO> CreateFood(FoodComboCreateRequest request)
		{
			try
			{
				var response = await _httpClient.PostAsJsonAsync($"https://localhost:7211/api/FoodCombo/create-foodcombo", request);
				var foodComboDto = await response.Content.ReadFromJsonAsync<FoodComboDTO>();
				return foodComboDto;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error {ex.Message} : {ex.StackTrace}");
			}
		}
		public async Task<FoodComboDTO> UpdateFood(FoodComboUpdateRequest request)
		{
			try
			{
				var response = await _httpClient.PutAsJsonAsync($"https://localhost:7211/api/FoodCombo/update-foodcombo", request);
				var foodComboDto = await response.Content.ReadFromJsonAsync<FoodComboDTO>();
				return foodComboDto;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error {ex.Message} : {ex.StackTrace}");
			}
		}

	}
}
