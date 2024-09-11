using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.RankMembers;
using NeonCinema_Application.Interface.RannkMember;

namespace NeonCinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankMemberController : ControllerBase
    {
        private readonly IRankMemberRepository _rankMemberRepository;
        private readonly IMapper _mapper;

        public RankMemberController(IRankMemberRepository rankMemberRepository, IMapper mapper)
        {
            _rankMemberRepository = rankMemberRepository;
            _mapper = mapper;
        }

        [HttpGet("get-all-rankmember")]
        public async Task<ActionResult<IEnumerable<RankMemberDTO>>> GetRankMembers(CancellationToken cancellationToken)
        {
            var rankMembers = await _rankMemberRepository.GetAllRankMembers(cancellationToken);
            return Ok(rankMembers);
        }

        [HttpGet("get-by-id-rankmember")]
        public async Task<ActionResult<RankMemberDTO>> GetRankMember(Guid id, CancellationToken cancellationToken)
        {
            var rankMember = await _rankMemberRepository.GetRankMemberById(id, cancellationToken);
            if (rankMember == null) return NotFound();
            return Ok(rankMember);
        }

        [HttpPost("create-rankmember")]
        public async Task<ActionResult> CreateRankMember(CreateRankMemberRequest request, CancellationToken cancellationToken)
        {
            await _rankMemberRepository.CreateRankMember(request, cancellationToken);
            return CreatedAtAction(nameof(GetRankMember), new { id = request.UserID }, request);
        }

        [HttpPut("update-rankmember")]
        public async Task<IActionResult> UpdateRankMember(Guid id, UpdateRankMemberRequest request, CancellationToken cancellationToken)
        {
            await _rankMemberRepository.UpdateRankMember(id, request, cancellationToken);
            return NoContent();
        }

        [HttpDelete("delete-rankmember")]
        public async Task<IActionResult> DeleteRankMember(Guid id, CancellationToken cancellationToken)
        {
            await _rankMemberRepository.DeleteRankMember(id, cancellationToken);
            return NoContent();
        }
    }
}
