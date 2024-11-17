using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Statistics
{
    public interface IStatisticsRepository
    {
        // Phương thức lấy doanh thu trong ngày
        Task<decimal> GetDailyRevenueAsync(DateTime date);

        // Phương thức lấy tổng số khách hàng mới trong một ngày
        Task<int> GetNewCustomersCountAsync(DateTime date);

        // Phương thức lấy tổng số vé bán ra
        Task<int> GetTotalTicketsSoldAsync(DateTime startDate, DateTime endDate);

        // Phương thức lấy tổng doanh thu
        Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate);
    }
}
