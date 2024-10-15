using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.ShowTime;
using NeonCinema_Client.Data.IServices.Screenning;
using System.Text.Json;

namespace NeonCinema_Client.Data.Services.Screenning
{
    public class ScreeningService : IScreeningService
    {
        private readonly HttpClient _httpClient;

        public ScreeningService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ScreeningDTO>> GetAllScreenings(CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<List<ScreeningDTO>>("api/Screening/get-all-screenings", cancellationToken);
        }

        public async Task<ScreeningDTO> GetScreeningById(Guid id, CancellationToken cancellationToken)
        {
            return await _httpClient.GetFromJsonAsync<ScreeningDTO>($"api/Screening/get-screening-by-id/{id}", cancellationToken);
        }

        public async Task<HttpResponseMessage> CreateScreening( ScreeningCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Screening/create-screening", request, cancellationToken);
            return response;
        }

        public async Task<HttpResponseMessage> UpdateScreening(Guid id, ScreeningUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Screening/update-screening/{id}", request, cancellationToken);
            return response;
        }

        public async Task<HttpResponseMessage> DeleteScreening(Guid id, CancellationToken cancellationToken)
        {
            var response = await _httpClient.DeleteAsync($"api/Screening/delete-screening/{id}", cancellationToken);
            return response;
        }
        public async Task<List<MovieDTO>> GetAllMovies(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("api/Movie/GetAll", cancellationToken);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    try
                    {
                        // Chuyển đổi nội dung thành danh sách MovieDTO
                        return JsonSerializer.Deserialize<List<MovieDTO>>(content);
                    }
                    catch (JsonException jsonEx)
                    {
                        Console.WriteLine($"JSON Error: {jsonEx.Message}");
                        // Xử lý lỗi nếu cần
                    }
                }
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }

            return new List<MovieDTO>(); // Trả về danh sách rỗng nếu có lỗi
        }


        public async Task<List<ShowTimeDTO>> GetAllShowTimes(CancellationToken cancellationToken)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/ShowTime/get-all-showtime", cancellationToken);

                // Kiểm tra mã trạng thái HTTP
                response.EnsureSuccessStatusCode();

                // Đọc và kiểm tra nội dung
                var content = await response.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(content))
                {
                    // Chuyển đổi nội dung thành danh sách ShowTimeDTO
                    return JsonSerializer.Deserialize<List<ShowTimeDTO>>(content);
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

            return new List<ShowTimeDTO>(); // Trả về danh sách rỗng nếu có lỗi
        }


        public async Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken)
        {
            try
            {
                var response = await _httpClient.GetAsync("api/rooms", cancellationToken);

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

            return new List<RoomDTO>(); // Trả về danh sách rỗng nếu có lỗi
        }

    }
}
