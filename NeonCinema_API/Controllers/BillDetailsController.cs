using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.BillDetails;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillDetailsController : ControllerBase
    {
        IMapper _mapper;
        IBillDetailsRepository _repos;
        public BillDetailsController(IMapper mapper, IBillDetailsRepository repos)
        {
            _mapper = mapper;
            _repos = repos;
        }

        [HttpGet("get-all-bill")]
        public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _repos.GetAll(cancellationToken);

            return Ok(lst);
        }

        [HttpPost("post-bill")]
        public async Task<IActionResult> Create([FromBody] BillDetailsCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<BillDetail>(request), cancellationToken);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
