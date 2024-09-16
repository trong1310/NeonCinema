using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Language : EntityBase
    {
        public Guid ID { get; set; }
        public string LanguageName { get; set; }
       
        //
        public virtual ICollection<Movies>? Movies { get; set; }
    }
}
