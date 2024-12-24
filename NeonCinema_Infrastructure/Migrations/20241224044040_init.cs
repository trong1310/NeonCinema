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
                    { new Guid("4de3e8e4-f498-420d-bd5e-86cc166a244c"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("39b7cf53-e0ca-4280-998a-34889e04eb6d"), null, "mua tại quầy" },
                    { new Guid("e183af8b-ab80-4da3-a899-dac1bf2b3d86"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("979f137f-1242-4c94-85ac-6c7d52e0542d"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5466), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("a94ea550-38ca-4ad1-aa4a-d68600d03eb3"), "11:00 PM", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5471), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("314ed748-e750-4cb1-83fc-bf1d65b6ca97"), "Hàn Quốc" },
                    { new Guid("3d8bc807-1dc9-4756-818b-d106bf1b82dd"), "Vương Quốc Anh" },
                    { new Guid("410d7ff8-7311-4501-b19e-9569a17b63af"), "Ấn Độ" },
                    { new Guid("5d4f4bbb-19e1-4f42-879a-b3dee450e59c"), "Úc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("92a32acd-1ea8-4165-b217-5822e135bf2a"), "Trung Quốc" },
                    { new Guid("9e965d1f-df7b-40bc-b5e7-df1f7dcef088"), "Hồng Kông" },
                    { new Guid("c648be09-f26a-438c-af80-b5006deb5b20"), "Việt Nam" },
                    { new Guid("c7b7f282-9205-4d76-8012-f7b6d42de64a"), "Pháp" },
                    { new Guid("e52649a0-d820-4834-8ac8-7cddf941828e"), "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("332cd865-ab53-403c-9fab-e399641a2dda"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("4b08ca9f-d2ac-4824-b103-acb11a5eae98"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("58b2e3f0-9a2d-41a9-b190-4fb6cd763e7c"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("764fc128-97cf-4130-a89b-4ad4bf4ab4f4"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("7c994d97-0272-4ce9-a091-f467eaac69de"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("c910d0fe-d39c-4382-8b49-279f20613480"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("d3893182-214f-4489-bf35-fd1314e5cab0"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("dcdd70f8-579f-4898-96ad-2e49f12aa070"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("05fb5431-3fd0-4488-b75f-9af353c45ddc"), "Combo 3", null, new DateTime(2024, 12, 22, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6491), null, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 3, 75000m },
                    { new Guid("890a9247-e4f3-4af3-b0da-1c7a48d2ada9"), "Combo 2", null, new DateTime(2024, 12, 23, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6489), null, null, null, "1 bắp 2 cola", "combo2.png", null, null, 2, 100000m },
                    { new Guid("93f3eaaa-ee7e-4283-afd7-4b17aefca797"), "Combo 1", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6486), null, null, null, "1 bắp 1 cola", "combo1.png", null, null, 1, 80000m },
                    { new Guid("c74ff492-8220-4022-83a3-664eba2965fc"), "Combo 4", null, new DateTime(2024, 12, 21, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6494), null, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 4, 135000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("00e3fce7-3fb9-41ca-8ef8-dd6f26502856"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("00f3725a-545a-418f-a533-89edd6571b4d"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("0c4270e6-c07c-4cad-8c33-0fd748791002"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("439e9bae-6724-4497-8679-4f2c1b1cdda2"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("4c0f3b5d-cc65-482e-aad2-bd452bf73caa"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("cf037411-34f4-45d3-a5cf-ea74d223ca4e"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("e2dcdd43-95ae-4e93-8d29-ba87e3485a2e"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("fc84d8fe-093f-4ace-883a-02f228b10c7c"), null, null, null, null, null, "Phiêu lưu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("04a0cfa4-68fd-4724-8971-19db70d1565f"), null, null, null, null, null, "USA", null, null },
                    { new Guid("135a4d89-eb6d-424d-bba0-0e20f74f68a8"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("b1e2bca5-a879-4fea-b765-bff24a6f16f6"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("ef216cff-4848-4859-8746-48f9479e8885"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("fedc47f2-78c6-47c2-a698-8b23ba7cfbbc"), null, null, null, null, null, "VIE", null, null }
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
                    { new Guid("fd55a274-f2b5-4d2e-a375-4ab40d57dcf8"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("ffffc84b-c63c-4329-8235-fadc4cd1ce28"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4337), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4362), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4360), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5444), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5445), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5440), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("05f333fc-16ab-4f14-8c9d-5715d7d86a6e"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("1fe9536c-704e-4d7e-89a8-5ddecfb51d13"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("25bf583f-56ee-4385-bf01-73f34b3a1d23"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("394ad27d-99eb-4613-a320-a184b281cb6a"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("6cbd13e6-b147-48aa-8d8c-36adee646bfa"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("707a3b2b-7232-4385-a919-af5f7ecf48b7"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("7596159e-148b-4a75-a308-a3576cd1c3f7"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("774f916e-78cd-4597-9ca9-70920f5efadf"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("be2e224f-c1f4-4038-b5a4-99b4f5500966"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("ffd897fc-ad43-4eeb-8326-d4a973f59a42"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 }
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
                    { new Guid("34767c3e-5838-4292-bb50-0430794a018c"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6232), null, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 100, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("3de50cc7-c90c-4742-a3c2-cabcda795632"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6210), null, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("7c994d97-0272-4ce9-a091-f467eaac69de"), 120, new Guid("439e9bae-6724-4497-8679-4f2c1b1cdda2"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("4e1d145e-991d-4166-be81-217d6f2a2bf4"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6266), null, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 127, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("59828afc-78ec-4029-a274-0be53360bd57"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6260), null, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 134, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "cuocchien.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("5d4d8cb4-8ba8-4a83-8037-bbc445a99f2f"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6217), null, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("58b2e3f0-9a2d-41a9-b190-4fb6cd763e7c"), 110, new Guid("00e3fce7-3fb9-41ca-8ef8-dd6f26502856"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("695ccd45-2557-4068-95db-d800cf8228bf"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6238), null, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 113, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "cuoixuyenbiengioi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("6bc1101f-f327-4937-8fce-8b7b0bc3b390"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6203), null, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("91212d62-6c17-4212-b503-edc2bce7d4c4"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6184), null, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("c910d0fe-d39c-4382-8b49-279f20613480"), 109, new Guid("cf037411-34f4-45d3-a5cf-ea74d223ca4e"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("a9ec53d6-5c43-4bab-b37e-90e1b85e7889"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6194), null, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 99, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("b6f7c8ee-75b0-45bd-aaf5-40ff854e59a8"), 13, new Guid("314ed748-e750-4cb1-83fc-bf1d65b6ca97"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6177), null, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("58b2e3f0-9a2d-41a9-b190-4fb6cd763e7c"), 113, new Guid("00e3fce7-3fb9-41ca-8ef8-dd6f26502856"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("da306db8-48bb-4d10-9099-c4e7e82194f2"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6245), null, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 123, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "kinhvanhoa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("e4c70a93-76d8-4c10-a6bc-72c62d0e91e8"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6170), null, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("7c994d97-0272-4ce9-a091-f467eaac69de"), 81, new Guid("00e3fce7-3fb9-41ca-8ef8-dd6f26502856"), "xich.jpg", new Guid("fedc47f2-78c6-47c2-a698-8b23ba7cfbbc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6158), null, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("fe965086-73e6-449d-8381-6dff88d5f8a0"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6225), null, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("c910d0fe-d39c-4382-8b49-279f20613480"), 110, new Guid("cf037411-34f4-45d3-a5cf-ea74d223ca4e"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("fee58aa4-44e6-49e2-8520-8762cdc3f619"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6253), null, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("92ab3732-21fd-49c9-9ea9-9d1df25e3d1a"), 118, new Guid("f34d2746-e6c5-4de1-b5dc-f4f4714917e2"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/1KtBhnTfq8I" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5503), null, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5508), null, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("12a10f42-3a65-4780-8ba7-9e34f5866648"), "Nghệ An", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5047), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("234d626f-4d99-491f-a122-16a39617cc42"), "Hà Nội", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4923), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4c41c992-6982-49bb-8c61-fb5f344bba2b"), "Hà Nội", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4515), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4cd20e3a-4334-4858-aa56-9484b0c95e5a"), "Hưng Yên", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5121), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4cdee4eb-9c88-4311-8008-dd493de28939"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5012), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("64fbfaa7-8384-432d-ac1c-d47f401316be"), "Thái Bình", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5100), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8efe3e42-2854-47ee-b9eb-eec19a4a454f"), "Quảng Ninh", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5172), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a10c329f-d35b-4705-b161-7c25a1a1aa28"), "Hải Phòng", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4954), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a863ec17-dc39-483d-bcbc-6c1c2977f286"), "Bắc Ninh", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5077), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ad522676-3a55-445a-a82c-7ee378cc060d"), "Đà Nẵng", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(4982), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("e9b85d3d-fe42-4320-a56a-7a2db277d41c"), "Nam Định", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5147), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ecc83e92-642e-48e4-b9ed-e64763dd45d0"), "Hà Nội", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(5195), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "PromotionID", "Status", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("11819507-1f32-4915-9441-e05d72353c24"), null, "BILL009", null, new DateTime(2024, 12, 16, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6597), null, null, null, null, null, null, null, 0, null, 350000m, new Guid("4cd20e3a-4334-4858-aa56-9484b0c95e5a") },
                    { new Guid("253fbb73-ae9d-4714-a2d5-773f2e2593dc"), null, "BILL002", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6568), null, null, null, null, null, null, null, 2, null, 300000m, new Guid("234d626f-4d99-491f-a122-16a39617cc42") },
                    { new Guid("37142cb6-4e50-46bd-9f7f-c956b339e8cf"), null, "BILL007", null, new DateTime(2024, 12, 19, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6591), null, null, null, null, null, null, null, 1, null, 800000m, new Guid("a863ec17-dc39-483d-bcbc-6c1c2977f286") },
                    { new Guid("482d8756-62bc-4981-8630-c8842f63debf"), null, "BILL005", null, new DateTime(2024, 12, 21, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6583), null, null, null, null, null, null, null, 2, null, 250000m, new Guid("4cdee4eb-9c88-4311-8008-dd493de28939") },
                    { new Guid("6adc43e2-29fb-4fc3-8bc1-b622199cbce6"), null, "BILL010", null, new DateTime(2024, 12, 18, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6601), null, null, null, null, null, null, null, 2, null, 700000m, new Guid("e9b85d3d-fe42-4320-a56a-7a2db277d41c") },
                    { new Guid("9244cd74-92ef-473b-958b-758e9aebaa52"), null, "BILL004", null, new DateTime(2024, 12, 22, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6575), null, null, null, null, null, null, null, 2, null, 200000m, new Guid("ad522676-3a55-445a-a82c-7ee378cc060d") },
                    { new Guid("acb4e2f9-1bfc-4e3e-ab34-fbf55347f4ac"), null, "BILL006", null, new DateTime(2024, 12, 20, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6586), null, null, null, null, null, null, null, 2, null, 600000m, new Guid("12a10f42-3a65-4780-8ba7-9e34f5866648") },
                    { new Guid("c3667a62-c114-4de3-895f-83efa143c5c8"), null, "BILL003", null, new DateTime(2024, 12, 23, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6572), null, null, null, null, null, null, null, 3, null, 150000m, new Guid("a10c329f-d35b-4705-b161-7c25a1a1aa28") },
                    { new Guid("e3876444-47bb-415d-ae6b-c7e1938b475d"), null, "BILL008", null, new DateTime(2024, 12, 14, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6594), null, null, null, null, null, null, null, 2, null, 450000m, new Guid("64fbfaa7-8384-432d-ac1c-d47f401316be") },
                    { new Guid("e7986c8d-54f2-4ceb-8172-2c923d352421"), null, "BILL0122", null, new DateTime(2024, 12, 20, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6589), null, null, null, null, null, null, null, 2, null, 680000m, new Guid("12a10f42-3a65-4780-8ba7-9e34f5866648") },
                    { new Guid("f5cb56e3-6c60-47f7-a86f-2539288d5282"), null, "BILL001", null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6562), null, null, null, null, null, null, null, 2, null, 500000m, new Guid("4c41c992-6982-49bb-8c61-fb5f344bba2b") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("905eee70-0641-4d3c-8275-8ba40633e222"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6690), 1, new Guid("4c41c992-6982-49bb-8c61-fb5f344bba2b") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("06f7912e-e660-4d24-a0a4-d198a1ae8389"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6353), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6352), new Guid("be2e224f-c1f4-4038-b5a4-99b4f5500966"), null, 0 },
                    { new Guid("1a7bd996-665f-4b9c-9934-c716e70b6155"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6358), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6357), new Guid("774f916e-78cd-4597-9ca9-70920f5efadf"), null, 0 },
                    { new Guid("44ca0ee5-0e9d-416b-b13b-86ad862afe01"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6371), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 28, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6368), new Guid("394ad27d-99eb-4613-a320-a184b281cb6a"), null, 0 },
                    { new Guid("520f75c4-4cb9-43a9-96cd-e084a3909b05"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6365), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 29, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6364), new Guid("05f333fc-16ab-4f14-8c9d-5715d7d86a6e"), null, 0 },
                    { new Guid("99a4f258-35f9-4094-8af2-6b80d3786ddb"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6337), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6335), new Guid("ffd897fc-ad43-4eeb-8326-d4a973f59a42"), null, 0 },
                    { new Guid("b525614c-b7be-428a-a363-b172d797e0ad"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6349), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6347), new Guid("25bf583f-56ee-4385-bf01-73f34b3a1d23"), null, 0 },
                    { new Guid("c309cc12-0b93-44d3-9b43-409e023949f1"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6361), false, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6360), new Guid("6cbd13e6-b147-48aa-8d8c-36adee646bfa"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("002d1ae6-b8d8-4f5a-a167-be25e62083a0"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00f4f9b0-378b-42d9-85ee-965bf8c9406c"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03306825-264b-4323-9d6e-b8de57681653"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0434d9f4-d753-4225-9431-2b5c2eaaf04c"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04ca1147-eb55-448f-bea4-ae45e3b9a2bf"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0652ed3b-05da-4c29-8216-632af29dd03d"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("071bd5c5-3bb7-4bec-b664-4ed3ef6811b6"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("074886bf-7839-4dd0-b9e2-67e39ec159ef"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("081c3089-500a-44a1-8c97-d4ab91f5f402"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("083c32fa-0d92-40ba-8da0-d68a7a9681e2"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08412743-044e-4d7c-bf1d-ddb414d597f4"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0921528e-5ebc-43d7-9056-6885b12a7d6b"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("095f90cc-4587-4779-bfce-a707359e79b0"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09e878b7-00d8-46cb-8c6d-f9ae7054c2e2"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a1544ef-50bd-4f0a-b686-2e2a960f109b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a2c6696-6e5c-409c-8a19-a1194ffd8319"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0aec79cb-8221-466c-b805-b5f7cf2d1e96"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b91f023-4f0c-44b4-857f-0ed805ddf5d8"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c62b96d-dbb5-49a6-a270-29b75d4b9456"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0dcf30f8-8610-43ea-a9f4-6b9cfba8aa21"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e24cbba-ff20-47dd-94c9-a6f30bc3e3ac"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e93ca0c-6fd6-447d-af3b-3b6679fd57bf"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11af9d2a-ca43-46a2-a330-d91c2478f4fb"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("124c467e-3be9-488b-8378-9354eb711d58"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12e7e0cc-9a96-4d4a-9781-9c50c862a7fc"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("133872bf-e563-4e8b-a40d-35e50344a64e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("156332af-de88-4f48-ba5f-d6dc5a192f2e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17dd4681-6eb3-4de7-8b8e-740739b86a02"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("183f5c62-f847-4171-9f71-adbca71e3865"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("185c7f01-7af7-4c53-bedd-bc081b62927a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18b33bd2-2f4d-46d4-b454-06ddbf1c2e4d"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18cc5565-6d38-4711-81a8-b7a94054d3c8"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1bf13106-91e9-4d7b-8a21-ef1c06a2fa56"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cf078f4-a932-4e6a-a4e2-0f7b5d550066"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1dfa422a-82a8-4be9-949c-62d5d6c54ba2"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f4551db-034c-4586-838a-bd33d7d5ec1a"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1faaf307-dbd7-41f2-ab5a-339afc884fed"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fc94ee2-959e-4420-a867-3576c7436434"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23def744-398f-4fac-8516-44af04b448c4"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2476f3ce-6b7b-4384-95bb-5b157cd8cf49"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24b7d56b-101a-46bd-b8e2-45c6f9056bae"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("254b9b56-ed4d-489d-8c75-73c3d7687140"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25587b8f-4c19-406d-8ddd-bcc5ae563b2e"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25dcafb4-a9a9-4efd-903d-f085c2cd1f96"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("262cefc0-27cc-498b-a80e-a894dc6c8a20"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("266b96a1-f83e-47a5-ae59-889e56a255a9"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("277455d3-d651-4939-a8e7-f4fa05977d20"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("28798323-4fba-43e1-b680-a354ec2b4391"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("28a7ded2-647d-4f88-aede-e32d3e97168a"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29d6013a-8e91-4959-8ee7-2cc6f766b390"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a128055-8b61-44da-9a9d-4cf7e61cf115"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2bb5ad85-677a-4fb9-9477-9cba51256a7a"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ca9763d-f10e-4f10-9a17-fe4a1b8e8970"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2fae5c14-250f-4007-bfa1-beea6d368e8b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ff7f61a-35c4-4178-b3dc-c66c97bc3531"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("327028d2-e494-486f-9dba-e36f10961605"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32d0392b-3f58-4530-9453-825dae5ffef3"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3429bc1c-5283-486f-bfd0-02d9840191fd"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("345e13cd-c664-487b-9b75-1d6efab56dce"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34f6bc27-7a16-44b9-ae18-a94dd6cd73a6"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35a3bc0d-d063-4479-bae3-662d212db234"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35f3b1c6-e0ae-477b-a040-b92ecd1eb342"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("361edb0c-8c6f-453b-9002-f445d3272228"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("396f14ff-af21-4d88-b831-4f6e4e56a00b"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39f85465-3a0c-48c3-b2be-d4bff4cd7755"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c919b50-159b-4c4d-8dd6-f3ba0600968d"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ccfc17b-6193-48e6-804c-a3ed823ecb69"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d64aa45-1ea8-4e90-a2ad-bf2e15537be0"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3dca373e-c5eb-42cf-a250-021a6e6cd50f"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fb44dbc-f064-4388-994d-c22b3b12768f"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("420f1e33-2232-4a69-a0e0-d7dea4cb5919"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43b941ba-20f9-40fc-a719-c84ead7d85a2"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4475f349-85d4-488c-abdf-8f1537631043"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4540a0f3-ad78-4ab3-9050-5fdc3da328f5"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("466a1bfa-c3ee-4565-b347-07e7f0e3f0ae"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46ac9a95-54bb-4528-999b-a70c927b3038"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4996e660-e74c-4501-8b7b-5d440495d975"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49bedaaf-79bb-48fc-bb13-8945bc72ae1a"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a6d68cb-50ed-4bc0-bd90-62ca2d8ed0ce"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ba59e25-e9ca-4c9f-ba42-79575e718737"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dc0898b-db59-4362-9482-ca0ba1163587"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ed3c458-aad5-4870-9245-7cfc758f496b"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4fe3392c-526b-4425-b6c1-6def0c7c3d83"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("503dec8a-c5e8-4b6b-92c5-0c5cde7a46a1"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50903c71-eb92-4894-9f59-c5cf472cc2b7"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51a43bc3-9e0c-4777-9bb3-8860b8ad1183"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("531eeb7d-0f93-4a41-83f2-eeff328e1a15"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5395ed50-83dc-4a8f-b05b-4d84bafc4a2e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53f32df5-ae0c-4f0c-a41b-75fa70a85943"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54d3b518-1b3a-44b2-ae4b-ccc0f3e1145e"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54f9be47-cd35-40f5-bbf2-b5963fbcee39"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55a157c2-f88d-4404-84c5-c8bc92c93f57"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56ef6102-c394-49be-9073-d1b86217466f"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58053216-5cd9-400b-9a6c-1714157b3dca"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5865da1f-4ca0-41da-b3e5-1a8824128640"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58725cb9-031d-4611-9b71-d2fb7c064f49"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("589d8fae-3a27-45fd-924c-e64ecffa7564"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("590f9cc6-5eae-48b9-8f52-56e34767026c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("591369e3-826e-4bb2-a879-2b52d88d7602"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("594a9870-27dc-40d2-89e2-afd8b478f188"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59d68fb9-0b17-4199-b683-ddd30a81ee49"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5aa9cff8-b5b7-4cd8-b070-f1221c9bf4e8"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b44143a-1f8c-4b8f-9ffc-88a50a229800"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c435430-3d19-4979-8e66-326cad5965b5"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5dc270a7-8e64-4f77-ae05-97ffcaf480f2"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5eddf4fb-15b0-4551-af20-bd0a12a85fd3"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("605e0bfc-eca2-4ba4-ac38-7a2a7c9785f5"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61333581-8340-4af9-ba37-160fe09a63a1"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62be1155-2b81-4c4a-abc2-a7a52ca79f44"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63fd186a-1f16-47ce-bd00-78b25090b74a"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64860666-9957-4df0-ac97-b83a612f74bd"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64c8e7a0-f64f-45e9-ad44-d76642a0aa4a"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64dfab24-dcb6-4b36-98ea-5ea6ee702e39"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64e6101e-53b0-4fee-9151-6c1981536d61"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64f1f7e0-e7de-4fee-a334-673d7ff62fd5"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65dcbc71-5d55-4615-a76a-9eba1aa52c5b"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66da6b46-65a8-4278-8282-177c27d27859"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67473de4-43f8-47e8-b83c-626280f9e55f"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("689ba66a-32c1-4108-baae-99b4d36d06b2"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ab86b95-119c-4d33-9144-57a6b124a0c7"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ac79849-4a58-4337-bb78-224f04d79052"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bcceb5f-0dff-4d6a-ba7c-2c98f730b9fa"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ca9f557-b626-414a-8a2c-e7684b7c2c02"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d59eeb7-726b-42e3-b436-1ca3a47d982f"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e00013a-10e3-483a-a681-c155a3f3d4fc"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("723a563e-8208-4f7b-9408-7aa00e6336fd"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74401e27-97c0-4a71-9bfb-7cfbe630f347"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75906d27-2c65-4d92-a0ce-497aa68a5473"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76f2a990-7cd7-4ed1-b81f-49ea2d204ebf"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78cde0b0-6004-4f6a-b569-719598710a97"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b85557a-e6df-492d-baab-16e26e073fce"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c85327e-5c54-4de7-84c9-6711f426cf21"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d619341-44b4-4036-b862-88a98cf4ce7d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7db6e53e-319b-400b-99af-b18415da6e05"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81490979-6591-43fa-b73d-49048383e1a5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("824d1756-1175-4b2d-b85e-5541525d49f5"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82a675f8-2923-4cb5-b69d-f06aff3d77d9"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82dbf289-ebfb-4134-ac93-f4404934aff0"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83cbfc9e-3cdf-4454-8092-d85d5ae70c69"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("857dbe56-b611-484b-9e46-b0202919b93f"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86622c7f-2381-402a-9ede-46be79f94ada"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86667da7-2693-480f-bf5c-d40f264d1763"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a3725a6-5541-4ca1-97ba-24dd54fa1821"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8aaae148-8555-48de-b3c4-45ad1bab1144"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b534385-f332-495f-84ad-685deb52a5f7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c940cc4-f6c6-4a21-bd80-ee15bcde2152"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e9a8b08-1579-422f-900d-f6089f1c0e24"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f7bc023-fc05-460a-b18e-0195646c3279"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("905e1f57-34ae-4cbe-b3be-4fc490822ad5"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90879524-1066-45ea-b6c0-bde53701c9c1"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91c3590f-c457-4d70-b39c-4478e7e10abd"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("924cdb2e-4eb7-48be-8489-4f7777f1a2d1"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("926722e3-819a-4e0f-8fca-609c2ef903b1"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("939a1230-b0bf-45dc-b9fe-36c0205a3b72"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9460db8f-bfcc-4f42-ad04-0670252f2413"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95083574-8922-4abe-bb84-1d588f51558f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95813bda-8bd2-4965-8ad5-9a4089794667"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("995c8ed4-cc8c-4d8e-ae8d-6b4d59745fa1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c4a9029-e971-48d8-8c16-588c1887d96a"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d688e4e-7891-4128-be07-a4bb5f0a67e4"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e5f8964-be1e-4aa7-a0ad-8f9b73b6b9ff"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e9248ad-f773-4fff-bfc0-a3ab1dcd9f74"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ed6a62a-01af-48a1-bb78-7174135fdca5"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fa966f2-1d16-47f1-b843-21f696b9ccd8"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fc33b81-587d-4a0b-8382-9f720461dc7f"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0e7d145-d842-4f99-a737-a7498384fdb8"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a25b923b-dd73-4fb6-a0e5-e7390d39088f"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3b48961-d748-4124-b87f-abae0830388d"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a46e1208-e484-485d-9ea4-8954792a29fd"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6b1bdc2-394b-4c1e-b8fc-39c0d8ee23e8"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a764f52e-9277-4546-9b8c-d3093cb9449f"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a76ac7ad-6c07-4f45-ad22-56d56bb065dd"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a80d3515-4ef5-46cb-8ba3-9dbfe53f028b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8498e5a-2184-4dfa-8b3a-bd3560d0fff7"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a949eb12-d94c-4c1c-9b84-d6f2dc72bf02"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa5c1b83-9761-46f4-8fb6-edc933731ad8"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("abd71960-3075-473e-93a3-d6907c9ab9f6"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("adedaae0-73a5-4472-9a64-9a0b7a61d7f5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0e4839d-641d-41f6-bf17-0d95c16626a0"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b190986c-775b-428b-9dd1-ee49506a5e20"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2652fb7-ac74-4ae8-981e-3b2f89e1ca25"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b27548ea-09a6-4583-bf15-7889069b1fd9"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3ddd61a-a76b-44ce-be66-a348379619d7"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4d9c952-3549-418b-9c62-249a6b89bf82"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b542ef72-e556-4397-bc6c-0621fc436b3a"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7db71e0-d2b0-4e51-bddb-da743f752b2e"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b81427c1-ea9d-4f60-b494-baf7ba2a2181"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b835f268-7ae0-444b-99d1-eca55bc15709"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b8aaa1d8-a5d6-4e91-9b5b-c01d44f6ce27"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b901c389-ac2e-4394-8259-161e1367667d"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbc2baef-4980-4ead-8a01-814817ad80b6"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bddca2e1-9c7f-42dd-90d5-9d59f42bd24e"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bfcd1e28-b8ed-4395-b884-9d8def327f32"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c358e2ec-ddd0-43fe-9d20-11a875e434b6"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3bd3da8-ce73-4f71-a84a-3f3a0f0f487c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4be2a2f-65f5-4b56-aee2-4770047f7e72"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4fa774f-4d5a-44f0-806a-e852247c3d1e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5301347-6c44-4f97-b5bb-633929656913"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6023435-1bda-4069-b70e-60abfc89ad66"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c813ac22-1c9d-4bbd-8f16-9c4b97d58f16"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9cdce56-0e89-4fc4-add9-396925f9cdd2"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca15785f-54cf-4c6a-8842-b4839a7ad7e7"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb0591cc-eb45-4f2f-8f12-5a9e4d63c37d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cba33925-eea6-4d1b-81a7-84d1bc0f8e1c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbdb50cc-03a4-4e2d-99e8-0b6f1b366721"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd42188d-1344-41e6-9a81-f43a436380f9"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd43565e-0774-49b1-bc3c-1a95cce437cc"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cda08325-1891-42e2-a440-a67dcbe75f8c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cda29a01-233e-4320-b073-217243c02406"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ceeaf0fb-f40e-4ba0-adde-acea4f63cdd9"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf9cb056-5ac8-43ff-87f8-db07e857af54"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfb57348-1cf4-4130-8cdc-dd6850125784"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0c7b0db-a87f-43de-aaaa-d6791b32af96"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d13a416e-738d-46e5-bc2a-86c5a5fd0d0d"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2c42fb3-f951-4b20-80d7-2928ca0ddc0a"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3bb0331-eea7-4d07-91f0-90431a92e014"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d460edeb-1a32-4e0d-8094-05e9f7736dcc"), "H", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d51eaf4e-2237-415f-b4a7-064b47f94c4f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7e849b4-9255-4143-99f7-c9c0c8b5aa63"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d885445c-255a-426c-a1f7-8a2cfa74d8cb"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8fd1e42-5d4b-4fc4-a430-ec6ad7e311c1"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9368050-1942-4a4d-bf7c-982c5602bb03"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9423132-1191-49b6-a662-2ccb418ffcec"), "B", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d96433b7-6a07-4c38-85a3-309db370b8e8"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da69d36f-0446-4463-9c32-8493ee982f65"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcb81867-3694-4004-85c2-82ec60b55751"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de01303c-9cfe-45fc-9ae8-1af6c589fd3c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1187dda-ce6c-4fce-8d6f-181fd3ee52c5"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e25d45c5-92ff-4ed4-bd76-b1b70f055cf0"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e47a4162-c7a2-4791-b665-94f6aee1179d"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4f4641c-349c-4842-adf7-11a33951eba0"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8944d40-2087-4b8e-bc6e-0dd8c035b8a7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8dbf836-6e13-475b-9015-a8abc5f7e2f9"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb2159e9-ad0d-4921-882c-548e3348971e"), "E", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("edf3a352-69a2-48e6-87bb-614f178f48a7"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee17f27b-d54b-497f-a7f7-51378fc9581c"), "J", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eedaa533-7c7d-4b1a-b500-ed5191721d7c"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef33bb91-ba3b-4cd2-9e60-30f8c43eb1eb"), "C", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1a6a051-88ac-4c78-8aa6-86777469d49c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4d29491-f9b2-4e79-ad55-9d539893d487"), "A", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f53bbd13-86e3-438f-a287-9eb667d46e26"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5e8a04f-28f6-47ab-a994-3caed96c3e83"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f647d2c3-a28a-4a47-98e5-9ca5525a0722"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7b6faf7-be85-42a2-a88c-2428e4d8ec24"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7ba093b-e8ee-4e5f-9180-359dda4bf354"), "F", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f88e806e-4cd6-4eb0-97b3-0284ced36841"), "I", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa840f94-0cef-4e8b-963f-47078fed592b"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa9fb990-8608-4397-93d7-b7feb139ab7e"), "D", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fadd43e7-cad1-49c8-933a-7591fd87cec3"), "G", null, null, null, null, null, null, null, new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe669b27-8c12-4800-acf7-70cb8b14addf"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("107ed061-1b06-4a45-90be-5764f5fbf4ed"), null, null, new DateTime(2024, 12, 26, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6309), null, null, null, null, null, new Guid("e4c70a93-76d8-4c10-a6bc-72c62d0e91e8"), new Guid("ab2817df-c260-4e1f-94d2-2dbf4380df5f"), 1, new DateTime(2024, 12, 24, 11, 42, 40, 600, DateTimeKind.Local).AddTicks(6308) },
                    { new Guid("8e5a8175-1462-4a62-b602-e57276b4210d"), null, null, new DateTime(2024, 12, 25, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6302), null, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 24, 11, 41, 40, 600, DateTimeKind.Local).AddTicks(6297) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("c467f31f-5382-4430-bbdf-c77402c1c58d"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 24, 13, 40, 40, 600, DateTimeKind.Local).AddTicks(6709), new DateTime(2024, 12, 24, 9, 40, 40, 600, DateTimeKind.Local).AddTicks(6709), new Guid("4c41c992-6982-49bb-8c61-fb5f344bba2b"), new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6708) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("253fbb73-ae9d-4714-a2d5-773f2e2593dc"), new Guid("890a9247-e4f3-4af3-b0da-1c7a48d2ada9"), null, new DateTime(2024, 12, 24, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6660), null, null, null, null, null, 2 },
                    { new Guid("9244cd74-92ef-473b-958b-758e9aebaa52"), new Guid("c74ff492-8220-4022-83a3-664eba2965fc"), null, new DateTime(2024, 12, 22, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6665), null, null, null, null, null, 4 },
                    { new Guid("c3667a62-c114-4de3-895f-83efa143c5c8"), new Guid("05fb5431-3fd0-4488-b75f-9af353c45ddc"), null, new DateTime(2024, 12, 23, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6663), null, null, null, null, null, 3 },
                    { new Guid("f5cb56e3-6c60-47f7-a86f-2539288d5282"), new Guid("93f3eaaa-ee7e-4283-afd7-4b17aefca797"), null, new DateTime(2024, 12, 22, 11, 40, 40, 600, DateTimeKind.Local).AddTicks(6657), null, null, null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("41dea2d4-de0d-4c03-97bb-5f271c99a839"), new Guid("f5cb56e3-6c60-47f7-a86f-2539288d5282"), null, null, null, null, null, null, null, new Guid("b6f7c8ee-75b0-45bd-aaf5-40ff854e59a8"), 3100000m, new Guid("06f7912e-e660-4d24-a0a4-d198a1ae8389"), new Guid("d8fd1e42-5d4b-4fc4-a430-ec6ad7e311c1"), 2 },
                    { new Guid("767c32e8-d102-4a2c-8452-0dfded61c43b"), new Guid("f5cb56e3-6c60-47f7-a86f-2539288d5282"), null, null, null, null, null, null, null, new Guid("ef6fd66b-d8d2-4b10-aaf3-b9aebd4d9cd3"), 100000m, new Guid("99a4f258-35f9-4094-8af2-6b80d3786ddb"), new Guid("39f85465-3a0c-48c3-b2be-d4bff4cd7755"), 2 },
                    { new Guid("abd0a13b-6e07-46a2-8f0a-bec8f413df00"), new Guid("f5cb56e3-6c60-47f7-a86f-2539288d5282"), null, null, null, null, null, null, null, new Guid("e4c70a93-76d8-4c10-a6bc-72c62d0e91e8"), 2100000m, new Guid("b525614c-b7be-428a-a363-b172d797e0ad"), new Guid("9e5f8964-be1e-4aa7-a0ad-8f9b73b6b9ff"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("39b7cf53-e0ca-4280-998a-34889e04eb6d"), null, null, null, null, null, null, null, 60000m, new Guid("b525614c-b7be-428a-a363-b172d797e0ad"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("25bf583f-56ee-4385-bf01-73f34b3a1d23"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("979f137f-1242-4c94-85ac-6c7d52e0542d"), null, null, null, null, null, null, null, 50000m, new Guid("99a4f258-35f9-4094-8af2-6b80d3786ddb"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("ffd897fc-ad43-4eeb-8326-d4a973f59a42"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
