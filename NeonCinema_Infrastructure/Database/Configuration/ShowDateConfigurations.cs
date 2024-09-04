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
	public class ShowDateConfigurations : IEntityTypeConfiguration<ShowDate>
	{
		public void Configure(EntityTypeBuilder<ShowDate> builder)
		{
			builder.HasKey(x => x.ID);
			builder.HasOne(x => x.Screening).WithMany(x => x.ShowDates).HasForeignKey(x => x.ScreeningID).OnDelete(DeleteBehavior.NoAction);
		}
	}
}
