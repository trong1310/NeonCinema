
using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;

namespace NeonCinema_API.Controllers.Service
{
    public class SV : ISV
    {
        private readonly NeonCinemasContext _context;
        public SV(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<(int TotalPoints, decimal TotalSpent, string ranks)> GetUserStatsAsync(Guid userId)
        {
            var totalPoints = await _context.Points
             .Where(p => p.UserID == userId)
             .SumAsync(p => p.TotalPoint);

            var totalSpent = await _context.BillDetails
                .Where(b => b.UserID == userId && b.Status == ticketEnum.paid)
                .SumAsync(b => b.TotalPrice);
            var rankuser = await _context.RankMembers
                 .Where(r => r.UserID == userId) 
                 .Select(r => r.Rank)
                 .FirstOrDefaultAsync();
            return (totalPoints, totalSpent, rankuser);
        }

        
    }
}
