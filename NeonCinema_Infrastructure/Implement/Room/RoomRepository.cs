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
                CinemasId = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
                CreatedTime = DateTime.Now
            };
            _context.Room.Add(room);

            var seats = new List<NeonCinema_Domain.Database.Entities.Seat>();

            for (int row = 1; row <= request.RowNumber; row++)
            {
                char rowLetter = (char)('A' + row - 1);
                Guid seatTypeID;
                if (row == request.RowNumber)
                {
                    seatTypeID = Guid.Parse("587FF198-12D1-4EB4-9CE7-909DA4AF6BCB");
                }
                else if (row >= 5 && row <= request.RowNumber -1)
                {
                    seatTypeID = Guid.Parse("0CE08FD6-0D1D-4C61-8B8B-7827BAFF7FE1");
                }
                else
                {
                    seatTypeID = Guid.Parse("8FB86C77-213F-4316-8A7A-43FEE795514E");
                }
                for (int column = 1; column <= request.ColumnNumber; column++)
                {
                    var seat = new NeonCinema_Domain.Database.Entities.Seat
                    {
                        ID = Guid.NewGuid(),
                        SeatNumber = $"{rowLetter}{column}",
                        Row = row.ToString(),
                        Column = column.ToString(),
                        Status = seatEnum.Available,
                        RoomID = room.ID,
                        SeatTypeID = seatTypeID
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
            return await _context.Room.OrderByDescending(x => x.CreatedTime)
                .Select(room => new RoomDTO
                {
                    ID = room.ID,
                    Name = room.Name,
                    SeatingCapacity = room.RowNumber * room.ColumnNumber,
                    Status = room.Status,
                    RowNumber = room.RowNumber,
                    ColumnNumber = room.ColumnNumber,
                    CinemasId = room.CinemasId,

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
            room.SeatingCapacity = request.RowNumber * request.ColumnNumber;
            room.RowNumber = request.RowNumber;
            room.ColumnNumber = request.ColumnNumber;
            room.CinemasId = request.CinemasId;
            var currentSeats = _context.Seat
                .Where(s => s.RoomID == room.ID)
                .ToList();

            var seatsToAdd = new List<Seat>();
            var seatsToRemove = new List<Seat>();

            for (int row = 1; row <= request.RowNumber; row++)
            {
                char rowLetter = (char)('A' + row - 1);
                for (int column = 1; column <= request.ColumnNumber; column++)
                {
                    string seatNumber = $"{rowLetter}{column}";
                    var existingSeat = currentSeats.FirstOrDefault(s => s.SeatNumber == seatNumber);
                    if (existingSeat == null)
                    {

                        var seatTypeId = Guid.Parse("8FB86C77-213F-4316-8A7A-43FEE795514E");
                        if (row >= 5 && row <= 10)
                        {
                            seatTypeId = Guid.Parse("0CE08FD6-0D1D-4C61-8B8B-7827BAFF7FE1");
                        }
                        else if (row == request.RowNumber)
                        {
                            seatTypeId = Guid.Parse("587FF198-12D1-4EB4-9CE7-909DA4AF6BCB");
                        }

                        var newSeat = new Seat
                        {
                            ID = Guid.NewGuid(),
                            SeatNumber = seatNumber,
                            Row = row.ToString(),
                            Column = column.ToString(),
                            Status = seatEnum.Available,
                            RoomID = room.ID,
                            SeatTypeID = seatTypeId
                        };
                        seatsToAdd.Add(newSeat);
                    }
                }
            }

            // Loại bỏ ghế nằm ngoài giới hạn mới
            foreach (var existingSeat in currentSeats)
            {
                char rowLetter = existingSeat.Row[0];
                int row = rowLetter - 'A' + 1; // Chuyển chữ cái thành số
                int column = int.Parse(existingSeat.Column);

                if (row > request.RowNumber || column > request.ColumnNumber)
                {
                    seatsToRemove.Add(existingSeat);
                }
            }

            // Thêm và xóa ghế
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


        public async Task<List<SeatDTO>> GetSeatsByRoomId(Guid roomId, CancellationToken cancellationToken)
        {
            if (roomId == Guid.Empty)
            {
                return new List<SeatDTO>();
            }


            var seats = await _context.Seat
                .Where(seat => seat.RoomID == roomId)
                .Select(seat => new SeatDTO
                {
                    ID = seat.ID,
                    SeatNumber = seat.SeatNumber,
                    Row = seat.Row,
                    Column = seat.Column,
                    Status = seat.Status,
                    RoomID = seat.RoomID,
                    SeatTypeID = seat.SeatTypeID,
                    SeatTypeName = seat.SeatTypes != null ? seat.SeatTypes.SeatTypeName : "N/A"
                })
                .ToListAsync(cancellationToken);
            return seats ?? new List<SeatDTO>();
        }
    }
}


