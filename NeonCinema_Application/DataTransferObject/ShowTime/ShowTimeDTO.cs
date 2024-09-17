using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowTime
{
    public class ShowTimeDTO
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public EntityStatus Status { get; set; }
    }
}
