using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Directors;
using NeonCinema_Application.Interface.Directors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Directors
{
    public class DirectorRepositories : IDirectorRepositories
    {
        private readonly IMapper _map;
        private readonly NeonCinemasContext _context;
        public DirectorRepositories(NeonCinemasContext context,IMapper map)
        {
            _context = context;
            _map = map;
        }
        public async Task<DirectorDTO> CreateDirector(CreateDirectorRequest director, CancellationToken cancellationToken)
        {
            var directo = new Director
            {
                ID = Guid.NewGuid(), // Generate a new unique ID for the director
                FullName = director.FullName,
                Gender = director.Gender,
                BirthDate = director.BirthDate,
                Address = director.Address,
                Nationality = director.Nationality,
                Biography = director.Biography,
                Images = director.Images,
                Status = director.Status,
               
            };

            // Add the director entity to the context and save changes
            await _context.Directors.AddAsync(directo, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            // Return a DTO representation of the newly created director
            return new DirectorDTO
            {
                ID = director.ID,
                FullName = director.FullName,
                Gender = director.Gender,
                BirthDate = director.BirthDate,
                Address = director.Address,
                Nationality = director.Nationality,
                Biography = director.Biography,
                Images = director.Images,
                Status = director.Status
            };
        }

        public async Task<List<DirectorDTO>> GetAllDirector(CancellationToken cancellationToken)
        {
            var directors =  _context.Directors.AsNoTracking();
            var obj = await directors.ToListAsync();
            return _map.Map<List<DirectorDTO>>(obj);

          
        }

        public async Task<DirectorDTO> GetBiIdDirector(Guid id, CancellationToken cancellationToken)
        {
            var directo = await _context.Directors.FirstOrDefaultAsync(d => d.ID == id, cancellationToken);

            if (directo == null)
            {
                throw new KeyNotFoundException("Director not found");
            }

            // Return a DTO representation of the director
            return new DirectorDTO
            {
                ID = directo.ID,
                FullName = directo.FullName,
                Gender = directo.Gender,
                BirthDate = directo.BirthDate,
                Address = directo.Address,
                Nationality = directo.Nationality,
                Biography = directo.Biography,
                Images = directo.Images,
                Status = directo.Status
            };
        }

        public async Task<HttpRequestMessage> UpdateDirector(Guid id, UpdateDirectorRequest director, CancellationToken cancellationToken)
        {
            var directo = await _context.Directors.FirstOrDefaultAsync(d => d.ID == id, cancellationToken);

            if (director == null)
            {
                throw new KeyNotFoundException("Director not found");
            }

            // Update the director entity's properties
            director.FullName = director.FullName;
            director.Gender = director.Gender;
            director.BirthDate = director.BirthDate;
            director.Address = director.Address;
            director.Nationality = director.Nationality;
            director.Biography = director.Biography;
            director.Images = director.Images;
            director.Status = director.Status;
            

            // Save the updated director back to the database
            await _context.SaveChangesAsync(cancellationToken);

            // Return a confirmation message
            return new HttpRequestMessage
            {
                Content = new StringContent($"Director {directo.FullName} updated successfully.")
            };
        }
    }
}
