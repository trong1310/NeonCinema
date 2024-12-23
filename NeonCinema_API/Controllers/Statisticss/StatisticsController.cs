using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using NeonCinema_Application.DataTransferObject.Statistics;
using NeonCinema_Application.Interface.Statistics;


namespace NeonCinema_API.Controllers.Statisticss
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticalRepo;
        private readonly IMapper _mapper;

        public StatisticsController(IStatisticsRepository statisticsRepository, IMapper mapper)
        {
            _statisticalRepo = statisticsRepository;
            _mapper = mapper;
        }


		[HttpGet("total-revenue")]
		public async Task<IActionResult> GetTotalRevenue([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
		{
			var totalRevenue = await _statisticalRepo.GetTotalRevenueAsync(startDate, endDate);
			return Ok(new { StartDate = startDate, EndDate = endDate, TotalRevenue = totalRevenue });
		}

		[HttpGet("revenue")]
		public async Task<IActionResult> GetRevenueStatistics(DateTime startDate, DateTime endDate)
		{
			try
			{
				var totalRevenue = await _statisticalRepo.GetTotalRevenueAsync(startDate, endDate);
				var totalTickets = await _statisticalRepo.GetTotalTicketsAsync(startDate, endDate);
				var newCustomers = await _statisticalRepo.GetNewCustomersAsync(startDate, endDate);
				var dailyRevenue = await _statisticalRepo.GetDailyRevenueAsync(startDate, endDate);

				if (dailyRevenue == null || !dailyRevenue.Any())
				{
					return NotFound("No data found for the selected period.");
				}

				var statistics = new RevenueStatisticsDTO
				{
					TotalRevenue = totalRevenue,
					TotalTickets = totalTickets,
					NewCustomers = newCustomers,
					RevenueChart = dailyRevenue
				};

				return Ok(statistics);
			}
			catch (Exception ex)
			{
				return StatusCode(500, $"Error: {ex.Message}");
			}
		}
		[HttpGet("combo-statistics")]
		public async Task<IActionResult> GetComboStatistics(DateTime startDate, DateTime endDate)
		{
			var comboStatistics = await _statisticalRepo.GetComboStatisticsAsync(startDate, endDate);
			return Ok(comboStatistics);
		}

		//[HttpGet("movie-statistics")]
		//public async Task<IActionResult> GetMovieStatistics(DateTime startDate, DateTime endDate)
		//{
		//	var movieStatistics = await _statisticalRepo.GetMovieStatisticsAsync(startDate, endDate);
		//	return Ok(movieStatistics);
		//}



	}
}
