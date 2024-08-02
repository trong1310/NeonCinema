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
    public class CenimaConfiguration : IEntityTypeConfiguration<Cinema>
    {
        public void Configure(EntityTypeBuilder<Cinema> builder)
        {
            builder.ToTable("Cenima");
            builder.HasKey(x=>x.CenimaID);
            builder.Property(x => x.Name).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.Location).HasMaxLength(256).IsFixedLength().IsUnicode(true);
            builder.Property(x=>x.PhoneNumber).HasMaxLength(10).IsRequired();
            builder.Property(x => x.WebSite).HasMaxLength(256).IsFixedLength().IsUnicode(true);
            builder.Property(x=>x.RoomNumber).HasDefaultValue(0).IsRequired();
        }
    }
}
