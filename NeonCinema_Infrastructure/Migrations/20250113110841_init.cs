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
                    { new Guid("0cdfc9f1-2267-4f77-9f80-b1eea2dc7dc2"), "11:00 PM", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7083), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7076), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1c8f5328-851c-41d0-8e2d-0428ca2681cf"), "Việt Nam" },
                    { new Guid("62d6bac9-57e4-4589-9bba-3c2059a08134"), "Hàn Quốc" },
                    { new Guid("7c1d2745-a419-4881-84e2-9628019bb939"), "Pháp" },
                    { new Guid("8e2c3f59-8827-4467-a3e6-89e5d1f5cfe7"), "Mỹ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("a4bad124-ab40-4a64-8c4a-65c26e1e46c4"), "Trung Quốc" },
                    { new Guid("ac8767fc-aec6-4f32-bf65-fc4aeee7e44a"), "Hồng Kông" },
                    { new Guid("c106a3f9-fb9a-44cd-a1f3-a505f4386e03"), "Ấn Độ" },
                    { new Guid("d839890e-1f41-4f46-8cfb-30cb632636bf"), "Vương Quốc Anh" },
                    { new Guid("ff528e7e-569d-4be5-a501-20fc0154bcbc"), "Úc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("022a564b-4920-4f17-aa0b-92bbaa8a016d"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6880), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("0e24694a-2ce9-4e71-af22-58773bd475a9"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6868), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6870), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("32dc766e-828a-4d78-a6a5-3f9b76ceffec"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6878), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("378e868b-cbe9-4abf-8490-a12c45ea0781"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6863), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("43abfbc3-8c60-48cb-9d60-09f0711ae392"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6874), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6856), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("947fd77f-7167-415c-88b2-2ca85a86e795"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6866), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("c087ae60-c332-4055-8fbd-dbda49663a80"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6882), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("d4adc721-7cab-4cdc-84a1-0a60f3b330dd"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6876), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("09cd3a7c-a3bd-48f0-83ea-b0169fdec7d3"), "Combo 4", null, new DateTime(2025, 1, 10, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8332), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("1462a055-b099-4bc0-b647-e594569f0b4e"), "Combo 1", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8322), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("848a032d-bc97-4c1c-965b-ea52c2bf0139"), "Combo 2", null, new DateTime(2025, 1, 12, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8328), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("bfda1138-bff6-45dd-ab22-26c66269f1a9"), "Combo 3", null, new DateTime(2025, 1, 11, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8330), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1f46d17a-be5e-4fa1-b750-3ccedbf4829d"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6945), false, null, null, "Hoạt hình", null, null },
                    { new Guid("255fddf0-8ec3-49f7-815d-0c575497e1f8"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6920), false, null, null, "Tình cảm", null, null },
                    { new Guid("5cd26ac8-70e4-4fcb-bdbe-f6565f2e655c"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6949), false, null, null, "Hài hước", null, null },
                    { new Guid("7b7bc83f-41c1-4c3d-a164-97dd9c08b823"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6953), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("83eccf58-58a2-4bb7-8dc5-031296cb58d6"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6942), false, null, null, "Kinh dị", null, null },
                    { new Guid("8d45dc01-dfc4-4145-85a3-5fd68b6282d2"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6948), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6916), false, null, null, "Kịch tính", null, null },
                    { new Guid("b63c7377-4bd6-4ed5-abcc-033903179353"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6951), false, null, null, "Tâm lý", null, null },
                    { new Guid("c6d644d2-0ac9-41d2-8c98-6da8a333e7a1"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6950), false, null, null, "Lãng mạn", null, null },
                    { new Guid("f8b64553-529b-403a-b6a4-67e218678295"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6940), false, null, null, "Hành động", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1ac74b16-5279-42d7-8cb0-3b30ac2bd20b"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6821), false, null, null, "ThaiLans", null, null },
                    { new Guid("56db09e3-b610-43d4-ba79-bb95bfd38841"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6822), false, null, null, "USA", null, null },
                    { new Guid("7655782d-4bc1-4ba1-a3c3-d0f2fefc51e1"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6808), false, null, null, "VIE", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6804), false, null, null, "EN", null, null },
                    { new Guid("97012a46-381b-46f7-8679-a8b45bdfe1e2"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6819), false, null, null, "JPN", null, null },
                    { new Guid("cba97b33-2268-4df9-880e-4068f111e3dc"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6825), false, null, null, "Korea", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6197), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6199), false, null, null, null, null, "2D" },
                    { new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(6193), false, null, null, null, null, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6078), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6095), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6093), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7045), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7049), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7040), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1e94d4a5-4e7a-4d34-aee9-6c9437398008"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("50f016b0-85c5-4ff0-9eb3-0f34a09b095e"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("5bc53268-a030-4e71-8d8e-918f1bab7078"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("86d910a8-e7b5-4539-bd00-b50f90e4950f"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("954d71f1-169f-4db7-9ea8-82896f8d68e0"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("a7b6d7b5-e475-48cd-b369-c4ec249ee312"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("b517eeea-9c33-4b0d-a82a-5ce717ae748e"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("bce2b85a-a4df-48aa-9e7e-ac4cd3e73d8c"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("ef50c9fe-ad72-4b83-92a8-97224caee38c"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("fbf4364e-6074-4fb9-a6ac-513ab4a41882"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(8269), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 10000m, 20000m, 10000m, 50000m, 5000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("33365e2d-b17e-4b4c-8085-311550f87151"), 13, new Guid("7c1d2745-a419-4881-84e2-9628019bb939"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8097), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 113, new Guid("c6d644d2-0ac9-41d2-8c98-6da8a333e7a1"), "cuoixuyenbiengioi.jpg", new Guid("cba97b33-2268-4df9-880e-4068f111e3dc"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("5940fbcd-ece5-49b3-a90b-c0c16fb37b8f"), 13, new Guid("ff528e7e-569d-4be5-a501-20fc0154bcbc"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8035), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("947fd77f-7167-415c-88b2-2ca85a86e795"), 113, new Guid("8d45dc01-dfc4-4145-85a3-5fd68b6282d2"), "congtubaclieu.jpg", new Guid("56db09e3-b610-43d4-ba79-bb95bfd38841"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("646fa15a-76b2-485a-a981-123275b9d627"), 18, new Guid("7c1d2745-a419-4881-84e2-9628019bb939"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8026), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("378e868b-cbe9-4abf-8490-a12c45ea0781"), 81, new Guid("5cd26ac8-70e4-4fcb-bdbe-f6565f2e655c"), "xich.jpg", new Guid("cba97b33-2268-4df9-880e-4068f111e3dc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("9d02540d-dfd5-4796-83c0-da747ee8f77c"), 16, new Guid("8e2c3f59-8827-4467-a3e6-89e5d1f5cfe7"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8059), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("f8b64553-529b-403a-b6a4-67e218678295"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("a0f10aae-7529-499f-9015-bd16825e9968"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8088), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 100, new Guid("c6d644d2-0ac9-41d2-8c98-6da8a333e7a1"), "chayngaydi.jpg", new Guid("7655782d-4bc1-4ba1-a3c3-d0f2fefc51e1"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("a7019180-d932-4f6e-9cac-18e7606401da"), 18, new Guid("8e2c3f59-8827-4467-a3e6-89e5d1f5cfe7"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8125), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 127, new Guid("f8b64553-529b-403a-b6a4-67e218678295"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("a798a442-06a7-4f03-91d7-c25967374234"), 13, new Guid("ff528e7e-569d-4be5-a501-20fc0154bcbc"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8066), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("378e868b-cbe9-4abf-8490-a12c45ea0781"), 120, new Guid("c6d644d2-0ac9-41d2-8c98-6da8a333e7a1"), "botubaothu.jpg", new Guid("56db09e3-b610-43d4-ba79-bb95bfd38841"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("b1cf95d9-91d0-4159-bce2-ea9b07ff67f2"), 16, new Guid("7c1d2745-a419-4881-84e2-9628019bb939"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8045), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("0e24694a-2ce9-4e71-af22-58773bd475a9"), 109, new Guid("83eccf58-58a2-4bb7-8dc5-031296cb58d6"), "yeuem.jpg", new Guid("cba97b33-2268-4df9-880e-4068f111e3dc"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("b458ec27-1781-4c4c-89d4-e63b678718dc"), 13, new Guid("ff528e7e-569d-4be5-a501-20fc0154bcbc"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8104), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 123, new Guid("5cd26ac8-70e4-4fcb-bdbe-f6565f2e655c"), "kinhvanhoa.jpg", new Guid("56db09e3-b610-43d4-ba79-bb95bfd38841"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("bedc4e47-6d06-4c81-93bc-9dd99d3460cc"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8073), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("947fd77f-7167-415c-88b2-2ca85a86e795"), 110, new Guid("c6d644d2-0ac9-41d2-8c98-6da8a333e7a1"), "tretraukhongduaduocdau.jpg", new Guid("7655782d-4bc1-4ba1-a3c3-d0f2fefc51e1"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("d54e6883-1b56-480e-b01a-6074c2de1670"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8052), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 99, new Guid("5cd26ac8-70e4-4fcb-bdbe-f6565f2e655c"), "tetamhon.jpg", new Guid("7655782d-4bc1-4ba1-a3c3-d0f2fefc51e1"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), 16, new Guid("7c1d2745-a419-4881-84e2-9628019bb939"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8017), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("5cd26ac8-70e4-4fcb-bdbe-f6565f2e655c"), "ngaiquy.jpg", new Guid("cba97b33-2268-4df9-880e-4068f111e3dc"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("f0e79193-583c-424c-ab44-f3a2b042b42e"), 13, new Guid("a4bad124-ab40-4a64-8c4a-65c26e1e46c4"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8117), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 134, new Guid("f8b64553-529b-403a-b6a4-67e218678295"), "cuocchien.jpg", new Guid("97012a46-381b-46f7-8679-a8b45bdfe1e2"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("fab7eb4e-961c-442b-85cb-9d1c743b9230"), 15, new Guid("7c1d2745-a419-4881-84e2-9628019bb939"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8080), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("0e24694a-2ce9-4e71-af22-58773bd475a9"), 110, new Guid("8d45dc01-dfc4-4145-85a3-5fd68b6282d2"), "chuyennhabanh.png", new Guid("cba97b33-2268-4df9-880e-4068f111e3dc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("fde425ee-7fb2-424d-9498-773f57e1926a"), 13, new Guid("8e2c3f59-8827-4467-a3e6-89e5d1f5cfe7"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8111), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("1545013d-49e1-4be9-b848-f408bbd4638a"), 118, new Guid("b63c7377-4bd6-4ed5-abcc-033903179353"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("38388304-6e71-42ca-8372-24811c581722"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7125), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(7119), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0493b846-3fac-45a1-8119-2728f925e510"), "Hà Nội", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6747), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("2b57c04a-3f43-4c94-9a41-7f7f9ac8e6de"), "Hà Nội", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6653), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("7e79158e-9518-4ce5-aa44-7f58d41366a7"), "Hà Nội", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6725), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("f4c242ba-0422-473a-af96-c7662e31f599"), "Hà Nội", null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(6250), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("31f9eeba-8ab9-4caf-be16-f0b40cd3c2ea"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8236), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 18, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8235), new Guid("954d71f1-169f-4db7-9ea8-82896f8d68e0"), null, 0 },
                    { new Guid("42190cc6-43c2-481c-8484-b5bf71f89772"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8239), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 17, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8238), new Guid("1e94d4a5-4e7a-4d34-aee9-6c9437398008"), null, 0 },
                    { new Guid("46bc4623-38a6-4190-af49-050f65537c72"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8225), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 21, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8224), new Guid("ef50c9fe-ad72-4b83-92a8-97224caee38c"), null, 0 },
                    { new Guid("5ffdfab4-d23d-4e02-a0a7-635ef5be959f"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8222), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 22, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8220), new Guid("fbf4364e-6074-4fb9-a6ac-513ab4a41882"), null, 0 },
                    { new Guid("7befc02d-43d0-4455-b817-4f4581ad2781"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8228), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8227), new Guid("a7b6d7b5-e475-48cd-b369-c4ec249ee312"), null, 0 },
                    { new Guid("a21819eb-8c27-4241-a2ac-72874d2dfb96"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8214), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 23, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8212), new Guid("bce2b85a-a4df-48aa-9e7e-ac4cd3e73d8c"), null, 0 },
                    { new Guid("d9577e18-3117-4140-a554-f562d0e5bfa5"), null, new DateTime(2025, 1, 13, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8232), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8231), new Guid("b517eeea-9c33-4b0d-a82a-5ce717ae748e"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("028fafd0-24b5-44cc-b40d-0f654d56c18b"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7196), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0414dcad-baf7-4be8-be9f-1e8dad3bf4f2"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7556), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b43d6eb-4411-4d00-b5c7-a3c235395af4"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7276), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c071ca8-2d08-45c2-9510-1b0c90a838c8"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7553), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c64cfbe-eb45-4d01-bfbb-2f7ce9a7c583"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7731), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c9a0d79-3dcc-4ccb-9ce9-618d508dcfac"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7660), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cebcea4-0fda-43db-a7cf-e7771bfe9845"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7318), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cfe35a2-1a0f-4d01-b81d-001fdead1364"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7413), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d35d674-aaa9-4e68-ab06-e211eb8ebd46"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7451), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e316688-377c-4492-8f7e-874140d859ff"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7625), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e5d34c4-d951-4dc5-b638-3d86a3a25649"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7500), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ecf4fe7-2b43-41ad-91fe-176915cef606"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7794), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fec5bc8-bc93-4404-bac9-e8324d9e14a3"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7781), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("122c858f-c9f2-4162-bcbb-aec07026bf3b"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7274), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12b60776-2714-4497-abbd-1e962a819294"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7488), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16007401-a7fd-44c1-a269-fe30c7f9fe9e"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7590), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1615698b-4ec0-4cd1-bccb-d766e6d97eb9"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7603), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("169fc922-b5d7-4874-858b-7be259397ad0"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7751), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17044484-2d3d-4356-a2fc-1735fe651f15"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7657), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19b99fd3-d85e-4a01-a10c-9864e76b9d05"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7377), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19ca624d-7b69-412c-9b50-76a3cfd310d5"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7259), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a63da14-519c-42f7-9a76-41a7500aadc2"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7273), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d846d84-3bc1-498e-bee2-828759e4ce07"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7299), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e2a91c4-d4ce-4110-9218-2e24433a6321"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7606), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e7eec4c-3dc3-4eda-98d7-836e353ec79e"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7252), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("218bb94b-997e-413c-b62c-fa963f8957be"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7559), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22218949-bed7-40fc-b0fe-ac65a5826371"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7688), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2239ba87-519f-4d0b-a3f2-75765fbf61de"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7682), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2292eb7c-a22c-41d8-becf-80e0895b78fe"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7361), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22aaa05a-0335-45fb-8fb2-8b6c81987dde"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7692), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("233d3a98-7e3e-43f7-9981-ff42a177ffd6"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7659), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2354ada8-4f13-4b29-988c-fef6d481d110"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7678), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("285a1bb1-a026-47c6-bdcf-577588c2bac3"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7369), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("294a34af-cf55-4f82-ad84-4ce3f3aa6164"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7617), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e1d8249-96b5-4350-ac62-fd7f1461ba63"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7326), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e2afe28-c491-4da9-bb75-4200988583f4"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7780), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e3e8430-7bc1-4faf-962e-d264eb66c072"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7495), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("306f88ec-6d4b-4d6e-9be9-e5b220aeff45"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7683), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3369853d-6a62-4fb5-b3c6-fcab08784d8e"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7308), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("338e815c-359e-439f-825d-6526df8ea20d"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7382), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3417d3c6-2cdc-405b-8116-cfae357c3e6f"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7566), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("368d38c4-f760-4421-ba07-8469635f5d63"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7234), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36da3501-3cf7-433b-ac09-43c916542538"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7815), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("385f6706-667e-4a12-b432-d66193f2ee11"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7266), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39a5b9c1-565c-4af2-9c02-da10aa735186"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7536), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a91244d-929e-4f36-a58d-14bf85c5a56a"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7314), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b6b13be-8e0a-45cb-897e-079391f5f815"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7367), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e5463c7-5afd-4af7-a91f-241ae3ece2eb"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7501), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f0b92e3-43ad-43f3-9329-996056d143a3"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7697), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4073b73a-303a-4f6e-83fe-08a020951cd3"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7564), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40a4fef5-8a53-4669-82e5-877dbaf13479"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7666), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("41370619-808d-46fa-96e7-5f085e778292"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7329), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4471327a-2511-47e3-8224-53131ebfccc9"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7594), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44cd3045-695b-4d37-8c29-e86f01edc98e"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7663), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45875edf-ae84-46d1-9ecd-4c12cd875dd8"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7539), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46d380d7-d0e8-488b-9be2-505542464f4a"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7612), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47103310-6d3d-4045-a235-e19038a4ffd7"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7447), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47fd4d94-d978-4217-82b5-0eae8720c285"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7426), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4904dfa2-ac6e-4a9c-a24d-0b391c81f147"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7453), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("491cdfb5-b0ab-4478-8052-dd3bd62fbf65"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7311), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a89eec1-8699-473d-a5fe-6deabce5faae"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7502), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a92ba48-e58b-410e-a6c0-9aa0d12b8108"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7251), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4afbec89-23b8-4ab8-aa6b-35c247d3eae1"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7332), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b017b13-60a5-42b3-8db8-8e2f1693584a"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7841), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4bd0f9cf-76cf-43e0-a02b-cbd39ab4e66b"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7787), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c965f3d-48e8-43cc-89e2-c7012a188afe"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7759), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d8b7ecc-3bb0-43ca-ba95-1bce8f2dbc76"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7388), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dd73e70-5923-499c-964e-9e11db98785e"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7739), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dfcdd5c-645e-48a0-9e47-3ba0ca12a7ea"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7333), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52c4dda6-8e28-4580-88b1-cf16cbb71328"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7515), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52ec9c30-5ae4-4c62-b739-0537181f7fc2"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7784), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5517a7a7-999e-4afa-88ca-20d3986a65ed"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7812), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56325f3c-7df6-49c9-bc03-115fd19fa448"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7803), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56390e12-e32c-474a-98fe-9ed56eba3b7d"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7628), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57fa3261-2c53-4f1e-834a-6c183add1c9f"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7366), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("581750fa-6bcb-4733-916c-5716a0709790"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7549), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59167312-8953-4380-a22e-d00ff63b4982"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7360), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59186aaa-647f-4f14-99a7-1a27cca051af"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7662), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a4393bd-94fa-4f95-ba96-71077de7dd4a"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7756), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5aa9d481-3703-4831-af1f-44bd83151b64"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7414), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b9ac692-0c58-4c00-81a8-e46137869229"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7550), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5bbd5acc-f2eb-4839-baaf-fec5b6c6d0c8"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7357), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c5526a6-ea7d-482d-84d4-070d2e5d3488"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7563), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c61978f-da5f-44e7-a119-fb2585e464df"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7443), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5daa834a-3e6f-4e3c-a4ff-5f173f6a1796"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7420), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e88440e-946b-4109-9de2-a9a822bc8ebe"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7474), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5eb12dac-1b26-4548-a104-69fd8727d819"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7677), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f18698b-0140-43e7-b41e-48f925cf3d4f"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7673), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6000b2dc-b131-4f81-8ce1-10589c137629"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7428), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("604ccb25-092f-4d09-9d8e-bea492211982"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7492), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6193d72f-52ad-49e2-918b-46acd6a5c257"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7690), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("644eda02-1aa4-40e4-b653-d5deebeba81a"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7504), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64ab8d4d-f4ca-4f36-a7de-05c03ed6a01d"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7597), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64d94d4f-635c-4441-8b57-bbc1eaa90708"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7438), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66122040-c63c-4e91-a56d-a9cc27f59ffb"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7796), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("667cfc04-40c1-4575-bc2f-5bc06c962146"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7793), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66c96ba5-330c-4608-9772-022cce38e0a3"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7432), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6735d1ef-e1fe-4615-ba3f-6cca5fa44c2c"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7675), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ebcdc4d-9203-4da5-bbd2-86ee38d0b4b0"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7485), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70b82a79-7349-4a38-8eef-dce57488aa4d"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7477), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70c7d76e-d70f-4295-befc-b0c8f4a8b594"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7754), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74a5f8cf-826a-408a-b209-71f5eebef96b"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7835), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74b71b73-feed-4dff-b3be-6de6c7b7da5c"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7544), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74f8b6aa-f431-43d9-8a11-a5f19473c7bd"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7561), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77f465ed-8ef1-44d8-bfb4-cfd2eea8e19d"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7685), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7811ec4a-c22b-4b19-b7d0-0d1d1886221a"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7798), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("785dff56-cfa9-4fbd-9334-998200c2b6a5"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7486), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78e63ad5-14e3-4d42-932f-e0dfb6d02f47"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7155), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79be5398-f256-4fa3-b05f-91dc0fd92084"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7808), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a0dbaab-0a72-4095-996f-d3bdbf5c0151"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7618), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b4c53b1-a4bd-444c-83c3-d15207308f52"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7740), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8002bf30-a09c-42c5-8758-38361bf167bd"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7263), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80e1e358-aecc-44fd-b10d-3ef56ea9e800"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7514), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("818f1ccc-5527-4ade-a354-26ce75ef226d"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7724), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82dc2403-310c-4d49-9a58-06f04852a9fa"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7800), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84350315-4d19-4ba0-89d1-557d492f198c"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7258), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84744fc1-b2d8-4488-b2b5-36396f46fa15"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7755), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85057dda-ee09-4cd9-b5c8-a0cd586c7762"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7616), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8709f67f-bf0c-47da-b7e1-0bac47ded9d3"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7744), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("872f68cb-5761-4084-bde0-67b9fb52c8a3"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7806), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8762cb97-be67-4806-b511-2d852352456d"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7239), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("892c779e-6004-492e-90e7-4c52e294f2ee"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7384), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89b4045a-61d7-4498-b09a-5e0fa889cad2"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7505), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89eabd27-2b58-423f-8cde-67197e240a57"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7778), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a5c0c85-0f50-4b75-beaf-5a2787994919"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7237), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8bdef70c-327d-495f-9560-5e984d6959f3"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7837), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c3aad7b-9bde-473b-9852-420c3e49739c"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7546), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c3b07b0-0602-4210-8d81-396fc3b8e2bb"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7506), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d84e15f-fc07-4b45-a33c-e4b04e1007d4"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7437), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8da8a5b6-a3af-42b8-9c74-434f4fb33767"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7494), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8deab92f-8972-45cc-b11f-55aeae96c9cd"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7847), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f5daa9a-154d-43ca-9e16-8c2c3a5b53c4"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7324), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91700151-2121-4cde-946f-6bde7a54cdaf"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7748), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92ea817b-ae10-4174-84d7-4db049d90cc4"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7439), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9368f462-a3e8-4feb-9a63-b3ff1761632e"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7249), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("954f71f2-bc8e-41cb-8555-bbd639ffa5e9"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7621), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95ac1fba-0314-4544-9b81-fa098ff12d0a"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7231), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95d3d247-490f-4650-8f9e-c1fcb7c29d97"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7445), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95de9139-aa8e-40d6-801c-cd96453139b8"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7669), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9682c1ff-b00b-4bc3-87ec-cf78d736fac6"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7325), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("977bf2b7-bdd7-451d-a370-996364039931"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7792), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98d95a17-7c5c-4ec1-a953-5143d6539b41"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7844), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98fbe227-f71c-45c2-844e-2a8d00347055"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7811), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9979acd7-5152-42c2-bc5c-badeaf407880"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7419), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bff4b3b-1d01-4651-a2f9-a4073ce6445a"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7423), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c62fe65-d600-452b-a1fc-3e22f0caa0e9"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7611), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d9f788a-b654-458a-b529-d025260902cb"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7312), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f8996a5-09b6-4872-b862-e87cc624addd"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7810), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9feac460-c46d-445b-9fe9-76230007bed0"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7736), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4263725-bfd0-4e7a-8973-a04e4a83be93"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7542), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a529a58d-89f4-45d1-98d3-c30c2bd00603"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7309), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a64d4216-0fb0-42ce-a056-df0ccb324bdc"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7322), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6c6d6ca-b8b0-4f3f-9c19-dd16ea46d79b"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7850), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6f311d5-742a-42c9-b098-015b8c6fdd72"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7391), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a710d41d-eaea-4660-8125-388fd1675bbc"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7381), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7cc674d-83dd-4402-91ae-0483a400aff2"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7264), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8d065a9-3493-4bcb-8178-9ffb14c0d708"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7321), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8e80671-4127-4e04-9e14-31e5412abcf5"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7508), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa822e33-5887-4e91-853a-08f6738c5fb2"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7254), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("abf73b8e-7945-4265-aed8-a21793f90552"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7371), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac8180ed-9630-424c-bec7-17404a1276c3"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7194), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ace928dd-4557-4cb0-bb5c-3e0d58452a1a"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7491), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad156823-fbbb-4fdb-b4bf-d65b2eae7e78"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7243), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad62fea9-92d0-404e-aa0d-3ff9f9708290"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7695), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad880758-5c9c-41b9-9791-3d4c4625d729"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7665), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b04da2f0-1614-41ab-b866-17f812d0e646"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7499), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0eb0f27-bb84-40ed-8d03-efc4500d687b"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7734), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b422bfe2-3436-4d88-add7-a582cc94e773"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7272), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4371640-7906-4db7-82f7-3356fcc8f450"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7790), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b52538af-093e-4fee-8034-d7afbc5f1372"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7416), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6884f0d-226d-4850-9f0a-92a11c31631f"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7838), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6927e4e-8e81-4b73-a1ac-3808e1a4d22b"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7300), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b74ce65b-9680-4b9a-89d4-0d6efcad0776"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7750), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b86f53e3-2418-4ffb-8d43-07d08b0eca31"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7417), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b935e340-f4f5-49d1-a7f0-8312db1302c3"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7722), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba685f8e-be01-4e51-b5b0-5bcddcb553d7"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7359), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbfcd37b-5972-4db9-a77d-6a66f671ae2b"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7610), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bea3b3bf-d442-42da-ac0c-06bc578c00a2"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7605), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf35b9e7-6082-49a8-ae66-8df4d7986ce2"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7392), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bfbc5d03-6278-4b39-b786-8ded177dd345"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7320), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1717b90-891e-4cf7-91a1-b9f9d6be8c38"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7742), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c17c2515-952d-416e-b41f-cffa8edc59f2"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7316), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2070dbe-1bfe-41c7-af70-741f23bb7083"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7379), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c28781d8-b38b-4577-bb36-a50287e4a9bc"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7430), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c47518fe-3ce8-4ae7-a121-37ef8665dd02"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7599), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c49a1b29-e61e-4b9b-9336-45ab9e861b15"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7425), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c50f4700-9017-4a9b-b560-9f11c2d46374"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7472), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c51a259d-081c-4115-a8a1-7f1417a82d48"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7303), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5443bac-732a-458f-b32b-1cbeed7c26e9"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7747), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5b0aa5b-9b9b-4b33-bac1-51f5d3a7aaa4"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7267), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5fe8d69-0b9b-4628-ab40-75066b154180"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7737), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c612810f-1056-4971-9f8a-57b1b25dfcf5"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7375), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6d09306-202c-4d5f-a521-e8941d39e1c3"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7607), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c76d6bbd-c2f4-465f-85eb-0cd2f0407ea0"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7331), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9079843-a051-401c-81f9-4d66ab93d03e"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7434), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c95d8170-5584-4842-b69c-64b88179a82d"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7622), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cafa1304-94bb-4219-bf9a-4143a65ba4c7"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7538), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb74e3cc-ad9c-4630-a2fb-a3f7b093fd03"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7512), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbf2e2c6-a89d-4518-b71b-cc3a9a2bbfaf"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7552), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc0e17b7-e5da-4dc3-9e00-5b2ad2b1083a"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7446), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc9d4499-29b6-4aee-af61-01ecc3f116a4"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7511), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd0e08e0-9757-40f7-a407-dcbda962bfb2"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7686), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd3a5e99-6062-443b-b106-934b498ec8ee"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7385), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce3b7383-1cfd-4811-adde-15a1fee74279"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7431), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce948495-70a1-4677-94e2-dcf84e618d25"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7307), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d04a7cbc-e6a1-4a52-8620-b2035f5c68bd"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7726), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d19117a3-9bf6-4175-b444-b516c1ee9b2a"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7370), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d21861dd-20ed-4f8a-b8b0-00b510dfd870"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7373), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d25a39d9-5059-4210-ac9f-8f13c0906e51"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7681), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d424e2b4-6e1d-4782-a005-e75b78548b94"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7247), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7e90297-906d-4fc4-bd7e-89d9c1bf2291"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7297), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8d28472-82c9-40b7-8221-27b59a3fae39"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7269), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d99714cf-82bf-4f5f-9455-a208fd918b3a"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7728), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9e53e0d-ec83-4042-84d8-a95c79f857ea"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7560), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da1880eb-06c0-49b7-8133-f872cd874b86"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7671), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da5fc861-0986-48aa-8c1f-419bb7f0c0ec"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7596), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbd1c588-f396-4e6d-a784-b6768975bc8c"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7262), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc2d32d2-c482-4d85-89bc-d1e0983e4461"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7783), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddca1c06-98b4-45f4-aa2f-cdeaf22130b5"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7548), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df0a47d4-4101-4088-b68d-c2ec7b3160ba"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7804), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df7790d7-4b25-43de-9c2b-be84292b6a5e"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7558), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df8bbfe8-7697-42cd-aa22-b30a47f701af"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7255), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dfe86e1e-da66-4d38-b12c-49c5e746cb85"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7592), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0830a60-6780-4a56-86f1-4dcad66afc3b"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7535), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0bc89e7-ecfb-4448-be44-08a217d7b2ab"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7245), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1ff9f58-4306-4c59-a5d0-c4c229bd60f2"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7593), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e293a85b-e7e6-4e02-b8ae-21f9136d5f8d"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7807), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e36d29fb-b6ae-4882-be91-81364d103c94"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7729), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e43e87fd-a411-444b-b612-2e0b9ceec648"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7786), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e669da1d-2282-49bf-860b-5502e1a9d2d7"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7797), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e69fcdc3-51be-4e52-bb41-8b554974f448"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7619), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e707e144-62e0-42c7-8a12-320510dd93a7"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7305), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e82b8fbd-7af6-4c6a-98d8-667bace85291"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7609), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eaa0251e-4727-4e5d-bea1-eb38ccadc118"), "H", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7295), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eacf6f00-4eb2-4666-b344-c081577352d3"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7600), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb20a28e-257b-44cf-8a14-cca07a4ba7d6"), "C", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7482), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ebd23189-8733-4aa7-aaa8-5738d30ff374"), "E", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7741), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec1431d9-efe5-483f-a446-7395c4353240"), "D", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7839), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec4d8501-9899-460e-9618-c52c6eacd480"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7674), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ecfb46cf-01d1-4d28-9b78-fb3498418a88"), "J", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7386), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed97edc0-c3bc-40a3-96db-ed413d492507"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7364), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1b60784-2f13-450b-8e21-d0a6b4325015"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7452), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f32ccd64-baf4-4a7f-8eec-5efab63a8e48"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7670), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f54c18d4-3378-4ba2-a82b-20e59fff6d82"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7752), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f74895e2-42f6-4d32-b4f1-6567bf2c3e83"), "G", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7489), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f906353a-1622-490b-85a3-48a2e5b7ea1c"), "A", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7441), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f94b9f12-b256-49e2-aa63-e6aa74702b1d"), "B", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7481), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("faf1eb7a-9115-488a-95e1-5dde5434fcf6"), "I", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7848), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc9eaf05-4cc5-4318-a900-875667d0c917"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7842), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd8cd989-1a48-486a-b522-6d0e79821b0c"), "F", null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(7623), false, null, null, null, null, new Guid("38388304-6e71-42ca-8372-24811c581722"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("14beb363-77a8-487e-846b-7c719eb54cdc"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(8171), new DateTime(2025, 1, 14, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8179), false, null, null, null, null, new Guid("dd0e7cf6-fbb9-4b5f-8316-c8003411271f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 13, 18, 9, 40, 998, DateTimeKind.Local).AddTicks(8174) },
                    { new Guid("c33e20e2-36af-4eb3-953a-b308d2d26b5c"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(8184), new DateTime(2025, 1, 15, 18, 8, 40, 998, DateTimeKind.Local).AddTicks(8186), false, null, null, null, null, new Guid("646fa15a-76b2-485a-a981-123275b9d627"), new Guid("38388304-6e71-42ca-8372-24811c581722"), 1, new DateTime(2025, 1, 13, 18, 10, 40, 998, DateTimeKind.Local).AddTicks(8186) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("21a3b1ca-1b5f-4eb3-8380-5a73a77f7c1d"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(8290), false, null, null, null, null, 50000m, new Guid("a21819eb-8c27-4241-a2ac-72874d2dfb96"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("bce2b85a-a4df-48aa-9e7e-ac4cd3e73d8c"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("8f4bafa4-76c1-423c-9d33-962950d65650"), null, new DateTime(2025, 1, 13, 11, 8, 40, 998, DateTimeKind.Utc).AddTicks(8297), false, null, null, null, null, 60000m, new Guid("5ffdfab4-d23d-4e02-a0a7-635ef5be959f"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("fbf4364e-6074-4fb9-a6ac-513ab4a41882"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
