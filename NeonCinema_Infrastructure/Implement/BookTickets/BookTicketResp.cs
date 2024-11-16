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
				var respone = _context.Screening.Where(x => x.MovieID == request.MovieId);

				return new HttpResponseMessage(HttpStatusCode.OK);
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
