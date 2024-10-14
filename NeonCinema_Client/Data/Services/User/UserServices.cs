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
using NeonCinema_Client.Data.IServices.User;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.DataTransferObject.MovieData;

namespace NeonCinema_Client.Services.User
{

    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;
        private readonly LoginModel _loginModel;
        public UserServices(HttpClient httpClient)
        {
            _loginModel = new LoginModel();
            _httpClient = httpClient;
        }

        public async Task<HttpResponseMessage> CreateUser(UserCreateRequest request)
        {
            var repones = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/User/create", request);
            return repones;
        }

        public async Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("api/User/get-all", cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync(cancellationToken);
            return JsonSerializer.Deserialize<List<UserDTO>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }

        public async Task<UserDTO> GetByIDUser(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _httpClient.GetFromJsonAsync<UserDTO>($"https://localhost:7211/api/User/get-by-id?id={id}", cancellationToken);
                return response;
            }
            catch (HttpRequestException ex)
            {
                // Xử lý lỗi yêu cầu HTTP
                throw new Exception($"Có lỗi xảy ra khi gọi API: {ex.Message}");
            }
        }

       
    }
}
