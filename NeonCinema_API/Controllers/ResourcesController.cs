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

namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ResourcesController : ControllerBase
	{
		private readonly NeonCinemasContext _context;
		public ResourcesController(NeonCinemasContext context)
		{
			_context = context;
		}
		[HttpGet("{name}")]
		//[Authorize]
		public PhysicalFileResult Get([FromRoute] string name)
		{
			string namefile = Uri.UnescapeDataString(name);
			string path = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
			string filePath = Path.Combine(path, namefile);
			return PhysicalFile(filePath, "image/jpeg");
		}
		[HttpPost("upload")]
		public async Task<IActionResult> Upload(IFormFile file)
		{
			if (file == null || file.Length == 0)
				return BadRequest("No file uploaded.");

			var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
			var fileName = Path.GetFileName(file.FileName);
			var filePath = Path.Combine(uploadsFolderPath, fileName);

			// Kiểm tra thư mục có tồn tại không, nếu không thì tạo mới
			if (!Directory.Exists(uploadsFolderPath))
			{
				Directory.CreateDirectory(uploadsFolderPath);
			}

			using (var fileStream = new FileStream(filePath, FileMode.Create))
			{
				await file.CopyToAsync(fileStream);
			}

			var imageUrl = $"https://localhost:7211/Resources/{fileName}";
			return Ok(new { ImageUrl = imageUrl });
		}
		[HttpGet("get-bill-details/{billId}")]
		public async Task<IActionResult> GetBillDetails(Guid billId)
		{
			var bill = await _context.BillTickets
				.Include(b => b.Bills).ThenInclude(b => b.Users) // Khách hàng
				.Include(b => b.Tickets).ThenInclude(t => t.Movies) // Phim
				.Include(b => b.Tickets).ThenInclude(t => t.Screenings).ThenInclude(s => s.Rooms) // Phòng chiếu
				.Include(b => b.Bills).ThenInclude(b => b.BillCombos).ThenInclude(bc => bc.FoodCombo) // Combo
				.FirstOrDefaultAsync(b => b.BillId == billId);

			if (bill == null)
			{
				return NotFound("Không tìm thấy hóa đơn.");
			}

			var billDetails = new
			{
				BillCode = bill.Bills.BillCode,
				CustomerName = bill.Bills.Users?.FullName ?? "Khách hàng",
				TheaterName = "Neon Cinemas",
				TheaterAddress = "Số 1 Việt Nam, Hà Nội",
				PrintedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
				Tickets = bill.Tickets.BillTickets.Select(ticket => new
				{
					MovieName = ticket.Tickets.Movies.Name,
					ShowDate = ticket.Tickets.Screenings.ShowDate,
					StartTime = ticket.Tickets.Screenings.ShowTime.StartTime,
					SeatNumber = $"{ticket.Tickets.Seat.Row}{ticket.Tickets.Seat.Column}",
					Room = ticket.Tickets.Screenings.Rooms.Name,
					Price = ticket.Tickets.Price
				}),
				Combos = bill.Bills.BillCombos.Select(combo => new
				{
					ComboName = combo.FoodCombo.Content,
					Quantity = combo.Quantity,
					Price = combo.FoodCombo.TotalPrice
				}),
				TotalPrice = bill.Bills.TotalPrice
			};

			return Ok(billDetails);
		}


		[HttpGet("generate-invoice-pdf/{billTicketId}")]
		public async Task<IActionResult> GenerateInvoicePdf(Guid billTicketId)
		{
			// 1) Lấy danh sách BillTickets
			var billTickets = await _context.BillTickets
				.Include(bt => bt.Bills).ThenInclude(b => b.Users)
				.Include(bt => bt.Bills).ThenInclude(b => b.BillCombos).ThenInclude(bc => bc.FoodCombo)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Seat).ThenInclude(s => s.SeatTypes)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Movies)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Screenings).ThenInclude(sc => sc.ShowTime)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Screenings).ThenInclude(sc => sc.Rooms)
				.Where(bt => bt.BillId == billTicketId)
				.ToListAsync();

			if (billTickets == null || !billTickets.Any())
			{
				return NotFound("Không tìm thấy thông tin hóa đơn hoặc vé.");
			}

			var bill = billTickets.First().Bills;

			// Tìm user Staff (nhân viên)
			var staff = _context.Users
				.Include(u => u.Roles)
				.FirstOrDefault(u => u.Roles.RoleName == "Staff");
			string staffName = staff != null ? staff.FullName : "Nhân viên (không xác định)";

			// 2) Tạo folder tạm
			var tempFolder = Path.Combine("wwwroot", "tickets_temp");
			if (!Directory.Exists(tempFolder))
				Directory.CreateDirectory(tempFolder);

			// Danh sách file PDF cần nén
			List<string> pdfFilePaths = new List<string>();

			// Tính tổng combos + tổng tiền Bill (có combos)
			decimal totalComboPrice = bill.BillCombos.Sum(cb => cb.FoodCombo.TotalPrice * cb.Quantity);
			decimal totalBillPrice = billTickets.Sum(bt => bt.Tickets.Price) + totalComboPrice;

			// Bước A: Tạo PDF TỔNG (có combos + tổng tiền)
			string summaryFileName = $"HoaDon_TONG_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
			var summaryPdfPath = Path.Combine(tempFolder, summaryFileName);
			GenerateBillSummaryPdf_WithCombo(billTickets, staffName, totalComboPrice, totalBillPrice, summaryPdfPath);
			pdfFilePaths.Add(summaryPdfPath);

			// Bước B: Mỗi ghế -> 1 file PDF (chỉ giá ghế)
			foreach (var bt in billTickets)
			{
				var ticket = bt.Tickets;
				if (ticket == null) continue;

				string seatName = $"{ticket.Seat.Column}{ticket.Seat.Row}";
				string pdfFileName = $"Ticket_{seatName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
				var pdfPath = Path.Combine(tempFolder, pdfFileName);

				GenerateSingleSeatPdf_NoCombo(bt, staffName, pdfPath);
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

		// ============== HÀM 1: PDF TỔNG (CÓ combos + tổng tiền) ===================
		private void GenerateBillSummaryPdf_WithCombo(
			List<BillTicket> billTickets,
			string staffName,
			decimal totalComboPrice,
			decimal totalBillPrice,
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

				var bill = billTickets.First().Bills;

				// Tạo pdfUrl ảo
				string pdfUrl = "NoURL"; // link ảo

				// HEADER
				document.Add(new Paragraph("NeonCinemas")
					.SetFont(boldFont)
					.SetFontSize(20)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Địa chỉ: Số 1 Việt Nam\nĐiện thoại: 0334583920\nTài khoản: 1160087273 – BIDV – Nguyễn Văn Trọng")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Hóa đơn thanh toán (Tổng)")
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

				// Lấy info screening
				var screening = billTickets.First().Tickets.Screenings;
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
				foreach (var bt in billTickets)
				{
					var ticket = bt.Tickets;
					if (ticket != null)
					{
						detailsTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {ticket.Movies?.Name}")
							.SetFont(normalFont).SetFontSize(10)));
						detailsTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {ticket.Seat.Column}{ticket.Seat.Row}")
							.SetFont(normalFont).SetFontSize(10)));
						detailsTable.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ")
							.SetFont(normalFont).SetFontSize(10)));
					}
				}

				// Combo
				 totalComboPrice = 0;
				foreach (var combo in bill.BillCombos)
				{
					decimal total = combo.FoodCombo.TotalPrice * combo.Quantity;
					totalComboPrice += total;
					detailsTable.AddCell(new Cell().Add(new Paragraph($"Combo: {combo.FoodCombo.Content}")
						.SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{combo.Quantity}")
						.SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{total:n0}đ")
						.SetFont(normalFont).SetFontSize(10)));
				}

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// Tính total
				decimal sumTickets = billTickets.Sum(bt => bt.Tickets.Price);
				decimal finalTotal = sumTickets + totalComboPrice;
				document.Add(new Paragraph($"Tổng tiền: {finalTotal:n0}đ")
					.SetFont(boldFont).SetFontSize(12).SetTextAlignment(TextAlignment.RIGHT));

				// QR code
				document.Add(new Paragraph("\n"));
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
								.SetWidth(80).SetHeight(80)
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

		// ============== HÀM 2: PDF CHO MỖI GHẾ (KHÔNG combo, KHÔNG tổng) ================
		private void GenerateSingleSeatPdf_NoCombo(
			BillTicket bt,
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

				var bill = bt.Bills;
				var ticket = bt.Tickets;
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

	}


}


	