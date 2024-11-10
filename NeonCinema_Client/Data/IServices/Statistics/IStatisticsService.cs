using NeonCinema_Application.DataTransferObject.StaticStatis;

namespace NeonCinema_Client.Data.IServices.Statistics
{
    public interface IStatisticsService
    {
        Task<StatisticsResponseDto> GetAllStatisticsAsync(DateTime date, DateTime startDate, DateTime endDate);
    }
}
