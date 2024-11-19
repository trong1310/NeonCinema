using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Infrastructure.Database.AppDbContext;

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

   //     public async Task<IActionResult> ExportBill(Guid billId)
   //     {
   //         try
   //         {
			//	string outputPath = "InvoiceTemplate.pdf";
			//	var invoiceData = new
			//	{
			//		BillCode = "HD12345",
			//		CreatedTime = "19/11/2024",
			//		CustommerName = "Nguyễn Văn A",
			//		Items = new List<dynamic>
			//		{
			//			new { Product = "Vé xem phim", UnitPrice = "100,000 VND", Quantity = 2, Total = "200,000 VND" },
			//			new { Product = "Bắp rang bơ", UnitPrice = "50,000 VND", Quantity = 1, Total = "50,000 VND" }
			//		}
			//	};
			//	var dataExpot = await _context.BillDetails.Include(x=>x.Users).Where(x=>x.ID == billId).FirstOrDefaultAsync();
			//	if (dataExpot == null) { return null; }

			//	using (PdfWriter writer = new PdfWriter(outputPath))
			//	using (PdfDocument pdfDoc = new PdfDocument(writer))
			//	using (Document document = new Document(pdfDoc))
			//	{
			//		// Thêm thông tin công ty và tiêu đề
			//		document.Add(new Paragraph("NeonCinemas")
			//			.SetFontSize(16).SetBold().SetTextAlignment(TextAlignment.CENTER));
			//		document.Add(new Paragraph("Địa chỉ: số 1 Việt Nam"));
			//		document.Add(new Paragraph("Điện thoại: 0334583920"));
			//		document.Add(new Paragraph("TK 1160087273 – BIDV – Nguyen Van Trong"));
			//		document.Add(new Paragraph(" "));
			//		document.Add(new Paragraph("HÓA ĐƠN THANH TOÁN").SetBold().SetTextAlignment(TextAlignment.CENTER));
			//		document.Add(new Paragraph(" "));

			//		// Thông tin hóa đơn
			//		document.Add(new Paragraph($"HD: {dataExpot.BillCode}"));
			//		document.Add(new Paragraph($"Ngày: {dataExpot.CreatedTime}"));
			//		document.Add(new Paragraph($"Tên khách hàng: {(dataExpot.UserID != null ? dataExpot.Users.FullName : null)}"));
			//		document.Add(new Paragraph(" "));

			//		// Tạo bảng với các cột: Sản phẩm, Đơn giá, Số lượng, Thành tiền
			//		Table table = new Table(UnitValue.CreatePercentArray(new float[] { 4, 2, 1, 2 }))
			//						.UseAllAvailableWidth()
			//						.SetMarginTop(10);

			//		// Thêm header cho bảng
			//		table.AddHeaderCell(new Cell().Add(new Paragraph("Sản phẩm").SetBold()));
			//		table.AddHeaderCell(new Cell().Add(new Paragraph("Đơn giá").SetBold()));
			//		table.AddHeaderCell(new Cell().Add(new Paragraph("Số lượng").SetBold()));
			//		table.AddHeaderCell(new Cell().Add(new Paragraph("Thành tiền").SetBold()));

			//		var billTicket = await _context.BillTickets.Include(x=>x.Tickets).Include(x=>x.Bills).Where(x => x.BillId == dataExpot.ID).ToListAsync();
			//		// Thêm dữ liệu vào bảng
			//		foreach (var item in billTicket)
			//		{
			//			table.AddCell(new Cell().Add(new Paragraph(item.Tickets.Seat.SeatNumber)));
			//			table.AddCell(new Cell().Add(new Paragraph(item.Tickets.Price.ToString("c"))));
			//			//table.AddCell(new Cell().Add(new Paragraph(item.Qu)));
			//			//table.AddCell(new Cell().Add(new Paragraph(item.Total)));
			//		}

			//		// Thêm bảng vào PDF
			//		document.Add(table);

			//		// Thêm tổng tiền
			//		document.Add(new Paragraph("Tổng tiền: 250,000 VND")
			//			.SetFontSize(12)
			//			.SetBold()
			//			.SetTextAlignment(TextAlignment.RIGHT));

			//		// Lời cảm ơn
			//		document.Add(new Paragraph("NeonCinemas xin cảm ơn quý khách, hẹn gặp lại.")
			//			.SetTextAlignment(TextAlignment.CENTER));
			//	}

			//	Console.WriteLine($"Hóa đơn đã được xuất tại: {outputPath}");
			//	return Ok();
			//}
			//catch
			//{
			//		throw new Exception();
			//}
		//}
    }
}
