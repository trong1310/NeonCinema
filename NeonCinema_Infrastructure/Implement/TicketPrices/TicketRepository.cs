using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Interface;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NeonCinema_Domain.Enum;

namespace NeonCinema_Infrastructure.Implement.Tickets

{
    public class TicketRepository : ITicketRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public TicketRepository(IMapper mapper)
        {
            _context = new NeonCinemasContext();
            _mapper = mapper;
        }
        public async Task<HttpResponseMessage> CreateTicket(TicketPrice ticket, CancellationToken cancellationToken)
        {
            try
            {
                TicketPrice tk = new TicketPrice()
                {
                    ID = Guid.NewGuid(),
                    Price = ticket.Price,
                    SeatTypeID = ticket.SeatTypeID,
                    ShowTimeID = ticket.ShowTimeID,
                    Status = ticket.Status,
                    ScreeningID = ticket.ScreeningID,
                };
                await _context.Ticket.AddAsync(tk);
                await _context.SaveChangesAsync(cancellationToken);
                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Created successfully")
                };

            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> DeleteTicket(TicketPrice ticket, CancellationToken cancellationToken)
        {
            try
            {
                var tk = await _context.Ticket.FindAsync(ticket.ID, cancellationToken);

                if (tk == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Ticket is not found")
                    };
                }

                _context.Ticket.Remove(tk);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete ticket complete")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<TicketDTO> GetTicketById(Guid id, CancellationToken cancellationToken)
        {
            if (id != null)
            {
                var tk = await _context.Ticket.FindAsync(id);

                if (tk == null)
                {
                    throw new Exception("Ticket is not found");
                }

                return _mapper.Map<TicketDTO>(tk);
            }

            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> UpdateTicket(TicketPrice ticket, CancellationToken cancellationToken)
        {
            try
            {
                var tk = await _context.Ticket.FindAsync(ticket.ID);
                if (tk == null)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("Ticket is not found")
                    };
                }

                tk.Price = ticket.Price;
                tk.SeatTypeID = ticket.SeatTypeID;
                tk.ShowTimeID = ticket.ShowTimeID;
                tk.Status = ticket.Status;
                tk.ScreeningID = ticket.ScreeningID;
                _context.Ticket.Update(tk);

                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent("Update ticket complete")
                };

            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }

        }
    }
}
