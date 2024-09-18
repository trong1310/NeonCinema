using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Point
{
    public class CreatePointRequest
    {
        public Guid ID { get; set; }
        public int TotalPoint { get; set; }
        public DateTime DateEarned { get; set; }
        public Guid UserID { get; set; }
    }
}
