using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.Interface.Utilities
{
    public interface IReCapchaRepositories
    {
        public Task<bool> VerifyToken (string token);
    }
}
