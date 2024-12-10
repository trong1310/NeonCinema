using Com.CloudRail.SI.ServiceCode.Commands;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Application.DataTransferObject.BookTicket.Request;
using NeonCinema_Application.DataTransferObject.BookTicket.Resp;
using NeonCinema_Application.DataTransferObject.Screening;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.Utili;
using System.Net;
using System.Threading;

namespace NeonCinema_Infrastructure.Implement.BookTickets
{
	public class BookTicketResp
	{
		private readonly NeonCinemasContext _context;
		public BookTicketResp(NeonCinemasContext context)
		{
			_context = context;
		}
		 <MudNavLink Href="/listactor" Icon="fas fa-user" IconColor="Color.Success" Class="custom-nav-link">Quản lý diễn viên</MudNavLink>
 <MudNavLink Href="/listDirector" Icon="fas fa-user-tie" IconColor="Color.Primary" Class="custom-nav-link">Quản lý đạo diễn</MudNavLink>


		public async Task<List<ScreeningMoviesDto>> GetScreeningMovies(Guid MovieId, DateTime? showDate)
		{
			TimeSpan currentTime = DateTime.Now.TimeOfDay;
			var date = DateTime.Now;

			// Lấy danh sách các lịch chiếu của phim
			var screenings = await _context!.Screening
				.Include(x => x.ShowTime)
				.Include(x => x.Rooms)
					.ThenInclude(s => s.Seats!)
						.ThenInclude(x => x.SeatTypes)
				.Where(x => x.MovieID == MovieId && x.ShowDate.Date >= date.Date).Where(x => x.ShowTime.StartTime >= currentTime)
				.OrderBy(x => x.ShowDate.Date)
				.ThenBy(x => x.ShowTime.StartTime)
				.ToListAsync();

			if (screenings == null || !screenings.Any())
				return new List<ScreeningMoviesDto>();
			if (showDate.HasValue)
			{
				screenings = screenings.Where(x => x.ShowDate.Date == showDate.Value.Date && x.ShowDate.Month == showDate.Value.Month && x.ShowDate.Year == showDate.Value.Year).ToList();
			}
			// Ánh xạ từng lịch chiếu thành DTO
			var screeningDtos = screenings.Select(screening =>
			{
				return new ScreeningMoviesDto
				{
					Id = screening.ID,
					RoomName = screening.Rooms.Name,
					ShowDate = screening.ShowDate,
					ShowTime = screening.ShowTime.StartTime,
					MoviesID = screening.MovieID,
				};
			}).ToList();

			return screeningDtos;
		}

		public async Task<ScreeningMoviesDto> ChooseScreeningMovies(Guid Id)
		{
			var screenings = await _context!.Screening
							.Include(x => x.ShowTime)
							.Include(x => x.Rooms)
								.ThenInclude(s => s.Seats!)
									.ThenInclude(x => x.SeatTypes)
							.Where(x => x.ID == Id)
							.FirstOrDefaultAsync();
			var seatShowTime = await _context.SeatShowTimeStatuss
				.Include(x => x.ShowTime)
				.Include(x => x.Room)
				.Include(x => x.Seat).Where(x => x.ShowtimeId == screenings.ShowTimeID)
				.Where(x => x.RoomID == screenings.RoomID)
				.Where(x => x.ShowDate == screenings.ShowDate).ToListAsync();
			var seats = seatShowTime.Select(x =>
			{
				// Lấy giá dựa trên SeatTypeID thay vì SeatID
				var ticketPrice = _context.TicketPrice
					.Where(tp => tp.SeatTypeID == x.Seat.SeatTypes.ID) // Sửa: Lấy giá theo SeatTypeID
					.Select(tp => tp.Price)
					.FirstOrDefault();

				return new SeatDto
				{
					ID = x.Seat.ID,
					SeatNumber = x.Seat.SeatNumber,
					SeatType = x.Seat.SeatTypes.SeatTypeName,
					Status = x.seatEnum,
					Price = ticketPrice // Gán giá lấy được từ bảng TicketPrice
				};
			}).ToList();
			var dto = new ScreeningMoviesDto()
			{
				MoviesID = screenings.MovieID,
				Id = screenings.ID,
				RoomName = screenings.Rooms.Name,
				ShowDate = screenings.ShowDate,
				ShowTime = screenings.ShowTime.StartTime,
				Seats = seats,
			};
			return dto;
		}
		public async Task<RankMemberResp> GetAccountByPhone(string? phone, CancellationToken cancellationToken)
		{
			try
			{

				var obj = await _context.RankMembers.Include(x => x.Users).Where(x => x.Users.PhoneNumber == phone).FirstOrDefaultAsync();
				if (obj == null)
				{
					return null;
				}
				return obj == null ? null : new RankMemberResp()
				{
					Id = obj.ID,
					AccountName = obj.Users.FullName,
					AccountId = obj.UserID,
					Point = obj.MinPoint,
					Rank = obj.Rank,
				};

			}
			catch (Exception ex)
			{
				throw new Exception();
			}
		}

	}
}
