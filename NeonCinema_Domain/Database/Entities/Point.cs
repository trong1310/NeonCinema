using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Point : EntityBase
    {
        public Guid ID { get; set; }
        public int TotalPoint   { get; set; }
        public DateTime DateEarned { get; set; }
        public Guid UserID { get; set; }

        //
        public virtual Users? Users { get; set; }


    }
}
