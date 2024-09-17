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
            // Kiểm tra dữ liệu đầu vào
            ValidateSeat(seat);

            await _context.Seat.AddAsync(seat);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            // Kiểm tra xem ID có hợp lệ không
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
            // Tính tổng số bản ghi để xác định có trang tiếp theo không
            var totalRecords = await _context.Seat.CountAsync();

            // Lấy dữ liệu cho trang hiện tại
            var data = await _context.Seat
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            // Xác định xem có trang tiếp theo không
            bool hasNext = (request.PageNumber * request.PageSize) < totalRecords;

            // Tạo đối tượng phân trang để trả về
            var paginationResponse = new PaginationResponse<NeonCinema_Domain.Database.Entities.Seat>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = data
            };

            return paginationResponse;
        }

        public async Task<NeonCinema_Domain.Database.Entities.Seat> GetByIdAsync(Guid id)
        {
            // Kiểm tra xem ID có hợp lệ hay không
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
            // Kiểm tra xem ghế có tồn tại không
            var existingSeat = await GetByIdAsync(seat.ID);
            if (existingSeat == null)
            {
                throw new KeyNotFoundException("Không tìm thấy ghế để cập nhật.");
            }

            // Kiểm tra tính hợp lệ của dữ liệu
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
        // Hàm kiểm tra tính hợp lệ của một Seat
        private void ValidateSeat(NeonCinema_Domain.Database.Entities.Seat seat)
        {
            if (seat == null)
            {
                throw new ArgumentException("Dữ liệu ghế không hợp lệ.");
            }

            // Ví dụ: Kiểm tra nếu số ghế hoặc một thuộc tính cụ thể khác của ghế là null hoặc không hợp lệ
            if (string.IsNullOrWhiteSpace(seat.SeatNumber))
            {
                throw new ArgumentException("Số ghế không được để trống.");
            }

            // Thêm các kiểm tra khác cho các thuộc tính khác của ghế
        }
    }
}
