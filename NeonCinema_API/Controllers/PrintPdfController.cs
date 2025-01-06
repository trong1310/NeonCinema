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
namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PrintPdfController : ControllerBase
	{
		private readonly NeonCinemasContext _context;
		private readonly EmailServices _emailServices;
		public PrintPdfController(NeonCinemasContext context, EmailServices emailServices)
		{
			_emailServices = emailServices;
			_context = context;
		}
		[HttpGet("generate-invoice-pdf")]
		public async Task<IActionResult> GenerateInvoicePdf(long code)
		{
			try
			{
				BillResp resp = new BillResp();
				// 1) Lấy danh sách BillTickets
				var tickets = await _context.Tickets
					.Include(bt => bt.Bills).ThenInclude(b => b.Users)
					.Include(bt => bt.Bills).ThenInclude(b => b.BillCombos).ThenInclude(bc => bc.FoodCombo)
					.Include(t => t.Seat).ThenInclude(s => s.SeatTypes)
					.Include(t => t.Movies)
					.Include(t => t.Screenings).ThenInclude(sc => sc.ShowTime)
					.Include(t => t.Screenings).ThenInclude(sc => sc.Rooms)
					.Where(bt => bt.Bills.BillCode == code)
					.ToListAsync();

				if (tickets == null || !tickets.Any())
				{
					return NotFound("Không tìm thấy thông tin hóa đơn hoặc vé.");
				}

				var bill = tickets.First().Bills;

				// Tìm nhân viên tạo hóa đơn từ `UserID`
				var staff = await _context.Users
					.FirstOrDefaultAsync(u => u.ID == bill.CreatedBy);
				string staffName = staff != null ? staff.FullName : "Nhân viên (không xác định)";

				// 2) Tạo folder tạm
				var tempFolder = Path.Combine("wwwroot", "tickets_temp");
				if (!Directory.Exists(tempFolder))
					Directory.CreateDirectory(tempFolder);

				// Danh sách file PDF cần nén
				List<string> pdfFilePaths = new List<string>();

				// Tính tổng combos + tổng tiền Bill (có combos)
				decimal totalComboPrice = bill.BillCombos.Sum(cb => cb.FoodCombo.TotalPrice * cb.Quantity);
				decimal totalBillPrice = tickets.Sum(bt => bt.Price) + totalComboPrice;

				// Bước A: Tạo PDF TỔNG (có combos + tổng tiền)
				string summaryFileName = $"HoaDon_ThanhToan_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
				var summaryPdfPath = Path.Combine(tempFolder, summaryFileName);
				GenerateBillSummaryPdf_WithCombo(resp);
				pdfFilePaths.Add(summaryPdfPath);

				// Bước B: Mỗi ghế -> 1 file PDF (chỉ giá ghế)
				foreach (var ticket in tickets)
				{
					if (ticket == null) continue;

					string seatName = $"{ticket.Seat.Column}{ticket.Seat.Row}";
					string pdfFileName = $"Ticket_{seatName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
					var pdfPath = Path.Combine(tempFolder, pdfFileName);

					GenerateSingleSeatPdf_NoCombo(ticket, staffName, pdfPath);
					pdfFilePaths.Add(pdfPath);
				}

				// 4) Nén tất cả PDF (1 PDF tổng + N PDF ghế) vào .zip
				string zipFileName = $"BillAndTickets_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.zip";
				var zipFilePath = Path.Combine(tempFolder, zipFileName);

				using (var zipArchiveStream = new FileStream(zipFilePath, FileMode.Create))
				using (var archive = new ZipArchive(zipArchiveStream, ZipArchiveMode.Create, true))
				{
					foreach (var pdfFile in pdfFilePaths)
					{
						var entryFileName = Path.GetFileName(pdfFile);
						var entry = archive.CreateEntry(entryFileName, CompressionLevel.Fastest);

						using (var entryStream = entry.Open())
						using (var fileStream = new FileStream(pdfFile, FileMode.Open))
						{
							await fileStream.CopyToAsync(entryStream);
						}
					}
				}

				// 5) Trả file .zip về client
				var zipBytes = System.IO.File.ReadAllBytes(zipFilePath);
				return File(zipBytes, "application/octet-stream", zipFileName);
			}
			catch (Exception ex)
			{
				throw new Exception($"Error {ex.Message} : {ex.StackTrace}");
			}
		}


		// ============== HÀM 1: PDF TỔNG (CÓ combos + tổng tiền) ===================
		private async void GenerateBillSummaryPdf_WithCombo(
			BillResp billReps)
		{
			using (var ms = new MemoryStream())
			{
				var writer = new PdfWriter(ms);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);

				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSerif.ttf");
				var boldFontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var boldFont = PdfFontFactory.CreateFont(boldFontPath, PdfEncodings.IDENTITY_H);

				// HEADER
				document.Add(new Paragraph("NeonCinemas")
					.SetFont(boldFont)
					.SetFontSize(20)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Địa chỉ: Tầng 1 , Vincom Center Trần Duy Hưng")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Hóa đơn thanh toán ")
					.SetFont(boldFont)
					.SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Add(new Paragraph("\n"));

				// Bảng info
				var invoiceInfo = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Hóa đơn: ").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{billReps.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Thời gian thanh toán: ").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{billReps.CreatedAt:dd/MM/yyyy}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Khách hàng").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{billReps.CustomerName ?? "Khách khách lẻ"}")
					.SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				// Nhân viên
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Nhân viên đặt vé").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(billReps.CreatedBy).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Thời gian xuất file").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}")
					.SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				// Lấy info screening
				var tickets = await _context.Tickets.Where(x => x.BillId == billReps.Id).ToListAsync();
				var screening = tickets.First().Screenings;
				var showTime = screening?.ShowTime;

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Suất chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(
					showTime != null ? $"{showTime.StartTime} - {showTime.EndTime}" : "Không xác định"
				).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Phòng chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(screening?.Rooms?.Name ?? "Không xác định")
					.SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(invoiceInfo);
				document.Add(new Paragraph("\n"));

				// BẢNG CHI TIẾT (Có combos, hiển thị combos + vé)
				var detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2 })).UseAllAvailableWidth();
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10)));

				// Vé
				foreach (var bt in tickets)
				{

					if (bt != null)
					{
						detailsTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {bt.Movies?.Name}")
							.SetFont(normalFont).SetFontSize(10)));
						detailsTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {bt.Seat.Column}{bt.Seat.Row}")
							.SetFont(normalFont).SetFontSize(10)));
						detailsTable.AddCell(new Cell().Add(new Paragraph($"{bt.Price:n0}đ")
							.SetFont(normalFont).SetFontSize(10)));
					}
				}

				// Combo
				decimal totalComboPrice = 0;
				foreach (var combo in billReps.BillCombo)
				{
					decimal total = (decimal)(combo.Prices * combo.Quantity);
					totalComboPrice += total;
					detailsTable.AddCell(new Cell().Add(new Paragraph($"Combo: {combo.ComboName}")
						.SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{combo.Quantity}")
						.SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{total:n0}đ")
						.SetFont(normalFont).SetFontSize(10)));
				}

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// Tính total
				decimal sumTickets = tickets.Sum(bt => bt.Price);
				decimal finalTotal = (decimal)billReps.TotalPrice;
				document.Add(new Paragraph($"Tổng tiền: {finalTotal:n0}đ")
					.SetFont(boldFont).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT));

				// Bar code
				document.Add(new Paragraph("\n"));
				try
				{
					var bodyBuilder = new BodyBuilder();
					string barcodeFilePath = _emailServices.GenerateBarcodeToFile(billReps.BillCode);
					var imageContentId = "barcodeImage";

					// Đính kèm tệp ảnh và đặt ContentId
					var linkedResource = bodyBuilder.LinkedResources.Add(barcodeFilePath);
					linkedResource.ContentId = imageContentId;
					linkedResource.ContentType.MediaType = "image/png";
					linkedResource.ContentType.Name = "barcode.png";
					linkedResource.IsAttachment = false;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Lỗi tạo QR code: " + ex.Message);
				}

				document.Add(new Paragraph("\nNeonCinemas xin cảm ơn quý khách, hẹn gặp lại!")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Close();
				writer.Close();
				var outputPath = Path.Combine("wwwroot", "tickets_temp", $"{billReps.BillCode}.pdf");
				Directory.CreateDirectory(Path.GetDirectoryName(outputPath)); // Tạo thư mục nếu chưa tồn tại

				// Ghi file PDF
				System.IO.File.WriteAllBytes(outputPath, ms.ToArray());
			}
		}

		// ============== HÀM 2: PDF CHO MỖI GHẾ (KHÔNG combo, KHÔNG tổng) ================
		private void GenerateSingleSeatPdf_NoCombo(
			Ticket ticket,
			string staffName,
			string outputPath)
		{
			using (var ms = new MemoryStream())
			{
				var writer = new PdfWriter(ms);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);

				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSerif.ttf");
				var boldFontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var boldFont = PdfFontFactory.CreateFont(boldFontPath, PdfEncodings.IDENTITY_H);

				var bill = ticket.Bills;
				string pdfUrl = "NoURL"; // Link ảo cho QR code

				// HEADER
				document.Add(new Paragraph("NeonCinemas")
					.SetFont(boldFont)
					.SetFontSize(20)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Địa chỉ: Số 1 Việt Nam\nĐiện thoại: 0334583920\nTài khoản: 1160087273 – BIDV – Nguyễn Văn Trọng")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Hóa đơn thanh toán (Ghế lẻ)")
					.SetFont(boldFont)
					.SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Add(new Paragraph("\n"));

				// Bảng info
				var invoiceInfo = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Hóa đơn").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Ngày tạo").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.CreatedTime:dd/MM/yyyy}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Khách hàng").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.Users?.FullName.ToLower() ?? "Khách hàng"}")
					.SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				// Nhân viên
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Nhân viên xuất file").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(staffName).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Thời gian xuất file").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}")
					.SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				var screening = ticket.Screenings;
				var showTime = screening?.ShowTime;

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Suất chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(
					showTime != null ? $"{showTime.StartTime} - {showTime.EndTime}" : "Không xác định"
				).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Phòng chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(screening?.Rooms?.Name ?? "Không xác định")
					.SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(invoiceInfo);
				document.Add(new Paragraph("\n"));

				// BẢNG CHI TIẾT VÉ (chỉ giá ghế)
				var detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2 })).UseAllAvailableWidth();
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10)));

				detailsTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {ticket.Movies?.Name}")
					.SetFont(normalFont).SetFontSize(10)));
				detailsTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {ticket.Seat.Column}{ticket.Seat.Row}")
					.SetFont(normalFont).SetFontSize(10)));
				detailsTable.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ")
					.SetFont(normalFont).SetFontSize(10)));

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// KHÔNG combo, KHÔNG tổng tiền

				// QR code
				try
				{
					using (var qrGenerator = new QRCodeGenerator())
					{
						var qrCodeData = qrGenerator.CreateQrCode(pdfUrl, QRCodeGenerator.ECCLevel.Q);
						var qrByteCode = new BitmapByteQRCode(qrCodeData);
						byte[] qrBytes = qrByteCode.GetGraphic(10, "#000000", "#FFFFFF");

						using (var msQr = new MemoryStream(qrBytes))
						{
							ImageData imgData = ImageDataFactory.Create(msQr.ToArray());
							var qrImage = new iText.Layout.Element.Image(imgData)
								.SetWidth(80)
								.SetHeight(80)
								.SetHorizontalAlignment(HorizontalAlignment.CENTER);

							document.Add(new Paragraph("Quét QR để mở hoá đơn PDF:")
								.SetFont(normalFont));
							document.Add(qrImage);
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Lỗi tạo QR code: " + ex.Message);
				}

				document.Add(new Paragraph("\nNeonCinemas xin cảm ơn quý khách, hẹn gặp lại!")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Close();
				writer.Close();

				// Ghi file PDF
				System.IO.File.WriteAllBytes(outputPath, ms.ToArray());
			}
		}

		// ========== Helper format TimeSpan "hh:mm" ==========
		private string TimeSpanToString(TimeSpan ts)
		{
			int hours = (int)ts.TotalHours;
			int minutes = ts.Minutes;
			return $"{hours:D2}:{minutes:D2}";
		}
		[HttpGet("generate-invoice-image/{billId}")]
		public async Task<IActionResult> GenerateInvoiceImage(Guid billId)
		{
			var bill = await _context.BillDetails
				.Include(b => b.BillCombos).ThenInclude(bc => bc.FoodCombo)
				.Include(bt => bt.Ticket).ThenInclude(t => t.Seat).ThenInclude(s => s.SeatTypes)
				.Include(bt => bt.Ticket).ThenInclude(t => t.Movies)
				.Include(bt => bt.Ticket).ThenInclude(t => t.Screenings).ThenInclude(sc => sc.Rooms)
				.Include(b => b.Users)
				.FirstOrDefaultAsync(b => b.ID == billId);

			if (bill == null)
			{
				return NotFound("Không tìm thấy hóa đơn.");
			}

			// Generate the invoice image
			string imagePath = Path.Combine("wwwroot", "invoices", $"{bill.BillCode}.png");

			GenerateInvoiceImage(bill, imagePath);

			return PhysicalFile(imagePath, "image/png");
		}

		// Helper method to generate invoice as an image
		private void GenerateInvoiceImage(Bill bill, string imagePath)
		{
			// Render the invoice details as an image (using any library like SkiaSharp or System.Drawing)
			using (var bitmap = new Bitmap(800, 1200)) // Create a blank canvas
			using (var graphics = Graphics.FromImage(bitmap))
			{
				graphics.FillRectangle(Brushes.White, 0, 0, 800, 1200);
				graphics.DrawString($"Mã Hóa Đơn: {bill.BillCode}", new Font("Arial", 16), Brushes.Black, new PointF(50, 50));
				graphics.DrawString($"Khách Hàng: {bill.Users.FullName}", new Font("Arial", 14), Brushes.Black, new PointF(50, 100));
				graphics.DrawString($"Ngày: {bill.CreatedTime?.ToString("dd/MM/yyyy")}", new Font("Arial", 14), Brushes.Black, new PointF(50, 150));
				graphics.DrawString($"Tổng Tiền: {bill.TotalPrice.ToString("N0")}", new Font("Arial", 14), Brushes.Black, new PointF(50, 200));

				// Draw each ticket
				int y = 250;
				foreach (var ticket in bill.Ticket)
				{
					graphics.DrawString($"Phim: {ticket.Movies.Name}", new Font("Arial", 12), Brushes.Black, new PointF(50, y));
					graphics.DrawString($"Ghế: {ticket.Seat.SeatNumber}", new Font("Arial", 12), Brushes.Black, new PointF(50, y + 30));
					graphics.DrawString($"Giá Vé: {ticket.Price:C0}", new Font("Arial", 12), Brushes.Black, new PointF(50, y + 60));
					y += 100;
				}

				// Save the image
				bitmap.Save(imagePath, ImageFormat.Png);
			}
		}
	}
}
