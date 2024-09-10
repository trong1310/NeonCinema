using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Actors
{
    public interface IActorRepositories
    {
        public  Task<List<ActorDTO>> GetAllActor(CancellationToken cancellationToken);
        public  Task<ActorDTO> GetActorByID(Guid id,CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateActor(Actor actor, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateActor(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteActor(Guid id, CancellationToken cancellationToken);
        
    }
}
