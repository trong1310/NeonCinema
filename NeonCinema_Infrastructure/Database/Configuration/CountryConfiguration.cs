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
	public class CountryConfiguration : IEntityTypeConfiguration<Countrys>
	{
		public void Configure(EntityTypeBuilder<Countrys> builder)
		{
			builder.ToTable(nameof(Countrys));
			builder.HasKey(x=>x.ID);
			builder.HasOne(x=>x.Movies).WithMany(x=>x.Countrys).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
