using AutoMapper;
using Microsoft.AspNetCore.Mvc;

using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeonCinema_API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class WorkShiftController : ControllerBase
    {
        private readonly IWorkShiftRepository _reps;
        private readonly IMapper _mapper;
        public WorkShiftController(IWorkShiftRepository reps, IMapper mapper)
        {
            _mapper = mapper;

            _reps = reps;
        }
        // GET: api/<WorkShiftController>
        [HttpGet("Getall-Workshift")]
        public async Task<IActionResult> GetAllWorkShift([FromQuery] WorkShiftViewRequets requets, CancellationToken cancellationToken)
        {
            var result = await _reps.GetAllWorkShift(requets, cancellationToken);
            return Ok(result);
        }

        // GET api/<WorkShiftController>/5
        

        // POST api/<WorkShiftController>
        [HttpPost("Create-Workshift")]
        public async Task<IActionResult> Create([FromBody] WorkShiftCreateRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.CreateWorkShift(_mapper.Map<WorkShift>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<WorkShiftController>/5
        [HttpPut("Update-Workshift")]
        public async Task<IActionResult> Update([FromBody] WorkShiftUpdateRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.UpdateWorkShift(_mapper.Map<WorkShift>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<WorkShiftController>/5
        [HttpDelete("Delete-Workshift")]
        public async Task<IActionResult> Remove([FromBody] WorkShiftDeleteRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.DeleteWorkShift(_mapper.Map<WorkShift>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
