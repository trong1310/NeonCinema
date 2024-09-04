using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Screenings;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScreeningController : ControllerBase
    {
        private readonly IScreeningRepository _repos;
        private readonly IMapper _mapper;
        public ScreeningController(IScreeningRepository repos, IMapper mapper)
        {
            _repos = repos;
            _mapper = mapper;
        }

        [HttpGet("get-all-screening")]
        public async Task<IActionResult> GetAllScreening(CancellationToken cancellationToken)
        {
            var lst = await _repos.GetAllScreening(cancellationToken);
            return Ok(lst);
        }

        [HttpPost("post-screening")]
        public async Task<IActionResult> PostScreening([FromBody] ScreeningCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.CreateScreening(_mapper.Map<Screening>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update-screening")]
        public async Task<IActionResult> UpdateScreening([FromBody] ScreeningUpdateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.UpdateScreening(_mapper.Map<Screening>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("delete-screening")]
        public async Task<IActionResult> DeleteScreening([FromBody] ScreeningDeleteRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.DeleteScreening(_mapper.Map<Screening>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
