using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
    public class LogginResponseDTO
    {
        public Users User { get; set; }
        public string Token { get; set; }
    }
}
