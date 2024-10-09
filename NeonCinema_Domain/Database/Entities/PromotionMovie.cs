using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class PromotionMovie
    {
        public Guid ID { get; set; }  // Khóa chính
        public Guid PromotionID { get; set; }  // Khóa ngoại đến Promotion
        public Guid MovieID { get; set; }  // Khóa ngoại đến Movies

        // Liên kết
        public virtual Promotion? Promotion { get; set; }
        public virtual Movies? Movies { get; set; }
    }
}
