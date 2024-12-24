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
                    { new Guid("87799fad-175c-40e9-a85f-94d7bd3eeb0d"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("d2ee7907-9d48-45f9-858a-db5c16725483"), null, "mua tại quầy" },
                    { new Guid("ea9a86b0-09e8-48ab-89a1-e1ce02be2933"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("e0be44ef-42aa-4756-b0ae-e859e78d76c8"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9523), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("9d92b4be-7673-4223-bff8-7dc3ec19656a"), "11:00 PM", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9527), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0189e990-e21a-4000-adb4-968a6c8e6688"), "Pháp" },
                    { new Guid("0d909c98-808c-4812-bb6e-48d7daefb9e7"), "Hồng Kông" },
                    { new Guid("69575267-03cd-4058-8361-f986251b59e1"), "Trung Quốc" },
                    { new Guid("82156b6d-5467-4964-bf29-69974bf68d93"), "Ấn Độ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("a21d647d-3bf5-4a20-8dbc-336cac9654f1"), "Việt Nam" },
                    { new Guid("b42d6818-43bb-4cf3-9238-cff676b98e6c"), "Úc" },
                    { new Guid("d1df3472-b743-4ac6-b027-1d5cbad5f312"), "Hàn Quốc" },
                    { new Guid("d3984bda-4916-4b25-800f-ee9d8601decd"), "Vương Quốc Anh" },
                    { new Guid("f2e73916-1a5f-4670-9d47-a4cf7b4d747c"), "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("10018c37-c548-4740-a6cf-74ffc0c9e60c"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("2137f880-db34-4e83-bc69-fbf5a2eeb236"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("235a5763-4df6-4ad1-8847-7105ad9b0841"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("255fbb87-238a-4d20-804b-a3ba0017302d"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("800480dc-7e7c-4dc0-8b30-c6276c5e842e"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("aff43723-2430-480a-b98e-1c88fe4e5512"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("ba30c525-40e5-4c51-a29b-73102d020d81"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("c5d2a780-0210-49ce-95f7-9e8d89c7de80"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("17921c63-706c-49a7-9986-a9e428240d68"), "Combo 1", null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(526), null, null, null, "1 bắp 1 cola", "combo1.png", null, null, 1, 80000m },
                    { new Guid("37c7a46a-ffcc-4163-a478-5ad121e40029"), "Combo 4", null, new DateTime(2024, 12, 21, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(537), null, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 4, 135000m },
                    { new Guid("6f71221b-21d7-4526-b36a-1a539213f416"), "Combo 3", null, new DateTime(2024, 12, 22, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(533), null, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 3, 75000m },
                    { new Guid("a336b81f-5964-4798-ad1d-57fd8149e403"), "Combo 2", null, new DateTime(2024, 12, 23, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(529), null, null, null, "1 bắp 2 cola", "combo2.png", null, null, 2, 100000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("293ae831-9c11-4c0c-8094-41e3e9cbbdf9"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("4c70c8c7-26ff-40ea-9c45-03f422548c93"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("507041c9-bc4a-447c-af3f-6afee691acbf"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("903b8a50-94cd-40f9-ac0b-5466b8346ad2"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("ab37abf6-f115-4b8e-9bdc-108d7f208d09"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("b1f1de18-ab6c-468e-bd83-d6438ede3d0f"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("c9cb2deb-b342-4ee8-9dde-bfe82fb7e5d9"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("f99a61f7-0fbc-4c34-9d86-18b528627c27"), null, null, null, null, null, "Lãng mạn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("17acb37d-10f0-4331-b8cf-22442aa1cf24"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("2be44c74-f59e-48e8-85bf-7ab3181cab75"), null, null, null, null, null, "USA", null, null },
                    { new Guid("364c86d6-84d9-495e-8b47-b94bc1301f85"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("55d1a14a-bf0d-45e4-8bc1-931f401cb90f"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("ff49249f-008f-480f-b842-df26767823b3"), null, null, null, null, null, "JPN", null, null }
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
                    { new Guid("1589375a-9267-464e-97aa-a2bc23298b7c"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("5b346486-679c-4d83-b44d-888ac457d4c3"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(8377), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(8406), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(8398), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9497), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9498), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9493), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("103862d9-de93-4784-b280-ef58c137206e"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("15f2b3c5-a1f4-4eb9-ba45-45ed4ea9eb6a"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("4abb0dd4-9537-4703-ae53-5ad1b2af06ed"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("5d930db6-25de-4248-9c49-cc637fbd9359"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("63169f03-8b7b-4cd2-8caa-cd213b6c001e"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("79fb05b0-0925-45af-96cc-0d6433e70ac2"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("9405c492-d82d-463e-a8f8-98a8b40cd0e0"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("e04c8956-391f-4751-8114-5c4b12d36d6e"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("e785ce3a-6c35-40dc-95ef-adf99270ad81"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("fb14e9c3-ee08-4adb-8c44-ef74a0748c68"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 }
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
                    { new Guid("163b1168-9fd3-47c7-90ae-b018520e2c37"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(209), null, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("ba30c525-40e5-4c51-a29b-73102d020d81"), 81, new Guid("293ae831-9c11-4c0c-8094-41e3e9cbbdf9"), "xich.jpg", new Guid("364c86d6-84d9-495e-8b47-b94bc1301f85"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("57e73941-e746-456b-85ff-3d026bf3c53f"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(262), null, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("800480dc-7e7c-4dc0-8b30-c6276c5e842e"), 110, new Guid("4c70c8c7-26ff-40ea-9c45-03f422548c93"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("6a4bbbf5-6447-4b09-b009-420cd8d32469"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(225), null, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("800480dc-7e7c-4dc0-8b30-c6276c5e842e"), 109, new Guid("4c70c8c7-26ff-40ea-9c45-03f422548c93"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("7518bda8-5bdc-4d04-ad1f-b95f471534ea"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(256), null, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("2137f880-db34-4e83-bc69-fbf5a2eeb236"), 110, new Guid("293ae831-9c11-4c0c-8094-41e3e9cbbdf9"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("774e27af-373b-46a2-8bfa-30a20d687ef7"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(249), null, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("ba30c525-40e5-4c51-a29b-73102d020d81"), 120, new Guid("903b8a50-94cd-40f9-ac0b-5466b8346ad2"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("7a00e7fa-6987-45c2-b4f0-e1a60cc787df"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(290), null, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 118, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("7fbe55bb-46d0-4d8d-9abe-619b5a354d3e"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(305), null, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 127, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("879fd82f-9435-4427-9035-bc10a0054b3f"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(284), null, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 123, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "kinhvanhoa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("8fd0887b-1054-496a-b509-2742e74403b0"), 13, new Guid("d1df3472-b743-4ac6-b027-1d5cbad5f312"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(216), null, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("2137f880-db34-4e83-bc69-fbf5a2eeb236"), 113, new Guid("293ae831-9c11-4c0c-8094-41e3e9cbbdf9"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("a621f48c-55aa-4c0b-a8a5-bf87f55738a7"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(272), null, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 100, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(200), null, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("afe2127f-f8d4-45a5-80b8-b13c399702ab"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(278), null, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 113, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "cuoixuyenbiengioi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("d0560df4-0f36-4722-afdf-ec7ddfd249a1"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(296), null, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 134, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "cuocchien.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("e3b35cda-c048-47c2-9571-d941adc11633"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(232), null, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("79be6860-e9d6-4455-8fba-2de29be78f0e"), 99, new Guid("4aa2472a-91b8-4c96-b100-e57a6b1c6741"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("e4f53ac8-ec18-4458-b55d-1a2eee370cb1"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(240), null, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2gFjV9v7QVE" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9564), null, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9568), null, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("130b1f80-4725-4d96-8072-49ef2042b51f"), "Hải Phòng", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9037), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3a2376ba-6f8a-4090-822b-0a46c4b64afa"), "Hà Nội", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(8632), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3d4cc5c5-8d87-40ea-ae21-a46c00c78ff6"), "Thái Bình", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9171), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5509a1ac-0787-4e73-ac9b-66ed70fd6d11"), "Nam Định", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9214), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6d0523ea-1c35-48e9-9878-b3edc48f10f5"), "Hà Nội", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9007), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7528b64a-069d-4e32-91f2-55795ed1ca8e"), "Hà Nội", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9253), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("7b679602-8f20-49d6-b342-b60af6ae9518"), "Quảng Ninh", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9234), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8cf974e4-a612-4d5b-b2cf-ca3b029d7fe1"), "Hưng Yên", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9193), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a1931b12-73b2-4eb4-be80-b252147c75c7"), "Nghệ An", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9123), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a69bf531-5cd2-4814-810c-6860c4d79ffe"), "Bắc Ninh", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9150), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c5e4b971-a9ff-4526-b873-7735f2a813df"), "Đà Nẵng", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9059), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d43fd482-4f24-41ac-9fb4-da616a0628bd"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 24, 22, 35, 7, 21, DateTimeKind.Local).AddTicks(9101), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "PromotionID", "Status", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("0890b743-c61a-4c7c-896c-8ca9e789a1ab"), null, "BILL007", null, new DateTime(2024, 12, 19, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(630), null, null, null, null, null, null, null, 1, null, 800000m, new Guid("a69bf531-5cd2-4814-810c-6860c4d79ffe") },
                    { new Guid("2bbdc594-d267-4ee1-bfc3-c2c2e722d2c4"), null, "BILL004", null, new DateTime(2024, 12, 22, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(606), null, null, null, null, null, null, null, 2, null, 200000m, new Guid("c5e4b971-a9ff-4526-b873-7735f2a813df") },
                    { new Guid("3f76362f-4384-4b9a-83a2-dea03b92ee84"), null, "BILL005", null, new DateTime(2024, 12, 21, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(610), null, null, null, null, null, null, null, 2, null, 250000m, new Guid("d43fd482-4f24-41ac-9fb4-da616a0628bd") },
                    { new Guid("54464c4e-59cb-43e8-a738-2c525874a7bf"), null, "BILL002", null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(601), null, null, null, null, null, null, null, 2, null, 300000m, new Guid("6d0523ea-1c35-48e9-9878-b3edc48f10f5") },
                    { new Guid("5e48c616-3a48-4c5a-8651-cbfd37624e49"), null, "BILL010", null, new DateTime(2024, 12, 18, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(638), null, null, null, null, null, null, null, 2, null, 700000m, new Guid("5509a1ac-0787-4e73-ac9b-66ed70fd6d11") },
                    { new Guid("6f2a5d7d-56fa-425a-97b7-a59ef0012214"), null, "BILL006", null, new DateTime(2024, 12, 20, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(614), null, null, null, null, null, null, null, 2, null, 600000m, new Guid("a1931b12-73b2-4eb4-be80-b252147c75c7") },
                    { new Guid("729175e5-9bc1-49e7-8f84-5b49efd5da0b"), null, "BILL001", null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(597), null, null, null, null, null, null, null, 2, null, 500000m, new Guid("3a2376ba-6f8a-4090-822b-0a46c4b64afa") },
                    { new Guid("7ac1cf98-0eae-4f25-ad0c-ba298df729ee"), null, "BILL009", null, new DateTime(2024, 12, 16, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(635), null, null, null, null, null, null, null, 0, null, 350000m, new Guid("8cf974e4-a612-4d5b-b2cf-ca3b029d7fe1") },
                    { new Guid("9122e100-6d36-4223-9b4e-4e79a75efc05"), null, "BILL003", null, new DateTime(2024, 12, 23, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(603), null, null, null, null, null, null, null, 3, null, 150000m, new Guid("130b1f80-4725-4d96-8072-49ef2042b51f") },
                    { new Guid("b9c7e0f0-df9a-4578-a666-4c1482c364cc"), null, "BILL0122", null, new DateTime(2024, 12, 20, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(627), null, null, null, null, null, null, null, 2, null, 680000m, new Guid("a1931b12-73b2-4eb4-be80-b252147c75c7") },
                    { new Guid("d52e3e7f-ccd1-44d0-8b01-1048e75a07ab"), null, "BILL008", null, new DateTime(2024, 12, 14, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(632), null, null, null, null, null, null, null, 2, null, 450000m, new Guid("3d4cc5c5-8d87-40ea-ae21-a46c00c78ff6") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("a02bea4c-ce23-43eb-8c30-1e8bbd8ffe7d"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(731), 1, new Guid("3a2376ba-6f8a-4090-822b-0a46c4b64afa") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("2cfc4322-4adb-4884-8f00-11da56ac5666"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(409), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 29, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(407), new Guid("5d930db6-25de-4248-9c49-cc637fbd9359"), null, 0 },
                    { new Guid("4321136c-61f5-4d0c-a49a-c98098f409fc"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(412), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 28, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(411), new Guid("103862d9-de93-4784-b280-ef58c137206e"), null, 0 },
                    { new Guid("847a831f-e17f-4e2d-83bc-23eb92ef2146"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(379), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(376), new Guid("79fb05b0-0925-45af-96cc-0d6433e70ac2"), null, 0 },
                    { new Guid("9da32152-9b2d-4818-97f1-2dee96a70929"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(390), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(388), new Guid("9405c492-d82d-463e-a8f8-98a8b40cd0e0"), null, 0 },
                    { new Guid("a7f4d3a7-c4f7-41e0-b0cc-5e399650cd62"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(386), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(385), new Guid("15f2b3c5-a1f4-4eb9-ba45-45ed4ea9eb6a"), null, 0 },
                    { new Guid("b5ec8f4a-43c4-497d-a07b-2405e48fb1bb"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(402), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(401), new Guid("fb14e9c3-ee08-4adb-8c44-ef74a0748c68"), null, 0 },
                    { new Guid("b9aac105-d5df-4edc-bcd6-4e0d7ec1e9ab"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(399), false, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(398), new Guid("e785ce3a-6c35-40dc-95ef-adf99270ad81"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("034dd050-481e-4400-9cf5-f653015b189f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03b7b8cf-c938-4489-89f8-7370aaa45cac"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03df7ac3-6838-4b0a-93a5-efab2033b257"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04c67a5e-406a-491d-9784-f190a6af322e"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04ebdef2-0015-4977-b610-d746303ed7d9"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05c9dc52-decd-4677-bbc5-580926da4283"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("083caeed-4051-4af4-ae2a-a3e7a2b0db2b"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09433d71-1c61-48d2-b7b7-c59fc3f61d62"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a8497c6-5a45-493b-b7cd-16ee750738cf"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ab1b5b2-9086-4145-bf1f-bf458c5aa46f"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0abba70a-f8c3-4337-9aa4-690180bb7c5b"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0af38bac-709e-4cc0-a436-d871346ac891"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b8582b0-fc2b-419a-807b-fd1d7fd6e90b"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0bc2d513-71a5-42ce-a83f-55731f081e0f"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ca5bcb0-7919-488f-b32f-7b110460c523"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f0b2517-5c19-4ac8-b290-0e411515c25c"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f8f23cb-c3f7-4c20-820c-9b9151fd77df"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10fe10d2-b033-454a-a3f0-5f9bad78cd5b"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("112272e0-b6e9-4940-82f1-c4a92a1aafbe"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("141aac74-649f-40af-a769-0adc6b5aac5d"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14ace0a5-139f-42e3-b29f-b6ad846489e1"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15975f51-1ac7-4e2f-8fe2-83dbf167a69c"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("173ac8a4-4fc7-4cc4-a84a-2a7bf1cf07e3"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("176b2b2b-a649-47e6-89ea-6168acb971a0"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17b6ea4a-e681-4501-a678-25a543f7f796"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c31fbfc-576f-4f8c-9fe8-3d53f913f3e9"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c9c0c7b-c631-4906-a547-e9afdf525d24"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e94c2da-03d7-4ef9-80b7-b745ad28bd5b"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1eb90d1f-9ce0-4a24-a567-c5fc97027b8c"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("201fdea6-7c02-4778-a93f-e2d95afe0d6a"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20e84860-7f34-410e-8bea-666f5de6a430"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2119159d-cbbd-4afb-a29b-77004ea08c7b"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21cfac2d-89d9-49a3-9ca7-58a1c9fbcf95"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25580a30-4531-471b-8977-f15f9dcbec56"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2568df6c-b4a0-4ac8-a4f2-1e8eb5d76872"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25cb930c-ec31-4cad-8ab7-f670f8a4a85c"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26a5e9c7-a543-41e3-8343-666ea3a0f144"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29fe2399-0612-4e3c-a67c-0e4f5e29866f"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2bdb1c91-5111-4a86-ac52-9e3d907c899d"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c3916ea-80e4-4d28-be1f-2112890e1493"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c5f3d93-5fbf-4879-96d2-0ce62525e326"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c84d4ce-a064-491a-952a-ff455dc8315c"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d21e131-197d-4b21-bf31-a24efa7684b4"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("300b5d50-2e99-49d6-ba13-35a355296091"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3069e51c-d891-439b-98c5-5a8d9eca3ef3"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30d8a5b5-a7b9-4364-9e71-99f0068fa4d9"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3190afad-0baa-4115-9785-e3e1f7ebdd0c"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32875dbc-60d8-46b4-8c20-7474ba3f24e5"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3320d1e5-c7f8-4750-b240-cbd053272b02"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33d01796-34a6-4b6c-a695-0db4567fa5b1"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("354a6110-bd48-4ab9-b60c-155775320346"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35ae8e3f-f4b5-42cb-b24f-72914fe3d9b9"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35f5e745-2115-4ab8-9d1b-d4955b8ea045"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("368dae23-546e-4704-a139-6dded8d97a47"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36ae8bc3-a3a3-4c9c-b103-c7cdf2f45a70"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37132da3-e030-4685-8151-aace5e8ac6a2"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3791cd29-d717-41ca-a6e0-33a466d31c69"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37bef496-ab4e-4f16-8b3b-385434817f38"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38a3931c-4549-4e77-a2da-afcec326e066"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("395bb5d3-a56a-4bc5-b9af-0b5cc2975c43"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b8f10a3-5ddf-4189-a1eb-3a98204f29a5"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c88ed0c-af18-43b5-9b2c-04f78270e6bd"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3da0a408-7bde-4456-9beb-ca12eb0dd9b2"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3debd48e-a8df-4138-89c6-9842694e6ae7"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e71afea-4853-4fd2-945d-dcfe5320c876"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f2dc089-32b2-43fa-95fb-fc0d6f4a794c"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f572fa0-4b4f-4116-aa00-b3cd913f8cd5"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fb9eb88-89cb-462a-aeb9-a009be39de10"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("409a03c9-3218-43cf-bad4-a5d467e0503e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40ba0073-c460-4771-a179-55ce80896d06"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("41e6c825-b449-4678-a502-dd6cb8e0d6d6"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42b811e2-121e-43a7-8ffa-a2c9e6be7226"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43dd1050-81ab-48f7-9363-44a2c9e030b9"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("443f6b0c-5240-497a-a372-dc3d0c701063"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45d8ac8d-f66b-4dae-b63d-1c5af1758d60"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46b53d8a-9f28-4c5e-85bd-39926bc12c50"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46e99fd2-51c4-40b5-8f80-e742fd3e4a93"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47790688-931b-490f-b69f-13dcfeb22a81"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48c53220-2e61-48ec-836d-9ee1655298db"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49505b04-170f-4550-a3e2-f984be3e1497"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a9db47c-6d9b-4f64-9d03-58500258291e"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b70dbf9-02a8-420a-8c65-b19ff6a9d1d8"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b960eac-8aa1-4178-a2b2-d2b9d01d5baa"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f3389fa-6d1e-4b7f-8bc3-76badbdcbac6"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f771c61-6d3a-48fb-9a21-3a9d09c8aff6"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5133f7e1-661b-4f85-a921-adff9a9baddb"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("513dfcd3-3a53-4213-bc2c-a5784a4d0742"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51d056f9-3e9d-4076-8570-b1448e067975"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("521455c0-1f3c-464f-ac5d-dd5eeb4b6320"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("524fc9d1-b09f-4c6a-8844-9facd9878a67"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("527f8a93-692c-4f23-98f2-bdc667dd7828"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("528e9c6c-7a79-4252-9044-6a8980a4c545"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("528f4f3f-69f8-452c-a013-1eff153cc4f7"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52cd447b-5d47-4a9e-b486-ed6b6f1f2ca6"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53bf7e6d-e5ac-4bc7-ab51-f10f155889ba"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53f64d1a-19e0-46ed-acfc-08e353882268"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54e1ddb5-e9b1-4bf7-8db4-4df6bf16f049"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55508b86-5ea5-402e-9211-6f9f79bb0647"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5673d941-2487-44c6-a772-d6fce9abc458"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a26a618-6dd0-47d1-8beb-bf0b80167c49"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ba5ca73-5e0b-4925-af86-5166ef7fc997"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e28fb12-ddbf-4a7e-8248-f9d679cfecad"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5edfd5e8-822d-4ea9-8bb0-227b7a678f6b"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fa16f1b-e385-4f02-82ab-4220c1ef54ed"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6043ff42-7beb-4bc2-a39c-69a1b06ac2a1"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("612e5f0a-c146-451f-a2d5-92e72db7c1ab"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64144600-81f9-4a24-b329-3e2f0fd32611"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64543c79-57f4-4f0f-8a93-aef7dd9bdac5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("666e824d-23f1-467a-94cf-7cc202f862f0"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6750dbad-7228-401f-817a-ca342d79477d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a647c15-580a-49e8-ac79-3f139d867df5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b0aa95f-b91f-4d15-838c-c875c9426c0b"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d80f473-232e-44ad-9bf3-b224cddfa4b4"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7007b42a-afbc-4f59-9328-810692cb1bf1"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7016ca78-7f2e-42c0-bf56-5d477e475793"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72ab204e-fcd4-49fa-a349-0a8c315a2fc3"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("743b6c6c-17ff-494a-9e20-06b360b5f725"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("760c5ffe-702c-46b6-b746-92bd380c727a"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79fd55b2-334b-482a-9c77-3a6a1089b932"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a8c9111-8c10-4e80-8c54-2f440d9ed77c"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b3d479d-caa9-4c98-97ac-c272786f230c"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c2f4df5-11dc-475e-9a75-fcd44789067f"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c622131-5527-4c42-9fe6-bb02e87cfc42"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f6cc311-3bbe-412d-8e52-4ba00834e196"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("808f29c0-36ba-49e3-9894-f7657e29aaa5"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("811d3965-fb0e-4e45-be7e-ee5317c207dc"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8148cfed-61d2-4964-8359-a74d3f15245b"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("817ad5c1-887c-4031-83c3-5ebe8cf0ad8d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("819098c3-9d13-4486-91e9-3f6112b82096"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81f489aa-3a4c-4786-8826-5effb30eafa3"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8429fb10-7465-4564-9c52-e58ac5d9a8dd"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("851fc843-832c-49cf-bc1d-756bfe87f05d"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8572d839-d357-4ae5-9604-681e235a2777"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87ed3c85-01f6-4836-ab66-9557ec411003"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87fae9d9-42c6-4809-8258-3322b1af5c95"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88362433-2bba-47df-bcc5-43f8c39e33e2"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8863d51c-09ce-4d82-9dbc-e553f77cceae"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89336be6-137b-4cf3-9999-15cac0c1b103"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89a7efc1-5de2-4e57-840c-5d1f430be37f"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89c3e5b3-b177-4ce7-8411-694ab926410a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8af857e4-9242-4753-a3b8-34462a843e64"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b51c6c5-34b5-44ab-9e94-e1b4d1bab158"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b972d9b-1f51-40d7-8f3b-509f252e99ef"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8bc231e7-2df3-4268-88fa-8ea69487180d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c3cba6c-5c4f-44eb-91ae-431ed2a7da22"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d35841d-aeb3-46b5-ac30-f95fae6005ad"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ee18731-5b68-4c8e-b235-34e9b0bfd569"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f1998c9-477c-4fa8-81ff-8b4602cb1c05"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91755ba6-c8ca-4eab-85bc-3c1fc3ac391d"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("922b0ef8-63ae-4a2f-842d-da42bb4f339c"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92b0f583-4bac-49d9-989e-1c04a7ae2879"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93c6ce62-0e68-42d5-ae01-3196f8d5a693"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95f53f28-a77b-4827-8c2d-d9c36afd9ab2"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9612941f-b1a9-4b34-9f5a-f519e25cd291"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("977f3f68-d387-44e7-99aa-d7c49983d654"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9974e1e5-e153-4cbf-9a4a-0b17868f3a15"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e3a8654-ec00-4eba-a37e-2bbe1bd7e3cd"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a02c2e8c-87a8-4e57-8fc1-4b8b47422b15"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0dcdc2e-cba1-4b60-a1c3-c4cbbfc55ba6"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1f88291-5c4f-4fbd-a30d-b2cc59c84aaf"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a38a9c96-3329-403d-9376-6d82a6fea4d8"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8aa3bcc-cad1-4fb0-a906-77929916f312"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa03168b-62ea-403d-b415-e5fe3ba7a095"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aad97ec5-ae40-42d0-8dba-2366a13dca4c"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac39af6f-0615-4e94-8b23-4c883a672ba9"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("acd58bd2-73db-474b-803d-0be9243b2374"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad8b643f-d784-4402-be32-4d9f0a324d51"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af633c3e-8f0c-4ddc-a960-fc9a33a9eb39"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("afab8cd3-49ec-42d0-b8ad-ab87b820a00e"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0e27fda-3385-49d1-b860-60d858bf3f7b"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b15db351-9fd1-411c-b354-5605abf77226"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1ca3994-6939-4c9d-a6c0-cdb9c81330a7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3bf8aed-c498-4c6e-9e68-044f33927a35"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b400685b-c5b2-4679-a9ec-54964bddcf65"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b41412b8-bb41-4ff3-9291-717f8529f75f"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b478985c-5a58-4220-a325-c1feecbfb823"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b502d1e5-f95f-4854-aa27-53cd58bd614a"), "D", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b53a48b7-cf94-4a64-beda-4e1b42e722d4"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b54c6645-f7b0-496e-836d-edb8a94745ee"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5bfc983-8ca7-44e7-ae11-2f60829a2b77"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7ad5ba9-df78-46cb-ba14-eb0c9ff1bf43"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b85fc616-efae-4025-89bb-aa6d595e3787"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b86092b5-ccc9-46ef-b1ca-a399cb167fc4"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b953a475-23c4-45fc-b5e6-a3c8e5409f1f"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("baad0bf3-b431-425f-899f-aee5f10a2ceb"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbc3c89e-10fb-43ea-93d4-8f4940c70648"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be3adc30-9d88-449a-aba1-ca3e131d2aa3"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c30170ce-5662-4b8f-87a4-48535b253f6f"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c535a59d-f1dd-4e8c-b709-407c4cdb4bdc"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5f4cc64-d3af-469f-8799-5c9c18c46047"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c61e7d81-7f42-4a03-ac07-d89c25c66ef0"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c79cd4d5-7bdf-4e55-bed6-34fdf23f9318"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c801ad66-15f0-4736-99f7-73daec6f4bba"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c860d878-2176-4074-a510-5b579c13f8c7"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8a9a398-54d2-46e9-a1f4-a7f05cc7ad2f"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9bb7208-b611-47f9-9d4a-36a388946887"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca1a547f-f2ac-4765-9a32-1bc3909d3786"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cab43f79-e9e7-4ff1-a1a3-4a453b31314b"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb60a32d-a173-4c73-a41a-9470bd8d30d8"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbc0b572-420f-4dd8-a6ac-2dbc2364fa36"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd788998-a9d0-4f64-8268-b7fe3725075a"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ceaa022b-7ac0-4cd7-bc69-811ede9298f3"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0773a0b-8b50-4452-9288-7fd25d4b9f8c"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d12f2497-ca88-41e3-8fe0-5ae9439f3e3c"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d36708bb-8a24-47ca-b767-3690390fd35e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4362d2a-b162-40a7-90d7-2740fb31cdfd"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5e195ee-f63c-491b-8386-dca3d7c8ac91"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5f23ed6-c420-4f82-8d27-7c2bc15c7b91"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5fcad78-215d-48f1-a6c7-4440724e2469"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d68fbfae-c068-42e8-8b03-cbd4c4f94b2f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6c59526-2486-4d0d-b812-e6b261e74cf2"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da6ba503-b5ee-446d-90b7-2b480e29db4f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da7ae09b-3f49-4c44-a22f-49cb8034dcff"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daaa8f41-e9ef-4b96-bd02-14cc4185013b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbf647ac-0d1c-43dc-83b8-fe1f6ea87bfc"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc43592b-04c9-4a94-bfc6-cf678120c195"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd444218-fac8-4cea-8b43-6e3cbde3c237"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("deffff66-6fbc-4ffa-9403-6c6f73eaf18f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df686e75-15b1-42f2-9005-d475ae23a98e"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e057a55d-f7dd-4641-8b3d-a4265d245da7"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e20379a4-5f2a-490f-a7d2-bd6713e3015a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e40efdac-1a33-44ee-af30-df79db5107f7"), "F", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e46610de-45be-4f8e-a1d1-a03e13ca881b"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4aeacde-5366-4606-a139-a4406db4e40e"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e539f701-2f2d-4889-b8c1-b201966e579e"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e53da151-665f-4eff-b633-ff5ad8e66806"), "I", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6c1d5b5-d8d0-4cfc-98e2-6df454f97905"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8274f39-9890-4a3d-8bcb-80ce7231064d"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8ff07b7-0078-4744-9caf-828f48c6ad49"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea2a20ae-19ab-4543-84f8-627e4d35ed01"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea4dca37-c958-4d28-9eda-c1a96e7b7f30"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea8b8ee6-1fd0-4d85-9dbd-566c1fb1b669"), "H", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed43ad2b-7506-43b5-a04f-fac47e17dd36"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eda52f7c-4d22-47a4-9f4a-4c7a60e9e290"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("efa7b4a0-7358-441b-833f-68a94fa0c246"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f00ba7e7-7372-4302-8f9c-6a2f657c795f"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f08e0a65-ff97-4c18-9efb-44f4ce7eebc7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1fff5c5-5b81-429e-b408-f2efb07e3b66"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f202738a-1cb4-436b-994a-dc1ab4478f0f"), "G", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f224e3f1-13c6-4227-9574-eb83fb97c18a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f466ae40-4f7c-4139-8ef4-66d7adf43564"), "C", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4b6c9f2-63fd-4317-8430-70d9c284242a"), "J", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f529326c-54ba-46ec-8c86-b39a8716ef8f"), "B", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f74025fb-fe49-46b5-93ab-e6466947e94a"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7c7732c-febd-4d2c-8c30-7301453038c2"), "A", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9b37adf-7a80-4b57-83ae-3ea52ddcf313"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fbccbc89-62a5-4290-9703-9a48211ed0ca"), "E", null, null, null, null, null, null, null, new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc3c0531-22f8-4e11-a1aa-9f72d9c757eb"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fda5c934-9976-49df-8709-65b20a831190"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fffa52ed-cb28-4398-8958-78d1a42f1428"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("0b397d98-2373-4eff-80fd-1177ca6fd705"), null, null, new DateTime(2024, 12, 25, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(345), null, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 24, 22, 36, 7, 22, DateTimeKind.Local).AddTicks(340) },
                    { new Guid("8967c6ef-e458-4d91-b61c-63fdff05528e"), null, null, new DateTime(2024, 12, 26, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(352), null, null, null, null, null, new Guid("163b1168-9fd3-47c7-90ae-b018520e2c37"), new Guid("d39cbc9e-0aa7-419e-8e0b-e263e0ddc3cf"), 1, new DateTime(2024, 12, 24, 22, 37, 7, 22, DateTimeKind.Local).AddTicks(351) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("4cfdd6f2-7377-4cd4-abd3-2cc844647514"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 25, 0, 35, 7, 22, DateTimeKind.Local).AddTicks(754), new DateTime(2024, 12, 24, 20, 35, 7, 22, DateTimeKind.Local).AddTicks(753), new Guid("3a2376ba-6f8a-4090-822b-0a46c4b64afa"), new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("2bbdc594-d267-4ee1-bfc3-c2c2e722d2c4"), new Guid("37c7a46a-ffcc-4163-a478-5ad121e40029"), null, new DateTime(2024, 12, 22, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(708), null, null, null, null, null, 4 },
                    { new Guid("54464c4e-59cb-43e8-a738-2c525874a7bf"), new Guid("a336b81f-5964-4798-ad1d-57fd8149e403"), null, new DateTime(2024, 12, 24, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(705), null, null, null, null, null, 2 },
                    { new Guid("729175e5-9bc1-49e7-8f84-5b49efd5da0b"), new Guid("17921c63-706c-49a7-9986-a9e428240d68"), null, new DateTime(2024, 12, 22, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(702), null, null, null, null, null, 1 },
                    { new Guid("9122e100-6d36-4223-9b4e-4e79a75efc05"), new Guid("6f71221b-21d7-4526-b36a-1a539213f416"), null, new DateTime(2024, 12, 23, 22, 35, 7, 22, DateTimeKind.Local).AddTicks(707), null, null, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("13720227-3217-4249-9e4a-83cc9369769e"), new Guid("729175e5-9bc1-49e7-8f84-5b49efd5da0b"), null, null, null, null, null, null, null, new Guid("163b1168-9fd3-47c7-90ae-b018520e2c37"), 2100000m, new Guid("a7f4d3a7-c4f7-41e0-b0cc-5e399650cd62"), new Guid("977f3f68-d387-44e7-99aa-d7c49983d654"), 2 },
                    { new Guid("3edec969-96e2-4c38-bb51-b5c8dba90eb5"), new Guid("729175e5-9bc1-49e7-8f84-5b49efd5da0b"), null, null, null, null, null, null, null, new Guid("a6a85558-fe7d-47b0-b1f7-ea8790d2f616"), 100000m, new Guid("847a831f-e17f-4e2d-83bc-23eb92ef2146"), new Guid("baad0bf3-b431-425f-899f-aee5f10a2ceb"), 2 },
                    { new Guid("bf25553c-88ea-42a3-99af-0397602378fa"), new Guid("729175e5-9bc1-49e7-8f84-5b49efd5da0b"), null, null, null, null, null, null, null, new Guid("8fd0887b-1054-496a-b509-2742e74403b0"), 3100000m, new Guid("9da32152-9b2d-4818-97f1-2dee96a70929"), new Guid("d36708bb-8a24-47ca-b767-3690390fd35e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("d2ee7907-9d48-45f9-858a-db5c16725483"), null, null, null, null, null, null, null, 60000m, new Guid("a7f4d3a7-c4f7-41e0-b0cc-5e399650cd62"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("15f2b3c5-a1f4-4eb9-ba45-45ed4ea9eb6a"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("e0be44ef-42aa-4756-b0ae-e859e78d76c8"), null, null, null, null, null, null, null, 50000m, new Guid("847a831f-e17f-4e2d-83bc-23eb92ef2146"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("79fb05b0-0925-45af-96cc-0d6433e70ac2"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
