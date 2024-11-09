using Bogus;
using Bogus.Hollywood;
using Bogus.Hollywood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeonCinema_Domain.Database.Entities;
using NeonCinema_Domain.Enum;
using NeonCinema_Infrastructure.Database.Configuration;
using NeonCinema_Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeonCinema_Infrastructure.Database.AppDbContext
{

	public class NeonCinemasContext : DbContext
	{
		public NeonCinemasContext()
		{
		}

		public NeonCinemasContext(DbContextOptions<NeonCinemasContext> options) : base(options)
		{
		}

		#region DbSet
		public DbSet<Bill> BillDetails { get; set; }
		public DbSet<Cinemas> Cinema { get; set; }
		public DbSet<Users> Users { get; set; }
		public DbSet<Director> Directors { get; set; }
		public DbSet<Genre> Genres { get; set; }
		public DbSet<Language> Lenguages { get; set; }
		public DbSet<RankMember> RankMembers { get; set; }
		public DbSet<Movies> Movies { get; set; }
		public DbSet<Roles> Roles { get; set; }
		public DbSet<Countrys> Country { get; set; }
		public DbSet<ShowTime> ShowTimes { get; set; }
		public DbSet<BookTickets> BookTickets { get; set; }
		public DbSet<MovieType> MoviesType { get; set; }
		public DbSet<PaymentMethod> PaymentMethods { get; set; }
		public DbSet<Room> Room { get; set; }
		public DbSet<Screening> Screening { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<SeatType> SeatTypes { get; set; }
		public DbSet<FoodCombo> FoodCombos { get; set; }
		public DbSet<ShiftChange> ShiftChange { get; set; }
		public DbSet<TicketPrice> TicketPrice { get; set; }
		public DbSet<WorkShift> WorkShift { get; set; }
		public DbSet<CategoryMovies> CategoryMovies { get; set; }
		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<Checkin> Checkin { get; set; }
		public DbSet<Show_release> Show_release { get; set; }
		public DbSet<Actor> Actor { get; set; }
		public DbSet<ActorMovies> ActorMovies { get; set; }
		public DbSet<BillTicket> BillTickets { get; set; }
		public DbSet<Point> Points { get; set; }
		public DbSet<Promotion> Promotions { get; set; }
		public DbSet<PromotionUsers> PromotionUsers { get; set; }
		#endregion

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//optionsBuilder.UseSqlServer("Data Source= vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
			optionsBuilder.UseSqlServer("Data Source= CUONG;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			SeedData(modelBuilder);

			modelBuilder.Entity<PromotionUsers>()
				.HasKey(ma => new { ma.PromotionID, ma.UserID });
		}
		private void SeedData(ModelBuilder modelBuilder)
		{
			var roleData = new List<Roles>
			{
				new Roles
				{
					ID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
					CreatedTime = DateTime.Now,
					Status = EntityStatus.Active,
					RoleName = "Admin"
				},
				new Roles
				{
					ID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
					CreatedTime = DateTime.Now,
					Status = EntityStatus.Active,
					RoleName = "Client"
				},
				new Roles
				{
					ID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
					CreatedTime = DateTime.Now,
					Status = EntityStatus.Active,
					RoleName = "Staff"
				}
			};
			modelBuilder.Entity<Roles>().HasData(roleData);

			var userData = new List<Users>
			{
				new Users
				{
					ID = Guid.NewGuid(),
					CreatedTime = DateTime.Now,
					FullName = "Admin",
					Email = "admin@gmail.com",
					PassWord = Hash.Encrypt("admin"),
					Status = EntityStatus.Active,
					PhoneNumber = "0862774830",
					Adderss = "Ba Vi",
					DateOrBriht= DateTime.Parse("25/12/2004"),
					Images = "images.jpg",
					Gender = true,
					RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d")
				},
				new Users
				{
					ID = Guid.NewGuid(),
					CreatedTime = DateTime.Now,
					FullName = "Client",
					Email = "client@gmail.com",
					PassWord = Hash.Encrypt("client"),
					Status = EntityStatus.Active,
					PhoneNumber = "0334555555",
					Adderss = "Ba Vi",
					DateOrBriht= DateTime.Parse("25/12/2004"),
					Images = "images.jpg",
					Gender = true,
					RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
				},
				new Users
				{
					ID = Guid.NewGuid(),
					CreatedTime = DateTime.Now,
					FullName = "Staff",
					Email = "staff@gmail.com",
					PassWord = Hash.Encrypt("staff"),
					Status = EntityStatus.Active,
					PhoneNumber = "0987126125",
					Adderss = "Ba Vi",
					DateOrBriht= DateTime.Parse("20/12/2004"),
					Images = "images.jpg",
					Gender = true,
					RoleID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d")
				}
			};
			modelBuilder.Entity<Users>().HasData(userData);

			var languageData = new List<Language>
			{
				new Language { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), LanguageName = "en" },
				new Language { ID = Guid.NewGuid(), LanguageName = "vi" },
				new Language { ID = Guid.NewGuid(), LanguageName = "ja" }
			};
			modelBuilder.Entity<Language>().HasData(languageData);

			var directorData = new List<Director>
			{
				new Director
				{
					ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
					FullName = "Nguyễn Văn A",
					Address = "Hà Nội",
					Biography = "Có",
					Gender = "Nam",
					Nationality = "Ha Noi",
					Status = EntityStatus.Active
				},
				new Director
				{
					ID = Guid.NewGuid(),
					FullName = "Nguyễn Văn D",
					Address = "Hà Nội",
					Biography = "Có",
					Gender = "Nam",
					Nationality = "Ha Noi",
					Status = EntityStatus.Active
				},
				new Director
				{
					ID = Guid.NewGuid(),
					FullName = "Nguyễn Văn B",
					Address = "Hà Nội",
					Biography = "Có",
					Gender = "Nam",
					Nationality = "Ha Noi",
					Status = EntityStatus.Locked
				},
				new Director
				{
					ID = Guid.NewGuid(),
					FullName = "Nguyễn Văn C",
					Address = "Hà Nội",
					Biography = "Có",
					Gender = "Nam",
					Nationality = "Ha Noi",
					Status = EntityStatus.Locked
				}
			};
			modelBuilder.Entity<Director>().HasData(directorData);

			var genreData = new List<Genre>
			{
				new Genre { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), GenreName = "Kịch tính" },
				new Genre { ID = Guid.NewGuid(), GenreName = "Tình cảm" },
				new Genre { ID = Guid.NewGuid(), GenreName = "2D" },
				new Genre { ID = Guid.NewGuid(), GenreName = "Hoạt hình" }
			};
			modelBuilder.Entity<Genre>().HasData(genreData);

			var countryData = new List<Countrys>
			{
				new Countrys { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), CountryName = "Nhật Bản" },
				new Countrys { ID = Guid.NewGuid(), CountryName = "Vương Quốc Anh" },
				new Countrys { ID = Guid.NewGuid(), CountryName = "Trung Quốc" },
				new Countrys { ID = Guid.NewGuid(), CountryName = "Việt Nam" }
			};
			modelBuilder.Entity<Countrys>().HasData(countryData);

			var seatTypeData = new List<SeatType>
			{
				new SeatType { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), SeatTypeName = "Ghế thường",CreatedTime = DateTime.Now },
				new SeatType { ID = Guid.NewGuid(), SeatTypeName = "Ghế Vip",CreatedTime = DateTime.Now },
				new SeatType { ID = Guid.NewGuid(), SeatTypeName = "Ghế đôi",CreatedTime = DateTime.Now }
			};
			modelBuilder.Entity<SeatType>().HasData(seatTypeData);
			var cinemaData = new List<Cinemas>
			{
				new Cinemas
				{
					ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
					Name = "Cinema A",
					Location = "Hà Nội",
					PhoneNumber = "0123456789",
					WebSite = "www.cinemaa.com",
					OpeningHours = "08:00 AM",
					ClosingHours = "10:00 PM",
					RoomNumber = 5,
					CreatedTime = DateTime.Now,
				},
				new Cinemas
				{
					ID = Guid.NewGuid(),
					Name = "Cinema B",
					Location = "Đà Nẵng",
					PhoneNumber = "0987654321",
					WebSite = "www.cinemab.com",
					OpeningHours = "09:00 AM",
					ClosingHours = "11:00 PM",
					RoomNumber = 7,
					CreatedTime = DateTime.Now,
				}
			};
			modelBuilder.Entity<Cinemas>(b => { b.HasData(cinemaData); });
			var roomData = new List<Room>
			{
				new Room
				{
					ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
					Name = "Room 1",
					SeatingCapacity = 100,
					Status = EntityStatus.Active,
					CreatedTime = DateTime.Now,
							CinemasId = cinemaData[0].ID,
				},
				new Room
				{
					ID = Guid.NewGuid(),
					Name = "Room 2",
					SeatingCapacity = 150,
					Status = EntityStatus.Active,
					CreatedTime = DateTime.Now,
					CinemasId = cinemaData[0].ID,
				}
			};
			modelBuilder.Entity<Room>(b => { b.HasData(roomData); });
			var SeatData = new List<Seat>
			{
				new Seat
				{
					ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
					SeatNumber = "1",
					Column = "1",
					Row = "1",
					Status = seatEnum.selected,
					SeatTypeID = seatTypeData[0].ID,
					RoomID = roomData[0].ID,
				},
				new Seat
				{
					ID = Guid.NewGuid(),
					SeatNumber = "2",
					Column = "2",
					Row = "2",
					Status = seatEnum.selected,
					SeatTypeID = seatTypeData[0].ID,
					RoomID = roomData[0].ID,
				},
				new Seat
				{
					ID = Guid.NewGuid(),
					SeatNumber = "2",
					Column = "2",
					Row = "2",
					Status = seatEnum.selected,
					SeatTypeID = seatTypeData[0].ID,
					RoomID = roomData[0].ID,
				}
			};
			modelBuilder.Entity<Seat>(b => { b.HasData(SeatData); });
			var showTimeData = new List<ShowTime>
			{
				new ShowTime
				{
					ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
					StartTime = new TimeSpan(14, 0, 0), // 14:00
					EndTime = new TimeSpan(16, 30, 0), // 16:30
					Status = EntityStatus.Active,
					
				},
				new ShowTime
				{
					ID = Guid.NewGuid(),
					StartTime = new TimeSpan(18, 0, 0), // 18:00
					EndTime = new TimeSpan(20, 30, 0), // 20:30
					Status = EntityStatus.Active
				}
			};
			modelBuilder.Entity<ShowTime>(b => { b.HasData(showTimeData); });
			var actorData = new List<Actor>
			{
				new Actor
				{
					ID = Guid.Parse("127d38f8-f339-40a6-9626-0dbd122d7f5f"),
					Name = "Dang xuan phong",
					Status = EntityStatus.Active,
				}
			};
			var movieData = new List<Movies>
			{
				new Movies
				{
					ID = Guid.Parse("127d38f8-f339-40a6-9626-0dbd122d7f5f"),
					Name = "Movie A",
					Duration = 120, // in minutes
					Description = "An exciting action movie.",
					StarTime = DateTime.Parse("2024-10-22"),
					Trailer = "https://www.youtube.com/watch?v=IkaP0KJWTsQ",
					Images = "0e9f825c-5346-44f1-a94d-7078909ce83a.png",
					AgeAllowed = 18,
					Status = MovieStatus.Active,
					GenreID = genreData[0].ID,
					LenguageID = languageData[0].ID,
					CountryID = countryData[0].ID,
					DirectorID = directorData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Movies
				{
					ID = Guid.NewGuid(),
					Name = "Movie B",
					Duration = 150,
					Description = "A thrilling mystery.",
					StarTime = DateTime.Parse("2024-11-15"),
					Trailer = "https://www.youtube.com/watch?v=IkaP0KJWTsQ",
					Images = "0e9f825c-5346-44f1-a94d-7078909ce83a.png",
					AgeAllowed = 16,
					Status = MovieStatus.Comingsoon,
					GenreID = genreData[0].ID,
					LenguageID = languageData[0].ID,
					CountryID = countryData[0].ID,
					DirectorID = directorData[0].ID,
					CreatedTime = DateTime.Now
				}
			};
			modelBuilder.Entity<Movies>(b => { b.HasData(movieData); });
			var showreales = new List<Show_release>
			{
				new Show_release
				{
					ID = Guid.Parse("127d38f8-f339-40a6-9626-0dbd122d7f5f"),
					MovieID =movieData[0].ID,
					RoomID = roomData[0].ID,
					Status = EntityStatus.Active,
					TimeRelease = DateTime.Now.AddHours(2),
					DateRelease = DateTime.Now.AddDays(1),
					
				},

			};
			modelBuilder.Entity<Show_release>(b => { b.HasData(showreales); });

			var screeningData = new List<Screening>
			{
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = EntityStatus.Active,
					ShowTimeID = showTimeData[0].ID,
					ShowDate = DateTime.Now.AddDays(2), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Show_ReleaseID = showreales[0].ID,
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = EntityStatus.Active,
					ShowTimeID = showTimeData[0].ID,
					ShowDate = DateTime.Now.AddDays(2), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Show_ReleaseID = showreales[0].ID,
				}
			};
			modelBuilder.Entity<Screening>(b => { b.HasData(screeningData); });
		}
	}
}