using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.FoodCombos
{
    public class FoodComboDTO
    {
        public Guid ID { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string Images { get; set; }
        public decimal Amount { get; set; }
		public string FormattedAmount
		{
			get => Amount.ToString("N0"); // Hiển thị dạng số có dấu phân cách
			set
			{
				if (decimal.TryParse(value, out var result))
				{
					Amount = result; // Cập nhật giá trị Amount khi người dùng nhập vào
				}
			}
		}
	}
}
