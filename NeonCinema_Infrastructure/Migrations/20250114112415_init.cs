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
                    { new Guid("23bb9280-f713-4bf8-a816-8308d2b22eba"), "11:00 PM", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3810), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3806), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("08f0a347-5293-41ab-aedf-d5932aab55a7"), "Việt Nam" },
                    { new Guid("1d47603d-0846-4c3a-995c-a7371fa3c6f5"), "Vương Quốc Anh" },
                    { new Guid("6061ed6a-866e-45d5-8320-05b9f79e25d1"), "Pháp" },
                    { new Guid("6a021a4b-f521-477d-8352-f2de895c03fa"), "Hồng Kông" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("9e650772-18d0-4d29-b8bc-d0c6f8213355"), "Ấn Độ" },
                    { new Guid("c2808b11-6258-434f-882d-cd5900b13d60"), "Úc" },
                    { new Guid("eaa7f9a2-a6d5-4bda-b8d1-0b14ce11bc2b"), "Trung Quốc" },
                    { new Guid("eb56b9b1-b5d6-46ce-9a1c-19221459d0cc"), "Mỹ" },
                    { new Guid("f3bef1aa-df4a-4c29-9e44-80aa1c3e279e"), "Hàn Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("17efe36d-61db-457f-8e27-4e10323d1a6b"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3648), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3649), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("8d7cc9bf-e0e4-4700-be11-3bef3a3e0a1d"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3646), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3638), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("9ebc5947-7f23-4499-86b7-9d8c4ec31443"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3657), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("a9465d2f-cc87-4534-ba1d-c989fda7287d"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3652), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("cc1fc6c1-1aa4-4188-8fb1-65d5b0b234ba"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3655), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("d15d8012-a404-414c-9aa2-84389415c5e3"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3644), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("e6a3f890-4218-4581-b064-7443ce097e2f"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3661), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f98efb32-b2e8-457a-afb6-a5285232c689"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3654), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("22464697-3495-400f-8d35-d448ca5359a2"), "Combo 4", null, new DateTime(2025, 1, 11, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(5005), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("3b332821-7f67-4f6b-bd23-9a38eb8a658d"), "Combo 1", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4994), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("3f8f6442-87fd-4f9a-9c4a-a2accc6528eb"), "Combo 2", null, new DateTime(2025, 1, 13, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4998), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("b7fbeeee-47c6-400e-b58a-291c4633c5c7"), "Combo 3", null, new DateTime(2025, 1, 12, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(5000), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1cef0bd3-6fba-46d7-84cb-7908b57e06e1"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3712), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("2798195b-4e59-424d-810e-444e2c8723d1"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3718), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("54ee7c7d-afdd-40af-be9c-8dc95164242c"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3708), false, null, null, "Hành động", null, null },
                    { new Guid("60053dcb-bbdd-4e78-8733-5145326262ed"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3717), false, null, null, "Tâm lý", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3702), false, null, null, "Kịch tính", null, null },
                    { new Guid("cdb0907e-3130-4cfe-9ea8-70826d8a7ead"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3714), false, null, null, "Lãng mạn", null, null },
                    { new Guid("cecec4d5-b8bf-42e1-b6aa-54a733fe2d3b"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3709), false, null, null, "Kinh dị", null, null },
                    { new Guid("e8663ec4-463e-4b13-b0ef-f3981fde9644"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3713), false, null, null, "Hài hước", null, null },
                    { new Guid("f637ad0d-4851-44c1-b2a2-a8949ea26786"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3706), false, null, null, "Tình cảm", null, null },
                    { new Guid("faab115c-3f5f-4b71-a491-f4fe339edfd2"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3710), false, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("3a561743-05fa-4087-b651-0fc917935b4a"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3607), false, null, null, "ThaiLans", null, null },
                    { new Guid("50a21d91-76a6-4815-bdad-a33c24f2bfbf"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3608), false, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3600), false, null, null, "EN", null, null },
                    { new Guid("94832d01-59bd-4b09-819b-d0b20cb18c40"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3605), false, null, null, "JPN", null, null },
                    { new Guid("d7810bd1-17d2-466e-9d73-cc5c02bd59e3"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3604), false, null, null, "VIE", null, null },
                    { new Guid("ee56896b-c949-4766-b63b-6afb0b8a797a"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3610), false, null, null, "Korea", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3010), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3011), false, null, null, null, null, "2D" },
                    { new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3001), false, null, null, null, null, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(2903), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(2920), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(2918), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3785), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3787), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3781), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("00076875-d26a-481b-9eb4-6b587e311f77"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("0614ffd0-31e0-474a-9cd1-68fba16f0b96"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("3428ccd9-e7d7-42de-a7ab-3f673b54bef0"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("5b9e1bc9-2eaa-4ee3-8287-073e615a3ade"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("9af8a52a-4976-41f9-9a10-e484ef61b853"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("aaa8c96a-6bb1-43cb-b225-ef060469e67a"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("b0f5489f-c2ef-4bee-9440-d6e98dd82e04"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("b921a2fd-3ca5-4aa3-b069-5b9cdbc94795"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("bd2a5fc6-08ea-4c99-aa20-134721d1388e"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("e3c2d2b1-a385-47ec-a0db-a282cd67c3fb"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4934), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 10000m, 20000m, 10000m, 50000m, 5000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), 16, new Guid("6061ed6a-866e-45d5-8320-05b9f79e25d1"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4700), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("e8663ec4-463e-4b13-b0ef-f3981fde9644"), "ngaiquy.jpg", new Guid("ee56896b-c949-4766-b63b-6afb0b8a797a"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("0947de61-249d-49fd-8709-8ab61314f88e"), 18, new Guid("eb56b9b1-b5d6-46ce-9a1c-19221459d0cc"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4821), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 127, new Guid("54ee7c7d-afdd-40af-be9c-8dc95164242c"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("17710fe7-62c1-4ea9-ba4b-519ed61ead00"), 16, new Guid("eb56b9b1-b5d6-46ce-9a1c-19221459d0cc"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4737), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("54ee7c7d-afdd-40af-be9c-8dc95164242c"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("2a1f26fa-2b37-4707-96a3-1c068e43b19e"), 13, new Guid("c2808b11-6258-434f-882d-cd5900b13d60"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4746), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("d15d8012-a404-414c-9aa2-84389415c5e3"), 120, new Guid("cdb0907e-3130-4cfe-9ea8-70826d8a7ead"), "botubaothu.jpg", new Guid("50a21d91-76a6-4815-bdad-a33c24f2bfbf"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("2ff05316-52f3-4b5c-ae88-7c89e385bbad"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4766), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 100, new Guid("cdb0907e-3130-4cfe-9ea8-70826d8a7ead"), "chayngaydi.jpg", new Guid("d7810bd1-17d2-466e-9d73-cc5c02bd59e3"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("37f1be90-f216-42b8-ba49-d79c0196c911"), 16, new Guid("6061ed6a-866e-45d5-8320-05b9f79e25d1"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4723), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("17efe36d-61db-457f-8e27-4e10323d1a6b"), 109, new Guid("cecec4d5-b8bf-42e1-b6aa-54a733fe2d3b"), "yeuem.jpg", new Guid("ee56896b-c949-4766-b63b-6afb0b8a797a"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("3a043f34-42f3-49c9-96e3-52fbb89712db"), 13, new Guid("6061ed6a-866e-45d5-8320-05b9f79e25d1"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4771), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 113, new Guid("cdb0907e-3130-4cfe-9ea8-70826d8a7ead"), "cuoixuyenbiengioi.jpg", new Guid("ee56896b-c949-4766-b63b-6afb0b8a797a"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("46040d9c-1787-4a50-9bef-5494ecadd91a"), 13, new Guid("c2808b11-6258-434f-882d-cd5900b13d60"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4716), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("8d7cc9bf-e0e4-4700-be11-3bef3a3e0a1d"), 113, new Guid("1cef0bd3-6fba-46d7-84cb-7908b57e06e1"), "congtubaclieu.jpg", new Guid("50a21d91-76a6-4815-bdad-a33c24f2bfbf"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("5cd74187-0122-4d1a-9804-774e9d241a3c"), 13, new Guid("eaa7f9a2-a6d5-4bda-b8d1-0b14ce11bc2b"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4789), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 134, new Guid("54ee7c7d-afdd-40af-be9c-8dc95164242c"), "cuocchien.jpg", new Guid("94832d01-59bd-4b09-819b-d0b20cb18c40"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("6aeeec20-fd58-401e-99fe-009003a3b4ce"), 15, new Guid("6061ed6a-866e-45d5-8320-05b9f79e25d1"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4759), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("17efe36d-61db-457f-8e27-4e10323d1a6b"), 110, new Guid("1cef0bd3-6fba-46d7-84cb-7908b57e06e1"), "chuyennhabanh.png", new Guid("ee56896b-c949-4766-b63b-6afb0b8a797a"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("825663f7-024e-40f4-8aa0-1c6bcea370c6"), 13, new Guid("eb56b9b1-b5d6-46ce-9a1c-19221459d0cc"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4783), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 118, new Guid("60053dcb-bbdd-4e78-8733-5145326262ed"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("9a335e7e-a745-444a-92b3-15321ddcccda"), 18, new Guid("6061ed6a-866e-45d5-8320-05b9f79e25d1"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4710), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("d15d8012-a404-414c-9aa2-84389415c5e3"), 81, new Guid("e8663ec4-463e-4b13-b0ef-f3981fde9644"), "xich.jpg", new Guid("ee56896b-c949-4766-b63b-6afb0b8a797a"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("ca571b7b-a6ca-45f8-b22f-2a3b050948d9"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4729), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 99, new Guid("e8663ec4-463e-4b13-b0ef-f3981fde9644"), "tetamhon.jpg", new Guid("d7810bd1-17d2-466e-9d73-cc5c02bd59e3"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("de0356f6-0314-4fb0-9c2b-14e27b1d61d8"), 13, new Guid("c2808b11-6258-434f-882d-cd5900b13d60"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4777), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("88eaa15a-dae8-4658-b054-050b4b25685d"), 123, new Guid("e8663ec4-463e-4b13-b0ef-f3981fde9644"), "kinhvanhoa.jpg", new Guid("50a21d91-76a6-4815-bdad-a33c24f2bfbf"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("ecb08212-b3d8-48dd-b7eb-b7a7ea366fa6"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4752), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("8d7cc9bf-e0e4-4700-be11-3bef3a3e0a1d"), 110, new Guid("cdb0907e-3130-4cfe-9ea8-70826d8a7ead"), "tretraukhongduaduocdau.jpg", new Guid("d7810bd1-17d2-466e-9d73-cc5c02bd59e3"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3846), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3841), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0d90a24c-8cec-4ad7-9d0b-d93f843b1c4d"), "Hà Nội", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3072), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4ca26f01-dc1e-4f90-a32f-58513bd5610c"), "Hà Nội", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3543), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("706b380a-5160-4d5f-82f6-efc548d6b1e6"), "Hà Nội", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3519), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("9fd2df65-d257-46cb-905c-4b0736d32250"), "Hà Nội", null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(3463), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("13c96c85-999a-4d3a-bb23-354eeaf6655f"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4909), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4907), new Guid("aaa8c96a-6bb1-43cb-b225-ef060469e67a"), null, 0 },
                    { new Guid("17c1b819-1938-4674-814a-aec24f7fb42b"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4894), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 23, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4892), new Guid("0614ffd0-31e0-474a-9cd1-68fba16f0b96"), null, 0 },
                    { new Guid("3e894e50-3975-4377-9720-0b7857896dc2"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4889), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 24, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4884), new Guid("b0f5489f-c2ef-4bee-9440-d6e98dd82e04"), null, 0 },
                    { new Guid("45369751-18d7-47f3-87ca-7e3e57506f5f"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4912), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 18, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4911), new Guid("3428ccd9-e7d7-42de-a7ab-3f673b54bef0"), null, 0 },
                    { new Guid("68d8376d-e082-439b-a683-d9746d7d5609"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4903), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4902), new Guid("5b9e1bc9-2eaa-4ee3-8287-073e615a3ade"), null, 0 },
                    { new Guid("cdb3af80-ab2f-44b8-b4fc-8a973e4c36c4"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4900), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 21, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4899), new Guid("bd2a5fc6-08ea-4c99-aa20-134721d1388e"), null, 0 },
                    { new Guid("db551236-3bac-4ecd-a7ac-f48d48c6f3d0"), null, new DateTime(2025, 1, 14, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4897), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 22, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4896), new Guid("00076875-d26a-481b-9eb4-6b587e311f77"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("000a9ec2-0b3b-4461-835b-3d420645268a"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3867), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00136bd9-ddcc-4fd4-8e18-4144d848faa2"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4391), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("008b8552-7722-4fb0-8f55-ecf3371718d5"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4018), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00b87a53-1088-4a1d-913a-956664747844"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4217), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0324ddca-4de7-4894-aa62-18d878b0f8bd"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4224), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03a1ae60-8727-4823-ba0b-297315413255"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4368), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03eb02d3-1d16-490f-b60a-37cb0a5c51ff"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4537), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04e72b98-5a71-4d85-bc07-0af42838067d"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4137), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0519c724-1fb3-4e3b-a92d-13354723e812"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3950), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05c2aee3-a11c-4768-92db-f5443407dde6"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4301), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("060bfc55-3554-4f4a-bc3a-7fe0c0ef9372"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4062), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0756e7b5-b155-4014-a207-e9cf05ebff4e"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4332), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("07e214de-0be0-41e6-9658-7e6f732f897b"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4223), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("087e3bfd-a0de-4bae-afaf-61d7341ad4e8"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4323), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b9eace5-47b4-47f9-88b8-6061958f9108"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4256), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0da06379-2200-4297-a751-adfb759d4e8d"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4215), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0de5d875-a929-4ac6-bb58-790ce77c1789"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4298), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e0196e6-f9fe-4779-829a-addb7323344f"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4422), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ed382dd-d87c-40ef-ae91-10e6fe792bd7"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3998), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f503f39-b8ae-4c45-a8b3-0adeb24b4042"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4419), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("101f2354-9a2c-404e-a25e-121c3831125e"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4272), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10326289-2055-4d88-84af-181c142915bc"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4003), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11b81c70-b98c-4ddc-a256-113c3e4feb46"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4026), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11ca8ec1-0370-4d66-8884-6ab490980e9f"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4437), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12c14cb3-e0dc-4a37-81c0-9c2a2acb89af"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4384), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1368217b-8478-4f63-a599-bd839df43c53"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4372), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("13c13e43-44fe-4170-9d78-3a9b6b44f6bd"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4250), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15677dc1-4f6f-48ff-b657-d68fb0e403fe"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4334), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15b49bb2-8e47-443a-832b-aa914d0dd049"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4253), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1616876b-e192-4d19-a3a3-66686bdaf763"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4257), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1686edcd-de87-406a-bac1-c91c13e0704c"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4430), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16a33f06-f2e0-4e8e-82ec-494f39d7eb38"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4487), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16bb2de2-5871-4813-bad4-56f0f9e444f3"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3948), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("184a8456-6e4a-452d-83ab-631f6e385406"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4187), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c194d91-ea2b-43fb-8e17-b7577e2f60ba"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4016), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c57946a-f3e1-4b70-9d23-a9aeba5145ff"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4504), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d60cea9-0848-412d-856a-8122155c3c17"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3965), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e36e7d6-6db6-473c-95c0-646328fe0e66"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4268), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2018c55a-0b5f-4180-9330-d0d27f42e33c"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4500), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2027ab26-7cb2-4770-a303-7f711f5a5790"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4540), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21d52b42-ab3b-447c-874e-5d9ad7bec0f2"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3963), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22141eee-662e-4588-b389-53c7ad692b7a"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4495), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23309bfc-f4df-4a13-a372-d8265344d1ef"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4370), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23785991-2d83-4dfa-9061-6690bc297046"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4526), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25bcc11f-5e8a-4dd1-9dec-f285c90964cd"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3961), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27991265-8590-49fe-9b6b-2f376a2e36fc"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4195), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("280d5d47-7f55-42e9-b5e8-71d54503ab77"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4136), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("28d1ae58-6db8-4536-a399-ccfd7e2d4c05"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4534), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c0d72a9-8fed-4a18-af97-c6f17004d298"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4211), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c6076f9-de4b-4ad5-ba9d-97c5fc5155a7"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4085), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c7be197-26fb-49f3-9372-aa2fd62bfb97"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4477), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d427849-5bb1-4176-9d88-84fbd1f612ad"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4140), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f365e1f-4dfb-42c8-b606-ec98ec24b0be"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4149), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f44fc92-eb46-4259-b6e8-c7e14b48928a"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4141), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3020d589-8ff4-4616-a07c-abd3b9ae1158"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3953), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("308fe7e8-f01d-4411-a72b-91104fdad21c"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4261), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31c2c175-2d9d-4818-bea0-1ae85501d4a8"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4485), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32090a6c-7d5d-49bb-8115-549f2287bde4"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4316), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32a05e3e-e3c2-4b0a-8ea4-0d9e32a3cd0a"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4209), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32dd14e4-4978-4bff-ab62-ce3d07dfebba"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4145), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34dce8a6-5192-4a7d-b62d-5ebc9e4b43c0"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4319), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("352d7be5-cd0c-4241-8f76-b0553ddcada6"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4496), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("381db2c0-1167-4a0d-b9f2-4cfc3f69b6c9"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3947), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38202d2b-9938-425c-bd7e-c36c8cb20191"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4009), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38cfb23c-23d6-49e5-8561-e5841e71dcef"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3933), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("397ac34b-4a2c-4f48-8472-6e35af22d630"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3942), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("398aa1f6-ff8c-4a61-8fef-d394abbbe17e"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4374), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b014f8a-e0b0-42bf-8ba9-67b5ce1d312a"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4227), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d038321-bf3f-47fc-92ae-1929f3eb6345"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4300), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3dabe1c7-6526-4d7f-a808-d9b9dda5ab1b"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4358), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e829a7f-2289-48c2-9f13-56621594427a"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4220), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4055d1ed-c65c-4cee-8f81-cbdd95587373"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4303), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("415b35e6-df13-4080-8c89-9de9132da601"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3956), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("420ceb3d-6132-4865-bb4b-f27b5aa30f90"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4277), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4386b1b6-06aa-42f2-a4a5-d94513a876c7"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4315), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("448c731c-3c78-4ce1-b8a3-58d60bcde875"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4059), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45fd5945-04b1-49f3-a74d-74e569a0dfb4"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4204), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48ab48c5-c544-48c9-9f9d-9fe6f23a7728"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4082), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("490d1d5b-34e6-41a7-85bd-db0ae195c99f"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4505), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49945a9f-934b-4f9f-a777-528c52f1c62b"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4360), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c199e5d-0f18-4263-8673-89263f0c68a9"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3955), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d82c429-701b-4379-a5fb-3f96b0cbe353"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4529), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4deb4dcc-1998-4654-b9c9-99fe0f46ab30"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4200), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f24fe7e-ccca-4422-b795-28131d87a034"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3960), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f307c97-4f6d-4890-ae7d-fd771ccebca3"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4008), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f9ba781-6e97-4a8c-8ea3-c4ad04acb8d4"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4021), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50611aa5-8e0f-4daa-ab10-55208eb6cc4f"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4271), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50ee93b3-dace-4dd5-b1e3-a9be9dc71b17"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3996), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("519aa86e-7d69-4327-9b04-7755d624a383"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4121), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51fb3476-8b83-4158-b7c9-8c6cc84160d6"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4302), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5261c2f1-aee3-4c33-9563-863026b2dbc4"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4156), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("534350e0-0411-413c-8f11-67ea6a559231"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4214), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53995654-f5ba-401a-a1f6-dcfbccd4b4a4"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4445), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54ac23c3-75dc-46e7-87e1-474f87587630"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4077), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54e1e108-d30b-4744-a3fa-6206f61eecfb"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4357), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55832478-a1bd-4b28-a81f-f812984207aa"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4012), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55ae512e-3125-42ad-a919-8aef2c1420f5"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3943), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56ab04c3-1937-4b08-bb3b-9a96d22026bf"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4432), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5715606a-d3aa-45e2-82ca-ebfb500a0534"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4393), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59261b0d-9011-47a2-9edf-2bcaa3705520"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4221), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("599fdad7-d932-4bf1-8a07-faeb15194366"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4265), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59d29d9a-30c4-4934-982c-bd0416bbc54b"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4525), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b2ed172-18d3-48a5-b640-188cce8faaa5"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4260), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b4199b2-d288-4446-b2ff-6945ee1613cc"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4073), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5bf9ba80-faca-4c5e-b1e2-74b2ce9d7de6"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3935), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e805d57-60ee-4126-947f-79cb39c689d4"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4428), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f0ed182-a663-4225-b357-f5b8dc4c5275"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4331), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f31c7f0-93b9-4284-a0b4-d3dcaa1f93a2"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3966), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6122c85a-2533-43bd-af33-75cc3394ea1b"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4210), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6328fbae-b92d-43e6-9a6b-25a9c5561500"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4325), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("641f0bc4-ea73-4eb2-9d11-1caddafe7bba"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3997), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("668c4890-72b2-4a14-b80d-d3ba11112172"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4297), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68d22311-3e3f-40da-8472-c53a21bf7851"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4312), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6aaded34-1920-4d5f-b5cd-e85870bde209"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4365), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d783809-1cec-445b-8687-bc4c76e20675"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3931), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e49666d-8d8b-4607-9a85-f5fb9fd3f05f"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4248), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f23d1ab-f98c-4307-a3aa-66a8af22d44b"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4492), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fea66f0-af1e-45a1-91e8-a42a4005f732"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4383), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70600c1f-e779-4c09-9c66-80d97d78332b"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4160), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70c34f89-ab88-4c78-8d5f-f884fd5ebf27"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4373), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("719bbbcc-9e3a-4c47-acd1-8b48c22e7a32"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4075), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7395f8b6-0cbb-432e-afa4-7f6c1308eac7"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4066), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74fed5f6-831a-4bca-8f9a-f7a98a31b7e9"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4497), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("764843d0-1846-46f9-aea0-14b6c9d64d7b"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4053), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76a0ac3a-948a-4906-8339-6aac0e3ce4dc"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4377), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76e40fdf-9e97-409e-852d-2cb007aea70f"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4475), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76f12f08-3ef2-419a-975b-9aa6d216aaae"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4014), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77bda269-9b5b-4041-a729-e306d49785ca"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4434), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78c530ac-24a6-4510-857a-43c07cefc6d1"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4252), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a84b852-6d07-4f11-9cc1-380411828e3a"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4499), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7af23d4b-6f7f-4204-b839-6a32f2382f50"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4363), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cac59af-59db-4a61-a65e-4ad7981d53a4"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4444), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cb6f58e-65fc-4792-9831-2fa5c0608091"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4069), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d373bef-bb0e-4057-9ace-461b36f41d36"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3939), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e41ff07-b5ea-44b2-a0ad-d148d5736916"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4133), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ece2a55-657d-486e-8cd4-eaac2fad6bb9"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4324), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f45edbb-2bd1-4372-98af-f58e0d9ff9c6"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4449), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f790e06-034f-4754-99ab-7a50ecb0d735"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4058), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81aebd85-6310-4af4-8bf8-273f419fb8fc"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4074), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8261a4e4-6499-48b8-9f77-09384b07db95"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4123), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82e30ab7-86ad-41ee-a729-5cd770c00d07"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4255), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82ececb2-c364-423a-b278-0bc35d08e2a2"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4380), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("831abe66-ac7f-4df1-a454-f9299b9d3e57"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4308), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84ddbbce-d735-48d7-90f0-4a0ee049710a"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4205), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85d76b4b-138c-4d24-ba22-95b244dfcb79"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3940), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8790bee2-d4ff-483a-8291-afaccda40717"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4155), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87d0c81a-8d28-4dee-b6a2-3998b7e24378"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4208), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87f47199-7eff-4980-8ac4-6a5508f48008"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4022), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89acdd8b-1d5f-4b75-b9df-0d73905c3e20"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4429), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b36a7ea-b25a-4691-a58d-c994d54a6850"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4386), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b6398da-ef5f-4e68-b051-7aadf0dd71ab"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3959), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ca5cae3-aba0-4e7d-8e1a-be5b75c4690c"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4070), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8db35d58-557f-4b4a-970a-7c083c1ad55e"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4153), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f86ab45-a59b-4f5e-a9af-68285122992c"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4451), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f8ae2ae-ed89-4f44-9308-570aeb34a847"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4129), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9070d20e-7b7e-44ca-b25f-a96dcef4f112"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4481), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92f745fa-f7d7-4e11-a6fa-dd2d4dbb1694"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4189), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92f98fe1-3cb9-4756-b20a-2a73016619d1"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4127), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9335b262-2f2a-4f73-9275-5343a3d129a6"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4226), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95422e40-bd8c-4894-8b13-e9775db22b49"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4000), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95e75aba-a5da-49e8-88ef-f0d1ecae71b3"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4130), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98f28625-c9d6-4a5a-9789-04a98f6c5ba3"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4084), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bf8fb39-8464-44af-a891-8e2b593c554f"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4446), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9dc24df2-c9d8-41c5-bdd5-e49329500471"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4063), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9df41830-ca60-4fea-92f0-52b2e1374b89"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4385), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e2f0402-6452-4d4f-8f40-bc4e1464b1b1"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4531), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a318c190-bb87-488e-954d-25017fa7a45e"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4486), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3508323-f5a2-4161-a9cf-3cdfff17cb5d"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3949), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a406e2c2-1e7d-42c0-b4c7-4b58db5f3d07"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4148), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a41a542d-6834-4e6b-a310-55b8a71322a6"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4528), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a77915de-8e8b-4e0a-9624-7576375a828f"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4327), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a861022b-554e-4d50-b4ff-aae6f1e81b1f"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4488), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a89d0504-6862-4202-820a-760b154e761d"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4222), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab4230de-8697-4abc-906c-37777e07cd31"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4472), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac172bc2-1762-4422-86ab-c05a15eef02a"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4023), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae7c7948-680c-4a7f-ae95-6e81187a431e"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4192), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b048e506-a7b8-4b51-a9a7-60765a09e45b"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4007), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0a9eec1-8c8c-4ae3-a579-832996e23a01"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4320), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3f2f295-2ec7-44a1-a82d-44be8de89c1c"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3994), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b456af83-ff7d-4752-8ad3-42b8b35b758b"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4024), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4eb2910-c98d-43e3-9bf9-6729225ef0e6"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4199), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b64cb15c-7465-44cb-b00d-997af932a439"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4441), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6df8b2b-3d84-4679-b1e2-2f362f811a09"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4433), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7a17611-f943-41d3-943b-f96c1fd39fa9"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3937), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9f30ae0-663a-460c-b59b-a42730fd4dfa"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4494), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba1b01d5-9c73-4421-abd2-3c7632055072"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4395), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("baca2cfd-1ff9-4653-af50-daaaa1420021"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3907), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be82a03b-90e6-4759-8fb3-72666932323d"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4310), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf951831-cf45-4d32-ba76-056955bd0708"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4061), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1b3b986-65fe-4048-813b-e6e6d6471d18"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4306), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1c9874e-4f63-4baa-a018-20e1a8c3f429"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4392), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1feef57-36bb-4dc3-9c87-4f41231fc77b"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4483), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c38e25c7-5a57-4b55-9349-4d53b416d33b"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4330), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4b12f69-8e6a-4304-acf0-db7f4621bc46"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4056), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6e6fb50-df2f-470c-84b4-679db4ba3805"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3928), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c72bdbcd-8364-4742-a0ab-67b18322b0cd"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4491), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c787b881-ca4b-453e-b82c-2026b3b5c94f"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4131), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7f1627f-b760-4bbe-9f90-00b6127b0d4e"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4079), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8ae9eee-c794-4110-8c41-86e00ecb3cd8"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4389), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c909f735-69bd-4d14-81d5-2d70917df6b1"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4264), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c91768ea-57d4-45e1-a293-522cd5c0786e"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4273), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c99559d1-6210-4f5c-8887-6304b280fce5"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4086), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c99a2ceb-e5c1-46de-b7a0-bbbd8207bfc9"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4309), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca885dc4-fe72-417b-84b0-3af84ea38430"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4438), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce953625-83a8-4c2e-8ed9-9b3b0d02f36c"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4201), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d154b21a-6088-4ed3-9384-784e73d2b95c"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4019), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d20707aa-b444-4c18-ad31-9cf52f2b7491"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4157), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d399a2af-7525-4c2b-8390-18329a891691"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4440), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3c74e7a-e233-4f18-95f1-9e33a7ecf671"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4144), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3fba334-7991-46e6-be6f-f5e026e973e5"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4538), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d426d67f-966f-4d8b-b691-8316f7bb578b"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4083), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4760b18-c1a8-4aef-8c44-0fd30776167d"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4001), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d54ba7e9-ca31-45d8-b3f4-8f3b59c8e297"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4420), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d55b612b-ae47-48ec-b9ac-072a56fd243d"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4535), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d657a3d9-6136-4771-ad50-3db6453dd12f"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4011), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7387729-5297-4b5e-917f-3b6886481d13"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4539), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d75187a0-8475-4dfc-99cd-0b773b38c34d"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3991), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d76ba240-297f-4557-b9ae-eb530b253d83"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4474), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d79a9b9d-59ce-4738-b257-67d6cc3f1902"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4124), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9c93ae2-5644-465d-80f9-c1d3bdfac8a8"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4071), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dad2e64b-1b0b-4ebf-81b7-47012ca30e2f"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3964), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbb39d27-c202-4ce5-8977-759d6e1a43da"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4482), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbcc3c58-f5ef-48ce-83b9-0c3570ccd1af"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4064), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcff6952-1233-4fb8-863a-d6ca08716e4f"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4367), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de1d1f76-58b8-4daa-a4d1-0c57642ca815"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4542), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df2775ef-8eeb-4f48-b796-f080c6975e1e"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4213), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df74accf-b473-4e96-9ab9-d797f30361b0"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4142), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2f6bf61-a309-4beb-984c-1ab07906d2cd"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4321), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2ff4465-19a5-4ac4-a0e9-82440c5a1258"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4381), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e364901c-a11f-40d1-b23f-b2ee6eb6cf9d"), "D", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4267), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e39a9132-b9e9-4915-94f4-67334124f5cc"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4269), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3fb5d67-232b-4e88-ada8-e91123dadaa5"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4202), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e43cfe11-844d-4ec8-9d4a-7f997d2c110b"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4379), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4a9451a-2f59-4e51-9f12-4066ebda39df"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4013), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4e8ddb4-194a-4d88-a9c2-39a26779c3cc"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4158), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e55f4464-868d-4ebe-a8f5-266adf79ec43"), "A", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4134), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e791db57-7056-4404-8a1a-cdb02b95e8fb"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4355), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e822ec66-dae6-48d9-9fe3-7fd6a1ed72c3"), "B", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4326), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb075fe4-66a5-40ff-98a5-6c4794225f98"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(3952), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec13441a-0ac4-4ea9-92a5-032d499787a2"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4452), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed2a8f2b-f2c9-4d4e-a8f7-2776cfbba53e"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4450), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eec2aaf0-ba8f-4c01-8dbd-a6a573df759d"), "G", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4426), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef12824c-e66b-4028-9ef8-1136281bf2bc"), "C", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4313), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f139fed3-dd1c-4948-b511-8bae49eee25e"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4479), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f288033a-0609-457b-9f59-7202ce39aacc"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4425), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3837a64-098b-4c57-bad0-9ce1a17a9026"), "F", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4503), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7e19094-d463-42ed-a8bf-5dececcf75b1"), "H", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4442), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa73f62f-1d76-47a3-8437-1b6a65ee4a81"), "I", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4147), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fef2525e-87bd-4ffc-a463-5c301534c4c3"), "J", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4276), false, null, null, null, null, new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff120bb8-bfd7-4bfd-9bab-f0a2ecdb559c"), "E", null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4004), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("3700b64f-cd97-4118-8cf3-299bfbf1c0e6"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4858), new DateTime(2025, 1, 16, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4861), false, null, null, null, null, new Guid("9a335e7e-a745-444a-92b3-15321ddcccda"), new Guid("427db6c5-bd55-4cc5-802b-3d647afce83c"), 1, new DateTime(2025, 1, 14, 18, 26, 15, 243, DateTimeKind.Local).AddTicks(4860) },
                    { new Guid("a4786a8a-dd86-4cf0-bcd7-899070c8ac8a"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4844), new DateTime(2025, 1, 15, 18, 24, 15, 243, DateTimeKind.Local).AddTicks(4853), false, null, null, null, null, new Guid("04c6fda8-279c-48a9-8573-1041a7cd8f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 14, 18, 25, 15, 243, DateTimeKind.Local).AddTicks(4849) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("5c7ad45b-8f8a-4925-8b23-621f86818d04"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4959), false, null, null, null, null, 50000m, new Guid("3e894e50-3975-4377-9720-0b7857896dc2"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("b0f5489f-c2ef-4bee-9440-d6e98dd82e04"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("a1e01560-7b63-4dd7-8afa-3698e1066d86"), null, new DateTime(2025, 1, 14, 11, 24, 15, 243, DateTimeKind.Utc).AddTicks(4969), false, null, null, null, null, 60000m, new Guid("17c1b819-1938-4674-814a-aec24f7fb42b"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("0614ffd0-31e0-474a-9cd1-68fba16f0b96"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
