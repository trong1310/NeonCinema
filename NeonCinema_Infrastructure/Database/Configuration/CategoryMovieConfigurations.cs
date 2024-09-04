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
	public class CategoryMovieConfigurations : IEntityTypeConfiguration<CategoryMovies>
	{
		public void Configure(EntityTypeBuilder<CategoryMovies> builder)
		{
			builder.ToTable("CategoryMovies");
			builder.HasKey(x => x.ID);
			builder.HasOne(x=>x.Movies).WithMany(x=>x.CategoryMovies).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x=>x.MovieType).WithMany(x=>x.CategoryMovies).HasForeignKey(x=>x.MovieTypeID).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
