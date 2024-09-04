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
	public class SeatShowTimeStatusConfigurations : IEntityTypeConfiguration<Seat_ShowTime_Status>
	{
		public void Configure(EntityTypeBuilder<Seat_ShowTime_Status> builder)
		{
			builder.ToTable("Seat_ShowTime_Status");
			builder.HasKey(x => x.ID);
			builder.HasOne(x=>x.Seat).WithMany(x=>x.Seat_ShowTime_Status).HasForeignKey(x=>x.SeatID).OnDelete(DeleteBehavior.NoAction);

		}
	}
}
