using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.TicketPrice;
using NeonCinema_Application.Interface;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketPriceController : ControllerBase
    {
        private readonly ITicketPriceRepository _ticketPriceRepository;

        public TicketPriceController(ITicketPriceRepository ticketPriceRepository)
        {
            _ticketPriceRepository = ticketPriceRepository;
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateTicketPrice([FromBody] TicketPriceCreateRequest request, CancellationToken cancellationToken)
        {
            var result = await _ticketPriceRepository.CreateTicketPrice(request);

            if (result.IsSuccessStatusCode)
            {
                return Ok("Tạo giá vé thành công!");
            }

            return BadRequest("Tạo giá vé thất bại!");
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdateTicketPrice([FromBody] TicketPriceDTO ticketPriceDTO, CancellationToken cancellationToken)
        {
            var result = await _ticketPriceRepository.UpdateTicketPrice(ticketPriceDTO);

            if (result.IsSuccessStatusCode)
            {
                return Ok("Sửa giá vé thành công!");
            }

            return BadRequest("Sửa giá vé thất bại!");
        }

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAllTicketPrices(CancellationToken cancellationToken)
        {
            var ticketPrices = await _ticketPriceRepository.GetAllTicketPrices();

            if (ticketPrices == null)
            {
                return NotFound("Không có giá vé nào!");
            }

            return Ok(ticketPrices);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetTicketPriceById(Guid id, CancellationToken cancellationToken)
        {
            var ticketPrice = await _ticketPriceRepository.GetTicketPriceById(id);

            if (ticketPrice == null)
            {
                return NotFound("Giá vé không tồn tại");
            }

            return Ok(ticketPrice);
        }
    }

}
