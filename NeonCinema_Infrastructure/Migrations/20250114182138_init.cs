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
                    { new Guid("34e962b2-dea4-43e2-8dcd-0945590ece9b"), "11:00 PM", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6170), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6165), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0c9d8f3d-a49b-4149-bf56-4d64fc3c3bf5"), "Hàn Quốc" },
                    { new Guid("0e020cdc-0819-499b-a029-cc3217075fc4"), "Mỹ" },
                    { new Guid("26d044c6-34a1-4d37-8c02-d25fc81ead7f"), "Trung Quốc" },
                    { new Guid("44447ffa-eb13-4135-a904-bfefab0f4b4f"), "Việt Nam" },
                    { new Guid("80840a0e-745d-4770-b19c-f19d085e2cf7"), "Ấn Độ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("93ebd061-4ac6-4fc3-a969-0fe53f7c2604"), "Hồng Kông" },
                    { new Guid("b29734cb-be56-40cb-86ac-f1e6518595f3"), "Pháp" },
                    { new Guid("e3d36a44-f0b9-464d-bfbc-9f24ad7a3d88"), "Úc" },
                    { new Guid("f815fcd6-3738-40e0-9d8f-ea1bcdd1f52b"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("10c655aa-377d-487c-957e-af2fb7a1600d"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5960), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("6be26047-a087-497b-93aa-8a97f3d6fb84"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5955), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("6c5ffc6c-d889-4279-adc0-0f2e08247e6d"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5967), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5957), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("789f3d24-aa31-45c5-add3-4349fdfc4d99"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5952), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5940), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("955ef44a-f327-4600-be86-3a12f99d5152"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5965), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("d02b1989-a302-4b1f-b472-496af74f36bf"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5947), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f6c4813e-3ca3-44f1-8102-e4614117b287"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5963), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f8e275c0-33e3-4698-9629-f66aab859bed"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5961), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("903a3d63-7773-43ea-8f15-54f5598a3972"), "Combo 2", null, new DateTime(2025, 1, 14, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7589), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("95564dac-2f7e-4098-90e4-bfa9eb91473c"), "Combo 3", null, new DateTime(2025, 1, 13, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7592), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("9adfe2f3-0203-40a9-842c-42de894c6d6f"), "Combo 4", null, new DateTime(2025, 1, 12, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7595), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("9dfbc7e2-3579-4a0c-8480-df4ca1e58a73"), "Combo 1", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7582), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0f71efdc-2bab-42d1-b7c2-eaf315d6172a"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6032), false, null, null, "Lãng mạn", null, null },
                    { new Guid("3858a924-6062-4fda-af59-2c79c6c720cd"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6034), false, null, null, "Tâm lý", null, null },
                    { new Guid("54849d52-ec21-4956-bbfc-1c974515e975"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6005), false, null, null, "Hoạt hình", null, null },
                    { new Guid("716a3517-838f-45f9-8e0c-299517ad1a68"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6003), false, null, null, "Hành động", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5998), false, null, null, "Kịch tính", null, null },
                    { new Guid("90c2315c-d0d2-4d5e-b1b7-10e56789fcff"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6004), false, null, null, "Kinh dị", null, null },
                    { new Guid("93c29ee4-58ff-4cc0-a569-9e9b363ab1b7"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6001), false, null, null, "Tình cảm", null, null },
                    { new Guid("9d240f43-613c-4ada-af8d-b3c253bb5548"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6039), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("9e18dc9b-7e52-4d14-af15-1ec440f30b57"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6009), false, null, null, "Hài hước", null, null },
                    { new Guid("f1539bb9-ea0c-4daf-8c4a-38ed486ec7d9"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6007), false, null, null, "Phiêu lưu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("49a9dafb-b856-4693-a59d-9627a70d814e"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5900), false, null, null, "JPN", null, null },
                    { new Guid("54d8099b-2cca-46d8-9bad-ff2e812fcd89"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5902), false, null, null, "ThaiLans", null, null },
                    { new Guid("6f9baa32-df97-4d5e-a6a0-734480bf47ed"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5906), false, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5894), false, null, null, "EN", null, null },
                    { new Guid("d3d370dc-95ee-4ece-9bc9-347c8eb9d99a"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5903), false, null, null, "USA", null, null },
                    { new Guid("f869a0d1-6dee-4f95-980e-196ea7a6590d"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5899), false, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5162), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5163), false, null, null, null, null, "2D" },
                    { new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(5157), false, null, null, null, null, "4D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5004), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5029), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5027), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6130), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6133), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6124), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2aa0943e-67f1-466c-95e7-84d49a3b56f6"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("538e99ed-d204-49ee-805f-4628f2a15718"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("5fdc7f6d-bc34-4fc4-a835-a7888ce6c9c4"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("8e75c479-70b9-46eb-82d1-ad96e85fd8eb"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("be07dea6-e74b-4360-92d7-a706ff0a7f4d"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("c8cd8600-ae62-4a91-a720-cd4951039085"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("d82f8e9c-88ac-4455-926b-0a08048acf6c"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("e1300d77-e917-4e09-ae58-191e615423ad"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("e2ab23ed-23db-4fcf-bd7c-242329dd9fad"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("ec1be223-120e-46c5-991e-75b7039176cd"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7515), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 10000m, 20000m, 10000m, 50000m, 5000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("13d3e22a-47e3-4729-87f5-54c5fa71d513"), 13, new Guid("e3d36a44-f0b9-464d-bfbc-9f24ad7a3d88"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7292), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("d02b1989-a302-4b1f-b472-496af74f36bf"), 120, new Guid("0f71efdc-2bab-42d1-b7c2-eaf315d6172a"), "botubaothu.jpg", new Guid("d3d370dc-95ee-4ece-9bc9-347c8eb9d99a"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("18b79d70-adb8-488e-9c32-8797571bd9ff"), 13, new Guid("e3d36a44-f0b9-464d-bfbc-9f24ad7a3d88"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7259), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("789f3d24-aa31-45c5-add3-4349fdfc4d99"), 113, new Guid("f1539bb9-ea0c-4daf-8c4a-38ed486ec7d9"), "congtubaclieu.jpg", new Guid("d3d370dc-95ee-4ece-9bc9-347c8eb9d99a"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("1e1e9de9-a900-4c8a-865a-1e76ed3a3b10"), 13, new Guid("0e020cdc-0819-499b-a029-cc3217075fc4"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7340), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 118, new Guid("3858a924-6062-4fda-af59-2c79c6c720cd"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("28c9add2-578f-448b-9149-899bfd926029"), 18, new Guid("0e020cdc-0819-499b-a029-cc3217075fc4"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7353), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 127, new Guid("716a3517-838f-45f9-8e0c-299517ad1a68"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("4ef82ede-6bcd-4d82-ab89-a26fe1966d9a"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7319), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 100, new Guid("0f71efdc-2bab-42d1-b7c2-eaf315d6172a"), "chayngaydi.jpg", new Guid("f869a0d1-6dee-4f95-980e-196ea7a6590d"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("583a9292-5858-4ef9-9fbb-d0501ac88123"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7301), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("789f3d24-aa31-45c5-add3-4349fdfc4d99"), 110, new Guid("0f71efdc-2bab-42d1-b7c2-eaf315d6172a"), "tretraukhongduaduocdau.jpg", new Guid("f869a0d1-6dee-4f95-980e-196ea7a6590d"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("767080d9-680a-4e6b-8e6b-a9ee9248701f"), 15, new Guid("b29734cb-be56-40cb-86ac-f1e6518595f3"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7311), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("6be26047-a087-497b-93aa-8a97f3d6fb84"), 110, new Guid("f1539bb9-ea0c-4daf-8c4a-38ed486ec7d9"), "chuyennhabanh.png", new Guid("6f9baa32-df97-4d5e-a6a0-734480bf47ed"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("8b7793a1-8ea2-4710-8d71-e24231278e3a"), 13, new Guid("b29734cb-be56-40cb-86ac-f1e6518595f3"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7327), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 113, new Guid("0f71efdc-2bab-42d1-b7c2-eaf315d6172a"), "cuoixuyenbiengioi.jpg", new Guid("6f9baa32-df97-4d5e-a6a0-734480bf47ed"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("a10876d9-4c89-4cec-a37a-8d6e585066d4"), 13, new Guid("e3d36a44-f0b9-464d-bfbc-9f24ad7a3d88"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7334), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 123, new Guid("9e18dc9b-7e52-4d14-af15-1ec440f30b57"), "kinhvanhoa.jpg", new Guid("d3d370dc-95ee-4ece-9bc9-347c8eb9d99a"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("b832d2df-78ad-4e7a-8e8e-22c96454ca68"), 16, new Guid("b29734cb-be56-40cb-86ac-f1e6518595f3"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7266), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("6be26047-a087-497b-93aa-8a97f3d6fb84"), 109, new Guid("90c2315c-d0d2-4d5e-b1b7-10e56789fcff"), "yeuem.jpg", new Guid("6f9baa32-df97-4d5e-a6a0-734480bf47ed"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("bc5d5ad1-7bbf-4990-a674-814f176a5f5a"), 16, new Guid("0e020cdc-0819-499b-a029-cc3217075fc4"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7284), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("716a3517-838f-45f9-8e0c-299517ad1a68"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("dae95ab5-74f7-40fb-8971-70d95506361d"), 18, new Guid("b29734cb-be56-40cb-86ac-f1e6518595f3"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7251), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("d02b1989-a302-4b1f-b472-496af74f36bf"), 81, new Guid("9e18dc9b-7e52-4d14-af15-1ec440f30b57"), "xich.jpg", new Guid("6f9baa32-df97-4d5e-a6a0-734480bf47ed"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("e4b226bd-b01c-4677-b2fd-49c1f9cb5b52"), 13, new Guid("26d044c6-34a1-4d37-8c02-d25fc81ead7f"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7346), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 134, new Guid("716a3517-838f-45f9-8e0c-299517ad1a68"), "cuocchien.jpg", new Guid("49a9dafb-b856-4693-a59d-9627a70d814e"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("fbad5f00-be79-400e-b2e6-01c2ab53dc72"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7274), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("7170a9bb-64c8-477f-a40d-af219f35aa20"), 99, new Guid("9e18dc9b-7e52-4d14-af15-1ec440f30b57"), "tetamhon.jpg", new Guid("f869a0d1-6dee-4f95-980e-196ea7a6590d"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), 16, new Guid("b29734cb-be56-40cb-86ac-f1e6518595f3"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7241), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("9e18dc9b-7e52-4d14-af15-1ec440f30b57"), "ngaiquy.jpg", new Guid("6f9baa32-df97-4d5e-a6a0-734480bf47ed"), null, null, new Guid("e53dc036-adcd-4a38-9fdc-c7fe231af726"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6218), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(6211), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("6d56e742-32ed-4930-8ede-79524403cadb"), "Hà Nội", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5776), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("8638d0b8-9784-4a6a-9fe1-b2239ca9ebdd"), "Hà Nội", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5835), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "avt-default.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("8afb3c84-4c3a-45c5-b6ea-28c2c7dce1f0"), "Hà Nội", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5747), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("be516e80-9af5-432d-9a3e-f7f924cad365"), "Hà Nội", null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(5229), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("0ec78c75-a041-4137-9757-7787163769ca"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7476), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 22, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7475), new Guid("2aa0943e-67f1-466c-95e7-84d49a3b56f6"), null, 0 },
                    { new Guid("1e983ac2-33b7-4e15-903e-34c6664610f8"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7469), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 24, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7467), new Guid("c8cd8600-ae62-4a91-a720-cd4951039085"), null, 0 },
                    { new Guid("2033de4b-e1c9-4e24-a428-c492b3aa89fa"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7463), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 25, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7462), new Guid("538e99ed-d204-49ee-805f-4628f2a15718"), null, 0 },
                    { new Guid("76c2ed70-0b8a-425d-abcf-838c5ec59971"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7484), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 20, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7483), new Guid("e1300d77-e917-4e09-ae58-191e615423ad"), null, 0 },
                    { new Guid("9a45efe9-6857-4b8c-93c2-d5c636cc5a22"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7480), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 21, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7478), new Guid("be07dea6-e74b-4360-92d7-a706ff0a7f4d"), null, 0 },
                    { new Guid("acfee077-d764-4e96-8552-c5cc61ffcb4e"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7472), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 23, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7471), new Guid("e2ab23ed-23db-4fcf-bd7c-242329dd9fad"), null, 0 },
                    { new Guid("be8a2901-d18e-462b-bd81-ce7b597928d4"), null, new DateTime(2025, 1, 15, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7491), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 19, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7490), new Guid("d82f8e9c-88ac-4455-926b-0a08048acf6c"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00b21d01-ee85-4793-b35c-7723459fa2e8"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6421), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02cbc454-2fab-42af-8a62-e5fe10dd5a75"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6533), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04bb5ffb-cb89-46ab-b3fb-237a80386cd9"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6524), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04d6b106-7a31-494c-8195-c70f4129f78e"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6528), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("057ee1b8-5d2e-4fc0-9689-639481b6f35d"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6675), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06f7574b-f823-4626-af93-1702577a38ee"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6342), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("083ffc5b-7d65-4433-827f-676167561799"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6495), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("087fa6ed-890e-43d7-80fb-ddef3cf3f8ca"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6523), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08dd63a9-8f4b-4489-bfb4-fc96e51534e2"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7026), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b57b780-a353-49b7-a271-48d31665a8a5"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6837), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b6a46d9-2574-4814-b1d0-aeabd36affad"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6513), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cb34d3e-cf2e-4938-97b9-44fc2b3540f5"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6331), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d3415c1-c32a-41e3-9d53-911d97e8a8bd"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6933), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e389da6-99ad-41df-b028-422f837f6959"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6298), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e9f7c09-095b-451f-a49f-37c0f116847c"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6408), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f481724-db66-48a4-8f8d-8a63188b898c"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6459), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f80ed1d-1059-474d-97bb-e9f4d5c47496"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6807), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("108bbc32-2a10-419c-ab69-76f81d39c4df"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6958), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12e54274-1ba5-483f-bb0c-aa7e580e53ab"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6788), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("13a289b2-f3cb-4324-83e8-8d8e86ad7aa3"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6622), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("13c571b7-d880-4875-9070-1457f21cbef8"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6916), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("141c4c8c-42ac-4bf3-bc52-93ae4f743b6f"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7019), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14936d3c-8367-412f-a84f-6a9d541177a8"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6846), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("150ab804-37a5-4da7-a39d-c570a4201bf2"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6352), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("162ca6a9-69d1-49cc-9054-d354f0e6f6e6"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6864), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("193d3136-10ca-483f-9d0d-ffbf5e7476f6"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6854), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f45310f-fcf4-47dd-9a6a-98245ed1cc9c"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6477), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2152aae8-1504-499a-907f-a7bc594fb8db"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6991), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21645d83-8c40-4218-86c6-8ef8c5fb12f6"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6412), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("217b2172-b359-4b7e-93dd-3e1568563917"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6520), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21d0294a-95e9-40e6-a987-ec2d1f722b02"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6498), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23339b57-a72c-4c9b-a9f9-4d408e21b4f7"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6985), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24ea0fb5-fdb2-45e3-8766-b6cb49f9c1bd"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6500), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("255623a3-c875-4af7-b197-a6000f142fc2"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6395), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2787dfe3-8114-49cc-8766-ce41a5acb94c"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6474), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("298b8ba8-34f5-4dd6-bd2a-7ab89a30fbfc"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6836), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29c3530f-3440-4ad8-a182-b8bf2ccc73e0"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6961), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29c9d463-27e3-4143-af46-6e3f3461e55f"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6987), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ae68c08-f9c8-4452-8ee5-cc8d4f2047ed"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6797), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d1bd8dc-1d6c-4f98-9ba1-84e8a3dc4f31"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6777), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d2704cd-f311-4875-8e1b-5eeffec5f286"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6912), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2db1bd7e-196b-41c3-bdf3-25a59d205536"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6793), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e020eaa-34b3-4112-8dc6-95233357be17"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6473), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("306ec333-f260-427e-9b5e-9f04c8a5e6cd"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6415), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3217ee72-5ece-4327-af73-7bc84db7f50b"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6499), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("327bbdfa-2412-4970-aeb3-a4dad1e4ad89"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6869), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33766314-5a5e-4389-89ae-b5b9ef218c2f"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6976), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35de0237-d7e8-4823-bd8c-b7a091886dd5"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6406), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("360dd5ea-cbac-4b1f-97ff-7239cd96dad5"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6399), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("363d2631-0ebe-4954-917d-04693e2959e9"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6767), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3651e7f2-1a3b-48dd-8a44-6a64cd60eeab"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6447), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("367f5823-8edb-4aaa-b3f6-8ddf206b767c"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6461), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36e09d0c-8a28-4dba-8953-7e948c7484e5"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6955), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("373d57c3-4f51-4f87-9c2a-db0cffb95adb"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7014), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37f5aa38-f31e-41d7-b2e9-b2018ca7bf48"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6898), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37fea428-a557-42d2-8017-067f12d11707"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6611), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38ddb712-5e25-4af1-a51e-cc6aee54c4e1"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6627), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a64a978-6d10-4212-95a9-8da0a053a930"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6960), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b098ba0-0016-403b-8831-3c2666aa162b"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6606), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c0dd96d-78bc-456f-8391-15d6f6e77e40"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6305), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3dda8cc7-c8d3-4ebf-a373-eaf051615e35"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6464), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f21a42f-43a5-4e6f-94ac-75ae2e9c33a2"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6405), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ff29fb0-38f5-4e73-a5c3-da24c5068a4b"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6362), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40ea7d7c-5ad9-405c-9b4e-d726602290af"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6779), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4102ba0d-d10b-454d-ad70-7ca4cc3c0be0"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6701), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("41ebcd79-fdf2-4f95-8030-65860697d3aa"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6598), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("428eda27-2ffc-4e5c-8d3c-778b0adf115a"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6841), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("430bfa7a-b594-401c-ba19-fc87c1416fa2"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6591), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44bda383-c214-451b-9236-16154a32ca94"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6401), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44e8c97b-1f6c-41bc-835f-b627983aa9c1"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6456), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("457b283d-ed53-4028-909b-cbdafc645882"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6479), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46142b87-96d6-4e08-bf8c-1ccae1b91c5e"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6967), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46d66b92-9e15-4469-9197-7c6f53565a05"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6391), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47940dfd-f36d-4f9b-b81f-994f1b67d8b1"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6612), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48132005-4e6d-416d-8981-d9389a6dc279"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6737), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48e75bdb-dbeb-435c-ada3-5e8f504c5bd6"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6452), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48ed5465-6796-49cb-a8e3-6448962bf7d9"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6964), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49da2993-436a-445b-88b1-8fbadbb0da42"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6446), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49fbd91b-eabc-4bbd-9c88-0e83734a45ce"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6307), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a62529a-631a-43a6-b6fe-f0707be0d45f"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6872), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b1d3f13-d96c-433b-94d8-2ace6f4963f0"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6593), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b3b6e00-4ba5-43aa-a755-6c5008a36654"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6874), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d888122-e44e-4046-a220-c59a7c48f109"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6858), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f3278c8-62f9-471c-b43f-a6039680b700"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6608), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52df8763-28ca-43d9-8229-07ef129fde43"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6517), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53dfe259-ab0c-420f-8448-4c47038ad2b7"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6340), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("562223aa-d784-4c41-b6c4-b26ef7aec0ac"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6346), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56c7b968-968c-48db-9385-8cb2894d4a98"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6709), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("572411b3-3ef5-479f-95cb-e434a2991976"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7024), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("592c8b6b-f156-449b-8e0e-74a6cc399c05"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6465), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("598a517b-0618-43a3-80b1-b7f3c0ce9156"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6347), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59da98ba-f20a-46da-91e8-c1c1cb90a4ed"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7012), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a071fff-df62-4150-85f6-a46595534cf7"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6806), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5cf9a2d3-a6d9-4daf-b3fc-066611e2968f"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6723), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5de92aa0-d34a-4b49-bb37-998809be91de"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6772), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61542cf8-4822-41f3-be13-ff3ffd1b7aee"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6903), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61946052-b87d-45e3-acf1-595b03388363"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6795), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6290f80c-eea6-4736-9044-9d3b1e0b633c"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6704), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("636159c6-f568-4572-bf6d-41384ac431e2"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6679), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("638ad24f-1fa5-4d6d-bfd2-ca0289a1cd08"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6402), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("646fcb5c-7ea5-48dd-adac-ccc107f0fb7a"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6698), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6518bd88-8e34-4351-85d0-0c9f14998ae7"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6589), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6545aef1-665f-46c1-b8c2-f614ecbed836"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6603), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("667f9f03-75c2-4338-be15-e7cb64921d1b"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6463), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66a6d962-9121-4fb6-89eb-64926db1882f"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6844), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("672892aa-4cbc-474c-a3de-9b661160b157"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6808), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("677e1b41-cd77-4500-b1b8-e2ec14c71484"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6367), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("690395da-f9a3-4168-873d-9166d55b3a62"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6919), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("697a65a2-8590-431d-ae61-bee4264bf3df"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6930), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b63dbbd-36da-4d93-9c23-b4ebe76fba9f"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6774), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bcc0ddc-6ff8-4030-8a9d-15999494b935"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6297), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c429e84-9d77-4e43-967a-c804a5bed451"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6977), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ddf4f98-9c90-4d4a-9bae-173a6eb94ad9"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6847), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7006f038-3f7b-47c9-b43c-90466ffc11f3"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6782), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("701f60f8-dceb-45cb-9024-d9651ee2be11"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6900), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70bb0361-7abb-43fe-a02f-b37345ef4591"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6907), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("711c4f5f-0889-4ace-be9b-71094840bb09"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7023), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71a625f5-7efc-4754-80e3-84e72ca506a4"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6506), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("720b8362-f5b2-4edf-bd6d-34b0b0f64f5f"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6527), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7257a0e9-c740-4a33-ae33-fcb1caea7c99"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6715), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("736df934-a936-4a4d-9728-d744e57be166"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6929), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74cd7ca3-7063-4c1e-ba58-23a2140bcfd7"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6984), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7699fc7f-d3e4-43c9-84fe-411717719a4f"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6360), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76ed24d8-8a5b-4c88-b476-66e57afbd56b"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6625), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77765fd7-30ba-407a-950c-2a6d6e5dcb88"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6682), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("778894f5-f814-4a88-9a79-5d7d7d8890c1"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6965), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77fe8b5c-6070-4a36-90fa-60dd94cd5fb0"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6514), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("784acdf6-929d-45f0-90ae-1ddd584646e9"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6781), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a21ecc1-84f7-4b2c-97a1-ea789d0cd1b1"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6852), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ade56bc-dd92-4a07-9717-0b2dd14a819c"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6804), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7be82a6e-a388-49f4-bc12-89fe2a69b7d5"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6857), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c7056e8-8f27-4df0-b96a-c3c456aa7790"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6294), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7de943e8-0b31-474c-9bd1-d0ce54c5f61f"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6974), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f76fc8c-1fbe-43cd-a565-91edfba88763"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6475), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8060bb92-1a5a-43a4-8cf8-7656594a26a3"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6343), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80d6f190-f4ed-4d4b-8526-b3fa8b87d1a8"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6450), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81d067b2-1e2b-489b-9739-712f6c67e1e3"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6614), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82e2d05c-c596-4bd7-ae67-2df0d5c9a2fe"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6769), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83debbf9-b523-4158-862f-00f8e7e4ce7e"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6712), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84aea2df-d8a7-4571-b49e-85850a2dd370"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6732), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8571e737-58bb-46bf-8273-a2e9d5ff7b2f"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6839), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("872269db-e418-4bd3-85a3-49887ed60c78"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6904), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89bdb7a2-b5b2-4888-b242-47afa84ed937"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6403), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c4a58ff-6181-48bf-9bfc-b68b5a589606"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6512), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d98d9b9-6107-4ffe-90df-5d10dca49fb7"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6859), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8daa0e70-b87a-4546-8e0c-c566617714a5"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6776), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8dae8e15-0ef7-4672-8b85-62230ed3d4a2"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6865), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8dc59411-a3a6-4a06-ae8a-b1f0a8285627"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6337), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ef79f2f-378f-403a-93b8-52cc4a0febe0"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6633), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91153c30-45a3-4faa-8ff5-98082a09a445"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6521), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("934053eb-f00d-4110-8ea5-b7f5224cd2a1"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6978), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("943cd486-109a-4934-8fbd-75c4ec279fb4"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6356), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95d09687-5c67-4a60-af78-cab3b5d4db38"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6726), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96650897-da5a-4a28-bee6-ea35b18d93f8"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6604), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9711d6a4-9e8e-41ea-b86b-2fc0a96b8bd4"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6934), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97b9a99c-bb48-4bbb-808b-dfab324504fe"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6963), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("980cafeb-8308-4109-b8de-bc6bc68fce15"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6901), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("995020f9-5c63-4a96-b9b3-5f3f3c4719e9"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6595), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99617c43-7038-4d6a-9962-b11e2eb57a66"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6922), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9973500b-0b49-405e-8ea2-5927edb7cf92"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6923), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ae64ab9-0954-45d9-924f-7b669adba625"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6248), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9af884a8-9403-40a5-96c7-05042059ab46"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6926), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c21026f-dec1-4f97-9c39-65429b6c8204"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6339), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e211bfc-444c-4ead-82e7-31046430bb43"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6928), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f0f079f-5101-464a-82d7-8f08321f3655"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6620), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f2fd9b9-3ad2-4fbc-acc0-f456e016eef5"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6357), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f51a6c6-078c-413e-b53e-05c42e3632fa"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6644), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a01cfd7f-28b3-4831-b091-2c3a412732bb"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6798), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a06bdbb5-4b52-47a3-84a8-9a7fb47d639e"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6867), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2715dff-6866-44f0-8ad4-2536411be0eb"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6980), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5980bd3-23a7-4307-91a9-0ae496952666"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6932), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a68463e7-de90-4e67-81dd-79d125078f94"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6503), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6a278e2-c03f-481c-b63c-33f1405f4c11"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6334), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6bc43bd-99da-4c7e-a5af-f7d87844948f"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6706), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6e98374-e2e1-4ad1-b0ea-96260b2bbb6a"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6906), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a83dd2d5-6a86-4f13-a75c-c2e1c537a4d5"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6389), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a85d506c-9ded-457b-b50e-27d9085beb4a"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6988), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9c7dcf2-b521-46d0-aaf6-fda3f52c68bc"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6920), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa1d5b63-d223-47cf-80ec-2e05c38cadf5"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6647), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aaaa3e81-3dce-4201-869a-501419ebb427"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6861), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab10d5f6-034e-45b6-b171-d5519e9238bc"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6971), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab35b24c-b388-447f-9659-63cecea534ba"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6333), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac29b7b5-93d3-4428-af9e-b13e87f74189"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6989), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ace50c2f-c55a-4cc7-ad94-7f6f6fae135c"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6600), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad62eecb-2c2f-45e8-8cbf-c58dfcf567d1"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6502), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af2d3f82-81d1-4a84-9691-530f849bf351"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6687), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b01913a0-258d-4df5-9bae-5d03bb09b578"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6832), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b07c5b6d-1c63-4b5f-8c5e-457343df1ad9"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6496), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3ec2551-13ad-43f5-b322-dbcff0628a96"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6349), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4044340-9f1a-4fe1-a67e-c6a3fed01f6e"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6425), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b50eec46-b01a-4953-952b-181419ec5585"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6639), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b582a6fd-6a71-4773-ad6a-e125d715b4ed"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6855), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b62efec4-1b82-427a-b37b-18311739adb6"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6783), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("baff39fa-46ed-49a5-ad2c-b9bda829cff6"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6914), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcd4cd74-f466-413a-a993-289030a616e8"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6735), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be2d0f7b-166d-482e-b44e-dcaf78316f5b"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6471), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bef917b3-db5d-464d-b68b-6bcba23a9492"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6416), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0738be2-5b77-4d04-a7b6-688a94b401d5"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6810), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cab0c4c5-f37e-4c3a-81c1-2b52e3793cc0"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6413), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb42749d-c927-469e-9e33-af2c38140b56"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6468), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbea57f4-ff73-445a-a5b9-fd5b78b25632"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6790), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ccd879ec-7439-41fa-b912-fad73a2090a6"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6449), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ccfa5adf-ecad-448a-b123-e063160a24ee"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6470), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd600aec-b236-41b8-beb3-13023a25fba0"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6353), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd657130-77b0-4fb1-a6ce-1c6a3e9408b9"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6329), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd81e5e4-aa6e-4ce1-b7f4-21696c5a8989"), "B", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6693), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce81ed05-00d5-423f-9137-ebd91616b937"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6409), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf060c88-c044-4783-aa2d-3c6623fd8aac"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6792), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf3fd333-23ad-4b44-9ef1-a61d5fab974d"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6981), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfb505b8-0187-4398-aca3-ac7de13afa34"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6418), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cffcb110-78e8-46f7-bb8e-cec4e263cab3"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6510), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1562342-6ffb-4b20-840f-41c45ddd2ae5"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6850), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1713541-8a18-4d65-acba-50a3c12af016"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6596), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1d05e46-718f-438c-9ed5-c4a187593fcc"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6729), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d38605ff-58a0-4ee2-b308-7cdd2c29ed0a"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6327), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3e4a767-5cf5-450a-9f5b-bc40d82fb60c"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6909), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d546c831-3e03-442d-a87d-ab45e662acb3"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6455), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d57f3865-79f4-4731-82bc-469621713b55"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6875), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6cdf0c8-fbdd-49df-9300-188befaa4832"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6424), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d80c83db-4efc-47e0-8f44-fcbe2d8395a2"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6302), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8be124f-7cff-4250-b057-155631bb24e1"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6630), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da71f2af-0c2f-4b60-936c-cbb564c752bb"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6529), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc5785a5-bb2a-441f-8629-96de4bcd7ca4"), "D", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6393), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc9ebbf7-bb58-4045-8b5d-9c1a0a560f49"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6525), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddf57938-47f1-4e22-ae92-b872d12a8983"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6787), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0c6a5f4-7aa3-4a7e-986e-0461b56b0726"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6482), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e131f3e5-5361-4318-907d-9c4c46224b08"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6803), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1ea9740-bcbb-4ccf-ba28-40d4f5d84c9d"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6458), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1fd39b6-ef2f-4662-917c-371d97a0eaeb"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6717), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e37e9f03-5563-44df-9cee-27dac1f6a33b"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6427), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3be7c0e-63da-488a-9b74-86649d7729ad"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6870), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e952237f-dddf-4da6-bb75-8ebde1ae0d2d"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6366), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9c780c0-3ae7-404b-9d8f-531cd2d53993"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6609), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb61a5bc-9a61-43b4-bebc-8839d9fbbedb"), "J", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6973), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ecb42497-8132-4892-9496-b110ab2769b6"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6509), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed4436fb-ce6d-49a2-91bd-d0d37bfe3e57"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6842), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("edd353a2-6051-455b-9821-d59b23803e99"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6417), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee03d600-be0c-48b3-80e3-10b5228ed982"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7018), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4db8ffd-2a68-4b6b-b627-8b0a4259539a"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6690), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f59caddd-10d9-42e0-a16b-f991ec00ccdf"), "A", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6420), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5b4da35-9fab-422e-a40c-3194faf622f6"), "I", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6365), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5d9f2bb-34d9-4797-bf3e-36a62945fc06"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6359), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f65a4ddc-d192-408a-9f0d-85b159183812"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6508), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f74f885e-b955-44f5-968a-b2436aa611c9"), "E", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6801), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f899f3c2-864e-4e94-b57d-e682e7dd1e76"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6637), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb6f17c8-99fb-4fc1-8cad-67fcd240076f"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6968), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fbf1dd7d-5ca9-47f6-840f-07e62919c60d"), "H", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6917), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fcbcbb5c-9037-402a-84c8-bf1e97daa9b7"), "F", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6396), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdbfb650-e56b-452d-8314-144add01f3c0"), "G", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7021), false, null, null, null, null, new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff35115e-98d5-4b11-930a-ff3d0f57478c"), "C", null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(6355), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("532ec1c1-cbab-45f0-9a3d-5e384d93dab9"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7433), new DateTime(2025, 1, 17, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7436), false, null, null, null, null, new Guid("dae95ab5-74f7-40fb-8971-70d95506361d"), new Guid("6e4748d3-55cc-4775-824d-75d5f3556928"), 1, new DateTime(2025, 1, 15, 1, 23, 37, 773, DateTimeKind.Local).AddTicks(7436) },
                    { new Guid("727e04f7-6980-4f8a-a8b2-8c6917a159be"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7392), new DateTime(2025, 1, 16, 1, 21, 37, 773, DateTimeKind.Local).AddTicks(7400), false, null, null, null, null, new Guid("fd647e8e-2dc4-49d9-9796-40827db5e105"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 15, 1, 22, 37, 773, DateTimeKind.Local).AddTicks(7396) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("1a74f643-7a71-4fb3-8396-b6e8058984eb"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7547), false, null, null, null, null, 50000m, new Guid("2033de4b-e1c9-4e24-a428-c492b3aa89fa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("538e99ed-d204-49ee-805f-4628f2a15718"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("6437d9cf-79c4-41d5-b16b-72898595eb86"), null, new DateTime(2025, 1, 14, 18, 21, 37, 773, DateTimeKind.Utc).AddTicks(7554), false, null, null, null, null, 60000m, new Guid("1e983ac2-33b7-4e15-903e-34c6664610f8"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("c8cd8600-ae62-4a91-a720-cd4951039085"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
