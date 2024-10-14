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
            string folderPath = Path.Combine("Resources");

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = Path.Combine(folderPath, fileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            string fileUrl = Path.Combine("Resources", fileName);
            return Ok(new { FileUrl = fileUrl });
        }
    }
}
