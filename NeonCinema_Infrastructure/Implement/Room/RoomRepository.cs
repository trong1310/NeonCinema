using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Room;
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
            // Thêm yêu cầu phòng vào DbContext
            var roomEntity = new NeonCinema_Domain.Database.Entities.Room // Use the Room entity class here
            {
                ID = Guid.NewGuid(),
                Name = request.Name,
                SeatingCapacity = request.SeatingCapacity,
                Status = request.Status, // Assuming you want to set the status as well
                CinemasID = request.CinemasID,
            };

            _context.Room.Add(roomEntity); // Add the Room entity to the DbSet

            // Save changes to the database
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created)
            {
                Content = new StringContent("Room created successfully.")
            };
        }

        //public async Task<List<RoomDTO>> GetAllRoom(CancellationToken cancellationToken)
        //{
        //    // Lấy tất cả các phòng từ cơ sở dữ liệu và chuyển đổi chúng thành RoomDTO
        //    var rooms = await _context.Room
        //        .AsNoTracking() // Không theo dõi thay đổi để tối ưu hóa hiệu suất
        //        .Select(room => new RoomDTO
        //        {
        //            ID = room.ID,
        //            Name = room.Name,
        //            SeatingCapacity = room.SeatingCapacity,
        //            Status = room.Status
        //            // Thêm các thuộc tính khác cần thiết từ Room sang RoomDTO
        //        })
        //        .ToListAsync(cancellationToken); // Chuyển đổi sang danh sách

        //    return rooms; // Trả về danh sách các phòng
        //}

        public async Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken)
        {
                var rooms = await _context.Room
             .AsNoTracking()
             .Select(room => new RoomDTO
             {
                 ID = room.ID,
                 Name = room.Name,
                 SeatingCapacity = room.SeatingCapacity,
                 Status = room.Status // Lấy giá trị Status từ cơ sở dữ liệu
             })
             .ToListAsync(cancellationToken);

                return rooms;
        }

        public async Task<RoomDTO> GetByIDRoom(Guid id, CancellationToken cancellationToken)
        {
            // Tìm phòng theo ID
            var room = await _context.Room
                .AsNoTracking()
                .FirstOrDefaultAsync(r => r.ID == id, cancellationToken); // Tìm phòng

            if (room == null) // Nếu không tìm thấy phòng
            {
                throw new KeyNotFoundException("Room not found."); // Ném ra ngoại lệ
            }

            // Chuyển đổi phòng sang RoomDTO và trả về
            return new RoomDTO
            {
                ID = room.ID,
                Name = room.Name,
                SeatingCapacity = room.SeatingCapacity,
                Status= room.Status
                // Thêm các thuộc tính khác cần thiết từ Room sang RoomDTO
            };
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            var room = await _context.Room.FirstOrDefaultAsync(r => r.ID == id, cancellationToken);
            if (room == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Room not found.")
                };
            }

            room.Name = request.Name;
            room.SeatingCapacity = request.SeatingCapacity;
            room.Status =request.Status;
            

            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("Room updated successfully.")
            };
        }

    }
}
