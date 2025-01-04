using NeonCinema_Domain.Database.Base;
using NeonCinema_Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Domain.Database.Entities
{
    public class Actor : EntityBase
    {
        [Key]
        public Guid ID { get; set; }
        public string Name { get; set; }
        [Required(ErrorMessage = "Giới tính không được để trống.")]
        public EntityStatus Sex { get; set; }
        public EntityStatus Status { get; set; }
        public virtual ICollection<ActorMovies>? ActorMovies { get; set; }
    }
}
