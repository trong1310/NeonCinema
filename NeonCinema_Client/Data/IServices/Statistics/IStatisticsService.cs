using NeonCinema_Application.DataTransferObject.StaticStatis;
using NeonCinema_Application.DataTransferObject.Statistics;

namespace NeonCinema_Client.Data.IServices.Statistics
{
    public interface IStatisticsService
    {
        Task<StatisticsDTO> GetAllStatistics(DateTime startDate, DateTime endDate);
        Task<ChartDataResponse> GetChartDataAsync(DateTime startDate, DateTime endDate, string timeFilter, string theater);
    }
}
