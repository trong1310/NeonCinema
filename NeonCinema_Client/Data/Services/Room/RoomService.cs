using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Client.Data.IServices.IRoom;
using System.Text.Json;
using System.Threading;

namespace NeonCinema_Client.Data.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly HttpClient _httpClient;

        public RoomService(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Room/create", request);
            return response;
        }

        public async Task<List<CinemasDTO>> GetAllCinemas()
        {
            return await _httpClient.GetFromJsonAsync<List<CinemasDTO>>("api/Cinemas");
        }

        public async Task<List<RoomDTO>> GetAllRooms()
        {
            var response = await _httpClient.GetFromJsonAsync<List<RoomDTO>>("api/Room/all");
            return response ?? new List<RoomDTO>();
        }

        public async Task<List<SeatTypeDTO>> GetAllSeatType()
        {
            return await _httpClient.GetFromJsonAsync<List<SeatTypeDTO>>("api/SeatType/Get-all");
        }

        public async Task<RoomDTO> GetRoomById(Guid id)
        {
            var respones = await _httpClient.GetFromJsonAsync<RoomDTO>($"api/Room/{id}");
            return respones;
        }

        public Task<List<SeatDTO>> GetSeat()
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Room/update/{id}", request);
            return response;
        }

        public Task UpdateSeatType(UpdateSeatDTO seatDTO)
        {
            throw new NotImplementedException();
        }
    }
}
