using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Application.Interface.Point;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PointController : ControllerBase
    {
        private readonly IPointRepositories _pointRepository;
        private readonly IMapper _mapper;

        public PointController(IPointRepositories pointRepository, IMapper mapper)
        {
            _pointRepository = pointRepository;
            _mapper = mapper;
        }

        // Lấy tất cả điểm
        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<PointDTO>>> GetAllPoints(CancellationToken cancellationToken)
        {
            var points = await _pointRepository.GetAllPoints(cancellationToken);
            return Ok(points);
        }

        // Lấy điểm theo ID
        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<PointDTO>> GetPointById(Guid id, CancellationToken cancellationToken)
        {
            var point = await _pointRepository.GetPointById(id, cancellationToken);
            if (point == null) return NotFound(new { message = "Điểm không tồn tại" });
            return Ok(point);
        }

        // Tạo điểm mới
        [HttpPost("create")]
        public async Task<ActionResult> CreatePoint(CreatePointRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _pointRepository.CreatePoint(request, cancellationToken);
                return CreatedAtAction(nameof(GetPointById), new { id = request.ID }, request);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Lỗi khi tạo điểm: {ex.Message}" });
            }
        }

        // Cập nhật điểm
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdatePoint(Guid id, UpdatePointRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _pointRepository.UpdatePoint(id, request, cancellationToken);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Lỗi khi cập nhật điểm: {ex.Message}" });
            }
        }

        // Xóa điểm
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeletePoint(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                await _pointRepository.DeletePoint(id, cancellationToken);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Lỗi khi xóa điểm: {ex.Message}" });
            }
        }
    }
}
