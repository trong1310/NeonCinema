using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Base
{
    public class EntityBase : ICreateBase , IDeleteBase ,IModifiedBase
    {
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset? ModifiedTime { get; set; }
        public Guid? ModifiedBy { get; set; }
      
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset? DeletedTime { get; set; }
        public DateTime? CreatedTime { get; set; }
        
    }
}
