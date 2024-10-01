using NeonCinema_Application.DataTransferObject.Room;
using NeonCinema_Application.Interface.Room;
using NeonCinema_Client.Data.IServices.IRoom;

namespace NeonCinema_Client.Data.Services.Room
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public async Task<HttpResponseMessage> CreateRoomm(RoomCreateRequest request, CancellationToken cancellationToken)
        {
            return await _roomRepository.CreateRoom(request, cancellationToken);
        }

        public async Task<List<RoomDTO>> GettAllRooms(CancellationToken cancellationToken)
        {
            return await _roomRepository.GetAllRooms(cancellationToken);
        }

        public async Task<RoomDTO> GetRoomByyId(Guid id, CancellationToken cancellationToken)
        {
            return await _roomRepository.GetByIDRoom(id, cancellationToken);
        }

        public async Task<HttpResponseMessage> UpdateRoomm(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken)
        {
            return await _roomRepository.UpdateRoom(id, request, cancellationToken);
        }
    }
}
