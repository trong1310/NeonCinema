using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Base
{
    public interface ICreateBase
    {
        public DateTimeOffset? CreatedTime { get; set; }

        public Guid? CreatedBy { get; set; }
    }
}
