using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Application.DataTransferObject.Actors
{
    public class DeleteActorRequest
    {
        public Guid ID { get; set; }
        public Guid? DeleteBy {  get; set; } 
    }
}
