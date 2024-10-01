using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.Interface.Countrys;
using NeonCinema_Client.Data.IServices.Country;

namespace NeonCinema_Client.Data.Services.Country
{
    public class CountryService : ICountryService
    {
        private readonly HttpClient _httpClient;

        public CountryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<CountryDTO>> GetAllCountries()
        {
            return await _httpClient.GetFromJsonAsync<List<CountryDTO>>("api/Country/get-all");
        }

        public async Task<CountryDTO> GetCountryById(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<CountryDTO>($"api/Country/get-by-id?id={id}");
        }

        public async Task<bool> CreateCountry(CountrysCreateRequest request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Country/create", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateCountry(Guid id, CountryUpdateRequest request)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Country/update?id={id}", request);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteCountry(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/Country/delete?id={id}");
            return result.IsSuccessStatusCode;
        }
    }
}
