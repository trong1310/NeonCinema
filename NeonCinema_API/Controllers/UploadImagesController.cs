using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SixLabors.ImageSharp.Formats.Png;
using static System.Net.Mime.MediaTypeNames;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
namespace NeonCinema_API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UploadImagesController : ControllerBase
	{
		[HttpPost("upload-image")]
		public async Task<IActionResult> UploadImage(IFormFile file)
		{
			// Kiểm tra file có tồn tại hay không
			if (file == null || file.Length == 0)
				return BadRequest("No file uploaded.");

			// Đường dẫn thư mục lưu trữ ảnh
			string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Resources");
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}

			// Tạo tên file với định dạng PNG
			string fileName = Guid.NewGuid().ToString() + ".png";
			string filePath = Path.Combine(folderPath, fileName);

			// Mở stream từ file tải lên và lưu vào thư mục
			using (var inputStream = file.OpenReadStream())
			{
				using (var image = SixLabors.ImageSharp.Image.Load(inputStream))
				{
					using (var outputStream = new FileStream(filePath, FileMode.Create))
					{
						var pngEncoder = new PngEncoder();
						await image.SaveAsync(outputStream, pngEncoder); // Sử dụng SaveAsync để đảm bảo bất đồng bộ
					}
				}
			}

			// URL đầy đủ của ảnh (bao gồm hostname và đường dẫn tĩnh)
			string fileUrl = $"{Request.Scheme}://{Request.Host}/Resources/{fileName}";

			// Trả về JSON chứa URL đầy đủ của ảnh
			return Ok(new { FileUrl = fileUrl });
		}
	}
}
