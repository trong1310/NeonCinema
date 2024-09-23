using NeonCinema_Application.DataTransferObject.User;

namespace NeonCinema_Client.IServices.User
{
    public interface IUserServices
    {
        public Task<List<UserDTO>> GetAllUser(CancellationToken cancellationToken);
      //  public Task<UserLoginDTO> UserLogin();
        public Task<UserDTO> GetByIDUser(string phoneNumber, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> CreateUser(UserCreateRequest request, CancellationToken cancellationToken);
        public Task<HttpResponseMessage> UpdateUser(Guid id, UserUpdateRequest request, CancellationToken cancellationToken);
    }
}
