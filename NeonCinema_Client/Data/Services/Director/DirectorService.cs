using Azure.Core;
using Com.CloudRail.SI.ServiceCode.Commands;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Client.Data.IServices.Director;

namespace NeonCinema_Client.Data.Services.Director
{
    public class DirectorService : IDirectorService
    {
        private readonly HttpClient _httpClient;
        public DirectorService(HttpClient client)
        {
                _httpClient = client;
        }

        public async Task<HttpResponseMessage> CreateDirector(CreateDirectorRequest request, CancellationToken cancellationToken)
        {
            return await _httpClient.PostAsJsonAsync("api/Director", request, cancellationToken);
        }

        public async Task<List<DirectorDTO>> GetAllDirector(CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<List<DirectorDTO>>("api/Director", cancellationToken);
        }

        public async Task<DirectorDTO> GetDirectorById(Guid id, CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<DirectorDTO>($"api/Director/{id}", cancellationToken);
        }

        public async Task<HttpResponseMessage> UpdateDirector(Guid id, UpdateDirectorRequest request, CancellationToken cancellationToken)
        {
            return await _httpClient.PutAsJsonAsync($"api/Director/{id}", request, cancellationToken);
        }
    }
}
