using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class FoodCombo : EntityBase
    {
        public Guid ID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public virtual ICollection<Bill>? Bills { get; set; }
    }
}
