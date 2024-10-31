using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Enum
{
	public enum PromotionStatus
	{		
		Private = 1,
		Public = 2,
		Expired = 3,
		NotYetApplied = 4,

		//
		Unused = 5,
		Used = 6,
	}
}
