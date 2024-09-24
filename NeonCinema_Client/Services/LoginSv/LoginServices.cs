using Microsoft.IdentityModel.Tokens;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Client.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Net.Http;
using NeonCinema_Client.IServices.LoginServices;
using Microsoft.AspNetCore.Authorization;
using static NeonCinema_Client.Pages.Login;
using static System.Net.WebRequestMethods;
using Blazored.LocalStorage;

namespace NeonCinema_Client.Services.LoginSv
{
    [Authorize]
    public class LoginServices
    {
        private readonly ILocalStorageService _localStorage;
        private readonly HttpClient _httpClient;
        private string _token;

        public LoginServices(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
            _httpClient = httpClient;
        }

        // Phương thức để đăng nhập và nhận JWT token
        public async Task<bool> LoginAsync(LoginModel loginModel)
        {
            var response = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/Login/Login", loginModel);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                // Giả sử API trả về JSON với thuộc tính 'token'
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(content);
                _token = tokenResponse.Token;

                // Lưu token vào HttpClient cho các yêu cầu sau
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue( _token);

                return true;
            }
            return false;
        }
        public async Task<UserLoginDTO> GetUserInfoAsync()
        {         
            var response = await _httpClient.GetFromJsonAsync<UserLoginDTO>("https://localhost:7211/api/Login/current");

            return response;
        }
    }
}
