using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatTypeController : ControllerBase
    {
        private readonly ISeatTypeRepository _seatTypeRepository;
        private readonly IMapper _mapper;

        public SeatTypeController(ISeatTypeRepository seatTypeRepository, IMapper mapper)
        {
            _seatTypeRepository = seatTypeRepository;
            _mapper = mapper;
        }
        [HttpGet("Get-all")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetAll( CancellationToken cancellationToken)
        {
            try
            {
                var result = await _seatTypeRepository.GetAllAsync(cancellationToken);
                return Ok(result);
            }
            catch (Exception ex)
            {
                // Log the exception here for further analysis
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet("Get-by-id")]
       // [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var seatType = await _seatTypeRepository.GetByIdAsync(id);
            if (seatType == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<SeatTypeDTO>(seatType);
            return Ok(result);
        }
        [HttpPost("Create-SeatType")]
        //[Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([FromBody] CreateSeatTypeDTO createSeatTypeDTO)
        {
            var seatType = _mapper.Map<SeatType>(createSeatTypeDTO);
            await _seatTypeRepository.AddAsync(seatType);
            return CreatedAtAction(nameof(GetById), new { id = seatType.ID }, seatType);
        }


        [HttpPut("Update-SeatType/{id}")]
        public async Task<IActionResult> UpdateSeattype(Guid id, [FromBody] UpdateSeatTypeDTO request, CancellationToken cancellationToken)
        {
            if (id != request.ID || !ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedResponse = await _seatTypeRepository.UpdateSeatType(id, request, cancellationToken);
                return Ok(updatedResponse);
            }
            catch (Exception ex)
            {
                // Log the exception for debugging
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }


        [HttpDelete("Delete-SeatType")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await  _seatTypeRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
