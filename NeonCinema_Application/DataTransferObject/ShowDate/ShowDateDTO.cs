using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowDate
{
    public class ShowDateDTO
    {
        public Guid ID { get; set; }
        public DateTime StarDate { get; set; }
        public EntityStatus Status { get; set; }
    }
}
