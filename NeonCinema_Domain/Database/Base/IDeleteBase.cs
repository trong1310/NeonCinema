using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Base
{
    public interface IDeleteBase
    {
      

        public Guid? DeletedBy { get; set; }

        public DateTimeOffset? DeletedTime { get; set; }
    }
}
