using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.User;
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
				var billCombo = new BillCombo
				{
					BillID = bill.ID,
					FoodComboID = ticket.ID,
					CreatedTime = DateTime.UtcNow,
				};
				await _context.BillCombos.AddAsync(billCombo);
				await _context.SaveChangesAsync();
				decimal totalComboPrice = 0;
				var foodCombo = _context.FoodCombos.Where(x => x.ID == request.FoodComboId);
				foreach (var food in foodCombo)
				{
					if (foodCombo != null)
					{
						totalComboPrice += food.TotalPrice * request.QuantityCombo;
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
			TimeSpan currentTime = DateTime.Now.TimeOfDay;
			var date = DateTime.Now;
			var screenings = await _context.Screening
				.Include(x => x.ShowTime)
				.Include(x => x.Rooms)
					.ThenInclude(s => s.Seats)
						.ThenInclude(x => x.SeatTypes)
				.Where(x => x.MovieID == MovieId)
				.ToListAsync();
			var upcomingScreening = screenings
				.Where(x => x.ShowTime.StartTime >= currentTime && x.ShowDate.Date >= date.Date)
				.OrderBy(x => x.ShowDate.Date)
				.ThenBy(x => x.ShowTime.StartTime)
				.FirstOrDefault();
			if (upcomingScreening == null) return null;
			var seats = upcomingScreening.Rooms.Seats.Select(x =>
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

			// Tạo DTO trả về
			var dto = new ScreeningMoviesDto()
			{
				Id = upcomingScreening.ID,
				RoomName = upcomingScreening.Rooms.Name,
				ShowDate = upcomingScreening.ShowDate,
				ShowTime = upcomingScreening.ShowTime.StartTime,
				Seats = seats,
			};
			return dto;
		}
		public async Task<UserDTO> GetAccountByPhone(string phone, CancellationToken cancellationToken)
		{
			try
			{

				var obj = await _context.Users.Where(x => x.PhoneNumber == phone).FirstOrDefaultAsync();
				return new UserDTO()
				{
					ID = obj.ID,
					PhoneNumber = obj.PhoneNumber,
					Adderss = obj.Adderss,
					DateOrBriht = obj.DateOrBriht,
					Email = obj.Email,
					FullName = obj.FullName,
					Gender = obj.Gender,
					Images = obj.Images,
					PassWord = obj.PassWord,
					RoleID = obj.RoleID,
					Status = obj.Status,
				};
			}
			catch (Exception ex)
			{
				throw new Exception();
			}
		}

	}
}
