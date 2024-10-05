using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesController : ControllerBase
    {
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
    }
}
