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
	public class CinemaTypesConfigurations : IEntityTypeConfiguration<CinemasType>
	{
		public void Configure(EntityTypeBuilder<CinemasType> builder)
		{
			builder.ToTable("CinemaTypes");
			builder.HasKey(x => x.Id);
		}
	}
}
