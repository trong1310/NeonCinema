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
	public class ShowReleaseConfigurations : IEntityTypeConfiguration<Show_release>
	{
		public void Configure(EntityTypeBuilder<Show_release> builder)
		{
			builder.ToTable(nameof(Show_release));
			builder.HasKey(x => x.ID);
			builder.HasOne(x=>x.Movies).WithMany(x=>x.Show_Releases).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);
			builder.HasOne(x=>x.Room).WithMany(x=>x.Show_Releases).HasForeignKey(x=>x.RoomID).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
