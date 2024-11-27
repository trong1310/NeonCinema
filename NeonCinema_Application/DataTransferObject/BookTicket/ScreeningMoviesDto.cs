using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.BookTicket
{
	public class ScreeningMoviesDto
	{
		public Guid Id { get; set; }
		public Guid MoviesID { get; set; }
		public TimeSpan? ShowTime { get; set; }
		public DateTime? ShowDate { get; set; }
		public string? RoomName { get; set; }
		public List<SeatDto>? Seats { get; set; }
	}
}