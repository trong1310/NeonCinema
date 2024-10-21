using Microsoft.AspNetCore.Http.HttpResults;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.Data.IServices.Seat;
using NeonCinema_Infrastructure.Implement.Seats;
using System.Text.Json;
using System.Threading;

namespace NeonCinema_Client.Data.Services.Seat
{
    public class SeatService : ISeatService
    {
        private readonly ISeatRepository _seatRepository;
        private readonly HttpClient _client;
        public SeatService(HttpClient httpclient, SeatRepository seatRepository)
        {
            _client = httpclient;
            _seatRepository = seatRepository;
        }
        public async Task CreateSeat(CreateSeatDTO request)
        {
            await _client.PostAsJsonAsync("api/Seat/create", request);
        }

        //public async Task<List<SeatDTO>> GetAllSeat()
        //{
           
        //    var seats = await _client.GetFromJsonAsync<List<SeatDTO>>("api/Seat/get-all");
        //    return seats;  
        //}

        public async Task<PaginationResponse<SeatDTO>> GetAllSeat(PaginationRequest request)
        {
            var response = await _client.GetFromJsonAsync<PaginationResponse<SeatDTO>>($"api/Seat/get-all?pageNumber={request.PageNumber}&pageSize={request.PageSize}");
            return response;
        }

        public async Task<SeatDTO> GetByIdSeat(Guid id)
        {
            return await _client.GetFromJsonAsync<SeatDTO>($"api/Seat/get-by-id/{id}");
        }

        public async Task UpdateSeat(Guid id, UpdateSeatDTO request)
        {
            await _client.PutAsJsonAsync($"api/Seat/Update/{id}", request);
        }
        public async Task<List<RoomDTO>> GetAllRooms()
        {
            try
            {
                var response = await _client.GetAsync("api/rooms");

                // Kiểm tra mã trạng thái HTTP
                response.EnsureSuccessStatusCode();

                // Đọc và kiểm tra nội dung
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    // Chuyển đổi nội dung thành danh sách RoomDTO
                    return JsonSerializer.Deserialize<List<RoomDTO>>(content);
                }
            }
            catch (HttpRequestException httpEx)
            {
                Console.WriteLine($"HTTP Error: {httpEx.Message}");
                // Xử lý lỗi HTTP nếu cần
            }
            catch (JsonException jsonEx)
            {
                Console.WriteLine($"JSON Error: {jsonEx.Message}");
                // Xử lý lỗi JSON nếu cần
            }

            return new List<RoomDTO>();
        }

        public async Task<List<SeatTypeDTO>> GetAllSeatTypes()
        {
            var response = await _client.GetAsync("api/SeatType/Get-all");

            
            if (response.IsSuccessStatusCode)
            {
                
                var seatTypes = await response.Content.ReadFromJsonAsync<List<SeatTypeDTO>>();
                return seatTypes; 
            }
            else
            {
                
                throw new Exception("Failed to retrieve seat types.");
            }

        }

        public async Task<List<SeatDTO>> GetAllSeats()
        {
            var seats = await _seatRepository.GetAllSeatAsync();
            return seats;
        }
    }
}
