using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
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
			using var transaction = await _context.Database.BeginTransactionAsync();
			try
			{
				List<Guid> TicketID = new List<Guid>();
				decimal price = 0;
				foreach(var seatId in request.SeatID)
				{
					var seat = await _context.Seat.FindAsync(seatId);
					if (seat == null || seat.Status != NeonCinema_Domain.Enum.seatEnum.Available)
						throw new Exception($"Ghế {seatId} không thể đặt bây giờ");
					var ticketPrice = seat.TicketPrice.Where(x => x.SeatID == seatId).FirstOrDefault();
					var ticket = new Ticket
					{
						ScreningID = request.ScreeningID,
						SeatID = seatId,
						Price = ticketPrice.Price,
						ID = Guid.NewGuid(),
						MovieID = request.MovieId,
						CreatedTime = DateTime.Now,
						Status = NeonCinema_Domain.Enum.ticketEnum.checkin,	
					};
					_context.Tickets.Add(ticket);
					seat.Status = NeonCinema_Domain.Enum.seatEnum.Sold;
					_context.Update(seat);
					TicketID.Add(ticket.ID);
					price += ticketPrice.Price;
				}
				await _context.SaveChangesAsync();
				decimal comboPrice = 0;
				foreach(var combo in request.BillCombos)
				{
					var foodCombo = await _context.FoodCombos.FindAsync(combo.FoodComboId);
					if(foodCombo != null)
					{
						comboPrice += foodCombo.TotalPrice * combo.Quantity;
					}
				}
				var bill = new Bill()
				{
					ID = Guid.NewGuid(),
					CreatedTime = DateTime.UtcNow,
					Status = NeonCinema_Domain.Enum.ticketEnum.checkin,
					BillCode = Uliti.GenerateBillCode(),
					TotalPrice  = price+comboPrice,
					
				};
				await _context.BillDetails.AddAsync(bill);
				await _context.SaveChangesAsync();

				// 4. Liên kết vé với hóa đơn
				foreach (var ticketId in TicketID)
				{
					_context.BillTickets.Add(new BillTicket
					{
						BillId = bill.ID,
						TicketId = ticketId
					});
				}

				// 5. Liên kết combo đồ ăn với hóa đơn
				foreach (var combo in request.BillCombos)
				{
					_context.BillCombos.Add(new BillCombo
					{
						BillID = bill.ID,
						FoodComboID = combo.FoodComboId,
						Quantity = combo.Quantity,
					});
				}

				await _context.SaveChangesAsync();
				await transaction.CommitAsync();
				return new HttpResponseMessage(HttpStatusCode.OK)
				{
					Content =new StringContent("Đặt vé thành công"),
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
			var screenings = await _context!.Screening
				.Include(x => x.ShowTime)
				.Include(x => x.Rooms)
					.ThenInclude(s => s.Seats!)
						.ThenInclude(x => x.SeatTypes)
				.Where(x => x.MovieID == MovieId)
				.ToListAsync();
			var upcomingScreening = screenings
				.Where(x => x.ShowTime.StartTime >= currentTime && x.ShowDate.Date >= date.Date)
				.OrderBy(x => x.ShowDate.Date)
				.ThenBy(x => x.ShowTime.StartTime)
				.FirstOrDefault();
			if (upcomingScreening == null) return null;
			var seats = upcomingScreening.Rooms!.Seats!.Select(x =>
			{
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatID == x.ID)
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
