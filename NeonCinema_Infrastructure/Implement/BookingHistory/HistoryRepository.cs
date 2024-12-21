using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookingHistory;
using NeonCinema_Application.Interface.IBookingHistory;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.BookingHistory
{
	public class HistoryRepository : IHistoryRepository
	{
		private readonly NeonCinemasContext _context;

		public HistoryRepository(NeonCinemasContext context)
		{
				_context = context;
		}
		public async Task<List<BookingHistoryDTO>> GetBookingHistoryAsync(Guid userId)
		{
			return await _context.Tickets
				.Where(t => t.BillTickets.Any(b => b.Bills.UserID == userId))
				.Select(t => new BookingHistoryDTO
				{
					TicketID = t.ID,
					MovieName = t.Movies.Name,
					ShowDate = t.Screenings.ShowDate,
					StartTime = t.Screenings.ShowTime.StartTime,
					SeatNumber = t.Seat.SeatNumber,
					Price = t.Price,
					Status = t.Status.ToString()
				}).ToListAsync();
				
		}

		public async Task<List<BillHistoryDTO>> GetBillHistoryAsync(Guid userId)
		{
			return await _context.BillDetails
				.Where(b => b.UserID == userId)
				.Select(b => new BillHistoryDTO
				{
					BillID = b.ID,
					BillCode = b.BillCode,
					TotalPrice = b.TotalPrice,
					BillDate = b.CreatedTime.Value,
					Status = b.Status.ToString(),
					Tickets = b.BillTickets.Select(bt => new BookingHistoryDTO
					{
						TicketID = bt.TicketId,
						MovieName = bt.Tickets.Movies.Name,
						ShowDate = bt.Tickets.Screenings.ShowDate,
						StartTime = bt.Tickets.Screenings.ShowTime.StartTime,
						SeatNumber = bt.Tickets.Seat.SeatNumber,
						Price = bt.Tickets.Price,
						Status = bt.Tickets.Status.ToString()
					}).ToList(),
					Combos = b.BillCombos.Select(bc => new ComboDTO
					{
						ComboName = bc.FoodCombo.Content,
						Quantity = bc.Quantity,
						Price = bc.FoodCombo.TotalPrice
					}).ToList()
				})
				.ToListAsync();
		}
		public async Task<List<BookingHistoryDTO>> GetAllBookingHistoryAsync()
		{
			return await _context.Tickets
				.Include(t => t.Screenings)
				.ThenInclude(s => s.Movies)
				.Select(t => new BookingHistoryDTO
				{
					TicketID = t.ID,
					MovieName = t.Screenings.Movies.Name,
					ShowDate = t.Screenings.ShowDate,
					StartTime = t.Screenings.ShowTime.StartTime,
					SeatNumber = t.Seat.SeatNumber,
					Price = t.Price,
					Status = t.Status.ToString(),
					UserName = t.BillTickets.FirstOrDefault().Bills.Users.FullName,
					Theater = t.Screenings.Rooms.Cinemas.Name,
					Room = t.Screenings.Rooms.Name,
					MoviePoster = $"/images/export/{t.Screenings.Movies.Images}"
				})
				.ToListAsync();
		}



		public async Task<List<BillHistoryDTO>> GetAllBillHistoryAsync()
		{
			return await _context.BillDetails
				.Select(b => new BillHistoryDTO
				{
					BillID = b.ID,
					UserName = b.Users.FullName, // Lấy tên người dùng
					BillCode = b.BillCode,
					TotalPrice = b.TotalPrice,
					BillDate = b.CreatedTime.Value,
					Status = b.Status.ToString(),
					Tickets = b.BillTickets.Select(bt => new BookingHistoryDTO
					{
						UserName = b.Users.FullName, // Lấy tên người dùng
						TicketID = bt.TicketId,
						MovieName = bt.Tickets.Movies.Name,
						ShowDate = bt.Tickets.Screenings.ShowDate,
						StartTime = bt.Tickets.Screenings.ShowTime.StartTime,
						EndTime = bt.Tickets.Screenings.ShowTime.EndTime,
						SeatNumber = bt.Tickets.Seat.SeatNumber,
						Price = bt.Tickets.Price,
						Room = bt.Tickets.Screenings.Rooms.Name,
						Status = bt.Tickets.Status.ToString(),
						MoviePoster = $"/Resources/export/{bt.Tickets.Movies.Images}.png" // Đường dẫn đầy đủ tới hình ảnh phim
					}).ToList(),
					Combos = b.BillCombos.Select(bc => new ComboDTO
					{
						ComboName = bc.FoodCombo.Content,
						Quantity = bc.Quantity,
						Price = bc.FoodCombo.TotalPrice
					}).ToList()
				})
				.ToListAsync();
		}

	}

}
