using NeonCinema_Application.DataTransferObject.Cinemas;
using NeonCinema_Application.Interface.Cinemas;
using NeonCinema_Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Cinemas
{
    public class CinemasRepository : ICinemasRepository
    {
        private readonly NeonCinemasContext _context;
        public CinemasRepository(NeonCinemasContext ct)
        {
            _context = ct;
        }
        public async Task<HttpResponseMessage> CreateCinemas(CinemasCreateRequest request, CancellationToken cancellationToken)
        {
            // Validate fields
            if (string.IsNullOrWhiteSpace(request.Name) ||
                string.IsNullOrWhiteSpace(request.Location) ||
                string.IsNullOrWhiteSpace(request.PhoneNumber) ||
                string.IsNullOrWhiteSpace(request.WebSite) ||
                string.IsNullOrWhiteSpace(request.OpeningHours) ||
                string.IsNullOrWhiteSpace(request.ClosingHours) ||
                request.RoomNumber <= 0
                )
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("All fields must be filled correctly.")
                };
            }

            var cinema = new NeonCinema_Domain.Database.Entities. Cinemas
            {
                ID = Guid.NewGuid(),
                Name = request.Name,
                Location = request.Location,
                PhoneNumber = request.PhoneNumber,
                WebSite = request.WebSite,
                OpeningHours = request.OpeningHours,
                ClosingHours = request.ClosingHours,
                RoomNumber = request.RoomNumber,
                CinemasTypeID = request.CinemasTypeID
            };

            _context.Cinema.Add(cinema);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }

        public async Task<List<CinemasDTO>> GetAllCinemas(CancellationToken cancellationToken)
        {
            var cinemas = await _context.Cinema
                .Select(c => new CinemasDTO
                {
                    ID = c.ID,
                    Name = c.Name,
                    Location = c.Location,
                    PhoneNumber = c.PhoneNumber,
                    WebSite = c.WebSite,
                    OpeningHours = c.OpeningHours,
                    ClosingHours = c.ClosingHours,
                    RoomNumber = c.RoomNumber,
                    CinemasTypeID = c.CinemasTypeID
                })
                .ToListAsync(cancellationToken);

            return cinemas;
        }

        public async Task<CinemasDTO> GetByIDRCinemas(Guid id, CancellationToken cancellationToken)
        {
            var cinema = await _context.Cinema
               .Where(c => c.ID == id)
               .Select(c => new CinemasDTO
               {
                   ID = c.ID,
                   Name = c.Name,
                   Location = c.Location,
                   PhoneNumber = c.PhoneNumber,
                   WebSite = c.WebSite,
                   OpeningHours = c.OpeningHours,
                   ClosingHours = c.ClosingHours,
                   RoomNumber = c.RoomNumber,
                   CinemasTypeID = c.CinemasTypeID
               })
               .FirstOrDefaultAsync(cancellationToken);

            return cinema;
        }

        public async Task<HttpResponseMessage> UpdateCinemas(Guid id, CinemasUpdateRequest request, CancellationToken cancellationToken)
        {
            var cinema = await _context.Cinema.FindAsync(new object[] { id }, cancellationToken);

            if (cinema == null)
            {
                return new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Cinema not found.")
                };
            }

            // Validate fields
            if (string.IsNullOrWhiteSpace(request.Name) ||
                string.IsNullOrWhiteSpace(request.Location) ||
                string.IsNullOrWhiteSpace(request.PhoneNumber) ||
                string.IsNullOrWhiteSpace(request.WebSite) ||
                string.IsNullOrWhiteSpace(request.OpeningHours) ||
                string.IsNullOrWhiteSpace(request.ClosingHours) ||
                request.RoomNumber <= 0 
                )
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    Content = new StringContent("All fields must be filled correctly.")
                };
            }

            cinema.Name = request.Name;
            cinema.Location = request.Location;
            cinema.PhoneNumber = request.PhoneNumber;
            cinema.WebSite = request.WebSite;
            cinema.OpeningHours = request.OpeningHours;
            cinema.ClosingHours = request.ClosingHours;
            cinema.RoomNumber = request.RoomNumber;
            cinema.CinemasTypeID = request.CinemasTypeID;

            _context.Cinema.Update(cinema);
            await _context.SaveChangesAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
