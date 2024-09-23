using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ScreeningDeleteRequest
    {
        public Guid ID { get; set; }
        public EntityStatus Status { get; set; }
        public Guid ShowTimeID { get; set; }
        public Guid ShowDateID { get; set; }
        public Guid MovieID { get; set; }
        public Guid RoomID { get; set; }
    }
}
