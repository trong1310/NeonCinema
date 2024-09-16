using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Screenings
{
    public class ScreeningDeleteRequest
    {
        public Guid ScreeningID { get; set; }
        public Guid DeleteBy { get; set; }
    }
}
