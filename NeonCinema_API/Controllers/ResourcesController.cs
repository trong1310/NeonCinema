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
		[HttpGet("generate-invoice-pdf/{billId}")]
		public async Task<IActionResult> GenerateInvoicePdf(Guid billId)
		{
			// Lấy hóa đơn từ database
			var bill = await _context.BillDetails
	.Include(b => b.Users) // Lấy thông tin người dùng
	.Include(b => b.BillTickets) // Lấy danh sách BillTickets
		.ThenInclude(bt => bt.Tickets) // Lấy thông tin vé (Ticket)
			.ThenInclude(t => t.Movies) // Lấy thông tin phim
	.FirstOrDefaultAsync(b => b.ID == billId);

			if (bill == null)
			{
				return NotFound("Không tìm thấy hóa đơn.");
			}

			using (var stream = new MemoryStream())
			{
				var writer = new PdfWriter(stream);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);

				// Thiết lập font
				var fontPath = Path.Combine("wwwroot", "fonts", "ttf", "DejaVuSans-Bold.ttf");
				var boldFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
				var normalFont = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);

				// Tiêu đề hóa đơn
				document.Add(new Paragraph(new Text("NeonCinemas").SetFont(boldFont).SetFontSize(20))
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph(new Text("Địa chỉ: số 1 Việt Nam\nĐiện thoại: 0334583920\nTK 1160087273 – BIDV – Nguyen Van Trong")
					.SetFont(normalFont).SetFontSize(10))
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph(new Text("HÓA ĐƠN THANH TOÁN").SetFont(boldFont).SetFontSize(15))
					.SetTextAlignment(TextAlignment.CENTER));
				document.Add(new Paragraph("\n"));

				// Thông tin hóa đơn
				document.Add(new Paragraph(new Text($"HD: {bill.BillCode}\nNgày: {bill.CreatedTime:dd/MM/yyyy}\nTên khách hàng: {bill.Users?.FullName}")
					.SetFont(normalFont).SetFontSize(12))
					.SetTextAlignment(TextAlignment.LEFT));
				document.Add(new Paragraph("\n"));
				var table = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 2, 2 })).UseAllAvailableWidth();
				table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Tên phim").SetFont(boldFont))));
				table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Đơn giá").SetFont(boldFont))));
				table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Số lượng").SetFont(boldFont))));
				table.AddHeaderCell(new Cell().Add(new Paragraph(new Text("Thành tiền").SetFont(boldFont))));

				// Lặp qua từng BillTicket
				foreach (var billTicket in bill.BillTickets)
				{
					var ticket = billTicket.Tickets;
					var movie = ticket?.Movies;

					if (movie != null)
					{
						table.AddCell(new Paragraph(new Text(movie.Name).SetFont(normalFont))); // Tên phim
						table.AddCell(new Paragraph(new Text($"{ticket.Price:n0} VND").SetFont(normalFont))); // Giá vé
						table.AddCell(new Paragraph(new Text("1").SetFont(normalFont))); // Số lượng luôn là 1
						table.AddCell(new Paragraph(new Text($"{ticket.Price:n0} VND").SetFont(normalFont))); // Tổng tiền (Price * 1)
					}
				}
				document.Add(table);
				document.Add(new Paragraph("\n"));

				// Tổng tiền
				document.Add(new Paragraph(new Text($"Tổng tiền: {bill.TotalPrice:n0} VND").SetFont(boldFont).SetFontSize(12))
					.SetTextAlignment(TextAlignment.RIGHT));

				// Ghi chú cuối
				document.Add(new Paragraph(new Text("NeonCinemas xin cảm ơn quý khách, hẹn gặp lại").SetFont(normalFont).SetFontSize(12))
					.SetTextAlignment(TextAlignment.CENTER));

				document.Close();
				writer.Close();

				// Trả file PDF về client
				return File(stream.ToArray(), "application/pdf", "HoaDon.pdf");
			}
		}
	}
}
