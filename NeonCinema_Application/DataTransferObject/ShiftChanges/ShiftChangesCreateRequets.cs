using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ShiftChanges
{
    public class ShiftChangesCreateRequets
    {
        public Guid ShiftChangeID { get; set; }
        public string ShiftName { get; set; }
        public string NewShift { get; set; }
        public DateTime RequetDate { get; set; }
        public EntityStatus Status { get; set; }
        public Guid WorkShiftID { get; set; }
    }
}
