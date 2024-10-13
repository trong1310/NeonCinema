using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screening
{
    public class ScreeningDTO
    {
        public Guid ID { get; set; }
        public EntityStatus Status { get; set; }
        public Guid ShowTimeID { get; set; }
    
        public DateTime ShowDate { get; set; }
        public Guid MovieID { get; set; }
        public Guid RoomID { get; set; }
    }
}
