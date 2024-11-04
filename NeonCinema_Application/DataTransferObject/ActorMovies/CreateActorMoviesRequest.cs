using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.ActorMoives
{
    public class CreateActorMoviesRequest
    {
        public Guid MovieID { get; set; }
        public Guid ActorID { get; set; }
        public bool IsLeadActor { get; set; }
    }
}
