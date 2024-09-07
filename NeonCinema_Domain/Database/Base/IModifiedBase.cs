using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Base
{
    public interface IModifiedBase
    {
        public DateTimeOffset? ModifiedTime { get; set; }

        public Guid? ModifiedBy { get; set; }
    }
}
