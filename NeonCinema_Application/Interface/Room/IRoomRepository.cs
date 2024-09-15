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
        public Task<List<RoomDTO>> GetAllRoom(CancellationToken cancellationToken);
        public Task<RoomDTO> GetByIDRoom(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateRoom(RoomCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateRoom(Guid id, RoomUpdateRequest request, CancellationToken cancellationToken);
    }
}
