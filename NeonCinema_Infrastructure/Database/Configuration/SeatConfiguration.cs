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
    public class SeatConfiguration : IEntityTypeConfiguration<Seat>
    {
        public void Configure(EntityTypeBuilder<Seat> builder)
        {
            builder.ToTable("Seat");
            builder.HasKey(x=>x.ID);
            builder.Property(x=>x.SeatNumber);
            builder.HasOne(x=>x.Room).WithMany(x=>x.Seats).HasForeignKey(x=>x.RoomID).OnDelete(DeleteBehavior.NoAction);    
        }
    }
}
