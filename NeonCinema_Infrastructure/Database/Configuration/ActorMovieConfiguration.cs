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
	public class ActorMovieConfiguration : IEntityTypeConfiguration<ActorMovie>
	{
		public void Configure(EntityTypeBuilder<ActorMovie> builder)
		{
			builder.ToTable("ActorMovies");
			builder.HasKey(x=>x.ID);
			builder.HasOne(x=>x.Movies).WithMany(x=>x.ActorMovies).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x=>x.Actors).WithMany(x=>x.ActorMovies).HasForeignKey(x=>x.ActorID).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
