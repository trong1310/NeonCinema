//using iText.Kernel.Pdf;
//using iText.Layout;
//using iText.Layout.Element;
//using iText.Layout.Properties;
//using iText.Kernel.Font;
//using iText.Bouncycastleconnector;
//using iText.IO.Font.Constants;
//using Microsoft.AspNetCore.Http;
//using System.IO;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using NeonCinema_Infrastructure.Database.AppDbContext;
//using iText.IO.Font;
//using NeonCinema_Domain.Database.Entities;
//using iText.Layout.Borders;
//using iText.IO.Image;
//using QRCoder;
//using System.Drawing;
//using System.IO.Compression;
//using System.Drawing.Imaging;
//using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
//using MimeKit;
//using NeonCinema_Infrastructure.Services;
//using System.Text;
//using System.Text.Json;
//using System.Security.Cryptography;
//namespace NeonCinema_API.Controllers
//{
//	[Route("api/[controller]")]
//	[ApiController]
//	public class ServicesController : ControllerBase
//	{
//		private readonly NeonCinemasContext _context;
//		private readonly HttpClient _httpClient;
//		private const string BaseUrl = "https://sandbox.api.payos.vn"; // Thay bằng URL API chính thức của PayOS
//		private const string ApiKey = "034d36fc-e272-4e29-9748-ee2e4c568e80"; // Thay bằng API Key từ PayOS

//		public ServicesController(NeonCinemasContext context, HttpClient httpClient)
//		{		
//			_context = context;
//			_httpClient = httpClient;
//			_httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {ApiKey}");
//		}
//		public async Task<string> CreatePaymentAsync(decimal amount, string description)
//		{
//			var endpoint = $"{BaseUrl}/payments";
//			var payload = new
//			{
//				amount,
//				currency = "VND",
//				description
//			};

//			var content = new StringContent(JsonSerializer.Serialize(payload), Encoding.UTF8, "application/json");
//			var response = await _httpClient.PostAsync(endpoint, content);

//			response.EnsureSuccessStatusCode();

//			var responseContent = await response.Content.ReadAsStringAsync();
//			var result = JsonSerializer.Deserialize<PayOSPaymentResponse>(responseContent);
//			return result?.PaymentUrl; // Trả về URL thanh toán để người dùng thực hiện chuyển khoản
//		}
//		public async Task<string> CheckPaymentStatusAsync(string transactionId)
//		{
//			var endpoint = $"{BaseUrl}/payments/{transactionId}";
//			var response = await _httpClient.GetAsync(endpoint);

//			response.EnsureSuccessStatusCode();

//			var responseContent = await response.Content.ReadAsStringAsync();
//			var result = JsonSerializer.Deserialize<PayOSPaymentStatusResponse>(responseContent);
//			return result?.Status; // Trả về trạng thái thanh toán
//		}
//	}
//	// Các lớp phản hồi từ PayOS
//	public class PayOSPaymentResponse
//	{
//		public string PaymentUrl { get; set; }
//	}

//	public class PayOSPaymentStatusResponse
//	{
//		public string Status { get; set; }
//	}
//}
