using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.FoodCombos
{
    public class FoodComboUpdateRequest
    {
        public Guid ID { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid ServiceID { get; set; }
        public Guid BillID { get; set; }
    }
}
