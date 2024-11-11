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
        private readonly IStatisticsRepository _statisticsRepository;
        private readonly IMapper _mapper;

        public StatisticsController(IStatisticsRepository statisticsRepository, IMapper mapper)
        {
            _statisticsRepository = statisticsRepository;
            _mapper = mapper;
        }

        [HttpGet("daily-revenue")]
        public async Task<IActionResult> GetDailyRevenue([FromQuery] DateTime date, CancellationToken cancellationToken)
        {
            var dailyRevenue = await _statisticsRepository.GetDailyRevenue(date, cancellationToken);
            return Ok(dailyRevenue);
        }

        [HttpGet("new-customers")]
        public async Task<IActionResult> GetNewCustomers([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, CancellationToken cancellationToken)
        {
            var newCustomers = await _statisticsRepository.GetNewCustomers(startDate, endDate, cancellationToken);
            return Ok(newCustomers);
        }

        [HttpGet("total-tickets")]
        public async Task<IActionResult> GetTotalTickets([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, CancellationToken cancellationToken)
        {
            var totalTickets = await _statisticsRepository.GetTotalTickets(startDate, endDate, cancellationToken);
            return Ok(totalTickets);
        }

        [HttpGet("total-revenue")]
        public async Task<IActionResult> GetTotalRevenue([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, CancellationToken cancellationToken)
        {
            var totalRevenue = await _statisticsRepository.GetTotalRevenue(startDate, endDate, cancellationToken);
            return Ok(totalRevenue);
        }

        [HttpGet("food-combos")]
        public async Task<IActionResult> GetFoodCombos([FromQuery] DateTime startDate, [FromQuery] DateTime endDate, CancellationToken cancellationToken)
        {
            var foodCombos = await _statisticsRepository.GetFoodCombos(startDate, endDate, cancellationToken);
            var foodComboDtos = foodCombos.Select(fc => new FoodComboDto
            {
               
                Quantity = fc.Quantity,
                TotalPrice = fc.TotalPrice
            }).ToList();
            return Ok(foodComboDtos);
        }

        [HttpGet("all-statistics")]
        public async Task<IActionResult> GetAllStatistics([FromQuery] DateTime date, [FromQuery] DateTime startDate, [FromQuery] DateTime endDate, CancellationToken cancellationToken)
        {
            var dailyRevenue = await _statisticsRepository.GetDailyRevenue(date, cancellationToken);
            var newCustomers = await _statisticsRepository.GetNewCustomers(startDate, endDate, cancellationToken);
            var totalTickets = await _statisticsRepository.GetTotalTickets(startDate, endDate, cancellationToken);
            var totalRevenue = await _statisticsRepository.GetTotalRevenue(startDate, endDate, cancellationToken);
            var foodCombos = await _statisticsRepository.GetFoodCombos(startDate, endDate, cancellationToken);

            var foodComboss = await _statisticsRepository.GetFoodCombos(startDate, endDate, cancellationToken);
            var foodComboDtos = _mapper.Map<List<FoodComboDto>>(foodComboss);
            
            var response = new StatisticsResponseDto
            {
                DailyRevenue = dailyRevenue,
                NewCustomers = newCustomers,
                TotalTickets = totalTickets,
                TotalRevenue = totalRevenue,
                FoodCombos = foodComboDtos
            };

            return Ok(response);
        }
    }
}
