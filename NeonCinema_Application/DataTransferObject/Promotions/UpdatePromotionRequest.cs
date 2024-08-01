using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
    public class UpdatePromotionRequest
    {
        public Guid PromotionID { get; set; }
        public string PromotionCode { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Quantity { get; set; }
        public string Proviso { get; set; }
        public string Discount { get; set; }
        public Guid PromotionTypeID { get; set; } 
    }
}
