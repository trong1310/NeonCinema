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
    public class MoviesConfiguration : IEntityTypeConfiguration<Movies>
    {
        public void Configure(EntityTypeBuilder<Movies> builder)
        {
            builder.ToTable("Movies");
            builder.HasKey(x=>x.ID);
            builder.Property(x => x.Duration).HasDefaultValue(0);
            builder.Property(x => x.AgeAllowed).HasDefaultValue(0);
			builder.HasOne(x => x.Countrys).WithMany(x => x.Movies).HasForeignKey(x => x.CountryID).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Genre).WithMany(x => x.Movies).HasForeignKey(x => x.GenreID).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x => x.Lenguage).WithMany(x => x.Movies).HasForeignKey(x => x.LenguageID).OnDelete(DeleteBehavior.NoAction);
		}
    }
}
