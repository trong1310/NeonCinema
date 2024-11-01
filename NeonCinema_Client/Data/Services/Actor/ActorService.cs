//using NeonCinema_Application.DataTransferObject.Actors;
//using NeonCinema_Client.Data.IServices.Actor;

//namespace NeonCinema_Client.Data.Services.Actor
//{
//    public class ActorService : IActorService
//    {
//        private readonly HttpClient _httpClient;
//        public ActorService(HttpClient client)
//        {
//            _httpClient = client;
//        }
//        public async Task CreateActor(CreateActorRequest request)
//        {
//            await _httpClient.PostAsJsonAsync("api/Actor/Create", request);
//        } 

//        public async Task<List<ActorDTO>> GetAllActor()
//        {
//            return await _httpClient.GetFromJsonAsync<List<ActorDTO>>("api/Actor/GetAll");
//        }

//        public async Task<ActorDTO> GetByIdActor(Guid id)
//        {
//            return await _httpClient.GetFromJsonAsync<ActorDTO>($"api/Actor/{id}");
//        }

//        public async Task UpdateActor(Guid id, UpdateActorRequest request)
//        {
//            await _httpClient.PutAsJsonAsync($"api/Actor/Update/{id}", request);
//        }
//    }
//}
