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
			message.From.Add(new MailboxAddress("Your Company Name", _emailSettings.Username));
			message.To.Add(new MailboxAddress(bill.CustomerName, bill.Email));
			message.Subject = $"Hóa đơn đặt vé xem phim - Mã hóa đơn: {bill.BillCode}";

			var bodyBuilder = new BodyBuilder();

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
                    {string.Join("", bill.BillCombo.Select(c => $@"
                        <tr>
                            <td>{c.ComboName}</td>
                            <td>{c.Quantity}</td>
                            <td>{(c.Prices?.ToString("N0"))}</td>
                        </tr>
                    "))}
                </tbody>
            </table>
            <br>
            <table>
                <thead>
                    <tr>
                        <th>Ghế</th>
                        <th>Suất chiếu</th>
                        <th>Giá vé</th>
                    </tr>
                </thead>
                <tbody>
                    {string.Join("", bill.TicketResp.Select(t => $@"
                        <tr>
                            <td>{t.SeatNumber}</td>
                            <td>{t.ShowTime}</td>
                            <td>{t.Prices}</td>
                        </tr>
                    "))}
                </tbody>
            </table>
            <br>
            <table>
                <tr>
                    <td>Tổng tiền:</td>
                    <td>{bill.TotalPrice:C}</td>
                </tr>
                <tr>
                    <td>Giảm giá:</td>
                    <td>{bill.Voucher:C}</td>
                </tr>
                <tr>
                    <td>Thành tiền phải trả:</td>
                    <td>{bill.AfterPrice:C}</td>
                </tr>
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
	}
}
