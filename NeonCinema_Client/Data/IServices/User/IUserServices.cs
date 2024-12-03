﻿
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.DataTransferObject.User.Request;
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
        public Task<HttpResponseMessage> CreateClient(UserCreateRequest request);
        public Task<HttpResponseMessage> ForgotPass(Forgotpass request);
    }
}