using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.Language;
using NeonCinema_Application.Interface.Language;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly ILanguageRepositories _languageRepository;
        private readonly IMapper _mapper;

        public LanguageController(ILanguageRepositories languageRepository, IMapper mapper)
        {
            _languageRepository = languageRepository;
            _mapper = mapper;
        }

        // Lấy tất cả ngôn ngữ
        [HttpGet("get-all")]
        public async Task<ActionResult<IEnumerable<LanguageDTO>>> GetAllLanguages(CancellationToken cancellationToken)
        {
            var languages = await _languageRepository.GetAllLanguages(cancellationToken);
            return Ok(languages);
        }

        // Lấy ngôn ngữ theo ID
        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<LanguageDTO>> GetLanguageById(Guid id, CancellationToken cancellationToken)
        {
            var language = await _languageRepository.GetLanguageById(id, cancellationToken);
            if (language == null) return NotFound(new { message = "Ngôn ngữ không tồn tại" });
            return Ok(language);
        }

        // Tạo ngôn ngữ mới
        [HttpPost("create")]
        public async Task<ActionResult> CreateLanguage(CreateLanguageRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _languageRepository.CreateLanguage(request, cancellationToken);
                return CreatedAtAction(nameof(GetLanguageById), new { id = request.ID }, request);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Lỗi khi tạo ngôn ngữ: {ex.Message}" });
            }
        }

        // Cập nhật ngôn ngữ
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateLanguage(Guid id, UpdateLanguageRequest request, CancellationToken cancellationToken)
        {
            try
            {
                await _languageRepository.UpdateLanguage(id, request, cancellationToken);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Lỗi khi cập nhật ngôn ngữ: {ex.Message}" });
            }
        }

        // Xóa ngôn ngữ
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteLanguage(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                await _languageRepository.DeleteLanguage(id, cancellationToken);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = $"Lỗi khi xóa ngôn ngữ: {ex.Message}" });
            }
        }
    }
}
