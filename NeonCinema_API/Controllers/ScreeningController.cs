using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.Interface;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningController : ControllerBase
    {
        private readonly IScreeningRepository _screeningRepository;
        private readonly IMapper _mapper;

        public ScreeningController(IScreeningRepository screeningRepository, IMapper mapper)
        {
            _screeningRepository = screeningRepository;
            _mapper = mapper;
        }

        [HttpGet("get-all-screenings")]
        public async Task<IActionResult> GetAll([FromQuery]ViewScreningRequest request,CancellationToken cancellationToken)
        {
            var result = await _screeningRepository.GetAllScreening(request,cancellationToken);
            return Ok(result);
        }

        [HttpGet("get-screening-by-id/{id}")]
        public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _screeningRepository.GetScreeningById(id, cancellationToken);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost("create-screening")]
        public async Task<IActionResult> Create([FromBody] ScreeningCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _screeningRepository.CreateScreening(request, cancellationToken);
                return StatusCode((int)response.StatusCode, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update-screening/{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ScreeningUpdateRequest request, CancellationToken cancellationToken)
        {
            if (id != request.ID)
            {
                return BadRequest("ID mismatch");
            }

            try
            {
                var response = await _screeningRepository.UpdateScreening(request, cancellationToken);
                return StatusCode((int)response.StatusCode, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("delete")]
        public async Task<IActionResult> Delete(Guid id )
        {
            try
            {
                var response = await _screeningRepository.DeleteScreening(id);
                return StatusCode((int)response.StatusCode, response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("create-sss")]
        public async Task<IActionResult> Create(SeatShowTimeStatusDTO input, CancellationToken ctoken)
        {
            try
            {
                var response = await _screeningRepository.CreateSSS(input, ctoken);

                if (response.IsSuccessStatusCode)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest(response.Content);
                }

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }

        [HttpGet("get-scr-by-room-and-showdate")]
        public async Task<IActionResult> GetScr(Guid roomId, DateTime showDate)
        {
            try
            {
                return Ok(await _screeningRepository.GetScrByRoomAndShowDate(roomId, showDate));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
