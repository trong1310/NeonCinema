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
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9045), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("f3695221-65d4-4ae3-aee1-e458f9ef20a9"), "11:00 PM", null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9048), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0b708d93-1c8e-473b-87dc-b88a418b2362"), "Mỹ" },
                    { new Guid("3336291a-0077-4e81-bcb2-3febaa80c38e"), "Hàn Quốc" },
                    { new Guid("42adf1af-759c-414e-8ce4-f292d45b93df"), "Trung Quốc" },
                    { new Guid("48d77208-5237-4950-9b98-82f585db4d03"), "Pháp" },
                    { new Guid("57182296-cfdb-44d9-bfcf-79a778ea87a4"), "Ấn Độ" },
                    { new Guid("86429e3f-212c-4f65-bc99-0e59729508cf"), "Việt Nam" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("96161f82-e6c1-4cc1-8de8-22a0063e032b"), "Úc" },
                    { new Guid("bdc7621a-d167-4f89-827b-c5364895236d"), "Vương Quốc Anh" },
                    { new Guid("d6e8b740-b2d8-4526-9258-3787082b5889"), "Hồng Kông" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("09af9221-4711-4ad7-a99b-818a73e43aba"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8837), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("244a9ebd-ea88-47d8-a08b-f62592eaeb03"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8843), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("3223f96a-7e85-4710-bfc5-9e73c016d2e2"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8846), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8839), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("756f6e22-e493-4335-80ec-937281111224"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8836), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("79715535-abad-425a-adb8-924bc8ecd966"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8849), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8825), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("9f7b3cff-ebf0-4650-b333-32123296808c"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8842), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("a6d6bb3a-564a-48b1-95b0-dbaebc433217"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8831), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b079f78a-a874-4448-bb67-0e60f4324702"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8845), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("15a4fbf6-83c8-4cfb-86d5-0a495eb3c535"), "Combo 2", null, new DateTime(2025, 1, 13, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(418), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("24eaa8c9-6466-4894-bb5c-9737d6e229a0"), "Combo 4", null, new DateTime(2025, 1, 11, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(423), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("30c2371c-af5f-4abf-97df-b2e98b018a01"), "Combo 3", null, new DateTime(2025, 1, 12, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(421), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("a008deb4-6654-46e5-ba94-ca8c0bd394fb"), "Combo 1", null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(414), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1b528961-3a4d-42d3-a3bd-27995497cd81"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8882), false, null, null, "Kinh dị", null, null },
                    { new Guid("478a65b1-119f-4aae-9981-450489b84a8a"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8885), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("6964739f-2a71-4e40-8a16-baa87b2d9b6e"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8883), false, null, null, "Hoạt hình", null, null },
                    { new Guid("6f92dbb3-bbc4-44f0-9838-907cab126de4"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8888), false, null, null, "Lãng mạn", null, null },
                    { new Guid("81b0b29b-1c81-4e03-b65e-3119a38e7a0c"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8881), false, null, null, "Hành động", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8876), false, null, null, "Kịch tính", null, null },
                    { new Guid("9306fd8e-0fa2-4f52-aba6-3256c9b2b01a"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8889), false, null, null, "Tâm lý", null, null },
                    { new Guid("a0703ba6-4261-411b-8a68-d4421399fefb"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8893), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("e1c6fdc8-27b4-4a65-b35b-7618a753696d"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8880), false, null, null, "Tình cảm", null, null },
                    { new Guid("f1d8af2d-4dd6-45b5-b002-d968117e84a7"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8887), false, null, null, "Hài hước", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("02e041ce-8367-4ca7-a18b-893a2c5357e5"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8791), false, null, null, "JPN", null, null },
                    { new Guid("405da90b-6f3a-4465-8e60-492a38d3629f"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8793), false, null, null, "USA", null, null },
                    { new Guid("4f356a65-35fb-4de1-a5e7-5255b90b89bf"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8789), false, null, null, "VIE", null, null },
                    { new Guid("7613f9a5-3ab1-454e-a3c0-95b46da49d33"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8796), false, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8785), false, null, null, "EN", null, null },
                    { new Guid("b33fba2a-9ffe-4bf6-91ec-a86dbf241f80"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8792), false, null, null, "ThaiLans", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8197), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8198), false, null, null, null, null, "2D" },
                    { new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(8194), false, null, null, null, null, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8070), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8091), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8089), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9019), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9020), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9014), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("0466c06a-57c5-4f93-99d0-a76625d0d423"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("063fcdbf-9305-4bd3-8d40-97ab4e95b008"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("16657db7-ead1-4545-b79b-dc72668659c4"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("5a60b692-c4d3-46ac-951d-ef9d2104b003"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("82325602-f57d-4bdb-8602-d44402194812"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("a413c8ea-b44b-41c7-a785-519fbb9fabc2"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("c76b63c6-6b57-439d-9a58-854602b084c7"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("c83dc9ae-f0e7-4e19-b6ff-f566e29b8cbe"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("ee182897-0900-4cc9-acc0-d8dee7b91f71"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("fe5e62fe-196c-48fe-a876-6cc3a4a01844"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 14, 7, 58, 57, 170, DateTimeKind.Utc).AddTicks(357), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 10000m, 20000m, 10000m, 50000m, 5000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("21094162-792e-4001-bdc9-ebfa43df182a"), 13, new Guid("42adf1af-759c-414e-8ce4-f292d45b93df"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(185), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 134, new Guid("81b0b29b-1c81-4e03-b65e-3119a38e7a0c"), "cuocchien.jpg", new Guid("02e041ce-8367-4ca7-a18b-893a2c5357e5"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("5fced3dd-7adb-4862-aac7-9a89f2fa4abd"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(113), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 99, new Guid("f1d8af2d-4dd6-45b5-b002-d968117e84a7"), "tetamhon.jpg", new Guid("4f356a65-35fb-4de1-a5e7-5255b90b89bf"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("6542c09c-0d88-448c-b552-54397b2bacf1"), 16, new Guid("48d77208-5237-4950-9b98-82f585db4d03"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(107), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("09af9221-4711-4ad7-a99b-818a73e43aba"), 109, new Guid("1b528961-3a4d-42d3-a3bd-27995497cd81"), "yeuem.jpg", new Guid("7613f9a5-3ab1-454e-a3c0-95b46da49d33"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("6b647c5c-435e-4234-b276-03202ff1378c"), 13, new Guid("96161f82-e6c1-4cc1-8de8-22a0063e032b"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(172), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 123, new Guid("f1d8af2d-4dd6-45b5-b002-d968117e84a7"), "kinhvanhoa.jpg", new Guid("405da90b-6f3a-4465-8e60-492a38d3629f"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("72a16335-2d20-448b-96ee-d9514a645204"), 13, new Guid("96161f82-e6c1-4cc1-8de8-22a0063e032b"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(130), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("a6d6bb3a-564a-48b1-95b0-dbaebc433217"), 120, new Guid("6f92dbb3-bbc4-44f0-9838-907cab126de4"), "botubaothu.jpg", new Guid("405da90b-6f3a-4465-8e60-492a38d3629f"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("73b6c793-cda4-4d30-9a5b-1e71eaa9dd59"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(140), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("756f6e22-e493-4335-80ec-937281111224"), 110, new Guid("6f92dbb3-bbc4-44f0-9838-907cab126de4"), "tretraukhongduaduocdau.jpg", new Guid("4f356a65-35fb-4de1-a5e7-5255b90b89bf"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("7734f386-3af4-4da6-8719-7ab8ce2949e4"), 18, new Guid("0b708d93-1c8e-473b-87dc-b88a418b2362"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(192), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 127, new Guid("81b0b29b-1c81-4e03-b65e-3119a38e7a0c"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), 16, new Guid("48d77208-5237-4950-9b98-82f585db4d03"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(81), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("f1d8af2d-4dd6-45b5-b002-d968117e84a7"), "ngaiquy.jpg", new Guid("7613f9a5-3ab1-454e-a3c0-95b46da49d33"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("8a1b20e5-d8bd-4e97-af39-6979abbba31c"), 13, new Guid("48d77208-5237-4950-9b98-82f585db4d03"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(165), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 113, new Guid("6f92dbb3-bbc4-44f0-9838-907cab126de4"), "cuoixuyenbiengioi.jpg", new Guid("7613f9a5-3ab1-454e-a3c0-95b46da49d33"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("cef38f66-c442-4f69-8f9d-6f3353c1ccf4"), 13, new Guid("0b708d93-1c8e-473b-87dc-b88a418b2362"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(179), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 118, new Guid("9306fd8e-0fa2-4f52-aba6-3256c9b2b01a"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("d54d5c74-151a-4676-ade2-ddc105793b9e"), 18, new Guid("48d77208-5237-4950-9b98-82f585db4d03"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(92), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("a6d6bb3a-564a-48b1-95b0-dbaebc433217"), 81, new Guid("f1d8af2d-4dd6-45b5-b002-d968117e84a7"), "xich.jpg", new Guid("7613f9a5-3ab1-454e-a3c0-95b46da49d33"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("ef8b3f05-dc06-4cce-b67f-dbbbd91f93c2"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(158), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("63f5a4e4-cc43-42a5-b124-9ea66f5bedf4"), 100, new Guid("6f92dbb3-bbc4-44f0-9838-907cab126de4"), "chayngaydi.jpg", new Guid("4f356a65-35fb-4de1-a5e7-5255b90b89bf"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("f65f0766-89ff-481b-9981-14af3ce2e97a"), 15, new Guid("48d77208-5237-4950-9b98-82f585db4d03"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(150), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("09af9221-4711-4ad7-a99b-818a73e43aba"), 110, new Guid("478a65b1-119f-4aae-9981-450489b84a8a"), "chuyennhabanh.png", new Guid("7613f9a5-3ab1-454e-a3c0-95b46da49d33"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("fd8933b9-c9e6-403d-aa7f-cd83ca675bb5"), 16, new Guid("0b708d93-1c8e-473b-87dc-b88a418b2362"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(122), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("81b0b29b-1c81-4e03-b65e-3119a38e7a0c"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("febaae19-e0a5-4706-ae28-e287c20549d7"), 13, new Guid("96161f82-e6c1-4cc1-8de8-22a0063e032b"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(99), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("756f6e22-e493-4335-80ec-937281111224"), 113, new Guid("478a65b1-119f-4aae-9981-450489b84a8a"), "congtubaclieu.jpg", new Guid("405da90b-6f3a-4465-8e60-492a38d3629f"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9089), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(9083), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("22c21bf8-d723-4a56-ba43-5f772bcd2827"), "Hà Nội", null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8684), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("541e1d70-1ded-44a5-8331-bc2e99ddc66e"), "Hà Nội", null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8246), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8f5468f9-8a47-4630-8475-de0adcf0e055"), "Hà Nội", null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8707), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("9e684648-102e-498b-bde3-21ade4a0a762"), "Hà Nội", null, new DateTime(2025, 1, 14, 14, 58, 57, 169, DateTimeKind.Local).AddTicks(8658), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("1ceceac9-f654-4691-95fa-8e09e7a71a74"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(273), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 23, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(272), new Guid("a413c8ea-b44b-41c7-a785-519fbb9fabc2"), null, 0 },
                    { new Guid("56e1b445-3cb4-4f35-ac54-2a7982cbbaec"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(326), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(325), new Guid("ee182897-0900-4cc9-acc0-d8dee7b91f71"), null, 0 },
                    { new Guid("59ba36e1-4cc6-45b8-b56b-f7b273f3013d"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(319), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 21, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(317), new Guid("5a60b692-c4d3-46ac-951d-ef9d2104b003"), null, 0 },
                    { new Guid("7ae3501c-7ba8-4f9b-be29-236d87d71193"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(314), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 22, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(313), new Guid("fe5e62fe-196c-48fe-a876-6cc3a4a01844"), null, 0 },
                    { new Guid("890d5437-d176-4aab-b749-8bd98ab15220"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(268), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 24, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(266), new Guid("063fcdbf-9305-4bd3-8d40-97ab4e95b008"), null, 0 },
                    { new Guid("9a934266-8269-4ab5-af29-7a482a735cf0"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(333), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 18, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(332), new Guid("82325602-f57d-4bdb-8602-d44402194812"), null, 0 },
                    { new Guid("fc851507-b73e-4938-92f7-30c329e19faa"), null, new DateTime(2025, 1, 14, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(322), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(321), new Guid("c76b63c6-6b57-439d-9a58-854602b084c7"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("016ceaab-c4b8-4c5f-8c8a-a5c98ada2f80"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9428), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02b92af1-be1a-4426-bef3-64d1eeda5635"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9542), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0315e5c8-fd7a-40cf-98ca-69a3fc716167"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9306), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05ab0b84-0af8-4244-a0ab-c4f0cfd58d6e"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9501), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("069cdb44-f9b0-47e5-8d34-416ddf05b10b"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9224), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06baa8a9-5083-48b8-b4c8-8d858c03fccd"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9855), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("07bea668-5fe3-4fac-8e7e-19fbb229ba0d"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9697), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08644e37-da78-49ec-9470-f9a0a31d492f"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9646), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("086a9ffd-f909-4bfc-9f42-b7b1beb11633"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9234), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09662c57-490e-49e5-a383-bd7762c8bef6"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9821), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b5ccfa0-ca38-42e2-aa64-0f6829b65d26"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9214), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f086756-2861-48e0-9000-251cda8a57b6"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9218), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f41b2ea-857c-46cd-8e71-28a0506cf4f7"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9314), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10ec968f-bd52-4a71-9e7d-9f1f93a06c28"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9487), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11cf5ccc-1120-4c0f-ad5d-6c95e9b652b6"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9316), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11fedb88-f29b-47a3-9afd-012a6ba96c64"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9559), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12c78a07-309d-4e2a-acc9-24cc12c37a45"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9410), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1378bf9c-3c69-46eb-9a07-ac594528e943"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9504), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("140bae81-514f-4223-a133-8ec039f8c45c"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9550), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("144b67cb-4975-49d4-8041-56ee33be1d2c"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9354), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15bab086-e518-4bcf-83fc-d7c8a822f496"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9485), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1856e227-61ab-4229-ac4c-414f774c0ce6"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9413), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("191d4d30-73b7-4538-bb2d-4180b3508948"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9420), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a07bba6-4eb4-4655-91a2-ab81aebbbbb9"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9227), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c77124f-cd27-4a02-a9be-ca5effbdc442"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9721), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1df9c29d-80cf-47e2-840e-57418a156345"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9836), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e291375-fc5a-4e08-a999-3b144b8ffa51"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9426), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f31db5b-8f38-4f9a-9cc9-3e5d15508d06"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9493), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21269247-ebf8-43d0-bf47-05e82d941d55"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9885), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21aa8d78-44fd-435f-8bf8-394d8d31cbde"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9346), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21bd6b25-d12b-4007-b561-51000f1365c8"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9612), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22c26ee1-9f56-478c-9cc6-2ee451b494c1"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9313), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22d0de0d-b75e-49ce-85ee-54200a05487d"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9692), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23d01a8e-a6c4-451c-ab85-7ee70e5fea48"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9652), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24d8c3ba-86a0-4b17-bd2f-20b2bfa56823"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9772), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("250dac92-cdb5-4e5c-98b2-97f5a6f11076"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9293), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("297e416d-9e5b-47d1-872d-0d10d1fbf6a8"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9858), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29a62d4a-4eee-4a12-9436-04c774cfb630"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9766), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2aa80753-0081-44d7-b22a-29d67a96c01f"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9554), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ac8e4dc-75fb-4649-9126-c37f43e0b12d"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9470), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2aec497e-6ee5-47ae-a7e0-5a885d51e98c"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9832), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b6ae9f3-4ff7-411f-8786-576cbbba20e4"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9376), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2bab19fc-9939-4049-89ff-0768e4496ff3"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9712), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2bf4e69b-95bf-4e04-8eaf-babe82d097f9"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9418), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d0fe7cd-af03-4b52-a5d7-4e071732aa67"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9768), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d572b37-9ff7-4cdb-818a-660b3a38dfae"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9785), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e7deca4-0d42-48c6-9bca-df3e811a1027"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9437), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e97da2f-073f-4954-b97a-87474ee225e5"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9467), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2effaf2a-1b52-4c33-b833-10300683b803"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9304), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f0b5fd1-939b-4d5b-bbdc-9a0700f93bcc"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9476), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("304bb6ea-8ed0-4991-bc47-87a30f52bced"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9178), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30a5651a-69e0-49e0-af9e-249e32399f5c"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9318), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31242872-821c-4b0a-bff7-1a668e1034df"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9730), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31a22516-1d5f-428a-a57a-e0089e066e9b"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9852), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("367bf4e9-b19d-430f-bb25-5c49c1b8273d"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9496), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a4832f9-3fa2-4824-bc07-35f91a312a95"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9774), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b1ffa2a-ba70-46b0-8cd4-22e423df2767"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9245), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b9f7278-5bd2-4577-b3ae-6f911eaa1dde"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9718), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cf05bd8-112f-4f26-9a46-30f16e7569e1"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9294), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d6238c3-7143-4d63-ab00-0659e9efe77f"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9733), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e7b24d5-afb0-4222-8fed-c8627cd06855"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9884), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f3d986e-a063-4566-ae55-e31e653edd9b"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9650), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("41bb2d6d-8662-4c64-a63e-64e60c2d9659"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9409), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43c5e554-817e-49d7-97f9-b73de851c508"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9241), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4469030a-3f99-4a04-8fed-ee9ae2e95eb4"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9423), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44bf740e-0011-473e-9ac4-959a40570396"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9373), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47232eb5-4335-409a-8aa8-1d5c29946fc2"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9846), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47a759cd-cb05-484e-aa1b-3a65467ff367"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9349), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4966299f-bdaa-40b4-8f43-5bf4f34f4cb6"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9422), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b2e2444-6e10-4111-b662-ecae3cff93aa"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9539), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b3843fa-6a57-4358-8005-2b8ad7f4714c"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9794), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4bf35a96-775b-4a22-8b75-68b8cbb7d736"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9369), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c77cfcc-9e8a-452d-9c8c-f11560edae7c"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9541), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d2c2e31-88da-434f-adb1-1aab30c64e5d"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9441), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d2d9d1e-43ab-4e84-a8b4-28164822e52b"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9789), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e126ff5-3a0f-479c-b880-14ab2211ec0d"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9653), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f20ec22-6249-4358-99b8-9d3dec9c802b"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9784), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4fd84b60-6ab5-4430-bde8-77438ff5f120"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9544), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50ecfe13-0003-4506-a16b-d858e1944432"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9424), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("523bdeb3-387c-4914-9d9c-0ba6e8a07d24"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9235), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52468318-8325-45b3-a700-92fd3c65be2d"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9535), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55946555-362d-4cf8-834a-42671b51ed9a"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9438), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55c756d0-67b4-4cc2-a389-d06db1c3a6d7"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9563), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55f3939d-5531-46b3-ab63-22f3bbcbccde"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9723), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57038648-8d26-4a8f-b6d1-6db396e87eb5"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9614), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("579d0d97-77d1-4409-b8e4-34415d8ef59d"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9633), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57b664aa-8491-4db7-8be6-b57d50cdc837"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9838), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5bfa4847-8de2-43fb-9820-0f7e958b61b1"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9363), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c55a598-5e12-4e27-8f7e-8a00e10b4f04"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9631), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5dfcfa52-8bd3-4a7f-b43a-4443b6acb5d8"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9230), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("607d4c67-3bbd-4d16-88f8-bbba96c30a3f"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9411), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6422e639-0f68-4b63-8b95-7a1632da8b45"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9351), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6644ab32-7dec-44cd-91d4-d1200bf5d181"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9280), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67a003a9-63ce-475c-9301-626d62fdfa0a"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9627), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67e6296b-e5b2-406c-b55d-6b6033ffaedd"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9170), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("689c866d-cf0e-4439-948f-bddf1577d8ca"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9212), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68a8f6ee-6adc-4fc8-8cb0-6a2d5dfacf51"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9228), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a594a5d-8580-46a0-9c43-695fca67e020"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9289), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ec25935-129a-440d-a6cb-d3fe6b24c7ff"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9705), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6efc8909-767e-4e14-a598-1017351c8f7c"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9624), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fff9792-2ffa-406e-94ac-e890f40607ac"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9472), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7048fcdf-d5e0-43eb-b602-faec552c979a"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9286), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7067211e-3947-4575-91ee-c925da90d962"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9880), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70ad2e89-6ff5-4f0d-aa49-661ba33095b0"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9367), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7140a1ad-658c-43db-9f5a-ddf05c64802c"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9763), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("721b5e4b-b366-4f04-8e5e-f1c6f2f067f7"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9400), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("756b7dce-ef23-4fab-a254-2b9ecec5a369"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9618), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("766d2a1e-d97b-43b7-96b6-30dc599308aa"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9848), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77b3dc37-0135-4d8f-a797-c608f4223b68"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9777), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("783d688f-045d-417e-8b1e-d71d3aa85a5d"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9505), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("791b7039-e9f2-457b-be07-eda5bd6059ce"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9365), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a59ece8-be1d-4f4f-93e3-07510468b798"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9824), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a7e2ae3-1871-4521-b8d4-f2fdf74f6fb2"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9725), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b051a29-9441-4aed-9af4-174bd0a51d8c"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9440), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b1cfa75-6402-4d0d-905a-0eca0735b2aa"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9290), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7be4ddda-d95e-4eaa-ae64-1c9cd665e6d2"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9556), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d52b8d7-4709-47d1-9011-cf7f6698dad4"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9217), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e2f7c6e-1710-47e8-a007-6a78b15f272d"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9849), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f471dfd-a073-48bf-a86f-e52d11aa091e"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9786), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f846b40-4438-4924-8af2-39147e018749"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9232), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("804555f5-4813-4449-9301-7879fed6c708"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9732), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80fcf81e-13ec-484f-8ddd-25db70933882"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9532), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("816d972a-fd58-4ab2-aa8b-a613dd099473"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9209), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("821520c8-9240-4356-95c4-d6ad43362947"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9707), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8304c719-debf-4aee-a6de-35a2c7d3101b"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9366), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83a7e0d6-b2c9-4630-843b-4635afc7c415"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9621), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("843ab701-b8da-4510-9416-d293fa7ebc85"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9477), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85d1c57d-946d-423d-afbe-4779bc68a3bc"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9398), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87bb9f73-8075-43c9-92a2-28376984df69"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9625), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("886fef1c-0868-4a93-b79e-bbbd01d59e72"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9300), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88d33578-8122-45e6-9fc2-c3c8b493a3dc"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9628), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("890d324f-61a7-48b2-bac5-8e5bc224260a"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9840), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89386738-ba3f-40be-80ff-cbbfe40ef8ff"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9465), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("897fef4c-4986-4bed-8bb8-918dcfcf8d9f"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9835), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a18adb7-1bee-46ad-978e-e7912360654e"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9207), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a542888-9f0a-40c3-85d8-f8957e1755ae"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9699), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ae84e83-408b-47d0-89e3-77a59853371b"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9560), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b1e854c-200c-4a3d-88ec-24c406620f4e"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9759), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b95d02c-abab-4219-9df4-622a665bb6a6"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9757), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d172a7e-e439-4d11-91d5-47f7c365743f"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9405), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90671ff4-7fbb-4c6c-bed2-29c71177ffc9"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9215), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("919ea302-1260-44cd-8ee6-c5bbd845b903"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9463), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("963c3917-02c2-43f0-937c-7c9e0f548c26"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9502), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("964af683-2ad4-4aa2-b73e-8a3065eb2d32"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9118), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96b412fe-638b-41e3-8f5d-31227a98b082"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9342), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96fe28c3-1c77-450a-80df-0c1fb58c6a63"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9634), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("970dbc26-a4bf-43ca-9a85-dcee7f95e87f"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9362), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98c3caf3-4125-4ab2-8588-282be37a899f"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9340), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99c846c3-9488-40f0-b574-e2948af90caa"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9292), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99fee7e6-8972-4a3a-bdf0-5917f9db45ca"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9415), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a03e80f-f21d-4a1f-8b81-09e85f38e924"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9771), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a122fcd-7679-4214-b664-3b94f6ce802c"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9356), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a37ed06-2aa0-4948-9171-eecd06285e47"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9303), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9adca180-afbe-4a34-8f3e-4abc7cec0067"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9782), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bc89aa6-0586-479e-aca2-3aa11225ac72"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9166), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c4e26a3-5d84-441f-bd15-1fd54c71e315"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9221), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f958268-68fe-4871-9cae-262f4f568eda"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9242), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fb665a2-6a35-4ffe-9cff-db696138cca6"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9709), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fb673b6-8d74-434a-b7dd-526b0dfd562d"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9722), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a01ea71b-3121-4dae-8928-89c4db87bd2e"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9308), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a146a99c-d73d-472c-a7db-faa3378e0655"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9547), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2290bf0-020f-4062-b5d8-5669e74920c5"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9781), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a271d121-011e-443e-80c2-7771215b825c"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9433), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a29e1dbe-d6e2-44bf-9e49-9c0048b3a0ea"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9537), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a38a9324-c8d2-45f3-8f20-46c223245717"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9853), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4043e2d-f300-4903-a87a-8b130b093f09"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9842), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5425a49-d57b-4d15-947c-7191f2393498"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9640), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a61437c9-ca1b-4d9a-9e77-c555e7055300"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9374), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6d98c65-39aa-4600-a478-49cd7e7e0d21"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9474), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9bcef25-738c-49fd-b093-0b343ff960a4"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9279), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab1dee00-7c7e-486f-9dbf-5d8f0402beba"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9702), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("acafee31-e691-410d-809d-ce68608cb97f"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9639), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae0213ca-448e-4800-ae23-0a33783543fc"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9553), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aed80a0d-d9f3-498b-84e2-8061e22092e1"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9311), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af2f9473-0878-4cfd-8316-65d63c008b56"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9345), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b10f4183-d7df-4403-b512-03de1d466e2a"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9528), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1235583-011a-4652-b339-00afb97bb52e"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9643), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3964f19-e918-42ea-a694-63a67abefc7d"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9851), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b49dc02e-73c5-49e6-9197-db8e351e824b"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9860), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5760056-c723-44ec-b586-839ea7dbc223"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9642), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7e4c97e-3624-4697-b16d-f141a6d17433"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9307), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc3a1d99-05dd-4c91-b44a-e067b7b5f0f5"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9788), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be283589-909e-4082-8ba8-62a40a7f6d2f"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9397), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bec1256a-aa8e-43dc-9ed0-b1c283349c1a"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9239), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("becb9835-bdab-41f1-be86-73897d3a80d9"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9694), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf80c842-3b75-4f8f-a373-9efd28741478"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9161), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bfde2162-ba1b-42c4-b2e1-158065fd0fad"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9696), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c058fc13-9b80-42d2-9a55-bfa432347fde"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9616), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c215adef-8fa1-4a58-af9c-0afa87f35c8b"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9557), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3b1bae4-a941-44c4-acb2-836dc4c337aa"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9780), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4e1493e-3943-4335-8320-50ee4bbfb8a6"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9231), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5eff3e7-af58-423f-843c-797e99790722"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9164), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6501a61-f53e-4bb8-88d6-d87492be26f7"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9302), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6772f27-593f-4aaf-af14-13ded55f9451"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9769), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6a56c41-0799-4780-a290-bbbe9cd1b4fd"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9827), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6d46570-43d7-49c0-a404-badabea02340"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9492), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7090ca7-2b7e-49e0-b9bb-822df56589ac"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9545), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c76fe7f2-f898-41db-9ce7-ded87ee4a6b5"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9719), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7aeaad6-1684-4504-84dc-9c8b9bd387aa"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9429), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9e40e3f-a4b5-4614-ac90-b28a3ce63e58"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9482), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc2b51c5-a221-4bb8-b1e0-e07ff74d9a54"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9177), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cca39382-c12a-4a30-925f-f850a6b7d933"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9499), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd029ad8-a109-49df-8109-c77f28df6867"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9619), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0e1f119-4cce-435d-8dee-fde26a90df4b"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9839), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1cd13e2-0ee3-4969-8536-3f87c3763bfc"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9710), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d39be384-8b01-4400-8ae3-b69ee51077bf"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9530), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4343518-f7ae-489f-a105-6b2e9c3c6da5"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9402), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d46819d2-63ea-4dc6-98dd-70eff3787238"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9762), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d472cc60-4780-4921-b90b-9e667ef8ed81"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9630), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d566b26d-4030-41e3-8d0e-ac4fe588569d"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9644), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6163c55-155f-440a-b733-0f814d3b7f64"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9243), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d683407b-c5f2-4f7f-a230-af2b02e85719"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9825), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7ba5262-b1f5-48f2-9ae0-e97c41dd763c"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9704), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7e304f9-8401-4633-8ee1-0a059a6ada45"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9222), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d89b2eb4-96aa-4e81-a828-6beb0eefed65"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9353), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8ebb3ce-319f-4132-be0e-db4cd2af55b0"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9792), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dad933bd-eac0-430f-9dd8-85dc888f792e"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9716), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcddacfe-d37f-416e-b7b9-06bd6950f7bb"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9296), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df4f85f7-c223-4e10-8de0-968da71d714c"), "D", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9479), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e11e2d42-cbee-4f40-a088-21bacc83815a"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9372), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1572915-dc1b-478e-ac53-a14880371821"), "A", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9775), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e20db79e-3d07-4e93-9e8f-5b7526fe243c"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9833), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e22df990-bc6a-4bbe-a200-a5e4b05e42d0"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9348), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2bd3105-38ce-4ec3-9734-3541c45247b3"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9481), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2dbf731-bf60-4637-9d46-5c9316db72c2"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9204), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2dca2b8-4c3e-459c-b595-aaf9e014bc8a"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9489), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e34a6354-5db0-45cb-ab86-f5b40473d66e"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9406), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e400e0f1-4693-4b56-85dc-9cf43c7a8039"), "I", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9359), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4878487-78c6-445d-98e9-7ed3f7ada3b0"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9282), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e58e0625-20f3-41ab-b2e6-4af997dc9d6f"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9299), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e641efd9-c925-4213-b9e3-b8bd20532ed3"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9828), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6c14285-d101-4f8b-84e1-ad5e5ba730d3"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9727), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7196288-bcb9-47cf-8f02-8ce8b75cdad4"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9610), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e763530d-0fc9-48b6-a02f-5851dfbfc869"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9317), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e81c6df0-2ed2-491b-894f-3cafec42e36b"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9408), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8adab73-4b3c-433e-b6db-961a3d6810b4"), "F", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9173), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9a0630a-8391-4e88-9264-444cfd9d5b07"), "E", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9637), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee60576c-4eb0-44d5-a954-109e78b88fcd"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9647), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eefdb59d-6418-4df7-a53c-9d7a549c18b1"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9795), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef3c652e-26bc-4072-b141-654dfe7c562f"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9551), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1a739d1-27f7-4406-8af2-a91ed8e2a194"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9236), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1bf8887-37bc-4344-8cec-8206e348c183"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9287), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3f0e0c9-45fd-48f3-b8d9-42c1f2177ec7"), "C", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9495), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5af9fb5-758b-4f92-9d78-99d6ad0db12d"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9713), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7fad004-ff06-4504-942c-95dc535bdedf"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9175), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f90e336d-a399-47f3-98ce-37e73b1782f2"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9490), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa03e965-76bb-49d8-9eeb-d931d2e7d3d0"), "B", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9760), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa7dadd5-29e9-44b7-a9fe-d392d9648fe1"), "J", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9361), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa86cde3-da6c-414d-b78e-47d67e79a47d"), "G", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9845), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb00a14d-13a7-4f34-8167-ce5ab90e6d94"), "H", null, new DateTime(2025, 1, 14, 7, 58, 57, 169, DateTimeKind.Utc).AddTicks(9882), false, null, null, null, null, new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("5d3e0313-0c44-461a-8661-fa96a5922b9b"), null, new DateTime(2025, 1, 14, 7, 58, 57, 170, DateTimeKind.Utc).AddTicks(226), new DateTime(2025, 1, 15, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(235), false, null, null, null, null, new Guid("807cb72d-729e-4cf3-84e6-7dc06c42011f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 14, 14, 59, 57, 170, DateTimeKind.Local).AddTicks(230) },
                    { new Guid("63fc92b0-7538-4090-8cc1-e0d6355376e1"), null, new DateTime(2025, 1, 14, 7, 58, 57, 170, DateTimeKind.Utc).AddTicks(239), new DateTime(2025, 1, 16, 14, 58, 57, 170, DateTimeKind.Local).AddTicks(242), false, null, null, null, null, new Guid("d54d5c74-151a-4676-ade2-ddc105793b9e"), new Guid("80b97611-eca2-416d-a794-e5636cd49ba0"), 1, new DateTime(2025, 1, 14, 15, 0, 57, 170, DateTimeKind.Local).AddTicks(241) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("35d3d5e8-7ec0-41aa-9316-bed7de73a227"), null, new DateTime(2025, 1, 14, 7, 58, 57, 170, DateTimeKind.Utc).AddTicks(390), false, null, null, null, null, 60000m, new Guid("1ceceac9-f654-4691-95fa-8e09e7a71a74"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("a413c8ea-b44b-41c7-a785-519fbb9fabc2"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("dc24bc45-fd30-4c04-81a4-13d0865661c2"), null, new DateTime(2025, 1, 14, 7, 58, 57, 170, DateTimeKind.Utc).AddTicks(383), false, null, null, null, null, 50000m, new Guid("890d5437-d176-4aab-b749-8bd98ab15220"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("063fcdbf-9305-4bd3-8d40-97ab4e95b008"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
