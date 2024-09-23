using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShowDate;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Interface.ShowDate;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Implement.Screenings;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowDateController : ControllerBase
    {
        private readonly IShowDateRepository _showDateRepository;

        public ShowDateController(IShowDateRepository showDateRepository)
        {
            _showDateRepository = showDateRepository;
        }

        // GET: api/showdate
        [HttpGet]
        public async Task<IActionResult> GetAllShiftChange(CancellationToken cancellationToken)
        {
            var result = await _showDateRepository.GetAllShiftChange(cancellationToken);
            return Ok(result);
        }

        // GET: api/showdate/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIDShiftChange(Guid id, CancellationToken cancellationToken)
        {
            var result = await _showDateRepository.GetByIDShiftChange(id, cancellationToken);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        // POST: api/showdate
        [HttpPost]
        public async Task<IActionResult> CreateShiftChange([FromBody] ShowDateCreateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Invalid data.");
            }

            var response = await _showDateRepository.CreateShiftChange(request, cancellationToken);
            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }

        // PUT: api/showdate/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateShiftChange(Guid id, [FromBody] ShowDateUpdateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Invalid data.");
            }

            var response = await _showDateRepository.UpdateShiftChange(id, request, cancellationToken);
            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShiftChange(Guid id, CancellationToken cancellationToken)
        {
            var response = await _showDateRepository.DeleteShiftChange(id, cancellationToken);
            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
    }
}
