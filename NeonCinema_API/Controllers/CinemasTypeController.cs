using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.CinemasType;
using NeonCinema_Application.Interface.CinemasType;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasTypeController : ControllerBase
    {
        private readonly ICinemasTypeRepository _repo;
        public CinemasTypeController(ICinemasTypeRepository repo)
        {
            _repo = repo;
        }
        // POST: api/CinemasType
        [HttpPost]
        public async Task<IActionResult> CreateCinemasType([FromBody] CinemasTypeCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.CreateCinemasType(request, cancellationToken);

            if (response.StatusCode == System.Net.HttpStatusCode.Created)
            {
                return Created("", "Loại rạp đã được tạo thành công.");
            }

            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
        // GET: api/CinemasType
        [HttpGet]
        public async Task<IActionResult> GetAllCinemasType(CancellationToken cancellationToken)
        {
            var cinemasTypes = await _repo.GetAllCinemasType(cancellationToken);
            return Ok(cinemasTypes);
        }
        // GET: api/CinemasType/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCinemasTypeById(Guid id, CancellationToken cancellationToken)
        {
            var cinemaType = await _repo.GetByIDRCinemasType(id, cancellationToken);

            if (cinemaType == null)
            {
                return NotFound("Loại rạp không tồn tại.");
            }

            return Ok(cinemaType);
        }
        // PUT: api/CinemasType/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCinemasType(Guid id, [FromBody] CinemasTypeUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.UpdateCinemasType(id, request, cancellationToken);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return Ok("Loại rạp đã được cập nhật thành công.");
            }

            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
    }
}
