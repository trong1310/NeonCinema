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
            var fileId = await _repo.UploadFiles(file);

            if (fileId == -1)
            {
                return BadRequest("No file uploaded.");
            }
            else
            {
                return Ok(fileId);
            }
        }
    }
}
