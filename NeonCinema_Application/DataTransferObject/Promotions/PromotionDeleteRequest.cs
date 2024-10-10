using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Promotions
{
    public class PromotionDeleteRequest
    {
        public Guid Id { get; set; }
        public Guid DeleteBy { get; set; }
    }
}
