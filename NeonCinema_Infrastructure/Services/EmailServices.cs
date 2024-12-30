using iText.Layout.Element;
using Microsoft.Extensions.Configuration;
using MimeKit;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;
using MailKit.Net.Smtp;
using Bogus;
using System.DrawingCore.Drawing2D;
using System.DrawingCore.Imaging;
using System.DrawingCore;
using ZXing.Common;
using ZXing;

namespace NeonCinema_Infrastructure.Services
{
	public class EmailSettings
	{
		public string Host { get; set; }
		public int Port { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
	}
	public class EmailServices
	{
		private readonly EmailSettings _emailSettings;
		public EmailServices(IConfiguration configuration)
		{
			_emailSettings = configuration.GetSection("EmailSetting").Get<EmailSettings>();
			if (_emailSettings == null)
			{
				throw new Exception("Cấu hình EmailSettings không được tìm thấy hoặc không đúng.");
			}
		}
		public async Task GenerateBillEmail(BillResp bill)
		{
			var message = new MimeMessage();
			message.From.Add(new MailboxAddress("Neon Cinemas", _emailSettings.Username));
			message.To.Add(new MailboxAddress(bill.CustomerName, bill.Email));
			message.Subject = $"Hóa đơn đặt vé xem phim - Mã hóa đơn: {bill.BillCode}";

			var bodyBuilder = new BodyBuilder();
			string barcodeFilePath = GenerateBarcodeToFile(bill.BillCode);
			var imageContentId = "barcodeImage";

			// Đính kèm tệp ảnh và đặt ContentId
			var linkedResource = bodyBuilder.LinkedResources.Add(barcodeFilePath);
			linkedResource.ContentId = imageContentId;
			linkedResource.ContentType.MediaType = "image/png";
			linkedResource.ContentType.Name = "barcode.png";
			linkedResource.IsAttachment = false;
			bodyBuilder.HtmlBody = $@"
        <!DOCTYPE html>
        <html>
        <head>
            <style>
                body {{ font-family: sans-serif; }}
                table {{ border-collapse: collapse; width: 100%; }}
                th, td {{ border: 1px solid #ddd; padding: 8px; }}
                th {{ background-color: #f2f2f2; }}
            </style>
        </head>
        <body>
            <h1>Hóa đơn đặt vé xem phim</h1>
            <p>Kính gửi: {bill.CustomerName}</p>
            <p>Cảm ơn quý khách đã đặt vé xem phim tại hệ thống của chúng tôi.</p>
            <p>Mã hóa đơn: {bill.BillCode}</p>
            <p>Ngày đặt vé: {bill.CreatedAt.ToString("dd/MM/yyyy HH:mm")}</p>
            <p>Phim: {bill.Films}</p>
        <img src=""cid:{imageContentId}"" alt=""Barcode"" />
            <br>
<table>
    <thead>
        <tr>
            <th>Tên combo</th>
            <th>Số lượng</th>
            <th>Đơn giá</th>
        </tr>
    </thead>
    <tbody>
        <!-- Thêm các combo -->
        {string.Join("", bill.BillCombo.Select(c => $@"
            <tr>
                <td>{c.ComboName}</td>
                <td>{c.Quantity}</td>
                <td>{(c.Prices?.ToString("N0"))}</td>
            </tr>
        "))}
        <!-- Thêm ghế và suất chiếu -->
        <tr>
            <th colspan=""3"" style=""text-align: left; background-color: #f2f2f2;"">Chi tiết vé</th>
        </tr>
        <tr>
            <th>Ghế</th>
            <th>Suất chiếu</th>
            <th>Giá vé</th>
        </tr>
        {string.Join("", bill.TicketResp.Select(t => $@"
            <tr>
                <td>{t.SeatNumber}</td>
                <td>{t.ShowTime}</td>
                <td>{(t.Prices?.ToString("N0"))}</td>
            </tr>
        "))}
        <!-- Thêm tổng tiền -->
        <tr>
            <th colspan=""2"" style=""text-align: left;"">Phụ thu phim :{bill.FilmsType}</th>
            <td>{bill.Surcharge?.ToString("N0")}</td>
        </tr>
 <tr>
            <th colspan=""2"" style=""text-align: left;"">Tạm tính</th>
            <td>{bill.TotalPrice?.ToString("N0")}</td>
        </tr>
        <tr>
            <th colspan=""2"" style=""text-align: left;"">Giảm giá:</th>
            <td>{bill.Voucher?.ToString("N0")}</td>
        </tr>
        <tr>
            <th colspan=""2"" style=""text-align: left;"">Thành tiền phải trả:</th>
            <td>{bill.AfterPrice?.ToString("N0")}</td>
        </tr>
    </tbody>
</table>
            <br>
            <p>Xin vui lòng mang mã hóa đơn này đến rạp để nhận vé.</p>
            <p>Trân trọng,</p>
            <p>NeonCinemas</p>
        </body>
        </html>
    ";
			message.Body = bodyBuilder.ToMessageBody();

			// Use MimeKit for sending
			using (var client = new MailKit.Net.Smtp.SmtpClient())
			{
				client.Connect(_emailSettings.Host, _emailSettings.Port, false);
				client.Authenticate(_emailSettings.Username, _emailSettings.Password);
				await client.SendAsync(message);
				client.Disconnect(true);
			}
		}
			public string GenerateBarcodeToFile(long number)
			{
				// Nội dung mã vạch
				string barcodeContent = number.ToString();

				// Cấu hình BarcodeWriter
				var writer = new BarcodeWriterPixelData
				{
					Format = BarcodeFormat.CODE_128, // Định dạng mã vạch
					Options = new EncodingOptions
					{
						Height = 100, // Chiều cao mã vạch
						Width = 300,  // Chiều rộng mã vạch
						Margin = 10   // Lề
					}
				};

				// Tạo dữ liệu pixel từ mã vạch
				var pixelData = writer.Write(barcodeContent);

				// Chuyển dữ liệu pixel thành Bitmap
				using var barcodeBitmap = new Bitmap(pixelData.Width, pixelData.Height, PixelFormat.Format32bppRgb);
				var bitmapData = barcodeBitmap.LockBits(
					new Rectangle(0, 0, barcodeBitmap.Width, barcodeBitmap.Height),
					ImageLockMode.WriteOnly,
					PixelFormat.Format32bppRgb);

				try
				{
					System.Runtime.InteropServices.Marshal.Copy(pixelData.Pixels, 0, bitmapData.Scan0, pixelData.Pixels.Length);
				}
				finally
				{
					barcodeBitmap.UnlockBits(bitmapData);
				}

				// Kích thước ảnh cuối cùng (thêm không gian cho số và viền)
				int finalWidth = barcodeBitmap.Width + 40;  // Thêm 20px mỗi bên cho viền
				int finalHeight = barcodeBitmap.Height + 70; // Thêm không gian cho số và viền

				using var finalImage = new Bitmap(finalWidth, finalHeight);
				using (var graphics = Graphics.FromImage(finalImage))
				{
					// Đặt màu nền trắng
					graphics.Clear(Color.White);

					// Tăng chất lượng vẽ
					graphics.SmoothingMode = SmoothingMode.AntiAlias;

					// Tạo hình chữ nhật bo góc
					int borderRadius = 20; // Bán kính góc bo
					using var borderPen = new Pen(Color.Black, 3); // Viền đen, dày 3px

					// Vẽ hình chữ nhật bo góc
					using var path = new GraphicsPath();
					path.AddArc(5, 5, borderRadius, borderRadius, 180, 90); // Góc trên trái
					path.AddArc(finalWidth - borderRadius - 5, 5, borderRadius, borderRadius, 270, 90); // Góc trên phải
					path.AddArc(finalWidth - borderRadius - 5, finalHeight - borderRadius - 5, borderRadius, borderRadius, 0, 90); // Góc dưới phải
					path.AddArc(5, finalHeight - borderRadius - 5, borderRadius, borderRadius, 90, 90); // Góc dưới trái
					path.CloseFigure();

					graphics.DrawPath(borderPen, path);

					// Vẽ mã vạch ở giữa ảnh
					graphics.DrawImage(barcodeBitmap, 20, 20);
					// Vẽ số bên dưới mã vạch
					using var font = new Font("Arial", 16, FontStyle.Regular);
					using var brush = new SolidBrush(Color.Black);
					var stringSize = graphics.MeasureString(barcodeContent, font);
					graphics.DrawString(
						barcodeContent,
						font,
						brush,
						(finalWidth - stringSize.Width) / 2, // Căn giữa theo chiều ngang
						barcodeBitmap.Height + 30           // Vị trí bên dưới mã vạch
					);
				}

				// Lưu ảnh thành tệp
				string filePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.png");
				finalImage.Save(filePath, ImageFormat.Png);

				return filePath;
			}
	}
}
