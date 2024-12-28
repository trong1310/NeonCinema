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


		[HttpGet("revenue-statistics")]
		public async Task<IActionResult> GetRevenueStatistics(DateTime? specificDate, DateTime? startDate, DateTime? endDate)
		{
			try
			{
				RevenueStatisticsDTO statistics;

				if (specificDate.HasValue)
				{
					statistics = await _statisticalRepo.GetRevenueStatisticsAsync(specificDate, null, null);
				}
				else if (startDate.HasValue && endDate.HasValue)
				{
					statistics = await _statisticalRepo.GetRevenueStatisticsAsync(null, startDate, endDate);
				}
				else
				{
					return BadRequest("Invalid parameters provided.");
				}

				return Ok(statistics);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
				return StatusCode(500, "An error occurred while processing your request.");
			}
		}




		[HttpGet("combo-statistics")]
		public async Task<IActionResult> GetComboStatistics(DateTime startDate, DateTime endDate)
		{
			var comboStatistics = await _statisticalRepo.GetComboStatisticsAsync(startDate, endDate);
			return Ok(comboStatistics);
		}

		[HttpGet("movie-statistics")]
		public async Task<IActionResult> GetMovieStatistics(DateTime startDate, DateTime endDate)
		{
			try
			{
				var movieStatistics = await _statisticalRepo.GetMovieStatisticsAsync(startDate, endDate);
				return Ok(movieStatistics);
			}
			catch (Exception ex)
			{
				// Ghi log chi tiết lỗi
				Console.WriteLine($"Error: {ex.Message}");
				return StatusCode(500, "An error occurred while processing your request.");
			}
		}
		[HttpGet("growth")]
		public async Task<IActionResult> GetGrowthStatistics([FromQuery] DateTime currentStart, [FromQuery] DateTime currentEnd, [FromQuery] DateTime previousStart, [FromQuery] DateTime previousEnd)
		{
			var result = await _statisticalRepo.GetGrowthStatisticsAsync(currentStart, currentEnd, previousStart, previousEnd);
			return Ok(result);
		}




	}
}
