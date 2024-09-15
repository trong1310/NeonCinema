using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Countrys
{
    public class CountryUpdateRequest
    {
        public Guid ID { get; set; }
        public string CountryName { get; set; }
    }
}
