using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Client.Data.IServices.IRoom;

namespace NeonCinema_Client.Data.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly HttpClient _client;

        public RoomService(HttpClient client)
        {
            _client = client;
        }

        public async Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request, CancellationToken cancellationToken)
        {
            return await _client.PostAsJsonAsync("api/Room/create", request, cancellationToken);
        }

        public async Task<RoomDTO> GetRoomById(Guid id, CancellationToken cancellationToken)
        {
            return await _client.GetFromJsonAsync<RoomDTO>($"api/Room/{id}", cancellationToken);
        }

        public async Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken)
        {
            var response = await _client.GetAsync("api/Room/getall", cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<RoomDTO>>(cancellationToken: cancellationToken);
            }
            else
            {
                // Log error or throw exception
                throw new Exception($"Failed to fetch rooms. Status code: {response.StatusCode}");
            }
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            return await _client.PutAsJsonAsync($"api/Room/{id}", request, cancellationToken);
        }
    }
}
