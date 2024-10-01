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
		[HttpPost("create")]
		public async Task<IActionResult> CreateCountry([FromBody] CountrysCreateRequest request, CancellationToken cancellationToken)
		{
			if (request == null || string.IsNullOrWhiteSpace(request.CountryName))
			{
				return BadRequest("Invalid request. Country name is required.");
			}

			// Gọi repository để tạo mới Country
			var response = await _countryRepository.CreateRole(request, cancellationToken);

			if (response.StatusCode == HttpStatusCode.Created)
			{
				// Trả về thông báo thành công mà không cần trả lại ID
				return Ok("Country created successfully.");
			}

			// Nếu xảy ra lỗi, trả về mã lỗi tương ứng
			return StatusCode((int)response.StatusCode, await response.Content.ReadAsStringAsync());
		}


		// GET: api/Country
		[HttpGet("get-all")]
		public async Task<IActionResult> GetAllCountries(CancellationToken cancellationToken)
		{
			var countries = await _countryRepository.GetAllRole(cancellationToken);
			return Ok(countries);
		}
		// GET: api/Country/{id}
		[HttpGet("get-by-id")]
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
		[HttpPut("update")]
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
		[HttpDelete("delete")]
		public async Task<IActionResult> DeleteCountry(Guid id)
		{
			await _countryRepository.DeleteID(id);
			return Ok();
		}
	}
}
