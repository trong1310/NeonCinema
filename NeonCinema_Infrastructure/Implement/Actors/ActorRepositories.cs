using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Infrastructure.Database.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Implement.Actors
{
    public class ActorRepositories : IActorRepositories
    {
        NeonCinemasContext _context;
        IMapper _map;
        public ActorRepositories(IMapper map)
        {
            _map = map;
            _context = new NeonCinemasContext();
        }
        public Task<HttpResponseMessage> CreateActor(Actor actor, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> DeleteActor(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ActorDTO> GetActorByID(Guid id, CancellationToken cancellationToken)
        {
           var actor =await _context.Actors.FirstAsync(x=>x.ID == id);
            return _map.Map<ActorDTO>(actor);
        }

        public async Task<List<ActorDTO>> GetAllActor(CancellationToken cancellationToken)
        {
           var actor = await _context.Actors.ToListAsync(cancellationToken);
            return _map.Map<List<ActorDTO>>(actor);
        }

        public Task<HttpResponseMessage> UpdateActor(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
