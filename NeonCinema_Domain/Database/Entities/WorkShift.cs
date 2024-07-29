using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class WorkShift : EntityBase
    {
        public Guid WorkShiftID { get; set; }
        public DateTime WorkDate { get; set; }
        public DateTime TimeStar { get; set; }
        public DateTime TimeEnd { get; set; }
        public EntityStatus Status { get; set; }
        public Guid EmployeesID { get; set; }
        public virtual Employees? Employees { get; set; }
        public virtual ICollection<ShiftChange>? ShiftChanges { get; set; }
    }
}
