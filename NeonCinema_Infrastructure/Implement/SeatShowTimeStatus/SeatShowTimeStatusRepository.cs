using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.SeatShowTimeStatus;
using NeonCinema_Application.Interface.SeatShowTimeStatus;
using NeonCinema_Application.Pagination;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.SeatShowTimeStatus
{
    public class SeatShowTimeStatusRepository : ISeatShowTimeStatusRepository
    {
        private readonly NeonCinemasContext _context;
        private readonly IMapper _mapper;

        public SeatShowTimeStatusRepository(NeonCinemasContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public async Task AddAsync(CreateSeatShowTimeStatusDTO createSeatShowTimeStatusDTO)
        {
            // Kiểm tra xem tất cả các thuộc tính yêu cầu có được cung cấp đầy đủ không
            if (createSeatShowTimeStatusDTO.SeatID == Guid.Empty )
            {
                throw new ArgumentException("SeatId and ShowTimeId cannot be empty");
            }
            

            var seatShowTimeStatus = _mapper.Map<Seat_ShowTime_Status>(createSeatShowTimeStatusDTO);
            await _context.Seat_ShowTime_Status.AddAsync(seatShowTimeStatus);
            await _context.SaveChangesAsync();
        }


        public async Task DeleteAsync(Guid id)
        {
            // Kiểm tra ID
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Invalid ID");
            }

            var seatShowTimeStatus = await _context.Seat_ShowTime_Status.FindAsync(id);
            if (seatShowTimeStatus == null) throw new KeyNotFoundException("Seat_ShowTime_Status not found");

            _context.Seat_ShowTime_Status.Remove(seatShowTimeStatus);
            await _context.SaveChangesAsync();
        }

        public async Task<PaginationResponse<SeatShowTimeStatusDTO>> GetAllAsync(PaginationRequest request)
        {
            // Kiểm tra nếu số trang hoặc kích thước trang không hợp lệ
            if (request.PageNumber <= 0 || request.PageSize <= 0)
            {
                throw new ArgumentException("PageNumber and PageSize must be greater than zero");
            }

            var totalRecords = await _context.Seat_ShowTime_Status.CountAsync();
            var data = await _context.Seat_ShowTime_Status
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync();

            bool hasNext = (request.PageNumber * request.PageSize) < totalRecords;

            var seatShowTimeStatusDTOs = _mapper.Map<List<SeatShowTimeStatusDTO>>(data);

            return new PaginationResponse<SeatShowTimeStatusDTO>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = hasNext,
                Data = seatShowTimeStatusDTOs
            };
        }

        public async Task<SeatShowTimeStatusDTO> GetByIdAsync(Guid id)
        {
            // Kiểm tra tính hợp lệ của ID
            if (id == Guid.Empty)
            {
                throw new ArgumentException("Invalid ID");
            }

            var seatShowTimeStatus = await _context.Seat_ShowTime_Status.FindAsync(id);
            if (seatShowTimeStatus == null) throw new KeyNotFoundException("Seat_ShowTime_Status not found");

            return _mapper.Map<SeatShowTimeStatusDTO>(seatShowTimeStatus);
        }

        public async Task UpdateAsync(UpdateSeatShowTimeStatusDTO updateSeatShowTimeStatusDTO)
        {
            // Kiểm tra ID
            if (updateSeatShowTimeStatusDTO.ID == Guid.Empty)
            {
                throw new ArgumentException("Invalid ID");
            }
            if (updateSeatShowTimeStatusDTO.SeatID == Guid.Empty || updateSeatShowTimeStatusDTO.ShowTime == null)
            {
                throw new ArgumentException("SeatId and ShowTimeId cannot be empty");
            }
            if (updateSeatShowTimeStatusDTO.Status== null)
            {
                throw new ArgumentException("Status is required");
            }

            var seatShowTimeStatus = await _context.Seat_ShowTime_Status.FindAsync(updateSeatShowTimeStatusDTO.ID);
            if (seatShowTimeStatus == null) throw new KeyNotFoundException("Seat_ShowTime_Status not found");

            _mapper.Map(updateSeatShowTimeStatusDTO, seatShowTimeStatus);
            _context.Seat_ShowTime_Status.Update(seatShowTimeStatus);
            await _context.SaveChangesAsync();
        }
    }
}
