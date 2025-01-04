using NeonCinema_API.Controllers.Service;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Client.Data.IServices.Actor;

namespace NeonCinema_Client.Data.Services.Actor
{
    public class ActorService : IActorService
    {
        private readonly HttpClient _httpClient;
        public ActorService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task CreateActor(ActorCreateRequest request)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Actor/createActor", request);
        }

        public async Task<List<ActorResponse>> GetAllActor()
        {
            return await _httpClient.GetFromJsonAsync<List<ActorResponse>>("https://localhost:7211/api/Actor/GetAll-Actor");
        }

        public async Task<ActorResponse> GetByIdActor(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<ActorResponse>($"https://localhost:7211/api/Actor/Get-Actor-Id/{id}");
        }

        public async Task UpdateActor(UpdateActorRequests request)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7211/api/Actor/Update-Actor", request);
        }
        
        
    }
}
