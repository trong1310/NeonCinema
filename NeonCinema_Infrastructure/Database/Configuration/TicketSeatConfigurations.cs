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
	public class TicketSeatConfigurations : IEntityTypeConfiguration<TicketSeat>
	{
		public void Configure(EntityTypeBuilder<TicketSeat> builder)
		{
			builder.ToTable(nameof(TicketSeat));
			builder.HasKey(x=>x.ID);
			builder.HasOne(x=>x.Movies).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.MovieID).OnDelete(DeleteBehavior.NoAction);	
			builder.HasOne(x=>x.Show_Release).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.Show_ReleaseID).OnDelete(DeleteBehavior.NoAction);	
			builder.HasOne(x=>x.Tickets).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.TicketID).OnDelete(DeleteBehavior.NoAction);	
			builder.HasOne(x=>x.Room).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.RoomID).OnDelete(DeleteBehavior.NoAction);		
			builder.HasOne(x=>x.Cinemas).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.CinemasID).OnDelete(DeleteBehavior.NoAction);		
			builder.HasOne(x=>x.Seat).WithMany(x=>x.TicketSeats).HasForeignKey(x=>x.SeatID).OnDelete(DeleteBehavior.NoAction);		
		}
	}
}
