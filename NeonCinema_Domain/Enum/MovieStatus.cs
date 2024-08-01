using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Enum
{
    public enum MovieStatus
    {
        Active = 0, 
        PendingForApproval = 1,
        InActive = 2,
        StopShowing = 3,
    }
}
