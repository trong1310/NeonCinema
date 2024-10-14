﻿using NeonCinema_Application.DataTransferObject.Actors;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.DataTransferObject.MovieData;

namespace NeonCinema_Client.Data.IServices.User
{
    public interface IUserServices
    {
        public Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken);
        //  public Task<UserLoginDTO> UserLogin();
        public Task<UserDTO> GetByIDUser(Guid id, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateUser(UserCreateRequest request);

    }
}