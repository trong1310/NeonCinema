using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Point
{
    public class DeletePointRequest
    {
        public Guid ID { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
