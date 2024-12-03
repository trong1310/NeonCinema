
using NeonCinema_Application.DataTransferObject.Statistics;

namespace NeonCinema_Client.Data.IServices.Statistics
{
    public interface IStatisticsService
    {
		Task<RevenueStatisticsDTO> GetRevenueStatisticsAsync(DateTime startDate, DateTime endDate);
		Task<List<ComboStatisticsDTO>> GetComboStatisticsAsync(DateTime startDate, DateTime endDate);
		Task<List<MovieStatisticsDTO>> GetMovieStatisticsAsync(DateTime startDate, DateTime endDate);

	}

}

