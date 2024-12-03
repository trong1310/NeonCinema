using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Client.Data.IServices.Screenning;
using System.Net.Http.Json;

namespace NeonCinema_Client.Data.Services.Screenning
{
    public class ShowTimeService : IShowTimeService
    {
        private readonly HttpClient _httpClient;

        public ShowTimeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ShowTimeDTO>> GetAllShowTimes(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("api/ShowTime/get-all-showtime", cancellationToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<List<ShowTimeDTO>>(cancellationToken: cancellationToken);
        }

        public async Task<ShowTimeDTO> GetShowTimeById(Guid id, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($"api/ShowTime/get-showtime-by-id/{id}", cancellationToken);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<ShowTimeDTO>(cancellationToken: cancellationToken);
        }

        public async Task<bool> CreateShowTime(ShowTimeCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PostAsJsonAsync("api/ShowTime/create-showtime", request, cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task UpdateShowTime(Guid id, ShowTimeUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/ShowTime/update-showtime/{id}", request);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteShowTime(Guid id, CancellationToken cancellationToken)
        {
            var response = await _httpClient.DeleteAsync($"api/ShowTime/delete-showtime/{id}", cancellationToken);
            response.EnsureSuccessStatusCode();
        }
    }
}
