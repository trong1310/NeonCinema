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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Room");
            builder.HasKey(x => x.RoomID);
            builder.Property(x=>x.Name).HasMaxLength(50).IsFixedLength();
            builder.Property(x=>x.SeatingCapacity).HasDefaultValue(50).IsRequired();

            builder.HasOne(x=>x.Cinema).WithMany(x=>x.Rooms).HasForeignKey(x=>x.CinemaID);

        }
    }
}
