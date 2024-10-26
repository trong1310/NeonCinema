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
			if (file == null || file.Length == 0)
				return BadRequest("No file uploaded.");
			string folderPath = Path.Combine("Resources");
			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}
			string fileName = Guid.NewGuid().ToString() + ".png";
			string filePath = Path.Combine(folderPath, fileName);
			using (var inputStream = file.OpenReadStream())
			{
				using (var image = SixLabors.ImageSharp.Image.Load(inputStream))
				{
					using (var outputStream = new FileStream(filePath, FileMode.Create))
					{
						var pngEncoder = new PngEncoder(); 
						image.Save(outputStream, pngEncoder);
					}
				}
			}
			string fileUrl = Path.Combine("Resources", fileName);
			return Ok(new { FileUrl = fileUrl });
		}
	}
}
