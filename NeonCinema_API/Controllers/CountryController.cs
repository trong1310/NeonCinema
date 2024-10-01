using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.Interface.Countrys;
using System.Net;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        // POST: api/Country
        [HttpPost]
        public async Task<IActionResult> CreateCountry([FromBody] CountrysCreateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }

            var response = await _countryRepository.CreateRole(request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.Created)
            {
                return CreatedAtAction(nameof(GetById), new { id = request.ID }, request);
            }

            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
        // GET: api/Country
        [HttpGet]
        public async Task<IActionResult> GetAllCountries(CancellationToken cancellationToken)
        {
            var countries = await _countryRepository.GetAllRole(cancellationToken);
            return Ok(countries);
        }
        // GET: api/Country/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var country = await _countryRepository.GetByIDRole(id, cancellationToken);
                return Ok(country);
            }
            catch (KeyNotFoundException)
            {
                return NotFound("Country not found.");
            }
        }
        // PUT: api/Country/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCountry(Guid id, [FromBody] CountryUpdateRequest request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }

            var response = await _countryRepository.UpdateRole(id, request, cancellationToken);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return Ok(response.Content.ReadAsStringAsync().Result);
            }

            return StatusCode((int)response.StatusCode, response.Content.ReadAsStringAsync().Result);
        }
    }
}
