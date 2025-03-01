﻿using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookingHistory;
using NeonCinema_Application.Interface.IBookingHistory;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
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
				.Where(t => t.Bills.UserID == userId)
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
					Tickets = b.Ticket.Select(bt => new BookingHistoryDTO
					{
						TicketID = bt.ID,
						MovieName = bt.Movies.Name,
						ShowDate = bt.Screenings.ShowDate,
						StartTime = bt.Screenings.ShowTime.StartTime,
						SeatNumber = bt.Seat.SeatNumber,
						Price = bt.Price,
						Status = bt.Status.ToString()
					}).ToList(),
					Combos = b.BillCombos.Select(bc => new ComboDTO
					{
						ComboName = bc.FoodCombo.Content,
						Quantity = bc.Quantity,
						Price = (decimal)bc.FoodCombo.TotalPrice
					}).ToList()
				})
				.ToListAsync();
		}
		public async Task<List<BookingHistoryDTO>> GetAllBookingHistoryAsync()
		{
			return await _context.Tickets
				.Include(t => t.Screenings).ThenInclude(s => s.Movies)
				.Include(x=>x.Bills).ThenInclude(x=>x.Users)
				.Select(t => new BookingHistoryDTO
				{
					TicketID = t.ID,
					MovieName = t.Screenings.Movies.Name,
					ShowDate = t.Screenings.ShowDate,
					StartTime = t.Screenings.ShowTime.StartTime,
					SeatNumber = t.Seat.SeatNumber,
					Price = t.Price,
					Status = t.Status.ToString(),
					UserName = t.Bills.Users.FullName,
					Theater = t.Screenings.Rooms.Cinemas.Name,
					Room = t.Screenings.Rooms.Name,
					MoviePoster = $"/images/export/{t.Screenings.Movies.Images}"
				})
				.ToListAsync();
		}



		public async Task<List<BillHistoryDTO>> GetAllBillHistoryAsync()
		{
			var users = await _context.Users.ToDictionaryAsync(u => u.ID, u => u.FullName);

			// Chỉ lấy các Bill có Status == checkin (0) HOẶC paid (2)
			return await _context.BillDetails
				.Where(b => b.Status == ticketEnum.checkin || b.Status == ticketEnum.paid)
				.Select(b => new BillHistoryDTO
				{
					BillID = b.ID,
					UserName = b.Users.FullName,
					BillCode = b.BillCode,
					TotalPrice = Convert.ToDecimal(b.AfterDiscount),
					BillDate = b.CreatedTime.Value,
					StaffID = b.CreatedBy,
					StaffName = b.CreatedBy.HasValue && users.ContainsKey(b.CreatedBy.Value)
							   ? users[b.CreatedBy.Value]
							   : "Không xác định",
					Status = b.Status.ToString(),
					Tickets = b.Ticket.Select(bt => new BookingHistoryDTO
					{
						UserName = b.Users.FullName,
						TicketID = bt.ID,
						MovieName = bt.Movies.Name,
						ShowDate = bt.Screenings.ShowDate,
						StartTime = bt.Screenings.ShowTime.StartTime,
						EndTime = bt.Screenings.ShowTime.EndTime,
						SeatNumber = bt.Seat.SeatNumber,
						Price = bt.Price,
						Room = bt.Screenings.Rooms.Name,
						Status = bt.Status.ToString(),
						MoviePoster = $"/Resources/export/{bt.Movies.Images}.png"
					}).ToList(),
					Combos = b.BillCombos.Select(bc => new ComboDTO
					{
						ComboName = bc.FoodCombo.Content,
						Quantity = bc.Quantity,
						Price = (decimal)bc.FoodCombo.TotalPrice
					}).ToList()
				})
				.ToListAsync();
		}
		

	}

}
