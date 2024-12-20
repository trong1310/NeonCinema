using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.FoodCombos
{
	public class FoodComboCreateRequest
	{
		public string? Content { get; set; }
		public string? Description { get; set; }
		public string? Images { get; set; }
		public decimal? TotalPrice { get; set; }
	}
}
