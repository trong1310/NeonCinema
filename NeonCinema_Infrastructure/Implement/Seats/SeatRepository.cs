using NeonCinema_Application.Interface.Seats;
using NeonCinema_Application.Pagination;
using NeonCinema_Infrastructure.Database.AppDbContext;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Seats;

namespace NeonCinema_Infrastructure.Implement.Seats
{
    public class SeatRepository : ISeatRepository
    {
        private readonly NeonCinemasContext _context;
        public SeatRepository(NeonCinemasContext context)
        {
            _context = context;
        }
        public async Task AddAsync(NeonCinema_Domain.Database.Entities.Seat seat)
        {
            
            ValidateSeat(seat);

            await _context.Seat.AddAsync(seat);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
           
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID không hợp lệ.");
            }

            var seat = await GetByIdAsync(id);
            if (seat == null)
            {
                throw new KeyNotFoundException("Không tìm thấy ghế để xóa.");
            }

            _context.Seat.Remove(seat);
            await _context.SaveChangesAsync();
        }

        public async Task<PaginationResponse<NeonCinema_Domain.Database.Entities.Seat>> GetAllAsync(PaginationRequest request)
        {
            
            var totalRecords = await _context.Seat.CountAsync();

           
            var data = await _context.Seat
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            
            bool hasNext = (request.PageNumber * request.PageSize) < totalRecords;

            
            var paginationResponse = new PaginationResponse<NeonCinema_Domain.Database.Entities.Seat>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = data
            };

            return paginationResponse;
        }

        public async Task<List<SeatDTO>> GetAllSeatAsync()
        {
            var seats = await _context.Seat
           .Include(s => s.Room)           
           .Include(s => s.SeatTypes)       
           .Select(s => new SeatDTO
               {
                   ID = s.ID,
                   SeatNumber = s.SeatNumber,
                   Column = s.Column,
                   Row = s.Row,
                   Status = s.Status,
                   RoomID = s.RoomID,
                   SeatTypeID = s.SeatTypeID,
                   RoomName = s.Room.Name,          
                   SeatTypeName = s.SeatTypes.SeatTypeName 
               })
               .ToListAsync();

            return seats;
        }

        public async Task<NeonCinema_Domain.Database.Entities.Seat> GetByIdAsync(Guid id)
        {
            
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ID không hợp lệ.");
            }

            var seat = await _context.Seat.FindAsync(id);
            if (seat == null)
            {
                throw new KeyNotFoundException("Không tìm thấy ghế với ID này.");
            }

            return seat;
        }

        public async Task UpdateAsync(NeonCinema_Domain.Database.Entities.Seat seat)
        {
           
            var existingSeat = await GetByIdAsync(seat.ID);
            if (existingSeat == null)
            {
                throw new KeyNotFoundException("Không tìm thấy ghế để cập nhật.");
            }

            
            ValidateSeat(seat);
            existingSeat.Column = seat.Column;
            existingSeat.Status = seat.Status;
            existingSeat.SeatNumber = seat.SeatNumber;
            existingSeat.Ticket = seat.Ticket;
            existingSeat.TicketSeats = seat.TicketSeats;
            existingSeat.Row = seat.Row;
            existingSeat.RoomID = seat.RoomID;
            existingSeat.SeatTypeID = seat.SeatTypeID;
            _context.Seat.Update(seat);
            await _context.SaveChangesAsync();
        }
        
        private void ValidateSeat(NeonCinema_Domain.Database.Entities.Seat seat)
        {
            if (seat == null)
            {
                throw new ArgumentException("Dữ liệu ghế không hợp lệ.");
            }

            
            if (string.IsNullOrWhiteSpace(seat.SeatNumber))
            {
                throw new ArgumentException("Số ghế không được để trống.");
            }

            
        }



    }
}