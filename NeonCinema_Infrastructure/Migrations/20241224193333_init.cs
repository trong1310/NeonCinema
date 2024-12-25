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
                    Surcharge = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
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
                    { new Guid("5279ea7b-ecf6-4a9c-93ba-270008316710"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("247260ce-eed1-495d-97cc-2b0c47771c3f"), null, "mua tại quầy" },
                    { new Guid("5ff14d47-2fea-4601-bcde-5c8e001c30c7"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("8d3db0fb-0df4-4bcb-aed4-35c6dc0dcd04"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6557), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("a5c9ddf2-37bf-4b2a-b7e9-ba7acf4bb368"), "11:00 PM", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6561), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("37bae8aa-3414-4028-8e58-84cbfdef72c0"), "Úc" },
                    { new Guid("53ebac8c-af53-42e6-b68c-a8db8243b7f8"), "Trung Quốc" },
                    { new Guid("589c5b01-431e-4dd1-83e9-ed928811eb12"), "Vương Quốc Anh" },
                    { new Guid("60fae8cc-de4d-4660-9030-cabecca7d652"), "Mỹ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("966a5924-ed2e-494e-a64a-ae5fc7b6a56b"), "Pháp" },
                    { new Guid("9b41a2a8-a6b4-4f8f-8a82-4eec31751ada"), "Việt Nam" },
                    { new Guid("a5ce0c5c-f733-45e2-853c-7a239c218c33"), "Ấn Độ" },
                    { new Guid("b599f9a7-5288-4ebc-bdf9-5e1d1bb636d3"), "Hồng Kông" },
                    { new Guid("bae1a26c-181d-418d-af3a-13adde258812"), "Hàn Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("02add965-c965-48d9-8058-089771d71542"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("0e1d76a1-1c0e-4c89-8471-93f79161611d"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("46ee31bf-3a47-4bdf-911b-94b4c9535c87"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("52f3d9b8-5227-4df0-8099-05476c0c59cf"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("63ea682a-d145-40ef-94cf-867f379fe7f2"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("73d8cfe6-b227-4c87-92a5-3adf56a8e625"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9a6e85a7-5a74-46f1-a651-63f668a8d490"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("c4b2713d-3421-4a8c-8fdb-6ec30b838c64"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("cab3a232-3012-459b-9287-5f0e94575f3e"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("01ef6841-3c98-4188-8873-89ad58e0f004"), "Combo 4", null, new DateTime(2024, 12, 22, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8141), null, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 4, 135000m },
                    { new Guid("4228db1d-f646-4810-82e2-93abbb96d5f6"), "Combo 3", null, new DateTime(2024, 12, 23, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8138), null, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 3, 75000m },
                    { new Guid("b3e947c7-6ba4-45fe-a437-bbc05e60ffd5"), "Combo 2", null, new DateTime(2024, 12, 24, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8135), null, null, null, "1 bắp 2 cola", "combo2.png", null, null, 2, 100000m },
                    { new Guid("c2c9c1fe-2a0d-4079-8056-43d518c85c86"), "Combo 1", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8132), null, null, null, "1 bắp 1 cola", "combo1.png", null, null, 1, 80000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0b6c2264-05b4-4bc8-b326-51903a4256ef"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("1af5244d-46ed-473c-8235-5e129af96c37"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("2499b771-5481-4dbe-bab1-fe8f0a3172b3"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("61b20628-fcf1-41dd-8981-c09b2ce39047"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("70fa001d-f9fe-44e1-bea0-eaddfc0f0383"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("8479a683-2ca9-4bc9-8a4f-524ce054500d"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("acd979ec-0ba9-4dce-8c7b-d6ab49e08aad"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("ece8b361-9373-43c9-977c-639171ec23d5"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("2c71d101-e644-4926-a2c5-37fa6d2a9f5c"), null, null, null, null, null, "USA", null, null },
                    { new Guid("6e0a0b72-2642-46ee-8040-bab313a66808"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("bb3ca71a-04d3-4efe-9294-207081ba4638"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("dc690327-5cde-4ead-be95-a825f3d6cce7"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("e3dc99e1-8ffe-44c5-9784-878adaf0ad23"), null, null, null, null, null, "VIE", null, null }
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
                    { new Guid("ae981828-8e28-4240-98a2-73256f6da2b2"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("f055629b-759c-4e5a-9c63-76610d7f99d5"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5141), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5162), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5160), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6534), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6537), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6530), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("000d78eb-1817-4e00-bf4c-c5cdf0cfe0d7"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("0a1078b8-0547-4ac7-802b-852a57a8d0e5"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("0c61e863-f51c-4ad9-89ac-181d10fa8674"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("1bd0b291-9180-46b0-b047-307623613aa8"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("25051998-07dc-4ec5-b130-d6ca2096fac2"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("35214017-49b5-4ef0-b726-85227c79af58"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("425b859a-9c79-4c1c-808b-183c1d2c3b54"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("797459ac-3a79-43d3-a9ab-9625556294be"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("afe45f53-7a4c-40ac-aa48-5a00886b7b1a"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("ddfceb61-a24d-42e9-a21f-ff27619354ec"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 }
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
                    { new Guid("005bfd18-9a47-4f42-b2c2-182d21e6c0f1"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7847), null, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("02add965-c965-48d9-8058-089771d71542"), 127, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("0098b6c3-3c51-4ab2-8bc1-d9287643b7ca"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7761), null, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("73d8cfe6-b227-4c87-92a5-3adf56a8e625"), 109, new Guid("61b20628-fcf1-41dd-8981-c09b2ce39047"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("2ffc7f6b-10b4-44aa-adda-d40eb144c430"), 13, new Guid("bae1a26c-181d-418d-af3a-13adde258812"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7754), null, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("0e1d76a1-1c0e-4c89-8471-93f79161611d"), 113, new Guid("0b6c2264-05b4-4bc8-b326-51903a4256ef"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("35ceec6e-81db-4a16-b11f-ffc016e06d54"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7802), null, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("73d8cfe6-b227-4c87-92a5-3adf56a8e625"), 110, new Guid("61b20628-fcf1-41dd-8981-c09b2ce39047"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("39ed6810-2fd4-4204-ba5b-28f357fa35fb"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7787), null, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("9a6e85a7-5a74-46f1-a651-63f668a8d490"), 120, new Guid("acd979ec-0ba9-4dce-8c7b-d6ab49e08aad"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7732), null, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("52615387-5b08-45e8-b44a-70dfe69dec08"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7820), null, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("02add965-c965-48d9-8058-089771d71542"), 113, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "cuoixuyenbiengioi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("578ff748-cb73-4e52-8251-c14d49e56abd"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7794), null, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("0e1d76a1-1c0e-4c89-8471-93f79161611d"), 110, new Guid("0b6c2264-05b4-4bc8-b326-51903a4256ef"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("7e32ebf7-d34d-40f7-8a10-1e24376101be"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7827), null, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("02add965-c965-48d9-8058-089771d71542"), 123, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "kinhvanhoa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("80bac727-d8a1-435d-9732-5e851919496c"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7833), null, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("02add965-c965-48d9-8058-089771d71542"), 118, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("9176de69-b745-411e-b51b-29d8cd24d172"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7840), null, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("02add965-c965-48d9-8058-089771d71542"), 134, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "cuocchien.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("be512c17-ca83-4eec-af95-726e053938e5"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7744), null, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("9a6e85a7-5a74-46f1-a651-63f668a8d490"), 81, new Guid("0b6c2264-05b4-4bc8-b326-51903a4256ef"), "xich.jpg", new Guid("e3dc99e1-8ffe-44c5-9784-878adaf0ad23"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("e8c55520-d536-417f-8928-ffce3adae1b4"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7770), null, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("02add965-c965-48d9-8058-089771d71542"), 99, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("ee6f6c5a-e44a-4980-b097-2a17a57da919"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7779), null, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("faefb139-116c-4ffb-b3fd-72e0fc55e2d5"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7812), null, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("02add965-c965-48d9-8058-089771d71542"), 100, new Guid("f5da9ba1-daba-4540-b7c1-2734be62a08d"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/jS6TZkBB0lY" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6589), null, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6595), null, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0f6af167-df35-410c-b8b6-4dd70313dfbf"), "Hà Nội", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6159), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("55942c5d-dd64-4b7f-96b0-18b0dc59c8bf"), "Hải Phòng", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5747), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6330b8d9-378a-409c-bafa-27630e2e2836"), "Hà Nội", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5321), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("710c97c1-cbaa-4869-80fe-428711043364"), "Hưng Yên", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6050), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("73435cb0-0ddd-49eb-a029-8f49c230c963"), "Hà Nội", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5720), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7a7b8b50-0be1-4a91-b288-751da8fb0861"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5961), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7f4ec1d6-bae9-4a90-bf11-5a6b11c6895e"), "Thái Bình", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6029), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8b9ca369-2d50-48a3-a4bf-e178cdeff164"), "Đà Nẵng", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5786), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ca07c1d3-84c8-4dd0-a871-c0c1e3eea834"), "Quảng Ninh", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6097), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cd99dda3-5a45-45d8-b8d6-9ce20e843e87"), "Nghệ An", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(5988), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d0375b00-1246-4ea8-ada9-acaae176f948"), "Nam Định", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6071), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ee326c57-5921-4b33-bf7a-55cfaf2842f8"), "Bắc Ninh", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(6009), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "PromotionID", "Status", "Surcharge", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("10e889db-4131-428c-b45c-38360eafea3a"), null, "BILL007", null, new DateTime(2024, 12, 20, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8225), null, null, null, null, null, null, null, 1, null, null, 800000m, new Guid("ee326c57-5921-4b33-bf7a-55cfaf2842f8") },
                    { new Guid("12d99457-e314-4c5b-b187-98df1d5b69b1"), null, "BILL001", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8199), null, null, null, null, null, null, null, 2, null, null, 500000m, new Guid("6330b8d9-378a-409c-bafa-27630e2e2836") },
                    { new Guid("24255959-9905-4d26-9654-e05662b82a4b"), null, "BILL009", null, new DateTime(2024, 12, 17, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8231), null, null, null, null, null, null, null, 0, null, null, 350000m, new Guid("710c97c1-cbaa-4869-80fe-428711043364") },
                    { new Guid("43e59291-36fe-4782-8d1f-a03b16659ae8"), null, "BILL0122", null, new DateTime(2024, 12, 21, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8220), null, null, null, null, null, null, null, 2, null, null, 680000m, new Guid("cd99dda3-5a45-45d8-b8d6-9ce20e843e87") },
                    { new Guid("555b8754-bfc7-46aa-9aa5-848c05870896"), null, "BILL004", null, new DateTime(2024, 12, 23, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8211), null, null, null, null, null, null, null, 2, null, null, 200000m, new Guid("8b9ca369-2d50-48a3-a4bf-e178cdeff164") },
                    { new Guid("707013d6-0a32-48df-b1bf-a2c4d88c5f18"), null, "BILL002", null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8204), null, null, null, null, null, null, null, 2, null, null, 300000m, new Guid("73435cb0-0ddd-49eb-a029-8f49c230c963") },
                    { new Guid("8a081fa9-b365-4336-8295-fc49034a571c"), null, "BILL006", null, new DateTime(2024, 12, 21, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8217), null, null, null, null, null, null, null, 2, null, null, 600000m, new Guid("cd99dda3-5a45-45d8-b8d6-9ce20e843e87") },
                    { new Guid("92bad151-293a-4ecc-aa66-740983d06366"), null, "BILL008", null, new DateTime(2024, 12, 15, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8227), null, null, null, null, null, null, null, 2, null, null, 450000m, new Guid("7f4ec1d6-bae9-4a90-bf11-5a6b11c6895e") },
                    { new Guid("bfe764a4-d99b-4aa1-b2eb-5e1689eedfcc"), null, "BILL010", null, new DateTime(2024, 12, 19, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8234), null, null, null, null, null, null, null, 2, null, null, 700000m, new Guid("d0375b00-1246-4ea8-ada9-acaae176f948") },
                    { new Guid("cbf87d88-7b0a-4341-9363-a77abd7b6e02"), null, "BILL005", null, new DateTime(2024, 12, 22, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8214), null, null, null, null, null, null, null, 2, null, null, 250000m, new Guid("7a7b8b50-0be1-4a91-b288-751da8fb0861") },
                    { new Guid("e830afc7-1521-41a8-b540-30c28bf75103"), null, "BILL003", null, new DateTime(2024, 12, 24, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8206), null, null, null, null, null, null, null, 3, null, null, 150000m, new Guid("55942c5d-dd64-4b7f-96b0-18b0dc59c8bf") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("1e16b947-f428-46ca-b0c8-d4c38aeb02b2"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8322), 1, new Guid("6330b8d9-378a-409c-bafa-27630e2e2836") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("1c8722ab-d0de-40eb-9ef0-9c5b0fede852"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8016), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8014), new Guid("425b859a-9c79-4c1c-808b-183c1d2c3b54"), null, 0 },
                    { new Guid("1d2c0d89-36e1-42b1-a781-a91941e54429"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8009), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8008), new Guid("000d78eb-1817-4e00-bf4c-c5cdf0cfe0d7"), null, 0 },
                    { new Guid("76bdbf3a-81dc-48c4-ab2f-5292719efa8b"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8023), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 29, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8022), new Guid("1bd0b291-9180-46b0-b047-307623613aa8"), null, 0 },
                    { new Guid("960350c2-d260-416d-9ee8-d4885dec398c"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8006), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8004), new Guid("35214017-49b5-4ef0-b726-85227c79af58"), null, 0 },
                    { new Guid("c383b434-04f9-4eff-b3c8-65ab7e58a4e9"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8012), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8011), new Guid("797459ac-3a79-43d3-a9ab-9625556294be"), null, 0 },
                    { new Guid("d1b4ca6a-9857-442d-9f44-6834222299fe"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7999), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 4, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7997), new Guid("0a1078b8-0547-4ac7-802b-852a57a8d0e5"), null, 0 },
                    { new Guid("de9c7340-b10e-4a0d-ab0e-ad1cc6f01c40"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8020), false, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8019), new Guid("0c61e863-f51c-4ad9-89ac-181d10fa8674"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("017b48fe-83ee-4c22-a4d8-cb484b095bc0"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("01826e10-b890-4145-abb6-0a6f136b97ba"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02636e60-75c2-47fa-aef7-e7f3e474e197"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02e5113c-62ed-4cd5-af08-1d917d777dd5"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0302ea7d-6ac6-44d9-b37d-a2ca3a4f2480"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03593c34-b89e-4b94-9e92-5e75634d3eeb"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04ee8194-33d4-41b5-b67d-1ee43b943d38"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("079ed111-a2ce-4dd4-873e-c6b8fb9009a6"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("080a2cdb-7e99-49e5-ad65-271a9f84a0ab"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("083ba985-ba43-422a-8474-9f59386ccc05"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08621570-b98e-4719-b3cf-a61edec51e1f"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cba975c-829f-40d9-8eb1-a2364bc375c8"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cd433cc-e8d4-4df3-82e6-f9931b892fca"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d3025ab-e261-4981-a90c-1944ad72419b"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0dc19ade-0f7d-492d-a3f6-a242875f4ace"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0eacf7b6-4250-48a5-a71d-983b0fdf7101"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0efd5341-c8e8-4510-83b5-ba92f8794312"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f0f63d8-7b93-4d92-9071-8422a873f2cc"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f27fb55-2ae3-423a-9c73-3829de3f5be8"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f7cea64-3da1-441a-a96d-bb9c1c0276a7"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("114b3052-48f3-45bd-8f03-66fea6ae8260"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1339a76d-c12e-4fb3-9d8f-5f8d1618b2ea"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1605fa8d-40f9-4234-9e25-bb94e65c8311"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16a75d43-5707-4032-8db1-5d8050976fa8"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("170e938b-1e25-40d5-8588-4b6b1605c66b"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1750c5ee-f4b1-4e88-b709-20064c5a2ff1"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17e1bf6f-6150-4313-8353-9840f920c6bb"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18041e0e-b59d-4aee-bf9e-e9d815283fb8"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1924b1a0-4bc7-4e9e-9907-d39ccf8e37cc"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("198f9a3d-cdc3-481b-8524-7ef58f92c6dd"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ac415ca-c426-4a64-8b65-f3d25252e14a"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b8ac281-0615-464c-a182-ee7ac407beaa"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cc64a61-448a-48a0-813a-14504a5c1b08"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1db99481-eb15-4608-b4ed-3c5af15142b5"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e097113-84ca-476d-96c9-5cf1ae53620b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e4eacaf-4174-45bd-a6c8-a4a7abcae2f8"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1eca7248-d6df-415f-824e-e8b7738774d9"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21069968-13d0-49ba-b18a-393202b48ac0"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("228ddf8c-24e5-4051-ae3d-16201493cc2c"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("239ed392-98db-4925-8cea-51db9c94b4af"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2681f4ba-3635-4f96-90be-3ab837171cb0"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27c83837-4cc2-4012-9903-5e13c7428253"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("298a450e-5031-4eaf-8af4-9ec90955fff9"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29c58e71-ae5b-4458-8593-deb6522c1e9a"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29c5d39c-cd19-492b-91f1-99b5b062a4ba"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a0f67ca-a7e5-44f5-9828-1dbfa6736ddd"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b98f367-6c25-47f3-bbb7-3e70b2b70ef7"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2db36d94-23f8-49ff-8f99-53bb0aa94904"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e9fca3f-a2c2-40b2-9b33-6be47463c072"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30018913-49f4-4737-ab7f-333b32bda0f1"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30a172d7-807d-498b-8724-59f66c51f6f1"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30b113dd-fc3a-4155-a29e-9d6dab6ff0d1"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30dcdf9e-efa6-4e62-85b0-4ae8fe3f345c"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32034c73-419a-4be3-bac4-c50c38601340"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32c57a5c-d2e0-4dfc-9f2e-2f9decf28af6"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("330249d1-0b14-49fe-a099-7814865a9245"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3323e02f-bdff-46ea-8a3d-8a3b4c25df99"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("365f768e-cef5-41d8-b58b-921da56883f3"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37756165-dd42-427b-b3df-a4fc0d0b58ce"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37db1df4-a4b3-4189-ab56-41896f724e90"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c418734-5841-4753-a6b9-a36c28f11e0a"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c6de2ec-bde7-4c25-8fa8-f07c2426f282"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cd55148-bbd9-4a2c-84a5-2b1151d405c0"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cdeb1b8-7f2b-4399-ba1a-5b4cb8c572b5"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d566854-86fd-4048-bcd9-beea202dd18a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fbcb231-9faa-4a0b-a317-951ac46da392"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40705bd9-405d-4f34-ac73-d7a0868d9ee9"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("454eab76-6d67-415a-a05d-18a95d93e565"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("456a13f9-0a41-432b-9338-b118460776b3"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45749d82-cb67-43bd-8a56-70ae157469dc"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("464b6480-d868-4359-9720-6a3eb8b612f1"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46aec22a-374e-4dfc-9fac-8d8ef092704a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d15f559-a80e-4ae7-9c8a-36aeb81e557c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d757715-6951-4d6f-b436-740567a5b0d6"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e853634-2da5-4f79-9daa-ec16cebff054"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f81560c-38ef-4512-b18f-5c5d993ea1b4"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51cd029a-1c02-42a5-b153-ed978c8ea0c4"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("537464c1-a11b-4c06-a68f-fb11e8ee1bd4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54a091a5-8b78-4eea-b268-b8658eaf37bb"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("554bc750-c460-4c45-8898-c93facb5bffe"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("559d5e32-b993-4ed3-825c-1960c00ac35f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("563ccc53-8d40-41aa-9c0d-017c8e442285"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56d965e2-b6a1-40dc-8cca-e52907bc6135"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5765d83d-227b-4506-9b39-bca453cd906c"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57ed3eb0-65b9-414d-b681-ed73e0faf3c5"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58d21b81-5101-4219-9ce4-81adbdcf7b8a"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("595e2c62-ae7b-47ae-ba7c-ef9fba725111"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d269998-2371-4174-b167-259233908be8"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d468cb2-67fd-4ad5-9049-035e27a32322"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d50678a-1361-4f81-b1d0-f1fae43116a1"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ea25525-2a72-48a6-8431-706f5e7e2479"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61474413-d0c5-4530-9cb7-28ca5a5e089e"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6168b682-5e76-4655-b254-dcc909cd2682"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61847040-0164-44a5-b717-d099b644fa22"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61ede186-fb25-431e-b6a8-a42638c36647"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62f796e7-b1ac-4b0f-a9c4-82aa096a00da"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64a9f94f-762a-4da3-a256-76e5afe3e08e"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("656728f9-875b-4612-bb2e-48c7464ed731"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("657e9187-4f24-4c9a-a2b1-ad947b9d56d8"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66a082f3-06d8-4811-a37b-7b7dbf569a6f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66a353c0-9275-4ec8-bf24-f5cba4b4e9fb"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68e5fd84-0c65-447c-aa27-118ee98c85d3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("695f385e-55ba-470a-8024-5e780909742c"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b23b3b1-c403-41b3-bf77-0c45d38ae8ea"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bc108fd-66ce-4858-8eb9-8ffd3dd575c7"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bdd4691-3f9b-4157-86a4-d382f210d7e4"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c2f9844-eb72-4342-b614-0d8b95554d9e"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c3f39ff-b40a-4d65-b697-cf95a40d5d34"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6dfefefe-9082-4c4b-9d35-ca4489af7334"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e802f19-8c83-4ea1-96a6-9ef9fc049c36"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f1fecb5-bfbe-4158-ae39-272f7728900c"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fc20c51-832d-44f0-8a72-68da8f3d8306"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71bee437-f1d8-4263-97b9-6194abf3f17a"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72489774-2289-4533-aef2-7b6aca057441"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("727412ed-709e-4ac5-bf76-aa019fa342f4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("730f1bbc-14ff-4c43-b03a-0783e9532645"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74584a9e-4764-480a-97f2-dbaf7738020a"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75c3aa75-f3d9-45e5-ad9c-32e5cfd27658"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75db7c5a-fed7-4ab3-bf1a-a94d02d77fab"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7714ce1b-9188-45ac-884b-d3acc238394d"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77681f27-42bf-4dcc-b542-d96c1489c323"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("792d6ed1-6f6d-4e31-a489-78f752f0fdc2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79aa0596-0d98-45c5-bce6-63bab1f07f28"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a511785-0af6-4fc8-b514-dbaad383b3f3"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a7203cd-46c4-4d56-99d6-24feec8abbfb"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b3b621c-592c-4520-8f65-15fbcbaa4efe"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b98f145-5b3c-49e8-adb3-482e0de54c15"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d6a0c4f-2d9c-442b-8dc5-fad4a0fb9306"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d6bb2ce-6216-427a-bc19-e59105e9182a"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85ebd398-374e-4e97-850c-dc2e9fb56c78"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86a47a2f-8f47-48a9-806a-48b127d35bfe"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("879cf372-205b-47bd-ad90-24495b034db8"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88f36eac-96dd-4949-973f-3774b43903ea"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("891533f4-6b91-4375-98e2-77cc979bed64"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a0bd4d3-9817-472a-9e61-9db0a16fcd6b"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a22f981-188c-4436-b1dc-76c5c5fc010a"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b2efb60-d38a-4346-8507-6e84d4c46e8d"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b7b0379-e6f4-49d7-ac90-cdc3286bdd0a"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c8997d7-c486-46cf-9972-f27e724c5a47"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8cb58938-6e05-490e-a0c0-9c423f9db2df"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e190b13-6c74-4f3d-9853-2c765bbd6ec0"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ea40f06-59cc-4281-a052-3f9f831e7a28"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9164bfec-8810-47e0-90f4-ffaa0d00c58d"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("919241ea-ce74-4a67-8074-93ce50da4417"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91fe9f79-0add-4cf6-9d1b-2ccf20060946"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93c31a3b-4578-4758-8e7d-73cf01fd9b37"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94a8430e-f11a-40ab-ae2f-508fafb19985"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9579ffba-5dfe-41b0-84ca-fece1e0b485c"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97bea194-0bad-4f32-8b6c-359966278d1f"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("988c1b6a-c698-4c5f-b16e-d0725ab0bb59"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d976291-8e01-4cd5-9d67-bef9300e2231"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9daba85d-c8e4-4574-9eee-e80c47f91d33"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e81a193-c448-40f2-80f2-450ff37f3ddd"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f00a51f-457a-4903-b3ee-76570cda28e2"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2a23901-974d-4cc9-bedd-482e711242bb"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a424ddcf-d1dd-4bbe-9fe9-42dcbf95d051"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5419b24-561d-4425-8051-478dbf2d7bb8"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5ffcfd8-b177-41f3-a411-2756ecb3fde0"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a732c78c-a3a6-49f9-8ea9-a338975a6721"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8f462c9-bc15-4ce5-be2b-eed9b1b70044"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a925d702-29bf-4422-851e-53196460b626"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a98883ab-f80e-4bbf-aea8-aebf7b26f1c2"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa397a1e-efaf-4a62-9869-46822e8300c2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aabf3446-e57c-4c82-8f62-82195c6a158e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab059b5b-f5d1-4a92-9975-60dfff9766bf"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("abbf5bd9-fdb3-4414-9e8c-b1d2ec1bf670"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("adacdc02-0a7e-4c9d-82c4-b28665cd0aff"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae05f442-0e71-4fbf-b7fb-c987b9607c0b"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af634760-bc6c-4f47-a106-5a466a8f634e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b211da30-dc1e-4be7-825a-3ccfd53d1c6b"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3a0ed79-a7d2-4e34-b781-9e78f5cd78c2"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b407a307-2c5a-4d2f-9637-a8d6ff503d15"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9974496-f55e-49e1-ac9f-16e3f8eaf332"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bacd9bca-1fa4-4e5c-9efa-7b8e64d55f20"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bb899abb-a823-44ed-b9f4-9ddddcb52d9d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcbe2e14-0155-47f7-a5f4-16c02cdfcbca"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcfbf8b7-f7e1-4c66-adff-49f16b82810e"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd3f3698-f8e0-42a6-bfcc-96b3cf1bbcd8"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("beca8826-28a1-471b-a056-f0b02d40738e"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf356373-3bcc-40eb-9874-4f0008b790f8"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0b4e4bc-5636-406f-85eb-a36d42474e7e"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c157c6ce-1427-412e-8af4-f36cbbd21037"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c28b130d-92aa-4f88-b77f-a02582147d24"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2a45a9f-1cb4-4722-a555-02babc0d3978"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c78a7b9d-9c97-4238-a08a-d873ee7c8a3d"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7c95205-98d9-439c-8060-b7d62da93d51"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7da8334-74cb-4582-ad31-4dabe40323a5"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8a33a64-8e3b-4545-86f2-0c42c9581d1f"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8ca2d20-04b6-4e50-8e8b-610bf5a088cb"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9013914-3008-4787-9b5e-985566def6e5"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca435b3d-59d6-4770-95ee-56db138f6c6d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca563204-1b53-4dc0-893d-651a463a0bea"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca9a6a79-1d13-44ed-a8bd-790642dfb16a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cba4bd40-223c-4a39-9138-d57552b6c048"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbb844b4-0ab7-4c5c-8b6f-5295a08e8e58"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc9ccfdb-19d7-4779-969f-155073318f7b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd00da62-3c33-4f6a-abc3-2f6a96a39a9f"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cdd46025-3bbb-4d80-80e4-5b526676361b"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d02e135d-4009-41c1-85bd-c00559471636"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d18d70e4-d44a-4338-b3c4-62313e67e047"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d18df514-ffff-4409-9f0f-b09643fe1c05"), "G", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2b52739-6a7b-498f-87f7-04e5c5736e9f"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3c3eecd-e937-47df-bda6-d2e64207085c"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4f3961a-fc2b-4fd5-896c-7fc2c8427a96"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4f48cf2-b42d-4242-b09c-280a8516bc33"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d50d4fed-51a2-4b33-a9a9-35407c824c18"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d562808a-beea-4390-a904-48c536d04490"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d80468fb-1d64-43a4-8bc2-64d251085115"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8e52b34-54c2-4ae5-a689-e5a6748da304"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daac1cfb-ea24-49e6-9859-268978df2113"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dac118cd-cde2-4d91-aa49-c75835a7da25"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddf26bfe-b601-4c12-8c7d-432653ef6277"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de2ff0d6-ba42-41f0-8ffa-40a59c329495"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de40b2aa-ee9c-4add-8380-0459511c1ade"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de8027b1-1fdd-436c-9201-9b06f7cbf663"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("deefa7f2-c9e7-4b2e-8c66-124cfbc1636b"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df8f97a6-cfec-4b06-8e51-48fc27e0aa89"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dfaf9c8b-d5fa-46aa-91b9-65005f0d3490"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1dac1fc-41b9-426b-971c-e38266bd63bb"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e50d9977-f051-4cc3-861f-7d0e36007ff1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e695e6bb-6124-4efd-995a-32a0453ae727"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e71857d3-a08f-4d1d-b5d2-68a7506ba6bc"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7eac42f-3b48-47bd-beba-8a66dc52dcc7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7ee9abb-367e-4018-9496-5d3a0172eb1f"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e99a9479-1ff9-4fce-a634-cb7b53e6d937"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea751b51-7e55-4bc3-9db4-70f3951d3d67"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eba80772-8b02-40ee-86bf-1ff28c82afc7"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec4921fe-255c-4607-b758-9cf081a88ac2"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec9cf7e7-1bf6-4afa-9fa3-b22c864fce1e"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ece5afec-f4b7-42a9-9f99-44fa7c369a8c"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed53a9d7-4df1-4a42-a904-bfd08f8d6a56"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed86d40b-1178-48dc-b9ac-1971f3771887"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eda884b4-5cfd-40e9-ae5a-f048850b908a"), "E", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef6e450d-b928-45e7-9b9d-194c92907b52"), "J", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f003bda4-c437-4d36-aa6b-188ff28e3a2c"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2ba7852-f931-4863-9aec-9ff9744b963a"), "C", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3079481-3186-448e-9d2d-aa67db38e27f"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3a9fbba-c685-4dcd-8b17-e77df554a50c"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f43e0ad3-e8cc-4888-896b-2ecb592bbfae"), "D", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4d8e22d-9880-4fcf-b3c8-a48142463237"), "H", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f694820b-227d-4bde-a4dd-cb74f11df8a6"), "A", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f702d31b-0ccd-4745-882a-9d1020305540"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f79ec384-dc73-4bfd-93b9-14cade9af971"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7cebc80-f383-428b-b999-666acac5d15f"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8a87a73-c8bf-4faa-823f-60fde53c01fb"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9ef97c7-3f40-4573-8300-16757485af90"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa6e7072-5ed5-4654-9ac1-89a4bcbdfb8a"), "B", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa7121da-6dea-4a1f-bee8-3e892a94cf20"), "F", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fee7b0fb-9385-4c3f-90c7-d69ff470055f"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff72d526-e1dd-4430-afb0-a0b0b768e557"), "I", null, null, null, null, null, null, null, new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("3d4751e0-8495-4d6d-b24d-32e7208f368a"), null, null, new DateTime(2024, 12, 27, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7894), null, null, null, null, null, new Guid("be512c17-ca83-4eec-af95-726e053938e5"), new Guid("e5dbb004-552f-40e7-bc2c-be3cc3531cea"), 1, new DateTime(2024, 12, 25, 2, 35, 32, 588, DateTimeKind.Local).AddTicks(7894) },
                    { new Guid("890382e4-f6d6-4fd6-9bda-81e3753a3042"), null, null, new DateTime(2024, 12, 26, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(7888), null, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 25, 2, 34, 32, 588, DateTimeKind.Local).AddTicks(7883) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("bc443602-a62d-4086-9348-20d13c73df12"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 25, 4, 33, 32, 588, DateTimeKind.Local).AddTicks(8344), new DateTime(2024, 12, 25, 0, 33, 32, 588, DateTimeKind.Local).AddTicks(8343), new Guid("6330b8d9-378a-409c-bafa-27630e2e2836"), new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8342) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("12d99457-e314-4c5b-b187-98df1d5b69b1"), new Guid("c2c9c1fe-2a0d-4079-8056-43d518c85c86"), null, new DateTime(2024, 12, 23, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8292), null, null, null, null, null, 1 },
                    { new Guid("555b8754-bfc7-46aa-9aa5-848c05870896"), new Guid("01ef6841-3c98-4188-8873-89ad58e0f004"), null, new DateTime(2024, 12, 23, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8299), null, null, null, null, null, 4 },
                    { new Guid("707013d6-0a32-48df-b1bf-a2c4d88c5f18"), new Guid("b3e947c7-6ba4-45fe-a437-bbc05e60ffd5"), null, new DateTime(2024, 12, 25, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8295), null, null, null, null, null, 2 },
                    { new Guid("e830afc7-1521-41a8-b540-30c28bf75103"), new Guid("4228db1d-f646-4810-82e2-93abbb96d5f6"), null, new DateTime(2024, 12, 24, 2, 33, 32, 588, DateTimeKind.Local).AddTicks(8297), null, null, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("6d0f4a19-2489-46fc-b93b-9b157a7fcd7c"), new Guid("12d99457-e314-4c5b-b187-98df1d5b69b1"), null, null, null, null, null, null, null, new Guid("2ffc7f6b-10b4-44aa-adda-d40eb144c430"), 3100000m, new Guid("1d2c0d89-36e1-42b1-a781-a91941e54429"), new Guid("228ddf8c-24e5-4051-ae3d-16201493cc2c"), 2 },
                    { new Guid("89636e6a-4907-43d9-9151-dc67018fadf7"), new Guid("12d99457-e314-4c5b-b187-98df1d5b69b1"), null, null, null, null, null, null, null, new Guid("477a2b6b-391c-4501-91d6-307bfc9a34e8"), 100000m, new Guid("d1b4ca6a-9857-442d-9f44-6834222299fe"), new Guid("a5ffcfd8-b177-41f3-a411-2756ecb3fde0"), 2 },
                    { new Guid("8cb85e57-6a73-4594-9609-e43956ed5b9a"), new Guid("12d99457-e314-4c5b-b187-98df1d5b69b1"), null, null, null, null, null, null, null, new Guid("be512c17-ca83-4eec-af95-726e053938e5"), 2100000m, new Guid("960350c2-d260-416d-9ee8-d4885dec398c"), new Guid("de40b2aa-ee9c-4add-8380-0459511c1ade"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("247260ce-eed1-495d-97cc-2b0c47771c3f"), null, null, null, null, null, null, null, 60000m, new Guid("960350c2-d260-416d-9ee8-d4885dec398c"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("35214017-49b5-4ef0-b726-85227c79af58"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("8d3db0fb-0df4-4bcb-aed4-35c6dc0dcd04"), null, null, null, null, null, null, null, 50000m, new Guid("d1b4ca6a-9857-442d-9f44-6834222299fe"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("0a1078b8-0547-4ac7-802b-852a57a8d0e5"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
