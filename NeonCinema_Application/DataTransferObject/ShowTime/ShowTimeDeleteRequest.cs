using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShowTime
{
    public class ShowTimeDeleteRequest
    {
        public Guid ID { get; set; }
        public Guid DeleteBy { get; set; }
    }
}
