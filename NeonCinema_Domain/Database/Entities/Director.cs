using NeonCinema_Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Director :  EntityBase
    {
        public Guid DirectorID { get; set; }
        public string FullName { get; set; }
        public string StageName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string Biography { get; set; }
        public string Awards { get; set; }
        public List<string> Images { get; set; }
    }
}
