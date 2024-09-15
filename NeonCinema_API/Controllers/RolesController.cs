using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Roles;
using NeonCinema_Application.Interface.Roles;
using System.Net;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRolesRepository _rolesRepository;

        public RolesController(IRolesRepository rolesRepository)
        {
            _rolesRepository = rolesRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] RolesCreateRequest request, CancellationToken cancellationToken)
        {
            var response = await _rolesRepository.CreateRole(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return CreatedAtAction(nameof(GetByIDRole), new { id = request.ID }, request);
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(Guid id, [FromBody] RolesUpdateRequest request, CancellationToken cancellationToken)
        {
            var response = await _rolesRepository.UpdateRole(id, request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(await response.Content.ReadAsStringAsync());
            }

            return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRole(CancellationToken cancellationToken)
        {
            var roles = await _rolesRepository.GetAllRole(cancellationToken);
            return Ok(roles);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDRole(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var role = await _rolesRepository.GetByIDRole(id, cancellationToken);
                return Ok(role);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
