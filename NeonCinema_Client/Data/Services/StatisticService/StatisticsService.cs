using NeonCinema_Application.DataTransferObject.StaticStatis;
using NeonCinema_Client.Data.IServices.Statistics;

namespace NeonCinema_Client.Data.Services.StatisticService
{
    public class StatisticsService : IStatisticsService
    {
        private readonly HttpClient _httpClient;

        public StatisticsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<StatisticsResponseDto> GetAllStatisticsAsync(DateTime date, DateTime startDate, DateTime endDate)
        {
            var apiUrl = $"api/Statistics/all-statistics";
            var response = await _httpClient.GetFromJsonAsync<StatisticsResponseDto>(apiUrl);
            return response ?? new StatisticsResponseDto();
        }
    }
}
