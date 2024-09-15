using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Tickets
{
    public class BookTicketRepository : IEntityRepository<BookTickets>
    {
        NeonCinemasContext _context;
        public BookTicketRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task<HttpResponseMessage> Create(BookTickets entity, CancellationToken cancellationToken)
        {
            try
            {

                BookTickets bt = new BookTickets
                {
                    ID = Guid.NewGuid(),
                    CustomerID = entity.CustomerID,
                    TicketID = entity.TicketID,
                    Status = EntityStatus.PendingForConfirmation
                };

                _context.BookTickets.Add(bt);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Create successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<HttpResponseMessage> Delete(BookTickets entity, CancellationToken cancellationToken)
        {
            try
            {
                var bt = await _context.BookTickets.FindAsync(entity.ID);

                if (bt == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("BookTicket is not found")
                    };
                }

                _context.BookTickets.Remove(bt);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Delete successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }

        public async Task<List<BookTickets>> GetAll(CancellationToken cancellationToken)
        {
            var lst = await _context.BookTickets
                .Include(x => x.Customers)
                .Include(x => x.Tickets)
                .ToListAsync(cancellationToken);

            return lst;
        }

        public async Task<BookTickets> GetById(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var st = await _context.BookTickets.FindAsync(id);

                if (st == null)
                {
                    throw new Exception("BookTicket is not found");
                }


                return st;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<HttpResponseMessage> Update(BookTickets entity, CancellationToken cancellationToken)
        {
            try
            {
                var bt = await _context.BookTickets.FindAsync(entity.ID);

                if (bt == null)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest)
                    {
                        Content = new StringContent("BookTicket is not found")
                    };
                }

                bt.CustomerID = entity.CustomerID;
                bt.TicketID = entity.TicketID;
                bt.Status = entity.Status;

                _context.BookTickets.Update(bt);
                await _context.SaveChangesAsync(cancellationToken);

                return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
                {
                    Content = new StringContent("Update successfully")
                };
            }
            catch (Exception ex)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError)
                {
                    Content = new StringContent(ex.Message)
                };
            }
        }
    }
}
