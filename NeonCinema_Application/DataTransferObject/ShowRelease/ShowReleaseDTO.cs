using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowRelease
{
    public class ShowReleaseDTO
    {
        public Guid ID { get; set; }
        public Guid MovieID { get; set; }
        public Guid RoomID { get; set; }
        public DateTime TimeRelease { get; set; }
        public DateTime DateRelease { get; set; }
        public EntityStatus Status { get; set; }
    }
}
