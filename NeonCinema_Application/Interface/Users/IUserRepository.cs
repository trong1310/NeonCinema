using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Users
{
    public interface IUserRepository
    {
        
        public Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken);
        public Task<UserDTO> GetByIDUser(string phoneNumber, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateUser(UserCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateUser(Guid id, UserUpdateRequest request, CancellationToken cancellationToken);
        
    }
}
