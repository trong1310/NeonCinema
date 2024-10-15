using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> GetAll([FromQuery] PaginationRequest request)
        {
            // Gọi phương thức GetAllAsync với request để lấy dữ liệu phân trang
            var seatTypes = await _seatTypeRepository.GetAllAsync(request);

            // Sử dụng AutoMapper để chuyển từ SeatType sang SeatTypeDTO
            var result = new PaginationResponse<SeatTypeDTO>
            {
                PageNumber = seatTypes.PageNumber,
                PageSize = seatTypes.PageSize,
                HasNext = seatTypes.HasNext,
                Data = _mapper.Map<List<SeatTypeDTO>>(seatTypes.Data)
            };

            // Trả về kết quả dạng JSON
            return Ok(result);
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
        [HttpPut("Update-SeatType")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UpdateSeatTypeDTO updateSeatTypeDTO)
        {
            var seatType = await _seatTypeRepository.GetByIdAsync(id);
            if (seatType == null)
            {
                return NotFound();
            }
            _mapper.Map(updateSeatTypeDTO, seatType);
            await _seatTypeRepository.UpdateAsync(seatType);
            return NoContent();
        }
        [HttpDelete("Delete-SeatType")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await  _seatTypeRepository.DeleteAsync(id);
            return NoContent();
        }
    }
}
