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
	public class TicketConfigurations : IEntityTypeConfiguration<Ticket>
	{
		public void Configure(EntityTypeBuilder<Ticket> builder)
		{
			builder.ToTable("Ticket");
			builder.HasKey(x=>x.ID);
			builder.HasOne(x=>x.Movies).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);	
			builder.HasOne(x => x.Screenings).WithMany(x => x.Ticket).HasForeignKey(x => x.ScreningID).OnDelete(DeleteBehavior.NoAction);			
			builder.HasOne(x=>x.Seat).WithMany(x=>x.Ticket).HasForeignKey(x=>x.SeatID).OnDelete(DeleteBehavior.NoAction);		
		}
	}
}
