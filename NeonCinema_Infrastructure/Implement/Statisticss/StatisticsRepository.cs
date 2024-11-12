using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface.Statistics;
using NeonCinema_Domain.Database.Entities;
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

        public async Task<decimal> GetDailyRevenue(DateTime date, CancellationToken cancellationToken)
        {
            var dailyRevenue = await _context.BillDetails
                .Where(b => b.CreatedTime == date.Date)
                .SumAsync(b => b.TotalPrice, cancellationToken);
            return dailyRevenue;
        }

        public async Task<int> GetNewCustomers(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            var newCustomers = await _context.Users
                .Where(u => u.CreatedTime >= startDate.Date && u.CreatedTime <= endDate.Date)
                .CountAsync(cancellationToken);
            return newCustomers;
        }


        public async Task<int> GetTotalTickets(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            var totalTickets = await _context.BillTickets
                .Where(bt => bt.Bills!.CreatedTime >= startDate && bt.Bills.CreatedTime <= endDate)
                .CountAsync(cancellationToken);
            return totalTickets;
        }


        public async Task<decimal> GetTotalRevenue(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            var totalRevenue = await _context.BillDetails
                .Where(b => b.CreatedTime >= startDate && b.CreatedTime <= endDate)
                .SumAsync(b => b.TotalPrice, cancellationToken);
            return totalRevenue;
        }

        public async Task<List<FoodCombo>> GetFoodCombos(DateTime startDate, DateTime endDate, CancellationToken cancellationToken)
        {
            var foodCombos = await _context.FoodCombos
                .Where(fc => fc.CreatedTime >= startDate && fc.CreatedTime <= endDate)
                .ToListAsync(cancellationToken);
            return foodCombos;
        }

    }
}
