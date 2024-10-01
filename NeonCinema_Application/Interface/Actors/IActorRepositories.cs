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
        public  Task<List<ActorDTO>> GetAllActor( CancellationToken cancellationToken);
        public Task<ActorDTO> GetActorById(Guid id, CancellationToken cancellationToken);
        public Task<ActorDTO> CreateActor(CreateActorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateActor(Guid id, UpdateActorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteActor(DeleteActorRequest request, CancellationToken cancellationToken);
        
    }
}
