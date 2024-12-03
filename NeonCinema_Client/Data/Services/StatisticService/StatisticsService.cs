
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

		public async Task<RevenueStatisticsDTO> GetRevenueStatisticsAsync(DateTime startDate, DateTime endDate)
		{
			var url = $"api/Statistics/revenue?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
			return await _httpClient.GetFromJsonAsync<RevenueStatisticsDTO>(url);
		}
		public async Task<List<ComboStatisticsDTO>> GetComboStatisticsAsync(DateTime startDate, DateTime endDate)
		{
			var url = $"api/Statistics/combo-statistics?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
			return await _httpClient.GetFromJsonAsync<List<ComboStatisticsDTO>>(url);
		}

		public async Task<List<MovieStatisticsDTO>> GetMovieStatisticsAsync(DateTime startDate, DateTime endDate)
		{
			var url = $"api/Statistics/movie-statistics?startDate={startDate:yyyy-MM-dd}&endDate={endDate:yyyy-MM-dd}";
			return await _httpClient.GetFromJsonAsync<List<MovieStatisticsDTO>>(url);
		}

	}
}
