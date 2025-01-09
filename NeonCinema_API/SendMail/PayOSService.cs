using System.Net.Http.Json;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Extensions.Options;
using NeonCinema_API.SendMail;

public class PayOSService
{
	public readonly PayOSSettings _settings;
	private readonly HttpClient _httpClient;

	public PayOSService(IOptions<PayOSSettings> settings, HttpClient httpClient)
	{
		_settings = settings.Value;
		_httpClient = httpClient;
	}

	public async Task<string> CreatePaymentAsync(decimal amount, string description)
	{
		// Tạo dữ liệu yêu cầu thanh toán
		var request = new
		{
			clientId = _settings.ClientId,
			apiKey = _settings.ApiKey,
			amount = amount,
			description = description,
			returnUrl = "https://yourdomain.com/payment/success",
			cancelUrl = "https://yourdomain.com/payment/cancel"
		};

		// Tạo checksum để xác thực
		string checksumData = $"{_settings.ClientId}|{_settings.ApiKey}|{amount}|{_settings.ChecksumKey}";
		string checksum = GenerateChecksum(checksumData);

		var requestWithChecksum = new
		{
			request.clientId,
			request.apiKey,
			request.amount,
			request.description,
			request.returnUrl,
			request.cancelUrl,
			checksum
		};

		// Gửi yêu cầu tới PayOS
		var response = await _httpClient.PostAsJsonAsync($"{_settings.BaseUrl}/payment/create", requestWithChecksum);

		response.EnsureSuccessStatusCode();
		var result = await response.Content.ReadFromJsonAsync<PayOSResponse>();

		return result.PaymentUrl;
	}

	public string GenerateChecksum(string data)
	{
		using (var sha256 = SHA256.Create())
		{
			var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(data));
			return Convert.ToBase64String(hash);
		}
	}

	public class PayOSResponse
	{
		public string PaymentUrl { get; set; }
	}

}
