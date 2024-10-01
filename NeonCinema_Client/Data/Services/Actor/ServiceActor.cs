using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.Interface.Actors;
using NeonCinema_Client.Data.IServices.Actor;
using NeonCinema_Domain.Database.Entities;
using AutoMapper;

namespace NeonCinema_Client.Data.Services.Actor
{
    public class ServiceActor : IActorService
    {
        private readonly IActorRepositories _actorRepository;

        public ServiceActor(IActorRepositories actorRepository)
        {
            _actorRepository = actorRepository;
        }

        public async Task<ActorDTO> CreateActor(CreateActorRequest request, CancellationToken cancellationToken)
        {
            return await _actorRepository.CreateActor(request, cancellationToken);
        }

        public Task<HttpResponseMessage> DeleteActor(DeleteActorRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<ActorDTO> GetActorById(Guid id, CancellationToken cancellationToken)
        {
            var actor = await _actorRepository.GetActorById(id, cancellationToken);
            if (actor == null)
            {
                // Nếu không tìm thấy diễn viên, ném ra ngoại lệ hoặc trả về null
                throw new KeyNotFoundException($"Actor with ID {id} not found.");
            }

            return actor; // Trả về ActorDTO
        }

        public async Task<List<ActorDTO>> GetAllActor(CancellationToken cancellationToken)
        {
            var actors = await _actorRepository.GetAllActor(cancellationToken);
            return actors; // Trả về danh sách ActorDTO
        }

        public async Task<HttpResponseMessage> UpdateActor(Guid id, UpdateActorRequest request, CancellationToken cancellationToken)
        {
            var response = await _actorRepository.UpdateActor(id, request, cancellationToken);

            // Kiểm tra mã trạng thái phản hồi
            if (!response.IsSuccessStatusCode)
            {
                // Nếu không thành công, có thể ném ra ngoại lệ hoặc xử lý tùy ý
                throw new HttpRequestException($"Error updating actor: {response.ReasonPhrase}");
            }

            return response; // Trả về HttpResponseMessage
        }
    }
}
