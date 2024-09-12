using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Genre;
using NeonCinema_Application.Interface.Genre;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IGenreRepositories _genreRepository;
        private readonly IMapper _mapper;

        public GenreController(IGenreRepositories genreRepository, IMapper mapper)
        {
            _genreRepository = genreRepository;
            _mapper = mapper;
        }

        [HttpGet("get-all-genre")]
        public async Task<ActionResult<IEnumerable<GenreDTO>>> GetGenres(CancellationToken cancellationToken)
        {
            var genres = await _genreRepository.GetAllGenres(cancellationToken);
            return Ok(genres);
        }

        [HttpGet("get-by-id-genre")]
        public async Task<ActionResult<GenreDTO>> GetGenre(Guid id, CancellationToken cancellationToken)
        {
            var genre = await _genreRepository.GetGenreById(id, cancellationToken);
            if (genre == null) return NotFound();
            return Ok(genre);
        }

        [HttpPost("create-genre")]
        public async Task<ActionResult> CreateGenre(CreateGenreRequest request, CancellationToken cancellationToken)
        {
            await _genreRepository.CreateGenre(request, cancellationToken);
            return CreatedAtAction(nameof(GetGenre), new { id = request.ID }, request);
        }


        [HttpPut("update-genre")]
        public async Task<IActionResult> UpdateGenre(Guid id, UpdateGenreRequest request, CancellationToken cancellationToken)
        {
            await _genreRepository.UpdateGenre(id, request, cancellationToken);
            return NoContent();
        }

        [HttpDelete("delete-genre")]
        public async Task<IActionResult> DeleteGenre(Guid id, CancellationToken cancellationToken)
        {
            await _genreRepository.DeleteGenre(id, cancellationToken);
            return NoContent();
        }
    }
}
