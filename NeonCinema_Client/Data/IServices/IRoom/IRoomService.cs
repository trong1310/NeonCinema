using NeonCinema_Application.DataTransferObject.Room;

namespace NeonCinema_Client.Data.IServices.IRoom
{
    public interface IRoomService
    {
        Task<List<RoomDTO>> GettAllRooms(CancellationToken cancellationToken);
        Task<RoomDTO> GetRoomByyId(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> CreateRoomm(RoomCreateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateRoomm(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken);
    }
}
