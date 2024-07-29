using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class LenguageConfiguration : IEntityTypeConfiguration<Lenguage>
    {
        public void Configure(EntityTypeBuilder<Lenguage> builder)
        {
            builder.ToTable("Lenguage");
            builder.HasKey(x => x.LenguageID);
            builder.Property(x => x.LenguageName).HasMaxLength(50).IsFixedLength();
        }
    }
}
