using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.StaticStatis
{
    public class FoodComboDto
    {
        public string ServiceName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
