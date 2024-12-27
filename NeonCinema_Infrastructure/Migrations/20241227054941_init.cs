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
                    { new Guid("389febca-895e-444c-9c09-3868cbcbd1b4"), "phonghhhhh", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3155), false, null, null, null, null, "hotdot", new Guid("181efcbc-2c26-4aa0-9cc7-1a255f8ece00"), null, "mua tại quầy" },
                    { new Guid("5fe6d3c8-69bc-4f54-bbee-be6e9e13023f"), "hgdsad", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3161), false, null, null, null, null, "hotdsot", new Guid("81ce24ed-fc0e-4a76-9aef-35d8c8f5062b"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2122), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("c749faa0-375e-4724-8375-fb04c003634a"), "11:00 PM", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2126), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("286a2641-7314-4b9c-9bd5-2b2adebd497b"), "Việt Nam" },
                    { new Guid("2d1c56fb-e96f-4415-ac44-9c95f431ca82"), "Hàn Quốc" },
                    { new Guid("59a86c74-bf22-4ff0-8014-c4b925f4df8c"), "Vương Quốc Anh" },
                    { new Guid("6781020c-ab3a-4c15-9457-d52ef6c5e656"), "Ấn Độ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("92c42f1b-4d66-4788-b893-02eae446e68e"), "Úc" },
                    { new Guid("ab99d5e6-2b58-4f2e-99c8-0057abc73321"), "Trung Quốc" },
                    { new Guid("af696059-a849-4b38-8c5f-6be25f00f1cb"), "Mỹ" },
                    { new Guid("d5d848f4-1071-4d86-a99f-e66bee35aef4"), "Hồng Kông" },
                    { new Guid("df93d131-1413-433b-8a4a-2840711766d8"), "Pháp" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("49c74110-f791-4ab8-9b14-f18b315f0193"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1997), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("53f4b14e-85f2-48cc-9799-b53afe278b13"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1983), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1973), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("93d3865c-e54c-49f9-9edb-f1894e80a078"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1993), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("992551d6-dbfa-4053-b19f-8468c53a59c9"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1994), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1986), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("d6fb3189-9170-443b-b5f3-bb61cee3000f"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1984), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("e5f02273-be96-4ded-bb57-6fd4b30d84cd"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1980), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("e99407e3-e852-44e3-8059-9d525ca18c55"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1991), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f248f0f9-7d8f-43bb-b0fb-b417ab7ec701"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1988), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("0d2eed4f-4c68-438f-8980-a5286908dd27"), "Combo 3", null, new DateTime(2024, 12, 25, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3136), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("7efe5b22-575c-40e7-8cf0-b0ec8b4911d5"), "Combo 1", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3128), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("eb5c7656-0376-4a66-b51b-fcf267405797"), "Combo 2", null, new DateTime(2024, 12, 26, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3133), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("fc689aa6-8189-4102-ace8-20cfa9b13a14"), "Combo 4", null, new DateTime(2024, 12, 24, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3138), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("14896d19-2774-4818-aa2a-6f77ff6b3b51"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2033), false, null, null, "Tâm lý", null, null },
                    { new Guid("3c31dd32-c5bf-444b-8618-625e252c8c7d"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2026), false, null, null, "Hoạt hình", null, null },
                    { new Guid("55b984f2-fbda-49b2-bbce-dca48ec99af7"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2032), false, null, null, "Lãng mạn", null, null },
                    { new Guid("56850bc4-ede9-4f3c-ad8e-01ce3ce8f727"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2031), false, null, null, "Hài hước", null, null },
                    { new Guid("6652a32f-5577-4829-b925-f416ff9ec309"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2022), false, null, null, "Tình cảm", null, null },
                    { new Guid("788aab39-a05a-4a90-953c-3c5fd7b4d4b0"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2034), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2018), false, null, null, "Kịch tính", null, null },
                    { new Guid("91bac78b-df7d-4929-9184-bf6684a18249"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2029), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("a784efbd-0508-4bd7-8016-56138de91740"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2024), false, null, null, "Hành động", null, null },
                    { new Guid("ed8742b8-b8d6-443a-9477-578ad80a6bfb"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2025), false, null, null, "Kinh dị", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0090e344-5186-4b08-9501-ef5eb72e759e"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1929), false, null, null, "USA", null, null },
                    { new Guid("823a27d7-eb57-4747-bfe8-c46960441ce7"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1930), false, null, null, "Korea", null, null },
                    { new Guid("829c7209-c2b0-47c6-939f-49959bfe34ba"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1927), false, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1917), false, null, null, "EN", null, null },
                    { new Guid("a1f7c6d7-2513-428f-b10b-cbdba052a3bc"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1922), false, null, null, "VIE", null, null },
                    { new Guid("e98020b8-7551-46e6-a8b6-2a7a96faf78e"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1924), false, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1127), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(1132), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1012), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1033), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1031), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2094), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2097), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2090), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("032bc1df-0835-41ae-a4b5-602f01087d4d"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("189ec1dc-ec4a-4df6-b099-908a76c3b826"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("1bf5bf4d-f77d-41a6-be7b-0a2a8a7a068e"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("6075cfef-d97c-4a6d-b42b-70bb1ec267b9"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("80d3ec49-73bf-441c-9130-c54508c110d8"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("a6d35a33-4bed-4597-b7e2-942367f6d029"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("c0d3db14-b522-4f05-b1d0-b8f672ff1eee"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("c7c7b271-eed6-4520-95eb-f0c6eaa091dd"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("d48f03ff-89b0-4074-b929-9b5d22edac16"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("e86f9cd3-90f0-4cf0-ae57-ef1fd6a9eab0"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3064), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("064868a6-e1f6-43a3-bc62-d84ab3d28c8d"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2902), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 100, new Guid("55b984f2-fbda-49b2-bbce-dca48ec99af7"), "chayngaydi.jpg", new Guid("a1f7c6d7-2513-428f-b10b-cbdba052a3bc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("0bc372d3-6872-4636-84d9-cbfc11f0627c"), 16, new Guid("af696059-a849-4b38-8c5f-6be25f00f1cb"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2871), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("a784efbd-0508-4bd7-8016-56138de91740"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("2cbb4482-165b-4b22-95d4-605b0bf0b970"), 18, new Guid("af696059-a849-4b38-8c5f-6be25f00f1cb"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2939), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 127, new Guid("a784efbd-0508-4bd7-8016-56138de91740"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("347cd555-2d94-4329-a9af-eec0e8e0c8d2"), 13, new Guid("92c42f1b-4d66-4788-b893-02eae446e68e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2918), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 123, new Guid("56850bc4-ede9-4f3c-ad8e-01ce3ce8f727"), "kinhvanhoa.jpg", new Guid("0090e344-5186-4b08-9501-ef5eb72e759e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("8915eae2-10b5-473b-a299-d6762a888768"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2886), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("53f4b14e-85f2-48cc-9799-b53afe278b13"), 110, new Guid("55b984f2-fbda-49b2-bbce-dca48ec99af7"), "tretraukhongduaduocdau.jpg", new Guid("a1f7c6d7-2513-428f-b10b-cbdba052a3bc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("9ea36ad0-79c7-401c-b847-4bab97b6948c"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2857), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 99, new Guid("56850bc4-ede9-4f3c-ad8e-01ce3ce8f727"), "tetamhon.jpg", new Guid("a1f7c6d7-2513-428f-b10b-cbdba052a3bc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("9f35ad92-66f0-4ccc-83ca-b1c29ee9d693"), 13, new Guid("af696059-a849-4b38-8c5f-6be25f00f1cb"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2925), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 118, new Guid("14896d19-2774-4818-aa2a-6f77ff6b3b51"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("aa0220ae-b8dd-4845-8036-be98f8f0f65c"), 18, new Guid("df93d131-1413-433b-8a4a-2840711766d8"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2833), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("e5f02273-be96-4ded-bb57-6fd4b30d84cd"), 81, new Guid("56850bc4-ede9-4f3c-ad8e-01ce3ce8f727"), "xich.jpg", new Guid("823a27d7-eb57-4747-bfe8-c46960441ce7"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("b42fbb9f-3a88-4f8b-a85a-44313dbf1d03"), 13, new Guid("df93d131-1413-433b-8a4a-2840711766d8"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2909), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 113, new Guid("55b984f2-fbda-49b2-bbce-dca48ec99af7"), "cuoixuyenbiengioi.jpg", new Guid("823a27d7-eb57-4747-bfe8-c46960441ce7"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("c45bc292-f29d-48a1-a685-20fbf67a0fdf"), 13, new Guid("92c42f1b-4d66-4788-b893-02eae446e68e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2878), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("e5f02273-be96-4ded-bb57-6fd4b30d84cd"), 120, new Guid("55b984f2-fbda-49b2-bbce-dca48ec99af7"), "botubaothu.jpg", new Guid("0090e344-5186-4b08-9501-ef5eb72e759e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("d954349f-f096-4808-805d-4dddefb19e99"), 16, new Guid("df93d131-1413-433b-8a4a-2840711766d8"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2850), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("d6fb3189-9170-443b-b5f3-bb61cee3000f"), 109, new Guid("ed8742b8-b8d6-443a-9477-578ad80a6bfb"), "yeuem.jpg", new Guid("823a27d7-eb57-4747-bfe8-c46960441ce7"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("da8b5db6-e41b-4580-8a8e-b65a871859de"), 15, new Guid("df93d131-1413-433b-8a4a-2840711766d8"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2894), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("d6fb3189-9170-443b-b5f3-bb61cee3000f"), 110, new Guid("91bac78b-df7d-4929-9184-bf6684a18249"), "chuyennhabanh.png", new Guid("823a27d7-eb57-4747-bfe8-c46960441ce7"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), 16, new Guid("df93d131-1413-433b-8a4a-2840711766d8"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2824), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("56850bc4-ede9-4f3c-ad8e-01ce3ce8f727"), "ngaiquy.jpg", new Guid("823a27d7-eb57-4747-bfe8-c46960441ce7"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("f8f4322c-6e69-40b9-98e5-0699bc9a1827"), 13, new Guid("ab99d5e6-2b58-4f2e-99c8-0057abc73321"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2932), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("a00d9bbf-1400-422c-baf5-bc1edae9ece6"), 134, new Guid("a784efbd-0508-4bd7-8016-56138de91740"), "cuocchien.jpg", new Guid("e98020b8-7551-46e6-a8b6-2a7a96faf78e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("fbd7dae3-0208-43fe-a99d-9a0b725cd7d9"), 13, new Guid("92c42f1b-4d66-4788-b893-02eae446e68e"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2840), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("53f4b14e-85f2-48cc-9799-b53afe278b13"), 113, new Guid("91bac78b-df7d-4929-9184-bf6684a18249"), "congtubaclieu.jpg", new Guid("0090e344-5186-4b08-9501-ef5eb72e759e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2162), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2156), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("031cbcfa-d487-4dcf-b154-7c27412a0403"), "Hà Nội", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1575), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1eb3d9a6-b115-4d9c-80eb-0990f4768e2d"), "Nghệ An", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1709), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("435249cd-08fa-47bb-82b5-394145cc30a5"), "Thái Bình", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1758), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6012ec69-c0dd-48fa-850d-5ee0dfa0f4ad"), "Hưng Yên", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1779), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("62c1d402-b928-4dd5-b757-5889501d1b07"), "Hà Nội", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1187), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6cd88546-6087-4675-bac7-81589ff7747d"), "Đà Nẵng", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1634), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("70b3bd20-3610-43da-840f-5735c5af9032"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1658), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9d7d4e27-e9b5-4297-b47e-34700293a3ec"), "Nam Định", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1823), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cd022e90-5f09-4735-ab7e-3411526b2587"), "Hà Nội", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1868), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("e0bad042-4a84-4f59-97fd-6d4b19d539c9"), "Hải Phòng", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1607), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f977876f-6b42-4202-9113-16256f551537"), "Quảng Ninh", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1847), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fe5c78a1-81b7-4774-a221-502c50524129"), "Bắc Ninh", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(1731), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PromotionID", "Status", "Surcharge", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("09bfae54-7911-4b94-96ba-a15b49b75b06"), null, "BILL004", null, new DateTime(2024, 12, 25, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3206), false, null, null, null, null, null, 2, null, null, 200000m, new Guid("6cd88546-6087-4675-bac7-81589ff7747d") },
                    { new Guid("2974c4e3-963c-4126-947a-beaa43e328ed"), null, "BILL010", null, new DateTime(2024, 12, 21, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3224), false, null, null, null, null, null, 2, null, null, 700000m, new Guid("9d7d4e27-e9b5-4297-b47e-34700293a3ec") },
                    { new Guid("50727b4e-6279-4779-b191-f78274fcf970"), null, "BILL007", null, new DateTime(2024, 12, 22, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3216), false, null, null, null, null, null, 1, null, null, 800000m, new Guid("fe5c78a1-81b7-4774-a221-502c50524129") },
                    { new Guid("5ea09529-9395-4191-a841-8e175323b05a"), null, "BILL001", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3182), false, null, null, null, null, null, 2, null, null, 500000m, new Guid("62c1d402-b928-4dd5-b757-5889501d1b07") },
                    { new Guid("71cfa33f-f514-46e7-a80e-50fc1a83e5ba"), null, "BILL005", null, new DateTime(2024, 12, 24, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3208), false, null, null, null, null, null, 2, null, null, 250000m, new Guid("70b3bd20-3610-43da-840f-5735c5af9032") },
                    { new Guid("81918103-998f-4a50-b432-81653e7aa06f"), null, "BILL006", null, new DateTime(2024, 12, 23, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3211), false, null, null, null, null, null, 2, null, null, 600000m, new Guid("1eb3d9a6-b115-4d9c-80eb-0990f4768e2d") },
                    { new Guid("932ed95d-798d-4471-a3a0-2acb27e1077a"), null, "BILL003", null, new DateTime(2024, 12, 26, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3201), false, null, null, null, null, null, 3, null, null, 150000m, new Guid("e0bad042-4a84-4f59-97fd-6d4b19d539c9") },
                    { new Guid("ae44ba7d-a8e4-40b5-b28a-df8de0cf1e50"), null, "BILL009", null, new DateTime(2024, 12, 19, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3222), false, null, null, null, null, null, 0, null, null, 350000m, new Guid("6012ec69-c0dd-48fa-850d-5ee0dfa0f4ad") },
                    { new Guid("c2ad5734-3510-4ec9-9491-224b17e8eff3"), null, "BILL008", null, new DateTime(2024, 12, 17, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3219), false, null, null, null, null, null, 2, null, null, 450000m, new Guid("435249cd-08fa-47bb-82b5-394145cc30a5") },
                    { new Guid("ddcaf43c-3e03-4f28-8f8d-6e2442406b07"), null, "BILL002", null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3199), false, null, null, null, null, null, 2, null, null, 300000m, new Guid("031cbcfa-d487-4dcf-b154-7c27412a0403") },
                    { new Guid("eb4b38c2-22bb-48ce-a77c-368d5caed7d5"), null, "BILL0122", null, new DateTime(2024, 12, 23, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3214), false, null, null, null, null, null, 2, null, null, 680000m, new Guid("1eb3d9a6-b115-4d9c-80eb-0990f4768e2d") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("58727cc2-740e-46cf-b6b4-f3bd5da23b75"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3317), false, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3320), 1, new Guid("62c1d402-b928-4dd5-b757-5889501d1b07") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("33388472-f7bc-4327-b9a2-48ea3ef6802c"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3020), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 4, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3019), new Guid("189ec1dc-ec4a-4df6-b099-908a76c3b826"), null, 0 },
                    { new Guid("3fcc2801-e2f5-419b-b2a5-b1eae03d60a6"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3026), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3025), new Guid("80d3ec49-73bf-441c-9130-c54508c110d8"), null, 0 },
                    { new Guid("85f479a2-2c1e-4ddf-9ac9-bed47a36e62b"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3031), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3029), new Guid("d48f03ff-89b0-4074-b929-9b5d22edac16"), null, 0 },
                    { new Guid("8a5e64a6-5f24-402d-aa7f-be44a8a78a33"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3034), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3033), new Guid("e86f9cd3-90f0-4cf0-ae57-ef1fd6a9eab0"), null, 0 },
                    { new Guid("ae61e4b3-4654-45bf-b299-8780addb9e2b"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3014), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 5, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3013), new Guid("c0d3db14-b522-4f05-b1d0-b8f672ff1eee"), null, 0 },
                    { new Guid("b09966fa-d550-4d86-adb9-52473efd45cb"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3009), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 6, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3007), new Guid("c7c7b271-eed6-4520-95eb-f0c6eaa091dd"), null, 0 },
                    { new Guid("fdc48966-4e48-4de6-977a-ce01f9401975"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3023), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3022), new Guid("032bc1df-0835-41ae-a4b5-602f01087d4d"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00d09246-d412-46fa-8b3a-456d884891a1"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2526), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("01f51e05-ca2e-4dd4-b32f-fd320beaafd6"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2430), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0259655b-6870-4f80-bb8f-d43697a9dad0"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2565), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("031f25b5-fc3d-441f-b323-024b70e7067f"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2319), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03831d95-6b84-49fd-a595-226274415c33"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2356), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04275457-7fd4-4904-b1e0-99d30a284af5"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2429), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("050256ea-f5ac-47da-9d1f-99c8a5338a2c"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2538), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("081821f8-114b-4f18-802d-869fc00635ba"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2644), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("093d9c3a-2a66-4c2b-9485-db338c62ad85"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2588), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ad00299-781d-40a5-8d61-cf6dc78613f9"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2310), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ce7fd48-3135-4b28-ab6b-bba6b7ba9bcb"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2346), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e948f8e-e341-4679-b45d-fa87a03b2071"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2531), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f00e7db-8782-4a51-9c0a-75e615bc8326"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2285), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("106b3862-2063-4425-814a-53ba4f7a6344"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2620), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1125413b-962d-49a7-ac83-383a65e0ceda"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2524), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("141b14a3-abcb-46de-9e8c-5ffcff18c62e"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2259), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14997888-d91a-4049-af37-22074d390712"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2570), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("156c0c82-e134-49ff-9d0d-65d9c3b90dd5"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2622), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("159ea6c2-c72e-4f73-af2e-edb17f1e3b9e"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2420), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1673bdcc-b1f9-4295-9b72-9889bb92fb55"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2548), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1674c120-38ef-4fb2-82c1-71c387cc4435"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2547), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16c4efb5-5912-478d-b2ee-8da46328e4aa"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2358), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18bb5c06-e668-4653-b3d6-0747210387ba"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2476), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ae1cb5e-148f-4d4a-a4eb-41ab364a5bcf"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2380), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b46dc79-1c52-42ce-bc1c-21e0543d1b25"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2303), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b683113-37c9-4bb6-9ad5-6a416e7087b2"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2461), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c15bfe0-e37b-495c-8763-d52a93be7853"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2304), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1caa0e44-77d3-458e-893f-a25d8d6e3803"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2611), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d1c2940-49fd-4c5d-b6c4-594e4b249e02"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2502), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d692f7f-5489-4f3a-8958-8c2677ba2421"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2330), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d81364b-a62d-40e3-97f5-bcf52476be55"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2362), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ec0bbe8-796d-4136-a676-976c024413a6"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2227), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1eed8ba0-f381-4e2f-88ed-220f5b8831ed"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2334), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fd37588-28df-4348-8ab1-610281cf99fe"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2349), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21f2234e-c598-4dab-803b-1f8b35fe813f"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2662), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("232e35a9-548f-4cd1-96ff-e649898e8310"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2489), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("243a6b55-3a11-4ffb-b233-52fe4733793f"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2250), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24fbfa2d-99ba-4a58-b681-c342a5cd6894"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2618), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25251242-a617-48ad-8d83-9646ba84319f"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2580), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("266b0776-21b2-48c5-8dde-ce7559f4f501"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2383), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2747c686-06ff-4dd7-8134-964b2c2ea88b"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2499), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("275e236d-cb5d-41da-9c96-ebc3bfc8dc86"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2492), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29baf245-6192-45b3-852c-c5be2f431b12"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2275), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2aaad53e-bdf2-4eaf-9792-5dad2059f293"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2503), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c17d460-05eb-4859-a8b5-36e16a93915e"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2309), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d4dff1e-a003-47ad-9690-be588cb95da1"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2456), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e8f8320-776d-4278-b0fc-8e8b1c3f3b92"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2403), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ee9b66f-0cc8-4049-9017-16c1c4c1ade1"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2654), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30aca022-8d58-4a9c-a3ea-4f70fdea4405"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2509), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30bb7d44-913d-40fa-b524-1e323d8cae80"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2560), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30cd57f5-3a7b-4ba4-b0e6-e30cb3227060"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2411), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("356e3768-1362-4901-8f20-df95e8b63b1e"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2528), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3577ffeb-4e9a-46e6-b620-033b064a706c"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2593), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35e51d8d-cbc2-4a1c-9b57-e88494ee20cb"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2551), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("362c6476-e428-4cb7-8195-dc713d85f3bb"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2457), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36d5da02-e00a-4671-8e43-04e60e833a38"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2578), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38a4afad-4f24-4bb7-87a5-ee8c6bd46c77"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2337), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3915c99d-dd80-4c0c-a229-af4b3b92efaa"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2277), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39391016-b08d-4b65-b5e7-3306a309805a"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2357), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a9437fa-04e2-4005-9fdc-b4fc7c62fbf8"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2568), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b085cb7-765d-42d0-a7db-e0c8ffa71c5e"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2485), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b0a374e-c193-481a-9dc9-c92abbc2ae0a"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2488), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c4f3e76-aec0-41a7-ada2-4e44ad017af8"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2563), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d04b4cb-bd0a-430d-9cb6-3e61d5166032"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2306), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d99bcf8-2e22-4124-8447-c6a10f16fe2d"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2666), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e6f8d5d-5bd7-464f-9175-466ffa078e4a"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2541), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f093041-d10b-4188-9797-31e2473b2830"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2398), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("406da8f6-58bd-4f14-b2c5-962c0641862e"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2477), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40df3848-30da-437c-a549-72a56ddda202"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2399), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("419883a9-3e78-48fb-b7bb-0691070242f4"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2444), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("41e30454-8abf-4ea6-a8a9-e443a9358607"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2271), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("444ffdea-39e4-48eb-9aba-61b91d6d7424"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2407), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("446ac684-7206-4871-a25e-b2b18b199704"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2535), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("457d5b26-2dad-468d-b685-0382d82541bd"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2602), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4620d6d2-bd64-48c7-923e-cc6813b241e9"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2353), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4865f96f-4f24-4d14-82d6-e6b574177b8e"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2333), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48b3b757-d7aa-486c-8234-1b4aed26c21f"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2316), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4905aaa5-d5e0-4f35-ab89-813bea0f9ce1"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2673), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4909621f-1c18-43f6-bb5a-f42f97764d79"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2232), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a307e51-ecca-49da-a22b-1f075d64b6d7"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2521), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a7dbc3d-c945-4435-95e9-216a1401b36d"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2575), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b78968d-0553-48fc-ac46-974715c48775"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2419), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4be8cc9b-9af2-4ec7-8fd5-8caef5cab13f"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2656), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c2ada5a-227b-4e70-8523-4848eaef6393"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2228), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d6b0aa5-cad2-4529-9ef6-3ee27e18c4d1"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2501), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4de79027-f8ef-4b15-8352-a5c4ee515d6b"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2592), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e49c5b3-0c76-440b-941a-b92754be5141"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2643), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f528842-61a8-400e-b2ad-85981df61e66"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2350), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f630405-11e4-4af5-83b4-4b1aa9b926b7"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2624), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51cec359-3e3c-450b-bea3-a358fdf750c6"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2540), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5263c3de-03a5-46be-b4c6-c7a609b68971"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2387), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("536fc281-c18a-46d1-953c-e004c8c6a566"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2289), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("544b1e32-64d8-4f17-a00c-3096412b0d04"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2448), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55e9b823-15dc-424b-9b33-4b0a8c67d24f"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2463), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("562949d9-3326-4e0b-8b33-021a709e5ed1"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2553), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("566db507-1c84-4b62-96eb-e19fa34db503"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2634), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("568be992-3eb3-4c69-bda4-04809376afb7"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2664), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56ca3338-9f33-4498-9d12-982c37a2d9bc"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2590), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56eab80f-d55e-4234-a472-8ab7c7ab47bb"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2497), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57386429-0718-465b-a7dc-ff163904c6ca"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2244), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("579bb771-342d-4156-8bb9-c548dee7a193"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2406), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57aeb60e-7ff3-441d-8dd6-47d33576b106"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2475), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("583da758-2c58-420c-b092-6d4c23f94bc3"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2246), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5953c7fa-5bff-4e0d-802c-f24578a87e6e"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2287), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e1d8616-5a75-4463-ade0-6c5c46afbd3b"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2667), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ef43b4d-dca8-4fe6-a352-d1b23df9577c"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2262), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60c7a49f-475a-4795-8055-dd3d258d373c"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2651), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6266dd9b-60c1-4f9d-b3e1-d0fecd59d6c5"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2332), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("631895c0-1f90-4f18-8a82-5a5053429d61"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2498), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6397e20b-87be-4590-a2c6-9088580c9bcc"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2422), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63a19fc2-ed1b-46d0-b154-5b979c946101"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2478), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65474dbc-4448-4400-8612-4c21332d928f"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2230), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6588e238-b98a-4ee0-ad7c-2a0efb724b18"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2507), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("668ca0e6-fdc0-4b90-a7f5-aa5c4550053b"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2402), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66f80c56-6ac1-487f-bce1-61194518d125"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2274), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6715b607-3d9c-4373-a920-1e19f05dfc0c"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2559), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6798227d-3aa2-47c1-9223-c14f50e7983c"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2313), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("679caded-aa6b-40eb-81c8-ddd8aa99775d"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2508), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67be0a58-72bd-49e1-888d-ddf2a7c1f06b"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2453), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ab5bf43-c580-45a4-803b-d17c39937cdb"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2581), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6af72bdb-c3b2-4ed5-b46d-5fcb3d08c611"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2361), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6cf31ee1-cf26-4404-be9c-0e0f3b8b257b"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2621), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e0118eb-1cd8-4ffa-8607-7b6aad4b330b"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2348), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f350697-ac51-4cb2-8357-69365bf5ad8f"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2628), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("705a4ab9-9f99-43ee-8084-705bf808d415"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2469), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("711905cb-7ef9-43e9-8c18-2eee7e589438"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2487), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71a86841-b207-4a88-8e7d-53cc29842a42"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2318), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("721d584b-bf39-48bf-a0f6-b26253fca1c9"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2608), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72650b42-34cd-4fff-ae74-544478618e41"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2307), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73724623-16e3-4ab6-9878-5e36dddc74b3"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2595), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("745521af-35e7-48c9-a13e-754601b498ba"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2655), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75255136-bc0a-431d-9cdf-64fae0d820c2"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2397), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75fcaccb-a4aa-4077-bfee-1cb975237561"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2585), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76a9166c-7568-4299-963f-2ac70db045c5"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2345), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78d81610-4d8a-4beb-9c73-1c6c5041a09d"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2413), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a865ace-b82b-4567-98ef-a38cba4dd8a4"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2242), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cebed83-1bfa-4192-a2b5-3d53c4c2613a"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2577), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e938e80-a5a2-4df9-8424-d450dd0486a4"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2572), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8040d4c3-5788-4620-a567-f8b054c677e5"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2260), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("819dc4c6-f8bc-408c-9f8d-c39054ebdcc9"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2525), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81b6ea91-512d-47fd-a857-249ed0963f60"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2445), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("831510ee-3ae1-4405-9f6d-6aebf9679f47"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2650), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("857d2a07-b6de-4410-93c8-4b806badd406"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2564), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("871fdbde-f774-417c-bd72-bf659606df06"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2325), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("876c086a-eadb-477e-b81f-22df7ba685f2"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2288), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8807adf3-5940-4e94-8a4d-52c70dbc0f57"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2278), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("887dfc45-1c73-4ab0-b7ee-8d41e0e90c40"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2668), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88c31676-d42d-4ce9-9260-cd66316e603c"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2582), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8afec533-ba54-4b3c-92c2-808da396dff9"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2459), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c0313cc-3c68-4311-9a8d-7be2954e7f7c"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2601), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c9335cf-79d9-4bf3-9553-6797a2c3e5ce"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2641), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e8338a7-c113-4d4e-b24a-f6206a9ed16f"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2266), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("905be6a6-c5b4-40d5-87d3-bb4331c3b585"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2224), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90a97406-7072-4551-9e2d-1e0c9628cd8f"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2462), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9107c6c6-2cf9-4a07-9484-3f2556fdf766"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2589), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92a731f1-b3c4-47d8-bd46-8840f249c295"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2322), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94d95ccd-8509-4c5f-9707-46667a57750b"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2235), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("954f20d5-0be7-4ff1-b2a5-52bb72c32852"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2270), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96510355-871e-444c-ac95-c4a57e9f349d"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2615), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9692cf96-d183-49e8-9a20-4d564d0091b0"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2632), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96b3af42-632b-461c-b958-33c8a79bcd46"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2607), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97558827-1431-47f1-bb0b-54937b35a6c2"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2493), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("978ea2b9-7c8c-42d1-84df-66472b45313b"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2241), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("979459c0-a480-4013-bd7d-b6694be4b633"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2264), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9964b5da-b1e5-4058-ab2d-e31d9107e8d4"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2633), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a337a7b-7d4e-4bd9-92fd-ffa668695fb6"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2671), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9aacdb5d-a8c8-4d54-af65-4f67953e6b1e"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2511), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9abfc6bb-3404-4740-ab1d-db24e3ad9bb3"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2496), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b7d27f7-3235-467c-add7-e9d838e096d8"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2363), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c90f48c-9571-421e-90ce-3cfa886d6235"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2410), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cc39802-e7fc-4420-bac8-e30c7c9bb795"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2433), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d21aecd-465d-41bf-abef-07709080424b"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2647), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9df90e0f-5a45-49f4-a4c7-072553f11645"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2426), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ff2a1ca-82c7-4c51-a66a-737e7339729d"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2267), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a129f525-5ba1-43bb-9d00-151398d03fbd"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2549), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a17a515a-83f7-4d3d-86d1-9f85f2f550a9"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2427), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1d0d9e3-3ae0-49b4-90b6-59c64e1f48dc"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2491), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1e8fe11-c67f-479f-80dc-28c75e01c0f3"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2529), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4830008-2571-462b-93eb-e1fc239d8027"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2234), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5b344c1-9e46-463c-8d40-50303011fe06"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2626), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5b3d3e7-905e-4ec0-a55c-304eed75a1c2"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2504), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a603c862-7b9a-43b8-98b0-ef13b198fd0c"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2532), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aae78712-419a-40f1-86df-9a81dc52feb2"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2635), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab33418f-e94a-41e5-8a99-991575a19bfe"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2351), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("abe5d3b3-1244-4a2d-80a2-1dbde353ded2"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2384), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac722c82-3571-469c-9623-d8e3b5f4f8e9"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2284), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac9d1ece-b452-448a-8367-bca929386c4c"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2458), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("adef70a0-2d27-4b79-a867-6c5d7d1bc603"), "C", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2282), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af20e12d-e735-47ef-9f8d-b7588126e9ec"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2652), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b09d1443-c7d5-4706-bdd3-a2d82da45153"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2536), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3d934ce-521e-4932-8529-c423dd6835d6"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2321), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b82546d2-51fb-4233-bd92-5290a2821865"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2301), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b88cc085-fbc6-4862-b74a-87fac9ed646b"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2609), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("badc41af-9625-407e-aee0-efba3e6872bf"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2388), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bae811dd-92c8-4f19-81cc-db496ac003ad"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2359), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc066499-c49c-46d0-a3e6-e2b15d6159f0"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2452), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be07a901-a4d9-4392-9456-4b830ed09a93"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2630), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bff52839-a164-4128-ba91-ab145f4ad59a"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2530), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c00a3ebe-0d2f-4a49-b412-4d78f6e52b19"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2539), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c29dd220-1edf-4ea8-8d7b-9c90e91184b7"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2659), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c42c3c2e-fbe1-49fd-bcb7-976579e4ee4d"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2441), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7599229-fa8c-4e18-8fe7-69ea1277aeb7"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2649), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7c73115-c073-49c3-92e9-aa77b106f9dd"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2279), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb4bd913-07e7-42b4-abb5-17b2d5577683"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2612), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce9d05a6-fb68-44d4-b64a-11e8d156cafd"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2326), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf541b4c-4772-44d9-8087-8709a98b7eda"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2584), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfbfe6c0-93e9-4ffc-b79c-857f51698377"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2543), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1d761b8-cde9-45e5-89ca-017f99340db5"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2605), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2d25e21-c97e-4eca-8470-b16636b2cae3"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2257), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d399511a-36c7-4183-9c90-993491093b31"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2464), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d40579a5-eda7-46ff-af6d-7c77a37f21d6"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2382), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d52d2e9d-7807-4509-8fee-2ad9eaac7f24"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2517), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5d120c4-fc2e-4538-b393-abe5a7272fff"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2300), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5dc1bbf-f846-4a83-9c66-c4492365c003"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2518), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6073c96-67f7-4299-8968-32542c5f6e04"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2550), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6934f4b-dd0c-4d2c-9b15-f844a41d2340"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2567), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daf24655-3885-472d-b52a-ec428f2f2d8c"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2329), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db5ad59d-689f-4dc1-a275-063c2eb5557b"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2239), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc7b7716-ca68-46b2-b9ed-7d518466485b"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2447), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcf80ec8-d980-4e43-bc80-40b040cc6bb8"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2414), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd203d22-d29a-4e9f-8052-d216cf595a62"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2416), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd3a85eb-eed4-45d1-adc6-0cee5fa3a9af"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2481), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e051e240-c36d-4fd4-a372-dd683593e541"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2431), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e13b2ff2-d33e-426a-854c-49375a621711"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2327), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2c74be1-9d8a-4674-9a8c-6fa2cac35648"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2614), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e485fcbf-8609-4a6a-bed8-84642ad05fe7"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2377), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e604aaf0-4ec1-40d2-a401-5c7da3004564"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2484), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e80b8545-2ffa-4c7a-b5e1-a306316df1ee"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2317), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e89d0b9c-6525-45cc-88fe-58fb60e69b36"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2185), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8eb759a-a061-428a-b551-7408caac89d8"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2385), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e99a048c-1a66-4a88-a620-e8c4e3c426e8"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2248), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea7b7d44-9925-45ea-85dd-233691b221c8"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2273), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb6d1bda-623a-4dd2-b19e-b28ec766f1d3"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2625), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ebfb7c17-59e3-41fc-9255-8164e910147b"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2663), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ecf5b748-d62f-4676-bcb3-c3d395cc87c4"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2404), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ede9a8ba-0e80-47bd-948e-860432f06ca3"), "B", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2660), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef943ab2-d9f5-4767-9308-4bfca8dc927b"), "G", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2449), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f25f6d0d-629d-42cf-936d-c333f5efbdca"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2571), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f55acf83-70b2-422d-9d19-a5253c6d5479"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2424), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f59e0873-934f-40d2-baf9-0d6cecc6341d"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2394), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7de855c-1763-42fb-a9df-d66332757be5"), "D", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2247), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f90ff122-e2bc-495d-a0a6-faf4863d354d"), "A", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2263), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fad4b66d-531b-4f7d-82da-c1946d6f8c22"), "H", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2450), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd4ec423-31f0-48e2-adaf-7e2cfc02f871"), "E", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2480), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd734bf7-735a-4473-8d35-35ceece769d1"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2291), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdef2666-4168-4eb3-bdad-6e037759d42a"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2520), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("feb4c049-ec58-4c82-8af3-64c78c05e75a"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2297), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff37f8e1-c0df-42fe-8ffb-2ce7fe09aee6"), "J", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2314), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff620ff5-ba00-427a-9fd8-0287e7218c8e"), "I", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2467), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fff707a8-1e22-441b-9b96-314443491ee5"), "F", null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2544), false, null, null, null, null, new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("a226f188-9f2f-48e9-9749-b9da025a7234"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2982), new DateTime(2024, 12, 29, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2984), false, null, null, null, null, new Guid("aa0220ae-b8dd-4845-8036-be98f8f0f65c"), new Guid("609d99a5-7e05-4f53-b00b-d1519957ab43"), 1, new DateTime(2024, 12, 27, 12, 51, 41, 109, DateTimeKind.Local).AddTicks(2984) },
                    { new Guid("b7eac430-c45c-4263-a0cc-a5488e998011"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(2969), new DateTime(2024, 12, 28, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(2977), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 27, 12, 50, 41, 109, DateTimeKind.Local).AddTicks(2972) }
                });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("09bfae54-7911-4b94-96ba-a15b49b75b06"), new Guid("fc689aa6-8189-4102-ace8-20cfa9b13a14"), null, new DateTime(2024, 12, 25, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3300), false, null, null, null, null, 4 },
                    { new Guid("5ea09529-9395-4191-a841-8e175323b05a"), new Guid("7efe5b22-575c-40e7-8cf0-b0ec8b4911d5"), null, new DateTime(2024, 12, 25, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3293), false, null, null, null, null, 1 },
                    { new Guid("932ed95d-798d-4471-a3a0-2acb27e1077a"), new Guid("0d2eed4f-4c68-438f-8980-a5286908dd27"), null, new DateTime(2024, 12, 26, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3298), false, null, null, null, null, 3 },
                    { new Guid("ddcaf43c-3e03-4f28-8f8d-6e2442406b07"), new Guid("eb5c7656-0376-4a66-b51b-fcf267405797"), null, new DateTime(2024, 12, 27, 12, 49, 41, 109, DateTimeKind.Local).AddTicks(3296), false, null, null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("5b96be6a-a773-4cd5-b766-776251fc4f6b"), new Guid("5ea09529-9395-4191-a841-8e175323b05a"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3273), false, null, null, null, null, new Guid("fbd7dae3-0208-43fe-a99d-9a0b725cd7d9"), 3100000m, new Guid("33388472-f7bc-4327-b9a2-48ea3ef6802c"), new Guid("1ec0bbe8-796d-4136-a676-976c024413a6"), 2 },
                    { new Guid("78348896-e4e4-4c1b-b6de-2577dcdd04d2"), new Guid("5ea09529-9395-4191-a841-8e175323b05a"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3270), false, null, null, null, null, new Guid("aa0220ae-b8dd-4845-8036-be98f8f0f65c"), 2100000m, new Guid("ae61e4b3-4654-45bf-b299-8780addb9e2b"), new Guid("905be6a6-c5b4-40d5-87d3-bb4331c3b585"), 2 },
                    { new Guid("78c227a0-ff7d-4630-9aa3-5c90de403fbf"), new Guid("5ea09529-9395-4191-a841-8e175323b05a"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3259), false, null, null, null, null, new Guid("f2739594-2834-473e-81fa-4d27bf8ae409"), 100000m, new Guid("b09966fa-d550-4d86-adb9-52473efd45cb"), new Guid("e89d0b9c-6525-45cc-88fe-58fb60e69b36"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("181efcbc-2c26-4aa0-9cc7-1a255f8ece00"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3093), false, null, null, null, null, 50000m, new Guid("b09966fa-d550-4d86-adb9-52473efd45cb"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("c7c7b271-eed6-4520-95eb-f0c6eaa091dd"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("81ce24ed-fc0e-4a76-9aef-35d8c8f5062b"), null, new DateTime(2024, 12, 27, 5, 49, 41, 109, DateTimeKind.Utc).AddTicks(3100), false, null, null, null, null, 60000m, new Guid("ae61e4b3-4654-45bf-b299-8780addb9e2b"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("c0d3db14-b522-4f05-b1d0-b8f672ff1eee"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
