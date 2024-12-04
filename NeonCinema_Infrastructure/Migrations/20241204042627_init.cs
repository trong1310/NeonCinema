using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WebSite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpeningHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClosingHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Countrys",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countrys", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Director",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nationality = table.Column<string>(type: "nchar(256)", fixedLength: true, maxLength: 256, nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Director", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FoodCombo",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false, defaultValue: 0m),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCombo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Lenguage",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LanguageName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lenguage", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MovieType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieTypeName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountAmount = table.Column<double>(type: "float", nullable: true),
                    DiscountPercentage = table.Column<double>(type: "float", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SeatType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShowTimes",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShowTimes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TicketPriceSettings",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceBefore17hWeekDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceAfter17hWeekDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceBefore17hWeekeend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PriceAfter17hWeekeend = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Surcharge3D = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Surcharge4D = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurchargeIMAX = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurchargeVIP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SurchargeCouple = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketPriceSettings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    SeatingCapacity = table.Column<int>(type: "int", nullable: false, defaultValue: 50),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RowNumber = table.Column<int>(type: "int", nullable: false),
                    ColumnNumber = table.Column<int>(type: "int", nullable: false),
                    CinemasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Room_Cinemas_CinemasId",
                        column: x => x.CinemasId,
                        principalTable: "Cinemas",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeAllowed = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenguageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Movies_Countrys_CountryID",
                        column: x => x.CountryID,
                        principalTable: "Countrys",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Movies_Director_DirectorID",
                        column: x => x.DirectorID,
                        principalTable: "Director",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Movies_Genre_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genre",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Movies_Lenguage_LenguageID",
                        column: x => x.LenguageID,
                        principalTable: "Lenguage",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    PassWord = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Gender = table.Column<bool>(type: "bit", fixedLength: true, maxLength: 50, nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOrBriht = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adderss = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RoleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Seat",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Column = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Row = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    SeatTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Seat_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Seat_SeatType_SeatTypeID",
                        column: x => x.SeatTypeID,
                        principalTable: "SeatType",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ActorMovies",
                columns: table => new
                {
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovies", x => new { x.MovieID, x.ActorID });
                    table.ForeignKey(
                        name: "FK_ActorMovies_Actor_ActorID",
                        column: x => x.ActorID,
                        principalTable: "Actor",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_ActorMovies_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CategoryMovies",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMovies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryMovies_MovieType_MovieTypeID",
                        column: x => x.MovieTypeID,
                        principalTable: "MovieType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CategoryMovies_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Show_release",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TimeRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateRelease = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Show_release", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Show_release_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Show_release_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    BillCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Bill_PaymentMethod_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethod",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPoint = table.Column<int>(type: "int", fixedLength: true, nullable: false, defaultValue: 0),
                    DateEarned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Point_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PromotionUsers",
                columns: table => new
                {
                    PromotionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionUsers", x => new { x.PromotionID, x.UserID });
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Promotion_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotion",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_PromotionUsers_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "RankMember",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0"),
                    MinPoint = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    StarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankMember", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RankMember_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WorkShift",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkShift", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkShift_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Screening",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShowTimeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Show_releaseID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screening", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Screening_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Screening_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Screening_ShowTimes_ShowTimeID",
                        column: x => x.ShowTimeID,
                        principalTable: "ShowTimes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Screening_Show_release_Show_releaseID",
                        column: x => x.Show_releaseID,
                        principalTable: "Show_release",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BillCombos",
                columns: table => new
                {
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodComboID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillCombos", x => new { x.BillID, x.FoodComboID });
                    table.ForeignKey(
                        name: "FK_BillCombos_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillCombos_FoodCombo_FoodComboID",
                        column: x => x.FoodComboID,
                        principalTable: "FoodCombo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShiftChange",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShiftName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    NewShift = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    RequetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    WorkShiftID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftChange", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShiftChange_WorkShift_WorkShiftID",
                        column: x => x.WorkShiftID,
                        principalTable: "WorkShift",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreningID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Ticket_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ticket_Screening_ScreningID",
                        column: x => x.ScreningID,
                        principalTable: "Screening",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Ticket_Seat_SeatID",
                        column: x => x.SeatID,
                        principalTable: "Seat",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TicketPrice",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowTimeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketPriceSettingID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreeningID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketPrice", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TicketPrice_Screening_ScreeningID",
                        column: x => x.ScreeningID,
                        principalTable: "Screening",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TicketPrice_SeatType_SeatTypeID",
                        column: x => x.SeatTypeID,
                        principalTable: "SeatType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TicketPrice_ShowTimes_ShowTimeID",
                        column: x => x.ShowTimeID,
                        principalTable: "ShowTimes",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TicketPrice_TicketPriceSettings_TicketPriceSettingID",
                        column: x => x.TicketPriceSettingID,
                        principalTable: "TicketPriceSettings",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BillTicket",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTicket", x => new { x.BillId, x.TicketId });
                    table.ForeignKey(
                        name: "FK_BillTicket_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BillTicket_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Checkin",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TicketID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketsID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Checkin", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Checkin_TicketPrice_TicketsID",
                        column: x => x.TicketsID,
                        principalTable: "TicketPrice",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Checkin",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "TicketID", "TicketsID", "Type" },
                values: new object[,]
                {
                    { new Guid("40006293-826c-4f47-8e1c-f7cf5a77e49b"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("a07c6418-88a9-480f-abd9-edb3a4fcea3f"), null, "mua tại quầy" },
                    { new Guid("77b4fd71-7c20-4232-bbdf-75c1efcc7e24"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("a7c79796-4d90-4f09-ab5a-3efbbd04141b"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("62748bbc-1649-43e7-9f5d-bc219e338600"), "11:00 PM", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5246), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5240), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("13f906e8-fb3e-4be2-8e1f-8451fc8d1569"), "Vương Quốc Anh" },
                    { new Guid("1542000f-dfc6-4b6f-9203-4cfb503e247d"), "Hàn Quốc" },
                    { new Guid("197d0917-2ba7-4202-ab6b-ff7c6ac598b9"), "Pháp" },
                    { new Guid("2cc3ec46-aa03-4334-b6b6-2c6dcaa743b3"), "Mỹ" },
                    { new Guid("4a4353d1-d993-483c-a72d-8ab581260553"), "Trung Quốc" },
                    { new Guid("57c6e914-005b-463b-a147-cecee5ffbe88"), "Việt Nam" },
                    { new Guid("7b63335b-e9a9-41c4-b733-9d0960797cae"), "Hồng Kông" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("ae6d41e9-c2ab-4660-9ee8-fa1c7fdb8b08"), "Ấn Độ" },
                    { new Guid("fc55a49c-6c40-4737-8f10-6d58fb187ebd"), "Úc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("010afa30-37a6-487a-a192-767ea7296803"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("379d577f-90bf-4001-90fd-b60954bcc88a"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("57472fd7-a6a8-4d02-be19-cc7d3f60cd93"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("64341265-9424-4132-b24f-0ef13da155ee"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("75958069-5026-45b5-8080-9ff46dcaf49a"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9083da3c-4a3d-4424-8d36-b35f39a73b7f"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("a503688c-813c-4155-9b13-d72276a8d2a9"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("d5a3627f-59f9-4061-b514-426547be2449"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("e6ba2787-cb8a-4ff8-b19f-80ed9087df61"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("24f68a83-c0e5-4529-ad27-f307067d186e"), "Combo 2", null, null, null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("8c708a83-3f4f-4ccb-a3cc-1a7958573aca"), "Combo 1", null, null, null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("176f6c8e-074e-4f9f-856a-bce976c159d7"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("1b9a46b7-6837-40e3-bb9e-0d28db8fe13c"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("2c0915e5-0663-4cdb-9c31-a76fff740726"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("34ae4bf3-81d2-431b-b824-0a639fe5d226"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("37f9eefc-83a9-4f9d-be62-c00d3912d334"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("8e518039-7beb-47ee-8369-ca4839fb13d9"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("95ee320a-5521-472f-89be-f7e63ee49bee"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("e48e247d-88ad-4380-999a-d953f478e326"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("f26d7b58-3273-4606-8840-1ce930ad84d5"), null, null, null, null, null, "Lãng mạn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("3d528bd1-1736-4144-a840-4aacaf6cc455"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("6242abac-8af5-418a-b381-31bfefcc658e"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("78ec1525-8549-4f0b-82ef-8cb2b9720e06"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("aaed63cf-a73d-4bd6-b421-95137260ee15"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("e303bcd9-6bb5-46e9-a5f9-bb50720eaf1c"), null, null, null, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("bd3b90ce-7064-4d8d-a60f-3258bf632dc7"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 },
                    { new Guid("ced8c8dc-767e-4e9a-8489-a6dc610dd26e"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4242), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4267), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4263), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("8717eb7b-4664-40ce-b39f-3ab38084b717"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5217), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5214), null, null, null, null, null, "Ghế thường" },
                    { new Guid("f7a9bc18-3ea1-4220-a37f-a1ee7ffacaea"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5219), null, null, null, null, null, "Ghế đôi" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2fa9dda0-32b1-4534-b3da-27aeb2da0c46"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("37e1dcee-879e-436a-9686-fb7fdd76ff22"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("4e56ae66-6d47-4845-8117-e2710051ed83"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("7119381c-0c9a-4da9-b5b7-2c081712b71e"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("9b8337f7-0a1d-4f9d-a5e9-f58a774d0ef7"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("a253a506-bf10-4665-8430-e2a1e2e7e605"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("ae7b29a3-da9b-4b46-8240-0f72e2d86269"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("bec15caa-9929-4a16-89dd-5e7558b459ea"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("cc1f4832-a921-458e-b7fe-588f0a1d17b4"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("d4ebf1fb-e06b-4fa6-9828-59f3552a09b7"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, null, null, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("0115da72-2d76-406b-9fed-83770a0b6028"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5931), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("64341265-9424-4132-b24f-0ef13da155ee"), 110, new Guid("176f6c8e-074e-4f9f-856a-bce976c159d7"), "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("1432fa80-d8ba-4c14-926b-7b23ea4ac61a"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5980), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("d5a3627f-59f9-4061-b514-426547be2449"), 100, new Guid("2c0915e5-0663-4cdb-9c31-a76fff740726"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("16cfc6ef-72a8-4e83-b3c6-39525a10ed92"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5962), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("75958069-5026-45b5-8080-9ff46dcaf49a"), 150, new Guid("8e518039-7beb-47ee-8369-ca4839fb13d9"), "5b626704-f3d1-482f-b77c-903284966efa.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("86736908-a3aa-4645-a292-eb7b26c4b935"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5923), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("75958069-5026-45b5-8080-9ff46dcaf49a"), 120, new Guid("8e518039-7beb-47ee-8369-ca4839fb13d9"), "161cd6ca-380d-4627-8071-2d5af03a1cf2.png", new Guid("e303bcd9-6bb5-46e9-a5f9-bb50720eaf1c"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("ae567b22-4eea-4ef1-ae51-f1d817d29141"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5937), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("379d577f-90bf-4001-90fd-b60954bcc88a"), 140, new Guid("e48e247d-88ad-4380-999a-d953f478e326"), "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("af015912-d39b-4230-a5a9-c619124daa44"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5944), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("d5a3627f-59f9-4061-b514-426547be2449"), 125, new Guid("2c0915e5-0663-4cdb-9c31-a76fff740726"), "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("b92bffaf-f37f-4d32-bbd4-628e0b5b1719"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5952), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5914), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "0e9f825c-5346-44f1-a94d-7078909ce83a.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("f248c23a-b48d-4e5b-beee-b8d8315a2310"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5968), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("64341265-9424-4132-b24f-0ef13da155ee"), 130, new Guid("176f6c8e-074e-4f9f-856a-bce976c159d7"), "7502d22a-c967-400c-bc8c-3062d00c7fcc.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("fcf10605-d9ce-4300-bffb-1679703c82b9"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5973), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("379d577f-90bf-4001-90fd-b60954bcc88a"), 145, new Guid("e48e247d-88ad-4380-999a-d953f478e326"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5281), null, null, null, null, null, "Room 2", 0, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(5276), null, null, null, null, null, "Room 1", 0, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("2bd50832-ca9e-4906-9ddd-254cb18ed9f6"), "Hưng Yên", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4915), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("300e5932-ed4e-4293-9cf1-dd51d66c3d93"), "Nam Định", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4935), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4d8822df-e584-4a41-acdf-59ee82e33fcb"), "Thái Bình", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4895), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5e16021d-8a76-44d6-9d24-0454abafd5cc"), "Hải Phòng", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4772), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6ca66297-0bc1-4626-bbb2-d4c13919117d"), "Đà Nẵng", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4794), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6f8fa817-a327-4658-a485-3317e3d35389"), "Nghệ An", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4853), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("841bc285-c4b0-416f-be0c-721b04ea77f7"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4814), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a346656c-9d3a-4a8e-8b11-716e505ce33e"), "Hà Nội", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4378), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bb2e847d-653e-4d81-bd86-ee657b7c8c37"), "Hà Nội", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4746), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ec8a14bd-8bdf-4bf6-82bc-2dc53cbff9ca"), "Bắc Ninh", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4876), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f17ad8fa-c4cc-4c7a-a094-263a9aa89c23"), "Quảng Ninh", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(4954), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("3a86415b-eed2-4eaf-ac58-85f3112c015b"), "BILL005", null, new DateTime(2024, 12, 4, 10, 26, 27, 425, DateTimeKind.Local).AddTicks(6254), null, null, null, null, null, null, 2, 250000m, new Guid("841bc285-c4b0-416f-be0c-721b04ea77f7") },
                    { new Guid("5a460503-7c76-4402-8d3b-5971806e3dee"), "BILL004", null, new DateTime(2024, 12, 4, 10, 41, 27, 425, DateTimeKind.Local).AddTicks(6251), null, null, null, null, null, null, 2, 200000m, new Guid("6ca66297-0bc1-4626-bbb2-d4c13919117d") },
                    { new Guid("7bce3afa-2ff7-435a-8ec0-dd1f711940c9"), "BILL001", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6242), null, null, null, null, null, null, 2, 500000m, new Guid("a346656c-9d3a-4a8e-8b11-716e505ce33e") },
                    { new Guid("a419fc9e-bde6-4874-ac8b-e4dac7abe71b"), "BILL003", null, new DateTime(2024, 12, 4, 10, 56, 27, 425, DateTimeKind.Local).AddTicks(6249), null, null, null, null, null, null, 3, 150000m, new Guid("5e16021d-8a76-44d6-9d24-0454abafd5cc") },
                    { new Guid("af0eb3ba-1f01-4009-8a3f-2178d9fe118b"), "BILL006", null, new DateTime(2024, 12, 4, 9, 56, 27, 425, DateTimeKind.Local).AddTicks(6259), null, null, null, null, null, null, 2, 600000m, new Guid("6f8fa817-a327-4658-a485-3317e3d35389") },
                    { new Guid("b16032f4-59b3-4bb3-ad0d-e9a71cb1e5e5"), "BILL002", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6246), null, null, null, null, null, null, 2, 300000m, new Guid("bb2e847d-653e-4d81-bd86-ee657b7c8c37") },
                    { new Guid("b1ea2632-0633-4fe4-9328-bbc5fa4f1e67"), "BILL010", null, new DateTime(2024, 12, 4, 8, 6, 27, 425, DateTimeKind.Local).AddTicks(6271), null, null, null, null, null, null, 2, 700000m, new Guid("300e5932-ed4e-4293-9cf1-dd51d66c3d93") },
                    { new Guid("dde96cf3-8234-4be4-bcc9-1fe624689e3c"), "BILL0122", null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6261), null, null, null, null, null, null, 2, 680000m, new Guid("6f8fa817-a327-4658-a485-3317e3d35389") },
                    { new Guid("e5de5af1-962f-405d-bd94-e4bf68187bf0"), "BILL008", null, new DateTime(2024, 12, 4, 8, 56, 27, 425, DateTimeKind.Local).AddTicks(6266), null, null, null, null, null, null, 2, 450000m, new Guid("4d8822df-e584-4a41-acdf-59ee82e33fcb") },
                    { new Guid("f937a5ae-a299-4411-a2a5-38467c279f10"), "BILL009", null, new DateTime(2024, 12, 4, 8, 26, 27, 425, DateTimeKind.Local).AddTicks(6269), null, null, null, null, null, null, 0, 350000m, new Guid("2bd50832-ca9e-4906-9ddd-254cb18ed9f6") },
                    { new Guid("ffcee602-3717-49f2-9a66-9a3d18326b7c"), "BILL007", null, new DateTime(2024, 12, 4, 9, 26, 27, 425, DateTimeKind.Local).AddTicks(6264), null, null, null, null, null, null, 1, 800000m, new Guid("ec8a14bd-8bdf-4bf6-82bc-2dc53cbff9ca") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("13fcfd99-c0a4-4173-89be-7e45cc05ae8e"), null, null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6352), null, null, null, null, null, 50, new Guid("a346656c-9d3a-4a8e-8b11-716e505ce33e") },
                    { new Guid("ead1bb56-dea6-4a7d-966b-76ca3a2162ac"), null, null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6361), null, null, null, null, null, 150, new Guid("bb2e847d-653e-4d81-bd86-ee657b7c8c37") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("837f0be7-fd5b-4445-a2e7-c48a01ab41fb"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6332), 1, new Guid("a346656c-9d3a-4a8e-8b11-716e505ce33e") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("01871d81-6705-4510-9a71-ad60ee8ea402"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6060), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 9, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6059), new Guid("a253a506-bf10-4665-8430-e2a1e2e7e605"), null, 1 },
                    { new Guid("10de605d-9e95-432f-bead-f3b1049e32c2"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6047), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 13, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6046), new Guid("4e56ae66-6d47-4845-8117-e2710051ed83"), null, 1 },
                    { new Guid("1619d12b-fafb-4f95-bea6-6fae713d5095"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6042), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 14, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6041), new Guid("37e1dcee-879e-436a-9686-fb7fdd76ff22"), null, 1 },
                    { new Guid("1e308f3f-5c3e-4ce2-91c9-61ec848d46c0"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6056), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 10, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6055), new Guid("2fa9dda0-32b1-4534-b3da-27aeb2da0c46"), null, 1 },
                    { new Guid("4dd618ca-35b8-4f6b-b74d-3cda3b735e5c"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6050), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 12, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6049), new Guid("ae7b29a3-da9b-4b46-8240-0f72e2d86269"), null, 1 },
                    { new Guid("a38d7cd9-a687-4c6c-a17e-3c8476c56121"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6053), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 11, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6052), new Guid("d4ebf1fb-e06b-4fa6-9828-59f3552a09b7"), null, 1 },
                    { new Guid("bfc21cd3-9306-4cd7-a318-7e2167883f3c"), null, new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6065), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 8, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6064), new Guid("bec15caa-9929-4a16-89dd-5e7558b459ea"), null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0194f9d4-d881-432b-a6fe-1bd834e61b35"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("01dfb491-f330-4441-a977-ed822ab3179d"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("03a5eb0d-0a98-437f-873e-cd4ddfc5b6ec"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("06923b61-3cd6-45f2-b423-5bc71bcaa07a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("06d02604-c478-43cd-953f-66827bf629f6"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("083fd0b6-d97e-4078-87a0-4fb72ebae932"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("08b53a1d-bd3c-474e-96ea-fbc291f6571e"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0b6c4eca-9661-474b-afc6-f010096be682"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0c6d3392-e7f2-4231-ab5a-d3f9d2ba8b49"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0d3ce9e1-3f0e-4a3f-b47b-01a077b00d4d"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0d89fa16-ff07-45d4-8622-086f98a0f4fe"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0dc7793d-aa69-47e0-b89b-19cec7bee733"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0e0b76e6-b3d8-4282-ae46-acf57addf050"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0f89ae7b-71cd-48ad-ad10-446b59ddb0bf"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0fd2b6af-42c6-490f-bd89-a99bc7f5e50c"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1199076d-08c4-470b-b74a-e407405869ec"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1353f4ca-ef18-4c03-ab1c-b806621ee162"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("142da1ae-5c28-41af-93a4-bd9a80e8c5cb"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1654e623-6320-42e0-a837-84a3d83ae68c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("191d2047-8c11-45d2-9c69-a81bf2829d5f"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("19f30343-ab4e-4cb1-b312-9bb52d28f1b6"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1be88a39-a1ae-4b47-b319-a390b492cc06"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1d5493a3-5188-4a5c-80f2-a4fc828342d4"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1ec95423-7795-4aab-bbec-6659052d34d7"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("227e3470-6830-45f0-acc2-24829ad50c8d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("240b3ae0-068f-4a61-a3bc-d70a63a52858"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("242dd433-2558-4193-a330-298d0a108677"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("24b51593-5f2f-4f91-9f7f-2d384b786a1e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("258810fb-a1c3-428d-b5b2-46654f2795e3"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("260f2c36-b9c2-40e7-939f-fb0e8fa666e3"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("274f14c9-c726-412a-a92f-6d05650bcc53"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("279679c6-9911-444a-bf01-010bc7482fac"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2844ffc8-1452-4e51-a76d-90b604cc87f9"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2894902d-ee42-427a-a127-ae50cea91d64"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("28e0f2a5-7eb4-4025-925b-173d24d769c2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2a7f0f71-78c2-4109-821e-91ccec5f6be0"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2afc7816-1017-4106-9ac2-699f4bf17b05"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2be06788-323a-4f46-8864-913c51f9e731"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2be0ec55-fc40-4e64-9053-68833438132c"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2cbff2cd-068d-49e4-aec3-778a87cab2b9"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2db70921-715a-4ce1-883d-d9706b2e549f"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("31c27497-81d4-4c1c-abe8-2ccc2dc95b2e"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("31d49071-8702-40c6-bad0-3b07c93038c7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("326d00b1-a2d9-49cb-be2b-d21af7636d5e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3363df88-fde5-40c2-9513-30e2524ef6ab"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("35d0c80a-6e03-46c5-9cf9-38bbe212cca9"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("36fef0f1-2904-4686-bfd6-1e36ed33fcf5"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("380db9fe-fdf1-44b5-b92c-c53fe4b53f32"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("39212356-aed9-4f9b-8b66-7b7e1162a089"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3980fc34-1e7c-42b5-bc7a-107115a1c990"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("39b81d0f-3cd0-443c-b2b2-867ff34c513e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("39f65c16-5895-4086-831a-476c4ce9e258"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3a74c610-5036-4f28-a153-bb7b06b343c5"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3b15d559-d970-436c-990b-f071904b452b"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3b694462-c5e2-4707-ba29-37b6c7932876"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3dc9a441-faa0-4eb7-a29c-daf9f0c43b3c"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3dd8b1b8-12f2-44f3-ad56-2d6cf0483e40"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3e688657-8dbf-4ba7-9ff2-711adcececdd"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3ed5c325-484d-4a0e-b5f8-47352d8194a1"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("417d2d3f-4949-4f97-947d-275c44aed8cd"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4348d312-c6e0-4128-8ae6-9035910ea099"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("43861e6a-4f11-444b-a04b-a7163c4f956f"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("44fae659-46f4-43e7-984b-711b3d07d12c"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("45b1db02-18b9-48d0-bbd5-c9f7e94da252"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4672a7be-6de8-4b4c-90de-a5abca4b8a9c"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("48d0bf3a-6680-4eed-aee4-72f7c7ef1d09"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("49704293-fe35-420a-a41a-6c921be37719"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4a6ab416-ce60-40c6-adf0-dc42ad42a552"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4b86304a-e7dd-412f-9ce7-f23f3d7d3a3f"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c3c507f-50e0-4963-bdd2-87806cdb44db"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c4b4d17-2e00-472a-90cc-a7b9a2220735"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c6ad34d-c012-405f-a15c-6a310af9851c"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c7bd4d4-0271-4426-8faf-81014deb1e4b"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4d9e4670-9262-4282-8731-d8cef5b613a7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4db03d1d-3cbb-4f89-8a20-7c0a14e8abc1"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("53e174cb-5474-47e7-92aa-0a2aab0ce648"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("53ec1a7e-fab9-4b40-927c-6f65cb8952fe"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("55b8a42c-8c9c-4cf9-8795-0ca4dfbebaf0"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("56837ba8-0935-4a70-bc34-7c15a4d6db41"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("57e72c78-9066-4dd6-90ed-9165e455a9bb"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("583f56ae-0b22-4e60-963b-c8e3bfa3c171"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5ac0211a-f9e6-4b42-8e81-879277dcb12d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5c12e0c6-ddc3-4a47-a91a-7b3f17e4a136"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5d3a7098-23ee-4dcf-b1c6-f5876f083a5c"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5d7f961b-6339-4fe2-8b48-b53f46aaf64e"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5d83ccd4-c154-43ca-b52a-6103bcccf36c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5e1830f7-c098-4830-b6c7-0a5f0f486b56"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5e28e3dd-8437-42ab-8072-056a9fcf0e2e"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5fd75b1e-51a7-40c9-966a-2451c7b15bb5"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("611ffa5d-3e0a-4d04-b7d4-ab49ec0441db"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("61d523d0-668b-4d80-80a0-5a825d9d4b81"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("61e781fa-51de-477f-b2f9-c66e92ba3473"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6281b397-1159-4c8d-b4de-14c231952070"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("62c3ad93-437c-4fa4-9fe9-9aa3b4000e5d"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("643c9b62-3c85-47b6-b1fe-70a4f042dd3c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("651e8bea-7dc2-4fcc-bb1e-4a0f96e3666a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("659523c4-3cd7-4a98-a40d-3b0a3b066e03"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("662eb1e0-3935-4852-b278-7a16f0aac705"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("67869ebb-9d03-4eb4-bc20-e6196cda21bc"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("67cb4d60-b5f9-4b00-8bad-31e2c73e4f7e"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("67f79df2-4e06-4f10-87ae-165813fe5104"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("69ba90e2-c055-4f75-b4cf-1467066b99a4"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6abc6bb0-1a3b-4afe-81e4-c5519bf65936"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6b6987b5-7b62-44f9-876a-a79915808bbf"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("70067cfb-4a27-4d0f-bc60-2faa82ad3328"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("71329d46-abde-4458-ab85-bc2fa929e3a1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7197136c-bad7-47a4-8b00-ebd084157798"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("71fab55b-dd4c-453a-85bd-7d311ff0e8c7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("76232d5b-5978-44a8-9f92-abec1e2999fe"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7654fc9d-4ed0-4b97-bb70-7e7e033212e4"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("76ed401e-5704-4d45-bf78-a855b5a393ff"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("78485323-45db-4720-9a75-f7935b9323a2"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("785b3dd4-ebfd-4612-b9e4-a43803c04d94"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("789a80b2-a937-4d2b-bbcc-7f672421558e"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("79dee2bf-d761-4824-8fa7-6a7892c03a20"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7b0cdea6-9241-435c-a6a2-7d348bc64862"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7c01cf55-3cfd-46fb-aa91-5630c57be733"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("810e73a3-46e9-4e7d-9b2e-7c8d0ddc498c"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8309cda2-688f-4115-907c-a3395a41bd21"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8332a097-8caf-4077-9291-c9a2847d8964"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("83ca156d-0163-46af-b989-f69dcb289964"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("840f95e1-3f82-4cf2-a4b3-e03ec9665660"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8437e942-cbe4-45d3-a83c-6ce4efdca8e6"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8453fa3d-c030-4225-8954-7b99740b984f"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("845e1653-2fb5-4de1-b5fd-bfef7563828c"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("848a95ba-033a-4eb0-bb00-f29e870d668a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("851c6a5f-a81a-4ce3-8c3d-fd088c115d59"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("85539c17-026f-49b6-8792-d047d43bbc36"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("86d95dec-38fa-439e-8106-71f862adf060"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("86ed52fb-6c37-4bd5-a11b-d6cdb28e910a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("875c71f8-553e-463f-b69c-ffce8490f8bf"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("879987f0-153a-48f9-82a1-1e46a0b62ba8"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("89147adf-0a04-44b7-981e-866ec1734773"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("89f934df-66d3-4556-8c87-6d3ac18590a8"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8b466897-73e2-47d7-a183-6aef6473c72c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8e32fbd2-a50b-4a39-a95b-9e3f19cdccb3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("902b68d1-1f64-45ae-b054-61e206b0976b"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9040522f-bae6-4800-9e99-32d6b528f7c9"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("907c8d25-b7d6-41e6-9c1e-c1db20745cc2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("907e9b86-37ee-452f-892d-3f154c6b6e60"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9477899a-594d-4fc0-ad5c-6a3583314727"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("95fb1d7a-5a6e-4369-b080-979200f35412"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("96a0c7ce-52f3-4099-93db-50decb2ef43b"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("989d918c-e0bb-4e24-9325-7fa99205bab9"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("98f3a033-ab08-4311-bcfb-8682fd67571e"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9cd18437-560f-4d7c-b82f-cb004daa683d"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9d8361f4-5f4f-400b-9b88-a52c54c40597"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9d95ae16-cad6-463d-b66e-8f72c5b20484"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9daad252-3548-4dca-984a-c8036f4dd44f"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9db587e4-096b-4495-bd05-5465661896a5"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9e3eafd6-ac56-4bfe-b1aa-4b41c1a6bcfd"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9f45b2d0-9edb-42fe-90fa-31a4cc06db0f"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a032b18a-4d78-4a38-b830-29bdeb54e5b1"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a0389c33-5c2b-4fea-92a3-4af25fccec00"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a2ec2d3a-9465-4382-9d60-f0448015c94b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a664cfce-41c2-4f22-99e9-a2f307f605a8"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a711b3f5-3ac2-46f1-b3de-8c8e4851b47c"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a78aca01-a745-41d9-92d8-f0d87a8dc50b"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a7e11b06-7ae5-42ac-a3d9-c71e1e1e2c89"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a8980432-d4d6-4e1a-9b78-e260a2ce73c7"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a9778c51-ee6b-4bc0-be59-776e495fa273"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a980504f-aa49-4f32-a3b1-599322be9a18"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("aa891025-756b-4cd7-a9ea-9a55e38e0e06"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("aa9b109a-6b0c-428c-bbde-f039697d9454"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("abd603a4-e127-4f74-a975-03598977ac85"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ac8e0b13-2721-456a-8cde-51c2849ae0af"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("acd61c10-9906-4947-89a2-f65e205e03d1"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ace7e377-c0c2-4bd5-abab-ba2774e7d5b7"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ad300380-7703-4a48-b018-44eeb6841e9d"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ad7f56bd-d0ad-4681-956a-de9d080ab1aa"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("adcf26a4-a7fb-4ea7-90b1-84317c1b5c87"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ae554b08-a7f5-40bc-ad23-15b9cafd149b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ae5c9a06-6fc8-46cc-b04d-244220fcaa02"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ae9a41c6-10e6-4430-ae7f-ca85b00c8ccc"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("aee32996-622b-4e41-a637-efcbf40ac883"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b058ec23-1b9e-486d-860e-3f6171502f28"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b084f967-c8b2-4459-bc8f-661ec7e1a0f2"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b091f1c2-c710-443a-adb9-f7eb99d28e3d"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b1448214-498e-4f4d-8f53-ce6f441b60fc"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b25a2b16-95a8-4c3e-a690-7f674b7b37c5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b310e555-e4d2-4755-bea6-5d138b03a318"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b471899a-84f4-4b3e-b748-469b4da7364f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b5b21cfd-a4f1-43bd-829f-83d5463b415c"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b5fcff0b-d97c-4a8d-98d5-3b637433b028"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b923e0c7-77d0-406b-9531-b70be948ecf7"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b9e6ff2b-7d3c-4300-8df4-556bfba7dc5b"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ba33affb-edef-4c24-94bd-05e229a6e292"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ba933ae1-4ade-429c-9a33-9eed6b382769"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bc575380-f173-47cc-8689-66e54315a3ba"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bd030ab8-3eaa-4bc9-9ed9-dd8e252b51c7"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("be6f01cc-9659-4e20-808c-a94a13d1f660"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bf90eb2f-5d5d-477a-a1b4-b72c437c027d"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bfbc62f0-17eb-4c1a-8673-c329143656b4"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c0dea2fd-7bca-4802-ad47-ff5feb740777"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c11bda5b-3e39-4ab5-94b8-7226444740ef"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c14a1da1-5a93-46f5-a48a-ab74cd4a25ef"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c27bf718-aea8-4e35-b10c-b802ddee03ee"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c2e7ba95-3583-47c0-bee7-842c6b6168d9"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c3d95292-2452-45f0-9308-698b054f43f4"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c40bf605-7d43-4930-a4e1-b8663413937c"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c5f92988-5cfe-48b7-961d-fcad43762f17"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c6ae1c14-e2fe-4502-9226-7d4294c56d62"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c9862634-9bb1-4789-8f05-0137b0dd8694"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c9c80c8b-e24c-4644-b0d5-23b2577ed3fe"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("caa1efe7-b2a8-4c8f-a9bf-e6d9411b5757"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cb2b6c59-aaca-4644-8f2e-bd7d88077249"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cb84d238-feef-4ca8-83a2-63088fc1c712"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cc97f46d-22de-4346-87ee-0e071e004ef6"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ceb67489-162a-4457-9808-58287887b2eb"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d19e4c3b-2cf1-4bbc-ac04-88d3c7f50595"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d2e8cbf1-fe16-43c4-9e59-c70badb9e50f"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d3326c2b-04a3-4f3b-8452-80ef11449a50"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d47760cb-dbf1-49bb-a421-2a2883c33e1b"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d6589f23-4dce-4530-ba59-ec71b9d114a5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d7dcc49b-b6ba-4433-a1f6-ff08b4875098"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("daaab1b3-4490-4162-9a89-685936ecc23a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("db01fbec-f488-4f07-8c32-7048a225c27f"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dc0291e6-2adf-426f-80b0-fc26aacd877f"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("de292e8a-718d-4432-bc3a-9acd0bf61e37"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("de984dfe-ac16-4d6e-ba92-c911b4de656d"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e11761e5-b56e-438f-88ce-c2935db9f9d0"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e1e06e98-0bfe-42ea-a79c-7c8c5b71eaeb"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e23664b5-c500-48dc-9773-7ead90b183e3"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e23ff475-8427-4675-94fe-2be6b1e4b0b4"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e379e5d5-233b-42c7-b511-617ad15ebd4e"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e3cb3c12-a016-43b4-921e-1fbd37b23673"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e55ae2a8-e0be-4f0b-a249-feed208d8c4f"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e5d0b161-52a0-4a38-90b5-a518145cad22"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e83eec1f-3a96-47d1-8d46-86a49fd42f71"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e88e8fb5-f9f4-4cdb-8f20-3186038dcf78"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e992bc43-f67f-43a6-8e50-4d4c27366b5d"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ecd5a394-76b8-48d1-bf84-a26f74a71e86"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ef95194e-dd91-4c19-ae6d-b61ac7d7358e"), "B", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("eff2e444-a534-430a-8bfc-2cfba013379f"), "J", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f05a2ea9-a05d-4358-9586-adf27aecf162"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f085015b-70f5-4183-bc39-e845bcf235c7"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f3b00d66-d28f-4700-b75c-8d5c714054d6"), "H", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f3d95af8-edcd-44b9-9aef-74b10bb1f566"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f4f5b445-219d-4f1e-936f-b2294c194161"), "F", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f5229878-ceb8-46db-9905-222bddd24fb5"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f5fc0105-6bbe-4cae-915b-b9cdbe57be2e"), "C", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f7ddf20c-1ad3-44b8-a097-20ede00a40a5"), "A", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f80b8f3f-20be-4b4e-9628-e5160ffe2e93"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f99417f5-8cf2-4bfb-baa9-3c4acbf4c2f2"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fa19b776-95cf-45ee-a646-4820583401c0"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fbea6aa9-b3fe-4520-8440-1283550dc66c"), "E", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fc15afc0-acec-436b-a56e-22c6a78596a6"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fc282267-008d-4371-8a07-9d04b1eaa8a3"), "D", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fece896c-6454-43e0-83a8-e0a452107b2b"), "G", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fef49601-61aa-4335-8502-d9a8f120d564"), "I", null, null, null, null, null, null, null, new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("800155f1-c2c0-46df-bbdf-96de70396dee"), null, null, new DateTime(2024, 12, 5, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6017), null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 4, 11, 27, 27, 425, DateTimeKind.Local).AddTicks(6013) },
                    { new Guid("f2dcf050-eaa0-4bff-b4df-576737d750d4"), null, null, new DateTime(2024, 12, 6, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6024), null, null, null, null, null, new Guid("86736908-a3aa-4645-a292-eb7b26c4b935"), new Guid("471e33b7-0d25-44e4-b2cc-f6991fec8db2"), 1, new DateTime(2024, 12, 4, 11, 28, 27, 425, DateTimeKind.Local).AddTicks(6023) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("71f629cd-4d09-4ec4-82de-2e9904904f31"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 4, 13, 26, 27, 425, DateTimeKind.Local).AddTicks(6387), new DateTime(2024, 12, 4, 9, 26, 27, 425, DateTimeKind.Local).AddTicks(6386), new Guid("a346656c-9d3a-4a8e-8b11-716e505ce33e"), new DateTime(2024, 12, 4, 11, 26, 27, 425, DateTimeKind.Local).AddTicks(6385) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("7bce3afa-2ff7-435a-8ec0-dd1f711940c9"), new Guid("8c708a83-3f4f-4ccb-a3cc-1a7958573aca"), null, null, null, null, null, null, null, 0 },
                    { new Guid("b16032f4-59b3-4bb3-ad0d-e9a71cb1e5e5"), new Guid("24f68a83-c0e5-4529-ad27-f307067d186e"), null, null, null, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("9c253c50-542a-4ad9-b9fd-1e41f6b6526f"), null, null, null, null, null, null, null, new Guid("d90fdffa-fa8f-4871-a057-636cf571d619"), 100000m, new Guid("1619d12b-fafb-4f95-bea6-6fae713d5095"), new Guid("a9778c51-ee6b-4bc0-be59-776e495fa273"), 2 },
                    { new Guid("c85cb4c3-6d68-4c86-adfb-b0bcc38c839d"), null, null, null, null, null, null, null, new Guid("86736908-a3aa-4645-a292-eb7b26c4b935"), 2100000m, new Guid("10de605d-9e95-432f-bead-f3b1049e32c2"), new Guid("db01fbec-f488-4f07-8c32-7048a225c27f"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("a07c6418-88a9-480f-abd9-edb3a4fcea3f"), null, null, null, null, null, null, null, 50000m, new Guid("1619d12b-fafb-4f95-bea6-6fae713d5095"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("37e1dcee-879e-436a-9686-fb7fdd76ff22"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("a7c79796-4d90-4f09-ab5a-3efbbd04141b"), null, null, null, null, null, null, null, 60000m, new Guid("10de605d-9e95-432f-bead-f3b1049e32c2"), new Guid("8717eb7b-4664-40ce-b39f-3ab38084b717"), new Guid("4e56ae66-6d47-4845-8117-e2710051ed83"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("7bce3afa-2ff7-435a-8ec0-dd1f711940c9"), new Guid("9c253c50-542a-4ad9-b9fd-1e41f6b6526f"), null, null, null, null, null, null, null },
                    { new Guid("b16032f4-59b3-4bb3-ad0d-e9a71cb1e5e5"), new Guid("c85cb4c3-6d68-4c86-adfb-b0bcc38c839d"), null, null, null, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_ActorID",
                table: "ActorMovies",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentMethodID",
                table: "Bill",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserID",
                table: "Bill",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BillCombos_FoodComboID",
                table: "BillCombos",
                column: "FoodComboID");

            migrationBuilder.CreateIndex(
                name: "IX_BillTicket_TicketId",
                table: "BillTicket",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovies_MovieID",
                table: "CategoryMovies",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovies_MovieTypeID",
                table: "CategoryMovies",
                column: "MovieTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Checkin_TicketsID",
                table: "Checkin",
                column: "TicketsID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CountryID",
                table: "Movies",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorID",
                table: "Movies",
                column: "DirectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_GenreID",
                table: "Movies",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_LenguageID",
                table: "Movies",
                column: "LenguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Point_UserID",
                table: "Point",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionUsers_UserID",
                table: "PromotionUsers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RankMember_UserID",
                table: "RankMember",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Room_CinemasId",
                table: "Room",
                column: "CinemasId");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_MovieID",
                table: "Screening",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_RoomID",
                table: "Screening",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_Show_releaseID",
                table: "Screening",
                column: "Show_releaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Screening_ShowTimeID",
                table: "Screening",
                column: "ShowTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_RoomID",
                table: "Seat",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Seat_SeatTypeID",
                table: "Seat",
                column: "SeatTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftChange_WorkShiftID",
                table: "ShiftChange",
                column: "WorkShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Show_release_MovieID",
                table: "Show_release",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Show_release_RoomID",
                table: "Show_release",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_MovieID",
                table: "Ticket",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ScreningID",
                table: "Ticket",
                column: "ScreningID");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_SeatID",
                table: "Ticket",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPrice_ScreeningID",
                table: "TicketPrice",
                column: "ScreeningID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPrice_SeatTypeID",
                table: "TicketPrice",
                column: "SeatTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPrice_ShowTimeID",
                table: "TicketPrice",
                column: "ShowTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketPrice_TicketPriceSettingID",
                table: "TicketPrice",
                column: "TicketPriceSettingID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleID",
                table: "Users",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkShift_UserID",
                table: "WorkShift",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "BillCombos");

            migrationBuilder.DropTable(
                name: "BillTicket");

            migrationBuilder.DropTable(
                name: "CategoryMovies");

            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropTable(
                name: "PromotionUsers");

            migrationBuilder.DropTable(
                name: "RankMember");

            migrationBuilder.DropTable(
                name: "ShiftChange");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "FoodCombo");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "MovieType");

            migrationBuilder.DropTable(
                name: "TicketPrice");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "WorkShift");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "TicketPriceSettings");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "SeatType");

            migrationBuilder.DropTable(
                name: "ShowTimes");

            migrationBuilder.DropTable(
                name: "Show_release");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Countrys");

            migrationBuilder.DropTable(
                name: "Director");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Lenguage");

            migrationBuilder.DropTable(
                name: "Cinemas");
        }
    }
}
