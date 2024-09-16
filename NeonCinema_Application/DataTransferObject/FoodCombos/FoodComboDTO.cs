using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.FoodCombos
{
    public class FoodComboDTO
    {
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ServiceID { get; set; }
        public Guid BillID { get; set; }
    }
}
