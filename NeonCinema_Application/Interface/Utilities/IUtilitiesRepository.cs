using NeonCinema_Application.DataTransferObject.Utilities;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Utilities
{
    public interface IUtilitiesRepository
    {
        Task<HttpResponseMessage> ChangePassword(ChangePasswordRequets requets, CancellationToken cancellationToken);

        Task<HttpResponseMessage> ForgotPassWord(ForgotPassWordRequets requets, CancellationToken cancellationToken);
        Task<bool> ConFirmCode(ConfirmCodeRequets requets, CancellationToken cancellationToken);
        Task<bool> SendMail(SendMaillRequest request,string token);
        Task<string> ResetPassWord(ForgotPassWordRequets requets, CancellationToken cancellationToken);

    }
}
