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
        public DbSet<PendingPoint> PendingPoint { get; set; }
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
		public DbSet<Ticket> Tickets { get; set; }
		public DbSet<Checkin> Checkin { get; set; }
		public DbSet<Show_release> Show_release { get; set; }
		public DbSet<Actor> Actor { get; set; }
		public DbSet<ActorMovies> ActorMovies { get; set; }
		public DbSet<Promotion> Promotions { get; set; }
		public DbSet<PromotionUsers> PromotionUsers { get; set; }
		public DbSet<TicketPriceSetting> TicketPriceSettings { get; set; }
		public DbSet<SeatShowTimeStatus> SeatShowTimeStatuss { get; set; }
		#endregion


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-8GC0563\\LEQUANGHAO29BAVI;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
            //optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=NeonCinemas;Integrated Security=True;Encrypt=True;Connect Timeout=120;Trust Server Certificate=True");
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
			var movieType = new List<MovieType>
			{
				new MovieType
				{
					ID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
					MovieTypeName = "3D",
				},
				new MovieType
				{
					ID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
					MovieTypeName = "2D",
				},
			};
			modelBuilder.Entity<MovieType>().HasData(movieType);
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
	},
	new Users
	{
		ID = Guid.NewGuid(),
		CreatedTime = DateTime.Now,
		FullName = "Phùng Tiến Giáp",
		Email = "giaphipp@gmail.com",
		PassWord = Hash.Encrypt("abc123"),
		Status = EntityStatus.Active,
		PhoneNumber = "0862774830",
		Adderss = "Hà Nội",
		DateOrBriht = DateTime.Parse("01/01/2004"),
		Images = "images/mai.jpg",
		Gender = false,
		RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

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
                new SeatType { ID = Guid.Parse("0CE08FD6-0D1D-4C61-8B8B-7827BAFF7FE1"), SeatTypeName = "Ghế Vip",CreatedTime = DateTime.Now },
                new SeatType { ID = Guid.Parse("587FF198-12D1-4EB4-9CE7-909DA4AF6BCB"), SeatTypeName = "Ghế đôi",CreatedTime = DateTime.Now }
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
                    RowNumber = 12,
                    ColumnNumber = 12,
                    CreatedTime = DateTime.Now,
					CinemasId = cinemaData[0].ID,
				},
				new Room
				{
					ID = Guid.NewGuid(),
					Name = "Room 2",
					SeatingCapacity = 150,
                    RowNumber = 12,
                    ColumnNumber = 12,
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
		Name = "DEVILS STAY: NGÀI QUỶ",
		Duration = 130,
		Description = "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, " +
		"tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, " +
		"mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.",
		StarTime = DateTime.Parse("2024-08-15"),
		Trailer = "https://youtu.be/4d7xzz0cTVw",
		Images = "ngaiquy.jpg",
		AgeAllowed = 16,
		Status = MovieStatus.isreleasing,
		GenreID = genreData[0].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[0].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC",
		Duration = 81,
		Description = "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích." +
		" Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.",
		StarTime = DateTime.Parse("2024-09-10"),
		Trailer = "https://www.youtube.com/watch?v=chimuoiba-trailer",
		Images = "xich.jpg",
		AgeAllowed = 18,
		Status = MovieStatus.isreleasing,
		GenreID = genreData[2].ID,
		LenguageID = languageData[1].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[1].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "CÔNG TỬ BẠC LIÊU",
		Duration = 113,
		Description = "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông," +
		" Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".",
		StarTime = DateTime.Parse("2024-07-25"),
		Trailer = "https://youtu.be/wqJXnO_TKpY",
		Images = "congtubaclieu.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.isreleasing,
		GenreID = genreData[2].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[5].ID,
		DirectorID = directorData[2].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI",
		Duration = 109,
		Description = "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp." +
		" Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.",
		StarTime = DateTime.Parse("2024-06-20"),
		Trailer = "https://youtu.be/JzY-5ZtVD88",
		Images = "yeuem.jpg",
		AgeAllowed = 16,
		Status = MovieStatus.isreleasing,
		GenreID = genreData[3].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[3].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "SENGKOLO: MALAM SATU SURO",
		Duration = 99,
		Description = "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, " +
		"mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.",
		StarTime = DateTime.Parse("2024-09-01"),
		Trailer = "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi",
		Images = "tetamhon.jpg",
		AgeAllowed = 18,
		Status = MovieStatus.isreleasing,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},

    // 5 phim sắp chiếu
    new Movies
	{
		ID = Guid.NewGuid(),
		Name = "SONIC THE HEDGEHOG: NHÍM SONIC 3",
		Duration = 100 ,
        Description = "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).",
		StarTime = DateTime.Parse("2024-12-15"),
		Trailer = "https://youtu.be/2gFjV9v7QVE",
		Images = "SONIC.jpg",
		AgeAllowed = 16,
		Status = MovieStatus.upcomingkrelease,
		GenreID = genreData[0].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[0].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "BỘ TỨ BÁO THỦ",
		Duration = 120,
		Description = "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ." +
		" Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?",
		StarTime = DateTime.Parse("2024-11-30"),
		Trailer = "https://youtu.be/2k0jK_sWmwE",
		Images = "botubaothu.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.upcomingkrelease,
		GenreID = genreData[1].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[1].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU",
		Duration = 110 ,
        Description = "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu." +
		" Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.",
		StarTime = DateTime.Parse("2024-12-01"),
		Trailer = "https://youtu.be/GKqrTQGHE3s",
		Images = "tretraukhongduaduocdau.jpg",
		AgeAllowed = 12,
		Status = MovieStatus.upcomingkrelease,
		GenreID = genreData[2].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[2].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP",
		Duration = 110,
		Description = "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.",
		StarTime = DateTime.Parse("2024-12-20"),
		Trailer = "https://youtu.be/X3SY9XUlQAA",
		Images = "chuyennhabanh.png",
		AgeAllowed = 15,
		Status = MovieStatus.upcomingkrelease,
		GenreID = genreData[3].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[3].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "404 RUN RUN: CHẠY NGAY ĐI",
		Duration = 100,
		Description = "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển." +
		" Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.",
		StarTime = DateTime.Parse("2024-11-25"),
		Trailer = "https://youtu.be/jS6TZkBB0lY",
		Images = "chayngaydi.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.upcomingkrelease,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},

	//5 Dừng chiếu
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI",
		Duration = 113,
		Description = "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình." +
		" Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.",
		StarTime = DateTime.Parse("2024-01-25"),
		Trailer = "https://youtu.be/JedDZeuTrzQ",
		Images = "cuoixuyenbiengioi.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.StopShowing,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "KÍNH VẠN HOA: BẮT ĐỀN CON MA",
		Duration = 123,
		Description = "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, " +
		"một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.",
		StarTime = DateTime.Parse("2024-01-25"),
		Trailer = "https://youtu.be/EDDbR2jINsQ",
		Images = "kinhvanhoa.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.StopShowing,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "MUFASA: THE LION KING: VUA SƯ TỬ",
		Duration = 118,
		Description = "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, " +
		"trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.",
		StarTime = DateTime.Parse("2024-01-25"),
		Trailer = "https://youtu.be/1KtBhnTfq8I",
		Images = "mufasa.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.StopShowing,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM",
		Duration = 134 ,
		Description = "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình," +
		" buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg",
		StarTime = DateTime.Parse("2024-01-25"),
		Trailer = "https://youtu.be/4pP71_7b_Y4",
		Images = "cuocchien.jpg",
		AgeAllowed = 13,
		Status = MovieStatus.StopShowing,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
	},
	new Movies
	{
		ID = Guid.NewGuid(),
		Name = "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH",
		Duration = 127 ,
		Description = "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, " +
		"đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.",
		StarTime = DateTime.Parse("2024-01-25"),
		Trailer = "https://youtu.be/gnj_VBjwiqU",
		Images = "thosanthulinh.jpg",
		AgeAllowed = 18,
		Status = MovieStatus.StopShowing,
		GenreID = genreData[4].ID,
		LenguageID = languageData[0].ID,
		CountryID = countryData[0].ID,
		DirectorID = directorData[4].ID,
		CreatedTime = DateTime.Now,
		MovieTypeID = movieType[0].ID
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
					CreatedTime = DateTime.Now,
					Deleted = false
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[1].ID,
					ShowDate = DateTime.Now.AddDays(9), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Deleted = false
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[2].ID,
					ShowDate = DateTime.Now.AddDays(8), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Deleted = false
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[3].ID,
					ShowDate = DateTime.Now.AddDays(7), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Deleted = false
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[4].ID,
					ShowDate = DateTime.Now.AddDays(6), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Deleted = false
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[5].ID,
					ShowDate = DateTime.Now.AddDays(5), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Deleted = false
				},
				new Screening
				{
					ID = Guid.NewGuid(),
					Status = ScreeningStatus.InActive,
					ShowTimeID = showTimeData[6].ID,
					ShowDate = DateTime.Now.AddDays(4), // Two days from now
					MovieID = movieData[0].ID,
					RoomID = roomData[0].ID,
					CreatedTime = DateTime.Now,
					Deleted = false
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

			var foodComboData = new List<FoodCombo>
	{
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 1, TotalPrice = 80000 ,Content="Combo 1",Description ="1 bắp 1 cola" , Images = "combo1.png",CreatedTime = DateTime.Now },
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 2, TotalPrice = 100000,Content="Combo 2",Description ="1 bắp 2 cola",Images = "combo2.png" ,CreatedTime = DateTime.Now.AddDays(-1) },
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 3, TotalPrice = 75000,Content="Combo 3",Description ="1 bắp + 1 Aquafina ",Images = "combo3.png" ,CreatedTime = DateTime.Now.AddDays(-2) },
		new FoodCombo { ID = Guid.NewGuid(), Quantity = 4, TotalPrice = 135000,Content="Combo 4",Description ="1 bắp + 1 cola + 1 khoai lắc",Images = "combo4.png" ,CreatedTime = DateTime.Now.AddDays(-3) }
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
			var ticketData = new List<Ticket>
			{
				new Ticket { ID = Guid.NewGuid(),  ScreningID = screeningData[0].ID, MovieID = movieData[0].ID,SeatID = seatData [0].ID, Price = 100000 , Status = ticketEnum.paid , BillId= billData[0].ID},
				new Ticket { ID = Guid.NewGuid(),  ScreningID = screeningData[1].ID, MovieID = movieData[1].ID,SeatID = seatData [1].ID, Price = 2100000 , Status = ticketEnum.paid ,BillId= billData[0].ID},
				new Ticket { ID = Guid.NewGuid(),  ScreningID = screeningData[2].ID, MovieID = movieData[2].ID,SeatID = seatData [2].ID, Price = 3100000 , Status = ticketEnum.paid , BillId = billData[0].ID}
	};
			modelBuilder.Entity<Ticket>().HasData(ticketData);
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