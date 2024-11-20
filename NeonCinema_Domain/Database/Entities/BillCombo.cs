using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class BillCombo :EntityBase
	{

		public Guid BillID { get; set; }
		public virtual Bill? Bill { get; set; }

		public Guid FoodComboID { get; set; }
		public virtual FoodCombo? FoodCombo { get; set; }

		public int Quantity { get; set; } // Số lượng của FoodCombo trong hóa đơn

	}
}
