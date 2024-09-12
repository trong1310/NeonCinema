using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.RankMembers;
using NeonCinema_Application.Interface.RannkMember;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.RankMembers
{
    public class RankMemberRepositories : IRankMemberRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public RankMemberRepositories(NeonCinemasContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<RankMemberDTO>> GetAllRankMembers(CancellationToken cancellationToken)
        {
            var rankMembers = await _context.RankMembers.ToListAsync(cancellationToken);
            return _mapper.Map<List<RankMemberDTO>>(rankMembers);
        }

        public async Task<RankMemberDTO> GetRankMemberById(Guid id, CancellationToken cancellationToken)
        {
            var rankMember = await _context.RankMembers.FirstOrDefaultAsync(x => x.ID == id, cancellationToken);
            if (rankMember == null) return null;
            return _mapper.Map<RankMemberDTO>(rankMember);
        }

        public async Task CreateRankMember(CreateRankMemberRequest request, CancellationToken cancellationToken)
        {
            var rankMember = _mapper.Map<RankMember>(request);
            _context.RankMembers.Add(rankMember);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateRankMember(Guid id, UpdateRankMemberRequest request, CancellationToken cancellationToken)
        {
            var rankMember = await _context.RankMembers.FindAsync(id);
            if (rankMember == null) return;

            _mapper.Map(request, rankMember);
            _context.RankMembers.Update(rankMember);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteRankMember(Guid id, CancellationToken cancellationToken)
        {
            var rankMember = await _context.RankMembers.FindAsync(id);
            if (rankMember == null) return;

            _context.RankMembers.Remove(rankMember);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
