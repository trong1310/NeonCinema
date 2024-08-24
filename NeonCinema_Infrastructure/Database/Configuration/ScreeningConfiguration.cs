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
            builder.HasKey(x=>x.ScreeningID);
            builder.Property(x=>x.Price).HasDefaultValue(0).IsRequired();
            //

            builder.HasOne(x=>x.MoviesDetails).WithMany(x=>x.Screenings).HasForeignKey(x=>x.MovieDetailsID);
            builder.HasOne(x=>x.Room).WithMany(x=>x.Screenings).HasPrincipalKey(x=>x.RoomID);
        }
    }
}
