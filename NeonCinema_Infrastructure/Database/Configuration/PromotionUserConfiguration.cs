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
	public class PromotionUserConfiguration : IEntityTypeConfiguration<PromotionUsers>
	{
		public void Configure(EntityTypeBuilder<PromotionUsers> builder)
		{
			builder.ToTable("PromotionUsers");
			builder.HasKey(x=>x.ID);
			builder.HasOne(x=>x.User).WithMany(x=>x.PromotionUsers).HasForeignKey(x=>x.UserID).OnDelete(DeleteBehavior.NoAction); ;
			builder.HasOne(x=>x.Promotion).WithMany(x=>x.PromotionUsers).HasForeignKey(x=>x.PromotionID).OnDelete(DeleteBehavior.NoAction); ;
		}
	}
}
