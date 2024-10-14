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
using NeonCinema_Application.DataTransferObject.Actors;

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
            _httpClient = new HttpClient();
        }

        private static HttpClientHandler CreateHttpClientHandler()
        {
            var handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            return handler;
        }

        public async Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken)
        {
            var response = await _httpClient.GetAsync("https://localhost:7211/api/User/get-all", cancellationToken);
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

        public async Task<HttpResponseMessage> CreateUser(UserCreateRequest request)
        {
            try
            {
                var obj = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/User/create", request);
                return obj;
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Có lỗi : " + ex.Message)
                };

            }
        }

       
    }
}
