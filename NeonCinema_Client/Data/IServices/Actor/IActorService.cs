using NeonCinema_API.Controllers.Service;
using NeonCinema_Application.DataTransferObject.Directors;

namespace NeonCinema_Client.Data.IServices.Actor
{
    public interface IActorService
    {
        Task<List<ActorResponse>> GetAllActor();
        Task<ActorResponse> GetByIdActor(Guid id);
        Task CreateActor(ActorCreateRequest request);
        Task UpdateActor(UpdateActorRequests request);
    }
}
