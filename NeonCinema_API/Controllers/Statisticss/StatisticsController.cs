using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NeonCinema_Application.DataTransferObject.StaticStatis;
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

        [HttpGet("daily-revenue")]
        public async Task<IActionResult> GetDailyRevenue([FromQuery] DateTime date)
        {
            var revenue = await _statisticalRepo.GetDailyRevenueAsync(date);
            return Ok(new { Date = date, Revenue = revenue });
        }

        [HttpGet("new-customers")]
        public async Task<IActionResult> GetNewCustomersCount([FromQuery] DateTime date)
        {
            var count = await _statisticalRepo.GetNewCustomersCountAsync(date);
            return Ok(new { Date = date, NewCustomers = count });
        }

        [HttpGet("total-tickets-sold")]
        public async Task<IActionResult> GetTotalTicketsSold([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var totalTickets = await _statisticalRepo.GetTotalTicketsSoldAsync(startDate, endDate);
            return Ok(new { StartDate = startDate, EndDate = endDate, TotalTicketsSold = totalTickets });
        }

        [HttpGet("total-revenue")]
        public async Task<IActionResult> GetTotalRevenue([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var totalRevenue = await _statisticalRepo.GetTotalRevenueAsync(startDate, endDate);
            return Ok(new { StartDate = startDate, EndDate = endDate, TotalRevenue = totalRevenue });
        }
        [HttpGet("all-statistics")]
        public async Task<IActionResult> GetAllStatistics([FromQuery] DateTime startDate, [FromQuery] DateTime endDate)
        {
            var dailyRevenue = await _statisticalRepo.GetDailyRevenueAsync(DateTime.Now);
            var newCustomers = await _statisticalRepo.GetNewCustomersCountAsync(DateTime.Now);
            var totalTicketsSold = await _statisticalRepo.GetTotalTicketsSoldAsync(startDate, endDate);
            var totalRevenue = await _statisticalRepo.GetTotalRevenueAsync(startDate, endDate);

            var result = new
            {
                DailyRevenue = dailyRevenue,
                NewCustomers = newCustomers,
                TotalTicketsSold = totalTicketsSold,
                TotalRevenue = totalRevenue
            };

            return Ok(result);
        }
        // Lấy dữ liệu biểu đồ cho thống kê vé và combo bán ra
        [HttpGet("chart-data")]
        public async Task<IActionResult> GetChartData([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, [FromQuery] string timeFilter, [FromQuery] string theater)
        {
            // Lấy danh sách vé theo thời gian
            var ticketSales = await _statisticalRepo.GetTotalTicketsSoldAsync(startDate, endDate);
            var totalRevenue = await _statisticalRepo.GetTotalRevenueAsync(startDate, endDate);

            // Thống kê vé bán ra theo ngày, tháng, năm
            var dates = Enumerable.Range(0, (endDate - startDate).Days + 1)
                                  .Select(offset => startDate.AddDays(offset))
                                  .ToList();
            var revenueList = dates.Select(date => _statisticalRepo.GetDailyRevenueAsync(date).Result).ToList();

            var chartData = new
            {
                Dates = dates.Select(d => d.ToString("yyyy-MM-dd")).ToList(),
                Revenue = revenueList,
                TotalTicketsSold = ticketSales,
                TotalRevenue = totalRevenue
            };

            return Ok(chartData);
        }

    }
}
