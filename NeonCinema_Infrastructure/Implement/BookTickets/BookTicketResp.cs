﻿using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.Utili;
using System.Net;

namespace NeonCinema_Infrastructure.Implement.BookTickets
{
	public class BookTicketResp
	{
		private readonly NeonCinemasContext _context;
		public BookTicketResp(NeonCinemasContext context)
		{
			_context = context;
		}
		public async Task<HttpResponseMessage> BookTicketCounter(CreateBookTicketRequest request, CancellationToken cancellationToken)
		{
			try
			{
				var screening = await _context.Screening.Include(x => x.Ticket).FirstOrDefaultAsync(x => x.ID == request.ScreningID);
				if (screening == null)
				{
					return new HttpResponseMessage(HttpStatusCode.NotFound);
				}

				var existingTicket = screening.Ticket.FirstOrDefault(t => t.SeatID == request.SeatID);
				if (existingTicket != null)
				{
					return new HttpResponseMessage(HttpStatusCode.Conflict)
					{
						Content = new StringContent("Ghế đã có người đặt, vui lòng chọn ghế khác.")
					};
				}
				var ticketPrice = await _context.TicketPrice.FirstOrDefaultAsync(x => x.ID == request.TicketPriceID);
				if (ticketPrice == null)
				{
					return new HttpResponseMessage(HttpStatusCode.NotFound);
				}
				var ticket = new Ticket
				{
					ID = Guid.NewGuid(),
					SeatID = request.SeatID,
					MovieID = screening.MovieID,
					RoomID = screening.RoomID,
					ScreningID = screening.ID,
					TicketPriceID = ticketPrice.ID,
					Status = NeonCinema_Domain.Enum.ticketEnum.waiting_for_payment,
					Price = ticketPrice.Price,
					CreatedTime = DateTime.UtcNow,
				};
				await _context.Tickets.AddAsync(ticket);
				var bill = new Bill
				{
					ID = Guid.NewGuid(),
					BillCode = Uliti.GenerateBillCode(),
					CreatedTime = DateTime.Now,
					Status = NeonCinema_Domain.Enum.ticketEnum.waiting_for_payment,
					UserID = request.CustomerID
				};
				await _context.BillDetails.AddAsync(bill);
				await _context.SaveChangesAsync();

				decimal totalComboPrice = 0;
				foreach (var comboId in request.FoodComboId)
				{
					var foodCombo = await _context.FoodCombos.FirstOrDefaultAsync(x => x.ID == comboId);
					if (foodCombo != null)
					{
						totalComboPrice += foodCombo.TotalPrice * request.QuantityCombo;
					}
				}
				var billUpdate = await _context.BillDetails.FirstOrDefaultAsync(x => x.ID == bill.ID);
				billUpdate.TotalPrice = ticket.Price + totalComboPrice;

				 _context.BillDetails.Update(billUpdate);
				await _context.SaveChangesAsync();

				var billTicket = new BillTicket
				{
					BillId = bill.ID,
					TicketId = ticket.ID,
					CreatedTime = DateTime.UtcNow,
				};
				await _context.BillTickets.AddAsync(billTicket);
				await _context.SaveChangesAsync();

				return new HttpResponseMessage(HttpStatusCode.OK)
				{
					Content = new StringContent("Đặt vé thành công")
				};
			}
			catch (Exception ex)
			{
				throw;
			}
		}

		public async Task<ScreeningMoviesDto> GetScreeningMovies(Guid MovieId)
		{
			TimeSpan currenTime = DateTime.Now.TimeOfDay;
			var date = DateTime.Now;
			var screening = await _context.Screening.Include(x => x.ShowTime)
				.Include(x => x.Rooms)
				.ThenInclude(s => s.Seats)
				.ThenInclude(x => x.SeatTypes)
				.AsNoTracking().Where(x => x.MovieID == MovieId).ToListAsync();

			var results = screening.Where(x => x.ShowTime.StartTime >= currenTime && x.ShowDate.Day
			>= date.Day && x.Status == NeonCinema_Domain.Enum.EntityStatus.Active).FirstOrDefault();
			if (results == null) return null;
			var seat = results.Rooms.Seats.Select(x =>
			{
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatTypeID == x.SeatTypes.ID)
					.Select(tp => tp.Price)
					.FirstOrDefault();

				return new SeatDto
				{
					ID = x.ID,
					SeatNumber = x.SeatNumber,
					SeatType = x.SeatTypes.SeatTypeName,
					Price = ticketPrice
				};
			}).ToList();

			var dto = new ScreeningMoviesDto()
			{
				Id = results.ID,
				RoomName = results.Rooms.Name,
				ShowDate = results.ShowDate,
				ShowTime = results.ShowTime.StartTime,
				Seats = seat,
			};
			return dto;
		}
	}
}
