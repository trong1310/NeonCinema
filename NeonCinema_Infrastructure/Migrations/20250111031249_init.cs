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
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1466), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("b04b5c06-e9d3-4ada-a31f-2761482d0234"), "11:00 PM", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1472), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("38e3b2d2-dfd6-4c3e-9ce9-57760e8c1a60"), "Ấn Độ" },
                    { new Guid("486132bc-63ff-411d-bec4-675364cb0d5d"), "Pháp" },
                    { new Guid("4a0aa1e3-a6b4-44ca-89f3-6ce5a6046e74"), "Trung Quốc" },
                    { new Guid("541ef555-5d27-4995-9dea-05ae4db68526"), "Úc" },
                    { new Guid("5fc6480d-1a47-43e3-82b2-8e8e80361173"), "Hàn Quốc" },
                    { new Guid("7c2acbed-aa54-4482-867f-977dd80513b3"), "Hồng Kông" },
                    { new Guid("7e59a04e-9232-49e8-a97a-13b915275d0e"), "Mỹ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("a88ef408-159b-4425-bf70-59bcdad39317"), "Việt Nam" },
                    { new Guid("f4c71635-8e27-4a58-b657-bc4a438327cb"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0fcb652c-b5fc-480d-9564-98e2fbd98332"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1332), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("4049d27f-9599-41a0-84a4-5a0e4cbd3e4c"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1347), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("54512945-766e-4dd7-a767-6be3238f1f80"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1344), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1335), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("5d106204-acce-4e70-b333-e648bab2d88d"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1343), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("697101c6-aa09-4359-a499-ef7b9dbcb267"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1333), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("7bc15d2b-862a-4eea-9b55-bf498f73179d"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1340), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("81540a5e-76ee-4978-90ca-bfb4b28c235d"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1341), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1305), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("ac9662b7-1fbe-4267-8f2a-f4b62656a634"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1311), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("7332f22c-7190-44fa-9f74-7adba7d98ac2"), "Combo 1", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2644), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("b792a4a0-2492-414b-890c-8b9f6c262594"), "Combo 3", null, new DateTime(2025, 1, 9, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2651), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("cf9f29a8-4716-4727-8a83-a71bbcebebab"), "Combo 2", null, new DateTime(2025, 1, 10, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2649), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("e85e705e-94d0-4646-969f-6a675ae373ad"), "Combo 4", null, new DateTime(2025, 1, 8, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2654), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("298a5d4a-8365-482e-a893-4a490cd45234"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1379), false, null, null, "Lãng mạn", null, null },
                    { new Guid("45366215-dfa3-4e7a-af28-e5b32389dbbf"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1377), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("496c99dd-abe8-4f23-b7c5-1c73216931e6"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1378), false, null, null, "Hài hước", null, null },
                    { new Guid("5aebf3e1-fb58-48af-986b-0423ffddb582"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1369), false, null, null, "Tình cảm", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1366), false, null, null, "Kịch tính", null, null },
                    { new Guid("9be4df62-bdc0-4c42-84c9-299b75cc9b28"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1371), false, null, null, "Hành động", null, null },
                    { new Guid("a6bd115a-ccad-4fe5-9201-137c80bc6838"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1372), false, null, null, "Kinh dị", null, null },
                    { new Guid("bc447dfb-cafe-4e2d-9acc-3b53e4d862ff"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1382), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("edb6a842-fa1c-42a3-a0db-5f20890c763a"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1380), false, null, null, "Tâm lý", null, null },
                    { new Guid("f893c6dc-f2c3-4147-b897-197b5e20f872"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1375), false, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("42464d45-14d5-4f95-91f1-cf066c5de026"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1277), false, null, null, "ThaiLans", null, null },
                    { new Guid("83396251-9995-4cfd-aa25-fc7c26374ba8"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1281), false, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1263), false, null, null, "EN", null, null },
                    { new Guid("b66b2d1b-51e5-40a4-b916-1f6e375c0d96"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1276), false, null, null, "JPN", null, null },
                    { new Guid("d6162855-539f-4e72-ae25-3e251e5c3535"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1278), false, null, null, "USA", null, null },
                    { new Guid("f291a4fa-f283-4ea4-9e17-e6ac7df281af"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1266), false, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(768), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(769), false, null, null, null, null, "2D" },
                    { new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(744), false, null, null, null, null, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(647), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(664), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(662), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1441), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1444), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1437), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("134dec38-2643-4c30-9b7c-4c71b9d74582"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("33435f01-659e-43e8-8b1a-7b29b261c7f6"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("42185563-ad2c-4502-b296-a0157efcfb50"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("5153d43c-f5f1-453f-a883-eadbbb5af5c7"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("5bf89d06-efb5-47ce-b16b-b01e8a313c7c"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("5efd3d9c-7aa5-4064-89d6-e492950c634d"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("650eed5b-516f-4f50-939d-a2491b29a3d4"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("9e7fed6e-3e5c-4f8b-a4c7-894c83c62fd2"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("9f7cc9b7-6f45-44d1-af73-40c507175045"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("bca51900-8fdd-42a8-92df-b1f402827d5d"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2563), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("09b149f1-7aef-4b05-b74b-db90ae8f098f"), 18, new Guid("486132bc-63ff-411d-bec4-675364cb0d5d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2347), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("ac9662b7-1fbe-4267-8f2a-f4b62656a634"), 81, new Guid("496c99dd-abe8-4f23-b7c5-1c73216931e6"), "xich.jpg", new Guid("83396251-9995-4cfd-aa25-fc7c26374ba8"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("1bbf52ea-9fa7-4a12-bb03-0e609e9ca2e9"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2427), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 100, new Guid("298a5d4a-8365-482e-a893-4a490cd45234"), "chayngaydi.jpg", new Guid("f291a4fa-f283-4ea4-9e17-e6ac7df281af"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("222c031b-8dd6-482a-9cc5-6418aa15c5a4"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2389), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("0fcb652c-b5fc-480d-9564-98e2fbd98332"), 110, new Guid("298a5d4a-8365-482e-a893-4a490cd45234"), "tretraukhongduaduocdau.jpg", new Guid("f291a4fa-f283-4ea4-9e17-e6ac7df281af"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("3553c7bd-b08e-4d53-9431-00555c05bfe9"), 13, new Guid("7e59a04e-9232-49e8-a97a-13b915275d0e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2447), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 118, new Guid("edb6a842-fa1c-42a3-a0db-5f20890c763a"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("706f641c-735f-4a91-85f6-3df3f0371fe0"), 13, new Guid("541ef555-5d27-4995-9dea-05ae4db68526"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2382), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("ac9662b7-1fbe-4267-8f2a-f4b62656a634"), 120, new Guid("298a5d4a-8365-482e-a893-4a490cd45234"), "botubaothu.jpg", new Guid("d6162855-539f-4e72-ae25-3e251e5c3535"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("731bee6a-0190-4d85-9c79-411c3c338776"), 13, new Guid("4a0aa1e3-a6b4-44ca-89f3-6ce5a6046e74"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2453), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 134, new Guid("9be4df62-bdc0-4c42-84c9-299b75cc9b28"), "cuocchien.jpg", new Guid("b66b2d1b-51e5-40a4-b916-1f6e375c0d96"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("83858324-33d4-4944-b3a1-e3b467c5e520"), 16, new Guid("486132bc-63ff-411d-bec4-675364cb0d5d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2362), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("697101c6-aa09-4359-a499-ef7b9dbcb267"), 109, new Guid("a6bd115a-ccad-4fe5-9201-137c80bc6838"), "yeuem.jpg", new Guid("83396251-9995-4cfd-aa25-fc7c26374ba8"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("a5a85b9e-f393-45b6-ba5a-23fc5922a183"), 18, new Guid("7e59a04e-9232-49e8-a97a-13b915275d0e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2459), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 127, new Guid("9be4df62-bdc0-4c42-84c9-299b75cc9b28"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("b3df3e93-4c39-41a7-9cec-84c6ae39cbb1"), 13, new Guid("486132bc-63ff-411d-bec4-675364cb0d5d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2435), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 113, new Guid("298a5d4a-8365-482e-a893-4a490cd45234"), "cuoixuyenbiengioi.jpg", new Guid("83396251-9995-4cfd-aa25-fc7c26374ba8"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("b905c0e6-615c-45e1-96a7-8d37aa7ac3ba"), 15, new Guid("486132bc-63ff-411d-bec4-675364cb0d5d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2419), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("697101c6-aa09-4359-a499-ef7b9dbcb267"), 110, new Guid("45366215-dfa3-4e7a-af28-e5b32389dbbf"), "chuyennhabanh.png", new Guid("83396251-9995-4cfd-aa25-fc7c26374ba8"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("bcd37df9-509d-4ec3-ac63-6e4d745ce0fa"), 13, new Guid("541ef555-5d27-4995-9dea-05ae4db68526"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2441), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 123, new Guid("496c99dd-abe8-4f23-b7c5-1c73216931e6"), "kinhvanhoa.jpg", new Guid("d6162855-539f-4e72-ae25-3e251e5c3535"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("c6189e58-948d-48f0-8551-52a3d4faf616"), 16, new Guid("7e59a04e-9232-49e8-a97a-13b915275d0e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2376), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("9be4df62-bdc0-4c42-84c9-299b75cc9b28"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), 16, new Guid("486132bc-63ff-411d-bec4-675364cb0d5d"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2338), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("496c99dd-abe8-4f23-b7c5-1c73216931e6"), "ngaiquy.jpg", new Guid("83396251-9995-4cfd-aa25-fc7c26374ba8"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("e99fe2f2-176e-4fbb-b3ab-638472b0f4ed"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2368), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("5b1ef847-042e-4479-82ab-e8e9f7be4778"), 99, new Guid("496c99dd-abe8-4f23-b7c5-1c73216931e6"), "tetamhon.jpg", new Guid("f291a4fa-f283-4ea4-9e17-e6ac7df281af"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("ed48d142-10df-4817-9a89-eb227c638edd"), 13, new Guid("541ef555-5d27-4995-9dea-05ae4db68526"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2356), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("0fcb652c-b5fc-480d-9564-98e2fbd98332"), 113, new Guid("45366215-dfa3-4e7a-af28-e5b32389dbbf"), "congtubaclieu.jpg", new Guid("d6162855-539f-4e72-ae25-3e251e5c3535"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1520), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1524), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("3e092f45-0919-4786-bf38-f0a0d7f61589"), "Hà Nội", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1199), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("596c80f5-b6ca-4cb2-a13b-0a76bd83480e"), "Hà Nội", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(813), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f5311ec3-3f9b-4be3-b507-08a33f2441ae"), "Hà Nội", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1175), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("fb45e844-3883-462f-b93b-377fb0421769"), "Hà Nội", null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(1220), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("07373c5a-1c37-4a86-8c5c-8c1f9448c14b"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2520), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 21, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2518), new Guid("5bf89d06-efb5-47ce-b16b-b01e8a313c7c"), null, 0 },
                    { new Guid("08ce32ce-67f8-42a5-9d3c-9a4ccb414f30"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2534), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 18, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2532), new Guid("650eed5b-516f-4f50-939d-a2491b29a3d4"), null, 0 },
                    { new Guid("257cbfe2-6061-4384-969e-13c97f0fef9a"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2527), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2526), new Guid("bca51900-8fdd-42a8-92df-b1f402827d5d"), null, 0 },
                    { new Guid("4cedf23a-56a6-4932-a4ee-20d4f5429e16"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2530), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2529), new Guid("134dec38-2643-4c30-9b7c-4c71b9d74582"), null, 0 },
                    { new Guid("6f0025e7-47bb-4af4-962f-8aa9aa98b3f8"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2541), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 16, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2540), new Guid("42185563-ad2c-4502-b296-a0157efcfb50"), null, 0 },
                    { new Guid("77a24075-7312-4053-a56a-bfb5be22d52c"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2537), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 17, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2536), new Guid("9f7cc9b7-6f45-44d1-af73-40c507175045"), null, 0 },
                    { new Guid("c2732d90-7478-4838-a48e-081ead74dc2f"), null, new DateTime(2025, 1, 11, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2544), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 15, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2543), new Guid("33435f01-659e-43e8-8b1a-7b29b261c7f6"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("013f6339-7ada-4dc5-99af-ad2a59fa7e95"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1829), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("016415a1-888b-4f11-ba00-d9ed8131acb4"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1704), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("033fe61d-b35a-4cff-ae4c-e725653aff69"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1711), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03dc4202-6a5e-41a5-bafd-05f725d9f7bd"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1667), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04c6a0c1-a2d5-40e4-92e0-016fa08ca501"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1817), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("054f58e3-2bb6-4a78-a7fc-40b20545588b"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1547), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("055af18b-6472-4c1f-bd29-4fe0d0fe72a6"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1881), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("080c56e6-aad8-4470-b2ca-aecfe7df5452"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1803), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("085025f7-3511-46f6-a4e7-2aa7d8622fd1"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2115), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08a2ace2-b009-4fc9-ba74-e2d164ead310"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2172), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a37bb25-82b2-4105-b129-7e0a36e4a35b"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1874), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b8c5c06-ee50-4d45-b270-0648640d14b0"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1614), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c19d014-2568-4e27-86ff-30d84269e9da"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1648), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cfd545b-34ac-4b8c-bbc6-b3fb63fcfa2f"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2056), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d047ffe-a426-4b22-a0f9-fe1e12550679"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1604), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ed485f4-c350-4183-b60c-abfc6634d999"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1602), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f690394-eabf-47e7-9aac-6fedbe21e2d8"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2073), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fbded4f-54ce-40be-a776-7a396e68cf0c"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1770), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10db72d2-32b2-4c75-956d-e98435e2ead0"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1815), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("129b9d56-cbe5-4584-b346-7c1b63137823"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2063), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18f7e0b5-5a9f-41f5-aa03-074a8801d978"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2105), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b5e1e1b-17ba-40c3-aec0-ef603dcaa358"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1773), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1bd613b0-9d77-4d08-988a-bf570e7cc32e"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1940), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d490d1f-e9f1-4ff3-ab4f-487ab5b78703"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1719), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e34d493-142e-4e2f-8721-bab85eeb0ebd"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2004), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20437c05-50f5-4743-9a87-c3d02d925b9d"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1820), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2066bf27-08ad-4301-a89b-137d13c52df1"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1902), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("207bc338-449c-4efa-87ff-db7712a64d2d"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1764), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("227ca09f-0076-453e-967e-cb87548f38f1"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1761), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2380c5ee-7370-4dee-8fab-2468bace2625"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1840), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("238940b5-fc1a-421c-bef4-6613136bb3a0"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2114), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25bf2b37-6be8-408a-bebe-a975fdafd241"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1949), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("263909a3-44fd-4311-87c0-534a7132a59b"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2164), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2693cbb1-63e7-4efc-a092-115f01db1ad4"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1938), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26d3c91a-b424-47d0-8b70-0c16ac1fc5bc"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1598), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a116489-c9dd-4f2e-8908-77bf67903209"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2132), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b2a90df-3fa2-4e49-a5ae-e7457bd0fdb3"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1893), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c2e3325-e9a0-4d32-a3bc-ff95f3de36a1"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2021), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c4e6649-7c7e-4b0b-aef0-ae7c66d84732"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1777), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c90fd2f-490e-46bf-bc79-a86f82d1c54b"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2180), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2cd73a45-a938-462e-aeb0-c27ee48912f9"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1878), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d1879d3-ac63-4c77-9007-1f2f9b875432"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1946), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e585b39-b627-4053-8d42-2ff9e33f1247"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1833), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f6f470b-e99f-4786-925a-d89b6b48e50c"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1672), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f76e241-707f-4d66-b85e-da99fa7bee3d"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1834), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("303ba8e3-8295-4504-bdb9-eae0cf5f7774"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1825), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("315c8413-fb2f-485a-9fc9-f8ba652c8d9a"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2070), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31781605-91ad-4ca9-b2a9-205f4333700d"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1944), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31f3ef26-01c8-4c8b-9306-49159c928c6d"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2014), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33e877ad-ffa2-4217-9117-ce5f7e22a363"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2171), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("340d72cd-a922-463a-bc7b-7027ac7320db"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2107), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34a423a7-96fe-4e73-bbd0-323878d5b7e7"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1936), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("350a105a-a4d4-465c-98c7-7d5cb063cc96"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1892), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35871a62-c4e5-4d2b-8d26-c0cde665d735"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1673), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3777a4e7-7dff-4855-98b8-b65826724b45"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2168), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38b1ad77-1d35-4bed-9bfe-57ee95a62e91"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1700), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b313aab-31a9-4b3f-8f45-d9b220fed30b"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2121), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ba1b782-23af-444f-b6ea-da21dfc24de9"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1674), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d51fb5f-9134-4f8c-b78b-e20bc1c25c17"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1904), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d5714ff-01f9-489a-a398-a7129afe530f"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2106), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3db64742-422b-4624-b04d-53e822516d38"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1832), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3dd3a325-2948-4727-92f0-82cc94b68eaa"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2126), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e4b49c1-7cc9-4c1f-a260-7908a11d503c"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2062), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ed4b46b-1ee1-4350-9163-639a71527872"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1990), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fa06912-ff29-42a8-a3da-3e0f0e0abb74"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1926), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40b82b75-85b1-4d1e-9fae-a84f0125ed5c"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1593), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("440e26b4-96a4-404d-9aa2-294b6fe4d00b"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1616), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("450783b5-8e80-49ab-86cf-29ad15650c48"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1884), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48c01968-d6b6-4aa7-bbae-9c45e82b0e6b"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1644), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b70d5e5-eda9-4419-8944-c896c2e3c8f2"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2117), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4bf0c94f-1b39-4837-8f81-e0c26eb190a3"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2128), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ce1e68e-d31b-4dac-a025-733537fd7d1d"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2124), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4db61dbe-1854-4183-ae9b-2a2c2a1a290e"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2052), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e7bff70-c18b-4b42-82ec-bbea724e11a7"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1934), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ed5bbe5-2bd6-44bb-9a58-b0f66d028c68"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1775), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4fea056b-bf96-4bf7-ae26-4c8b1a0fbb61"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2017), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51ceff0f-14a9-444b-a127-6a4341441537"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1807), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52fa0be7-89e3-44b5-adf7-577dfbfd88a0"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2051), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5480d71d-86bc-45ca-aca5-74a2f7e5d23b"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1960), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5486c022-375b-4711-ab8a-1cd20b315409"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1957), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54e07cfd-3ff2-4fcd-a282-19e57593efed"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1816), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("572cc6fa-0513-4462-a554-703f2c8fa195"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1998), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57a45abd-7c80-4862-bba9-a957346487e3"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1655), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57e97383-7e20-4ca7-bed2-ed567850e184"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2155), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a615304-2a50-42ff-95ed-6ed423fa9d71"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2118), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b93d405-5875-48cf-aae6-d0a4bf2f0ffc"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1842), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5bafd310-0993-4935-8dbf-680b8701f17b"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2110), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c25f3d1-0186-440c-a04e-1eaed123d546"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2047), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5dec6ef1-eca1-4b44-a22c-2df3929fd00d"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1931), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6153a989-fed2-4aa5-a994-a87e9bca8bcc"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2176), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("615af126-c7d1-469e-8e57-dc4128c308d7"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1708), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61c21f57-8880-4b26-8850-d1cd12ff6be1"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1717), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6451153b-3782-47be-9036-ac3b9e68ca79"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2077), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64bc1203-e6d0-4b4a-9ae5-ff4005cda3d6"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1669), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64e1dfbf-14e0-4eb6-896f-1bff7aefe1d0"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1772), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65765f27-e74c-4b6f-a994-3fe950d07d5d"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1897), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65d31188-1b57-465c-9902-87ed42e93c84"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1653), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6775b2eb-34e3-4ed0-bd1e-889a697ec6b5"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1771), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("679bac38-41e1-4568-a4f9-bfa308d434d1"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2009), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6cad0425-4a4b-4ecf-b8cd-074bfd1de46c"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2058), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6cdab928-4924-45a9-a0f2-f33265959624"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1607), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d0474c4-b4d5-4910-b7cb-bb8cda87c4c2"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1828), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d15f9dc-cb7b-491d-9641-53d1df9cf7dc"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2162), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d569c70-1624-42c3-a589-cab9027d6dc5"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1888), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e70bfa1-c4ae-4856-baed-2e73c8498067"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1586), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f458820-3afa-4dc3-a0f5-cdc81f5a48dc"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1987), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("703785a8-5188-4953-a07c-93e448e1efb9"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2076), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71030394-88ef-4954-8699-65eb56128765"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2011), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("733fb54f-4715-46c8-b78c-c380d5081507"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2103), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("752485b3-6deb-4fa9-9433-dfa54a029c43"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1988), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77b2796b-e611-495f-8f3b-57af5d61af9b"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1758), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("795edb7b-bc25-408c-a6fe-ff6acc4a4a48"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2000), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79c98d40-3138-4ddc-8fc5-78548a7f4d24"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2122), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a6af04c-8b2a-4b69-b145-d97d4d5acfcc"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2113), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a6c3af4-6cf2-4e68-abc5-03066faaee2c"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1929), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ac88c64-0fe2-4593-96c2-1f3dbba368fe"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1824), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cb7e1d7-4112-44fd-abb5-9dfa1c43982e"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1876), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ebfdfe9-d713-4ae4-94f3-8f9cc7f7cf72"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2071), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f203f10-6f97-4633-bc71-1e0bf309c17d"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1694), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f5c731d-d39c-4f8d-a948-113d62afb462"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2102), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("803d5375-598c-416d-9aec-d03e85057cc6"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1640), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83eadf5b-af58-4b22-bb2a-351dc231e9ed"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1900), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84a5d36e-1349-4eca-9c8b-d49d2996f68c"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1710), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("876b2ec5-3529-4c15-93ad-d936d97ea15b"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1609), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a6a4296-01fc-42b7-8611-6ade79c66564"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1835), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8bd67480-c8b7-4f00-9286-5ab3be0add47"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2175), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8cc39aba-293c-4544-8936-9cb560a81255"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2170), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d26b329-e43f-463b-8523-5dd08ff2110c"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2068), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d3ff895-2262-4dc6-9b61-86f0bd28468e"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2001), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8da6c49a-cda1-4f4b-a7ca-be58ccf376ea"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1697), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ec1866d-5347-4700-b0f2-9132a7951ffc"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1664), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90ea3ff2-56c7-49da-bd83-2772ddcfbd54"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1718), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91681fe2-ad4b-40bb-839d-24a57544950c"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1749), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("924ff890-5457-46fd-bfeb-e64220e545e0"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2075), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95f23a3d-2825-47a2-8090-aedb8f39b574"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2006), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("975b409a-9464-4295-b8fa-f2ee28d17b3e"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1661), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97a6d296-ec8b-48a1-bc5c-7105533f04eb"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2003), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98221c34-f9cd-49b2-b4e6-f0a9501cb1d9"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2060), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9822bab4-1af4-4bb6-83c2-b1df0cf8e6e1"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1707), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98330a05-d8e9-49e8-a818-41d132fd07f1"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2050), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99ee6fc7-8324-44f0-8045-52ee5849463c"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1665), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a8c44dc-2f02-4bb2-99a9-32026f47ef09"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1590), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b3693c0-a080-42cc-8e96-497c6b18941d"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1943), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d2e03cd-2bac-4905-904b-9b9390fa1078"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2010), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f53b87d-0063-430a-9a4f-a61b5a44ea04"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1924), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f66c9ab-2523-4099-a907-abef7b30810c"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1942), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fd2ed63-7b24-4385-94dc-42385e79704b"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1830), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a017b5ba-6930-47df-baf4-85d99662dccc"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1814), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0cdca87-b949-4979-a9db-ff653e630830"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1999), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1aed480-94ed-4be5-a995-3fbe384e2398"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1886), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a357af33-723d-4bba-af49-27071e905974"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1747), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3d47802-b763-43ab-b38f-39fff256d60d"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1952), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a425ef20-57f2-4092-af1a-839be15569ee"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2130), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4b1f2ea-36a2-4df4-a673-0c9ffa0d91e6"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1766), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4b92c89-0338-4a39-8139-7882a0d14292"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1896), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a562bad0-c7fb-4238-a511-c2c57aeeb16c"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1762), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5b7519a-6c89-4398-9f9b-482b3906abe6"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2160), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8b3a865-8c31-4989-a1fc-1905a5d0bb76"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1782), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa3e520e-bcd8-4f7a-85e4-1c3d07a6034e"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2048), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa60147c-e890-47f7-8fe0-34086c0df0dd"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1668), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("acbcfee4-2b3e-4d67-87c4-00150f5a2867"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1776), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("accfa97d-6213-4e88-a93b-a32f44c62579"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1780), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("adc1d268-937b-4a41-a416-784aad3e4a21"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1723), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af1fd681-9347-4e1e-b8c4-23d6f5c41d6b"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2133), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0c75c78-4a87-4adb-acb4-07a2c678c492"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2174), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0e78d26-2f2a-4833-b462-e55110c6e2ba"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1933), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1ce1b1e-41c8-4517-9421-8a9c2657d2db"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1760), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b274f581-8122-4bb0-a797-7689671f1483"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1903), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2919a00-e97c-436c-b6f7-f15b5a50b0c4"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1991), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4481066-1f72-4c20-91f1-5be4be053b4f"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1986), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b551241d-5b75-4616-95cf-9695cb4caf48"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1945), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6007ec3-efe6-4984-8798-f30f8a3d1584"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2064), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b68ab1fc-f2e0-4c58-845b-5d3eb2584355"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1702), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7d19bdf-a55d-4b0a-81b5-904f49c976e7"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1588), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9a1843f-200a-4901-910f-51dc90393712"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1613), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcf20bf9-3db1-469e-819c-7e34fcd113d3"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1584), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd45889e-ad90-4af0-a44e-07e415a217e5"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1935), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd5c1eb5-d029-48b1-825f-356757295a9d"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1647), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bdcf692c-e1c0-4fe6-87a8-efc44d369cbe"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1993), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf164bee-174e-4d45-8a38-dca0ef4a23fb"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2129), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c03aba47-2c95-4bfa-86b6-5b47110df8dd"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1812), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0ee064c-9c16-4316-a640-2700ebc29e20"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1600), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0f53165-297c-4a6a-9ff1-5db10372a2a2"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2005), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2411e86-032b-4655-8586-43d70bfd14bf"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2059), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2b626a1-770b-4755-ad10-bf624b475a0b"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1663), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c34a9cec-3025-44b8-9282-4e35533a0171"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1595), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4680827-dc92-4520-9e28-a50bb866ecf8"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1769), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4866ebd-3917-47cd-9c59-b2e3775a3a74"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1953), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5b37dde-73a4-442c-abd1-797280f80808"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1754), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5da02f7-cd88-4a37-9693-ac4ff35920fc"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2013), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c60a2246-9270-4e47-ad09-d980e3d5868e"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1948), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c71e976b-3cec-4eb0-a6bc-72c26d703a5c"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2109), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8fec6f7-1f99-4fdd-94ce-b53c21b0f7d5"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2127), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca622626-b025-4166-bbba-9f56aee003ae"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1890), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb54928c-3239-4d5f-901c-98481301a058"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1716), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd5e6946-e19d-447e-8e4f-8b23369d41d7"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1705), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd865df3-fd9a-4f49-84cf-1556e77a5ec5"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2179), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd93e878-f79d-4394-82d6-db4c268c26c1"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1751), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cda8fbc1-ec36-4616-8e34-c31df4df25a8"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2045), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0a23e47-1782-4b49-8a96-7fb6cb7184f3"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1610), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d16a5d24-8f22-405e-9c3d-c5fae1c6c431"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1727), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1cfdb90-cce6-48d4-b46b-09297d26719c"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1753), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3d3c653-420b-42bb-aafa-905a957ebaec"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1725), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d404dcdc-b805-4885-af48-4129629593d4"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1805), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4af9671-0cf3-4893-a2d2-81fa45acb244"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1891), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6320e24-e4f2-4f25-8092-ef01c2a701e7"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1809), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9b2134b-5047-4d74-88b8-b7b6e1118a5b"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1781), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dac14cce-742f-43ac-85f9-a9ff2f6a8eb9"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2159), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db388233-2466-4543-b3a9-e12e9623e103"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2044), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db871115-3273-4616-b8eb-52187aa4cd9c"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1696), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbdb97d4-56c5-4700-ae18-27c34de65433"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1958), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc56f339-c8d6-4030-a634-ba5fbc902ede"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1750), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc61ccf1-8588-41e7-89f9-ee1bcd99dea9"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2119), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddd5f751-bd6f-4b2b-8212-d079bc071b39"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1660), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df232856-78a1-4ceb-8e18-96a2d69d30b6"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1930), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e05758a3-b223-4876-8b38-b64e1e95ab87"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1722), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1f06a3c-233a-4c88-9b8d-d176456e2736"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2016), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3219050-2051-4a2e-ac8c-9b7f42e2e26b"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2018), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3b9689f-686e-4a03-b528-f52892a80685"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1992), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e47ed0b9-9460-4c88-9c78-d31af48e91bc"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1757), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4c1388a-6342-450e-8949-12f1c90b100a"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1698), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4e3efc1-1f69-4e68-9b40-37f21fa8376f"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1641), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5b309ae-ce25-4635-92b8-456c8f12efbe"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2163), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e77211bb-5c83-4113-85ae-fec4767f5209"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2074), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e989e386-0b3b-4f58-a8ca-a2611cd33a14"), "E", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1955), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea5391cb-29bc-46b7-9b6f-0c9848cd07a2"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1657), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb8ca5f5-de8a-44b7-a6b3-9c28f8ec2f71"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2080), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec5fab07-98a0-4b99-842d-48d5446a2d7f"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1638), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f044c903-cfe4-4dd9-8bf4-94d36ecb4e8d"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2065), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f07e096b-618a-404c-8b80-1715f7631f4e"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1887), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1123e36-ab39-436d-9610-f550c4461dd6"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1839), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1749b48-7414-473a-9fc7-6861170d3060"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1720), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2976adb-14f8-466c-bde6-ee41d7a3a6a6"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1995), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f29c1288-9ec4-417f-9f39-12ee9f928300"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1954), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f29c7ac0-d9fa-4a04-9628-a0732f80afeb"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1606), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2efce38-d3db-446c-8ec5-b5cbd85d35f7"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2167), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f359a629-75aa-41aa-83d6-2907447f8827"), "J", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2182), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f45ae0a2-bdce-4aba-a9d6-0e09fa5dfe32"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2156), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5dc5ab6-56a8-4aa5-8905-45ba16901856"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1763), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7b63a29-8ac9-434d-aec1-f3720369dd56"), "I", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1654), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7d0d9bd-c6b3-4f9b-b9e6-bb36297ac4e8"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1714), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f853d75e-4cbb-4432-99d7-a51b0c7deb08"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2158), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9554e26-3adc-40e6-852d-3551d962424b"), "D", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1808), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa5caac2-0729-40b8-a52f-a322f3211a23"), "C", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1709), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fbc5f232-7c1e-4f80-ae15-39c9d091921b"), "B", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1643), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc50dd5d-358b-4ceb-ae15-6a589f70740e"), "F", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1650), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fcee27f0-37af-475e-8221-e1e49edadca7"), "G", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1651), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd3ce92a-9d17-423b-b733-c460c8429602"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1880), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd9347e8-e4d5-49b0-a7a7-2db179b0cd09"), "H", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1959), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fee37b3b-f6bd-4fa8-891b-f67973b949c1"), "A", null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(1836), false, null, null, null, null, new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("5a1bda17-4aff-41e6-9b59-29ba17829f28"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2484), new DateTime(2025, 1, 12, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2492), false, null, null, null, null, new Guid("e660ad37-c745-4ee9-b627-01958c1b13c5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 11, 10, 13, 48, 737, DateTimeKind.Local).AddTicks(2487) },
                    { new Guid("d971e83c-f1a0-4be1-bfc0-2e880f878096"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2496), new DateTime(2025, 1, 13, 10, 12, 48, 737, DateTimeKind.Local).AddTicks(2498), false, null, null, null, null, new Guid("09b149f1-7aef-4b05-b74b-db90ae8f098f"), new Guid("f9288837-274b-4904-82aa-374ca4cef56b"), 1, new DateTime(2025, 1, 11, 10, 14, 48, 737, DateTimeKind.Local).AddTicks(2497) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("1406e44e-baaf-40df-b57d-45ac32fe072a"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2588), false, null, null, null, null, 50000m, new Guid("07373c5a-1c37-4a86-8c5c-8c1f9448c14b"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("5bf89d06-efb5-47ce-b16b-b01e8a313c7c"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("d7bb398a-2fd9-4622-a4c0-a8a0616f85ce"), null, new DateTime(2025, 1, 11, 3, 12, 48, 737, DateTimeKind.Utc).AddTicks(2594), false, null, null, null, null, 60000m, new Guid("257cbfe2-6061-4384-969e-13c97f0fef9a"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("bca51900-8fdd-42a8-92df-b1f402827d5d"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
