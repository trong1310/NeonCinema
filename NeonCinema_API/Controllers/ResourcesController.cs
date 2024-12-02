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
			// Lấy BillTicket từ database và liên kết với các bảng liên quan
			var billTicket = await _context.BillTickets
				.Include(bt => bt.Bills)
					.ThenInclude(b => b.Users)
				.Include(bt => bt.Bills)
					.ThenInclude(b => b.BillCombos)
						.ThenInclude(bc => bc.FoodCombo)
				.Include(bt => bt.Tickets)
					.ThenInclude(t => t.Seat)
					.ThenInclude(s => s.SeatTypes)
				.Include(bt => bt.Tickets)
					.ThenInclude(t => t.Movies)
				.Include(bt => bt.Tickets)
					.ThenInclude(t => t.Screenings)
					.ThenInclude(sc => sc.ShowTime)
				.Include(bt => bt.Tickets)
					.ThenInclude(t => t.Screenings)
					.ThenInclude(sc => sc.Rooms)
				.FirstOrDefaultAsync(bt => bt.BillId == billTicketId);

			if (billTicket == null || billTicket.Bills == null)
			{
				return NotFound("Không tìm thấy thông tin hóa đơn hoặc vé.");
			}

			var bill = billTicket.Bills;

			using (var stream = new MemoryStream())
			{
				var writer = new PdfWriter(stream);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);

				// Thiết lập font
				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSerif.ttf");
				var boldFontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var boldFont = PdfFontFactory.CreateFont(boldFontPath, PdfEncodings.IDENTITY_H);

				// Phần tiêu đề hóa đơn
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

				// Thông tin hóa đơn
				var invoiceInfo = new Table(UnitValue.CreatePercentArray(new float[] { 3, 7 })).UseAllAvailableWidth();
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Hóa đơn").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.BillCode}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Ngày tạo").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.CreatedTime:dd/MM/yyyy}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Khách hàng").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph($"{bill.Users?.FullName.ToLower() ?? "không xác định"}").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Mua vé xem phim").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Phim").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(billTicket.Tickets.Movies?.Name ?? "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				var screening = billTicket.Tickets?.Screenings;
				var showTime = screening?.ShowTime;

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Suất chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(showTime != null ? $"{showTime.StartTime} - {showTime.EndTime}" : "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				invoiceInfo.AddCell(new Cell().Add(new Paragraph("Phòng chiếu").SetFont(boldFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));
				invoiceInfo.AddCell(new Cell().Add(new Paragraph(screening?.Rooms?.Name ?? "Không xác định").SetFont(normalFont).SetFontSize(10)).SetBorder(Border.NO_BORDER));

				document.Add(invoiceInfo);
				document.Add(new Paragraph("\n"));

				// Bảng chi tiết (vé + combo)
				var detailsTable = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2 })).UseAllAvailableWidth();
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Dịch vụ").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetFont(boldFont).SetFontSize(10)));
				detailsTable.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetFont(boldFont).SetFontSize(10)));

				// Thêm chi tiết vé
				var ticket = billTicket.Tickets;
				if (ticket != null)
				{
					var movie = ticket.Movies;
					detailsTable.AddCell(new Cell().Add(new Paragraph($"Vé xem phim: {movie?.Name}").SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"Ghế: {billTicket.Tickets.Seat.Row}{billTicket.Tickets.Seat.Column}").SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{ticket.Price:n0}đ").SetFont(normalFont).SetFontSize(10)));
				}

				// Thêm chi tiết combo
				decimal totalComboPrice = 0;
				foreach (var billCombo in bill.BillCombos)
				{
					var combo = billCombo.FoodCombo;
					var quantity = billCombo.Quantity;
					var total = combo.TotalPrice * quantity;
					totalComboPrice += total;

					detailsTable.AddCell(new Cell().Add(new Paragraph($"Combo: {combo?.Content}").SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{quantity}").SetFont(normalFont).SetFontSize(10)));
					detailsTable.AddCell(new Cell().Add(new Paragraph($"{total:n0}đ").SetFont(normalFont).SetFontSize(10)));
				}

				document.Add(detailsTable);
				document.Add(new Paragraph("\n"));

				// Tổng tiền
				decimal totalBillPrice = (ticket?.Price ?? 0) + totalComboPrice;
				document.Add(new Paragraph($"Tổng tiền: {totalBillPrice:n0}đ")
					.SetFont(boldFont)
					.SetFontSize(12)
					.SetTextAlignment(TextAlignment.RIGHT));

				// Ghi chú
				document.Add(new Paragraph("\nNeonCinemas xin cảm ơn quý khách, hẹn gặp lại!")
					.SetFont(normalFont)
					.SetFontSize(10)
					.SetTextAlignment(TextAlignment.CENTER));

				document.Close();
				writer.Close();

				// Trả file PDF về client
				return File(stream.ToArray(), "application/pdf", $"HoaDon_{bill.Users?.FullName ?? "khachhang"}.pdf");
			}
		}

	}
}
