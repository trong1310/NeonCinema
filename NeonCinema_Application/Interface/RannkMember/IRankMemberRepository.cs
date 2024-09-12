using NeonCinema_Application.DataTransferObject.RankMembers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.RannkMember
{
    public interface IRankMemberRepository
    {
        Task<List<RankMemberDTO>> GetAllRankMembers(CancellationToken cancellationToken);
        Task<RankMemberDTO> GetRankMemberById(Guid id, CancellationToken cancellationToken);
        Task CreateRankMember(CreateRankMemberRequest request, CancellationToken cancellationToken);
        Task UpdateRankMember(Guid id, UpdateRankMemberRequest request, CancellationToken cancellationToken);
        Task DeleteRankMember(Guid id, CancellationToken cancellationToken);
    }
}
