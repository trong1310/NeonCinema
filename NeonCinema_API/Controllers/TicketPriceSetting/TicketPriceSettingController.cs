using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.TicketPriceSetting;
using NeonCinema_Application.Interface.TicketPriceSetting;
using System.Threading;

namespace NeonCinema_API.Controllers.TicketPriceSetting
{
	[Route("api/[controller]")]
	[ApiController]
	public class TicketPriceSettingController : ControllerBase
	{
		private readonly ITicketPriceSettingRepository _repository;

		public TicketPriceSettingController(ITicketPriceSettingRepository repository)
		{
			_repository = repository;
		}
		[HttpGet("{id}")]
		public async Task<IActionResult> GetById(Guid id)
		{
			var obj = await _repository.GetByIdAsync(Guid.Parse("4BAB0DA1-D912-4A87-8E21-CB7A665657D3"));
			if (obj == null)
			{
				return NotFound($"Không tìm thấy vé {id}.");
			}


			return Ok(obj);
		}
		[HttpPut]
		public async Task<IActionResult> Update( TicketPriceSettingDTO request)
		{
            var obj = await _repository.Update(request);
            if (!obj.IsSuccessStatusCode)
            {
                throw new Exception($"Có lỗi xảy ra khi cập nhật giá vé. Mã lỗi: {obj.StatusCode}");
            }

            return Ok(obj);
        }
	}
}
