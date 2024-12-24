using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Statistics;
using NeonCinema_Application.Interface.Statistics;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Statistics
{
	public class StatisticsRepository : IStatisticsRepository
	{
		private readonly NeonCinemasContext _context;

		public StatisticsRepository(NeonCinemasContext context)
		{
			_context = context;
		}

		public async Task<decimal> GetTotalRevenueAsync(DateTime startDate, DateTime endDate)
		{
			return await _context.BillDetails
				.Where(b => b.CreatedTime >= startDate && b.CreatedTime <= endDate)
				.SumAsync(b => b.TotalPrice);
		}

		public async Task<int> GetTotalTicketsAsync(DateTime startDate, DateTime endDate)
		{
			return await _context.BillDetails
				.Where(bt => bt.CreatedTime >= startDate && bt.CreatedTime <= endDate)
				.CountAsync();
		}

		public async Task<int> GetNewCustomersAsync(DateTime startDate, DateTime endDate)
		{
			return await _context.Users
				.Where(u => u.CreatedTime >= startDate && u.CreatedTime <= endDate)
				.CountAsync();
		}

		public async Task<List<DailyRevenueDTO>> GetDailyRevenueAsync(DateTime startDate, DateTime endDate)
		{
			var data = await _context.BillDetails
				.Where(b => b.CreatedTime.HasValue && b.CreatedTime.Value >= startDate && b.CreatedTime.Value <= endDate)
				.GroupBy(b => b.CreatedTime.Value.Date)
				.Select(g => new DailyRevenueDTO
				{
					Date = g.Key,
					Revenue = g.Sum(b => b.TotalPrice)
				})
				.ToListAsync();

			Console.WriteLine($"Fetched {data.Count} daily revenue entries.");
			return data;
		}

		public async Task<List<ComboStatisticsDTO>> GetComboStatisticsAsync(DateTime startDate, DateTime endDate)
		{
			return await _context.BillCombos
		.Where(b => b.CreatedTime.HasValue && b.CreatedTime.Value >= startDate && b.CreatedTime.Value <= endDate)
		.GroupBy(bc => bc.FoodComboID)
		.Select(g => new ComboStatisticsDTO
		{
			ComboID = g.Key,
			ComboName = g.FirstOrDefault().FoodCombo.Content,
			QuantitySold = g.Sum(bc => bc.Quantity)
		})
		.ToListAsync();
		}

		//public async Task<List<MovieStatisticsDTO>> GetMovieStatisticsAsync(DateTime startDate, DateTime endDate)
		//{
		//	//return await _context.BillDetails.AsNoTracking().Include(x => x.Ticket).ThenInclude(x => x.Movies)
		//	//		.Where(b => b.CreatedTime.HasValue && b.CreatedTime.Value >= startDate && b.CreatedTime.Value <= endDate)
		//	//	.GroupBy(bt => bt.Ticket.)
		//	//	.Select(g => new MovieStatisticsDTO
		//	//	{
		//	//		MovieID = g.Key,
		//	//		MovieName = g.FirstOrDefault().Tickets.Movies.Name,
		//	//		Revenue = g.Sum(bt => bt.Tickets.Price),
		//	//		TicketsSold = g.Count()
		//	//	})
		//	//	.ToListAsync();
		//}
	}
}
