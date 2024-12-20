using Microsoft.EntityFrameworkCore;
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
        public string Content { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public int? Quantity { get; set; }
		[Precision(18, 3)]
		public decimal TotalPrice { get; set; }

        public virtual ICollection<BillCombo>? BillCombos { get; set; }
    }
}
