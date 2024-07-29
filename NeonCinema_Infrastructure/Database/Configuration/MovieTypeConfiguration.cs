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
    public class MovieTypeConfiguration : IEntityTypeConfiguration<MovieType>
    {
        public void Configure(EntityTypeBuilder<MovieType> builder)
        {
            builder.ToTable("MovieType");
            builder.HasKey(x=>x.MovieTypeID);
            builder.Property(x => x.MovieTypeName).HasMaxLength(50).IsFixedLength();
        }
    }
}
