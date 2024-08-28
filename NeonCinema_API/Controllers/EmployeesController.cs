using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Employees;

using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesRepository _reps;
        private readonly IMapper _mapper;
        public EmployeesController(IEmployeesRepository reps, IMapper mapper)
        {
            _mapper = mapper;

            _reps = reps;
        }
        // GET: api/<EmployeesController>
        [HttpGet("getall-employees")]
        public async Task<IActionResult> GetAllEmployees([FromQuery] EmployessViewRequest requets, CancellationToken cancellationToken)
        {
            var result = await _reps.GetAllEmployees(requets, cancellationToken);
            return Ok(result);
        }

        // GET api/<EmployeesController>/5
       

        // POST api/<EmployeesController>
        [HttpPost("create-employees")]
        public async Task<IActionResult> CreateEmployees([FromBody] EmployeesCreateRequest requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.CreateEmployees(_mapper.Map<Employees>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("Update-Employees")]
        public async Task<IActionResult> Update([FromBody] EmployeesUpdateRequest requets, CancellationToken cancellationToken)
        {
            try
            {
                var result = await _reps.UpdateEmployees(_mapper.Map<Employees>(requets), cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EmployeesController>/5
        //[HttpDelete("Delete-Employees")]
        //public async Task<IActionResult> Remove([FromBody] employ requets, CancellationToken cancellationToken)
        //{
        //}
    }
}
