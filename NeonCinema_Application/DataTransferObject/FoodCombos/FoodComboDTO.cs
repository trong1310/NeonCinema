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
    }
}
