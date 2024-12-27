using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ActorMovies
{
	public class ActorMoviesDto
	{
		public Guid ActorID { get; set; }
		public string ActorName { get; set; }
		public bool IsChecked { get; set; } = false;
	}
}
