using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Surcharges
    {
        public Guid surchargeID {  get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public EntityStatus status { get; set; }
        public virtual Ticket  Ticket {  get; set; } 
    }
}
