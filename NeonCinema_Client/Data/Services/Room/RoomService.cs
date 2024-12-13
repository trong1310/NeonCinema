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

        public async Task<List<SeatDTO>> GetSeatsByRoomId(Guid roomId)
        {

            var response = await _httpClient.GetFromJsonAsync<List<SeatDTO>>($"api/Room/GetSeatsByRoomId/{roomId}");
            return response;
        }

        public async Task<List<SeatDTO>> GetSeatsByRowAsync(Guid roomId, string rowId)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<List<SeatDTO>>($"api/Room/{roomId}/seats/row/{rowId}");
                return response ?? new List<SeatDTO>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching seats for row {rowId}: {ex.Message}");
            }
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Room/update/{id}", request);
            return response;
        }

        public async Task<bool> UpdateSeatTypeForRowAsync(Guid roomId, string rowId, Guid seatTypeId)
        {
            try
            {
                var request = new
                {
                    RowId = rowId,
                    SeatTypeId = seatTypeId
                };

                var response = await _httpClient.PutAsJsonAsync($"api/Room/{roomId}/seats/update-row", request);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating seat type for row {rowId}: {ex.Message}");
            }
        }
    }
}
