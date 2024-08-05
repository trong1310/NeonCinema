using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.ShiftChanges;
using NeonCinema_Application.DataTransferObject.WorkShift;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using System.Threading;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftChangesCotroller : ControllerBase
    {
        private readonly IShiftChangeRepository _reps;
        private readonly IMapper _mapper;
        public ShiftChangesCotroller(IShiftChangeRepository reps, IMapper mapper)
        {
            _mapper = mapper;

            _reps = reps;
        }
        // GET: api/<ShiftChangesCotroller>
        [HttpGet("Getall-Shiftchanges")]
        public async Task<IActionResult> GetAllShiftCganges([FromQuery] ShiftChangesViewRequets requets, CancellationToken cancellationToken)
        {
            var result = await _reps.GetAllShiftChanges(requets, cancellationToken);
            return Ok(result);
        }

        //// GET api/<ShiftChangesCotroller>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ShiftChangesCotroller>
        [HttpPost("Create-ShiftChange")]
        public async Task<IActionResult> CreateShiftChanges([FromBody] ShiftChangesCreateRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.CreateShiftChanges(_mapper.Map<ShiftChange>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ShiftChangesCotroller>/5
        [HttpPut("Update-ShiftChanges")]
        public async Task<IActionResult> UpdateShiftcChanges([FromBody] ShiftChangesUpdateRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.UpdateShiftChanges(_mapper.Map<ShiftChange>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ShiftChangesCotroller>/5
        [HttpDelete("Delete-ShiftChanges")]
        public async Task<IActionResult> RemoveShiftChanges([FromBody] ShiftChangesDeleteRequets requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.DeleteShiftChanges(_mapper.Map<ShiftChange>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
