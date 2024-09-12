using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Point;
using NeonCinema_Application.Interface.Point;

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

        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<PointDTO>>> GetPoints(CancellationToken cancellationToken)
        {
            var points = await _pointRepository.GetAllPoints(cancellationToken);
            return Ok(points);
        }

        [HttpGet("get-by-id")]
        public async Task<ActionResult<PointDTO>> GetPoint(Guid id, CancellationToken cancellationToken)
        {
            var point = await _pointRepository.GetPointById(id, cancellationToken);
            if (point == null) return NotFound();
            return Ok(point);
        }

        [HttpPost("create")]
        public async Task<ActionResult> CreatePoint(CreatePointRequest request, CancellationToken cancellationToken)
        {
            await _pointRepository.CreatePoint(request, cancellationToken);
            return CreatedAtAction(nameof(GetPoint), new { id = request.ID }, request);
        }

        [HttpPut("update")]
        public async Task<IActionResult> UpdatePoint(Guid id, UpdatePointRequest request, CancellationToken cancellationToken)
        {
            await _pointRepository.UpdatePoint(id, request, cancellationToken);
            return NoContent();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> DeletePoint(Guid id, CancellationToken cancellationToken)
        {
            await _pointRepository.DeletePoint(id, cancellationToken);
            return NoContent();
        }
    }
}
