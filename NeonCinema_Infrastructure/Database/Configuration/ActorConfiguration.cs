using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class ActorConfiguration : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.ToTable("Actor");
            builder.HasKey(x=>x.ID);
            builder.Property(x=>x.FullName).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.Address);
            builder.Property(x=>x.Nationality).HasMaxLength(256).IsFixedLength();
            builder.Property(x => x.Biography);
           

        }
    }
}
