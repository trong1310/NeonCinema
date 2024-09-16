using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Services
{
    public class ServicesUpdateRequest
    {
        public Guid ID { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public EntityStatus Status { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
    }
}
