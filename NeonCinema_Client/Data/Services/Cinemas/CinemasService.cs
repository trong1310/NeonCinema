using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.Interface.Cinemas;
using NeonCinema_Client.Data.IServices.Cinemas;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.Services.Cinemas
{
    public class CinemasService : ICinemasService
    {
        private readonly HttpClient _httpClient;
        public CinemasService(HttpClient client)
        {
            _httpClient = client;
        }
        public Task<HttpResponseMessage> CreateCinemas(CinemasCreateRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<CinemasDTO>> GetAllCinemas(CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<List<CinemasDTO>>("api/Cinemas", cancellationToken);
        }

        public async Task<CinemasDTO> GetByIDRCinemas(Guid id, CancellationToken cancellationToken)
        {
            // Ví dụ cách lấy thông tin từ database hoặc API
            var result = await _httpClient.GetFromJsonAsync<CinemasDTO>($"api/Cinemas/{id}", cancellationToken);
            return result;
        }

        public async Task<HttpResponseMessage> UpdateCinemas(Guid id, CinemasUpdateRequest request, CancellationToken cancellationToken)
        {
            return await _httpClient.PutAsJsonAsync($"api/Cinemas{id}", request);
        }
    }
}
