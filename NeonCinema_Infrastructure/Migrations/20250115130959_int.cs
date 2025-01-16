using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class @int : Migration
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
                    Sex = table.Column<int>(type: "int", nullable: false),
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
                    Gender = table.Column<int>(type: "int", nullable: false),
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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    Sub = table.Column<int>(type: "int", nullable: true),
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
                    DateOrBriht = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    AfterDiscount = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: true),
                    Surcharge = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: true),
                    TotalPoint = table.Column<double>(type: "float", nullable: true),
                    BillCode = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Bill", x => x.ID);
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
                name: "Ticket",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SeatID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ScreningID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<long>(type: "bigint", nullable: false),
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
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("87022ed8-c01b-45d8-ab08-461c688bf854"), "11:00 PM", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4185), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4180), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("6d324f7c-d0c2-4580-ac75-ba58428376cd"), "Hồng Kông" },
                    { new Guid("832e058a-fa8a-4f96-87c6-dfb41e5ca4b0"), "Vương Quốc Anh" },
                    { new Guid("8e7417af-455b-413c-ae3f-62dcb7f9fb95"), "Úc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("a07dd4f9-f420-4892-9426-1adc8296e827"), "Việt Nam" },
                    { new Guid("a58c284d-cd8b-4e0d-b92c-0ce5413e9726"), "Pháp" },
                    { new Guid("b1ec478f-325f-4cb8-8c1b-881e22c5c096"), "Trung Quốc" },
                    { new Guid("e253c917-6df1-43d8-86d0-c2c9c5cbd5b9"), "Mỹ" },
                    { new Guid("e2abba5b-e7e6-43a9-822b-41abb622c32d"), "Ấn Độ" },
                    { new Guid("ea1f631f-d940-42f5-a75c-056855636c55"), "Hàn Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("03c9ee82-cc99-42be-9e88-a14b36dddd8c"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4025), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("36f02898-cb02-4199-ac05-8eb53d7be071"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4017), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("49cddcd9-ad8d-4953-8e3a-031117a4c272"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4019), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("5357368a-551b-45aa-bb4e-6bb78d373925"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4027), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("66897be2-4ff1-4915-b12b-1cbfefa1a2bc"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4032), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("6c407699-fb0d-4506-b3d4-0fd81446a70c"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4021), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4008), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4023), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("bacc9362-ed4e-4be3-a7ab-074b112327e4"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4034), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("fb171356-a9e0-4388-b3f8-372475dc8f4c"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4029), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("4b3b6378-93b2-4f7d-a583-ca49eb16c2bb"), "Combo 4", null, new DateTime(2025, 1, 12, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5486), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("6e93f422-bdb5-404c-beb6-d5e4ee138b22"), "Combo 1", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5476), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("721e7f98-e654-4837-a571-d389fca1f57c"), "Combo 2", null, new DateTime(2025, 1, 14, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5480), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("de947b35-8b11-4ea4-843f-a859881c6b8e"), "Combo 3", null, new DateTime(2025, 1, 13, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5482), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("2917b90f-20ce-411b-8ad1-e0a83a732294"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4088), false, null, null, "Lãng mạn", null, null },
                    { new Guid("2bc1dda4-07fc-489f-813d-3b75986a032b"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4058), false, null, null, "Hành động", null, null },
                    { new Guid("45a93af8-c17e-464a-a63f-dee4661c2cdc"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4085), false, null, null, "Hài hước", null, null },
                    { new Guid("512f315a-5fea-401b-9023-e0feef48a757"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4059), false, null, null, "Kinh dị", null, null },
                    { new Guid("8b55096b-2d05-4c01-a04d-be813cf46b15"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4060), false, null, null, "Hoạt hình", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4053), false, null, null, "Kịch tính", null, null },
                    { new Guid("a1a83379-ea1a-4551-a641-2fa7f2e84b9e"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4089), false, null, null, "Tâm lý", null, null },
                    { new Guid("ba20b0b9-9833-442e-8bd7-c91ff6a12fa7"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4083), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("c29c8386-dfc9-4a8c-b65b-8e81403a5cc2"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4091), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("cb4a1339-4672-4bfd-acef-9bc21dee9c9b"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4056), false, null, null, "Tình cảm", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("2e21cf65-bbdf-49d1-a379-6f48dd123829"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3974), false, null, null, "USA", null, null },
                    { new Guid("3a8bbff7-f33d-4db7-b0ff-38cb5857d635"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3986), false, null, null, "Korea", null, null },
                    { new Guid("5fca2606-e813-475e-86b4-304bed6764ee"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3970), false, null, null, "VIE", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3966), false, null, null, "EN", null, null },
                    { new Guid("ea69680c-ce32-499e-846d-270497e47cef"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3973), false, null, null, "ThaiLans", null, null },
                    { new Guid("fa417607-4164-46de-b4f8-bc3d0fcb85f7"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3972), false, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3373), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3375), false, null, null, null, null, "2D" },
                    { new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(3369), false, null, null, null, null, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3239), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3257), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3255), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4153), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4155), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4149), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1c6666b0-aa4e-4713-8263-5b1e7c4e413c"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("1edfc7ad-2eb3-402c-8a6c-f99e69cc2c31"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("4a785a85-deac-4e8e-8d40-1776961a20e2"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("508dcf1b-42c3-4606-ad15-48e3450985e7"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("6a8bf731-6897-4e5d-b9e4-490df550fdfa"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("c62ff947-9024-453a-8fbc-c27027cb9b40"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("d58ea6d5-2ee2-46e1-8323-5a02b8aa63a4"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("d89da39e-231a-48e9-90e7-a02fcc73a347"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("f371b0aa-91f3-4a4b-bd82-1f3d599b715e"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("f3c8888d-5ac4-45f7-9069-56d69ab3d082"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(5426), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 10000m, 20000m, 10000m, 50000m, 5000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("072ec3eb-334b-4880-a987-c6962cf6447a"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5205), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 99, new Guid("45a93af8-c17e-464a-a63f-dee4661c2cdc"), "tetamhon.jpg", new Guid("5fca2606-e813-475e-86b4-304bed6764ee"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("2003b341-b538-477c-9a59-549d105ee908"), 13, new Guid("8e7417af-455b-413c-ae3f-62dcb7f9fb95"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5221), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("36f02898-cb02-4199-ac05-8eb53d7be071"), 120, new Guid("2917b90f-20ce-411b-8ad1-e0a83a732294"), "botubaothu.jpg", new Guid("2e21cf65-bbdf-49d1-a379-6f48dd123829"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("2a451d88-8dae-403f-ae1f-1620a28c7bf5"), 18, new Guid("e253c917-6df1-43d8-86d0-c2c9c5cbd5b9"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5276), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 127, new Guid("2bc1dda4-07fc-489f-813d-3b75986a032b"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("3102fcfd-f9dd-4898-838a-6a0e88357501"), 16, new Guid("a58c284d-cd8b-4e0d-b92c-0ce5413e9726"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5198), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("6c407699-fb0d-4506-b3d4-0fd81446a70c"), 109, new Guid("512f315a-5fea-401b-9023-e0feef48a757"), "yeuem.jpg", new Guid("3a8bbff7-f33d-4db7-b0ff-38cb5857d635"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("356d0a06-e5da-43b3-8696-52ee37b74100"), 13, new Guid("8e7417af-455b-413c-ae3f-62dcb7f9fb95"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5191), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("49cddcd9-ad8d-4953-8e3a-031117a4c272"), 113, new Guid("ba20b0b9-9833-442e-8bd7-c91ff6a12fa7"), "congtubaclieu.jpg", new Guid("2e21cf65-bbdf-49d1-a379-6f48dd123829"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("467afddc-866a-401a-9b0b-e037ef65c3e7"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5228), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("49cddcd9-ad8d-4953-8e3a-031117a4c272"), 110, new Guid("2917b90f-20ce-411b-8ad1-e0a83a732294"), "tretraukhongduaduocdau.jpg", new Guid("5fca2606-e813-475e-86b4-304bed6764ee"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("5d1d605d-26f3-427b-ade2-542327adbfa0"), 16, new Guid("e253c917-6df1-43d8-86d0-c2c9c5cbd5b9"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5214), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("2bc1dda4-07fc-489f-813d-3b75986a032b"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("5f5cc234-32e7-4cf0-af85-f394595755f8"), 13, new Guid("b1ec478f-325f-4cb8-8c1b-881e22c5c096"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5270), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 134, new Guid("2bc1dda4-07fc-489f-813d-3b75986a032b"), "cuocchien.jpg", new Guid("fa417607-4164-46de-b4f8-bc3d0fcb85f7"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("76a136ab-938e-4911-ab3c-74e553ddf0b5"), 15, new Guid("a58c284d-cd8b-4e0d-b92c-0ce5413e9726"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5235), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("6c407699-fb0d-4506-b3d4-0fd81446a70c"), 110, new Guid("ba20b0b9-9833-442e-8bd7-c91ff6a12fa7"), "chuyennhabanh.png", new Guid("3a8bbff7-f33d-4db7-b0ff-38cb5857d635"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("9434933f-ac2c-41f7-b894-1408613ba19f"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5242), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 100, new Guid("2917b90f-20ce-411b-8ad1-e0a83a732294"), "chayngaydi.jpg", new Guid("5fca2606-e813-475e-86b4-304bed6764ee"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("9814f460-802d-4e5a-882c-62c2ea2cc64a"), 13, new Guid("a58c284d-cd8b-4e0d-b92c-0ce5413e9726"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5249), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 113, new Guid("2917b90f-20ce-411b-8ad1-e0a83a732294"), "cuoixuyenbiengioi.jpg", new Guid("3a8bbff7-f33d-4db7-b0ff-38cb5857d635"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), 16, new Guid("a58c284d-cd8b-4e0d-b92c-0ce5413e9726"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5170), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("45a93af8-c17e-464a-a63f-dee4661c2cdc"), "ngaiquy.jpg", new Guid("3a8bbff7-f33d-4db7-b0ff-38cb5857d635"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("df85cd48-f9f9-45c4-81b4-f4c96c910927"), 13, new Guid("8e7417af-455b-413c-ae3f-62dcb7f9fb95"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5255), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 123, new Guid("45a93af8-c17e-464a-a63f-dee4661c2cdc"), "kinhvanhoa.jpg", new Guid("2e21cf65-bbdf-49d1-a379-6f48dd123829"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("e0f5bad5-1c61-404c-a48f-1e553b14b383"), 18, new Guid("a58c284d-cd8b-4e0d-b92c-0ce5413e9726"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5180), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("36f02898-cb02-4199-ac05-8eb53d7be071"), 81, new Guid("45a93af8-c17e-464a-a63f-dee4661c2cdc"), "xich.jpg", new Guid("3a8bbff7-f33d-4db7-b0ff-38cb5857d635"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("f0ccc462-45ce-47b5-857f-fc060188d50f"), 13, new Guid("e253c917-6df1-43d8-86d0-c2c9c5cbd5b9"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5262), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("b063c434-6674-4ff8-a0cd-3a3f86cc4db7"), 118, new Guid("a1a83379-ea1a-4551-a641-2fa7f2e84b9e"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4216), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(4221), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("50a4ddb3-5748-4e8f-a8c1-518cdbbdfbbc"), "Hà Nội", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3859), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("5a28428d-bce5-4c65-8684-c316b8bde4d2"), "Hà Nội", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3423), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6a002d80-3bbb-4b76-9277-6c330a6306f2"), "Hà Nội", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3827), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("95bedf72-5ddf-4e41-8ce7-e60d2d226763"), "Hà Nội", null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(3917), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("1b807fe8-2054-4951-abaa-efc79264e133"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5383), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 23, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5382), new Guid("1edfc7ad-2eb3-402c-8a6c-f99e69cc2c31"), null, 0 },
                    { new Guid("5f0b01c6-bd4c-45bb-b009-f781f7ae9da4"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5392), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 21, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5391), new Guid("d58ea6d5-2ee2-46e1-8323-5a02b8aa63a4"), null, 0 },
                    { new Guid("629676ae-7a38-459b-91ec-da30ba2cd780"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5374), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 25, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5372), new Guid("f371b0aa-91f3-4a4b-bd82-1f3d599b715e"), null, 0 },
                    { new Guid("b24b9818-5156-41ee-8067-d45b23b50c9d"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5396), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5395), new Guid("f3c8888d-5ac4-45f7-9069-56d69ab3d082"), null, 0 },
                    { new Guid("bafea862-e4a6-4e79-974d-546b78363137"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5379), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 24, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5378), new Guid("1c6666b0-aa4e-4713-8263-5b1e7c4e413c"), null, 0 },
                    { new Guid("c3cd01ec-dbe7-4f06-9f14-277f09f09d37"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5400), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5399), new Guid("4a785a85-deac-4e8e-8d40-1776961a20e2"), null, 0 },
                    { new Guid("c94e712d-820b-498c-bdd7-f0f45b6bfc85"), null, new DateTime(2025, 1, 15, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5387), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 22, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5385), new Guid("d89da39e-231a-48e9-90e7-a02fcc73a347"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0066b9a0-0a3f-4448-8261-98c7749eea54"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4408), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00df5609-4bce-45bd-805a-33a66c6309c4"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4317), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("01e4b2a7-8481-4f90-8a13-67dc7271e52b"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4845), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03ab6658-5088-41c5-a67f-96c6cccd46a0"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4659), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04e49c0e-4be6-4022-8037-10dc44986f49"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4613), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04f01d33-38be-4b8b-84c3-dd49a73f661f"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4323), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0544f806-d68f-467f-916c-194996f6d0d8"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4777), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05ff16f6-8368-461c-9a0a-d944fd1f6107"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4978), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("068a8f79-b05a-4d0a-b893-ee6f3f0d56a5"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4624), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0801cfa2-19b2-449d-b4d4-988418ba7654"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4620), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0801ea66-0f56-476a-a2c6-d56e0e307be3"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4740), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0bc53fad-3e6d-4f79-9732-d3646d683230"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4618), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0bd7b80d-2423-45f2-af58-a4920fbb9728"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4345), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cc5c392-c492-489b-827d-92c90a92cfe9"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4678), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d77208e-26b8-4d26-b1e5-d40a116a7cc6"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4914), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0dc56e53-e94e-4784-ad65-0d3f8245aadd"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4401), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("102373ca-108c-4992-bd5f-28236366f457"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4867), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10730ece-f2fb-4b05-b673-65df15b63d59"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4324), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10c4b96f-d36d-4949-92b4-feca23ee589c"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4326), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("110384cf-0233-4b78-8b2e-9e607fbee6dc"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4672), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11369085-39ce-40bd-a7dd-f01d6d46e3e9"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4839), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("117d0f38-8426-4153-a86b-655fd0472328"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4971), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11f403ee-58cf-4853-a290-0b70161dda7d"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4474), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12195b06-0a78-4326-ae0e-161e2d576c4c"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4286), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("125b6d6f-362d-4af2-920e-63fc6cefb861"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4733), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("13b084fa-6a04-401f-a5f7-c12233cc3f9b"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4627), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("144b30ee-3c46-4f9c-aab1-135ac17db4d0"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4533), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("148629f5-4059-4850-839b-f2854e12a24e"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4846), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("159adca3-833b-481c-8e8b-4ba5854ab27d"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4339), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17509f4f-726f-4d2d-ab3e-cc8c43a2fb19"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4513), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a0640ed-3070-48cf-9431-fd6475effb34"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4796), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1becafec-70e1-49bd-b4fd-5f44a119c63d"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4380), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cf218d1-f4bb-46cf-9569-339c754ac6bf"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4729), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1da7cac9-19f3-4fe4-ae8d-6ed8306804d5"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4448), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fafeb7d-bbad-436e-ba38-2a9a2962f287"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4352), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ff695d1-0cf1-4432-83d1-4385a6ea270b"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4936), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20e94e52-f0cd-4564-9cb6-b8105de34e8d"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4525), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20fb2a02-2307-43c2-9730-1993d4be5b6a"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4475), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21ad787d-512f-4d02-b451-3ffa08b97143"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4717), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2212e70b-3a35-4860-8cea-a0470be43208"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4741), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("228b940a-8256-41e7-b75a-7f5b8d0f64fe"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4337), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2331da06-3f88-4ed1-8f10-ed6a084aefc0"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4682), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23b36c18-838d-432d-9c46-632e45838c35"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4457), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23baf6c5-f76e-4a35-a9e0-2ccbca4ce636"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4453), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24386b49-c381-425b-bc16-73d858c2b233"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4621), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25616b44-f704-489f-b572-984eeda165ec"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4541), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("272ddcf9-cae5-4f5b-9d78-0844823e837e"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4869), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("281d417b-59f7-4c40-878b-efd332f8c302"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4966), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("296caa80-b2a0-472f-ade1-737131062abe"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4540), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29b5dac1-497f-44e7-b00c-da2fe667d26a"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4802), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2bfec355-1ccb-4c9b-a230-3d70e4b104fc"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4938), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e261791-67eb-44d2-b2b7-9d56e4c48078"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4746), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f50044e-97b8-4805-87ed-f0b12fd7fa3f"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4415), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f7ed32f-3675-4f35-99ca-e616f7440b6e"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4329), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33a7c24f-4f96-4ce7-be87-f38b7d87c4d2"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4664), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39fb2a12-1e57-45ae-bdb5-c67a8edd0a51"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4411), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b3caf3b-673e-4ac3-b460-e1b5342df359"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4928), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bf80413-3709-4b92-9a50-f9ba5abefc07"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4842), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e07b9a4-ee12-4b66-b6d0-9762086e05a7"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4456), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e753193-a905-47e6-9df1-c891a87b627a"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4841), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f38faf4-5cb2-4c2d-ad3c-8f54a61d6634"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4670), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40fd8bf2-e4a4-4f18-a984-4b9391e02802"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4799), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("411106be-75d1-4417-a4a6-749c0c8234f6"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4333), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42413bfd-b6c1-4e77-af91-1861246b1fc3"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4804), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("428c5508-c337-4f92-a9ba-82f8029d3ed4"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4781), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43d96ab8-7f58-47a0-ade3-b2a9afb3e256"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4803), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("453238ff-7c8e-4d4c-9953-111e3dc2d913"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4795), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46010d1b-6561-4dbf-a5d6-f681dded0511"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4396), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46984885-0dc2-42cb-86b4-fb5ac5ec3642"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4469), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46e6a43b-98ff-49f9-b034-b2e6fb913a1a"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4463), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("473a2eea-75d4-40b6-8e85-05e8d6504c81"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4779), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a2c9c38-3e9c-4697-b98d-efeed1d7aacf"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4666), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b2e85cf-3956-4837-b854-74f7285a0970"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4521), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b8098de-faa1-498b-83e4-815fefea3f56"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4592), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c6b1f71-97c6-4985-8f4e-619f4482adf4"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4590), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c7ec6f6-7190-40c0-a858-40a597e36899"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4398), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4cbca959-c4b0-4003-a16e-d30a664af376"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4934), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d3376aa-801f-410d-bb1e-0021a9522ab8"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4479), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e0cde7c-c75d-4422-9123-9664f192dcb4"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4656), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4eba1b3e-cdce-4e0e-99e3-079fe53e13eb"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4385), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("502167be-6ef4-449c-8344-0ff9ef1f224f"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4471), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51109b15-6c09-492f-96de-206e1073920f"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4793), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("511763d8-58d5-46a3-b9a9-61cc7b29822b"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4654), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("512f9900-8290-43b7-b79d-e2074444fde0"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4509), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51609950-5325-422e-82c2-7611c83c646a"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4461), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52c79c67-f42c-4292-950e-c8da85c56334"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4331), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52c878bf-55a1-42d4-9e6b-e8330f2bdfba"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4976), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("533a846e-143b-42c6-aac5-06172ec5f3c9"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4680), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53aec688-4ec4-4310-9ff2-05308cf7af03"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4800), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53b9de64-a13c-40a6-b622-3cfbd93fceeb"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4725), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53ce99b6-74cf-4ec2-ad6e-ca2780fd7e30"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4857), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53d83647-3e9e-40a0-ba1d-369a7e1780f4"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4915), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5473e5d0-a9e5-4222-93f4-84d922f4c14f"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4336), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5478d6ad-8594-4806-a0c7-06f19f85cf7f"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4395), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56a05b11-72d2-4994-b3c3-7ee28da20361"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4927), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("582eb28b-7d73-4d01-a431-7370e779aea6"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4745), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58365671-e379-4e07-8c72-c2f9e158bb09"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4774), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58d662a4-2182-4b29-b817-100efe0ad8ef"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4516), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a8259d7-2327-4537-8a68-46ecf66a4c33"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4866), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c5c80fc-747c-4848-a40a-3b7b1a55ff07"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4657), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ce69056-7bba-4ecf-82a7-b45cb98a6c7d"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4792), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d5e9f83-6beb-41d0-bab3-fe76c4a79d60"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4460), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6045b77c-5e3d-4f44-9209-2236490cabc3"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4851), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6047d02c-25b6-4bb5-bee0-adda73697ccc"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4536), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("631a7ad7-52ab-44dc-8f61-52055fce2551"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4537), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64410313-6d81-4a76-ad23-ef66a554110d"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4932), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("648ccf82-888b-4c52-90f8-05137deb73d2"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4283), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66bcd00e-d0ed-434e-98f1-a6eb70da5ca1"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4905), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("695b6ab4-7345-4865-80e8-de840a5fa3cf"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4787), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69b78038-acaa-4064-918c-595c21c077d5"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4860), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a1368b4-2bdb-4596-ae15-0dc2d2285324"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4455), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c115172-b859-4e22-a972-d0be17275f99"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4616), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c2f1817-31ed-4c49-97e6-9147123b7fa4"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4712), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6cc9acf4-784f-48b4-a13d-30a867ae444c"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4788), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d0fafdc-772f-450a-8560-386cbd67077d"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4520), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d7210d7-699d-460d-845c-2a98b16f1740"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4607), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e836bcf-158b-47f0-9a62-f238b1437516"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4721), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("727c4631-debd-4e10-8b42-b019f6841d62"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4812), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7296056b-031e-4d8c-a6fc-5977c3290aab"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4855), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72be3f01-fab7-4000-a8d6-c3ff18fcde3a"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4406), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73e9ab73-27f5-49b7-8836-b16b4ed860e9"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4715), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("744af432-ab3a-46f8-b5b5-7a3e77eab623"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4973), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7588d8b1-3106-46b7-b8c2-9dbba967926e"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4748), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("760fdf06-5ca5-47d2-89ad-d70eedb939be"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4684), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("774cc4f9-e1d0-47be-b663-c128001fce4e"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4972), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7760a952-8ca5-4fa3-b2a8-0a2ee0d981ef"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4519), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("783bcad6-77e8-4528-afde-7a74af4e983c"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4674), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("788021bf-473f-4d40-9049-ed7249126a53"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4806), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78be841c-28a8-4a06-8253-ee6c7d42a675"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4445), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79764027-6c3a-4511-b74f-13cc762cb47f"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4844), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b6cb395-c516-4a50-9056-2c97ea7be639"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4848), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c20d95b-b2dd-458e-b897-a610bc2ddc04"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4405), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c8e2983-0616-4be5-9d74-cbece9b7f749"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4780), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d0d41cb-9c33-4446-97e4-dace2b7df2b2"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4402), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e18f4c7-87f1-441f-941e-c3078a575840"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4853), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e77ca2a-9624-4b86-b7eb-05819648ab38"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4859), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f48e225-be27-44d0-bdcc-66c19751ffa5"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4975), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fcbacc1-c0a8-4ae3-8d0b-83d807207c7d"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4681), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81e67b87-870a-4736-b9cc-f7d9a7b3c22c"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4667), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84e2be82-f9f1-4ae8-8c3e-595e5e272df9"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4931), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85675e16-44bf-4ef6-80a4-11edef687a8f"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4615), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("863f6362-dbd9-44df-973a-f427a967ccf2"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4612), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86daa188-8570-43a9-bb22-119369845c23"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4528), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87498783-c608-499d-985c-91b9c73ccb6a"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4722), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88639a35-842d-4737-88c8-072970705872"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4451), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88df387c-02d3-420f-88a7-7391a8dfc8e1"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4446), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8996ba53-3f0a-4d97-bd03-609167645376"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4969), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a5fbe5b-95f4-4bcc-a3fe-387192fd81eb"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4327), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8aad6058-a7c6-4177-876e-33fa02f67593"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4383), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8bdc6269-9c0e-4781-a4f8-7f3ecfab36a6"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4727), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c03b435-8ecf-4cc4-bcb5-b3c0216de99a"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4908), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c528d6c-0d8b-4cfd-863a-b2037ea622a5"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4925), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8cbdace6-827d-4fbf-b84d-bf8e02fdd3cd"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4921), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f8c7014-ab14-4b91-ba68-743ad0538c5e"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4524), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93052727-edfb-4827-88b8-48991dcc44f3"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4343), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95b0a294-57cd-4c4f-ba4e-9e7c862b19eb"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4918), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95e5be94-3e8e-44bb-9fb2-ae1c582c16e6"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4245), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("997aaac0-1432-4e47-9403-e54bb12f8e0f"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4782), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99950939-1edf-4ee8-a7e4-43ff1baa2f1f"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4515), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e83710e-a4e6-44dc-bc83-b270e17f0317"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4414), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f070546-3d85-4406-b872-5b1a57c23383"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4315), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f40ec59-eec0-48a9-804b-d9d6942c3d73"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4279), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1c45621-14c2-4418-b754-10f29f40ebc5"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4791), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1f91e95-2974-4321-949e-a554a1425181"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4865), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3aa3d6c-cd37-489f-b57f-520e12dcca0b"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4870), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3f4ec44-b7c7-496f-9750-563b80926740"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4858), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3fd49b7-cff3-42a2-aa14-ceb1af0b8855"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4719), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a69a295d-6a51-47a6-8616-20c1d8292a82"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4602), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6ff281b-93d3-4bd4-a288-4a7b1baff1d1"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4872), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a73c0148-3acd-4d3b-91bc-068792e19779"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4595), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a896874f-43a8-408f-9987-bd05ddd08fa6"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4731), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aad2192d-e32d-4f1f-8b4b-fdbafe0fb039"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4381), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab1d45f4-1ccc-430c-966b-49471ba59907"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4924), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab233a48-54c3-45a6-907f-59e6895c58ff"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4723), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab81ef49-e1d2-4118-8681-b834ff374243"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4523), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("abe88aab-9785-444b-aa34-56c0022568a4"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4626), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae520981-c54e-45e9-9835-b64a1151cb7b"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4776), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aeac4473-935c-47d9-8dec-d7c451a55944"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4349), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af217049-4e6d-49c2-8625-c62fbaf0aaed"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4735), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b03b7bfb-dc4d-477d-a7ca-c3a07eb7f8c1"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4544), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0d5bd62-9a9a-4d0f-8e45-43ec24158f09"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4459), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b405ee16-4daa-444f-ac34-9d1c95a5e08f"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4910), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5b28efd-0991-49f0-9adb-8131ee91bbbb"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4920), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9091781-1bf2-42aa-9af2-4179748a6a23"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4546), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b92592a6-aebd-4220-b502-f633facd4d65"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4319), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9916947-fdcf-454a-88bf-dc1f6c2af4e1"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4604), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b999500c-a156-4eb6-ad2e-71f2ac10b515"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4311), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9e67e18-8dac-492b-a6e8-903856bc191a"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4808), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd3ea31b-80a6-4127-b81c-517366c695dd"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4527), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd90a63c-4893-4238-b2c5-75e44baadf54"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4539), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf34a166-9b90-4eb9-a740-ce2be8842b34"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4603), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c09192d6-9d37-4b7d-9428-39625072550f"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4744), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2c4f409-1f36-4df1-a7cc-081093a78e51"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4585), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2fe117b-dab0-4c3c-b802-c0d29f2abf22"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4350), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c386ad75-c325-4508-95af-65212b8d9672"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4512), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4324d62-813c-49bb-89e7-b20151e370ba"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4939), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c55318b9-3e21-44cc-bb68-e72ee3dc6a5c"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4508), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6f69e03-133e-44ad-8292-1bb973e09d5c"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4378), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cabcb32e-11a9-42e2-8eec-1dd005fba3c2"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4389), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb2309de-d8c0-4e07-b213-9fb0f24e5c35"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4416), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb4f4d3a-07bf-4e8b-ac43-2f701f033a54"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4673), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb8016b6-986d-4379-a932-12aae14c1cf1"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4854), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cec76727-cf55-4b4e-a37f-db1f4b94b4de"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4911), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfa910fe-fa53-4900-b680-6a113c4ccdd7"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4617), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d33a70d2-9874-48c3-93b3-5c418c524125"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4711), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3a171d6-e457-4992-8a54-247213c2a802"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4935), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3dff5d5-900a-48dd-aa86-13e2b951091e"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4473), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d42b82c7-605c-4d08-abd3-415f0c501452"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4784), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5bd124f-74c2-437d-b844-aa059882501d"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4394), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6865a89-e35a-44a4-bc72-21533bfb0115"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4593), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6a7a76e-9a69-4564-b314-cefd11f923d4"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4737), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d766fc56-7877-47bb-b942-17cffbbe95dd"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4609), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7e33f60-4c2a-4b18-829f-ab09496e0a01"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4392), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d822ebad-7a90-455e-b6ec-4eab5040f480"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4977), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d88469c3-494c-472c-af72-d06c50c621f5"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4285), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d925652d-edff-4dd0-a8ae-908e5f632a95"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4873), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db7aa91c-89b6-4c66-883e-e42a2249a3fa"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4470), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbb0e0c6-c39e-493e-9bdc-905e567cb7c1"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4734), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcb3d614-3926-4ee8-8ce2-cae234c72c2b"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4661), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcd83663-2d4a-4fc7-ae0b-6e6222011bab"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4342), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("defaec5b-9168-4894-8adb-d29deec5a2f4"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4391), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df6b813b-2766-4c58-a282-5c172c702885"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4606), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dfa64edc-c8d9-4945-bfb4-129a159d1ae3"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4749), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e18c0f9b-3c7c-4689-9629-0a7d4fcd2dc6"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4922), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3566200-205f-4e54-8d07-1a2ef678dfb5"), "B", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4340), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3acc0cd-5ad1-427f-8952-010b867d9de0"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4531), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4bd643e-ff42-48f4-b2db-fb5eeb5a2c75"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4912), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e846cdcd-d062-4439-9ed5-79a64c37c5be"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4789), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e90e2d61-25aa-4324-b2e6-fbe2c2f9a1b8"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4409), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9106c69-82a6-412f-981e-2c89e5974ccc"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4466), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9302709-22cf-4974-b884-7a927e7e3434"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4468), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea3cf7c4-7225-4562-9787-bfdd2c58ec03"), "C", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4535), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ebbec4d3-96ad-4120-bab4-b23ed0ad481a"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4668), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec4b221f-48c1-43ad-a52b-bd7fc6ae77ce"), "J", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4907), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("edfaac56-db12-4170-a6ab-49561c9c06d2"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4449), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f09c50b3-3ca7-4686-88af-2969e7c59225"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4730), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0a64ba8-5b4d-48ba-a808-12b28c180d36"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4510), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0dcbfd8-b9dc-4fc3-931c-ceed2f29fc44"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4404), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1a40a09-74bd-4e96-bdf3-c196ed641a1e"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4388), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2fbad4b-03c3-403b-ba65-d23f1b0363e2"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4599), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5bda851-fcf3-4488-95b5-c8fbe19af57e"), "G", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4314), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f65fc55b-6a0f-426f-9896-e12b2a9c7914"), "H", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4600), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8b45f42-d4db-46dd-9e99-03131e2e75b6"), "A", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4864), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f91a70df-3dc5-4f45-be02-46f49354db5c"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4346), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9696064-42a1-47d2-8ab9-9acb7eb262bb"), "E", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4742), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb2cb196-aa57-4ae2-85c5-14c965b5f809"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4809), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd55c5d9-8882-4529-a560-5db31db77acf"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4330), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd9f46f9-e8b9-431a-9701-06708d1b0b07"), "I", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4718), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe016aa2-010e-448c-b68e-504524dc334f"), "D", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4685), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff0ff1ab-596c-4599-adab-5d76255eab69"), "F", null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(4596), false, null, null, null, null, new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("25b8bc8c-3d1b-4d2e-97fe-f861c2cd3313"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(5336), new DateTime(2025, 1, 16, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5343), false, null, null, null, null, new Guid("be1e7294-e763-4920-a417-4b2787750bbf"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 15, 20, 10, 58, 922, DateTimeKind.Local).AddTicks(5339) },
                    { new Guid("2adaec71-89dd-4315-9785-e07ff1f189d4"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(5349), new DateTime(2025, 1, 17, 20, 9, 58, 922, DateTimeKind.Local).AddTicks(5351), false, null, null, null, null, new Guid("e0f5bad5-1c61-404c-a48f-1e553b14b383"), new Guid("f5eb7b30-318e-4d3b-8996-09ed263544d0"), 1, new DateTime(2025, 1, 15, 20, 11, 58, 922, DateTimeKind.Local).AddTicks(5351) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("de8fafce-d8ca-413f-bb48-1ceb47a06c2c"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(5453), false, null, null, null, null, 60000m, new Guid("bafea862-e4a6-4e79-974d-546b78363137"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("1c6666b0-aa4e-4713-8263-5b1e7c4e413c"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("f6ec235d-9fac-4479-bc09-29448a908c36"), null, new DateTime(2025, 1, 15, 13, 9, 58, 922, DateTimeKind.Utc).AddTicks(5447), false, null, null, null, null, 50000m, new Guid("629676ae-7a38-459b-91ec-da30ba2cd780"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("f371b0aa-91f3-4a4b-bd82-1f3d599b715e"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_ActorID",
                table: "ActorMovies",
                column: "ActorID");

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
                column: "BillID",
                unique: true);

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
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "FoodCombo");

            migrationBuilder.DropTable(
                name: "TicketPrice");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "TicketPriceSettings");

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
