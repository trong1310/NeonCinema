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
    //public class TicketRepository : ITicketRepository
    //{
    //    private readonly NeonCenimaContext _context;
    //    private readonly IMapper _mapper;

    //    public TicketRepository(IMapper mapper)
    //    {
    //        _context = new NeonCenimaContext();
    //        _mapper = mapper;
    //    }
    //    public async Task<HttpResponseMessage> CreateTicket(Ticket ticket, CancellationToken cancellationToken)
    //    {
    //        try
    //        {
    //            if(ticket.Price == null ||
    //               ticket.BarCode == null ||
    //               ticket.CustomerID == null ||
    //               ticket.SeatID == null ||
    //               ticket.Screening == null)
    //            {
    //                return new HttpResponseMessage(HttpStatusCode.BadRequest)
    //                {
    //                    Content = new StringContent("Please enter enough")
    //                };
    //            }

    //            var findSeatByid = await _context.Seat.FindAsync(ticket.SeatID);

    //            if(findSeatByid != null)
    //            {
    //                return new HttpResponseMessage(HttpStatusCode.BadRequest)
    //                {
    //                    Content = new StringContent("Seat already exists")
    //                };
    //            }

    //            Ticket tk = new Ticket()
    //            {
    //                TicketID = Guid.NewGuid(),
    //                Price = ticket.Price,
    //                BarCode = ticket.BarCode,
    //                Status = EntityStatus.PendingForApproval,
    //                PurchaseDate = DateTime.Now,
    //                CustomerID = ticket.CustomerID,
    //                SeatID = ticket.SeatID,
    //                Screening = ticket.Screening,
    //            };
    //            await _context.Ticket.AddAsync(tk);
    //            await _context.SaveChangesAsync(cancellationToken);
    //            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
    //            {
    //                Content = new StringContent("Created successfully")
    //            };

    //        }
    //        catch (Exception ex)
    //        {
    //            return new HttpResponseMessage(HttpStatusCode.InternalServerError)
    //            {
    //                Content = new StringContent(ex.Message)
    //            };
    //        }
    //    }

    //    public async Task<HttpResponseMessage> DeleteTicket(Ticket ticket, CancellationToken cancellationToken)
    //    {
    //        try
    //        {
    //            var tk = await _context.Ticket.FindAsync(ticket.TicketID, cancellationToken);

    //            if(tk == null)
    //            {
    //                return new HttpResponseMessage(HttpStatusCode.BadRequest)
    //                {
    //                    Content = new StringContent("Ticket is not found")
    //                };
    //            }

    //            _context.Ticket.Remove(tk);
    //            await _context.SaveChangesAsync(cancellationToken);

    //            return new HttpResponseMessage(HttpStatusCode.OK)
    //            {
    //                Content = new StringContent("Delete ticket complete")
    //            };
    //        }
    //        catch(Exception ex) 
    //        {
    //            return new HttpResponseMessage(HttpStatusCode.InternalServerError)
    //            {
    //                Content = new StringContent(ex.Message)
    //            };
    //        }
    //    }

    //    public async Task<List<TicketDTO>> GetAllTicket(CancellationToken cancellationToken)
    //    {
    //        var lst = await _context.Ticket
    //            .Include(s => s.Seats)
    //            .Include(s => s.Customers)
    //            .Include(s => s.Screening)
    //            .ToListAsync(cancellationToken);
    //        return lst.Select(ticket => _mapper.Map<TicketDTO>(ticket)).ToList();
    //    }

    //    public async Task<TicketDTO> GetTicketById(Guid id, CancellationToken cancellationToken)
    //    {
    //        if(id != null)
    //        {
    //            var tk = await _context.Ticket.FindAsync(id);

    //            if(tk == null)
    //            {
    //                throw new Exception("Ticket is not found");
    //            }

    //            return  _mapper.Map<TicketDTO>(tk);
    //        }
            
    //        throw new NotImplementedException();       
    //    }

    //    public async Task<HttpResponseMessage> UpdateTicket(Ticket ticket, CancellationToken cancellationToken)
    //    {
    //        try
    //        {
    //            var tk = await _context.Ticket.FindAsync(ticket.TicketID);
    //            if(tk == null)
    //            {
    //                return new HttpResponseMessage(HttpStatusCode.BadRequest)
    //                {
    //                    Content = new StringContent("Ticket is not found")
    //                };
    //            }

    //            tk.Price = ticket.Price;
    //            tk.Status = ticket.Status;
    //            tk.BarCode = ticket.BarCode;
    //            tk.CustomerID = ticket.CustomerID;
    //            tk.Screening = ticket.Screening;
    //            tk.SeatID = ticket.SeatID;

    //            _context.Ticket.Update(tk);

    //            await _context.SaveChangesAsync(cancellationToken);

    //            return new HttpResponseMessage(HttpStatusCode.OK)
    //            {
    //                Content = new StringContent("Update ticket complete")
    //            };

    //        }
    //        catch (Exception ex)
    //        {
    //            return new HttpResponseMessage(HttpStatusCode.InternalServerError)
    //            {
    //                Content = new StringContent(ex.Message)
    //            };
    //        }

    //    }
    //}
}
