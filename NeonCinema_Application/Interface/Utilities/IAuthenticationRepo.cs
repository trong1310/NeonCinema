using NeonCinema_Application.DataTransferObject.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Utilities
{
   public interface  IAuthenticationRepo
    {
        bool IsUniqueUser(string username);
        //Task<LogginResponseDTO> GetLogginAsync(LogginResponseDTO logginResponseDTO);
    }
}
