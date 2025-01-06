using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.Bouncycastleconnector;
using iText.IO.Font.Constants;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Infrastructure.Database.AppDbContext;
using iText.IO.Font;
using NeonCinema_Domain.Database.Entities;
using iText.Layout.Borders;
using iText.IO.Image;
using QRCoder;
using System.Drawing;
using System.IO.Compression;
using System.Drawing.Imaging;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using MimeKit;
using NeonCinema_Infrastructure.Services;
using System.Text;
using System.Text.Json;
using System.Security.Cryptography;
namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		private readonly NeonCinemasContext _context;
		private readonly EmailServices _emailServices;
		public ServicesController(NeonCinemasContext context, EmailServices emailServices)
		{
			_emailServices = emailServices;
			_context = context;
		}
		public class ZaloPayService
		{
			private readonly string _appId = "YOUR_APP_ID";
			private readonly string _key = "YOUR_SECRET_KEY";

			public string CreatePayment(decimal amount, string appTransId, string description)
			{
				var requestBody = new
				{
					app_id = _appId,
					app_trans_id = appTransId,
					amount = amount,
					description = description,
					embed_data = "{}",
					callback_url = "https://yourwebsite.com/zalo_return"
				};

				var rawData = $"{_appId}|{appTransId}|{amount}|{description}|YOUR_SECRET_KEY";
				var mac = ComputeHmacSHA256(rawData);

				var requestJson = JsonSerializer.Serialize(new { requestBody, mac });
				using var httpClient = new HttpClient();
				var response = httpClient.PostAsync("https://sandbox.zalopay.vn/v001/tpe/createorder", new StringContent(requestJson, Encoding.UTF8, "application/json")).Result;
				return response.Content.ReadAsStringAsync().Result;
			}

			private string ComputeHmacSHA256(string rawData)
			{
				using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(_key));
				return BitConverter.ToString(hmac.ComputeHash(Encoding.UTF8.GetBytes(rawData))).Replace("-", "").ToLower();
			}
		}

	}
}
