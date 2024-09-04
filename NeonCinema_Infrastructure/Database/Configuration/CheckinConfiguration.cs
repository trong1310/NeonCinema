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
	public class CheckinConfiguration : IEntityTypeConfiguration<Checkin>
	{
		public void Configure(EntityTypeBuilder<Checkin> builder)
		{
			builder.ToTable("Checkin");
			builder.HasKey(x=>x.ID);
		}
	}
}
