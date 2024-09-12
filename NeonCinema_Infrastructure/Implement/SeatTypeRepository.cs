using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.Interface;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement
{
    public class SeatTypeRepository : ISeatTypeRepository
    {
       private readonly NeonCinemasContext _context;
        public SeatTypeRepository( )
        {
                _context = new NeonCinemasContext();
        }
        public async Task AddAsync(SeatType seatType)
        {
            await _context.SeatTypes.AddAsync(seatType);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var seatType = await GetByIdAsync(id);
            if (seatType != null)
            {
                _context.SeatTypes.Remove(seatType);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<PaginationResponse<SeatType>> GetAllAsync(PaginationRequest request)
        {
            var totalItems = await _context.SeatTypes.CountAsync(); // Tổng số phần tử

            var data = await _context.SeatTypes
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            // Tính HasNext dựa trên tổng số phần tử và trang hiện tại
            var hasNext = (request.PageNumber * request.PageSize) < totalItems;

            // Tạo đối tượng PaginationResponse
            var response = new PaginationResponse<SeatType>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = data
            };

            return response;
        }

        public async Task<SeatType> GetByIdAsync(Guid id)
        {
            return await _context.SeatTypes.FindAsync(id);
        }

        public async Task UpdateAsync(SeatType seatType)
        {
            _context.SeatTypes.Update(seatType);
            await _context.SaveChangesAsync();
        }
    }
}
