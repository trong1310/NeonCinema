using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadImagesController : ControllerBase
    {
       

        public UploadImagesController()
        {
            
        }

        [HttpPost("upload-image")]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("No file uploaded.");

            // Đường dẫn thư mục Resources
            string folderPath = Path.Combine("Resources");

            // Tạo thư mục nếu chưa có
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Đặt tên file với tên duy nhất
            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = Path.Combine(folderPath, fileName);

            // Lưu file vào thư mục Resources
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Trả về đường dẫn file đã upload
            string fileUrl = Path.Combine("Resources", fileName);
            return Ok(new { FileUrl = fileUrl });
        }
    }
}
