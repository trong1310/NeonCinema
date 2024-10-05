﻿using Microsoft.EntityFrameworkCore;
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

       

        public async Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken)
        {
            var rooms = await _context.Room
            .Select(room => new RoomDTO
            {
                ID = room.ID,
                Name = room.Name,
                SeatingCapacity = room.SeatingCapacity,
                Status = room.Status
            })
            .ToListAsync(cancellationToken);

            return rooms;
        }

        public async Task<RoomDTO> GetByIDRoom(Guid id, CancellationToken cancellationToken)
        {
            var room = await _context.Room
                .Where(r => r.ID == id)
                .Select(room => new RoomDTO
                {
                    ID = room.ID,
                    Name = room.Name,
                    SeatingCapacity = room.SeatingCapacity,
                    Status = room.Status
                })
                .FirstOrDefaultAsync(cancellationToken);

            return room ?? throw new KeyNotFoundException("Room not found");
        }

        public async Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            var room = await _context.Room.FirstOrDefaultAsync(r => r.ID == id, cancellationToken);

            if (room == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            room.Name = request.Name;
            room.SeatingCapacity = request.SeatingCapacity;
            room.Status = request.Status;

            _context.Room.Update(room);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

    }
}
