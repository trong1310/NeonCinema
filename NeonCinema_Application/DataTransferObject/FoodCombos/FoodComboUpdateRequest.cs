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
        public string? Content { get; set; }
        public string? Images { get; set; }
        public string? Description { get; set; }
        public Decimal? Amount { get; set; }
    }
}
