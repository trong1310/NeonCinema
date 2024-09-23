using NeonCinema_Application.DataTransferObject.User;

namespace NeonCinema_Client.IServices.LoginServices
{
    public interface ILoginServices
    {
        public Task<UserLoginDTO> UserLogin();
    }
}
