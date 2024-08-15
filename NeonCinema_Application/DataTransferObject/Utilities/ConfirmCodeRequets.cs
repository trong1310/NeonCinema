
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Utilities
{
    public class ConfirmCodeRequets
    {
        public Guid Id { get; set; }
        public string? Code { get; set; }
    }
}
