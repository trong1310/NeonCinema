using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.WorkShift
{
    public class WorkShiftViewRequets
    {
       
        public DateTime WorkDate { get; set; }
        public DateTime TimeStar { get; set; }
        public DateTime TimeEnd { get; set; }
       
    }
}
