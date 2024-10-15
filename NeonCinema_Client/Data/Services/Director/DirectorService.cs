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
        public async Task CreateDirector(CreateDirectorRequest request)
        {
            await _httpClient.PostAsJsonAsync("api/Director/CreateDirector", request);
        }

        public Task<List<DirectorDTO>> GetAllDirector()
        {
            return _httpClient.GetFromJsonAsync<List<DirectorDTO>>("api/Director/Get-All");
        }

        public Task<DirectorDTO> GetByIdDirector(Guid id)
        {
            return _httpClient.GetFromJsonAsync<DirectorDTO>($"/api/Director/GetById/{id}");
        }

        public async Task UpdateDirector(Guid id, UpdateDirectorRequest request)
        {
            await _httpClient.PutAsJsonAsync($"api/Director/UpdateDirector/{id}", request);
        }
    }
}
