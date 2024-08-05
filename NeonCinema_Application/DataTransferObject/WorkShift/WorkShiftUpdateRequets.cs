using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.WorkShift
{
    public class WorkShiftUpdateRequets
    {
        public Guid WorkShiftID { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime TimeStar { get; set; }
        public DateTime TimeEnd { get; set; }
        public EntityStatus Status { get; set; }
        public Guid EmployeesID { get; set; }
    }
}
