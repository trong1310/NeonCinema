using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.Interface.FileUpLoad;

namespace NeonCinema_API.Controllers.FileUpLoads
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private readonly IFileRepo _repo;
        public FileUploadController(IFileRepo repo)
        {
            _repo = repo;
        }
        [HttpPost("Upload-images")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("Invalid file.");
            }

            var fileUrl = await _repo.UploadFiles(file);

            if (fileUrl == null)
            {
                return StatusCode(500, "Error uploading file.");
            }

            return Ok(fileUrl); // Trả về URL của file
        }
    }
}
