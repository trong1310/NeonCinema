using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Ticket;
using NeonCinema_Application.Interface;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Ticket
{
    public class TicketRepository : ITicketRepository
    {
        private readonly NeonCenimaContext _context;
        private readonly IMapper _mapper;

        public TicketRepository(IMapper mapper)
        {
            _context = new NeonCenimaContext();
            _mapper = mapper;   
        }
        public Task<bool> CreateTicket(NeonCinema_Domain.Database.Entities.Ticket ticket, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTicket(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TicketDTO>> GetAllTicket(CancellationToken cancellationToken)
        {
            try
            {
                var lst = await _context.Ticket.ToListAsync(cancellationToken);
                return lst.Select(ticket => _mapper.Map<TicketDTO>(ticket)).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Task<TicketDTO> GetTicketById(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateTicket(NeonCinema_Domain.Database.Entities.Ticket ticket, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
