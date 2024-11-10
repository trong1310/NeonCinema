using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.BookTicket;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Extention.Utili;

namespace NeonCinema_Infrastructure.Implement.BookTickets
{
	public class BookTicketResp
	{
		private readonly NeonCinemasContext _context;
        public BookTicketResp(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> BookTicketCounter(CreateBookTicketRequest request,CancellationToken cancellationToken)
        {
            try
            {
                var screening = await _context.Screening.Include(x => x.Ticket).FirstOrDefaultAsync(x => x.ID == request.ScreningID);
                if (screening == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound);                   
                }
				var existingTicket = screening.Ticket.FirstOrDefault(t => t.SeatID == request.SeatID);
				if (existingTicket != null)
				{
                    return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
                    {
                        Content =new StringContent("(Ghế đã có người đặt vui lòng chọn ghế khác")
                    };
				}
                var ticketPrice = await _context.TicketPrice.Where(x=>x.ID == request.TicketPriceID).FirstOrDefaultAsync();
                if (ticketPrice == null) { return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound); }
                var ticket = new Ticket()
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
                await _context.SaveChangesAsync();
                var food = _context.FoodCombos.Where(x=>x.ID == request.FoodComboId).FirstOrDefault();
                var bill = new Bill()
                {
                    ID = Guid.NewGuid(),
                    BillCode = Uliti.GenerateBillCode(),
                    CreatedTime = DateTime.Now,
                    Status = NeonCinema_Domain.Enum.ticketEnum.waiting_for_payment,
                    TotalPrice = ticket.Price*food.TotalPrice,
                    UserID = request.CustomerID != null ? request.CustomerID : null,
                    FoodID = request.FoodComboId != null? request.FoodComboId : null,
                };
                await _context.BillDetails.AddAsync(bill);
                await _context.SaveChangesAsync();
                var billTicket = new BillTicket()
                {
                    BillId = bill.ID,
                    TicketId = ticket.ID,
                    CreatedTime = DateTime.UtcNow,
                };
                await _context.BillTickets.AddAsync(billTicket);
                await _context.SaveChangesAsync();
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK) 
                {
                    Content = new StringContent("(Đặt vé thành công")
                };
            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        public async Task<ScreeningMoviesDto> GetScreeningMovies(Guid MovieId)
        {
			TimeSpan currenTime = DateTime.Now.TimeOfDay;
            var date = DateTime.Now;
			var screening = await _context.Screening.Include(x=>x.ShowTime).Include(x=>x.Rooms).AsNoTracking().Where(x=>x.MovieID == MovieId).ToListAsync();
            var results = screening.Where(x => x.ShowTime.StartTime >= currenTime &&x.ShowDate.Day >= date.Day  && x.Status == NeonCinema_Domain.Enum.EntityStatus.Active).FirstOrDefault();
            if (results == null) return null;
            var dto = new ScreeningMoviesDto()
            {
                Id = results.ID,
                RoomName = results.Rooms.Name,
                ShowDate = results.ShowDate,
                ShowTime = results.ShowTime.StartTime,
            };
            return dto;
        }
    }
}
