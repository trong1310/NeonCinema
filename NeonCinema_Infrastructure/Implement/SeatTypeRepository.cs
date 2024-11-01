using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.MovieTypes;
using NeonCinema_Application.DataTransferObject.SeatTypes;
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

        public async Task<List<SeatTypeDTO>> GetAllAsync(CancellationToken cancellationToken)
        {
            var st = await _context.SeatTypes.ToListAsync(cancellationToken);

            // Manually map the list of Actor entities to a list of ActorDTOs
            var stdto = st.Select(stt => new SeatTypeDTO
            {
                ID = stt.ID,
                SeatTypeName = stt.SeatTypeName,
                //Price = stt.Price,

            }).ToList();

            return stdto;
        }

        public async Task<SeatType> GetByIdAsync(Guid id)
        {
            return await _context.SeatTypes.FindAsync(id);
        }

        public async Task<HttpResponseMessage> UpdateSeatType(Guid id, UpdateSeatTypeDTO request, CancellationToken cancellationToken)
        {
            // Retrieve the existing seat type by ID
            var seatType = await _context.SeatTypes.FindAsync(new object[] { id }, cancellationToken);

            // Check if the seat type exists
            if (seatType == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Seat type type not found.")
                };
            }

            // Update properties
            seatType.SeatTypeName = request.SeatTypeName;
            //seatType.Price = request.Price;

            // Save changes to the database
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("Seat type updated successfully.")
            };
        }
    }
}
