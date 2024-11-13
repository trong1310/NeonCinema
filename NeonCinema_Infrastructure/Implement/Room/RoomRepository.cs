using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.DataTransferObject.Seats;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace NeonCinema_Infrastructure.Implement.Room
{
    public class RoomRepository : IRoomRepository
    {
        private readonly NeonCinemasContext _context;
        public RoomRepository(NeonCinemasContext ct)
        {
            _context = ct;
        }

        public async Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request, CancellationToken cancellationToken)
        {
            var room = new NeonCinema_Domain.Database.Entities.Room
            {
                ID = Guid.NewGuid(),
                Name = request.Name,
                SeatingCapacity = request.RowNumber * request.ColumnNumber,
                Status = request.Status,
                RowNumber = request.RowNumber,
                ColumnNumber = request.ColumnNumber,
                CinemasId = request.CinemasId
            };
            _context.Room.Add(room);

            var seats = new List<NeonCinema_Domain.Database.Entities.Seat>();

            for (int row = 1; row <= request.RowNumber; row++)
            {
                for (int column = 1; column <= request.ColumnNumber; column++)
                {
                    var seat = new NeonCinema_Domain.Database.Entities.Seat
                    {
                        ID = Guid.NewGuid(),
                        SeatNumber = $"{row}-{column}", 
                        Row = row.ToString(),
                        Column = column.ToString(),
                        Status = seatEnum.drum, 
                        RoomID = room.ID,
                        SeatTypeID = Guid.Parse("54634cf1-6e98-48bf-b97c-f9d065dd3c54") 
                    };
                    seats.Add(seat);
                }
            }
            _context.Seat.AddRange(seats);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public async Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken)
        {
            return await _context.Room
                .Select(room => new RoomDTO
                {
                    ID = room.ID,
                    Name = room.Name,
                    SeatingCapacity = room.RowNumber * room.ColumnNumber,
                    Status = room.Status,
                    RowNumber = room.RowNumber,
                    ColumnNumber = room.ColumnNumber,
                    CinemasId = room.CinemasId
                })
                .ToListAsync(cancellationToken);
        }

        public async Task<RoomDTO> GetByIDRoom(Guid id, CancellationToken cancellationToken)
        {
            var room = await _context.Room
                .FirstOrDefaultAsync(r => r.ID == id, cancellationToken);

            if (room == null)
                throw new KeyNotFoundException("Room not found");

            return new RoomDTO
            {
                ID = room.ID,
                Name = room.Name,
                SeatingCapacity = room.SeatingCapacity,
                Status = room.Status,
                RowNumber = room.RowNumber,
                ColumnNumber = room.ColumnNumber,
                CinemasId = room.CinemasId
            };
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request)
        {
            var room = await _context.Room
                .FirstOrDefaultAsync(r => r.ID == id);

            if (room == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            room.ID = request.ID;
            room.Name = request.Name;
            room.Status = request.Status;
            room.SeatingCapacity = request.SeatingCapacity;
            room.RowNumber = request.RowNumber;
            room.ColumnNumber = request.ColumnNumber;
            room.CinemasId = request.CinemasId;

            //Lấy tất cả các ghế hiện có trong Room
            var existingSeats = _context.Seat
                .Where(s => s.RoomID == room.ID)
                .ToList();

            var seatsToAdd = new List<NeonCinema_Domain.Database.Entities.Seat>();
            var seatsToRemove = new List<NeonCinema_Domain.Database.Entities.Seat>();
            // Lặp qua hàng và cột để kiểm tra ghế
            for (int row = 1; row <= request.RowNumber; row++)
            {
                for (int column = 1; column <= request.ColumnNumber; column++)
                {
                    string seatNumber = $"{row}-{column}";

                    // Kiểm tra xem ghế đã tồn tại chưa
                    var existingSeat = existingSeats
                        .FirstOrDefault(s => s.SeatNumber == seatNumber);

                    if (existingSeat != null)
                    {
                        // Cập nhật thông tin ghế nếu cần
                        existingSeat.Row = row.ToString();
                        existingSeat.Column = column.ToString();
                        existingSeat.Status = seatEnum.drum; // Cập nhật trạng thái nếu cần
                    }
                    else
                    {
                        // Thêm ghế mới nếu chưa tồn tại
                        var newSeat = new Seat
                        {
                            ID = Guid.NewGuid(),
                            SeatNumber = seatNumber,
                            Row = row.ToString(),
                            Column = column.ToString(),
                            Status = seatEnum.drum,
                            RoomID = room.ID,
                            SeatTypeID = Guid.Parse("54634cf1-6e98-48bf-b97c-f9d065dd3c54") // ID cố định hoặc thay đổi theo yêu cầu
                        };
                        seatsToAdd.Add(newSeat);
                    }
                }
            }
            foreach (var existingSeat in existingSeats)
            {
                int row = int.Parse(existingSeat.Row);
                int column = int.Parse(existingSeat.Column);

                if (row > request.RowNumber || column > request.ColumnNumber)
                {
                    seatsToRemove.Add(existingSeat);
                }
            }
            // Thêm các ghế mới vào context
            if (seatsToAdd.Count > 0)
            {
                _context.Seat.AddRange(seatsToAdd);
            }
            if (seatsToRemove.Count > 0)
            {
                _context.Seat.RemoveRange(seatsToRemove);
            }
            await _context.SaveChangesAsync();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
