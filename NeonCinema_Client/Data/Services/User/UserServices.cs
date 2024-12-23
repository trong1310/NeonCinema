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
using NeonCinema_Application.DataTransferObject.User.Request;
using NeonCinema_API.Controllers;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using static NeonCinema_Client.Pages.Client.User.Profile;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Enum;
using System.Threading;
using System.Security.Claims;
using NeonCinema_API.Controllers.Service;

namespace NeonCinema_Client.Services.User
{

    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;
        private readonly LoginModel _loginModel;
        public UserServices(NeonCinemasContext context)
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
        public async Task<HttpResponseMessage> CreateClient(UserCreateRequest request)
        {
            try
            {
                var obj = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/User/create-client", request);
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
        public async Task<HttpResponseMessage> ForgotPass(Forgotpass request)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync("https://localhost:7211/api/User/Forgot-Password", request);
                return response;
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi gửi yêu cầu quên mật khẩu: {ex.Message}");
            }
        }

        public async Task<HttpResponseMessage> ChangerPass(ClientChangerPass request)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync("https://localhost:7211/api/User/Changer-Password", request);
                return response;
            }
            catch (Exception ex)
            {

                throw new Exception($"Lỗi đổi mật khẩu: {ex.Message}");
            }
        }

        public async Task<HttpResponseMessage> CheckPass(CheckPass request)
        {
            try
            {
                var reponse = await _httpClient.PostAsJsonAsync("https://localhost:7211/api/User/Check-Current-Password", request);
                return reponse;
            }
            catch (Exception ex)
            {

                throw new Exception($"mật khẩu không đúng:{ex.Message}");
            }
        }

        public async Task<List<Bill>> ClientCheckTicket(CancellationToken cancellationToken)
        {
            try
            {
                var token = "your_bearer_token"; 
                _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                var reponse = await _httpClient.GetFromJsonAsync<List<Bill>>("https://localhost:7211/api/User/user-check-tickets", cancellationToken);
                return reponse;
            }
            catch (Exception ex)
            {
                throw new Exception($"Bạn chưa đặt vé nào:{ex.Message}");
            }
        }

		public Task UpdateState(UpdateStateAccountRequestModels request)
		{
			try
			{

                var reponse =  _httpClient.PostAsJsonAsync($"https://localhost:7211/api/User/update-state", request);
				return reponse;
			}
			catch (Exception ex)
			{
				throw new Exception($"Bạn chưa đặt vé nào:{ex.Message}");
			}
		}

		
	}
}