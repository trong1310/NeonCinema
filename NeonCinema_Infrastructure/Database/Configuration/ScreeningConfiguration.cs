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
    public class ScreeningConfiguration : IEntityTypeConfiguration<Screening>
    {
        public void Configure(EntityTypeBuilder<Screening> builder)
        {
            builder.ToTable("Screening");
            builder.HasKey(x=>x.ID);
        
            builder.HasOne(x=>x.Movies).WithMany(x=>x.Screening).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x=>x.Rooms).WithMany(x=>x.Screenings).HasForeignKey(x=>x.RoomID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x=>x.ShowTime).WithMany(x=>x.Screening).HasForeignKey(x=>x.ShowTimeID).OnDelete(DeleteBehavior.NoAction);
            builder.HasOne(x=>x.ShowDate).WithMany(x=>x.Screening).HasForeignKey(x=>x.ShowDateID).OnDelete(DeleteBehavior.NoAction);
            
        }
    }
}
