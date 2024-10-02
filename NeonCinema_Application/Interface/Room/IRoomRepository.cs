using NeonCinema_Application.DataTransferObject.Countrys;
using NeonCinema_Application.DataTransferObject.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Room
{
    public interface IRoomRepository
    {
        Task<List<RoomDTO>> GetAllRooms(CancellationToken cancellationToken);
        Task<RoomDTO> GetByIDRoom(Guid id, CancellationToken cancellationToken);
        Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request, CancellationToken cancellationToken);
        Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken);
    }

}
