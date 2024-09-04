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
	public class RankMemberConfiguration : IEntityTypeConfiguration<RankMember>
	{
		public void Configure(EntityTypeBuilder<RankMember> builder)
		{
			builder.ToTable(nameof(RankMember));
			builder.HasKey(x=>x.ID);
			builder.HasOne(x=>x.Users).WithMany(x=>x.RankMembers).HasForeignKey(x=>x.UserID).OnDelete( DeleteBehavior.NoAction);

		}
	}
}
