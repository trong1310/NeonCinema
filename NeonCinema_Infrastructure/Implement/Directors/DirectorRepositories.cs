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
        private readonly NeonCinemasContext _context;
        public DirectorRepositories(NeonCinemasContext context)
        {
            _context = context;
        }

        public async Task<DirectorDTO> CreateDirector(CreateDirectorRequest request, CancellationToken cancellationToken)
        {
            var DRT = new Director
            {
                ID = Guid.NewGuid(), 
                FullName = request.FullName,
                Gender = (EntityStatus)request.Gender,
                Address = request.Address,
                Nationality = request.Nationality,
                Biography = request.Biography,
                Status = EntityStatus.Active 
            };

            
            await _context.Directors.AddAsync(DRT, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            
            var directorDTO = new DirectorDTO
            {
                ID = DRT.ID,
                FullName = DRT.FullName,
                Gender = (EntityStatus)DRT.Gender,
                Address = DRT.Address,
                Nationality = DRT.Nationality,
                Biography = DRT.Biography,
                Status = DRT.Status
            };

            return directorDTO;
        }

        public async Task<List<DirectorDTO>> GetAllDirector(CancellationToken cancellationToken)
        {
            var drt = await _context.Directors.Where(x=>x.Status == EntityStatus.Active).ToListAsync(cancellationToken);
            var direcDTOs = drt.Select(drtt => new DirectorDTO
            {
                ID = drtt.ID,
                FullName = drtt.FullName,
                Gender = drtt.Gender,
                Address = drtt.Address,
                Nationality = drtt.Nationality,
                Biography = drtt.Biography,
                Status = drtt.Status
            }).ToList();
            return direcDTOs;
        }

        public async Task<DirectorDTO> GetDirectorById(Guid id, CancellationToken cancellationToken)
        {
            var DRT = await _context.Directors.FindAsync(new object[] { id }, cancellationToken);
            if (DRT == null)
            {
                return null;
            }

            // Manually map the Actor entity to ActorDTO
            var direcDTO = new DirectorDTO
            {
                ID = DRT.ID,
                FullName = DRT.FullName,
                Gender = DRT.Gender,
                Address = DRT.Address,
                Nationality = DRT.Nationality,
                Biography = DRT.Biography,
                Status = DRT.Status
            };

            return direcDTO;
        }

        public async Task<HttpResponseMessage> UpdateDirector(Guid id, UpdateDirectorRequest request, CancellationToken cancellationToken)
        {
            var DRT = await _context.Directors.FindAsync(new object[] { id }, cancellationToken);
            if (DRT == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
                {
                    Content = new StringContent("director not found.")
                };
            }
            DRT.FullName = request.FullName;
            DRT.Gender = request.Gender;
            DRT.Address = request.Address;
            DRT.Nationality = request.Nationality;
            DRT.Biography = request.Biography;
            DRT.Status = request.Status;
            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("director updated successfully.")
            };
        }
    }
}
