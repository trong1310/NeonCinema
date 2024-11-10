using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Statistics
{
    public interface IStatisticsRepository
    {
        Task<decimal> GetDailyRevenue(DateTime date, CancellationToken cancellationToken);
        Task<int> GetNewCustomers(DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
        Task<int> GetTotalTickets(DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
        Task<decimal> GetTotalRevenue(DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
        Task<List<FoodCombo>> GetFoodCombos(DateTime startDate, DateTime endDate, CancellationToken cancellationToken);
    }
}
