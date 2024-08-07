using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screenings
{
    public class ScreeningDTO
    {
        public DateTime StarTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
        public DateTime ScreeningDate { get; set; }
        public Guid MovieID { get; set; }
        public Guid RoomID { get; set; }
    }
}
