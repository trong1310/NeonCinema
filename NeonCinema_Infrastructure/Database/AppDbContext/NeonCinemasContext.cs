using Bogus;
using Bogus.Hollywood;
using Bogus.Hollywood.Models;
using Microsoft.AspNetCore.Hosting.Server;
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
		public DbSet<MovieType> MoviesType { get; set; }
		public DbSet<PaymentMethod> PaymentMethods { get; set; }
		public DbSet<Room> Room { get; set; }
		public DbSet<Screening> Screening { get; set; }
		public DbSet<Seat> Seat { get; set; }
		public DbSet<SeatType> SeatTypes { get; set; }
		public DbSet<FoodCombo> FoodCombos { get; set; }
		public DbSet<BillCombo> BillCombos { get; set; }
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
		public DbSet<TicketPriceSetting> TicketPriceSettings { get; set; }
		public DbSet<SeatShowTimeStatus> SeatShowTimeStatuss { get; set; }
		#endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			//optionsBuilder.UseSqlServer("Data Source=DESKTOP-8GC0563\\LEQUANGHAO29BAVI;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
			optionsBuilder.UseSqlServer("Data Source=vantrong\\SQLEXPRESS;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");

			//optionsBuilder.UseSqlServer("Data Source=MRG;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
           // optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");

			optionsBuilder.UseSqlServer("Data Source=CUONG;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");


		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			SeedData(modelBuilder);

			modelBuilder.Entity<PromotionUsers>()
				.HasKey(ma => new { ma.PromotionID, ma.UserID });
			modelBuilder.Entity<BillCombo>()
		   .HasKey(bc => new { bc.BillID, bc.FoodComboID });

			// Thiết lập quan hệ 1-n giữa Bill và BillCombo
			modelBuilder.Entity<BillCombo>()
				.HasOne(bc => bc.Bill)
				.WithMany(b => b.BillCombos)
				.HasForeignKey(bc => bc.BillID);

			// Thiết lập quan hệ 1-n giữa FoodCombo và BillCombo
			modelBuilder.Entity<BillCombo>()
				.HasOne(bc => bc.FoodCombo)
				.WithMany(fc => fc.BillCombos)
				.HasForeignKey(bc => bc.FoodComboID);
            modelBuilder.Entity<Screening>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
			modelBuilder.Entity<Bill>()
		.Property(b => b.TotalPrice)
		.HasColumnType("decimal(18,2)");

			modelBuilder.Entity<Ticket>()
				.Property(t => t.Price)
				.HasColumnType("decimal(18,2)");

			modelBuilder.Entity<TicketPrice>()
				.Property(tp => tp.Price)
				.HasColumnType("decimal(18,2)");

			modelBuilder.Entity<TicketPriceSetting>(entity =>
			{
				entity.Property(tps => tps.PriceAfter17hWeekDay)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.PriceAfter17hWeekeend)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.PriceBefore17hWeekDay)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.PriceBefore17hWeekeend)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.Surcharge3D)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.Surcharge4D)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.SurchargeCouple)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.SurchargeIMAX)
					  .HasColumnType("decimal(18,2)");
				entity.Property(tps => tps.SurchargeVIP)
					  .HasColumnType("decimal(18,2)");
			});
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
		FullName = "Nguyễn Thị Mai",
		Email = "mainguyen@gmail.com",
		PassWord = Hash.Encrypt("mainguyen123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0901123456",
		Adderss = "Hà Nội",
		DateOrBriht = DateTime.Parse("01/01/1990"),
		Images = "images/mai.jpg",
		Gender = false,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),

	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Nguyễn Thị Hà Mai",
		Email = "mainguyen@gmail.com",
		PassWord = Hash.Encrypt("mainguyen123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0901123456",
		Adderss = "Hà Nội",
		DateOrBriht = DateTime.Parse("01/01/1991"),
		Images = "images/mai.jpg",
		Gender = false,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),

	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Phạm Văn Nam",
		Email = "nampham@gmail.com",
		PassWord = Hash.Encrypt("nampham123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0902123457",
		Adderss = "Hải Phòng",
		DateOrBriht = DateTime.Parse("05/06/1992"),
		Images = "images/nam.jpg",
		Gender = true,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Lê Thị Thu",
		Email = "thule@gmail.com",
		PassWord = Hash.Encrypt("thule123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0903123458",
		Adderss = "Đà Nẵng",
		DateOrBriht = DateTime.Parse("12/12/1993"),
		Images = "images/thu.jpg",
		Gender = false,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Trần Văn Tùng",
		Email = "tungtran@gmail.com",
		PassWord = Hash.Encrypt("tungtran123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0904123459",
		Adderss = "TP. Hồ Chí Minh",
		DateOrBriht = DateTime.Parse("20/09/1988"),
		Images = "images/tung.jpg",
		Gender = true,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Vũ Thị Lan",
		Email = "lanvu@gmail.com",
		PassWord = Hash.Encrypt("lanvu123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0905123460",
		Adderss = "Nghệ An",
		DateOrBriht = DateTime.Parse("15/04/1995"),
		Images = "images/lan.jpg",
		Gender = false,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Đỗ Văn Hùng",
		Email = "hungdo@gmail.com",
		PassWord = Hash.Encrypt("hungdo123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0906123461",
		Adderss = "Bắc Ninh",
		DateOrBriht = DateTime.Parse("30/03/1990"),
		Images = "images/hung.jpg",
		Gender = true,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Nguyễn Văn Bình",
		Email = "binhnguyen@gmail.com",
		PassWord = Hash.Encrypt("binhnguyen123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0907123462",
		Adderss = "Thái Bình",
		DateOrBriht = DateTime.Parse("25/11/1985"),
		Images = "images/binh.jpg",
		Gender = true,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Trần Thị Hạnh",
		Email = "hanhtran@gmail.com",
		PassWord = Hash.Encrypt("hanhtran123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0908123463",
		Adderss = "Hưng Yên",
		DateOrBriht = DateTime.Parse("18/05/1994"),
		Images = "images/hanh.jpg",
		Gender = false,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Lê Văn Long",
		Email = "longle@gmail.com",
		PassWord = Hash.Encrypt("longle123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0909123464",
		Adderss = "Nam Định",
		DateOrBriht = DateTime.Parse("10/07/1986"),
		Images = "images/long.jpg",
		Gender = true,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Phạm Thị Ngọc",
		Email = "ngocpham@gmail.com",
		PassWord = Hash.Encrypt("ngocpham123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0910123465",
		Adderss = "Quảng Ninh",
		DateOrBriht = DateTime.Parse("22/10/1997"),
		Images = "images/ngoc.jpg",
		Gender = false,
		RoleID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b")
	}
};

			modelBuilder.Entity<Users>().HasData(userData);

			var languageData = new List<Language>
			{
				new Language { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), LanguageName = "EN" },
				new Language { ID = Guid.NewGuid(), LanguageName = "VIE" },
				new Language { ID = Guid.NewGuid(), LanguageName = "JPN" },
				new Language { ID = Guid.NewGuid(), LanguageName = "ThaiLans" },
				new Language { ID = Guid.NewGuid(), LanguageName = "USA" },
				new Language { ID = Guid.NewGuid(), LanguageName = "Korea" }
			};
			modelBuilder.Entity<Language>().HasData(languageData);

			var directorData = new List<Director>
{
	new Director
	{
		ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"),
		FullName = "Trấn Thành",
		Address = "TP Hồ Chí Minh",
		Biography = "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Lý Hải",
		Address = "TP Hồ Chí Minh",
		Biography = "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Victor Vũ",
		Address = "Hà Nội",
		Biography = "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Charlie Nguyễn",
		Address = "TP Hồ Chí Minh",
		Biography = "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Ngô Thanh Vân",
		Address = "Hồ Chí Minh",
		Biography = "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.",
		Gender = "Nữ",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Đỗ Đức Thịnh",
		Address = "Hà Nội",
		Biography = "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Phan Gia Nhật Linh",
		Address = "Hồ Chí Minh",
		Biography = "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Vũ Ngọc Đãng",
		Address = "Hà Nội",
		Biography = "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Nguyễn Quang Dũng",
		Address = "Hồ Chí Minh",
		Biography = "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	},
	new Director
	{
		ID = Guid.NewGuid(),
		FullName = "Huỳnh Đông",
		Address = "Cần Thơ",
		Biography = "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.",
		Gender = "Nam",
		Nationality = "Việt Nam",
		Status = EntityStatus.Active
	}
};

			modelBuilder.Entity<Director>().HasData(directorData);


			// Dữ liệu thể loại phim (Genre)
			var genreData = new List<Genre>
{
	new Genre { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), GenreName = "Kịch tính" },
	new Genre { ID = Guid.NewGuid(), GenreName = "Tình cảm" },
	new Genre { ID = Guid.NewGuid(), GenreName = "Hành động" }, // Thêm thể loại Hành động
    new Genre { ID = Guid.NewGuid(), GenreName = "Kinh dị" }, // Thêm thể loại Kinh dị
    new Genre { ID = Guid.NewGuid(), GenreName = "Hoạt hình" },
	new Genre { ID = Guid.NewGuid(), GenreName = "Phiêu lưu" }, // Thêm thể loại Phiêu lưu
    new Genre { ID = Guid.NewGuid(), GenreName = "Hài hước" }, // Thêm thể loại Hài hước
    new Genre { ID = Guid.NewGuid(), GenreName = "Lãng mạn" }, // Thêm thể loại Lãng mạn
    new Genre { ID = Guid.NewGuid(), GenreName = "Tâm lý" }, // Thêm thể loại Tâm lý
    new Genre { ID = Guid.NewGuid(), GenreName = "Khoa học viễn tưởng" } // Thêm thể loại Khoa học viễn tưởng
};
			modelBuilder.Entity<Genre>().HasData(genreData);

			// Dữ liệu quốc gia (Countrys)
			var countryData = new List<Countrys>
{
	new Countrys { ID = Guid.Parse("8fb86c77-213f-4316-8a7a-43fee795514e"), CountryName = "Nhật Bản" },
	new Countrys { ID = Guid.NewGuid(), CountryName = "Vương Quốc Anh" },
	new Countrys { ID = Guid.NewGuid(), CountryName = "Trung Quốc" },
	new Countrys { ID = Guid.NewGuid(), CountryName = "Việt Nam" },
	new Countrys { ID = Guid.NewGuid(), CountryName = "Mỹ" }, // Thêm quốc gia Mỹ
    new Countrys { ID = Guid.NewGuid(), CountryName = "Hàn Quốc" }, // Thêm quốc gia Hàn Quốc
    new Countrys { ID = Guid.NewGuid(), CountryName = "Pháp" }, // Thêm quốc gia Pháp
    new Countrys { ID = Guid.NewGuid(), CountryName = "Hồng Kông" }, // Thêm quốc gia Hồng Kông
    new Countrys { ID = Guid.NewGuid(), CountryName = "Ấn Độ" }, // Thêm quốc gia Ấn Độ
    new Countrys { ID = Guid.NewGuid(), CountryName = "Úc" } // Thêm quốc gia Úc
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
			// Dữ liệu ghế cho 2 phòng
			var seatData = new List<Seat>();

			// Tạo ghế cho Room 1 (10 hàng x 10 cột = 100 ghế)
			for (int row = 1; row <= 10; row++) // 10 hàng
			{
				for (char col = 'A'; col <= 'J'; col++) // 10 cột (A đến J)
				{
					seatData.Add(new Seat
					{
						ID = Guid.NewGuid(),
						Column = col.ToString(),
						Row = row.ToString(),
						SeatNumber = $"{col}{row}",
						Status = seatEnum.Available,  // Bạn có thể thay đổi trạng thái ghế
						SeatTypeID = seatTypeData[0].ID,  // Loại ghế "Ghế thường"
						RoomID = roomData[0].ID  // Phòng 1
					});
				}
			}

			// Tạo ghế cho Room 2 (15 hàng x 10 cột = 150 ghế)
			for (int row = 1; row <= 15; row++) // 15 hàng
			{
				for (char col = 'A'; col <= 'J'; col++) // 10 cột (A đến J)
				{
					seatData.Add(new Seat
					{
						ID = Guid.NewGuid(),
						Column = col.ToString(),
						Row = row.ToString(),
						SeatNumber = $"{col}{row}",
						Status = seatEnum.Available,  // Bạn có thể thay đổi trạng thái ghế
						SeatTypeID = seatTypeData[0].ID,  // Loại ghế "Ghế thường"
						RoomID = roomData[1].ID  // Phòng 2
					});
				}
			}

			// Chèn dữ liệu vào database
			modelBuilder.Entity<Seat>(b => { b.HasData(seatData); });

			var showTimeData = new List<ShowTime>
{
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(8, 0, 0),   // 08:00 AM
		EndTime = new TimeSpan(10, 0, 0),    // 10:00 AM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(10, 15, 0), // 10:15 AM
		EndTime = new TimeSpan(12, 15, 0),   // 12:15 PM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(12, 30, 0), // 12:30 PM
		EndTime = new TimeSpan(14, 30, 0),   // 02:30 PM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(14, 45, 0), // 02:45 PM
		EndTime = new TimeSpan(16, 45, 0),   // 04:45 PM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(17, 0, 0),  // 05:00 PM
		EndTime = new TimeSpan(19, 0, 0),    // 07:00 PM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(19, 15, 0), // 07:15 PM
		EndTime = new TimeSpan(21, 15, 0),   // 09:15 PM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(21, 30, 0), // 09:30 PM
		EndTime = new TimeSpan(23, 30, 0),   // 11:30 PM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(23, 45, 0), // 11:45 PM
		EndTime = new TimeSpan(1, 45, 0),    // 01:45 AM (ngày hôm sau)
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(2, 0, 0),   // 02:00 AM
		EndTime = new TimeSpan(4, 0, 0),     // 04:00 AM
		Status = EntityStatus.Active
	},
	new ShowTime
	{
		ID = Guid.NewGuid(),
		StartTime = new TimeSpan(4, 30, 0),  // 04:30 AM
		EndTime = new TimeSpan(6, 30, 0),    // 06:30 AM
		Status = EntityStatus.Active
	}
};

			// Thêm dữ liệu vào model
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
    // 5 phim đang chiếu
    new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Bố Già 2",
		Duration = 130,
		Description = "Hành trình cảm động về tình cha con giữa Sài Gòn.",
		StarTime = DateTime.Parse("2024-08-15"),
		Trailer = "https://www.youtube.com/watch?v=bogia2-trailer",
		Images = "0e9f825c-5346-44f1-a94d-7078909ce83a.png",
		AgeAllowed = 16,
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
		Name = "Chị Mười Ba: Cuộc Chiến Nhân Tình",
		Duration = 120,
		Description = "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.",
		StarTime = DateTime.Parse("2024-09-10"),
		Trailer = "https://www.youtube.com/watch?v=chimuoiba-trailer",
		Images = "161cd6ca-380d-4627-8071-2d5af03a1cf2.png",
		AgeAllowed = 18,
		Status = MovieStatus.Active,
		GenreID = genreData[1].ID,
		LenguageID = languageData[1].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[1].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Nhà Bà Nữ",
		Duration = 110,
		Description = "Cuộc sống đầy biến động của một gia đình truyền thống Việt.",
		StarTime = DateTime.Parse("2024-07-25"),
		Trailer = "https://www.youtube.com/watch?v=nhabanu-trailer",
		Images = "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png",
		AgeAllowed = 13,
		Status = MovieStatus.Active,
		GenreID = genreData[2].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[2].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Gái Già Lắm Chiêu 6",
		Duration = 140,
		Description = "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.",
		StarTime = DateTime.Parse("2024-06-20"),
		Trailer = "https://www.youtube.com/watch?v=gaigialamchieu-trailer",
		Images = "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png",
		AgeAllowed = 15,
		Status = MovieStatus.Active,
		GenreID = genreData[3].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[3].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Tiệc Trăng Máu 2",
		Duration = 125,
		Description = "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.",
		StarTime = DateTime.Parse("2024-09-01"),
		Trailer = "https://www.youtube.com/watch?v=tiectrangmau-trailer",
		Images = "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png",
		AgeAllowed = 18,
		Status = MovieStatus.Active,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now
	},

    // 5 phim sắp chiếu
    new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Rừng Thế Mạng 2",
		Duration = 115,
		Description = "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.",
		StarTime = DateTime.Parse("2024-12-15"),
		Trailer = "https://www.youtube.com/watch?v=rungthemanh-trailer",
		Images = "rungthemanh.png",
		AgeAllowed = 16,
		Status = MovieStatus.Comingsoon,
		GenreID = genreData[0].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[0].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Em Và Trịnh 2",
		Duration = 150,
		Description = "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.",
		StarTime = DateTime.Parse("2024-11-30"),
		Trailer = "https://www.youtube.com/watch?v=emvatrinh-trailer",
		Images = "5b626704-f3d1-482f-b77c-903284966efa.png",
		AgeAllowed = 13,
		Status = MovieStatus.Comingsoon,
		GenreID = genreData[1].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[1].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Mắt Biếc 2",
		Duration = 130,
		Description = "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.",
		StarTime = DateTime.Parse("2024-12-01"),
		Trailer = "https://www.youtube.com/watch?v=matbiec-trailer",
		Images = "7502d22a-c967-400c-bc8c-3062d00c7fcc.png",
		AgeAllowed = 12,
		Status = MovieStatus.Comingsoon,
		GenreID = genreData[2].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[2].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Người Nhện Việt Nam",
		Duration = 145,
		Description = "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.",
		StarTime = DateTime.Parse("2024-12-20"),
		Trailer = "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer",
		Images = "96cc9263-2adb-46f1-a015-fe0a18c4b781.png",
		AgeAllowed = 15,
		Status = MovieStatus.Comingsoon,
		GenreID = genreData[3].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[3].ID,
		CreatedTime = DateTime.Now
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "Sài Gòn Trong Cơn Mưa 2",
		Duration = 100,
		Description = "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.",
		StarTime = DateTime.Parse("2024-11-25"),
		Trailer = "https://www.youtube.com/watch?v=saigonmuaroi-trailer",
		Images = "96cc9263-2adb-46f1-a015-fe0a18c4b781.png",
		AgeAllowed = 13,
		Status = MovieStatus.Comingsoon,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now
	}
};

			// Thêm dữ liệu vào model
			modelBuilder.Entity<Movies>(b => { b.HasData(movieData); });

			// 19. Show_release
			var showReleaseData = new List<Show_release>
	{
		new Show_release { ID = Guid.NewGuid(), MovieID = movieData[0].ID, RoomID = roomData[0].ID, Status = EntityStatus.Active , TimeRelease = DateTime.Now.AddMinutes(1),DateRelease =DateTime.Now.AddDays(1) },
		new Show_release { ID = Guid.NewGuid(), MovieID = movieData[1].ID, RoomID = roomData[1].ID, Status = EntityStatus.Active, TimeRelease = DateTime.Now.AddMinutes(2),DateRelease =DateTime.Now.AddDays(2) }
	};
			modelBuilder.Entity<Show_release>().HasData(showReleaseData);


			var screeningData = new List<Screening>
			{
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[0].ID,
					ShowDate = DateTime.Now.AddDays(10), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[1].ID,
					ShowDate = DateTime.Now.AddDays(9), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[2].ID,
					ShowDate = DateTime.Now.AddDays(8), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[3].ID,
					ShowDate = DateTime.Now.AddDays(7), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[4].ID,
					ShowDate = DateTime.Now.AddDays(6), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[5].ID,
					ShowDate = DateTime.Now.AddDays(5), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[6].ID,
					ShowDate = DateTime.Now.AddDays(4), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now
				}

			};
			modelBuilder.Entity<Screening>(b => { b.HasData(screeningData); });
			var paymentMethodData = new List<PaymentMethod>
	{
		new PaymentMethod { ID = Guid.NewGuid(), Name = "Credit Card", QRCode = "hh2", Status = EntityStatus.Active },
		new PaymentMethod { ID = Guid.NewGuid(), Name = "Cash",QRCode = "mskt3", Status = EntityStatus.Active  }
	};
			modelBuilder.Entity<PaymentMethod>().HasData(paymentMethodData);

			var ticketSeting = new List<TicketPriceSetting>
	{
		new TicketPriceSetting
	{
		ID = Guid.Parse("4bab0da1-d912-4a87-8e21-cb7a665657d3"),
		PriceBefore17hWeekDay = 50000,
		PriceAfter17hWeekDay = 60000,
		PriceBefore17hWeekeend = 60000,
		PriceAfter17hWeekeend = 70000,
		Surcharge3D = 30000,
		Surcharge4D = 40000,
		SurchargeIMAX = 50000,
		SurchargeVIP = 30000,
		SurchargeCouple = 50000
	},
	
	};
			modelBuilder.Entity<TicketPriceSetting>().HasData(ticketSeting);


			// 23. TicketSeat
			var ticketPriceData = new List<TicketPrice>
	{
		new TicketPrice { ID = Guid.NewGuid(), TicketPriceSettingID = ticketSeting[0].ID,ShowTimeID = showTimeData[0].ID, SeatTypeID = seatTypeData [0].ID,ScreeningID = screeningData[0].ID, Price = 50000, Status = EntityStatus.Active,  },
		new TicketPrice { ID = Guid.NewGuid(), TicketPriceSettingID = ticketSeting[0].ID, ShowTimeID = showTimeData[1].ID, SeatTypeID = seatTypeData [1].ID,ScreeningID = screeningData[1].ID, Price = 60000, Status = EntityStatus.Active  }
	};
			modelBuilder.Entity<TicketPrice>().HasData(ticketPriceData);
			// 22. Ticket
			var ticketData = new List<Ticket>
			{
				new Ticket { ID = Guid.NewGuid(),  ScreningID = screeningData[0].ID, MovieID = movieData[0].ID,SeatID = seatData [0].ID, Price = 100000 , Status = ticketEnum.paid},
		new Ticket { ID = Guid.NewGuid(),  ScreningID = screeningData[1].ID, MovieID = movieData[1].ID,SeatID = seatData [1].ID, Price = 2100000 , Status = ticketEnum.paid },
		new Ticket { ID = Guid.NewGuid(),  ScreningID = screeningData[2].ID, MovieID = movieData[2].ID,SeatID = seatData [2].ID, Price = 3100000 , Status = ticketEnum.paid }
	};
			modelBuilder.Entity<Ticket>().HasData(ticketData);
			var foodComboData = new List<FoodCombo>
	{
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 1, TotalPrice = 100000 ,Content="Combo 1",Description ="1 bắp 1 cola" , Images = "tải xuống.jfif",CreatedTime = DateTime.Now },
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 2, TotalPrice = 150000,Content="Combo 2",Description ="2 bắp 2 cola",Images = "tải xuống.jfif" ,CreatedTime = DateTime.Now.AddDays(-1) },
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 3, TotalPrice = 120000,Content="Combo 3",Description ="1 bắp bơ + 2 cola",Images = "tải xuống.jfif" ,CreatedTime = DateTime.Now.AddDays(-2) },
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 4, TotalPrice = 200000,Content="Combo 4",Description ="2 bắp bơ 2 cola",Images = "tải xuống.jfif" ,CreatedTime = DateTime.Now.AddDays(-3) }
	};
			modelBuilder.Entity<FoodCombo>().HasData(foodComboData);



			// 26. Checkin
			var checkinData = new List<Checkin>
	{
		new Checkin { ID = Guid.NewGuid(), Code = "phonghhhhh",Type = "mua tại quầy", Name="hotdot", TicketID = ticketPriceData[0].ID },
		new Checkin { ID = Guid.NewGuid(), Code = "hgdsad",Type = "mua tại quầy", Name="hotdsot", TicketID = ticketPriceData[1].ID  }
	};
			modelBuilder.Entity<Checkin>().HasData(checkinData);
			var billData = new List<Bill>
{
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[0].ID,
		TotalPrice = 500000,
		BillCode = "BILL001",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[1].ID,
		TotalPrice = 300000,
		BillCode = "BILL002",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[2].ID,
		TotalPrice = 150000,
		BillCode = "BILL003",
		Status = ticketEnum.cancel,
		CreatedTime = DateTime.Now.AddDays(-1)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[3].ID,
		TotalPrice = 200000,
		BillCode = "BILL004",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now.AddDays(-2)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[4].ID,
		TotalPrice = 250000,
		BillCode = "BILL005",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now.AddDays(-3)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[5].ID,
		TotalPrice = 600000,
		BillCode = "BILL006",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now.AddDays(-4)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[5].ID,
		TotalPrice = 680000,
		BillCode = "BILL0122",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now.AddDays(-4)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[6].ID,
		TotalPrice = 800000,
		BillCode = "BILL007",
		Status = ticketEnum.waiting_for_payment,
		CreatedTime = DateTime.Now.AddDays(-5)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[7].ID,
		TotalPrice = 450000,
		BillCode = "BILL008",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now.AddDays(-10)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[8].ID,
		TotalPrice = 350000,
		BillCode = "BILL009",
		Status = ticketEnum.checkin,
		CreatedTime = DateTime.Now.AddDays(-8)
	},
	new Bill
	{
		ID = Guid.NewGuid(),
		UserID = userData[9].ID,
		TotalPrice = 700000,
		BillCode = "BILL010",
		Status = ticketEnum.paid,
		CreatedTime = DateTime.Now.AddDays(-6)
	}
};
			modelBuilder.Entity<Bill>().HasData(billData);

			var billCombo = new List<BillCombo>
			{
				new BillCombo
				{

					 BillID = billData[0].ID,
					 Quantity = 1,
					 FoodComboID = foodComboData[0].ID,
					 CreatedTime = DateTime.Now.AddDays(-2)
				},
				 new BillCombo
				{
					 BillID = billData[1].ID,
					 Quantity = 2,
					 FoodComboID = foodComboData[1].ID,
					 CreatedTime = DateTime.Now,

				},
				 new BillCombo
				{
					 BillID = billData[2].ID,
					 FoodComboID = foodComboData[2].ID,
					 Quantity = 3,
					 CreatedTime = DateTime.Now.AddDays(-1),

				},
				 new BillCombo
				{
					 BillID = billData[3].ID,
					 FoodComboID = foodComboData[3].ID,
					 Quantity = 4,
					 CreatedTime = DateTime.Now.AddDays(-2),

				}

			};
			modelBuilder.Entity<BillCombo>().HasData(billCombo);
			// Seed data cho bảng BillTicket
			var billTicketData = new List<BillTicket>
	{
		new BillTicket
		{
			BillId = billData[0].ID,
			TicketId = ticketData[0].ID,
			CreatedTime = DateTime.Now.AddDays(-1)
		},
		new BillTicket
		{
			BillId = billData[1].ID,
			TicketId = ticketData[1].ID,
			CreatedTime = DateTime.Now.AddDays(-1)
		},
		new BillTicket
		{
			BillId = billData[2].ID,
			TicketId = ticketData[2].ID,
			CreatedTime = DateTime.Now.AddDays(-2)
		},
		new BillTicket
		{
			BillId = billData[3].ID,
			TicketId = ticketData[1].ID,
			CreatedTime = DateTime.Now.AddDays(-2)
		},
		new BillTicket
		{
			BillId = billData[4].ID,
			TicketId = ticketData[0].ID,
			CreatedTime = DateTime.Now
		}
	};
			modelBuilder.Entity<BillTicket>().HasData(billTicketData);
			var rankMemberData = new List<RankMember>
{
	new RankMember
	{
		ID = Guid.NewGuid(),
		UserID =userData[0].ID,
		Rank = "Gold",
		MinPoint = 100,
		Status = EntityStatus.Active,
		StarDate = DateTime.Now
	}
};
			modelBuilder.Entity<RankMember>().HasData(rankMemberData);
			// 29. Point
			var pointData = new List<Point>
{
	new Point { ID = Guid.NewGuid(), TotalPoint = 50, DateEarned = DateTime.Now, UserID = userData[0].ID },
	new Point { ID = Guid.NewGuid(), TotalPoint = 150, DateEarned = DateTime.Now, UserID = userData[1].ID }
};
			modelBuilder.Entity<Point>().HasData(pointData);
			var workShiftData = new List<WorkShift>
{
	new WorkShift
	{
		ID = Guid.NewGuid(),
		WorkDate = DateTime.Now,
		TimeStar = DateTime.Now.AddHours(-2),
		TimeEnd = DateTime.Now.AddHours(2),
		Status = EntityStatus.Active,
		UserID = userData[0].ID
	}
};
			modelBuilder.Entity<WorkShift>().HasData(workShiftData);

		}
	}
}