using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Domain.Database.Entities;

namespace NeonCinema_Client.Data.IServices.Actor
{
    public interface IActorService
    {
        public Task<List<ActorDTO>> GetAllActor(CancellationToken cancellationToken);
        public Task<ActorDTO> GetActorById(Guid id, CancellationToken cancellationToken);
        public Task<ActorDTO> CreateActor(CreateActorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateActor(Guid id, UpdateActorRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> DeleteActor(DeleteActorRequest request, CancellationToken cancellationToken);
    }
}
