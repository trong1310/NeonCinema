using NeonCinema_Application.DataTransferObject.StaticStatis;
using NeonCinema_Application.DataTransferObject.Statistics;
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

        public async Task<StatisticsDTO> GetAllStatistics(DateTime startDate, DateTime endDate)
        {
            var url = $"api/Statistics/all-statistics?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
            return await _httpClient.GetFromJsonAsync<StatisticsDTO>(url);
        }
        public async Task<ChartDataResponse> GetChartDataAsync(DateTime startDate, DateTime endDate, string timeFilter, string theater)
        {
            var apiUrl = $"api/statistics/chart-data?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}&timeFilter={timeFilter}&theater={theater}";

            // Gọi API và lấy dữ liệu
            var response = await _httpClient.GetFromJsonAsync<ChartDataResponse>(apiUrl);
            return response ?? new ChartDataResponse();
        }
    }
}
