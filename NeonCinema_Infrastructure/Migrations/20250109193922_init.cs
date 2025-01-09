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
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8313), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("93b17c2c-386c-4043-9e53-bd6541913351"), "11:00 PM", null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8323), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0a1159ba-377c-4088-9b6a-19f19209bd59"), "Việt Nam" },
                    { new Guid("227bf5c2-f323-401b-a988-10cd8b0d3ae0"), "Mỹ" },
                    { new Guid("75ea289d-aa12-4720-98d7-37f75d91ccba"), "Hàn Quốc" },
                    { new Guid("7f7674a4-70a1-4dc6-9a34-a727978393a8"), "Trung Quốc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("90ae84a6-8c73-4db3-95d7-00844c310483"), "Pháp" },
                    { new Guid("b3a45091-dc32-4dce-93d9-95fde14ade4a"), "Úc" },
                    { new Guid("ccb26394-ec98-4705-ad5c-98288149a95f"), "Hồng Kông" },
                    { new Guid("eaa556b6-7f8e-4b21-82e5-110d55e1e738"), "Vương Quốc Anh" },
                    { new Guid("f56302d0-861a-4cae-bfd1-983ac74bf88b"), "Ấn Độ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0628a3dd-c821-4727-9ba6-d7d7e6cfef54"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7870), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("27e6e5cf-48be-4322-934d-0a2bcfaf01a4"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7851), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("2e6de897-fe92-472e-b53b-68369e163540"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7862), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("3269797d-373f-4b34-901f-5c49d79a000b"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7874), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("828c7981-0e9b-4e0e-8dae-945ef3c02fd3"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7841), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7818), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("a40bdb58-d48e-4983-8b28-7b0d00da2404"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7836), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b26698ac-a871-4220-9e4e-142cf8b292c5"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7890), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b9e5fa77-5ea3-420a-b900-9482112736f3"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7886), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("fa968a4b-17e2-4f2d-97e6-323aed5a41ed"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7898), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("3c0028ab-3223-4aee-97f4-83276aa165b6"), "Combo 3", null, new DateTime(2025, 1, 8, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1817), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("dafc7fca-3f09-4f16-814d-4b2c154b874a"), "Combo 1", null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1799), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("db1c1443-3953-4c64-beae-6e53d875d26a"), "Combo 2", null, new DateTime(2025, 1, 9, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1811), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("ec0e2bac-e712-47cd-afb2-5185888802da"), "Combo 4", null, new DateTime(2025, 1, 7, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1823), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("048e4966-4814-49ad-8f95-bfbb254985cd"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7952), false, null, null, "Tình cảm", null, null },
                    { new Guid("1808482b-306d-4810-8d6d-995e401c9f91"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7967), false, null, null, "Hài hước", null, null },
                    { new Guid("5c6130e9-0aa7-4d57-a8a6-3812c46921d0"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7959), false, null, null, "Kinh dị", null, null },
                    { new Guid("89b1daf1-0269-40b5-91ad-cbbeb8da8206"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8021), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("8ca84ea9-2eb0-411b-9f08-2be4cbb0c11c"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7961), false, null, null, "Hoạt hình", null, null },
                    { new Guid("8f4e687c-02de-490d-904e-2772475b87b0"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7969), false, null, null, "Lãng mạn", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7944), false, null, null, "Kịch tính", null, null },
                    { new Guid("a2fcfae2-00cb-489d-8c0d-5015b79f801c"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7964), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("d17c2ce7-ce74-4d93-90a4-8720dccbd6c7"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7957), false, null, null, "Hành động", null, null },
                    { new Guid("e82446a4-aede-4177-807e-5aee99298d03"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8016), false, null, null, "Tâm lý", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("14c93b67-bcf1-4ccd-a1c1-ccf439caf61e"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7744), false, null, null, "USA", null, null },
                    { new Guid("2c8af4b0-227e-45cd-802e-0cf2580ab981"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7736), false, null, null, "JPN", null, null },
                    { new Guid("356f4dc3-3924-4074-91e2-85b8d782b6c5"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7750), false, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7716), false, null, null, "EN", null, null },
                    { new Guid("c2feb986-8ba7-438f-91f1-bf2fd65bb210"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7739), false, null, null, "ThaiLans", null, null },
                    { new Guid("e88af0d8-33df-4895-b84f-1dd1525b32d0"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(7732), false, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(6769), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(6779), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(6513), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(6544), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(6538), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8224), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8230), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8213), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2293046c-7581-444d-8a7b-fc83265071f2"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("336405d1-17ea-4d4d-9ffa-8f3c6e301866"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("4df2472e-c126-4f2a-abc7-0b5e05d4787c"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("51c793d9-5301-468d-8899-e303ef86b48e"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("7e758418-0469-4cea-ab41-93b19c1411d8"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("86bc7ff7-c048-435d-b978-0e7ba90b5aa3"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("8a1e1cc7-47c0-4733-91ad-d1d8a7c9a37d"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("9217fc85-c1db-4d87-a580-c4a1caec82a8"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("b9b50bfc-4b0c-4fe6-9876-bf07a0c578a3"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("e81c0551-8d63-4dd0-81b7-3336609e14e1"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(1665), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("0a1dd6d8-b75f-4431-8169-2837f902b829"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1179), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 100, new Guid("8f4e687c-02de-490d-904e-2772475b87b0"), "chayngaydi.jpg", new Guid("e88af0d8-33df-4895-b84f-1dd1525b32d0"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("0eabc56f-22de-411f-a128-02754c6b5662"), 13, new Guid("90ae84a6-8c73-4db3-95d7-00844c310483"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1216), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 113, new Guid("8f4e687c-02de-490d-904e-2772475b87b0"), "cuoixuyenbiengioi.jpg", new Guid("356f4dc3-3924-4074-91e2-85b8d782b6c5"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("0fc84262-e17a-4ac5-8e1b-693a04c0548b"), 13, new Guid("b3a45091-dc32-4dce-93d9-95fde14ade4a"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1235), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 123, new Guid("1808482b-306d-4810-8d6d-995e401c9f91"), "kinhvanhoa.jpg", new Guid("14c93b67-bcf1-4ccd-a1c1-ccf439caf61e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("189b19e3-5327-4d47-9558-9af1d4a98c00"), 13, new Guid("227bf5c2-f323-401b-a988-10cd8b0d3ae0"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1254), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 118, new Guid("e82446a4-aede-4177-807e-5aee99298d03"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("1f323f13-42d9-42a5-94a3-89836197f584"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1132), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("828c7981-0e9b-4e0e-8dae-945ef3c02fd3"), 110, new Guid("8f4e687c-02de-490d-904e-2772475b87b0"), "tretraukhongduaduocdau.jpg", new Guid("e88af0d8-33df-4895-b84f-1dd1525b32d0"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("2dea30b8-ffa7-4116-b534-ac9b271f114d"), 16, new Guid("227bf5c2-f323-401b-a988-10cd8b0d3ae0"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1095), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("d17c2ce7-ce74-4d93-90a4-8720dccbd6c7"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("572f9bf0-07b1-4066-a356-25266e17053c"), 16, new Guid("90ae84a6-8c73-4db3-95d7-00844c310483"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1028), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("27e6e5cf-48be-4322-934d-0a2bcfaf01a4"), 109, new Guid("5c6130e9-0aa7-4d57-a8a6-3812c46921d0"), "yeuem.jpg", new Guid("356f4dc3-3924-4074-91e2-85b8d782b6c5"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), 16, new Guid("90ae84a6-8c73-4db3-95d7-00844c310483"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(955), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("1808482b-306d-4810-8d6d-995e401c9f91"), "ngaiquy.jpg", new Guid("356f4dc3-3924-4074-91e2-85b8d782b6c5"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("9c900aab-7d24-4e7d-a458-bfea87436992"), 13, new Guid("7f7674a4-70a1-4dc6-9a34-a727978393a8"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1270), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 134, new Guid("d17c2ce7-ce74-4d93-90a4-8720dccbd6c7"), "cuocchien.jpg", new Guid("2c8af4b0-227e-45cd-802e-0cf2580ab981"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("a1ec4e87-8744-48b4-a6d0-b324e7f73578"), 13, new Guid("b3a45091-dc32-4dce-93d9-95fde14ade4a"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1115), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("a40bdb58-d48e-4983-8b28-7b0d00da2404"), 120, new Guid("8f4e687c-02de-490d-904e-2772475b87b0"), "botubaothu.jpg", new Guid("14c93b67-bcf1-4ccd-a1c1-ccf439caf61e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("ac19e935-aa87-4f50-b0dd-2d50c3ebdfc2"), 15, new Guid("90ae84a6-8c73-4db3-95d7-00844c310483"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1158), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("27e6e5cf-48be-4322-934d-0a2bcfaf01a4"), 110, new Guid("a2fcfae2-00cb-489d-8c0d-5015b79f801c"), "chuyennhabanh.png", new Guid("356f4dc3-3924-4074-91e2-85b8d782b6c5"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("b077a7bd-3f04-40a6-beac-58e7d6bfc2cf"), 13, new Guid("b3a45091-dc32-4dce-93d9-95fde14ade4a"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1009), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("828c7981-0e9b-4e0e-8dae-945ef3c02fd3"), 113, new Guid("a2fcfae2-00cb-489d-8c0d-5015b79f801c"), "congtubaclieu.jpg", new Guid("14c93b67-bcf1-4ccd-a1c1-ccf439caf61e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("b2979c51-0f29-47ca-abba-c8500c4b6543"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1061), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 99, new Guid("1808482b-306d-4810-8d6d-995e401c9f91"), "tetamhon.jpg", new Guid("e88af0d8-33df-4895-b84f-1dd1525b32d0"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("cc8cf331-daea-4ed5-a800-086cc29dbe1e"), 18, new Guid("90ae84a6-8c73-4db3-95d7-00844c310483"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(987), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("a40bdb58-d48e-4983-8b28-7b0d00da2404"), 81, new Guid("1808482b-306d-4810-8d6d-995e401c9f91"), "xich.jpg", new Guid("356f4dc3-3924-4074-91e2-85b8d782b6c5"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("f521667d-9f0c-4cb6-b34d-ac78285392a9"), 18, new Guid("227bf5c2-f323-401b-a988-10cd8b0d3ae0"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1287), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("2e6de897-fe92-472e-b53b-68369e163540"), 127, new Guid("d17c2ce7-ce74-4d93-90a4-8720dccbd6c7"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8385), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(8393), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("52c97b93-6eab-4d6b-ad38-61a1a36b8955"), "Hà Nội", null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(7379), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("736a4132-2995-4cf3-9ec1-77bb7e4d9e11"), "Hà Nội", null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(6838), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("74592efb-b7ab-46f6-8ce4-8ff2dfe091d2"), "Hà Nội", null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(7594), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("a5a854c2-1e15-417f-95e4-e962a6e48a50"), "Hà Nội", null, new DateTime(2025, 1, 10, 2, 39, 22, 428, DateTimeKind.Local).AddTicks(7445), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("02457b2b-782b-46fe-85b3-e2d803fb62b7"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1576), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 18, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1573), new Guid("336405d1-17ea-4d4d-9ffa-8f3c6e301866"), null, 0 },
                    { new Guid("625dcb2a-4bf0-4742-a7d2-d28ec92e0a97"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1611), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 14, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1608), new Guid("7e758418-0469-4cea-ab41-93b19c1411d8"), null, 0 },
                    { new Guid("756cfd72-51f6-4869-8c5f-2c355d67ef29"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1584), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 17, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1581), new Guid("e81c0551-8d63-4dd0-81b7-3336609e14e1"), null, 0 },
                    { new Guid("a83e08da-a5a1-4edc-b784-bd55e1e0ae2f"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1554), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1550), new Guid("86bc7ff7-c048-435d-b978-0e7ba90b5aa3"), null, 0 },
                    { new Guid("bab27f20-a779-4e15-9a87-2d16ae87d868"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1592), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 16, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1589), new Guid("9217fc85-c1db-4d87-a580-c4a1caec82a8"), null, 0 },
                    { new Guid("dcb86f74-4372-471d-8f77-d32666256046"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1568), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1564), new Guid("4df2472e-c126-4f2a-abc7-0b5e05d4787c"), null, 0 },
                    { new Guid("ec39ce06-1f05-4ed9-896a-38c6d4ba3185"), null, new DateTime(2025, 1, 10, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1603), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 15, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1599), new Guid("b9b50bfc-4b0c-4fe6-9876-bf07a0c578a3"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00034b87-6aec-4dd7-a08a-d3832a9010b2"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(8), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00dfcc95-677f-4f8a-bf7f-3514dfe0f1f3"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8878), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("01064853-5f18-42e2-8e32-56a50d1158d4"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(362), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02a0cfb2-e72e-44cc-90a9-9484f4a857a6"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9033), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0403b8f1-02ec-42e7-a76c-eccc71f9c807"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8649), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04081f07-a4d0-4c25-8364-6885a3b8de66"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9184), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("040fa49c-8768-426c-bd32-9ababc6438ba"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8940), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04468317-6103-4a20-867f-d8b2310c927a"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8883), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0452cb65-c0c6-457a-a1e1-f11450b46aea"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9830), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06160049-548e-40d1-aa7b-2bd261528160"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9102), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("075d09ab-550d-4cb9-9478-ac6dbe478dea"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8669), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0763c8a3-4d2e-45f1-b27a-61ccca973136"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9904), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0944f025-4b5d-48e0-ac9d-11664f8b97aa"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9788), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b69659e-a90f-4249-ac6c-00ae6add90b9"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(342), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b7a7ed4-f785-4af2-ae38-4a6b7518cfea"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(323), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0bc4d845-02c4-463f-97ad-4753a3ee1b90"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8686), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d6c578b-a675-478a-ad79-e9fa68dc9200"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8870), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e332c46-b274-4268-a71e-1eba4ff27494"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(106), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f25ff4d-6ff6-42dc-be25-a4fcb8414662"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8440), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("136ffddf-0f3f-4ee5-b7e3-4debebac82e0"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8860), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("139f1f50-544e-4a4a-8ac2-db10a8bca70d"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8910), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1590f561-044f-4ec5-82b9-1f2ad4aa5ad9"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9276), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16a5a1de-7e33-4104-a5e7-9d1f7aed83e1"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(144), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16a8f8e0-5d0f-40ca-9ab8-76f7afb275d4"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9485), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1704e46c-0cdb-44d1-88ca-d12009d1f50e"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(318), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17384579-de21-42d6-8963-b3c6d1d6c45f"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9615), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("176db789-848c-4f88-ad73-31eb92db47ee"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(124), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17bfd652-3de3-4163-b395-a2e5b44bd3f5"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8849), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18b11149-ec4f-4550-8663-2be2a597b5a0"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(80), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c01d1e1-852a-4f33-9cb0-8dc4fe9e6fe6"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9038), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c6afa46-80bd-4da5-a0f8-6201b200680e"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9610), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cfe415f-5f20-4b15-87cb-f353fe0087d6"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9919), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1dc45afe-0359-417f-80d4-809a7c1ee26c"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9714), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ed16e47-3f64-4334-968b-886b9d73d43c"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8961), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fada4c9-7d1e-48b4-9e54-903dc89b625e"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(276), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fd66166-224a-43e7-9ddd-201971961c9c"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9803), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ff9ae5d-b7e6-4b24-bae7-e202069abca0"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9490), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20816a86-0a03-4722-8dda-c61ae92304c3"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8855), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("208b064e-fc45-4b1d-a702-5eb2c0def699"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9457), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23356ec4-6cb9-4053-88be-f45d510f0daa"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8521), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24de20a5-44a0-4540-9af0-1af3ffd44092"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8639), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("252ddc7e-5555-471d-8646-200c07817b30"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9581), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("258837dc-1297-4cae-a526-fcd4d81bfb9c"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9966), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25b7a51f-4604-4aab-8d28-e78b3e75fafe"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9385), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2786c55b-472f-4507-9560-f195f391fa47"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(448), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27f0f354-405e-4200-85c7-a8e542bf53b1"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9793), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d274069-b3aa-4f7d-a5ca-8797bb9999b3"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9119), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2eb962a9-478e-4b2b-a1e6-df412a144ba4"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9591), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2fd84020-0dd4-44df-a3a2-7d335edbf942"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9437), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30ee2596-8664-4a8d-a2d2-93b025111f28"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9653), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32093438-a562-4fb4-8b35-727dfbf04226"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(439), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("322fbb53-a794-45eb-a233-245dc30162c8"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(111), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34e75c90-eac5-4df4-969a-03801a58071f"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9667), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34fa537d-e397-4c95-9df3-183ff254204c"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9067), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35c427e4-3ef1-482f-9f3f-ca4e6c044e12"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(154), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3626cef1-a8ba-4bfb-9835-7786a03b2324"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9501), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36a1bcbb-8791-486c-9c3a-e853adaf05dc"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(247), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36c912c4-5506-4558-938b-0afb8856daca"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8527), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36db7c49-fe20-42a5-b2d3-f3fd7768a942"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9308), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36ef73fb-c503-400d-84b2-b9c12c3989da"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9480), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37cd7446-5ee6-4954-9541-76f21a360b94"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(291), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("399b62da-6ab5-4827-a304-e91767bff97f"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9808), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c8eccc2-e3c7-496d-8af1-f9db54ff2128"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(298), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cf98fe8-077c-4e66-b037-81fe98111730"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9462), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42b848ae-3bde-45eb-8123-8682971a2b11"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9605), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4315b480-2f51-4200-bd13-fb212dddbe34"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9754), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("440d9624-ea31-4c69-925a-c481d81bac25"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(267), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44591eea-94c9-4b15-8945-1e6a7a39080d"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9081), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4583fdf0-0b33-404f-91c3-f563bc18ced0"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(443), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45aa60b5-22f4-45ca-b874-4d39543f3915"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(150), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45ae02fc-32f0-4aa8-a40d-a21b310a8373"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8616), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4699e5d2-eb24-485d-9c68-2724bb5ef2a7"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9976), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("475ab0c2-fa60-451a-85a1-37261f6b0117"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8644), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("480e982f-99dd-44f3-9019-0ac9b2c45314"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(178), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49486647-72c7-4c89-b1e8-57cf62f94456"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9266), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49ecc441-9fd0-4b03-90a6-9166b4fbc3bb"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9056), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c1ffacd-38b3-49b0-86d4-7601bcb002b9"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(96), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4cba8e9a-b243-468b-b529-5f0cf7d787b1"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(17), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d47a2f3-6171-49fb-8f68-5f2695ffbfec"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9629), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d6ac17d-dbb8-4e2f-978b-7038deac4ed8"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(304), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ef34eb4-bd1d-4c22-82e9-e569fce0b081"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9251), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50b85410-a658-4bf2-9a37-d3c899b3ff7e"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8626), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50e628b0-dd3b-4d76-bda5-3f7170b34536"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(262), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("526d01bf-a01d-4ff7-9893-22f91d6b0015"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(429), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54a34da4-9d52-4abe-9ba0-f1d3394500ff"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9648), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54a9652a-c0e1-4a0d-844d-865a2ff04b3f"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9573), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54b7ccbd-17af-4227-aefc-fa10f155f58c"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(183), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55503344-cef3-4ce9-a3cc-bdb8bdb19024"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9216), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("581023ad-2229-45e9-9e37-3b3e96a94f06"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9659), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59cb25a7-f314-4765-b37b-667afde872bd"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9914), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a39ffef-a989-4062-9dde-3354aa558854"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9471), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c2132c6-a713-41b5-9d59-690257f7fea0"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8621), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c867e96-c5f9-4982-aa24-f9b5816193a1"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9393), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c929672-fc5b-4428-9b7f-721d698267ab"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9934), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d8ee331-3344-459d-988c-c73d9c9bd300"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8677), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e1f8f35-d99c-48a3-8dcc-65e6c5b75a3f"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8682), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60b3ba51-9470-41d5-8e83-8770ae3dedad"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9985), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61114767-e994-4c7d-a2fe-244fdf2d4ca7"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(328), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61d4b171-0b9b-49ab-a481-7a8f52f360c1"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9241), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("620fedb3-6d6b-4622-93ac-bbf5baa3cd09"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(22), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("642c5740-997e-44ea-a98f-d3faab9ccca0"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(420), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66c297d1-d98d-45bc-9239-5490db557d0a"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9247), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69020b89-532f-4279-88e6-c60e518e3e20"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8611), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69df823b-deda-4a4e-8a25-726c3a50007b"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9739), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a2ed765-6dc6-48dd-b4a7-710d32e76a0a"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9098), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6baa17fd-6ead-4d9c-bc7b-2e1e0ac4097c"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9261), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bfb897b-053c-4ce2-b562-c90b8c7583ac"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9924), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6de30899-3d6a-43ee-b971-90742ae45a84"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8660), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fc1bae2-1a23-4a87-aede-3262294e2ffb"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(286), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71e414a4-de69-45ce-b492-a3b0c4f7f807"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9971), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("721d1adc-6561-47ae-a5a4-5f9b194c6c92"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8922), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72979c68-91f7-4d84-a793-178cf6f8264c"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9770), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("743074d6-9cbb-4cd1-885a-d2f01d94ab87"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9567), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74bfaa65-1014-4983-9cd4-2b5d723f2b4c"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8692), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75b7b56c-0740-4012-8e42-606eb976f819"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9297), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75f8fd44-dc56-4039-a294-b75bb671b731"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9505), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76deac59-d606-4cac-a2e7-2805f7358b75"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(31), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79c82a45-90f6-4f14-afdd-1813853cb688"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(433), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7bb1096b-3ada-449e-bbe3-1b10dcaaa258"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9179), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cc806b3-20b2-4e4a-b45b-62886e0bc236"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8944), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cdf5c6f-00a6-41eb-b542-94e3ca61b5ba"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8665), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d4afae1-c6a1-4675-92c9-edaad40d0239"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8548), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f6564b7-7e3c-48f9-af07-c603d7355a58"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9635), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80a7c8a7-4e5d-4a8b-aaa5-ad5376241314"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9620), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83b80fe2-6d80-4a77-8df5-6aff0b5085ec"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9725), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("844d9dfa-d5b3-4a38-a65f-8d5338bcf5cc"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(414), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("885d377b-84c4-463a-b51c-09f4c82a8f29"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9596), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a5f45de-55dc-44fc-b27a-0f7c399e3c27"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9407), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8aa2efe3-de8f-4bae-9900-4d0e6b5e6739"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(116), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8aa4fd82-0141-451c-97a9-6e0baa0d3e49"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(101), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b900dd4-2470-4bf4-b58f-c9358f70d29a"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9286), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9029ec78-804b-4d60-97f1-b91512720be1"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9624), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90d73a25-47c4-4bc0-80e5-500fb2ee76ba"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9046), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9135396c-6c02-4c2c-8e22-90ce8393d70a"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9291), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("927a3c77-f12b-4af2-a4ac-cd66ab38159e"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(347), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93116915-ecdf-41d8-b915-a7baf2d12ab5"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9019), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("940b28d7-8955-49fd-b64d-3f14c00f95b8"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9271), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("949936e8-2453-41bd-8b03-e240a773792a"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8936), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9820a4b4-a6ad-4bef-9aed-93771e627314"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8887), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9846d02d-a236-43aa-979c-6ec9d8116e85"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9111), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98ab249d-0916-4586-8fec-df2737607ccc"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9203), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98b57468-81d8-4ada-bd4a-866df12b8140"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9093), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a5e195d-0935-4005-8b2d-5ecddc0d85fb"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8656), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9afb534a-88f7-4151-8740-36ba202adfb2"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8792), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bf2fc06-11ff-46d0-9120-7313d8de1f4f"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9980), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9de294e0-6e17-4770-b638-82493990116c"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8949), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e3b9d17-c87e-4ddf-ba0d-af80e62cb105"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8706), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f1ff203-f6e6-46ad-af83-94db347f05f7"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9475), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fccab5d-1445-4705-a5a5-f05587e6de6f"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(272), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a01066a8-b6e2-4c1e-93f3-0bde4f88f0ee"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8597), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a110c241-ab8d-43fb-bffc-697f74e50a7a"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(257), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a23d34bb-3453-4839-88da-0543af17c172"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(313), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3678384-0e03-40d2-8eb7-bb5ea05a3178"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9426), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4721da9-b744-45c8-b22d-3a09e648115f"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8901), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6b320b8-3d42-4bbc-98e5-551f78fe2151"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(26), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8042260-2670-4029-af01-6d99ebfe9bdd"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9759), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a88aed88-4bf8-48ff-b8ab-a4b2cf381166"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9586), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9a2e621-3504-4e24-8425-831b19f26433"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9402), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9d0aba5-6f5b-46c4-ab6b-53b6f3d592f0"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9821), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa76988f-9587-431f-91c7-ca6c48843394"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9749), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("adcd2553-b34b-4ea2-b23a-aa9c4656890f"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9189), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af15b0e7-508e-470e-83e9-6aee536feece"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9417), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0becc01-3d47-47aa-99cc-a4e955fb88c2"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9226), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b10eec07-d233-4189-9671-63ef662218b1"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9432), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b18df085-ecfa-41c8-9593-9277f5b6f61b"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8710), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1de6746-9cbb-45ab-94f3-80957d8c0d7f"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9783), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2e2b861-4fe7-42a4-91f7-c9553e9bd98e"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9778), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b41d9fe0-1567-4544-a851-44538543c095"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(281), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b46e77a3-2d7a-499e-8ffe-30a43c473fbc"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9072), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7db19e7-91da-41c1-b7b3-fdcc98be0cf9"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9997), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b80952d6-195b-419e-9d60-956b8223cc43"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(135), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b950321e-ea90-40e5-b5aa-1311370047e3"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(188), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9807050-8db7-4995-aacb-9fc55f34e1f4"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9236), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbd323d4-274c-46d6-b3db-70d576bbb256"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9640), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbe43ccc-2417-4b2c-aa04-83ccbccfa86b"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(139), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc148cee-d768-4241-bbf9-75c96f9e8758"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9281), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc8f5836-aa02-4673-ade9-298efcf88777"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9962), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd86808a-5f5b-40d8-ad19-2ade7131eebf"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9198), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c14c4a4f-3078-4074-96a5-124717cf96a4"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8931), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2640d1f-12d8-4ad6-bd2d-48211367facb"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9107), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2a44d63-4ead-4c0c-8674-55ab5e6def07"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8701), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3f8fdb9-2dec-4d44-bce8-8099d33b832c"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9495), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6e2ea73-7869-414d-bef7-7e0bf4700bd4"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(366), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8722691-d072-4c34-b9bd-e72826e37b99"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9949), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd62a66a-407d-460f-b1ef-320010cf50e6"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(91), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce0a9741-ada0-49bd-b18d-ee65860b4665"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8865), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce161048-53cb-4e90-a22e-70e4230e930a"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(357), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce3d4854-1ddb-45d4-bb53-2815527f7d78"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9989), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf16dc4c-3424-4d9f-a1c9-9c58b1013271"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(86), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf901037-72aa-494b-99da-a59ba5738d47"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9089), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfc8e3cd-d51a-4fca-967b-3750c77fcacd"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(159), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0903e40-7cb7-4173-81be-c438eaf1c330"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(352), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2e55147-1cdf-4947-a737-23e1f72cd35a"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9051), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2f862dd-deca-46a6-a487-84278fe11695"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9442), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3e490f8-c0fd-48d8-a8b8-500dbcc55973"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9397), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4ad4868-146c-41f9-8ee5-20f261a7f23e"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9851), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d75abb75-17ea-4bf5-8b0a-81212811d667"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(308), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d76721e9-1e5e-4fd0-82fe-3c1edef07d23"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9193), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7681164-ccbd-4401-aa7d-4c9885086612"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9956), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7890dbd-fe14-4aba-b22b-6c568f59ddfd"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9798), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d78af7d2-c9b5-4322-958d-225eb7283797"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9939), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7fe0100-435e-4967-a368-57fd54f8c2d5"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9734), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8913937-2f73-434d-8699-aaa0088bc5ad"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9029), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d909f220-94ea-4189-9b0e-ed6f340b63db"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9812), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db001abc-4761-4084-a134-432061d20310"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9061), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbe443d7-eb87-4473-8b08-4dda8cf4e644"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8896), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc278938-c914-4842-8996-69ef6c69ab0c"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8604), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd153a33-70e8-4a69-9b9e-f5da330bf62d"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8956), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd29f90e-eecc-4f18-9160-6bcedd9c70d0"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9764), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd8de06e-b316-47ea-acee-8320b38f810a"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8892), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddf6a436-4552-4f40-9a59-5841e666dcbf"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9452), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df2d6b64-3635-447a-85e8-248ea4f3ca51"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8905), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dfbfdd17-5b42-4bdb-9b74-46decb42b72c"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(2), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dfe1baae-4409-4d4d-a701-68adfd7e64e8"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(193), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0b04848-6b7a-4bfb-8e63-f4742218e6f0"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8532), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1272b82-3c6d-4c57-a212-a76a347ef3fa"), "A", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9845), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e167b597-f23f-4ee0-bba8-c8b041342b37"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9013), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1e9bfcf-cf0a-48f4-81a4-b7a542774c57"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8727), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e21a89c6-466c-4c8f-9c48-4866a62ff862"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9835), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e250066b-ab70-4139-9086-c2a185979c97"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9744), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e352c197-d3ac-474d-8e1f-07dbcb4d3297"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9447), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4678e60-68af-46f3-804f-79e805f4da93"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8543), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5ba40fe-d6fc-44c5-8a05-c053a875490d"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9077), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e63b06a4-13b5-42b8-9b5c-df5a68ed3217"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8634), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e90c4790-6317-463a-af47-3559b78f8d4e"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8843), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e94b0190-44fe-4b42-afc8-182c19953242"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9115), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e988b37b-d381-421b-9f22-c2730dc5916e"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9840), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9cc5989-c939-49e9-b9c4-97e20bc09836"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9928), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eac99620-eefc-489b-b69e-507e4f63574f"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8696), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eaf5bbfb-777d-4ade-84df-db68136bb8b1"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(198), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb30ac66-2713-45d9-b834-7b3bf96bf306"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9412), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec7b7369-2862-48c8-aef2-295040701525"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9207), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("edadd8a9-0391-41a3-9784-2702484778b3"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(333), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee1ff511-852e-49ea-9c6e-8ca2dccb3b08"), "D", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(168), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee3d625d-cdfe-48b4-aa44-2969e88b5e04"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8918), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eeb8fa8e-4aeb-41dc-bafc-bfcd88d2afa2"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9221), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f298c643-a474-49b6-a660-417b8ab816d6"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8927), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3e368b8-81a5-42f2-a4b7-adbe555b277d"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9720), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f429ddd8-cfec-4a25-b123-c37a1ee2c918"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9519), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4ce4dd5-abc2-4fd8-b947-a284271a49ee"), "C", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(13), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f62e7e7e-6289-4c1b-aac3-976637954108"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9174), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f86ad02f-e95d-4782-9802-0f51fcd8d47f"), "F", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9513), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9259885-7c89-44c3-92f0-f4350f2aefed"), "I", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9231), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9722880-a338-474c-8a7d-7a0511a3b6d1"), "H", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9024), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fab5f034-67d7-484e-bcf0-f6b2bf9be0bc"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9663), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb22efe5-b23e-49a8-b596-7f8fab5bb5d6"), "E", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(173), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc90af01-e332-4251-ad0a-edadb69bbe02"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9825), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe8f4578-0c39-4739-9e7f-f4904c42279d"), "G", null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(129), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff89b866-399c-41eb-9877-c75e96494773"), "J", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(9943), false, null, null, null, null, new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffacff74-21d1-42a3-b6c3-abe22e806971"), "B", null, new DateTime(2025, 1, 9, 19, 39, 22, 428, DateTimeKind.Utc).AddTicks(8515), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("16422198-77dc-4d5b-8e6b-582032dd6e1c"), null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(1418), new DateTime(2025, 1, 12, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1429), false, null, null, null, null, new Guid("cc8cf331-daea-4ed5-a800-086cc29dbe1e"), new Guid("f9e58e95-b3d5-4d79-9cdd-135a03e376a8"), 1, new DateTime(2025, 1, 10, 2, 41, 22, 429, DateTimeKind.Local).AddTicks(1428) },
                    { new Guid("93b4d9f1-cfa3-41b3-8632-b25ff8aa2a66"), null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(1359), new DateTime(2025, 1, 11, 2, 39, 22, 429, DateTimeKind.Local).AddTicks(1411), false, null, null, null, null, new Guid("5a4bd3ea-6868-4ed8-b75c-8b1cfd263510"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 10, 2, 40, 22, 429, DateTimeKind.Local).AddTicks(1379) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("1e20346b-109e-46ab-9129-bd58d1c64214"), null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(1726), false, null, null, null, null, 50000m, new Guid("a83e08da-a5a1-4edc-b784-bd55e1e0ae2f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("86bc7ff7-c048-435d-b978-0e7ba90b5aa3"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("ebbd89b8-3862-4cf6-8d5f-0707045d77b6"), null, new DateTime(2025, 1, 9, 19, 39, 22, 429, DateTimeKind.Utc).AddTicks(1746), false, null, null, null, null, 60000m, new Guid("dcb86f74-4372-471d-8f77-d32666256046"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("4df2472e-c126-4f2a-abc7-0b5e05d4787c"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
