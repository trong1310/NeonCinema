using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
		public class ActorMovie : EntityBase
		{
			public Guid ID { get; set; }
			public Guid ActorID { get; set; }
			public Guid MovieID { get; set; }
			public EntityStatus Status { get; set; }
			public virtual Actor? Actors { get; set; }
			public virtual Movies? Movies { get; set; }	
		}
}
