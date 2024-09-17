using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.SeatShowTimeStatus;
using NeonCinema_Application.DataTransferObject.TicketSeats;
using NeonCinema_Application.Interface.TicketSeats;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.TicketSeats
{
    public class TicketSeatRepository : ITicketSeatRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;
        public TicketSeatRepository(NeonCinemasContext context , IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task AddAsync(CreateTicketSeatDTO dto)
        {
            ValidateTicketSeat(dto);

            var ticketSeat = _mapper.Map<TicketSeat>(dto);
            await _context.TicketSeats.AddAsync(ticketSeat);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(Guid id)
        {
            var ticketSeat = await _context.TicketSeats.FindAsync(id);
            if (ticketSeat == null)
            {
                throw new KeyNotFoundException("TicketSeat not found");
            }

            _context.TicketSeats.Remove(ticketSeat);
            await _context.SaveChangesAsync();
        }

        public async Task<PaginationResponse<TicketSeatDTO>> GetAllAsync(PaginationRequest request)
        {
            // CountAsync requires Microsoft.EntityFrameworkCore namespace
            var totalRecords = await _context.TicketSeats.CountAsync();  // Fix here

            var data = await _context.TicketSeats
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            bool hasNext = (request.PageNumber * request.PageSize) < totalRecords;

            // Map the entities to DTOs
            var ticketSeatDTOs = _mapper.Map<List<TicketSeatDTO>>(data);  // Correct mapping here

            var result = new PaginationResponse<TicketSeatDTO>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = ticketSeatDTOs  // Assign mapped DTOs here
            };

            return result;
        }

        public async Task<TicketSeatDTO> GetByIdAsync(Guid id)
        {
            var ticketSeat = await _context.TicketSeats.FindAsync(id);
            if (ticketSeat == null)
            {
                throw new KeyNotFoundException("TicketSeat not found");
            }
            return _mapper.Map<TicketSeatDTO>(ticketSeat);
        }

        public async Task UpdateAsync(UpdateTicketSeatDTO dto)
        {

            
            var ticketSeat = await _context.TicketSeats.FindAsync(dto.ID);
            if (ticketSeat == null)
            {
                throw new KeyNotFoundException("TicketSeat not found");
            }
            ticketSeat.BillID = dto.BillID;
            ticketSeat.CinemasID = dto.CinemasID;
            ticketSeat.RoomID = dto.RoomID;
            ticketSeat.Status = dto.Status;
            ticketSeat.Price = dto.Price;
            ticketSeat.SeatShowTimeStatusID = dto.SeatShowTimeStatusID;
            ticketSeat.Show_ReleaseID = dto.Show_ReleaseID;
            ticketSeat.MovieID = dto.MovieID;
            ticketSeat.SeatID = dto.SeatID;
            _mapper.Map(dto, ticketSeat);
            _context.TicketSeats.Update(ticketSeat);
            await _context.SaveChangesAsync();
        }

        private void ValidateTicketSeat(CreateTicketSeatDTO dto)
        {
            if (dto.CinemasID == Guid.Empty)
                throw new ArgumentException("CinemasID is required");

            if (dto.RoomID == Guid.Empty)
                throw new ArgumentException("RoomID is required");

            if (dto.BillID == Guid.Empty)
                throw new ArgumentException("BillID is required");

            if (dto.MovieID == Guid.Empty)
                throw new ArgumentException("MovieID is required");

            if (dto.SeatID == Guid.Empty)
                throw new ArgumentException("SeatID is required");

            if (dto.Show_ReleaseID == Guid.Empty)
                throw new ArgumentException("Show_ReleaseID is required");

            if (dto.SeatShowTimeStatusID == Guid.Empty)
                throw new ArgumentException("SeatShowTimeStatusID is required");

            if (dto.Price <= 0)
                throw new ArgumentException("Price must be greater than zero");
        }

    }
}
