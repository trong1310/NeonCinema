using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Language;

namespace NeonCinema_Client.Data.IServices.Actor
{
    public interface IActorService
    {
        Task<List<ActorDTO>> GetAllActor();
        Task<ActorDTO> GetByIdActor(Guid id);
        Task CreateActor(CreateActorRequest request);
        Task UpdateActor(Guid id, UpdateActorRequest request);
    }
}
