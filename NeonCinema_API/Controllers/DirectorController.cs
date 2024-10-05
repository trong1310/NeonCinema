using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorRepositories _reps;
        
        public DirectorController(IDirectorRepositories reps)
        {
           
            _reps = reps;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllDirectors(CancellationToken cancellationToken)
        {
            var directors = await _reps.GetAllDirector(cancellationToken);
            if (directors == null || directors.Count == 0)
            {
                return NotFound(new { message = "No directors found." });
            }
            return Ok(directors);
        }

        // 2. Get Director by ID
        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetDirectorById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var director = await _reps.GetBiIdDirector(id, cancellationToken);
                return Ok(director);
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { message = $"Director with ID {id} not found." });
            }
        }

        // 3. Create Director
        [HttpPost]
        public async Task<IActionResult> CreateDirector([FromBody] CreateDirectorRequest directorRequest, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newDirector = await _reps.CreateDirector(directorRequest, cancellationToken);
            return CreatedAtAction(nameof(GetDirectorById), new { id = newDirector.ID }, newDirector);
        }

        // 4. Update Director
        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateDirector(Guid id, [FromBody] UpdateDirectorRequest updateDirectorRequest, CancellationToken cancellationToken)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var updatedDirector = await _reps.UpdateDirector(id, updateDirectorRequest, cancellationToken);
                return Ok(updatedDirector);
            }
            catch (KeyNotFoundException)
            {
                return NotFound(new { message = $"Director with ID {id} not found." });
            }
        }


    }
}
