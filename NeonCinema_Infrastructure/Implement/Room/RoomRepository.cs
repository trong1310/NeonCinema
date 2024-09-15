using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            // Kiểm tra nếu tên phòng đã tồn tại trong cùng một rạp
            var existingRoom = await _context.Room
                .Where(r => r.Name == request.Name && r.CinemasID == request.CinemasID)
                .FirstOrDefaultAsync(cancellationToken);

            if (existingRoom != null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent($"Room with name '{request.Name}' already exists in the cinema.")
                };
            }

            // Validate SeatingCapacity
            if (request.SeatingCapacity <= 50 || request.SeatingCapacity >= 1000)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Seating capacity must be between 50 and 1000.")
                };
            }

            // Tạo và thêm phòng mới
            var newRoom = new NeonCinema_Domain.Database.Entities.Room
            {
                ID = request.ID != Guid.Empty ? request.ID : Guid.NewGuid(),
                Name = request.Name,
                SeatingCapacity = request.SeatingCapacity,
                CinemasID = request.CinemasID // Add CinemasID
            };

            _context.Room.Add(newRoom);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Room created successfully.")
            };

        }

        public async Task<List<RoomDTO>> GetAllRoom(CancellationToken cancellationToken)
        {
            var rooms = await _context.Room
               .Select(r => new RoomDTO
               {
                   ID = r.ID,
                   Name = r.Name,
                   SeatingCapacity = r.SeatingCapacity,
                   CinemasID = r.CinemasID
               })
               .ToListAsync(cancellationToken);

            return rooms;
        }

        public async Task<RoomDTO> GetByIDRoom(Guid id, CancellationToken cancellationToken)
        {
            var room = await _context.Room
                .Where(r => r.ID == id)
                .Select(r => new RoomDTO
                {
                    ID = r.ID,
                    Name = r.Name,
                    SeatingCapacity = r.SeatingCapacity,
                    CinemasID = r.CinemasID
                })
                .FirstOrDefaultAsync(cancellationToken);

            if (room == null)
            {
                throw new KeyNotFoundException("Room not found.");
            }

            return room;
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            // Kiểm tra xem phòng có tồn tại không
            var existingRoom = await _context.Room
                .FirstOrDefaultAsync(r => r.ID == id, cancellationToken);

            if (existingRoom == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Room not found.")
                };
            }

            // Kiểm tra tên phòng có bị trùng không trong cùng rạp
            var duplicateRoom = await _context.Room
                .Where(r => r.Name == request.Name && r.CinemasID == request.CinemasID && r.ID != id)
                .FirstOrDefaultAsync(cancellationToken);

            if (duplicateRoom != null)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent($"Room with name '{request.Name}' already exists in the cinema.")
                };
            }

            // Validate SeatingCapacity
            if (request.SeatingCapacity <= 50 || request.SeatingCapacity >= 1000)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("Seating capacity must be between 50 and 1000.")
                };
            }

            // Cập nhật thông tin phòng
            existingRoom.Name = request.Name;
            existingRoom.SeatingCapacity = request.SeatingCapacity;
            existingRoom.CinemasID = request.CinemasID;

            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Room updated successfully.")
            };
        }
    }
}
