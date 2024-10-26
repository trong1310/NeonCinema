using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonCinema_Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.Configuration
{
    public class MoviesActorConfiguration : IEntityTypeConfiguration<MoviesActor>
    {
        public void Configure(EntityTypeBuilder<MoviesActor> builder)
        {
            builder.ToTable("ActorMovies");
            builder.HasKey(x=> new {x.MovieID,x.ActorID});
            builder.HasOne(ma => ma.Movie).WithMany(m => m.MoviesActor).HasForeignKey(ma => ma.MovieID).OnDelete(DeleteBehavior.NoAction); 
            builder.HasOne(ma => ma.Actor).WithMany(a => a.MoviesActors).HasForeignKey(ma => ma.ActorID).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
