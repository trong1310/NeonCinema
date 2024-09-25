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
    }
}
