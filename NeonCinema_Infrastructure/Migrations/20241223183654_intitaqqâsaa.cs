using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intitaqqâsaa : Migration
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StarTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeAllowed = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenguageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Movies_MovieType_MovieTypeID",
                        column: x => x.MovieTypeID,
                        principalTable: "MovieType",
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
                    PromotionID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    AfterDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TotalPoint = table.Column<double>(type: "float", nullable: true),
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
                        name: "FK_Bill_Promotion_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotion",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_Users_UserID",
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
                name: "PendingPoint",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Point = table.Column<double>(type: "float", nullable: false),
                    ApplyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_PendingPoint", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PendingPoint_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PendingPoint_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
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
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                        name: "FK_Ticket_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "ID");
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
                    { new Guid("9b95b69d-0ce0-4f86-b8a6-a66b95634ed7"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("40285396-89fa-4845-a47a-b12b319a659c"), null, "mua tại quầy" },
                    { new Guid("e0ce42df-c903-4a9b-93c5-9a11de77ff38"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("23c04b8b-a0d2-4edf-a31f-980f3ee37ac7"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(586), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("be885a0c-2657-40a1-a53e-b031e6312496"), "11:00 PM", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(590), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("19027b65-6b36-44be-8166-37815ae1098e"), "Ấn Độ" },
                    { new Guid("26f61f8b-4f71-4636-be90-b467bde38c27"), "Việt Nam" },
                    { new Guid("4210aea2-c2dc-45f2-ac35-0c9b2c156fd5"), "Hàn Quốc" },
                    { new Guid("48f3aad3-04fd-46a4-9627-2112a11536e0"), "Trung Quốc" },
                    { new Guid("6a4c8816-01e8-4f42-9102-8fec3aa71dc9"), "Hồng Kông" },
                    { new Guid("8a8f24d6-4892-4204-8cc9-297c2ff63326"), "Pháp" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("8ffe0abe-3c01-4995-88b5-5bff208deae0"), "Mỹ" },
                    { new Guid("a1de947f-7cd4-428c-8e85-a2d7394f564d"), "Úc" },
                    { new Guid("bba24abe-4c32-4c8f-bd6f-22e59bdf5ee3"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("09445b47-39c8-4649-95fc-bfb4138edf2a"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("1cbeb1d9-6154-42b7-a22d-7e4a2fb4a4de"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("47340b0d-8e68-4695-a78b-01f0122eb0e8"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("7d8ce8f0-811d-43d0-a61a-7becb0716096"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("839045c7-90b3-45c4-ba9c-353de1cb6902"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("c23a402b-9bf5-44cb-b4bb-3e4c7730e26e"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("c3370d72-f2de-4980-a773-68e8f0908153"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("e284e3b7-fe77-4509-b314-3bbe791a804c"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("1c161f43-37d5-4ae1-8d5a-4b56e02e7bb0"), "Combo 3", null, new DateTime(2024, 12, 22, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1520), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m },
                    { new Guid("8e1aaa6a-4a28-448a-9833-441ba9b9212f"), "Combo 1", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1514), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("e9f951bf-9006-42d0-bd40-c70e4a3196d8"), "Combo 4", null, new DateTime(2024, 12, 21, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1523), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m },
                    { new Guid("f951c159-d1d1-4fd4-ba07-f3316329d8f7"), "Combo 2", null, new DateTime(2024, 12, 23, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1518), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0a44998c-25c3-4ffd-9b04-e8a65131082e"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("3251e861-b335-4027-9906-d7ddd056ccce"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("4c3ea098-ba57-415d-ae36-6b5272a94b09"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("4fec1dcd-e9b6-4494-bff2-182cb734cc85"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("8669361e-cfef-4f54-8c66-4ebeff3aa92b"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("a77a7c1a-3bde-42d1-bb37-ea8c5d11a245"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("e1ccb954-eaac-4bc3-8c02-49c245358f0e"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("f5178f05-951b-441b-ae5f-a335e101c783"), null, null, null, null, null, "Hành động", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("452da9a4-facd-4e04-b88e-a5da9571db62"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("5433698e-764e-40bc-a0da-334dcc94ae6a"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("844cb33d-7733-4983-a957-5b54adc1104a"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("b19f05ae-d898-4f5f-880a-2d4f3286b759"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("ca6adbfb-d580-498d-b91a-38451112c985"), null, null, null, null, null, "ThaiLans", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, null, null, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, null, null, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("28e000f0-b707-4dac-8b67-be9e2952d270"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 },
                    { new Guid("bfceb77c-04b3-4776-956b-cd7a4cb2ee8c"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 24, 1, 36, 54, 269, DateTimeKind.Local).AddTicks(9594), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 24, 1, 36, 54, 269, DateTimeKind.Local).AddTicks(9617), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 24, 1, 36, 54, 269, DateTimeKind.Local).AddTicks(9614), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(566), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(567), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(562), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("0136940e-7d9b-4ea3-bfdb-cedb17ac9d90"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("0f3e650f-bebe-4efd-9d26-44f366c95e2c"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("14718319-dfef-49ab-abed-46586c1daa2c"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("1b82e14c-51e3-40e2-bb86-1dd4107782b6"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("4cb6ea99-25b4-420a-9788-8b0bc3701b00"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("7e2ee9c0-0159-4446-a1a0-9cde92dca547"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("a9b47de6-8a13-4cef-9e52-afe525b7dcc5"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("cf64f180-2584-4633-b98a-622957d14eeb"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("d217c102-d148-4b4a-8fd4-355a7ac5a1bf"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("f90e0f6f-a4b1-4a40-b47d-2ba05024f7f6"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, null, null, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("0eaec262-c1cb-41c5-8ab7-9caca425e1e0"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1295), null, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("e284e3b7-fe77-4509-b314-3bbe791a804c"), 110, new Guid("3251e861-b335-4027-9906-d7ddd056ccce"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("38fab586-79a4-43e4-8744-827f848bb7c5"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1271), null, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1232), null, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("59c25127-f6ab-4801-bd77-1f4d30c30fce"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1257), null, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("e284e3b7-fe77-4509-b314-3bbe791a804c"), 109, new Guid("3251e861-b335-4027-9906-d7ddd056ccce"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("5a7cdb33-2aad-4a95-bdd2-bd120fffc5f8"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1329), null, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 134, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "cuocchien.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("6007bcd7-7725-44e4-a3c8-806d9983d04d"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1277), null, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("839045c7-90b3-45c4-ba9c-353de1cb6902"), 120, new Guid("a77a7c1a-3bde-42d1-bb37-ea8c5d11a245"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("602aae14-10cc-4fda-9988-89d92ab18c9e"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1241), null, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("839045c7-90b3-45c4-ba9c-353de1cb6902"), 81, new Guid("f5178f05-951b-441b-ae5f-a335e101c783"), "xich.jpg", new Guid("452da9a4-facd-4e04-b88e-a5da9571db62"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("6199a61e-af83-48c5-8510-f1d810142223"), 13, new Guid("4210aea2-c2dc-45f2-ac35-0c9b2c156fd5"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1248), null, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("c3370d72-f2de-4980-a773-68e8f0908153"), 113, new Guid("f5178f05-951b-441b-ae5f-a335e101c783"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("6854fead-d8cf-4c5a-881d-0922a0b95dad"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1335), null, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 127, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("775755e4-5533-4c67-be02-128d879f486a"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1284), null, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("c3370d72-f2de-4980-a773-68e8f0908153"), 110, new Guid("f5178f05-951b-441b-ae5f-a335e101c783"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("7ada8818-db94-473a-acab-1bd303a8e7e4"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1323), null, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 118, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("82e5beeb-bc06-4559-bfc2-6050ce72c0e2"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1301), null, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 100, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("bd1efcb6-cdf1-4d72-a15a-5b8a0532ad7c"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1263), null, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 99, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("c0d84026-bdda-45fc-bcf5-572423fdc259"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1309), null, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 113, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "cuoixuyenbiengioi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("cc514501-83bc-4b76-90fd-7e7f410c4a0b"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1317), null, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("06ae8873-be10-44d0-8a95-984533e7589e"), 123, new Guid("c86a1d37-c0d8-4e46-ab8f-29972146cfdb"), "kinhvanhoa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/EDDbR2jINsQ" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(624), null, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(629), null, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("05c5b606-20c9-410d-9d65-02c7939e9933"), "Hưng Yên", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(304), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("09eec6f0-f8d8-49c5-babc-7d42b284fb3a"), "Bắc Ninh", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(258), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("0c9bd852-c813-41e3-bf22-9ee6a33fe6fe"), "Đà Nẵng", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(192), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5d9a4a25-fb5b-4992-a5ff-fc24d11d92e0"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(211), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("60a8847b-20a1-4df2-8479-49ea30dff493"), "Quảng Ninh", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(342), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("66f9b3bd-b31e-4942-8a80-9c01096f5fe1"), "Thái Bình", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(277), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7a7a356c-bb5d-412c-aa85-e502e4177e95"), "Hà Nội", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(136), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7ee58cf6-8401-455e-957c-44434c1e1449"), "Nghệ An", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(237), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c8210d75-7cc9-44ad-8e6b-293e9b27c06d"), "Nam Định", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(323), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d9e539d5-1457-4c45-9359-49eb409d210b"), "Hà Nội", null, new DateTime(2024, 12, 24, 1, 36, 54, 269, DateTimeKind.Local).AddTicks(9762), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f0d2acf2-198c-4e5f-8ec1-cce7e2e4a9be"), "Hải Phòng", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(167), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f4a97607-a5cd-4489-a660-34fa5c1fb2bc"), "Hà Nội", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(360), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "PromotionID", "Status", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("02bfe040-2420-4a0d-a816-3eccbc2ee283"), null, "BILL004", null, new DateTime(2024, 12, 22, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1580), null, null, null, null, null, null, null, 2, null, 200000m, new Guid("0c9bd852-c813-41e3-bf22-9ee6a33fe6fe") },
                    { new Guid("2148d450-1b09-42f3-9b66-760575fda5a1"), null, "BILL008", null, new DateTime(2024, 12, 14, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1593), null, null, null, null, null, null, null, 2, null, 450000m, new Guid("66f9b3bd-b31e-4942-8a80-9c01096f5fe1") },
                    { new Guid("3690a9df-8762-4914-9485-ab818982f62e"), null, "BILL009", null, new DateTime(2024, 12, 16, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1597), null, null, null, null, null, null, null, 0, null, 350000m, new Guid("05c5b606-20c9-410d-9d65-02c7939e9933") },
                    { new Guid("387be377-1440-4cf2-9283-99f7d699a3e3"), null, "BILL006", null, new DateTime(2024, 12, 20, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1586), null, null, null, null, null, null, null, 2, null, 600000m, new Guid("7ee58cf6-8401-455e-957c-44434c1e1449") },
                    { new Guid("60e6a69c-c4d8-4bd7-9ce5-1f7e1506fc42"), null, "BILL002", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1574), null, null, null, null, null, null, null, 2, null, 300000m, new Guid("7a7a356c-bb5d-412c-aa85-e502e4177e95") },
                    { new Guid("6ffa936a-4435-4329-971c-86786e59a26e"), null, "BILL003", null, new DateTime(2024, 12, 23, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1578), null, null, null, null, null, null, null, 3, null, 150000m, new Guid("f0d2acf2-198c-4e5f-8ec1-cce7e2e4a9be") },
                    { new Guid("a18ef302-cfa9-4e36-8dd7-0674f003e0a4"), null, "BILL0122", null, new DateTime(2024, 12, 20, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1588), null, null, null, null, null, null, null, 2, null, 680000m, new Guid("7ee58cf6-8401-455e-957c-44434c1e1449") },
                    { new Guid("a59cb273-dc7a-4921-bd46-e6f90b45528f"), null, "BILL001", null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1569), null, null, null, null, null, null, null, 2, null, 500000m, new Guid("d9e539d5-1457-4c45-9359-49eb409d210b") },
                    { new Guid("b4894be9-dc0e-4785-8f8b-728e92cf2a40"), null, "BILL007", null, new DateTime(2024, 12, 19, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1590), null, null, null, null, null, null, null, 1, null, 800000m, new Guid("09eec6f0-f8d8-49c5-babc-7d42b284fb3a") },
                    { new Guid("bba355bb-f0eb-4812-a27b-5111a69b5c9f"), null, "BILL005", null, new DateTime(2024, 12, 21, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1583), null, null, null, null, null, null, null, 2, null, 250000m, new Guid("5d9a4a25-fb5b-4992-a5ff-fc24d11d92e0") },
                    { new Guid("e8f1282f-e88a-4ab5-9b54-c27cd48243c4"), null, "BILL010", null, new DateTime(2024, 12, 18, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1599), null, null, null, null, null, null, null, 2, null, 700000m, new Guid("c8210d75-7cc9-44ad-8e6b-293e9b27c06d") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("2d9f0dc0-c6ca-41c0-8b8e-dc0806ab7657"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1691), 1, new Guid("d9e539d5-1457-4c45-9359-49eb409d210b") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("05352ae7-a099-4a77-a7c1-89e926886324"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1397), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1396), new Guid("14718319-dfef-49ab-abed-46586c1daa2c"), null, 0 },
                    { new Guid("213fdd76-8c5a-421d-bbf4-0c0d8c31e64a"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1407), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 29, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1406), new Guid("f90e0f6f-a4b1-4a40-b47d-2ba05024f7f6"), null, 0 },
                    { new Guid("50e26061-5926-4082-9348-6bdfa9af54b5"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1388), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1385), new Guid("cf64f180-2584-4633-b98a-622957d14eeb"), null, 0 },
                    { new Guid("6fbcaf4d-eb59-4745-af1e-dd033ba35e17"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1403), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1402), new Guid("1b82e14c-51e3-40e2-bb86-1dd4107782b6"), null, 0 },
                    { new Guid("79d4fd80-c1c8-4f4e-8c50-9eb538d82905"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1400), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1399), new Guid("d217c102-d148-4b4a-8fd4-355a7ac5a1bf"), null, 0 },
                    { new Guid("7d0be1c8-6ff4-4de0-b940-639285e53921"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1411), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 28, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1409), new Guid("0136940e-7d9b-4ea3-bfdb-cedb17ac9d90"), null, 0 },
                    { new Guid("fb4fbbd1-62e7-4027-98b3-5d935e64d2be"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1392), false, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1391), new Guid("a9b47de6-8a13-4cef-9e52-afe525b7dcc5"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0110150b-2659-4e1c-91cb-0e746569105f"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0143f4e1-a22c-4bc4-a78f-bb2ca8b5f061"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0259f6c9-ef3e-4cc7-a53c-cd9d6d8eef78"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02bda1aa-fdd8-4ae6-9995-95961a4335c0"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03c6b711-7e2c-4eaa-a0c3-109704fa8d39"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04b9fcd4-36e1-4821-94c1-7a58e244b815"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05730321-f846-4c5e-b555-ba9f020d3d02"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06d1540f-84f0-4bc8-9a5c-88c1c8321f36"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06e30095-3f82-4cc8-8256-e4c278b29aae"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("07fb306a-f0b8-42cf-88a8-6a12344a0cd0"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08ab3717-4d88-4043-9051-0c3d91e59623"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("092754fe-688f-48bf-95ba-0c11e62a49b2"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09783617-25dd-4ef0-9ed1-d61ed0ab477d"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09c716e9-d28d-4b97-8b1b-0bb176712f5c"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b8ea81c-a96f-499d-9da7-89890e60ec58"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c1002a4-51ab-4435-a378-e2bcc4ba8905"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ca07b05-3b4d-4616-bdae-067e3d241e97"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10197f80-a3cf-432b-9154-2da4f134cb44"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10b92c3a-612a-4000-a38d-99e8814b3c7c"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10bac653-4715-4986-80a9-048d69f07e16"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11997387-f9f8-4f50-b4a9-c4f5dca47d12"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("120e8233-e840-43cd-b2f4-4dfc8ac9a2eb"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12970894-1585-4faf-b64e-0daf865d9eea"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14b3b7b0-d4b4-4dbc-81b3-a6c1809b2e48"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("151a1113-a1c3-462d-9a26-85ce6e51edef"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("154f2c2b-2e1b-443b-899f-44a286cb8b75"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16b19c5c-d969-456b-ac2d-b07a2496cdfd"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16d97195-20ec-41dd-8a64-ac474d7384e1"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17b36d8e-0092-4be6-a625-e4d6539a3ffe"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1888f810-32c8-49f7-9fa5-0c2c7533d820"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1965bd41-7044-422c-a05e-4995774cc9c5"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a083cf0-5bca-402c-a31b-ab83a2a332b9"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c8b49e7-1d60-4f55-b7da-9a4c571e473a"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e2fac46-4e24-47f7-aba4-bcb90c9daca6"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e9db53b-e3c3-4a12-b5f2-b3738ec910d9"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fad6847-3f8d-4b96-bafc-7ffeb3f37e13"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21f16cf4-43cb-47d3-9e32-c58aad335e2e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("222a0fb7-1cee-4d0c-b4ed-ff3a54f082fa"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("224190c0-08e9-4469-aa32-9e3f3f5d5ba2"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2279988a-45ca-46d0-88b2-8a92c8c6f401"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22955bc5-c396-4fd9-9703-a38d753fdb8a"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23120cf0-9c87-4c35-bb67-1f2052ba7ba2"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("235c16c3-43c1-4a95-8e9e-2d4e58e79466"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24e7d7f4-5d1b-4569-a551-6e9bd3d901a4"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("266310ec-ab5d-49ab-a460-d7a9c22d2403"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2855a715-c015-4fd2-aea4-eb047f1309ca"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2963de35-a73b-4af0-9276-ce7d28db0961"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("296bcf46-03dc-4af9-9ce0-2604dfaa380c"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("298a6679-ba3a-45c5-a3e6-f51298dfab5e"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29dc8fea-36c5-4810-a3f9-2945430c21ec"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ab078e8-ebcd-4426-87be-6f185a8538e9"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ac18744-c572-4cd6-8ec6-8821504c86a3"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ba41018-3d08-4604-b990-058b99c1f69a"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2bbaaae5-6b5a-4413-a134-8a673e645c22"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2beba5ba-b9d4-4eeb-acb3-6fa2136296b6"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d7368b3-1d9e-4116-b463-9b80f93941b1"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d74cfca-df0b-457f-ac6f-eb8548674f36"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f860ebd-81d3-4439-98b9-f96e446e0dcb"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ffa2ceb-a11e-4b7d-8e72-c72ed953fd55"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31584965-cf61-43af-943b-94f9712d1fb6"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32f11bb1-7b39-4405-b9e6-0377d21962bd"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34736178-b989-43a4-8a3b-d4672fa37390"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("357be958-cc90-4da1-8f70-52795bb36583"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37a1ff58-acfd-4563-a0af-ee0d8db749f7"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a4a436d-f6f3-44fa-9869-e5532b8239e0"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ac7bc4b-2cd3-4ec9-a6db-081385f5587a"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b85a43a-b7e7-4a2b-803f-afd0987fe418"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c663a80-e3b1-42b2-91af-6514d05a1eef"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f1da07e-e250-40d7-ad07-36df718550d9"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f466802-a3bc-49dd-b80b-cb019e6fa942"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("405ea359-0b57-4a51-b926-84c32a7bb1b7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("412b1aa1-151f-4fe7-a017-99d51cbde86a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("421964f0-4041-4617-8d5c-f50c9855fc55"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("421e1520-8e78-4a78-8875-3f5bcfa9f5d5"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4248f059-5728-496f-9d03-ceabba331bc1"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43e47000-23ad-4096-b9f6-3b58934fe49b"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43f9d4be-5a42-4106-aa9a-051b19f9b8a2"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43fde391-cb22-49e4-944f-996910f81ca2"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("482c8fdc-e350-4995-9c03-e7309433ef9c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48ac22a9-1087-4abc-bb36-29e6925f31e7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("497608bf-5815-454e-9719-a0b4c0a7abd8"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49ad77b0-5cdb-4141-ac6e-e7bc4a920de1"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49af401d-72e3-44e1-ae86-df0b33e48479"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ace2478-7ad8-4a52-8cf7-d3e4fd318462"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ba75149-027f-4714-8cae-6e1d152d5467"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c9ec0d0-684e-4a7c-a6fc-996a08d22c69"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d2ae4c4-04d9-4252-9253-91bd32f60fcd"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4da19f60-980e-4d61-ab68-42d328f2c2a7"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4edb48b7-a123-45a0-b830-d7697c698f6d"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("504b10fd-d900-45dc-b6bb-cc165c6e9f8b"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52a6bb22-5d21-423a-bc7c-fac702c8763a"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52ccb6ae-6cce-4aab-ab3b-7b16b8ca6f4a"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("540c1fa2-6131-4f45-8596-48a2a0bb16fe"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("570af213-b2ad-47b7-b16a-9b7983ee9864"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("571a96a6-f404-4d59-bb92-9abc8a88ed6b"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57ea5b22-d61a-40f2-b1f1-78bf5a23c3e4"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("587f3283-4e19-4c61-9688-219a831d56f9"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b9fc60b-9134-4745-856b-b387e20870db"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e298373-8158-4a22-9ec4-f3a02a2af6a5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f4dec45-4b08-40ef-9239-57b118642c71"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60a71255-0fa8-42c4-ad3b-91cdcf059906"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("610a75de-62fb-431f-9aa7-e62cfb67cee1"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66859ec5-4564-4095-aa12-aadbaf05307f"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67884c83-4ac2-45cf-bdf1-3945194ebb05"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("684613b7-529d-4bea-afa8-2811149ed900"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("685731b3-4e09-4c85-8a4a-5e7cf1c3b9d3"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68aa6f4e-af66-469a-bbb1-c93475b9224d"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("694c6c60-e353-4e10-b458-e1972540475c"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6972666a-760d-44f3-8a61-e8033dae1feb"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bb5fc05-9d12-4e91-8cb7-2a6dc1d4a706"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d5cbea6-9553-4484-b2c1-a4003bac4eb4"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6df1500c-48d3-4abe-96a5-a6e125f818e4"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e188a71-7938-4076-b6ed-2e8a5681f2d3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e321d2e-1386-46ae-84bc-c48fde46c3ef"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fac64a3-44a7-4f43-93c7-091fccabe845"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("702a6060-4486-46cb-9fd7-b8aad54cd275"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70602a5a-b8c0-4959-b3a1-c9a869bd8ff7"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70a6cffd-fca2-49dc-9229-08bceb417731"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71d53fdf-a423-49b7-b11b-97b25ef8e5b2"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72986019-1e23-49c8-9a22-7fb60381d98a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7516b9b8-c413-4e0c-932d-011c71cfe71b"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("751f8ce5-7229-43b9-8f17-c396ffb6a5a1"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77ae982f-db00-45a1-9c6f-0f837a66968f"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7873ccde-b16d-4933-b5be-0cd4dc553d06"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79833305-32f0-4535-b2a6-7f52df279cab"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("799aa745-bdc5-4693-bff3-abe7d4ea0c58"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a9b51bf-51dc-4cc7-9651-83bf40a50670"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c23a8e8-d073-4213-a099-b875e344bebf"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f124034-188d-4818-8649-a753b7cfd4a9"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("802e2379-7894-49ff-b731-8b08b97be656"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8278b9b8-13b0-4721-8331-1fa0dd8e7856"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("843ab5ff-f2f6-4b7e-8079-11ed287abcda"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("863b56c7-fda8-41c2-ab80-9d8ba1c08c3f"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8727c770-6e34-4bfa-a18b-cbf79489ee90"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8759e79a-1e2c-4631-8dd2-1350d67cdee1"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88283cfe-4e5b-4870-bb03-8dc57e15d557"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a276aa6-bf82-43c2-a894-1e875f6c5837"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b1d0c3a-1d7e-4d37-96e9-1b8044ab62a3"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b28d31c-5a28-4324-96d1-b7e93bb9ebbb"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b56819a-9d30-4614-b2a5-a8e7c5ccb992"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e4cd356-d14f-4c54-bda1-b6104156d904"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f50d19c-b36a-406e-a8d1-8084a10ce094"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91a003e0-fb7e-457d-9bde-d50e8b9921d1"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9237db10-249d-4a9d-b668-919467d6ff77"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94b92af6-f4be-400f-a5e1-0ffba830caf6"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94f25dea-ea30-4e70-8df2-3b2993134add"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9512df60-1ec7-4b7c-b136-a41ff4d698aa"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95807a4e-5da6-48fa-8087-f8179058a703"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96b9fbea-5f7b-4c7b-9bc4-11e7338426f6"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("982e2845-74ff-416e-aed9-2e8157270003"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9837bb41-ce03-41ec-9906-c5faf3abc6c6"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98b1d2bb-7c19-481e-ac88-9b5b9ab44b68"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("997a6d0d-97df-4062-8066-25b97265ceeb"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a255301-5d4c-47f3-a6f0-38932952e6c8"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b8da6f2-0ab9-429a-a7c8-d64136fa6769"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9be75940-3946-44aa-8253-26eaad52b0a5"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9df46625-7f34-4ca3-8009-35044b99b636"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9dfb544a-e6a0-4495-abbb-c7c2367e3f6a"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e17a7b0-9e30-4235-8132-fa5fbaf35be0"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ec6d0e7-3954-457f-ae71-33e1cc111041"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f07c1f0-fc81-49d9-b34e-040b75eecf4c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f3c9eb0-feb3-48cf-aeac-61d67a4ec392"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f42f739-83ed-42e7-b3c5-9f1c5548f92c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f65348a-fe2c-48d3-a1b2-9dc0e0aa814d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ff72919-ffed-4fdf-be28-45633d64c3b0"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1844f17-6495-4b95-b0b3-c7a103f896af"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2069c4a-e5c0-4287-b596-dc3fa8c856a3"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a22fbacd-0317-4f5b-ae7c-053037c129fd"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a235d906-8233-42c0-99d8-2172132a1b76"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2645f5a-e5fb-4792-ba62-c1f4fda0cf84"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a55cf01a-820d-4f8d-ae82-11cd2be1bb3e"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a604e16e-ef28-4771-9bec-6eb5c8aea2ae"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7fd28da-624d-453d-b6d6-c3f1d416adff"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8a27976-c170-4c37-86cc-65a2c9b3b76c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9ef5b14-c10f-473f-bf63-7ea0b954af3d"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac499dab-8c8d-4bab-8abe-ab5dad94f53f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("accb1180-ddec-4aec-bef9-8e54ac5797b7"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b04e3560-62ab-419f-9042-f45e94c1d6d2"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b16c5a52-221e-4f9a-9967-9094d8dd84d4"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5aea3dd-ab08-4c75-bd88-2338c6ed454a"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b67d94b7-8118-4e1e-9bd0-69ef53c58a8a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6bcc1b4-052f-4866-a9f3-b3a9a3334493"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b705391b-60e8-4e71-815e-a77e4596bdc6"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7221ce4-1c5e-4862-9762-dbe4f956e859"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7cba78e-7034-4393-bb7d-3c208da040b0"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b91ac7d5-a5fb-4585-93ae-c3fcc828efd6"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba0cbe66-ec74-456f-8781-8656807fdb78"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc5dc9d6-dd0b-4c0b-ac59-5c620d1e3fb7"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c023dcd4-21a0-4adb-a3c9-cf1068b7eb4c"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c06e3ff1-c34e-4426-854e-fcf870296d2f"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c11bdba6-55ed-4f63-8c48-33d6d6896333"), "A", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c31ead45-f482-4915-b252-4691f90a622d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c336205a-e4fe-4d96-a405-9a6f807a359f"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4f60b54-2573-45d3-92c7-5c3991ddb580"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5000357-9bc7-4438-b8f5-fbd4a7a8392f"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c66a7167-e955-4244-a28a-ac562e3468bf"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8c64db1-8860-4a9f-9cd6-d32db891b6cd"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8e10a59-7ad5-449b-9fc6-9b34be02cf14"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9aacbca-26bf-4383-ac42-0671a1d1a741"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca32f86e-3813-4ce9-85da-f2a1132df56f"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc74be88-a3dd-47d3-b2db-14d15d67a296"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ccc3915c-1643-41bd-a749-8f8173a123a5"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd3e9b45-bc76-40b1-a476-675fccad73c1"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce032982-e439-4114-8408-38fc8a2f12e2"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce165e37-fdae-4a1b-9cf7-b804516005b2"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce493ebe-0210-4b6a-95e6-ce245cf2508f"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce7462a0-d981-4638-9deb-c6e5386b5c53"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cebc70f2-715a-42e4-9b85-91930f7adad4"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf97629f-def2-42a0-ae15-f566fe83548a"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d15ec1a6-8f84-469e-ba21-23c5fd6b30fb"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2c23235-a79a-47dd-95ad-ea9026deac99"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4099db9-f210-430d-ad49-7869b6a5a0c6"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d56777f2-6fc6-448b-bbcf-7e6a1564c2de"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6cfa74d-2987-439d-9448-3089e1e9d39a"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d733cd25-da10-4d80-aa72-4ea3a2163550"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7480aac-03bb-4b3c-8425-917b947849b4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d94657f8-0c70-498f-b2f3-d4c33150d33c"), "H", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d982efa2-b864-4941-8e10-cad1b41e912c"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9b22eae-4736-484f-9c07-8cf7b408866e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc2c55f2-ab79-4433-972c-cd76d6cadcd4"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc7fd851-9c5e-4faa-97c5-c8a6e291ed8a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1e77888-65b4-426d-9339-341bb4853ed4"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e49eda42-238a-4f58-9100-f2dd58d56364"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4e9e0c0-d860-4c46-96a9-029c47432d26"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e59e1a11-fc04-4e7b-bbcd-47223df689a9"), "F", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6248145-a00d-411d-bcd2-6d6f81e3fee5"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e743a12e-46a8-46c8-98c0-0a9d41a62ba1"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7d8779c-7f1e-45ad-a8d7-9b89f9945724"), "G", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7dfa229-8ace-4c3c-8f5b-f2449094e9c6"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9db7224-e27b-4925-b8e0-9b1be63dac3c"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb704a61-5b7f-41e3-8b0d-778bad981f12"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec353ba7-7ce8-4346-a8e6-cff76d210ccb"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec5750d5-72fa-4bcd-9d2d-7f094eeac018"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eeb5f5cd-5207-4987-b513-f5b95cc60a6e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eecf48c2-82c8-4e1b-b833-60dd68b6d1a4"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef520ca5-6c88-4619-b831-6e7ccef1c21f"), "B", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f056d7c2-ee89-4883-9c3d-96c46a272c77"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f09f806b-5295-4785-8a5c-86c103e0dc20"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1fce402-a8e7-4e00-a35c-6bad2ead2b62"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f265e51b-5cd9-444b-89bc-4c445f3f6713"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f27d8f28-8483-43df-90d6-a18ab8f31624"), "I", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3e57930-1fe2-43a8-bd55-70b2e94d93d0"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f47b13f1-2b35-47e6-a55a-e5130fda7211"), "C", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f664c1f8-3f3c-4531-83d3-e0ff9369c43f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7f277bf-bed5-4fef-acf2-8665b7e4d561"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8786f22-b5b5-4589-a1b5-0b813bdb5711"), "E", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc90984f-7bdf-4fdc-aa4b-157e81c48069"), "J", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fcb91dc4-601b-4cff-935c-b9a04c0bbe34"), "D", null, null, null, null, null, null, null, new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fcc5127d-dbba-46f2-bb87-adc20823b516"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe40faea-8fb6-4e8f-b725-4d55164d9c4d"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("160c196f-7a6e-4663-beb8-93ad8cc9d7e1"), null, null, new DateTime(2024, 12, 26, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1369), null, null, null, null, null, new Guid("602aae14-10cc-4fda-9988-89d92ab18c9e"), new Guid("c28c1979-816f-4daa-85bf-3ce567061591"), 1, new DateTime(2024, 12, 24, 1, 38, 54, 270, DateTimeKind.Local).AddTicks(1369) },
                    { new Guid("38c5b32a-e107-480c-87ab-f4066c0eda3a"), null, null, new DateTime(2024, 12, 25, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1363), null, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 24, 1, 37, 54, 270, DateTimeKind.Local).AddTicks(1358) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("dfe49b09-849d-4b91-928d-c69c278109ad"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 24, 3, 36, 54, 270, DateTimeKind.Local).AddTicks(1708), new DateTime(2024, 12, 23, 23, 36, 54, 270, DateTimeKind.Local).AddTicks(1707), new Guid("d9e539d5-1457-4c45-9359-49eb409d210b"), new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("02bfe040-2420-4a0d-a816-3eccbc2ee283"), new Guid("e9f951bf-9006-42d0-bd40-c70e4a3196d8"), null, new DateTime(2024, 12, 22, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1671), null, null, null, null, null, 4 },
                    { new Guid("60e6a69c-c4d8-4bd7-9ce5-1f7e1506fc42"), new Guid("f951c159-d1d1-4fd4-ba07-f3316329d8f7"), null, new DateTime(2024, 12, 24, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1668), null, null, null, null, null, 2 },
                    { new Guid("6ffa936a-4435-4329-971c-86786e59a26e"), new Guid("1c161f43-37d5-4ae1-8d5a-4b56e02e7bb0"), null, new DateTime(2024, 12, 23, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1669), null, null, null, null, null, 3 },
                    { new Guid("a59cb273-dc7a-4921-bd46-e6f90b45528f"), new Guid("8e1aaa6a-4a28-448a-9833-441ba9b9212f"), null, new DateTime(2024, 12, 22, 1, 36, 54, 270, DateTimeKind.Local).AddTicks(1665), null, null, null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("12090433-e171-4809-8bad-4dc00da1defa"), new Guid("a59cb273-dc7a-4921-bd46-e6f90b45528f"), null, null, null, null, null, null, null, new Guid("6199a61e-af83-48c5-8510-f1d810142223"), 3100000m, new Guid("05352ae7-a099-4a77-a7c1-89e926886324"), new Guid("1e2fac46-4e24-47f7-aba4-bcb90c9daca6"), 2 },
                    { new Guid("3569aea1-a542-452d-896b-17a4085f922b"), new Guid("a59cb273-dc7a-4921-bd46-e6f90b45528f"), null, null, null, null, null, null, null, new Guid("3f9aa242-4e81-4f0e-b5b8-ce7d181375a7"), 100000m, new Guid("50e26061-5926-4082-9348-6bdfa9af54b5"), new Guid("67884c83-4ac2-45cf-bdf1-3945194ebb05"), 2 },
                    { new Guid("bca1856f-fce9-4210-b78a-44dd5e7b9a9f"), new Guid("a59cb273-dc7a-4921-bd46-e6f90b45528f"), null, null, null, null, null, null, null, new Guid("602aae14-10cc-4fda-9988-89d92ab18c9e"), 2100000m, new Guid("fb4fbbd1-62e7-4027-98b3-5d935e64d2be"), new Guid("a1844f17-6495-4b95-b0b3-c7a103f896af"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("23c04b8b-a0d2-4edf-a31f-980f3ee37ac7"), null, null, null, null, null, null, null, 50000m, new Guid("50e26061-5926-4082-9348-6bdfa9af54b5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("cf64f180-2584-4633-b98a-622957d14eeb"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("40285396-89fa-4845-a47a-b12b319a659c"), null, null, null, null, null, null, null, 60000m, new Guid("fb4fbbd1-62e7-4027-98b3-5d935e64d2be"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("a9b47de6-8a13-4cef-9e52-afe525b7dcc5"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
                name: "IX_Bill_PromotionID",
                table: "Bill",
                column: "PromotionID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserID",
                table: "Bill",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BillCombos_FoodComboID",
                table: "BillCombos",
                column: "FoodComboID");

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
                name: "IX_Movies_MovieTypeID",
                table: "Movies",
                column: "MovieTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_PendingPoint_BillID",
                table: "PendingPoint",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_PendingPoint_UserID",
                table: "PendingPoint",
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
                name: "IX_Ticket_BillId",
                table: "Ticket",
                column: "BillId");

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
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "PendingPoint");

            migrationBuilder.DropTable(
                name: "PromotionUsers");

            migrationBuilder.DropTable(
                name: "RankMember");

            migrationBuilder.DropTable(
                name: "SeatShowTimeStatuss");

            migrationBuilder.DropTable(
                name: "ShiftChange");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "FoodCombo");

            migrationBuilder.DropTable(
                name: "TicketPrice");

            migrationBuilder.DropTable(
                name: "WorkShift");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "TicketPriceSettings");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Promotion");

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
                name: "MovieType");

            migrationBuilder.DropTable(
                name: "Cinemas");
        }
    }
}
