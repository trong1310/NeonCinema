using NeonCinema_Application.DataTransferObject.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Statistics
{
	public interface IStatisticsRepository
	{
		Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate);
		Task<int> GetTotalTicketsAsync(DateTime startDate, DateTime endDate);
		Task<int> GetNewCustomersAsync(DateTime startDate, DateTime endDate);
		Task<List<DailyRevenueDTO>> GetDailyRevenueAsync(DateTime startDate, DateTime endDate);
		Task<List<ComboStatisticsDTO>> GetComboStatisticsAsync(DateTime startDate, DateTime endDate);
		Task<List<MovieStatisticsDTO>> GetMovieStatisticsAsync(DateTime startDate, DateTime endDate);
		Task<RevenueStatisticsDTO> GetRevenueStatisticsAsync(DateTime? specificDate, DateTime? startDate, DateTime? endDate);
	}
}
