using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Bills;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BillController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IBillRepository _repos;
        public BillController(IMapper mapper, IBillRepository repos)
        {
            _mapper = mapper;
            _repos = repos;
        }

        [HttpGet("get-all-bill")]
        public async Task<IActionResult> GetAllBill(CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.GetAll(cancellationToken);

                return Ok(result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("post-bill")]
        public async Task<IActionResult> PostBill([FromBody] BillCreateRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _repos.Create(_mapper.Map<Bill>(request), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
