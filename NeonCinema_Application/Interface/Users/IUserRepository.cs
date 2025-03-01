﻿
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.DataTransferObject.User.Request;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
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
        public Task<UserDTO> GetByIDUser(Guid id, CancellationToken cancellationToken);
        public Task<CreateClientResponse> CreateUser(UserCreateRequest request, CancellationToken cancellationToken);
        public Task<CreateClientResponse> CreateClient(UserCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateUser(UserUpdateRequest request, CancellationToken cancellationToken);

    }
}
