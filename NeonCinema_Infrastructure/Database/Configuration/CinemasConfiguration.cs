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
    public class CinemasConfiguration : IEntityTypeConfiguration<Cinemas>
    {
        public void Configure(EntityTypeBuilder<Cinemas> builder)
        {
            builder.ToTable("Cinemas");
            builder.HasKey(x=>x.ID);
            builder.HasOne(x=>x.Rooms).WithMany(x=>x.Cinemas).HasForeignKey(x=>x.RoomId).OnDelete(DeleteBehavior.Restrict);
            builder.Property(x => x.Name).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.Location);
            builder.Property(x=>x.PhoneNumber).HasMaxLength(10).IsRequired();
            builder.Property(x => x.WebSite);
            builder.Property(x=>x.RoomNumber).HasDefaultValue(0).IsRequired();
        }
    }
}
