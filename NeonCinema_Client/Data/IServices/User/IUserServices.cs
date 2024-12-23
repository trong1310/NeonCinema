
using NeonCinema_API.Controllers;
using NeonCinema_Application.DataTransferObject.Movie;
using NeonCinema_Application.DataTransferObject.User;
using NeonCinema_Application.DataTransferObject.User.Request;
using NeonCinema_Application.Pagination;
using NeonCinema_Client.DataTransferObject.MovieData;
using NeonCinema_Domain.Database.Entities;
using static NeonCinema_Client.Pages.Client.User.Profile;

namespace NeonCinema_Client.Data.IServices.User
{
    public interface IUserServices
    {
        public Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken);
        //  public Task<UserLoginDTO> UserLogin();
        public Task<UserDTO> GetByIDUser(Guid id, CancellationToken cancellationToken);
        public Task<Users> UserDetails();
        public Task<HttpResponseMessage> CreateUser(UserCreateRequest request);
        public Task<HttpResponseMessage> CreateClient(UserCreateRequest request);
        public Task<HttpResponseMessage> ForgotPass(Forgotpass request);
        public Task<HttpResponseMessage> ChangerPass(ClientChangerPass request);
        public Task<HttpResponseMessage> CheckPass(CheckPass request);
        public Task<List<Bill>> ClientCheckTicket(CancellationToken cancellationToken);
        
        public Task UpdateState(UpdateStateAccountRequestModels request);
    }
}