using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.BookTickets
{
	public class BookTicket
	{
		private readonly NeonCinemasContext _context;
        public BookTicket(NeonCinemasContext context)
        {
            _context = context;
        }
    }
}
