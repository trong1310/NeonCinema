using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Client.Data.IServices.Screenning;

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
            return await _httpClient.GetFromJsonAsync<List<ShowTimeDTO>>("api/ShowTime/get-all-showtime", cancellationToken);
        }

        public async Task<ShowTimeDTO> GetShowTimeById(Guid id, CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<ShowTimeDTO>($"api/ShowTime/get-showtime-by-id/{id}", cancellationToken);
        }

        public async Task CreateShowTime(ShowTimeCreateRequest request, CancellationToken cancellationToken)
        {

            await _httpClient.PostAsJsonAsync("api/ShowTime/create-showtime", request, cancellationToken);
        }

        public async Task UpdateShowTime(Guid id, ShowTimeUpdateRequest request)
        {
            await _httpClient.PutAsJsonAsync($"api/ShowTime/update-showtime/{id}", request);
        }

        public async Task DeleteShowTime(Guid id, CancellationToken cancellationToken)
        {
            await _httpClient.DeleteAsync($"api/ShowTime/delete-showtime/{id}", cancellationToken);
        }
    }
}
