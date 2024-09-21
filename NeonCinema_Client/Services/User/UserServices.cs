using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Client.IServices.User;
using System.Text.Json;
using System.Text;

namespace NeonCinema_Client.Services.User
{
    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;

        public UserServices()
        {
            var handler = CreateHttpClientHandler();
            _httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri("http://localhost:5039")
            };
        }

        private static HttpClientHandler CreateHttpClientHandler()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            return handler;
        }

        public async Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("api/User/get-all", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonSerializer.Deserialize<List<UserDTO>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<UserDTO> GetByIDUser(string phoneNumber, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/User/get-by-phone/{phoneNumber}", cancellationToken);

                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    throw new Exception("Không tìm thấy người dùng với số điện thoại này.");
                }

                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync(cancellationToken);
                return JsonSerializer.Deserialize<UserDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi yêu cầu HTTP
                throw new Exception($"Có lỗi xảy ra khi gọi API: {ex.Message}");
            }
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
