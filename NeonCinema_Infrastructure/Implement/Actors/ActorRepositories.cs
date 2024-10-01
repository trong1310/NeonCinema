using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Actors
{
    public class ActorRepositories : IActorRepositories
    {
        private readonly NeonCinemasContext _context;

        public ActorRepositories(NeonCinemasContext context)
        {
            _context = context;
        }

        public async Task<ActorDTO> CreateActor(CreateActorRequest request, CancellationToken cancellationToken)
        {
            var actor = new Actor
            {
                ID = Guid.NewGuid(), // Generate a new ID
                FullName = request.FullName,
                Gender = request.Gender,
                BirthDate = request.BirthDate,
                Address = request.Address,
                Nationality = request.Nationality,
                Biography = request.Biography,
                Images = request.Images,
                Status = EntityStatus.Active // Example status
            };

            // Add the actor to the context and save changes
            await _context.Actors.AddAsync(actor, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            // Manually map the Actor entity to ActorDTO
            var actorDTO = new ActorDTO
            {
                ID = actor.ID,
                FullName = actor.FullName,
                Gender = actor.Gender,
                BirthDate = actor.BirthDate,
                Address = actor.Address,
                Nationality = actor.Nationality,
                Biography = actor.Biography,
                Images = actor.Images,
                Status = actor.Status
            };

            return actorDTO; // Return the manually mapped ActorDTO
        }

        public Task<HttpResponseMessage> DeleteActor(DeleteActorRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ActorDTO> GetActorById(Guid id, CancellationToken cancellationToken)
        {
            var actor = await _context.Actors.FindAsync(new object[] { id }, cancellationToken);
            if (actor == null)
            {
                return null;
            }

            // Manually map the Actor entity to ActorDTO
            var actorDTO = new ActorDTO
            {
                ID = actor.ID,
                FullName = actor.FullName,
                Gender = actor.Gender,
                BirthDate = actor.BirthDate,
                Address = actor.Address,
                Nationality = actor.Nationality,
                Biography = actor.Biography,
                Images = actor.Images,
                Status = actor.Status
            };

            return actorDTO;
        }

        public async Task<List<ActorDTO>> GetAllActor(CancellationToken cancellationToken)
        {
            var actors = await _context.Actors.ToListAsync(cancellationToken);

            // Manually map the list of Actor entities to a list of ActorDTOs
            var actorDTOs = actors.Select(actor => new ActorDTO
            {
                ID = actor.ID,
                FullName = actor.FullName,
                Gender = actor.Gender,
                BirthDate = actor.BirthDate,
                Address = actor.Address,
                Nationality = actor.Nationality,
                Biography = actor.Biography,
                Images = actor.Images,
                Status = actor.Status
            }).ToList();

            return actorDTOs;
        }

        public async Task<HttpResponseMessage> UpdateActor(Guid id, UpdateActorRequest request, CancellationToken cancellationToken)
        {
            var actor = await _context.Actors.FindAsync(new object[] { id }, cancellationToken);
            if (actor == null)
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.NotFound)
                {
                    Content = new StringContent("Actor not found.")
                };
            }

            // Update the properties
            actor.FullName = request.FullName;
            actor.Gender = request.Gender;
            actor.BirthDate = request.BirthDate;
            actor.Address = request.Address;
            actor.Nationality = request.Nationality;
            actor.Biography = request.Biography;
            actor.Images = request.Images;
            actor.Status = request.Status;

            await _context.SaveChangesAsync(cancellationToken);
            return new HttpResponseMessage(System.Net.HttpStatusCode.OK)
            {
                Content = new StringContent("Actor updated successfully.")
            };
        }
    }
}
