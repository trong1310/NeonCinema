using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class PendingPoint : EntityBase
	{
		public Guid ID { get; set; }
		public Guid UserID { get; set; }
		public Guid BillID { get; set; }
		public double Point {  get; set; }
		public DateTime ApplyDate { get; set; }
		public bool State {  get; set; } = false;

		public virtual Users? User { get; set; }
		public virtual Bill? Bill { get; set; }
	}
}
