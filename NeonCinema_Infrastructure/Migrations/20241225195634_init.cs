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
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    BillCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    { new Guid("477dbe59-5e9f-483e-ac57-867b4c27251a"), "hgdsad", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5749), false, null, null, null, null, "hotdsot", new Guid("b17fff9a-48d3-47ea-b49d-92e0fa41d861"), null, "mua tại quầy" },
                    { new Guid("79d78231-d65c-4579-8d86-26fcbfe9e43a"), "phonghhhhh", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5743), false, null, null, null, null, "hotdot", new Guid("0e1265d5-93e5-4591-a7a0-b868da4416ec"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4763), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("cf934332-6900-4c1a-b38e-6984170ae8be"), "11:00 PM", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4767), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0ed80ddc-9245-4699-8f97-9b6141950639"), "Trung Quốc" },
                    { new Guid("2ab0939a-cf13-4647-a47d-232c01b523e2"), "Ấn Độ" },
                    { new Guid("443607f6-5ab2-47c9-ae02-553818144eab"), "Pháp" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("9ef9b7ea-3e97-4659-93fc-d599e451c85b"), "Vương Quốc Anh" },
                    { new Guid("a9d808f6-6398-419c-9b69-8dd39d90a704"), "Việt Nam" },
                    { new Guid("be652bed-bbc9-49ab-936b-d0afc6f8f6e8"), "Mỹ" },
                    { new Guid("c9af3ad6-d68c-410f-b206-99cf56569932"), "Úc" },
                    { new Guid("d737e386-d1f4-4cc3-93de-12d5afb28c08"), "Hồng Kông" },
                    { new Guid("f4b92287-6e78-401e-b535-ba048f117c30"), "Hàn Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4618), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("286b2ff9-a848-4e60-adb1-1e9152c20dea"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4629), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("5d1037aa-0956-4b8f-b6d1-5b9682c28e0b"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4620), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("805aed88-9fef-4c7b-8c99-6737286da893"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4617), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4604), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("9542cc35-604a-4add-ac3c-43f4ba54ff0c"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4625), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b24c9f21-29ee-4de1-9b40-e41ce0478768"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4624), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b6dfd428-bb85-4d3c-9339-49f088a4cd54"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4627), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("cc52ad7c-282c-470e-87ca-e087de069082"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4615), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("eb7006af-0aff-4986-a512-d8c18a25c8d3"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4610), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("22e7dbc9-f7dd-40dc-a705-4032ef6dce8b"), "Combo 4", null, new DateTime(2024, 12, 23, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5722), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("2e83376c-91a6-4b9f-b3b6-fb209782ed2a"), "Combo 2", null, new DateTime(2024, 12, 25, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5717), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("b83ca163-98b6-45f0-a4a9-c7ac48eec087"), "Combo 3", null, new DateTime(2024, 12, 24, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5720), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("c2d93f0b-bd11-4817-a706-2ae06e363290"), "Combo 1", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5713), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("44b2ff8e-19f2-4cb1-8cda-4df2f757296a"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4666), false, null, null, "Tâm lý", null, null },
                    { new Guid("5cbc9bda-483c-4043-b88a-1187746f7f35"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4657), false, null, null, "Hành động", null, null },
                    { new Guid("6d0dc6ca-1953-4225-a019-df94de61fc1f"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4663), false, null, null, "Hài hước", null, null },
                    { new Guid("793eeedc-8f7d-4f57-a47f-1f956c81b994"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4658), false, null, null, "Kinh dị", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4652), false, null, null, "Kịch tính", null, null },
                    { new Guid("a8b23c46-ce8c-4d57-9b24-c1ddc55312eb"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4667), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("b6ff0c77-9e22-49ce-85f2-2725f14f457d"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4656), false, null, null, "Tình cảm", null, null },
                    { new Guid("b8c94845-06e8-4d65-8d39-362251dc21e7"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4662), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4659), false, null, null, "Hoạt hình", null, null },
                    { new Guid("f0908744-42f8-4adc-9174-7530a970a4ba"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4665), false, null, null, "Lãng mạn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("02d0b217-c852-4d48-8b76-83cc91f4abab"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4573), false, null, null, "USA", null, null },
                    { new Guid("443c2fd0-573c-4859-8ac3-5a9a0290c81c"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4569), false, null, null, "JPN", null, null },
                    { new Guid("503d4cad-4b43-4e99-8a18-7c0be62226b3"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4567), false, null, null, "VIE", null, null },
                    { new Guid("6df0db0a-c93a-41ec-974b-630faad24e10"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4572), false, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4564), false, null, null, "EN", null, null },
                    { new Guid("e001a4d5-545a-445f-8493-83163bba8cc8"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4575), false, null, null, "Korea", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(3844), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(3849), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(3738), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(3761), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(3759), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4734), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4735), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4729), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("06d29921-e248-4886-b175-2f93ee9fa8c2"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("22fab400-ed7b-4019-982c-1d8a7af86d92"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("5afb0be6-a825-45a5-b75d-9c0d14477e49"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("82b94df7-61ec-44e2-917d-ba6bf783b453"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("82ccce64-b021-4a76-a46c-93e3a2dc6333"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("840c5d82-deb9-41c7-ac7d-edc3a0b90e18"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("a0d83ba5-c32d-4475-8844-21ff74837856"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("a5a071a7-4e94-4622-b7f4-29f471c834e2"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("f01ee0d4-7f7e-47ce-825d-22d3783ecbfa"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("f8066a9b-33a6-480e-875e-4cb1c7727184"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5660), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("09a4d877-2cd3-4290-8f02-6fe80db455d0"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5485), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("220e6162-4820-4704-b8ef-6d8b02ba8bb7"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5455), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("eb7006af-0aff-4986-a512-d8c18a25c8d3"), 81, new Guid("5cbc9bda-483c-4043-b88a-1187746f7f35"), "xich.jpg", new Guid("503d4cad-4b43-4e99-8a18-7c0be62226b3"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5447), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("3aa0cbc3-97ae-4a34-aa9f-2dcfbf3985e6"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5548), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 127, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("47d2da8d-8cd4-4407-b1fb-25c1263f9be6"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5470), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("805aed88-9fef-4c7b-8c99-6737286da893"), 109, new Guid("793eeedc-8f7d-4f57-a47f-1f956c81b994"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("4f61da66-cf32-4031-9d6a-e147f6b0fb6c"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5497), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("cc52ad7c-282c-470e-87ca-e087de069082"), 110, new Guid("5cbc9bda-483c-4043-b88a-1187746f7f35"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("5e112d39-e138-44df-b4f8-5954a21a32df"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5509), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("805aed88-9fef-4c7b-8c99-6737286da893"), 110, new Guid("793eeedc-8f7d-4f57-a47f-1f956c81b994"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("64a38d38-a884-4c37-bfa0-f3299171ea06"), 13, new Guid("f4b92287-6e78-401e-b535-ba048f117c30"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5462), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("cc52ad7c-282c-470e-87ca-e087de069082"), 113, new Guid("5cbc9bda-483c-4043-b88a-1187746f7f35"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("6c2f672d-38f1-4167-b23a-1edf30fb9a4d"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5522), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 113, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "cuoixuyenbiengioi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("6eb994cc-8f45-45fa-b2b9-190204473cd9"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5542), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 134, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "cuocchien.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("7aaf9b33-f60f-4a8e-9178-14358a369140"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5516), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 100, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("9469f9b2-5f4c-463f-abe4-fed02dc81b7c"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5530), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 123, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "kinhvanhoa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("d8cf5fb0-d03e-411d-a212-66416016845a"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5491), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("eb7006af-0aff-4986-a512-d8c18a25c8d3"), 120, new Guid("b6ff0c77-9e22-49ce-85f2-2725f14f457d"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("e3ea3352-8768-4a51-aeb4-138f3ca2387e"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5536), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 118, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("f48ecfca-2e6e-4df1-bbd8-afbf39420455"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5477), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("09a0e9e0-a6dc-4d54-b260-0c26da19b42f"), 99, new Guid("eeb0d14c-d394-4aa4-8d0a-97cce9a0a3fa"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4809), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4803), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("071ff4de-3cbe-480f-89ce-30425c7735b2"), "Hà Nội", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(3907), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1454f1f4-2151-4200-a299-f625c0b9e4fc"), "Hà Nội", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4519), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("15c8155f-8260-4b34-b468-60b1da0fafd9"), "Nghệ An", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4399), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2128ab5d-5098-4dad-9c8f-9df0f2dfa953"), "Hải Phòng", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4308), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2e17553c-901b-422a-9645-d8e052f90d22"), "Hà Nội", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4283), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3dcdeacb-7dd0-4b13-85fd-a41568bcc47f"), "Nam Định", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4482), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("41520284-9d42-4fdf-8046-cd5169754a1b"), "Bắc Ninh", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4419), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6281c998-53bc-456d-b99c-3b271f0830ff"), "Hưng Yên", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4461), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("85e499f7-0613-4eb5-abb6-93e2a0326a3a"), "Đà Nẵng", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4329), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("86cfe87a-689a-4542-85bf-22391a745414"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4368), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8e8e1b5f-f575-4d28-82f7-00d9c6c64140"), "Quảng Ninh", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4501), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a2832617-64a1-442f-99fb-c04a8dc41054"), "Thái Bình", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(4438), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PromotionID", "Status", "Surcharge", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("0f4dfaeb-8c90-4e9a-8c2f-0a18687ae3d4"), null, "BILL001", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5776), false, null, null, null, null, null, 2, null, null, 500000m, new Guid("071ff4de-3cbe-480f-89ce-30425c7735b2") },
                    { new Guid("26d306a7-49d4-439f-9ed6-3b2f8c0524b7"), null, "BILL003", null, new DateTime(2024, 12, 25, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5782), false, null, null, null, null, null, 3, null, null, 150000m, new Guid("2128ab5d-5098-4dad-9c8f-9df0f2dfa953") },
                    { new Guid("2dd6c2f7-7321-4cb3-afbd-2a1bc717d48a"), null, "BILL010", null, new DateTime(2024, 12, 20, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5805), false, null, null, null, null, null, 2, null, null, 700000m, new Guid("3dcdeacb-7dd0-4b13-85fd-a41568bcc47f") },
                    { new Guid("4c736a16-b05b-4680-85c3-c0c7520b0295"), null, "BILL002", null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5780), false, null, null, null, null, null, 2, null, null, 300000m, new Guid("2e17553c-901b-422a-9645-d8e052f90d22") },
                    { new Guid("55b93e97-1653-4fa9-ba45-8ef0b35ed127"), null, "BILL009", null, new DateTime(2024, 12, 18, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5803), false, null, null, null, null, null, 0, null, null, 350000m, new Guid("6281c998-53bc-456d-b99c-3b271f0830ff") },
                    { new Guid("79211f7f-b4c1-48de-ab54-389aaa69da40"), null, "BILL008", null, new DateTime(2024, 12, 16, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5799), false, null, null, null, null, null, 2, null, null, 450000m, new Guid("a2832617-64a1-442f-99fb-c04a8dc41054") },
                    { new Guid("7ab223b2-fc9e-4f42-8a26-d346cb26323e"), null, "BILL007", null, new DateTime(2024, 12, 21, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5797), false, null, null, null, null, null, 1, null, null, 800000m, new Guid("41520284-9d42-4fdf-8046-cd5169754a1b") },
                    { new Guid("88c726c7-72b3-4021-b506-397d44d7bf58"), null, "BILL004", null, new DateTime(2024, 12, 24, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5786), false, null, null, null, null, null, 2, null, null, 200000m, new Guid("85e499f7-0613-4eb5-abb6-93e2a0326a3a") },
                    { new Guid("89e9b942-22ef-459c-a8fa-19712326ab4a"), null, "BILL0122", null, new DateTime(2024, 12, 22, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5794), false, null, null, null, null, null, 2, null, null, 680000m, new Guid("15c8155f-8260-4b34-b468-60b1da0fafd9") },
                    { new Guid("e26b68c9-2db9-4065-8640-d3c428b8de92"), null, "BILL005", null, new DateTime(2024, 12, 23, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5789), false, null, null, null, null, null, 2, null, null, 250000m, new Guid("86cfe87a-689a-4542-85bf-22391a745414") },
                    { new Guid("e3189fa4-8afa-421b-a6f0-16013dfde05a"), null, "BILL006", null, new DateTime(2024, 12, 22, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5792), false, null, null, null, null, null, 2, null, null, 600000m, new Guid("15c8155f-8260-4b34-b468-60b1da0fafd9") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("2c272d49-a697-4e92-9ba5-40438320805e"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5889), false, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5891), 1, new Guid("071ff4de-3cbe-480f-89ce-30425c7735b2") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("299ec37b-077c-4854-bf56-c50d13ab2763"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5638), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5637), new Guid("a0d83ba5-c32d-4475-8844-21ff74837856"), null, 0 },
                    { new Guid("2d88f119-1740-4eef-93c3-e6f22d9152e6"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5618), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 4, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5617), new Guid("22fab400-ed7b-4019-982c-1d8a7af86d92"), null, 0 },
                    { new Guid("7678307b-4b90-4378-8e3d-7d2c15b06e82"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5635), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5634), new Guid("82ccce64-b021-4a76-a46c-93e3a2dc6333"), null, 0 },
                    { new Guid("7fdc1b7b-84f5-4e79-8473-7629d41593a8"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5631), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5630), new Guid("840c5d82-deb9-41c7-ac7d-edc3a0b90e18"), null, 0 },
                    { new Guid("9eb56519-b346-49fd-9c32-fea8e0fcef91"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5623), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5622), new Guid("5afb0be6-a825-45a5-b75d-9c0d14477e49"), null, 0 },
                    { new Guid("b23b5171-abd9-4f52-a1ce-fc850cbb7127"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5627), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5625), new Guid("a5a071a7-4e94-4622-b7f4-29f471c834e2"), null, 0 },
                    { new Guid("b9dfe2fb-3bc1-42fe-a67c-678543a85764"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5612), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 5, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5611), new Guid("f01ee0d4-7f7e-47ce-825d-22d3783ecbfa"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("037795a4-4ea0-4546-81d4-7c7a4b1becff"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5185), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05b5037e-bc76-4058-a7ea-88c9600e9b39"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4927), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08ef15ac-309b-433b-b568-bb07d3ce491d"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5008), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b0adaf2-6c30-4907-8055-811ba7906240"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4938), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c02f0c6-0acc-46c8-ad8d-91e2f0e31b0a"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5272), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ed7ce70-4786-40c8-bfe7-996782e1e969"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5010), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("111bfcc6-5231-4c36-9cbd-5ce19ac9a633"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5278), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12ab104c-3f8d-480a-90eb-2ee2cc1a7793"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4934), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12fe4ce5-4444-4a6e-8471-13a2fb90e454"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5114), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("13eb530e-830d-4d16-a012-7442b438e80b"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4894), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16a991e6-516d-456b-8d3c-8e53d5797975"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5254), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16e97764-ad27-402f-8cc1-88eb50adbe25"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4967), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17c73cee-b0ff-41ad-8e7e-e42b41755f2a"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4991), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17ccc7b2-6098-40dd-8fef-e96fd3f0d436"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5113), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1885e3f6-1306-4b61-8422-1934f426a067"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5236), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f7f31ec-0792-4364-81ca-eb0e889abb70"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5253), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fb87208-ee59-4e48-bb63-1afb61791684"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4904), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fffe999-1e5a-4fc6-9608-687d91d768f3"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5169), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21e6e1fc-cc7e-457c-a7d7-e1b18077f923"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4970), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21f165f3-aa2a-483c-95fd-0f0bc4dba1a9"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5263), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("227966d4-5268-4162-a30a-c3c57a382425"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4971), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22b1bd7d-6b22-452d-b187-352f5959afeb"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4888), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26a46afd-c597-40c3-8a44-9f8e3fe6733f"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4871), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2706a3d0-1198-472e-92a1-f03a8d8d6165"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5154), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27877d44-f23e-44a5-a1a4-16503778ca17"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5092), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27b3e837-ad17-45fd-97af-f9690ae1fb24"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5208), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27c9fad5-2a0c-4092-962c-109cabe2e6f2"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5138), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("28eebe1a-c92e-4a5a-9d0e-de4bed10241d"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5296), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("292e8df0-14e4-4df3-b0e2-f63a1e2215b7"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4899), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29a27950-0683-4aa5-9c2d-36be29e4e88e"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5277), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ae44747-1bcf-4aed-af97-5f9d84671a37"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5000), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b3c31ad-b1f4-4722-9e0f-e69d2360f2e7"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5162), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b697f64-3ac6-49e8-9f2c-2d17c8453ba5"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5210), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2be39631-da0d-4410-9a2e-be35d5496549"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5198), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c4d5891-b41e-4fcd-b662-bb1f8c16e002"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5056), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ea3534e-695d-488e-ac37-565f95edf017"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5248), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2eadd0d7-8119-418a-9291-470bd4b7bf18"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5087), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f6e22a0-182d-4a05-9b5c-d0345aa40be7"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5046), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f8d9f28-44ba-4308-b81a-1e92e4ec6ab1"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5209), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("303d4dba-cff9-4be6-912c-347511117dea"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4996), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("316ae5be-a532-45fe-8ff5-1a67f15a2476"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5137), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3305e07d-b5e0-4351-aad9-e7d4f1b78a67"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5018), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33282259-c1d2-42fb-a218-f6b20c3dc45a"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5199), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3453de4b-7c7c-45f4-99a4-3c5d29571319"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5276), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38ce7121-f890-4d3a-a051-ec69c0c532a3"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4892), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("391bc00f-5f6a-4125-aade-a054c817f0db"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5115), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a50d1f6-443a-4e7e-bf18-1ef035280162"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5098), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a5ba090-3d75-4779-bfc6-0a18768a38b7"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5274), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3aaf0a04-773e-4785-b01f-ce3f3a3870c3"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5095), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b445e19-e340-4667-8b3a-9e044339365c"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4960), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c247c4f-27c2-45a1-bb67-b67eaf6af89a"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4985), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c41b0ce-13e7-457b-a343-6504d1510e32"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5279), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d035566-198b-4917-8227-2119af961365"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5063), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d13d178-7c74-4283-9a8d-29d3a7ac6867"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4925), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d8a8424-48ae-4bf0-b644-4dc8a30a2dba"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5032), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ea1e268-913e-4d17-bb2e-7f0b97bd3a4f"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5192), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3eb3d21b-01dc-4fcc-9504-de7934f29919"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4957), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f1a916a-01e3-4918-80ec-7887cc198c51"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4885), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f2463a7-b1ed-4e0b-8a71-a510dc763554"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4920), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f625226-7c3c-402a-835f-f87768bf8d85"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5015), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fd48e55-c1d2-48a8-b882-c4af8c1ea4fc"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4897), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("432b9414-9db5-48de-8e10-2eb7fc7b8600"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4921), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("437e6cd7-d780-4c41-a865-01c31b19d631"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5116), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43dc9020-ee42-4045-95dd-bc5ca2791858"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5019), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45e7130f-6b1c-43be-8f10-c1b4c3a0ca24"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4873), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46c17076-2bee-43bf-9ee2-e914c893abcc"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5213), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4743621c-d48a-401c-9316-9bc73277eef3"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4922), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47ed848c-024c-40d7-abae-e7bef4208884"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5257), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48eb56b6-c7a1-4f23-a3b1-dd322e0bc68a"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5249), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a012474-4d1a-4268-bfb9-23ac95aab7f2"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5165), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a5d1a8e-a5f2-4a47-bcae-4f724aa6f0df"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4965), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c0c6c3b-8a24-4d62-b919-f0ae5e30bf1e"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4997), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c9b5cbf-b0ee-4a27-bf26-cb68e1735140"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5205), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4da1041e-dcd8-4c82-a885-182669e3c00b"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5041), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dc6061d-9408-4217-b7ec-74515176ae8d"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5286), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e474d86-0636-4f26-ab96-ed1b14d16c38"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5071), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e7df195-ae89-4501-950e-9789644b7944"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4910), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50030f36-5e41-480a-a44e-171435ac38c4"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5259), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("503d611c-3976-4008-b9a9-6e6364efd690"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5084), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("523b1eb1-1f11-4056-b8d5-da44addac21c"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5214), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("532d754a-f035-4342-a532-76117c033b02"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5196), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55694bd0-85af-4ddf-8f6f-3707b629fd21"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5287), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("558147f2-a97c-4a4a-b24c-c468f9eec113"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5075), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5620dbd4-e202-40ab-a174-c9cbea4565ef"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4930), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56f08749-bfae-43d4-a775-3c4bec22baa6"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4998), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58da9ff0-b0de-4740-b2ac-3202212e7bf7"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5127), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59766bc6-4848-4aaf-bc3b-27a000fc5f2a"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5290), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59a5ed2d-69b1-436b-b123-a19e6f3e1305"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5288), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a2810d6-3b72-426d-abeb-d2481467ddfa"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5139), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a28cc13-7e43-409e-bb2f-4cd6d7b09bb3"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5085), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b1b07d1-573a-4cc7-97d6-3b66d2be4a03"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5264), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c560b7a-7d5c-4ca2-956c-c5e49ecc656a"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5029), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f4a6b92-a90d-435e-9c9d-c9c18b88e3e1"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5195), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fa0c0b7-c6e6-433e-bc4c-754e819ca06c"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5002), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60199e65-296f-400d-a2cc-b03edbe962fb"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5225), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("605690dc-5f02-4993-9649-34ad7991c109"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4891), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6137e19c-b19b-4b75-8fd3-1d0aaf998d4c"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5258), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6253b3c9-c739-4e6a-8f56-d6a98490d80f"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5135), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("625df5e0-2fe8-499c-ace2-37ffbc9e571c"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5105), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("635528c7-8bef-4a73-85e7-8409636770b3"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5245), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63ef6afa-95a9-422c-a88e-7a605f042ae3"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5050), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6525cb3b-44a7-4e33-b8d5-968c7ba04a5f"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5218), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6546d550-e5e5-4541-a089-dcb6b7dbbdf1"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4956), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6554df2a-18c7-474d-838f-2efc9ccd0e52"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4932), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6564abd5-3eca-4857-820f-975447510f20"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4952), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66e800c5-b9a5-4b2f-b16e-8b4d53f02aad"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5036), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67e5c1ae-a2de-4769-9d65-0b27dc8d2881"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5283), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69df8a38-f266-475b-ba77-e9df4a5342bf"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5090), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a39f56a-c69e-4e0a-adf7-58c6c0d5eca9"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5132), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a737806-4be5-4c19-909d-fe069eed038e"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5200), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ab93819-bcd6-40ea-bae4-3bad0d0ddc7e"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5052), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ad99af7-1239-40a7-b4ae-04a54cfe5b30"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4908), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c9892fb-360e-47b6-a624-9d9c35a9a5d5"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5174), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c9b1db6-33a4-4ee5-964a-4dfc2cdfaea0"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4947), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d85a832-09ec-4caf-b355-42ddb0fd3304"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5053), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f43ff98-f513-4b1d-9f08-09c246e92cae"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4883), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f85148a-bed0-4235-af61-ed3149e4d02c"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5037), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70b2ea69-db5a-475d-8d80-ca63fd1b6f72"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4877), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72859789-b258-4c2a-a269-e6a3d787c12d"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5099), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("730f3855-6816-4dcd-9d38-f97317f9413e"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4869), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73810b6a-ce59-4751-af3d-f756bbe729f0"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5217), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75c5a492-845d-4625-96f4-8f5ff733a9b8"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5269), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7621fdbb-a4fb-48d9-a4c8-3af71564f022"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4907), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76bc4518-22b7-46e3-a1fe-13293e3539a9"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4880), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b07db82-54e7-46eb-aff2-156b9e7ce2de"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5292), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e650c11-3dc2-40a4-9581-0ca65b5f42fb"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4959), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f7bb51f-7c86-43e8-ac00-2f359f8eba88"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5262), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("801e12c3-7a73-4ae7-b5ee-298f87f84a86"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5202), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8054d581-78df-4ac6-8785-a2ea8177d219"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4931), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80b99441-fd5c-4f15-b78a-3af1600d9e33"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5151), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("826266fe-6941-48de-898b-be17ee1ba4d6"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4915), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8410c3aa-5cf5-41e7-bab3-d08c459cbf9e"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5109), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85c526e9-25a5-4716-ab30-a1040db382cc"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4835), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88fa52ef-f6f2-432a-84e8-188a4dda1d98"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5074), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89ff64d7-af19-41f6-ae0d-caf480633885"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5082), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a4500ed-003c-432a-b70f-12f3b660a9fb"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5193), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ab5d805-59d1-4247-bcec-cc082e966540"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4918), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c4c615f-5c5e-4a64-8f54-99649e7aef8b"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5239), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d645c1e-5899-4baa-ac9e-7b58035b876a"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5081), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e700f08-bc7c-4e42-8a72-d4dd88f73d7d"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5240), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8eb375fe-c807-4e16-bbe0-8e48779e0ab8"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5096), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f023a3d-2675-4072-b2cd-261b2e2f62b8"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4878), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("923e3daa-bb53-42f1-a93f-a24bf38cc7ae"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5055), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92daac51-35de-47fe-9781-ae4b47df99aa"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4889), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93d502ff-92bf-4357-8c84-0ec4abda7a82"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5247), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9403c60a-b937-4b4b-a0f5-1ce4edaa0f1a"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4916), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94335bbe-cb87-47d4-a5f4-59437d874845"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5047), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("943c406e-bdd8-4ca1-a760-eab661744377"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4984), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("953e549e-fd51-466c-ab7a-9a3213191069"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5059), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9837144c-d0ed-4ebb-b3d0-887a2c973dc4"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5111), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cffdb6b-2778-4ce6-a92a-5ef23a96dc79"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5180), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d5e212c-94b7-4c52-b3be-8260eea6fb6d"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4943), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9da49867-ebbd-487e-8a56-8cc7eec2b6a2"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5183), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a12e9690-eb3e-40a6-b943-83cd4bfef940"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5211), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a26e373b-d6c2-4605-a8fa-8e7e45537a8a"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5120), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a29a4b31-467b-4890-958e-0601d85ae1ed"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5160), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4a9f00c-08f1-42d8-afb6-c43cc6005bb2"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5206), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a534298e-05aa-44f9-8410-56ad92b01c71"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5175), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5393063-2f60-4b80-be4f-b7764f784f2c"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5224), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a65531e0-54d6-4e58-bbed-12a3baf77885"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5164), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6b44026-0aa2-4c6e-8db0-7f4d05176e1b"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5024), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6f10309-c313-467b-9015-fd66302b1217"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5220), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a78bd7bc-4e4a-4acb-8294-d9f3f451c53d"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5166), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aaf00ee9-025a-4586-a9db-ea3ac126f1f2"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5061), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab4401a3-6da5-4098-9d5d-a9b14051863c"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5148), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab56b01d-267c-486c-b64a-b818a8fdbf11"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5012), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad1fde9a-bc8a-4c7a-9bd0-822f0fc9d387"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5222), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae37e360-dcde-4bfb-92cd-5e7f03ffc8ee"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5221), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae8b22a4-9109-4a94-b2db-2cef736cd6e0"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5123), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae999853-d4b7-49bb-bcf5-bd304465021e"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5039), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b027ca5e-743e-4498-be88-a2988f573c24"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5103), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b05470f7-2b2c-428d-998c-3933ca6e1e8a"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4949), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2e656ce-38d0-47c5-8120-2eb2f0dff317"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5110), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3053af8-0be1-4f4b-bbc1-e6acc322e26c"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4948), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b327be46-5e81-4227-9e2d-99acfbf4e42f"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5035), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b33bdb18-9cb3-42f6-89c4-e778569a355a"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4886), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b512cc05-5e50-4a62-a274-199ba6c101f7"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4990), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5a4e759-840e-42c8-8dc7-3ebd62c07309"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5242), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6081911-908d-4fb9-8eea-c85e628cdfeb"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4966), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b750fa03-b3cf-4a6a-89a8-eff50b389f5b"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5134), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("baf3fcae-901d-4658-bbcb-df5a9ccc51f2"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5006), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd609212-2a6a-46c9-8b2e-3feafd1e736b"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5078), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be1330b5-e23f-438c-b265-d13f8d658637"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4955), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf353c59-3258-4b56-98ed-16484f387447"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5170), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2c522dd-f422-4490-9942-31adc9fef8e6"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5088), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3de629c-b56b-45ab-ac71-f3ed24931989"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5009), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4b31fcc-9102-4f61-81ec-bcd129f45a5c"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4905), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5dfbc72-6a7f-408a-b778-d094b85aa31c"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5027), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6fcbb7b-9934-45d3-8663-cb247506590b"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4994), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c83f591d-ded5-46ce-b526-66f4544f0379"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5159), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9bfcf24-ab49-40ac-a1db-b76a9e83d252"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5073), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca754c4c-9289-42b4-bdf4-1665c9c67ba6"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5125), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc6075c5-5712-4704-9b61-511784bc0551"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5054), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfbfe65c-2617-4afa-a447-1f01512e212f"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4939), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d04e7af7-b319-4f8d-abeb-213d79bf628f"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5026), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0fa88b8-1b27-4b12-aaf8-b117646c30f2"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5030), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1c5a63d-d74c-4379-a064-272ce29c3fa4"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5152), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d296786b-10db-4daa-ad67-c54bca321af8"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5291), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2d4019a-84a0-4725-83dc-44e435e40108"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5106), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d30b383f-9cd8-473b-86cb-c56c4466576c"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5014), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3670026-48c6-4eae-b302-321b001790b9"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5011), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d43aa2ad-ce92-426f-9ae1-b4289c115f87"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5156), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4db47ed-bd2f-41e4-870b-140f1f771509"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5167), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5663187-4c35-4a4c-8c32-40c1b12f9f3f"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4969), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d570e963-8493-400b-9484-c29839f80b55"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5122), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d630d84f-f29a-4c59-8204-57d52f943053"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4944), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6ecfb30-441b-477f-9d8f-b7d4c420314c"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4989), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8d35e7e-0730-45a9-ae52-a5bfa6068c31"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5177), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8dfe3f9-685f-4823-9a17-0acbea72d193"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4913), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da61a3b6-cf3a-48c8-9f4f-5874ec3c0a6b"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5181), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daec1906-6d28-49a2-b0ec-814535317e27"), "C", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5083), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc9e5f4a-395f-4b5a-949e-8dc0a79f9765"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5235), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dca77334-28b6-405f-9b40-97d6b8380acd"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5252), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de92f8a0-bd48-4499-92fb-5a8cd0faf394"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5234), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("defafafd-7526-4950-a7f7-83a24c77cb3e"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5260), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df99402c-82e3-40cd-878f-373c31f7980c"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4961), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dfd65c31-5379-43b1-be69-e6247cd18a02"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5003), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0d549a5-e34b-4f01-b99e-a544f1ee6b91"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5058), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0e346d6-8ef6-4421-8483-92975d3437d0"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5128), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e16ca5d6-3459-4362-981d-c406de83324a"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5076), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e33a6452-b18e-42b9-bf3b-cb4e559f52f1"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5238), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3e7f2a8-cf68-409c-8e6d-17e56d7863d2"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5273), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4d9327d-7751-473a-af53-b779054c4d43"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5155), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e63e85cb-3f49-46b4-ab3a-a91959f99a71"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4972), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7269b8a-ef03-4e32-8168-306cf6b3f4ea"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4975), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7e4ed17-4609-4753-abed-619415e82af3"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5001), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8232e5a-bf2b-4a5e-b7ac-57fee4471f43"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4935), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8c68902-ddd2-4ebd-a50c-f2418ba4e3fd"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5178), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9afcb80-cee9-4486-9109-fded6825efd9"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5157), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9bdc399-9800-46e7-9f2d-ed9c92e0f88c"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4953), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea754c2a-d676-4032-8034-25257d665d67"), "F", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5171), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea80e6b9-027a-4631-8ddd-2668adb7ac93"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5241), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee6c4c10-cf5b-4e6d-8eac-bd37bbb3e9e9"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4946), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef1efc4f-8b16-4859-b6b1-bac7e6482501"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5124), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f116b8e1-794e-486d-b8f4-83dc381b65bb"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5129), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f21b0f70-df1b-4322-9455-2fe538090e7c"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5117), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f230dcbf-0377-41ee-a7a9-72d547d9eade"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4988), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2e761c7-b68e-4eb1-8530-73ca0a3626f8"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5133), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f38ef75b-b1b8-4e4e-ba43-173c696bea61"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4928), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f41346fa-3551-44af-99d7-af7f6139addb"), "J", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5280), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f62cbc24-2267-4f0d-a5e0-6666dfc19667"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4986), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f65918a9-0744-45f9-ae03-d490b9d801f5"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4917), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f761da7b-7a2d-4eaa-93b6-14ba991a10ae"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5045), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7b1ded7-41ac-4875-ba17-ce39f6a1b35a"), "E", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4875), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8c9e05f-ef96-480f-b63f-1798ad068960"), "B", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5284), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd11c4c0-dc02-4217-ae72-9b4ff9700460"), "D", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4911), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd57a341-d589-44f7-8ae0-28bd2d787422"), "G", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(4964), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fec6b54f-dcf3-4d44-9ab9-eadb1d34bdbb"), "I", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5295), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff737625-78a8-4ca3-a203-38048a433621"), "H", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5226), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffd621ce-1464-4ff1-898f-226516b29921"), "A", null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5250), false, null, null, null, null, new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("4e2dd558-a4f4-4030-9a64-7d56a42c2e0c"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5576), new DateTime(2024, 12, 27, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5583), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 26, 2, 57, 33, 734, DateTimeKind.Local).AddTicks(5579) },
                    { new Guid("5827ef65-c947-49b3-863f-a105efb98afc"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5587), new DateTime(2024, 12, 28, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5590), false, null, null, null, null, new Guid("220e6162-4820-4704-b8ef-6d8b02ba8bb7"), new Guid("5d694d97-00c8-4732-92b0-5ec2035fa69e"), 1, new DateTime(2024, 12, 26, 2, 58, 33, 734, DateTimeKind.Local).AddTicks(5589) }
                });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0f4dfaeb-8c90-4e9a-8c2f-0a18687ae3d4"), new Guid("c2d93f0b-bd11-4817-a706-2ae06e363290"), null, new DateTime(2024, 12, 24, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5862), false, null, null, null, null, 1 },
                    { new Guid("26d306a7-49d4-439f-9ed6-3b2f8c0524b7"), new Guid("b83ca163-98b6-45f0-a4a9-c7ac48eec087"), null, new DateTime(2024, 12, 25, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5866), false, null, null, null, null, 3 },
                    { new Guid("4c736a16-b05b-4680-85c3-c0c7520b0295"), new Guid("2e83376c-91a6-4b9f-b3b6-fb209782ed2a"), null, new DateTime(2024, 12, 26, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5865), false, null, null, null, null, 2 },
                    { new Guid("88c726c7-72b3-4021-b506-397d44d7bf58"), new Guid("22e7dbc9-f7dd-40dc-a705-4032ef6dce8b"), null, new DateTime(2024, 12, 24, 2, 56, 33, 734, DateTimeKind.Local).AddTicks(5868), false, null, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("56d7e7e1-869c-4bd6-967d-d79b2f4f471f"), new Guid("0f4dfaeb-8c90-4e9a-8c2f-0a18687ae3d4"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5829), false, null, null, null, null, new Guid("220e6162-4820-4704-b8ef-6d8b02ba8bb7"), 2100000m, new Guid("2d88f119-1740-4eef-93c3-e6f22d9152e6"), new Guid("730f3855-6816-4dcd-9d38-f97317f9413e"), 2 },
                    { new Guid("b0b45c46-5db1-4ce6-867a-cad4d7bcb6b0"), new Guid("0f4dfaeb-8c90-4e9a-8c2f-0a18687ae3d4"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5821), false, null, null, null, null, new Guid("3868e69a-bc4e-4c52-96c8-0764bd8f7ba9"), 100000m, new Guid("b9dfe2fb-3bc1-42fe-a67c-678543a85764"), new Guid("85c526e9-25a5-4716-ab30-a1040db382cc"), 2 },
                    { new Guid("e0bdf65a-a237-498e-a7d5-6e14c10bd86a"), new Guid("0f4dfaeb-8c90-4e9a-8c2f-0a18687ae3d4"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5831), false, null, null, null, null, new Guid("64a38d38-a884-4c37-bfa0-f3299171ea06"), 3100000m, new Guid("9eb56519-b346-49fd-9c32-fea8e0fcef91"), new Guid("26a46afd-c597-40c3-8a44-9f8e3fe6733f"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("0e1265d5-93e5-4591-a7a0-b868da4416ec"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5684), false, null, null, null, null, 50000m, new Guid("b9dfe2fb-3bc1-42fe-a67c-678543a85764"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("f01ee0d4-7f7e-47ce-825d-22d3783ecbfa"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("b17fff9a-48d3-47ea-b49d-92e0fa41d861"), null, new DateTime(2024, 12, 25, 19, 56, 33, 734, DateTimeKind.Utc).AddTicks(5690), false, null, null, null, null, 60000m, new Guid("2d88f119-1740-4eef-93c3-e6f22d9152e6"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("22fab400-ed7b-4019-982c-1d8a7af86d92"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
