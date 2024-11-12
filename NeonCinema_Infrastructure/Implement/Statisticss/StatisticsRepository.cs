using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface.Statistics;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Statisticss
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly NeonCinemasContext _context;

        public StatisticsRepository(NeonCinemasContext context)
        {
            _context = context;
        }

        public async Task<decimal> GetDailyRevenueAsync(DateTime date)
        {
            return await _context.BillDetails
                .Where(b => b.CreatedTime == date.Date && b.Status == ticketEnum.paid)
                .SumAsync(b => b.TotalPrice);
        }

        public async Task<int> GetNewCustomersCountAsync(DateTime date)
        {
            return await _context.Users
                .Where(u => u.CreatedTime == date.Date &&
                            u.RoleID == _context.Roles.FirstOrDefault(r => r.RoleName == "Client")!.ID)  // Ensure Role is "Client"
                .CountAsync();
        }


        public async Task<int> GetTotalTicketsSoldAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.BillTickets
                .Where(bt => bt.Bills!.CreatedTime >= startDate.Date && bt.Bills.CreatedTime <= endDate.Date)
                .CountAsync();
        }

        public async Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.BillDetails
                .Where(b => b.CreatedTime >= startDate.Date && b.CreatedTime <= endDate.Date && b.Status == ticketEnum.paid)
                .SumAsync(b => b.TotalPrice);
        }
    }

}
