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
    public class MovieDetailConfiguration : IEntityTypeConfiguration<MovieDetail>
    {
        public void Configure(EntityTypeBuilder<MovieDetail> builder)
        {
            builder.ToTable("MovieDetail");
            builder.HasKey(x=>x.MovieDetailID);
            builder.HasOne(x=>x.MovieType).WithMany(x=>x.MovieDetails).HasForeignKey(x=>x.MovieTypeID);
          
            builder.HasOne(x=>x.Actor).WithMany(x=>x.MovieDetails).HasForeignKey(x=>x.ActorID);
            builder.HasOne(x=>x.Employees).WithMany(x=>x.MovieDetails).HasForeignKey(x=>x.MovieDetailID);
            builder.HasOne(x=>x.Director).WithMany(x=>x.MovieDetails).HasForeignKey(x=>x.DirectorID);
            builder.HasOne(x => x.Lenguage).WithMany(x => x.MovieDetails).HasForeignKey(x => x.LenguageID);
            builder.HasOne(x => x.Countrys).WithMany(x => x.Moviesdetail).HasForeignKey(x => x.CountryID);
            
            builder.HasOne(x => x.Genre).WithMany(x => x.MovieDetails).HasForeignKey(x => x.GenreID);

            builder.Property(x => x.Duration).HasDefaultValue(0);
            builder.Property(x => x.Images).HasConversion(
                    c => JsonConvert.SerializeObject(c),
                    c => JsonConvert.DeserializeObject<List<string>>(c));
            builder.Property(x => x.AgeAllowed).HasDefaultValue(0);

        }
    }
}
