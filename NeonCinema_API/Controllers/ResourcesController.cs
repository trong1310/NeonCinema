﻿using iText.Kernel.Pdf;
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
			var bill = await _context.BillDetails
				.Include(b => b.Users) // Khách hàng
				.Include(b => b.BillTickets)
					.ThenInclude(bt => bt.Tickets)
						.ThenInclude(t => t.Seat) // Ghế
						.ThenInclude(s => s.SeatTypes) // Loại ghế
				.Include(b => b.BillTickets)
					.ThenInclude(bt => bt.Tickets)
						.ThenInclude(t => t.Movies) // Phim
				.Include(b => b.BillCombos)
					.ThenInclude(bc => bc.FoodCombo) // Combo thức ăn
				.FirstOrDefaultAsync(b => b.ID == billId);

			if (bill == null)
			{
				return NotFound("Không tìm thấy hóa đơn.");
			}

			var billDetails = new
			{
				BillCode = bill.BillCode,
				CreatedTime = bill.CreatedTime,
				CustomerName = bill.Users?.FullName,
				Tickets = bill.BillTickets.Select(bt => new
				{
					MovieName = bt.Tickets.Movies?.Name,
					Seat = $"Hàng {bt.Tickets.Seat.Row}, Cột {bt.Tickets.Seat.Column}",
					SeatType = bt.Tickets.Seat.SeatTypes?.SeatTypeName ?? "Ghế thường",
					Price = bt.Tickets.Price
				}),
				Combos = bill.BillCombos.Select(bc => new
				{
					Content = bc.FoodCombo.Content,
					Quantity = bc.FoodCombo.Quantity,
					TotalPrice = bc.FoodCombo.TotalPrice
				}),
				TotalPrice = bill.TotalPrice
			};

			return Ok(billDetails);
		}
		[HttpGet("generate-invoice-pdf/{billTicketId}")]
		public async Task<IActionResult> GenerateInvoicePdf(Guid billTicketId)
		{
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

			// Tìm user có RoleName = "Staff"
			var staff = _context.Users
				.Include(u => u.Roles)
				.FirstOrDefault(u => u.Roles.RoleName == "Staff");
			string staffName = staff != null ? staff.FullName : "Nhân viên (không xác định)";

			// --- BƯỚC 1: Đặt tên file PDF & đường dẫn local ---
			var invoiceFolder = Path.Combine("wwwroot", "invoices");
			if (!Directory.Exists(invoiceFolder))
				Directory.CreateDirectory(invoiceFolder);

			string fileName = $"HoaDon_{bill.Users?.FullName ?? "khachhang"}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
			var filePath = Path.Combine(invoiceFolder, fileName);

			// --- BƯỚC 2: Tạo URL public trỏ tới file PDF ---
			string pdfUrl = $"{Request.Scheme}://{Request.Host}/invoices/{fileName}";

			using (var stream = new MemoryStream())
			{
				var writer = new PdfWriter(stream);
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
				document.Add(new Paragraph("Địa chỉ: Số 1 Việt Nam\nĐiện thoại: 0334583920\nTài khoản: 1160087273 – BIDV – Nguyễn Văn Trọng")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Hóa đơn thanh toán")
					.SetFont(boldFont)
					.SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Add(new Paragraph("\n"));

				// Bảng thông tin Hóa đơn
				var invoiceInfo = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Hóa đơn").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Ngày tạo").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.CreatedTime:dd/MM/yyyy}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Khách hàng").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.Users?.FullName.ToLower() ?? "Khách hàng"}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				// Nhân viên xuất file
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Nhân viên xuất file").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(staffName).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				// Thời gian xuất file
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Thời gian xuất file").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				var screening = billTickets.First().Tickets.Screenings;
				var showTime = screening?.ShowTime;

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Suất chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(showTime != null ? $"{showTime.StartTime} - {showTime.EndTime}" : "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Phòng chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(screening?.Rooms?.Name ?? "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(invoiceInfo);
				document.Add(new Paragraph("\n"));

				// BẢNG CHI TIẾT VÉ / COMBO
				var detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2 })).UseAllAvailableWidth();
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10)));

				// Chi tiết vé
				foreach (var bt in billTickets)
				{
					var ticket = bt.Tickets;
					if (ticket != null)
					{
						detailsTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {ticket.Movies?.Name}").SetFont(normalFont).SetFontSize(10)));
						detailsTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {ticket.Seat.Column}{ticket.Seat.Row}").SetFont(normalFont).SetFontSize(10)));
						detailsTable.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ").SetFont(normalFont).SetFontSize(10)));
					}
				}

				// Chi tiết combo
				decimal totalComboPrice = 0;
				foreach (var combo in bill.BillCombos)
				{
					decimal total = combo.FoodCombo.TotalPrice * combo.Quantity;
					totalComboPrice += total;

					detailsTable.AddCell(new Cell().Add(new Paragraph($"Combo: {combo.FoodCombo.Content}").SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{combo.Quantity}").SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{total:n0}đ").SetFont(normalFont).SetFontSize(10)));
				}

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// TỔNG TIỀN
				decimal totalBillPrice = billTickets.Sum(bt => bt.Tickets.Price) + totalComboPrice;
				document.Add(new Paragraph($"Tổng tiền: {totalBillPrice:n0}đ")
					.SetFont(boldFont)
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.RIGHT));

				// THÊM QR CODE pdfUrl
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
								.SetWidth(80)
								.SetHeight(80)
								.SetHorizontalAlignment(HorizontalAlignment.CENTER);

							document.Add(new Paragraph("Quét QR để mở hoá đơn PDF:").SetFont(normalFont));
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

				// --- BƯỚC 3: Ghi PDF ra file ---
				System.IO.File.WriteAllBytes(filePath, stream.ToArray());
			}

			// --- BƯỚC 4: Trả file PDF về client ---
			var fileData = System.IO.File.ReadAllBytes(filePath);
			return File(fileData, "application/pdf", fileName);
		}
	

	[HttpGet("generate-multiple-pdf/{billId}")]
		public async Task<IActionResult> GenerateMultiplePdf(Guid billId)
		{
			// Lấy danh sách billTickets
			var billTickets = await _context.BillTickets
				.Include(bt => bt.Bills).ThenInclude(b => b.Users)
				.Include(bt => bt.Bills).ThenInclude(b => b.BillCombos).ThenInclude(bc => bc.FoodCombo)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Seat).ThenInclude(s => s.SeatTypes)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Movies)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Screenings).ThenInclude(sc => sc.ShowTime)
				.Include(bt => bt.Tickets).ThenInclude(t => t.Screenings).ThenInclude(sc => sc.Rooms)
				.Where(bt => bt.BillId == billId)
				.ToListAsync();

			if (billTickets == null || !billTickets.Any())
			{
				return NotFound("Không tìm thấy thông tin hóa đơn hoặc vé.");
			}

			var bill = billTickets.First().Bills;

			// Thư mục tạm (hoặc folder "wwwroot/ticketspdf")
			var tempFolder = Path.Combine("wwwroot", "tickets_temp");
			if (!Directory.Exists(tempFolder))
				Directory.CreateDirectory(tempFolder);

			// Xoá file cũ nếu muốn, hoặc để tuỳ ý
			// Directory.Delete(tempFolder, true); ... (cẩn thận)

			// Lưu danh sách đường dẫn PDF tạo ra
			List<string> pdfFilePaths = new List<string>();

			foreach (var bt in billTickets)
			{
				var ticket = bt.Tickets;
				if (ticket == null) continue;

				// Tạo tên file PDF riêng cho ghế
				// Ví dụ: Ticket_SeatA3_20241215_142300.pdf
				string seatName = $"{ticket.Seat.Column}{ticket.Seat.Row}";
				string pdfFileName = $"Ticket_{seatName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
				var pdfPath = Path.Combine(tempFolder, pdfFileName);

				// Gọi hàm GenerateSingleTicketPdf(...) -> tạo file PDF
				GenerateSingleTicketPdf(bt, pdfPath);

				pdfFilePaths.Add(pdfPath);
			}

			// Sau khi đã tạo xong tất cả PDF, ta nén vào 1 file .zip
			// Tên file ZIP
			string zipFileName = $"Tickets_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.zip";
			var zipFilePath = Path.Combine(tempFolder, zipFileName);

			using (var zipArchiveStream = new FileStream(zipFilePath, FileMode.Create))
			{
				using (var archive = new ZipArchive(zipArchiveStream, ZipArchiveMode.Create, true))
				{
					foreach (var pdfFile in pdfFilePaths)
					{
						// Lấy tên file (không kèm path)
						var entryFileName = Path.GetFileName(pdfFile);
						var entry = archive.CreateEntry(entryFileName, CompressionLevel.Fastest);

						using (var entryStream = entry.Open())
						using (var fileStream = new FileStream(pdfFile, FileMode.Open))
						{
							await fileStream.CopyToAsync(entryStream);
						}
					}
				}
			}

			// Optionally, xoá file PDF lẻ trong tempFolder
			// foreach (var pdf in pdfFilePaths) { System.IO.File.Delete(pdf); }

			// Cuối cùng, trả .zip về client
			var zipBytes = await System.IO.File.ReadAllBytesAsync(zipFilePath);
			return File(zipBytes, "application/octet-stream", zipFileName);
		}
		private void GenerateSingleTicketPdf(BillTicket bt, string outputPath)
		{
			// Tạo PDF in-memory
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

				document.Add(new Paragraph("NeonCinemas - Vé Xem Phim")
					.SetFont(boldFont)
					.SetFontSize(16)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Add(new Paragraph("\n"));

				var ticketInfo = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();
				ticketInfo.AddCell(new Cell().Add(new Paragraph("Mã hóa đơn").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				ticketInfo.AddCell(new Cell().Add(new Paragraph("Khách hàng").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph(bill.Users?.FullName ?? "Khách hàng").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				ticketInfo.AddCell(new Cell().Add(new Paragraph("Ghế").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph($"{ticket.Seat.Column}{ticket.Seat.Row} ({ticket.Seat.SeatTypes?.SeatTypeName})").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				var showTime = ticket.Screenings?.ShowTime;
				ticketInfo.AddCell(new Cell().Add(new Paragraph("Phim").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph(ticket.Movies?.Name ?? "N/A").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				ticketInfo.AddCell(new Cell().Add(new Paragraph("Suất chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph(
					showTime != null
					? $"{showTime.StartTime:HH:mm} - {showTime.EndTime:HH:mm}"
					: "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				ticketInfo.AddCell(new Cell().Add(new Paragraph("Phòng chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph(ticket.Screenings?.Rooms?.Name ?? "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				ticketInfo.AddCell(new Cell().Add(new Paragraph("Giá vé").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				ticketInfo.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(ticketInfo);
				document.Add(new Paragraph("\n"));

				// Thêm QR code hoặc Barcode tùy ý
				try
				{
					using (var qrGenerator = new QRCodeGenerator())
					{
						string content = $"Ticket_{ticket.ID}";
						var qrCodeData = qrGenerator.CreateQrCode(content, QRCodeGenerator.ECCLevel.Q);
						var qrByteCode = new BitmapByteQRCode(qrCodeData);
						byte[] qrBytes = qrByteCode.GetGraphic(10, "#000000", "#FFFFFF");

						using (var msQr = new MemoryStream(qrBytes))
						{
							ImageData imgData = ImageDataFactory.Create(msQr.ToArray());
							var qrImage = new iText.Layout.Element.Image(imgData)
								.SetWidth(80)
								.SetHeight(80)
								.SetHorizontalAlignment(HorizontalAlignment.CENTER);

							document.Add(new Paragraph($"Mã vé: {ticket.ID}").SetFont(normalFont).SetFontSize(10));
							document.Add(qrImage);
						}
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Lỗi tạo QR code: " + ex.Message);
				}

				document.Close();
				writer.Close();

				// Ghi file pdf ra outputPath
				System.IO.File.WriteAllBytes(outputPath, ms.ToArray());
			}
		}
	}
	}