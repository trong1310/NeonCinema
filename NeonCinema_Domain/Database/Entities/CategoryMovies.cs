using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
	public class CategoryMovies : EntityBase
	{
		public Guid ID { get; set; }
		public Guid MovieID { get; set; }
		public Guid MovieTypeID { get; set; }
		public EntityStatus Status { get; set; }
		public virtual  Movies? Movies { get; set; }
		public virtual MovieType? MovieType { get; set; }	
	}
}
