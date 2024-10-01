using NeonCinema_Application.DataTransferObject.User;
using System.Text.Json;
using System.Text;
using System.Net.Http.Json;
using NeonCinema_Application.DataTransferObject.Utilities;
using static NeonCinema_Client.Pages.Login;
using static System.Net.WebRequestMethods;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authorization;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.DataTransferObject.MovieData;
using NeonCinema_Client.Data.IServices.User;

namespace NeonCinema_Client.Services.User
{

    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;
        private readonly LoginModel _loginModel;
        public UserServices()
        {
            _loginModel = new LoginModel();
            var handler = CreateHttpClientHandler();
            _httpClient = new HttpClient(handler)
            {
                BaseAddress = new Uri("https://localhost:7211")
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
            var obj = await _httpClient.GetFromJsonAsync<List<UserDTO>>("https://localhost:7211/api/User/get-all");
            return obj;
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
            var obj = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/User/create", request);
            return obj;
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
