using Microsoft.Extensions.Options;
using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Application.Interface.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Utilities
{
    public class ReCapchaRepositories : IReCapchaRepositories
    {
        private readonly ReCapchaRequest _request;
        private HttpClient _client;
        public ReCapchaRepositories(IOptions<ReCapchaRequest> request, HttpClient client)
        {
            _request = request.Value;
            _client = client;
        }   
        public async Task<bool> VerifyToken(string token)
        {
            var response = await _client.GetStringAsync($"https://www.google.com/recaptcha/api/siteverify?secret={_request.SecretKey}&response={token}");
            var recaptchaResponse = JsonConvert.DeserializeObject<RecaptchaResponse>(response);
            return recaptchaResponse.Success;
        }
    }
    public class RecaptchaResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("challenge_ts")]
        public DateTime ChallengeTs { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }
    }
}
