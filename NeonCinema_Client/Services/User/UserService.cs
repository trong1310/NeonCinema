using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Client.IServices.User;
using System.Text.Json;
using System.Text;

namespace NeonCinema_Client.Services.User
{
    public class UserService : IUserServices
    {
        private readonly HttpClient _httpClient;

        public UserService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("users", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonSerializer.Deserialize<List<UserDTO>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<UserDTO> GetByIDUser(string phoneNumber, CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync($"users/{phoneNumber}", cancellationToken);
            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new Exception("Không tìm thấy người dùng với số điện thoại này.");
            }

            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonSerializer.Deserialize<UserDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<HttpResponseMessage> CreateUser(UserCreateRequest request, CancellationToken cancellationToken)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PostAsync("users", content, cancellationToken);
            return response;
        }

        public async Task<HttpResponseMessage> UpdateUser(Guid id, UserUpdateRequest request, CancellationToken cancellationToken)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(request),
                Encoding.UTF8,
                "application/json");

            var response = await _httpClient.PutAsync($"users/{id}", content, cancellationToken);
            return response;
        }
    }
}
