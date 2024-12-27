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

		public async Task<List<MovieStatisticsDTO>> GetMovieStatisticsAsync(DateTime startDate, DateTime endDate)
		{
			return await _context.BillDetails.AsNoTracking()
				.Include(bd => bd.Ticket!)
				.ThenInclude(t => t.Movies)
				.Where(bd => bd.CreatedTime.HasValue && bd.CreatedTime.Value >= startDate && bd.CreatedTime.Value <= endDate)
				.SelectMany(bd => bd.Ticket!.Select(t => new
				{
					t.Movies.ID,
					t.Movies.Name,
					t.Price
				}))
				.GroupBy(t => t.ID)
				.Select(g => new MovieStatisticsDTO
				{
					MovieID = g.Key,
					MovieName = g.First().Name,
					Revenue = g.Sum(t => t.Price),
					TicketsSold = g.Count()
				})
				.ToListAsync();
		}
		public async Task<RevenueStatisticsDTO> GetRevenueStatisticsAsync(DateTime? specificDate, DateTime? startDate, DateTime? endDate)
		{
			var queryBillDetails = _context.BillDetails.AsNoTracking().AsQueryable();
			var queryUsers = _context.Users.AsNoTracking().AsQueryable();

			// Lọc theo ngày cụ thể
			if (specificDate.HasValue)
			{
				queryBillDetails = queryBillDetails.Where(bd => bd.CreatedTime.HasValue && bd.CreatedTime.Value.Date == specificDate.Value.Date);
				queryUsers = queryUsers.Where(u => u.CreatedTime.HasValue && u.CreatedTime.Value.Date == specificDate.Value.Date);
			}
			// Lọc theo khoảng ngày
			else if (startDate.HasValue && endDate.HasValue)
			{
				queryBillDetails = queryBillDetails.Where(bd => bd.CreatedTime.HasValue && bd.CreatedTime.Value.Date >= startDate.Value.Date && bd.CreatedTime.Value.Date <= endDate.Value.Date);
				queryUsers = queryUsers.Where(u => u.CreatedTime.HasValue && u.CreatedTime.Value.Date >= startDate.Value.Date && u.CreatedTime.Value.Date <= endDate.Value.Date);
			}

			// Tính toán doanh thu
			var totalRevenue = await queryBillDetails.SumAsync(bd => bd.TotalPrice);

			// Tính tổng vé
			var totalTickets = await queryBillDetails.CountAsync();

			// Tính khách hàng mới
			var newCustomers = await queryUsers.CountAsync();

			// Tính doanh thu theo từng ngày
			var dailyRevenue = await queryBillDetails
				.GroupBy(bd => bd.CreatedTime.Value.Date)
				.Select(g => new DailyRevenueDTO
				{
					Date = g.Key,
					Revenue = g.Sum(bd => bd.TotalPrice)
				})
				.ToListAsync();

			return new RevenueStatisticsDTO
			{
				TotalRevenue = totalRevenue,
				TotalTickets = totalTickets,
				NewCustomers = newCustomers,
				RevenueChart = dailyRevenue
			};
		}


	}
}
