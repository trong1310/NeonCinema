using NeonCinema_Application.DataTransferObject.Actors;
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
        public async Task CreateActor(CreateActorRequest request)
        {
            await _httpClient.PostAsJsonAsync("api/Actor/CreateActor", request);
        } 

        public async Task<List<ActorDTO>> GetAllActor()
        {
            return await _httpClient.GetFromJsonAsync<List<ActorDTO>>("api/Actor/Get-All");
        }

        public async Task<ActorDTO> GetByIdActor(Guid id)
        {
            return await _httpClient.GetFromJsonAsync<ActorDTO>($"api/Actor/GetById/{id}");
        }

        public async Task UpdateActor(Guid id, UpdateActorRequest request)
        {
            await _httpClient.PutAsJsonAsync($"api/Actor/UpdateActor/{id}", request);
        }
    }
}
