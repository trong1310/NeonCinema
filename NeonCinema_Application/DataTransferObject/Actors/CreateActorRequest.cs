using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Actors
{
    public class CreateActorRequest
    {
        public string FullName { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Images { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string? Biography { get; set; }
    }
}
