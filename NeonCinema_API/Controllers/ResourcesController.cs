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
using iText.Kernel.Colors;
using System.Runtime.InteropServices;
using ZXing.Common;
using ZXing;
using SkiaSharp;


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
			var bill = await _context.BillDetails.AsNoTracking()
				.Include(x => x.UserID)
				.Include(x => x.Ticket)
				.ThenInclude(x => x.Screenings)
				.ThenInclude(x => x.ShowTime)
				.ThenInclude(a => a.Screening).ThenInclude(x => x.Rooms)
				.ThenInclude(x => x.Seats).Include(x => x.BillCombos).Where(x => x.ID == billId).FirstOrDefaultAsync();

			if (bill == null)
			{
				return NotFound("Không tìm thấy hóa đơn.");
			}

			var billDetails = new
			{
				BillCode = bill.BillCode,
				CustomerName = bill.Users?.FullName ?? "Khách hàng",
				TheaterName = "Neon Cinemas",
				TheaterAddress = "Số 1 Việt Nam, Hà Nội",
				PrintedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
				Tickets = bill.Ticket.Select(ticket => new
				{
					MovieName = ticket.Movies.Name,
					ShowDate = ticket.Screenings.ShowDate,
					StartTime = ticket.Screenings.ShowTime.StartTime,
					SeatNumber = $"{ticket.Seat.Row}{ticket.Seat.Column}",
					Room = ticket.Screenings.Rooms.Name,
					Price = ticket.Price
				}),
				Combos = bill.BillCombos.Select(combo => new
				{
					ComboName = combo.FoodCombo.Content,
					Quantity = combo.Quantity,
					Price = combo.FoodCombo.TotalPrice
				}),
				TotalPrice = bill.TotalPrice
			};

			return Ok(billDetails);
		}



		[HttpGet("generate-invoice-pdf")]
		public async Task<IActionResult> GenerateInvoicePdf(Guid billId)
		{
			try
			{
				var tickets = await _context.Tickets
					.Include(bt => bt.Bills).ThenInclude(b => b.Users)
					.Include(bt => bt.Bills).ThenInclude(b => b.BillCombos).ThenInclude(bc => bc.FoodCombo)
					.Include(t => t.Seat).ThenInclude(s => s.SeatTypes)
					.Include(t => t.Movies)
					.Include(t => t.Screenings).ThenInclude(sc => sc.ShowTime)
					.Include(t => t.Screenings).ThenInclude(sc => sc.Rooms)
					.Where(bt => bt.BillId == billId)
					.ToListAsync();

				if (tickets == null || !tickets.Any())
				{
					return NotFound("Không tìm thấy thông tin hóa đơn hoặc vé.");
				}

				var bill = tickets.First().Bills;

				// Tạo thư mục tạm để lưu file PDF
				var tempFolder = Path.Combine("wwwroot", "tickets_temp");
				if (!Directory.Exists(tempFolder))
					Directory.CreateDirectory(tempFolder);
				// Tìm nhân viên tạo hóa đơn từ UserID
				var staff = await _context.Users
	.AsNoTracking() // Thêm AsNoTracking để tối ưu hóa
	.FirstOrDefaultAsync(u => u.ID == bill.CreatedBy);

				string staffName = staff != null ? staff.FullName : "Nhân viên (không xác định)";


				List<string> pdfFilePaths = new List<string>();

				// 1. Tạo hóa đơn tổng
				string summaryFileName = $"HoaDon_Tong_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
				var summaryPdfPath = Path.Combine(tempFolder, summaryFileName);
				GenerateBillSummaryPdf_WithCombo(tickets, staffName, bill.BillCombos.Sum(cb => cb.FoodCombo.TotalPrice * cb.Quantity), bill.TotalPrice, summaryPdfPath);
				pdfFilePaths.Add(summaryPdfPath);

				// 2. Tạo hóa đơn cho từng ghế
				foreach (var ticket in tickets)
				{
					string seatName = $"{ticket.Seat.Column}{ticket.Seat.Row}";
					string seatPdfFileName = $"HoaDon_Ghe_{seatName}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
					var seatPdfPath = Path.Combine(tempFolder, seatPdfFileName);

					GenerateSingleSeatPdf_NoCombo(ticket, staffName, seatPdfPath);
					pdfFilePaths.Add(seatPdfPath);
				}

				// 3. Tạo hóa đơn combo
				string comboFileName = $"HoaDon_Combo_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
				var comboPdfPath = Path.Combine(tempFolder, comboFileName);
				GenerateComboPdf(bill.BillCombos.ToList(), staffName, bill, comboPdfPath);
				pdfFilePaths.Add(comboPdfPath);

				// 4. Đóng gói tất cả các file PDF vào file ZIP
				string zipFileName = $"HoaDon_{bill.BillCode}_{DateTime.Now:yyyyMMddHHmmss}.zip";
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

				// Trả file ZIP về client
				var zipBytes = System.IO.File.ReadAllBytes(zipFilePath);
				return File(zipBytes, "application/octet-stream", zipFileName);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Lỗi: {ex.Message}");
			}
		}

		// ============== HÀM 1: PDF TỔNG (CÓ combos + tổng tiền) ===================
		private void GenerateBillSummaryPdf_WithCombo(
		List<Ticket> tickets,
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

				// Load fonts for Vietnamese support
				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans.ttf");
				var boldFontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var boldFont = PdfFontFactory.CreateFont(boldFontPath, PdfEncodings.IDENTITY_H);

				var bill = tickets.First().Bills;

				// Header
				document.Add(new Paragraph("NeonCinemas")
					.SetFont(boldFont)
					.SetFontSize(20)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Địa chỉ: Lotte Kosmo Tây Hồ - Kosmo Tây Hồ - Xuân La")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Hóa đơn thanh toán")
					.SetFont(boldFont)
					.SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("\n"));

				// Bill Information Table
				var infoTable = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 }))
					.UseAllAvailableWidth()
					.SetMarginBottom(10);
				infoTable.AddCell(new Cell().Add(new Paragraph("Mã hóa đơn:").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Khách hàng:").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph(bill.Users?.FullName ?? "Khách hàng").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Nhân viên xuất:").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph(staffName).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Thời gian xuất hóa đơn:").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(infoTable);
				document.Add(new Paragraph("\n"));



				// Service Details Table
				var detailTable = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2 }))
					.UseAllAvailableWidth()
					.SetMarginBottom(10);
				detailTable.AddHeaderCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));

				foreach (var ticket in tickets)
				{
					detailTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {ticket.Movies?.Name}").SetFont(normalFont).SetFontSize(10)));
					detailTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {ticket.Seat.SeatNumber}").SetFont(normalFont).SetFontSize(10)));
					detailTable.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ").SetFont(normalFont).SetFontSize(10)));
				}

				foreach (var combo in bill.BillCombos)
				{
					detailTable.AddCell(new Cell().Add(new Paragraph($"Combo: {combo.FoodCombo.Content}").SetFont(normalFont).SetFontSize(10)));
					detailTable.AddCell(new Cell().Add(new Paragraph($"{combo.Quantity}").SetFont(normalFont).SetFontSize(10)));
					detailTable.AddCell(new Cell().Add(new Paragraph($"{combo.FoodCombo.TotalPrice * combo.Quantity:n0}đ").SetFont(normalFont).SetFontSize(10)));
				}

				document.Add(detailTable);
				document.Add(new Paragraph("\n"));

				// Total Price Section
				document.Add(new Paragraph($"Tạm tính: {bill.TotalPrice.ToString("N0")}đ")
					.SetFont(normalFont)
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.LEFT));
				document.Add(new Paragraph($"Phụ phí phim: {bill.Surcharge ?? 0:n0}đ")
					.SetFont(normalFont)
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.LEFT));
				document.Add(new Paragraph($"Giảm giá: {bill.TotalPoint ?? 0:n0}đ")
		   .SetFont(normalFont)
		   .SetFontSize(12)
		   .SetTextAlignment(TextAlignment.LEFT));
				document.Add(new Paragraph($"Thành tiền: {bill.AfterDiscount:n0}đ")
					.SetFont(boldFont)
					.SetFontSize(14)
					.SetTextAlignment(TextAlignment.LEFT));
				document.Add(new Paragraph("\n"));
				// Add Barcode for Bill Code
				AddBarcodeToPdf(document, bill.BillCode.ToString());
				document.Add(new Paragraph("\n"));

				// Footer
				document.Add(new Paragraph("Cảm ơn quý khách đã sử dụng dịch vụ của NeonCinemas!")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Close();
				writer.Close();

				// Save the PDF file
				System.IO.File.WriteAllBytes(outputPath, ms.ToArray());
			}
		}

		private void AddBarcodeToPdf(Document document, string billCode)
		{
			// Create the barcode writer
			var barcodeWriter = new ZXing.SkiaSharp.BarcodeWriter
			{
				Format = ZXing.BarcodeFormat.CODE_128,
				Options = new ZXing.Common.EncodingOptions
				{
					Height = 50,  // Height of the barcode
					Width = 200,  // Width of the barcode
					Margin = 2    // Margin around the barcode
				}
			};

			// Generate the barcode as a SkiaSharp Bitmap
			var skBitmap = barcodeWriter.Write(billCode);

			using (var ms = new MemoryStream())
			{
				// Encode the SkiaSharp Bitmap to a PNG
				skBitmap.Encode(ms, SkiaSharp.SKEncodedImageFormat.Png, 100);
				var barcodeImageData = iText.IO.Image.ImageDataFactory.Create(ms.ToArray());

				// Add barcode to the PDF
				var barcodeImage = new iText.Layout.Element.Image(barcodeImageData)
					.SetWidth(200)
					.SetHeight(50)
					.SetHorizontalAlignment(HorizontalAlignment.CENTER);
				document.Add(barcodeImage);
			}
		}


		// ============== HÀM 2: PDF CHO MỖI GHẾ (KHÔNG combo, KHÔNG tổng) ================
		private void GenerateSingleSeatPdf_NoCombo(Ticket ticket, string staffName, string outputPath)
		{
			using (var ms = new MemoryStream())
			{
				var writer = new PdfWriter(ms);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);

				// Load fonts for Vietnamese support
				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans.ttf");
				var boldFontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var boldFont = PdfFontFactory.CreateFont(boldFontPath, PdfEncodings.IDENTITY_H);

				var bill = ticket.Bills;

				// Header
				document.Add(new Paragraph("NeonCinemas")
					.SetFont(boldFont)
					.SetFontSize(20)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Địa chỉ: Lotte Kosmo Tây Hồ - Kosmo Tây Hồ - Xuân La")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Vé xem phim")
					.SetFont(boldFont)
					.SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("\n"));

				// Thông tin hóa đơn
				var infoTable = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 }))
					.UseAllAvailableWidth()
					.SetMarginBottom(10);
				infoTable.AddCell(new Cell().Add(new Paragraph("Mã hóa đơn:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Khách hàng:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{bill.Users?.FullName ?? "Khách hàng"}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Nhân viên xuất:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph(staffName).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Thời gian xuất hóa đơn:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(infoTable);
				document.Add(new Paragraph("\n"));

				// Chi tiết vé
				var detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2 }))
					.UseAllAvailableWidth()
					.SetMarginBottom(10);
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));

				detailsTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {ticket.Movies?.Name}").SetFont(normalFont).SetFontSize(10)));
				detailsTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {ticket.Seat.SeatNumber}").SetFont(normalFont).SetFontSize(10)));
				detailsTable.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ").SetFont(normalFont).SetFontSize(10)));

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// Add barcode for Bill Code
				AddBarcodeToPdf(document, bill.BillCode.ToString());
				document.Add(new Paragraph("\n"));

				// Footer
				document.Add(new Paragraph("Cảm ơn quý khách đã sử dụng dịch vụ của NeonCinemas!")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Close();
				writer.Close();

				// Save the PDF file
				System.IO.File.WriteAllBytes(outputPath, ms.ToArray());
			}
		}


		private void GenerateComboPdf(List<BillCombo> billCombos, string staffName, Bill bill, string outputPath)
		{
			using (var ms = new MemoryStream())
			{
				var writer = new PdfWriter(ms);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);

				// Sử dụng font chữ giống hóa đơn tổng
				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans.ttf");
				var boldFontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var boldFont = PdfFontFactory.CreateFont(boldFontPath, PdfEncodings.IDENTITY_H);

				// Header
				document.Add(new Paragraph("NeonCinemas")
					.SetFont(boldFont)
					.SetFontSize(20)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Địa chỉ: Lotte Kosmo Tây Hồ - Kosmo Tây Hồ - Xuân La")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("Hóa đơn Combo")
					.SetFont(boldFont)
					.SetFontSize(15)
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("\n"));

				// Bảng thông tin hóa đơn
				var infoTable = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 }))
					.UseAllAvailableWidth()
					.SetMarginBottom(10);
				infoTable.AddCell(new Cell().Add(new Paragraph("Mã hóa đơn:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Khách hàng:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{bill.Users?.FullName ?? "Khách hàng"}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Nhân viên xuất:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph(staffName).SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph("Thời gian xuất hóa đơn:").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				infoTable.AddCell(new Cell().Add(new Paragraph($"{DateTime.Now:dd/MM/yyyy HH:mm:ss}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(infoTable);
				document.Add(new Paragraph("\n"));

				// Bảng chi tiết combo
				var detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 3, 5, 1, 2 }))
					.UseAllAvailableWidth()
					.SetMarginBottom(10);

				// Tiêu đề bảng
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Combo").SetFont(boldFont).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Mô tả").SetFont(boldFont).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));

				decimal totalComboPrice = 0;
				foreach (var combo in billCombos)
				{
					decimal comboPrice = combo.FoodCombo.TotalPrice * combo.Quantity;
					totalComboPrice += comboPrice;

					detailsTable.AddCell(new Cell().Add(new Paragraph(combo.FoodCombo.Content).SetFont(normalFont).SetFontSize(10).SetTextAlignment(TextAlignment.LEFT)));
					detailsTable.AddCell(new Cell().Add(new Paragraph(combo.FoodCombo.Description).SetFont(normalFont).SetFontSize(10).SetTextAlignment(TextAlignment.LEFT)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{combo.Quantity}").SetFont(normalFont).SetFontSize(10).SetTextAlignment(TextAlignment.CENTER)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{comboPrice:n0}đ").SetFont(normalFont).SetFontSize(10).SetTextAlignment(TextAlignment.RIGHT)));
				}

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// Tổng tiền combo
				document.Add(new Paragraph($"Tổng tiền combo: {totalComboPrice:n0}đ")
					.SetFont(boldFont)
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.RIGHT));

				// Footer
				document.Add(new Paragraph("Cảm ơn quý khách đã sử dụng dịch vụ của NeonCinemas!")
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


