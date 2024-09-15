using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.Interface.Cinemas;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly ICinemasRepository _repo;
        public CinemasController(ICinemasRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public async Task<ActionResult<List<CinemasDTO>>> GetAllCinemas(CancellationToken cancellationToken)
        {
            var cinemas = await _repo.GetAllCinemas(cancellationToken);
            return Ok(cinemas);
        }
        // GET: api/cinemas/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<CinemasDTO>> GetByIDRCinemas(Guid id, CancellationToken cancellationToken)
        {
            var cinema = await _repo.GetByIDRCinemas(id, cancellationToken);
            if (cinema == null)
            {
                return NotFound("Cinema not found.");
            }
            return Ok(cinema);
        }
        // POST: api/cinemas
        [HttpPost]
        public async Task<ActionResult> CreateCinemas([FromBody] CinemasCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.CreateCinemas(request, cancellationToken);
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return BadRequest(response.Content.ReadAsStringAsync().Result);
            }

            return CreatedAtAction(nameof(GetByIDRCinemas), new { id = request.ID }, request);
        }
        // PUT: api/cinemas/{id}
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateCinemas(Guid id, [FromBody] CinemasUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _repo.UpdateCinemas(id, request, cancellationToken);
            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                return BadRequest(response.Content.ReadAsStringAsync().Result);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return NotFound(response.Content.ReadAsStringAsync().Result);
            }

            return Ok();
        }
    }
}
