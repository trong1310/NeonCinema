using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Roles : EntityBase
    {
        public Guid ID { get; set; }// Admin = 1; Nhân Viên = 2, khách hàng = 3
        public string RoleName { get; set; }
        public EntityStatus Status { get; set; }

        public virtual ICollection<Users>? Users { get; set; }

    }
}
