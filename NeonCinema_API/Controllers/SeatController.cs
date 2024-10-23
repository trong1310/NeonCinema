using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.DataTransferObject.SeatTypes;
using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Implement.Seats;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SeatController : ControllerBase
    {
        private readonly ISeatRepository _reps;

        private readonly IMapper _map;
        public SeatController(ISeatRepository repo, IMapper mapper)
        {
            _reps = repo;
            _map = mapper;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> Get([FromQuery] ViewSeatRequest request, CancellationToken cancellationToken)
        {
            var obj = await _reps.GetAllAsync(request, cancellationToken);
            return Ok(obj);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateSeatDTO request, CancellationToken cancellationToken)
        {
            var obj = await _reps.AddAsync(request, cancellationToken);
            return Ok(obj); 
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(UpdateSeatDTO request, CancellationToken cancellationToken)
        {
            var obj = await _reps.UpdateAsync(_map.Map<NeonCinema_Domain.Database.Entities.Seat>(request), cancellationToken);
            return Ok(obj);
        }
        
        [HttpGet("GetById")]
        public async Task<IActionResult> GetMoviesById(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _reps.GetByIdAsync(id, cancellationToken);
            return Ok(obj);
        }
        
    }
}
