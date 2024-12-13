using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Innit : Migration
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
                    AmountMax = table.Column<double>(type: "float", nullable: true),
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
                name: "SeatShowTimeStatuss",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowtimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    seatEnum = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_SeatShowTimeStatuss", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SeatShowTimeStatuss_Room_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Room",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatShowTimeStatuss_Seat_SeatID",
                        column: x => x.SeatID,
                        principalTable: "Seat",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeatShowTimeStatuss_ShowTimes_ShowtimeId",
                        column: x => x.ShowtimeId,
                        principalTable: "ShowTimes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("6ab2e5e2-4d6e-412e-a79b-a49272ac6e1e"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("84f9296d-1517-4230-9246-21f1445fd0b5"), null, "mua tại quầy" },
                    { new Guid("81ce8735-9329-4252-916a-57041fc735d8"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("839bf7df-2262-4197-b21e-2d3ee47ac425"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8432), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("b135b583-f09a-4288-8b77-88d8247ddfc0"), "11:00 PM", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8436), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1430e22c-f978-493f-99a3-9b238964638e"), "Hàn Quốc" },
                    { new Guid("1b895c95-3250-4537-9951-13addb26d5f7"), "Việt Nam" },
                    { new Guid("24ac6e61-ef56-4de7-88cc-eb42c4251803"), "Pháp" },
                    { new Guid("322615a4-78b3-4bfe-85f3-8c6268514f44"), "Úc" },
                    { new Guid("40a7302c-0e50-445f-9d9a-5f3ae70ce123"), "Hồng Kông" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("b688b16b-8e7b-418c-9cbf-049492427a85"), "Vương Quốc Anh" },
                    { new Guid("b9e0c259-437b-474b-91a3-20e7ff186888"), "Ấn Độ" },
                    { new Guid("cdf130f4-2a54-4d0c-84ee-bf1b41349a6c"), "Trung Quốc" },
                    { new Guid("f0a411c3-41b0-4217-be55-d9aca5dd3a67"), "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("3798d378-01d4-41e8-ab2e-8f09497804ee"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("5b7065e5-057e-4bf6-bc4f-2208cd0355db"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("76dfacba-663d-472e-9223-e81474328b85"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("7e4d2663-a4ec-41c3-a567-9c1bfa4883d9"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8cfff192-a0a0-4548-b9cb-499fd3514e3a"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("925d6285-6c00-404f-81aa-b8d3c252c13a"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9716363d-b768-437f-a6de-296f43adf745"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("cbfd749b-b5ec-4b3f-bc15-c634956ff569"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("cfa87743-7d54-4f1c-97eb-e3d478c68a14"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("03803032-310c-45b4-b574-190149259681"), "Combo 2", null, new DateTime(2024, 12, 12, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9837), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("13f13397-5e1d-4173-920b-df9cfdafd383"), "Combo 1", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9833), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("21be93d9-9e84-4985-8f45-25daf48133ce"), "Combo 3", null, new DateTime(2024, 12, 11, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9840), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m },
                    { new Guid("a08d1991-2285-4571-acda-3707466840b3"), "Combo 4", null, new DateTime(2024, 12, 10, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9843), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("349539b3-0e64-44e4-bb16-f3832f115d5b"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("734c154c-18cc-4189-8902-0cacf49d6156"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("7ff8711a-c854-4f00-a382-2479de9e083b"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("91282823-5bc8-4862-b2b8-837046fe227a"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("929f913d-4a27-467d-ae4b-c2d9d6a4a509"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("a0fc1282-706e-44bd-9109-2adc6a2f50f8"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("a64fc51c-8f36-4352-9504-ab0544898da4"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("b24165dd-8526-4695-be15-36b4da8f9d92"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("e5fa160b-5d7f-44c0-b6c5-4564c6cbf76e"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("53851b88-7523-49dd-91db-2be5da59d2b2"), null, null, null, null, null, "USA", null, null },
                    { new Guid("72ed3f09-f614-4d03-a0cd-fd9f62b20b03"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("8a7258ce-f404-42c8-88b7-57c41d53e6f6"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("a830e0d6-bd82-43fa-8161-2ca27a5dc0be"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("e63012ee-a713-460d-81ec-97dce6338d66"), null, null, null, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("4dc6ac16-cb5f-4ebd-8479-0d44aaee98fc"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("a2b44013-3bfc-451b-bb47-d93bd508a2b0"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(6660), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(6710), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(6706), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("16fab0a5-c0e5-4e4d-a92c-9f10c6b6802c"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8396), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("802c1bae-c27f-4c9e-97ed-5b94a160d380"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8398), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8389), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("4d9cc1c7-d99a-4be7-80dc-23f2f0af4bda"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("4f460804-c903-4262-8728-165da509e836"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("595df1df-073e-4cd2-af05-4f3c0e6b5acd"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("741b3e6a-6955-49c8-9e13-93eecd7ad163"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("7d058b72-849e-4a83-9191-4d27fcfd0779"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("7f716a45-b6c5-4083-bad9-b54401324bc3"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("8ac89615-ed0e-4ed6-a6d3-0c340ae1fdd0"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("a3514f75-a49b-4fcb-afd7-90b54e34e468"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("e7f3f86d-bd5d-4827-a0c5-ebe918b593fe"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("f0224c98-37b0-41e0-abb0-66e3f56b2c57"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 }
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
                    { new Guid("159508aa-249b-479d-8e6a-afe0dd781b76"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9441), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("8cfff192-a0a0-4548-b9cb-499fd3514e3a"), 125, new Guid("e5fa160b-5d7f-44c0-b6c5-4564c6cbf76e"), "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("28be9eb3-8c98-46b9-aba5-050d9f5eee2f"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9485), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("9716363d-b768-437f-a6de-296f43adf745"), 145, new Guid("734c154c-18cc-4189-8902-0cacf49d6156"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("5f609da4-2b3b-4894-8335-8f00f47c9500"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9454), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("6517b964-1562-48f9-ad7f-e82957512887"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9433), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("9716363d-b768-437f-a6de-296f43adf745"), 140, new Guid("734c154c-18cc-4189-8902-0cacf49d6156"), "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("9487e234-5862-48e1-8268-50a984cc1b67"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9471), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("76dfacba-663d-472e-9223-e81474328b85"), 130, new Guid("91282823-5bc8-4862-b2b8-837046fe227a"), "7502d22a-c967-400c-bc8c-3062d00c7fcc.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9381), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "0e9f825c-5346-44f1-a94d-7078909ce83a.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("bb85ffe0-61ab-403e-9285-0bf08869ea63"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9393), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("925d6285-6c00-404f-81aa-b8d3c252c13a"), 120, new Guid("b24165dd-8526-4695-be15-36b4da8f9d92"), "161cd6ca-380d-4627-8071-2d5af03a1cf2.png", new Guid("72ed3f09-f614-4d03-a0cd-fd9f62b20b03"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("c2798649-1d7a-46f3-9397-9b736b23e972"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9402), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("76dfacba-663d-472e-9223-e81474328b85"), 110, new Guid("91282823-5bc8-4862-b2b8-837046fe227a"), "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("c70499b3-9b06-4daf-9d9d-ed3c52f2f56d"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9462), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("925d6285-6c00-404f-81aa-b8d3c252c13a"), 150, new Guid("b24165dd-8526-4695-be15-36b4da8f9d92"), "5b626704-f3d1-482f-b77c-903284966efa.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("caaeb783-5b2b-409b-a8df-08ed09f656f9"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9507), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("8cfff192-a0a0-4548-b9cb-499fd3514e3a"), 100, new Guid("e5fa160b-5d7f-44c0-b6c5-4564c6cbf76e"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8478), null, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(8485), null, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("12931e77-0b38-4f99-9e0d-aad2dcea36e9"), "Hưng Yên", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7891), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1327b38f-5095-49b2-911f-d9182a7c741e"), "Hà Nội", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7098), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("228835c8-0da4-452b-84d5-11d662cd859d"), "Hải Phòng", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7636), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3d164abd-177f-46b4-a883-b0e51b017dc9"), "Nam Định", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7923), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("44559344-807d-4e4f-b993-5ebc05b2aab6"), "Thái Bình", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7846), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("75239abc-3aea-4966-bb8f-7f691c98eebe"), "Bắc Ninh", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7814), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("88d4d9fc-df7e-40af-8983-222b9c516a28"), "Hà Nội", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7583), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a217fcb6-40c1-427e-8012-d5b47d063d13"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7747), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c007c310-42f9-4db1-8345-60d0a38d71b8"), "Nghệ An", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7783), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ca0c10af-9b78-4b1f-a504-a4c38ed86f0a"), "Đà Nẵng", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7704), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ff5421a4-6cf0-49d9-8fa5-f7e990fec007"), "Quảng Ninh", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(7992), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("012a94c2-3246-4da6-9f2d-65a5df534f37"), "BILL004", null, new DateTime(2024, 12, 11, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9929), null, null, null, null, null, null, 2, 200000m, new Guid("ca0c10af-9b78-4b1f-a504-a4c38ed86f0a") },
                    { new Guid("110fb5b2-74f6-4998-8ca5-516ca8d69918"), "BILL010", null, new DateTime(2024, 12, 7, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9964), null, null, null, null, null, null, 2, 700000m, new Guid("3d164abd-177f-46b4-a883-b0e51b017dc9") },
                    { new Guid("1b8bbbbd-dac6-40bb-8681-488993ea4545"), "BILL001", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9918), null, null, null, null, null, null, 2, 500000m, new Guid("1327b38f-5095-49b2-911f-d9182a7c741e") },
                    { new Guid("593bafa1-20b8-4756-845a-2c9aedd9f1ec"), "BILL009", null, new DateTime(2024, 12, 5, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9960), null, null, null, null, null, null, 0, 350000m, new Guid("12931e77-0b38-4f99-9e0d-aad2dcea36e9") },
                    { new Guid("958931f8-5db7-495e-87db-0dced4119c58"), "BILL0122", null, new DateTime(2024, 12, 9, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9947), null, null, null, null, null, null, 2, 680000m, new Guid("c007c310-42f9-4db1-8345-60d0a38d71b8") },
                    { new Guid("95bd366a-e2e3-415a-9ba9-182692c95257"), "BILL005", null, new DateTime(2024, 12, 10, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9940), null, null, null, null, null, null, 2, 250000m, new Guid("a217fcb6-40c1-427e-8012-d5b47d063d13") },
                    { new Guid("b324957f-bf6e-4172-b24d-43cc5a90d70e"), "BILL008", null, new DateTime(2024, 12, 3, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9956), null, null, null, null, null, null, 2, 450000m, new Guid("44559344-807d-4e4f-b993-5ebc05b2aab6") },
                    { new Guid("c1ed6955-5989-4bcd-b41f-40bba2cf7ea5"), "BILL003", null, new DateTime(2024, 12, 12, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9925), null, null, null, null, null, null, 3, 150000m, new Guid("228835c8-0da4-452b-84d5-11d662cd859d") },
                    { new Guid("c552a5c9-5fc7-4ad5-81c8-be78c007f9c2"), "BILL007", null, new DateTime(2024, 12, 8, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9951), null, null, null, null, null, null, 1, 800000m, new Guid("75239abc-3aea-4966-bb8f-7f691c98eebe") },
                    { new Guid("d84b4305-d9b2-4504-a82c-9dfb5a597a74"), "BILL006", null, new DateTime(2024, 12, 9, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9943), null, null, null, null, null, null, 2, 600000m, new Guid("c007c310-42f9-4db1-8345-60d0a38d71b8") },
                    { new Guid("d9d75d3a-e657-4401-ac30-6b3a5f386483"), "BILL002", null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9922), null, null, null, null, null, null, 2, 300000m, new Guid("88d4d9fc-df7e-40af-8983-222b9c516a28") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("38653bb2-b4df-430b-bb95-bcdda89cb155"), null, null, new DateTime(2024, 12, 13, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(110), null, null, null, null, null, 50, new Guid("1327b38f-5095-49b2-911f-d9182a7c741e") },
                    { new Guid("9b0beb91-1b3b-4bbd-9e6e-6a8215b25b06"), null, null, new DateTime(2024, 12, 13, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(114), null, null, null, null, null, 150, new Guid("88d4d9fc-df7e-40af-8983-222b9c516a28") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("76eb5f1a-29f0-40f1-8f2f-32f9615c8977"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 13, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(83), 1, new Guid("1327b38f-5095-49b2-911f-d9182a7c741e") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("13a8a1f2-31bc-4f1f-a992-dfb6dba4f860"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9603), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 22, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9601), new Guid("595df1df-073e-4cd2-af05-4f3c0e6b5acd"), null, 0 },
                    { new Guid("27c933a3-3c3c-4f83-bb68-0357af9c6b35"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9597), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 23, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9595), new Guid("4f460804-c903-4262-8728-165da509e836"), null, 0 },
                    { new Guid("4b967311-62c5-4163-a328-722f2ce524b0"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9632), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 18, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9630), new Guid("7f716a45-b6c5-4083-bad9-b54401324bc3"), null, 0 },
                    { new Guid("61b01e79-f6ce-4a61-9c2d-a2e5da9907e5"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9627), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 19, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9625), new Guid("e7f3f86d-bd5d-4827-a0c5-ebe918b593fe"), null, 0 },
                    { new Guid("a78fe708-0924-4edc-96ac-7e3372d79a9c"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9637), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 17, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9636), new Guid("a3514f75-a49b-4fcb-afd7-90b54e34e468"), null, 0 },
                    { new Guid("ba5c1568-b109-45e6-8472-ed16fee0cd3f"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9607), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 21, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9605), new Guid("741b3e6a-6955-49c8-9e13-93eecd7ad163"), null, 0 },
                    { new Guid("c72e2076-6edd-4c25-8fc1-058e89ba6e41"), null, new DateTime(2024, 12, 13, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9619), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 20, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9618), new Guid("f0224c98-37b0-41e0-abb0-66e3f56b2c57"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("009cce4e-8d9c-42b8-81ae-fc6f261368f1"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0148ccbd-5904-4c73-be7e-af93d3900c58"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("01f7b356-9522-4d28-b978-1615d31c0a88"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02023110-068d-4cb3-b748-25ce564ee369"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0278521c-3606-4451-a2eb-be0175b47397"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03094d76-d303-4d7c-a324-5bfd13c5d980"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03859422-1365-449b-9b1e-60d13413af61"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0407b7ac-8fc5-48e1-bcf0-f1aacaf7ba25"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("045f20b1-f008-4ac3-a4ff-4c789116d90a"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05739882-83e5-48f1-8dd3-61753963a34f"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("07a2a44b-e1a0-4977-888d-6e338060ac1a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("095aa678-bbc5-4178-8b42-d6f0289f62d8"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cc39225-5093-4641-8a94-a672289632ea"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e457c68-bad7-43a0-ade3-8a050c4eb01b"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e6b484b-f594-4de1-9306-0b8973779287"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f29d753-909a-4641-a71c-1d8f678dc2a1"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10c3cb63-74f8-4478-a179-d28519ebb905"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("114f76b4-b674-4e96-9fc1-bee2fd230765"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("121695d3-ed59-4458-94fe-148e437f3dd5"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1357a8b8-4a74-4006-a049-743b30a22149"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1402912c-885a-4fd6-8ce0-31174dd5cafb"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1456ba4b-ff66-489b-aca1-6ab84ce32874"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15314ade-934e-4d0f-be81-3868f16d84e2"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15576908-aa5a-4b46-8f2e-930047192e17"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("176d5029-824e-4544-a937-3027a0b1951a"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("193e6609-0ee1-4f86-a1c0-efe21ce5a6d0"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a2bedfa-044c-4f56-9483-e6073f5ba984"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a9745e6-e600-4659-ac47-381168a3b0fd"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b4b06a9-4fe2-4ee1-9587-cfc1f7f2486c"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c851638-4610-4a4a-9f11-fa8e3b7a5a09"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cd03ed2-0c33-4c3a-aff3-b704be551bd3"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d51f32b-f6f5-433a-bb5c-a61e86ea0912"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("207f2b7f-4542-4f2b-b652-ac2e069fe000"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20c9399e-f6fd-4914-bc05-1f051c7cde14"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22c43047-2cf1-4879-bf09-0baafb20d50f"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23ed2cc4-284a-4c65-b268-2a12ba0b16c8"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24600742-579f-4cfc-b70c-e474c97ecf8e"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24b2c774-4d5b-4eb3-a94c-ef85e4713644"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("272de1a7-0aa9-43d8-8180-b2f23f347af2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("284f2c4b-608f-4bf3-a65f-8d3c030ce324"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("290f6b87-703c-4be5-9237-8c4d24bbb478"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("296cd125-712a-4062-a037-87bd73c8474d"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a21d15b-f5e1-4180-a608-215bcf71539d"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a9d3c82-011b-4192-9445-8811dd784043"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ac2afac-427e-4c62-a411-9c7717f8f390"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2aecff41-4166-4f7f-b1c9-4bda3bc5c80b"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c8daf8c-bf67-4318-a8d3-f3168f812f3c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d0333cf-1f26-4f47-bdb6-476ac510b8bb"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d11a876-8ccb-48d3-b531-3dcb5e5cbab5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f96dee6-73d4-4d3d-8f2c-7d22f0aca279"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31394118-87a0-4f5d-ba32-be24b667cff7"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36577d83-4ae5-46ca-8acf-5049544e8e87"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("396a2baa-669c-4650-afd7-815b8e7fe36d"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39d8956b-d642-44b0-92e0-5a9cf81a1441"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39dd65bd-460d-4847-b087-ce72dce8b996"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bbba2bb-87f1-4e0a-83ec-bb0f83db575e"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bd4f010-38bf-4b88-9852-6a26aef777ef"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3dc3b774-3a6b-4c38-b0ef-ec1a8c73da53"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e0540d5-a55e-4719-9554-efec3952d8a9"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e1de3d2-59d6-47d6-b03a-874dd2fcb189"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e4ed93e-8de7-4a02-be40-17d1ac3020b1"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40f818fc-8e1a-452f-b58b-66f00eca4cff"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("416537aa-011f-48d5-9b71-cf5a144d6a00"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("421d2256-8b3e-4d0a-bd38-781eb87f273e"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("427c925e-8cef-4226-b651-55f64d7ed0dd"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("437d2b60-da1e-4e10-8aff-037bb7d9e412"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("444b5889-1ef9-4105-87da-559425adbc55"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46504975-03d1-48d7-a4ca-1905e720d0ff"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4758c08e-3382-4333-b95d-2d9c119f6b45"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4845bc14-b9ab-49d7-81ae-c15425c17a8b"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48804830-d6f4-450a-bc07-04166dee939b"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4aad32b3-f194-4724-9e38-a6653490effa"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52e8fd90-176a-4cd7-bbfc-474fdaa2f5a5"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5472e1ca-83a1-4b6e-a1ba-f9290d2156ac"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("561407cb-b1ef-462c-abb3-6f15daccd0d5"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("570988db-0cad-465c-8814-df95b58c6051"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("571fe344-4e9e-493c-95c8-4f18abd7766a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5972024b-108b-42aa-89b0-78a930d5042d"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59f50166-344e-45d4-bb48-dcd176a5561b"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5aa498e5-482d-4ab1-8294-66995dfc7b7e"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c59991e-c2ab-46dd-914e-d73879d0dc9c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e86c0ec-f0da-42af-87db-15add39e4f84"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ee8e5d4-2e7c-486e-b3d6-8ba52e821190"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fb25768-d377-4f73-bfe2-55b180d24627"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60d5c1a8-3ab2-4163-911c-99ed3666c889"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("622cf5b6-02d2-476f-8021-f3ff3d202144"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6297c7cf-3675-4660-a6fb-46395c12aaed"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("631eeaed-cacb-4de7-b8a4-1e214b124b13"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6db12a1b-bb2e-4120-86b4-de1a51f6c744"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e151ac9-7994-4d52-869d-50a1d795f07c"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ea970a0-aae6-4fd6-b075-689366602369"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7053db67-6b2c-404f-9054-73be45081ca9"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7089963a-bb1c-46f0-85a5-eb6459a3d6f7"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71f61938-ff76-4678-90d3-28304e07bbdd"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73427ddd-83a0-4a0e-a2ef-77d46f1d1922"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74527fe4-ef0b-45f2-8c72-bd02573a557c"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74ae087f-b910-4c11-8a6c-7a53afac1ed8"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7549dc3a-a0a3-4309-b966-f5413a3017c2"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("792805f9-84c8-41d8-911b-3ac7b2157d2c"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a45f035-329b-4c12-b23a-705128ee506e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a968e62-5943-4247-93c9-265620148a4a"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b9e9574-cddd-42a5-986a-b60e18220908"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c19ca38-2279-4815-9637-a821f087f255"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d3473b3-545a-40a0-b1f5-32afa44e7c8b"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e1fa55b-9ae2-4c53-99d4-db3160da189e"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f68d3e2-75fb-4d39-bc4d-a5e4cb50c33e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fc65122-2716-45d1-8514-34444d3de230"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fda796c-d7f0-4418-a5a7-33d727bf701b"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7feef56f-a181-4d4a-b075-f82120eb757e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8062b696-3d58-4e4e-861f-cc2f6a8d3659"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("846ee792-782e-45b4-8044-33ac8843cf89"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8565db6b-bb0b-46c8-a084-3607259b70ae"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("856acca7-064b-42e7-9765-aa8eb72dd3dd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("866b950b-b897-40e8-84c9-a9f4250fedf8"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8770e73b-f13d-48b8-84dd-38dc5e9f11ce"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("883bd3f9-6cae-46df-a041-3c45285c6d76"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88ce25b7-4cd9-4cad-8daf-c75435eb0ddc"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89003966-8f11-4ca3-b456-c3f1350dfc19"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c15c94d-3baf-4e4e-9413-912a2f2a5db4"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c5bb988-80e8-4b1e-88ed-15a7e8eb0df5"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c9d6910-a7ea-4a70-8661-ba3cf74425d0"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8cda4ef9-a1fc-4ef1-9ea1-f1fc61b8d8bc"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d8055b9-1bb9-449f-ae75-2959663d86e9"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d9474e5-0291-4bd2-8a2a-40d9f28fb228"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d9e6349-c781-41e7-8a7f-d3633429e0af"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8dac88e6-d9f4-458d-a617-1af92e299770"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8db4efe2-bf40-42c2-9342-32c708225e31"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8def5df1-c7fd-46cb-b368-67e27b5a86c1"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e7f9d5e-0456-4ffe-846f-18747e3857e5"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9020ecf3-6ed0-4e51-b414-19b9daee0b40"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("906db6fa-9838-4a7e-bb3d-1c489f2625fa"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("914d855d-cf89-48e0-9bf8-1464ee4054d4"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("915a8a2f-08b2-49a8-9d1f-76f8d45856d6"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92006581-8281-4436-be74-0d5f6a1e664e"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("920af02a-fc2a-4a2c-b364-bef987859457"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92a36bf8-288d-46ed-8488-e8d7c79f95b7"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9337b2c0-8e22-4cf4-8f4b-5d585d812c37"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("937652e5-1f46-4da8-a816-6b53019c958c"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("938095db-8ffa-48c1-bb2a-9c625404cf89"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93db22d6-4d0e-415b-9653-751c1af228e0"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93f2551d-0a8c-434b-93ce-9429c350b195"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95e340a0-15b6-47b1-bc4b-d04a27eaba1d"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95e4efba-40eb-42e4-be45-4223a8f4700a"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95eeb7f1-f542-484a-809b-50012bd566e9"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("988be1a6-0ae0-42c5-a15e-d4e0e726e371"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b655648-0c99-4bb5-bed4-92348741fbee"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bbb828c-2da7-4a5a-a5f0-c4bbd2226b49"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c0f99f2-ee41-49a4-b6f0-83f3026eb1a9"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cb68129-a9f2-4316-9957-8a8d65305337"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d74dbb2-38f8-45de-98e2-58ddcf433fcc"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a136adfe-d6d1-43df-b929-a266cd771a84"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1a39f09-e515-4410-8403-1ac18e9951c1"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1c74575-43d9-4481-bc5f-cd98417b3dd3"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a491fc19-8ac9-4b57-9f48-977cc1f6088d"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7e10cd5-fada-4a68-af60-db25cb74ac53"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9a9c4ce-28b8-4914-98bd-73d98860244b"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9ab7e37-88ac-48db-a3ed-fb2ba06497e3"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aaded598-faf1-428d-a228-6a1195a19f4b"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab7763b0-cb49-4c64-8c44-969a05660f6b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad74768f-d8aa-4c88-b741-1aa7ce717951"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aeec7c2d-4ef1-4b44-87c0-3acbf7683d77"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("afc69caf-3287-4b02-a364-4a6ce3659f8d"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b011e3cb-12b1-4ee2-b36a-8cf48a1013ff"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b45fcc48-57aa-40ad-b426-c4478dd52b06"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b48af42a-6566-44de-a422-4bdf0a87afea"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5085513-c9cc-4104-bbcb-373a3e25d830"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b57abfec-dd42-4f73-9ba5-093f77156e18"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b58684b4-bb43-4352-a4d4-5a418eda11f6"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5ed982e-36c0-48ef-afe1-d358105afd30"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7419040-2ea5-47b3-8efc-9b74784d3815"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b758b64c-2770-46dc-ac16-b8442e5d8a39"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7cf7fa5-d19d-4211-a0db-fad8bba92f67"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba04212e-d7d4-404d-889f-9cefcb5fe828"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc68c751-043a-466e-865a-4e80ad37166f"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd17f8c4-5f20-425d-af93-944927037b0e"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bda67b63-1ffe-40be-a08d-c255862c68df"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be7184d4-b4ff-4804-a4ae-302cfc6e771f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf2d041a-cd73-45b4-b09e-ab3fb7b9fe4b"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf8cbcd1-161a-43b5-9fa0-f33354b044bf"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0aeb433-0b1f-44a3-b1ca-1a761b44a048"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c38ee6ac-058f-4d05-9c19-1eb7e2ab0154"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3b4c8ec-4f18-4a2b-b6ac-97e5249cfb54"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3f520bf-2067-4bcc-832b-99d8f2d13d2d"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c677f70e-d9a5-4d82-a42c-eafea7d36eec"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6fbd62b-9c8e-4079-9019-30a45bdec3d8"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c79339ac-4a18-4be5-b987-e5cfe64b9336"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c86f4dfc-8119-4845-b76a-2f057757c959"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca3a9f7c-d8ff-4eb0-aeaa-1a1a9bd57282"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca46ec95-f21a-4bd3-8c35-4035c0ca4ea3"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca744bb2-9e5a-4349-9744-f4330223b260"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb116f04-db17-4955-9ff6-ccb2b214b91c"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbef4491-c9ec-4299-b5aa-4b623807fca4"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd4c18bc-d6af-4a01-bc00-cb16905a852b"), "G", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfca3455-8b7a-45cd-bc4b-5c2b3f9101d7"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0153871-7dcc-4dc3-b8dc-9969b6b7182e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6dd7106-e4f3-4f1d-bf61-aabb667a19fb"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7048251-6dc5-4016-ba35-cd1dbda4988d"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7c6a905-c3fd-4e16-a130-dba236a600d2"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d81bed54-f46a-4146-b07d-8b04617eb5da"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8ee4856-6e11-4e08-bfed-cd39cf37b359"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da2e9354-0c87-4000-83d8-97be1fa25990"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daac549d-8275-4799-a97a-07bfd536b19c"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc41050f-dd82-4222-b6fc-dc7dcd89ad44"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcc26355-2fda-454b-98a6-487029733155"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd1a486b-27bd-4b16-8f00-964da447d98e"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddeeafd0-aba8-4ae4-9baa-46aac784fbdf"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de2b6efe-62ce-4b0b-9064-08b2faa419ea"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dea0b823-a844-4235-8261-a50ac77fea46"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df3054af-7024-4aea-b3f3-5957341aa37d"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0179d60-1598-4103-aa72-01fec864646f"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e050cae6-eb0a-4a2f-95f1-29db4ed6040f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1afd2c2-e2b2-4485-a83f-29069aeb1e57"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2483dbf-8984-4371-b049-d53ae649948e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2bb6473-a54b-4e0b-a915-d9771f5a1000"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e467ab46-7636-4c05-bc49-fdf1e451c461"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4a4a26a-9ea9-4aea-88c3-b5310b07f3c1"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e571ac53-7468-4418-8c88-b0014c67c219"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e72cb4b8-d449-4c69-8cd2-ab49f067b454"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e76efdcd-b5dc-4474-9806-4bd9441c61ae"), "C", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e93132cc-588a-4265-82ee-e8ff9ae514ba"), "A", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9b3712e-e80e-4de5-86d9-b599b301d175"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea425242-1c6c-4dc3-a10c-45984dbe90d3"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eaf6ca5f-9566-4b51-a235-3aeb7fcb6b0b"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb127aac-e990-4560-9d10-ac14575dc249"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb1fa831-e88c-4ec1-becb-18d0eeb22a19"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb5175bd-1f9c-4a31-a478-bcfeec95d0b9"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eeb330cb-b414-415a-a7d8-087f8fa1fbd8"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eefd7a63-e3ec-4d6d-845c-52c2c8777691"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef502615-3b10-475a-8ae2-13da3353c222"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f275f0bd-eae8-4dfe-9976-daf81ba42a22"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2c77b6c-52af-49a1-bfcf-6610e02d748b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f31fc8f6-10ee-4b99-9e86-783fb2095312"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f39cd312-3097-4c1e-ba37-dc9c1c792cd6"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4a56b6c-d36b-46ca-8780-936f4c11dc58"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5594229-046b-4d95-8f99-0bd414f5e2a5"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f65d924a-1f87-4d6f-a66a-664794101859"), "I", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f747873f-b770-494b-95bb-c2eba5a99772"), "F", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7ad0f0c-0352-46d3-8df8-8f69a3fe207b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8133f96-4989-429f-8063-a47b4f37db09"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8220fcc-9a78-4b28-abad-719d8e0b912d"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f87b62c7-e893-4372-8b6b-936228e505c4"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb295458-3dfd-448c-8d9f-1b2174672b2b"), "J", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc64c218-aede-4513-b0a1-3a5d4aae9ddf"), "H", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fcc0fafa-6a73-4591-a4ad-5254047112d3"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd6f824d-17bf-4c38-8bb5-39e6deadff0f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd815dc3-170b-4429-aeb0-22376237352c"), "D", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdec6d42-00ad-4268-b7e1-4ca7893413fb"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdfec7a8-db60-405d-ae9e-0abacf3bbc09"), "B", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff2c5d9d-d7cb-4bfe-8198-234f63cd9cae"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffb6bde0-37c9-4707-9b46-ac0846b45eca"), "E", null, null, null, null, null, null, null, new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("5e914f40-57ea-4c16-b972-7595edc13fbd"), null, null, new DateTime(2024, 12, 14, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9558), null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 13, 15, 0, 48, 4, DateTimeKind.Local).AddTicks(9554) },
                    { new Guid("6a428ac4-82c5-4f1d-944c-8a2a62111d19"), null, null, new DateTime(2024, 12, 15, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9564), null, null, null, null, null, new Guid("bb85ffe0-61ab-403e-9285-0bf08869ea63"), new Guid("ffca94db-452c-4d83-8049-9bf069baf4a4"), 1, new DateTime(2024, 12, 13, 15, 1, 48, 4, DateTimeKind.Local).AddTicks(9563) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("51d65feb-d37c-476e-be26-b15c295269d1"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 13, 16, 59, 48, 5, DateTimeKind.Local).AddTicks(145), new DateTime(2024, 12, 13, 12, 59, 48, 5, DateTimeKind.Local).AddTicks(144), new Guid("1327b38f-5095-49b2-911f-d9182a7c741e"), new DateTime(2024, 12, 13, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("012a94c2-3246-4da6-9f2d-65a5df534f37"), new Guid("a08d1991-2285-4571-acda-3707466840b3"), null, new DateTime(2024, 12, 11, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(5), null, null, null, null, null, 4 },
                    { new Guid("1b8bbbbd-dac6-40bb-8681-488993ea4545"), new Guid("13f13397-5e1d-4173-920b-df9cfdafd383"), null, new DateTime(2024, 12, 11, 14, 59, 48, 4, DateTimeKind.Local).AddTicks(9997), null, null, null, null, null, 1 },
                    { new Guid("c1ed6955-5989-4bcd-b41f-40bba2cf7ea5"), new Guid("21be93d9-9e84-4985-8f45-25daf48133ce"), null, new DateTime(2024, 12, 12, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(3), null, null, null, null, null, 3 },
                    { new Guid("d9d75d3a-e657-4401-ac30-6b3a5f386483"), new Guid("03803032-310c-45b4-b574-190149259681"), null, new DateTime(2024, 12, 13, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(1), null, null, null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("17e04f0f-e66d-4595-ac73-d2c53a759662"), null, null, null, null, null, null, null, new Guid("c2798649-1d7a-46f3-9397-9b736b23e972"), 3100000m, new Guid("ba5c1568-b109-45e6-8472-ed16fee0cd3f"), new Guid("8c5bb988-80e8-4b1e-88ed-15a7e8eb0df5"), 2 },
                    { new Guid("2bf9a0c4-4b38-40d4-bf3e-46634a28ea5f"), null, null, null, null, null, null, null, new Guid("b7a0cd0a-c4dd-4e15-9fd6-61cb2416b72b"), 100000m, new Guid("27c933a3-3c3c-4f83-bb68-0357af9c6b35"), new Guid("1cd03ed2-0c33-4c3a-aff3-b704be551bd3"), 2 },
                    { new Guid("a69c9b6e-c0f1-4558-8220-d530347869b1"), null, null, null, null, null, null, null, new Guid("bb85ffe0-61ab-403e-9285-0bf08869ea63"), 2100000m, new Guid("13a8a1f2-31bc-4f1f-a992-dfb6dba4f860"), new Guid("22c43047-2cf1-4879-bf09-0baafb20d50f"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("839bf7df-2262-4197-b21e-2d3ee47ac425"), null, null, null, null, null, null, null, 60000m, new Guid("13a8a1f2-31bc-4f1f-a992-dfb6dba4f860"), new Guid("16fab0a5-c0e5-4e4d-a92c-9f10c6b6802c"), new Guid("595df1df-073e-4cd2-af05-4f3c0e6b5acd"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("84f9296d-1517-4230-9246-21f1445fd0b5"), null, null, null, null, null, null, null, 50000m, new Guid("27c933a3-3c3c-4f83-bb68-0357af9c6b35"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("4f460804-c903-4262-8728-165da509e836"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("012a94c2-3246-4da6-9f2d-65a5df534f37"), new Guid("a69c9b6e-c0f1-4558-8220-d530347869b1"), null, new DateTime(2024, 12, 11, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(45), null, null, null, null, null },
                    { new Guid("1b8bbbbd-dac6-40bb-8681-488993ea4545"), new Guid("2bf9a0c4-4b38-40d4-bf3e-46634a28ea5f"), null, new DateTime(2024, 12, 12, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(37), null, null, null, null, null },
                    { new Guid("95bd366a-e2e3-415a-9ba9-182692c95257"), new Guid("2bf9a0c4-4b38-40d4-bf3e-46634a28ea5f"), null, new DateTime(2024, 12, 13, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(51), null, null, null, null, null },
                    { new Guid("c1ed6955-5989-4bcd-b41f-40bba2cf7ea5"), new Guid("17e04f0f-e66d-4595-ac73-d2c53a759662"), null, new DateTime(2024, 12, 11, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(42), null, null, null, null, null },
                    { new Guid("d9d75d3a-e657-4401-ac30-6b3a5f386483"), new Guid("a69c9b6e-c0f1-4558-8220-d530347869b1"), null, new DateTime(2024, 12, 12, 14, 59, 48, 5, DateTimeKind.Local).AddTicks(40), null, null, null, null, null }
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
                name: "IX_SeatShowTimeStatuss_RoomID",
                table: "SeatShowTimeStatuss",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_SeatShowTimeStatuss_SeatID",
                table: "SeatShowTimeStatuss",
                column: "SeatID");

            migrationBuilder.CreateIndex(
                name: "IX_SeatShowTimeStatuss_ShowtimeId",
                table: "SeatShowTimeStatuss",
                column: "ShowtimeId");

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
                name: "SeatShowTimeStatuss");

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
