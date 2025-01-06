using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initDba : Migration
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
                    BillCode = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
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
                    Code = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
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
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6420), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("92537146-aa73-43ba-acc2-4c885ea9d8e3"), "11:00 PM", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6424), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0a658114-0965-4a9b-8ec4-1d06f39e3031"), "Trung Quốc" },
                    { new Guid("13f065b7-ccaa-4aab-91af-0f7a16e45184"), "Vương Quốc Anh" },
                    { new Guid("15ea243c-f969-46f3-a458-fc5efd62c070"), "Mỹ" },
                    { new Guid("508b8c0d-ec62-4e8a-8b6e-ad8d6558f635"), "Việt Nam" },
                    { new Guid("51c52851-f7db-4b93-ae4a-94f77222508a"), "Úc" },
                    { new Guid("55c4a29e-b040-4ed1-8200-ec266dc2b846"), "Hàn Quốc" },
                    { new Guid("6a9afd44-c6f3-4ffb-86d3-bd8c2575647d"), "Pháp" },
                    { new Guid("83a7823b-1a3d-4606-9484-686b9c572cff"), "Ấn Độ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("b632341f-830a-4e0b-b7a3-36db0feb3b4d"), "Hồng Kông" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6247), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("2157151a-5579-49d2-b664-f53503e9af2c"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6241), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("3376a52e-ef35-4c76-b205-5ae4327d7b34"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6254), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("4ac07af9-0fad-428d-a224-4c6996254296"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6258), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("4fbf3868-d97d-487e-8d10-9ade8e53f956"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6249), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("7b289d28-14af-4d31-a4a7-7995a5051b09"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6243), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("804b8799-6ad9-4102-8007-47c635cdf519"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6256), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6235), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("bb4863ca-dbb5-471e-9947-a0780f3ac89e"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6251), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("cdded79f-8446-40da-8f53-0c7c773ac718"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6245), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("174a3f11-95cf-49e6-8e4e-c1d6cc026947"), "Combo 3", null, new DateTime(2024, 12, 27, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7568), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("1e970b58-70c8-4587-b37b-6479b141bb26"), "Combo 1", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7561), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("c1db0ad0-c216-45d0-bf0f-d3d0e846046a"), "Combo 2", null, new DateTime(2024, 12, 28, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7564), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("f28e16b5-cfda-4a03-b400-35515ff31fdd"), "Combo 4", null, new DateTime(2024, 12, 26, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7572), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("13b39aec-a7c2-4a29-9e6e-25fc4ea9d0dd"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6298), false, null, null, "Hài hước", null, null },
                    { new Guid("22b6f2c7-978f-4f83-ba88-b3793094af2e"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6289), false, null, null, "Tình cảm", null, null },
                    { new Guid("3109c07a-97a0-49b4-96c2-8bcd1781768b"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6299), false, null, null, "Lãng mạn", null, null },
                    { new Guid("32e291eb-5943-425e-80c5-4746dbfde50d"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6291), false, null, null, "Hành động", null, null },
                    { new Guid("4d1154ed-3db5-4b6a-aea3-338256678492"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6303), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("6ca4f17d-1ebe-4eca-925b-19040b29df8a"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6292), false, null, null, "Kinh dị", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6284), false, null, null, "Kịch tính", null, null },
                    { new Guid("afc790bb-6e90-4636-8b80-9a1d2593f82c"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6301), false, null, null, "Tâm lý", null, null },
                    { new Guid("c927ca6c-a2b9-4541-93d2-2a6beaaa753c"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6294), false, null, null, "Hoạt hình", null, null },
                    { new Guid("fb7c3f98-e597-4a9c-8c5d-cc3c9b0ae14d"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6295), false, null, null, "Phiêu lưu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("06d81e82-536e-4ca6-bbe6-55e6e77406c6"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6192), false, null, null, "JPN", null, null },
                    { new Guid("32dc8ea1-6180-484b-902e-00c8844d17cc"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6197), false, null, null, "USA", null, null },
                    { new Guid("5c97db72-e2d0-4603-8184-6ef2f343742b"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6199), false, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6186), false, null, null, "EN", null, null },
                    { new Guid("dabfa242-6455-4af7-b98c-3ad24dd720dd"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6194), false, null, null, "ThaiLans", null, null },
                    { new Guid("e3455655-027b-4ac9-8ad2-3730444a4eb1"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6190), false, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(5451), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(5456), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5326), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5347), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5345), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6392), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6393), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6387), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("0ac5cc57-f45c-4e81-9fb3-3c3d8c6275a2"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("0e624cab-8546-404c-abb2-12168a6a7886"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("298b570a-09f0-4483-81cf-82aa78621618"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("4244f1b4-abe0-4e5b-90a3-6ce07290abab"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("52b71ffd-fcad-4fd6-82ad-c5f25afae9af"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("57207540-4dac-4829-9d12-f04ce585ad7e"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("99a35524-5335-42e7-baa0-a508000c8c87"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("acc6dacc-bd13-43e0-b50d-6cfbed15e1c9"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("b7b0df90-ee15-4ff3-9e68-752780862f85"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("e2c2f34b-b08a-4d25-9830-ff67a4ebe10e"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7506), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("03724919-0a64-4413-9245-a9303beb83aa"), 13, new Guid("15ea243c-f969-46f3-a458-fc5efd62c070"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7358), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 118, new Guid("afc790bb-6e90-4636-8b80-9a1d2593f82c"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("0dc639dc-5bcd-49e6-b412-6897edb87c58"), 18, new Guid("6a9afd44-c6f3-4ffb-86d3-bd8c2575647d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7273), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("2157151a-5579-49d2-b664-f53503e9af2c"), 81, new Guid("13b39aec-a7c2-4a29-9e6e-25fc4ea9d0dd"), "xich.jpg", new Guid("5c97db72-e2d0-4603-8184-6ef2f343742b"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("1bfb3047-9196-4cb4-a45d-06ddf63d51ae"), 16, new Guid("6a9afd44-c6f3-4ffb-86d3-bd8c2575647d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7288), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("cdded79f-8446-40da-8f53-0c7c773ac718"), 109, new Guid("6ca4f17d-1ebe-4eca-925b-19040b29df8a"), "yeuem.jpg", new Guid("5c97db72-e2d0-4603-8184-6ef2f343742b"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("2ef29d2e-9a3b-44a3-abe6-4926294cb76f"), 18, new Guid("15ea243c-f969-46f3-a458-fc5efd62c070"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7372), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 127, new Guid("32e291eb-5943-425e-80c5-4746dbfde50d"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("35fa3acb-0621-4387-9ad5-da23d9bb61b5"), 15, new Guid("6a9afd44-c6f3-4ffb-86d3-bd8c2575647d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7328), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("cdded79f-8446-40da-8f53-0c7c773ac718"), 110, new Guid("fb7c3f98-e597-4a9c-8c5d-cc3c9b0ae14d"), "chuyennhabanh.png", new Guid("5c97db72-e2d0-4603-8184-6ef2f343742b"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("4a999abd-f6e5-4109-8ab1-0cae8d1ebafe"), 13, new Guid("6a9afd44-c6f3-4ffb-86d3-bd8c2575647d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7342), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 113, new Guid("3109c07a-97a0-49b4-96c2-8bcd1781768b"), "cuoixuyenbiengioi.jpg", new Guid("5c97db72-e2d0-4603-8184-6ef2f343742b"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), 16, new Guid("6a9afd44-c6f3-4ffb-86d3-bd8c2575647d"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7257), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("13b39aec-a7c2-4a29-9e6e-25fc4ea9d0dd"), "ngaiquy.jpg", new Guid("5c97db72-e2d0-4603-8184-6ef2f343742b"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("86d92ed5-485c-490e-b38b-98773eb9c9ac"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7321), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("7b289d28-14af-4d31-a4a7-7995a5051b09"), 110, new Guid("3109c07a-97a0-49b4-96c2-8bcd1781768b"), "tretraukhongduaduocdau.jpg", new Guid("e3455655-027b-4ac9-8ad2-3730444a4eb1"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("a4d64f3e-67ed-47ca-a9b9-36eff660d495"), 13, new Guid("51c52851-f7db-4b93-ae4a-94f77222508a"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7350), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 123, new Guid("13b39aec-a7c2-4a29-9e6e-25fc4ea9d0dd"), "kinhvanhoa.jpg", new Guid("32dc8ea1-6180-484b-902e-00c8844d17cc"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("b415d670-c0aa-4d6a-a39f-d982ea586e15"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7336), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 100, new Guid("3109c07a-97a0-49b4-96c2-8bcd1781768b"), "chayngaydi.jpg", new Guid("e3455655-027b-4ac9-8ad2-3730444a4eb1"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("bbac0287-d260-405d-ad46-57d39da676cd"), 13, new Guid("0a658114-0965-4a9b-8ec4-1d06f39e3031"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7365), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 134, new Guid("32e291eb-5943-425e-80c5-4746dbfde50d"), "cuocchien.jpg", new Guid("06d81e82-536e-4ca6-bbe6-55e6e77406c6"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("cf1b4714-b9f2-4ae1-91cf-23e7d8944153"), 13, new Guid("51c52851-f7db-4b93-ae4a-94f77222508a"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7280), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("7b289d28-14af-4d31-a4a7-7995a5051b09"), 113, new Guid("fb7c3f98-e597-4a9c-8c5d-cc3c9b0ae14d"), "congtubaclieu.jpg", new Guid("32dc8ea1-6180-484b-902e-00c8844d17cc"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("d9677798-eaec-42b0-b42f-680424db72a0"), 13, new Guid("51c52851-f7db-4b93-ae4a-94f77222508a"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7312), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("2157151a-5579-49d2-b664-f53503e9af2c"), 120, new Guid("3109c07a-97a0-49b4-96c2-8bcd1781768b"), "botubaothu.jpg", new Guid("32dc8ea1-6180-484b-902e-00c8844d17cc"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("f1db4989-adc4-4208-817b-bce8c9686083"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7296), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("02752ece-bb9a-4ff7-8641-5a0661980407"), 99, new Guid("13b39aec-a7c2-4a29-9e6e-25fc4ea9d0dd"), "tetamhon.jpg", new Guid("e3455655-027b-4ac9-8ad2-3730444a4eb1"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("f4a09aca-2069-4291-bd6e-e454d0bc5a5e"), 16, new Guid("15ea243c-f969-46f3-a458-fc5efd62c070"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7304), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("32e291eb-5943-425e-80c5-4746dbfde50d"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6462), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6469), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("035d4fef-926a-40a7-931b-f69a924ae481"), "Bắc Ninh", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5992), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("12368991-2aea-4b92-8c8b-f90615da7545"), "Hà Nội", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5867), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1974c42b-237f-4a28-b8f3-aae7bccec84f"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5938), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("228d7c88-f9f8-4a05-9a81-96028876aa4d"), "Nghệ An", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5960), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("33a130e9-541a-4c4b-89ad-59dde36398e9"), "Hà Nội", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5513), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("356897ae-1b6e-4a12-845b-f137b1fc5318"), "Hà Nội", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6130), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("38b766c8-da11-4b73-afe0-2edaca7d25a2"), "Đà Nẵng", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5915), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("43d2f597-f334-4794-95c1-b26c5625ff47"), "Hưng Yên", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6031), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("62e3d421-d85f-4496-ab7d-44e04df6d294"), "Quảng Ninh", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6110), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6cd1fea4-415f-4437-bc93-f4e961cc2a5c"), "Thái Bình", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6012), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8a91d722-b0dc-47c9-845f-3b1843c2bc77"), "Nam Định", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(6052), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("dd6b9733-c551-4242-9716-9a4c4b71cd10"), "Hải Phòng", null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(5892), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("0bc9d705-239f-4df7-99ab-dbd0e2c606cd"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7446), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 8, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7444), new Guid("52b71ffd-fcad-4fd6-82ad-c5f25afae9af"), null, 0 },
                    { new Guid("29565312-bb1c-47f4-a3be-da65c16b03ba"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7451), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 7, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7450), new Guid("99a35524-5335-42e7-baa0-a508000c8c87"), null, 0 },
                    { new Guid("4346df6d-1819-4bee-bb65-04f0614eb867"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7479), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7478), new Guid("298b570a-09f0-4483-81cf-82aa78621618"), null, 0 },
                    { new Guid("769554ce-3e5f-4184-8989-54bf4da14a96"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7460), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 5, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7458), new Guid("4244f1b4-abe0-4e5b-90a3-6ce07290abab"), null, 0 },
                    { new Guid("87f67371-add5-412f-8423-130c6a9fc3d9"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7455), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 6, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7453), new Guid("0ac5cc57-f45c-4e81-9fb3-3c3d8c6275a2"), null, 0 },
                    { new Guid("b321571c-9c90-4bbf-97e3-f85488f705c3"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7476), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7475), new Guid("acc6dacc-bd13-43e0-b50d-6cfbed15e1c9"), null, 0 },
                    { new Guid("cde86343-2383-4dfc-9427-5b929d9afee8"), null, new DateTime(2024, 12, 29, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7472), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 4, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7471), new Guid("e2c2f34b-b08a-4d25-9830-ff67a4ebe10e"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00c91b79-bef7-4b7f-9938-c75790af2052"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6940), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00eedd6f-5fc1-4c31-869b-744271ae1def"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6716), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("025ad271-8a7d-49a9-9f9c-a1a252102091"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6619), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02900bf7-5a42-4312-8e8b-c19cb49ed300"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7011), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("041c4149-78d5-4e04-b1c9-352fb213e9b0"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6910), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0450311f-1a42-423d-a6c0-eabcbb8a387a"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6861), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("045887cc-9233-44a4-9ae1-5ac8fe20fa5c"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6942), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("058d4f03-846a-4bc1-9607-81bdcce8bd75"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6869), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("066f55c6-59f3-4d0e-8832-a8df6e31ccc4"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6608), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("074250c9-4408-433e-a509-a90ba99a80ab"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6636), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("098d8bf9-6566-4c17-b8dd-c108994ad224"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6991), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09a73720-6bd8-4c2a-af26-e916c9cbe640"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6914), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c177308-2e9d-4ad4-90cd-060df9109b00"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7018), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10362ff9-12f8-4fa4-910a-5e39b1bc7b11"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7071), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11454ad6-9eab-4e25-9cbb-2d89b171da3c"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7094), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("121aefb2-c7aa-47a0-b9f9-2e30fe4496a7"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6955), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("125f9457-0151-4f75-9e09-12c4f6df06f4"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6734), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1369c0c1-c2d2-4e5c-9771-16fc09c8cb6d"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7048), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("137c96f1-5e6a-412b-8d5b-59d014d72d76"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6938), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14810609-a64e-43d2-8c98-b51e740968d8"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6924), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17b9e5b1-dbe3-4d86-9ce3-5665b4a243da"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6903), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17f81931-7727-476b-b65b-0b68052bff32"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6704), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18119041-f67b-4bbe-b09f-808fec6b780c"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6889), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("187d530e-26a2-46c2-b495-08821955c8e4"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6872), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18b70006-4d42-4dd3-8a89-a9bd8c67d9a4"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6494), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19d38c54-090e-4cb4-87d2-5e266736dddc"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7055), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1aaff45e-1614-4dd4-a0e0-b503c4e7dc6e"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6794), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ac2d0ca-8118-402e-8506-e5b7076e113d"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6881), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1afa6673-0110-4e84-b148-fb5e65d05069"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6613), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cbf794f-a59f-44e5-8d09-6b7f9f735b94"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6747), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1da908e1-dfec-4b2f-a485-50904fd0f1ec"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6688), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1def2284-b3ba-4955-9615-b13d9b44cdf6"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6776), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f659d0c-efdf-4946-a9bf-9bb4c74a3f20"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6825), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f88d0f0-129c-4993-95ba-cb9b0b10e0f4"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6949), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("203563a7-aa6b-431a-a443-6283f9c56dcd"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6645), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("211a2fbd-56c5-4a09-8bb1-6dd258d9e4c4"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6757), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22191918-7e0b-442a-aeb0-f31b8c213f14"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6969), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22a14cec-12be-44b4-bef2-9f3f0f4359a6"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6601), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24e80359-691f-40ec-ba0b-a963f2f39791"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6609), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2514015d-4b5e-4fd1-9edf-939dc882345d"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6982), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26d638f0-6038-40eb-9806-e77047cf1ee2"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6883), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27623c99-a254-4adb-ac0b-2a3be1128062"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7007), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("292be03e-d366-4bab-b7dd-0f48843eb43a"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6695), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29da43d1-8d26-4d76-abbf-a702fd9195e1"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6690), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a20cd3a-90a9-4eab-ab7a-23e6f2c707e7"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6994), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ab175c0-97c0-4c92-a177-75a51197c9bf"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6844), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b34df7e-6ebe-447e-bed6-6841d60a71d8"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6773), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b6119b6-95a8-4df5-afbc-d029d9679138"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6538), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b81a36f-89ce-4733-a9c3-8cd636d0030d"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6919), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2db2bd9b-bc9a-4ab1-b127-7d98c3abc745"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6787), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e9564fe-2f33-47da-ba24-0e19c5705586"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6547), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f682449-c073-4b19-889f-1183bc335a6f"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6741), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("303d5c7b-ad77-4592-924d-5b37aaea9aff"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6847), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30e5305e-12f5-4337-98aa-c9b57bd1a87b"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6657), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31501657-143a-4849-8d50-aacb277b9718"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6842), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("319f911a-71b0-4c59-b336-57e4dc68967f"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6935), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32c5fa17-a8c9-4187-94a5-f5f44e037c00"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6750), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33d4db76-9fd8-42c1-a9c1-ab37fd7c0e85"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6672), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3425f80f-cce7-4c8c-bf31-d520805d722c"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6816), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("349bf621-fc49-4ce5-9127-ab2624bb5874"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6840), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34daae05-d54d-4f1c-9c24-301064850b0b"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6574), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("386d0223-d9fc-4b3f-99d6-5225a99553e5"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6599), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("395078c8-2168-4bc9-84f9-6de48ca7d61b"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6813), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39ddf158-1a8c-47ec-ae0e-e14beb53f5d5"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6894), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a953adf-a080-4fdf-864e-f7781a2cb126"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7041), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ac7252d-7941-4041-aa0b-67fae24c9386"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6821), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d015edc-f7e8-46b8-b76d-37f730eeee56"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7062), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e029aaf-3be0-4c29-bf0e-e3c878197ab1"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6729), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e0a3500-6f90-471e-a07c-33ae4b6da1ee"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6652), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f6c59c4-8264-47fc-8990-36a4031d3438"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7027), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40c33f77-a961-4c08-af5b-796584df14a8"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6663), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42f8acec-c6b9-48b0-be9a-b6e4384d5f38"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6592), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("431aded3-2529-4476-8f71-1af6674fe61a"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6535), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("448579fd-fe71-486a-8864-63342edd9f66"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6855), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44bf9657-a719-4e68-bd13-18ecaff2bc1c"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6859), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44ec0a1f-5f44-4316-a5c4-6df166fc4faf"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6874), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46e5975b-429e-470e-a65a-dba3ebfe7d60"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6707), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("484d5831-8a08-4331-b1cd-df4fe76eada8"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6804), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("493c2e0f-fb6f-4224-a56e-c74f9703a2d1"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6977), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("499aaa2d-f695-4dbd-9f38-d4afb8c8ede7"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6886), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49b666ae-812f-4a37-92f4-47f46de8dbdb"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6823), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a280a77-2c30-4a20-be47-8cfe94dea067"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6791), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a96ee2f-2146-4ac2-9c81-baef2528946b"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7085), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b72f2f9-5e44-471e-a6cd-c237d081fdba"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7023), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4bb246e3-1ebc-4644-9c12-f91a45638a4e"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6641), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4be71571-e0b9-489c-bc05-3a1d8e260031"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7030), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d3648f7-821b-43ce-a76b-5157e44c7e4e"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7009), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dcccf85-55d9-4fdd-9f7b-e362d82b8af6"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6912), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e4e001c-162b-4e59-8efa-4d194d68f819"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7097), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ece5bb7-1333-4429-8b4b-30b19a87083b"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6973), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("504558e2-91b9-4daf-baec-c3aa4d40b1ab"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6702), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50c63d45-f15c-41cd-baf5-323ad51f9b2f"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6818), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53b4584a-d9ae-4059-8664-ec44e2883329"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6867), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("543e1c0f-4e7e-476f-9d50-178b29fce1c6"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6770), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("562ae9d2-7505-40fc-8aae-58ed8f242962"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6896), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56832e60-96e1-462f-bf0b-e3d63457c301"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6602), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56ea2d0d-c025-4f7a-88b2-4baf31385304"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7064), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58412e5c-ad70-4ac9-9458-d1e16a2f4347"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6980), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d1b5420-5698-4d38-837c-f713e421bb4f"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6587), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5df51d61-d1b4-4499-b68e-04e9460064c8"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7016), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e38f4c0-9f25-4806-bea7-6d5eb32da149"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6950), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ea196f3-a00d-4006-aad9-6622ef439adb"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6623), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f17460b-0256-4b0f-826d-16ee72d58f5d"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6606), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fe0d669-4c35-4dec-a1d6-266c1bb4e6a4"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7050), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62b90f54-a011-451f-9b09-497fe699bfd7"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7025), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62ee6ad3-bd69-4828-a775-29d82bf36cf4"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6640), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63e74112-9943-498d-a993-09a25fddc79b"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7012), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6540c6c7-e4c2-4fa9-be7b-7f6a50f4444c"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6638), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6570e101-6889-4acb-a69b-b02138ddc192"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7052), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65c1db90-de63-4a8e-a851-d69c1ac2f860"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7083), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67ee270e-f00e-4f04-9782-980347d8e44f"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6944), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68a5b4c7-3865-42cb-91d4-11eafff50254"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6738), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68d59202-1435-4a93-810e-f7e2a80189b5"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6658), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69aa310b-e140-40a0-91c0-38c080ba2988"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6705), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69d1542d-9c84-4401-a7d5-c79842ab3ce2"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6806), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69f88477-409a-45a2-a6c6-3f8f6f3be7e0"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6621), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e85fe12-5cfe-455e-801b-8460db0fdcba"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6901), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f91c80f-28ff-4cd7-9f46-a000a5867f6d"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6797), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("711ecefa-b901-429f-9be6-4d09909fcf6d"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6692), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71bf3d53-d7b6-44c4-b25a-9bed1a0d96c0"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6549), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7383f62a-6d31-4a79-8334-d129ac90b925"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6852), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7516a463-df1f-4e3a-97b3-7ccdc8386d85"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6676), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7760808c-8f0d-43f7-9997-e71684e7bb67"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6643), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("797642a9-da5f-4c67-b862-3a6692278af5"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7068), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7983ca4c-dd43-479c-9522-c293a5c3f7f3"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7032), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a18dadc-b529-4dc7-a841-250fe8e263b6"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7044), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a757b84-2957-455b-9fc1-7d68f0a9f0ac"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6570), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c2967d0-89e7-4a1e-9ea0-a8b5d0942f9e"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6604), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ff77352-4e50-4d12-afe0-817b0647bbee"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6926), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("802d790f-4d9c-44be-bb9e-71b4b30588c0"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6585), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("804e74e6-0542-4749-9a8c-04fbde8d6fcb"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6761), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("809deb59-217a-4d92-b67d-ce8851f828a5"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6893), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("831ba8bb-e025-4591-a83a-7b8f2f0f6864"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6799), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83b141db-f9f8-4410-a172-8a988d4171d1"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6648), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("844672c2-681e-4fab-a85b-4c6d2d24d213"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6835), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84a49075-2117-4e2b-ab4d-cbb9913eade7"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7046), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85f7df39-adc5-4f3f-91ef-c9e320c487a7"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6917), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("863d7de5-f4d1-4735-9d1d-1b6e5fcdf48d"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6993), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("869fbe77-82f5-45fd-865d-5d76c6ff8a6c"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6743), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87f53710-6399-4db5-a139-316f1630da4b"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6653), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a15416f-e800-49f8-8dfd-0a2d1cb9b128"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6555), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a5157f5-ec65-41fb-a3e2-299baefd47ce"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6650), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a6e88d6-1616-4f9e-956f-0dd18ef94db9"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6838), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b50f291-e664-4734-ac9a-27e356e0ba7a"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6678), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c1a5859-d9df-4a8b-8987-ce30605de820"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6857), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c8203c4-2cc6-4a5f-95c9-3e4e46167826"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6568), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d57d98a-a552-4228-8eb8-a11303e72af0"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7034), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8da901ac-a8f2-4715-a117-72f4f0dd63ed"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6837), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f55e6a1-e997-4f74-b9ab-27bdd6d0b6e0"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6624), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9102fb52-9ded-4119-8ebd-dfaa4bbecb3c"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6681), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("910f2027-ca64-461d-9549-af81601af816"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6820), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("927ea8e7-1196-4a1f-87cb-fd2f74636796"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6927), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("929dc630-5b9a-4360-b188-79b542354e64"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6557), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93a2a3bc-982d-4fee-82ea-9aa4af046f2a"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7057), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("981d0a9e-5f4b-4769-8fdd-389f8bf51901"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7002), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98979b08-f8c2-42e0-916e-8145f1f1fa37"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6709), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99ee9c25-4236-47e2-857f-16b3f082bb3c"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6697), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ad1366c-b140-4d8d-82d6-b7a23bd32cbb"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6711), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b33272a-951b-4f08-a71d-be096b2c6783"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6922), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d041794-a8a7-4d45-8555-5f022f0d34ca"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6962), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ec76461-3d2e-44eb-abda-6f21379169d7"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6736), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ed92af3-ef68-49e6-9c58-37e1f47fb20b"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6754), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9efe57bf-67a9-4443-9ac4-c5201ea11f50"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7060), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f458d3a-3417-4014-b0a8-483b1e7cada9"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6854), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fab88cf-29c6-4cf3-93a6-f572bf0b0cbd"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6674), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0ee3c8f-e7b2-4913-adb1-aa8e71f80143"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7003), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a126be8c-c5bf-4413-a509-0538809b62ce"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6635), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a294e4b5-d98c-4493-afd9-24a7f8a0baf2"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6865), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2c54133-6bd0-4fdd-a0fe-a479d82f3cab"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7082), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2dda10f-2bcb-451e-955a-21ad5a628cff"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6665), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5bdc08f-b713-472c-a2a2-77238ba2227b"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6888), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6c307bf-19ba-4683-8af6-9b2f45b8f05e"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6687), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7acff0e-318e-477c-bef5-fc62f6efcd0a"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6898), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7e15eea-7e52-4f60-a4b0-eadbf9c7a668"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6589), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a83c4730-3958-45a2-9f80-46d0c8f354e4"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6578), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae6b94c5-9870-48a4-ace3-b7a4bbd64e27"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6633), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aeaa5fbf-be99-4934-a270-e2b259d7af8b"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6694), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aef42199-2a9d-4e3d-9c27-8341ce0fea59"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7000), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af234e26-e2fc-40ec-83fc-fb0b951a7a1e"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6871), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af2ad8eb-a87e-4763-998d-ba268b5cc664"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6966), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af2b5273-c601-4f45-9170-5a98799c6439"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6542), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2b84c3f-ac57-4b39-9e47-082abaf551ec"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6908), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b30cea02-04ea-43dd-a909-12ab6ea66066"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6730), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3f86c39-29bd-48a0-b3e7-c7de0753ea90"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7092), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4194884-7f89-4e71-9694-0b0e4b8222ea"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6626), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4e0325e-063b-4de4-a39b-47fdbfa20770"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6727), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b53b5f7e-6df0-4f4a-80c8-1ac9f04b9143"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7069), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7174d89-69ce-4007-aac5-11ff004dd9fc"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6964), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7902cf1-9c63-4716-8fcc-470b7c225832"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6685), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b86e5549-3f18-4919-95e7-75631f55c150"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6862), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9817631-7383-4ed1-89b8-277be70b2201"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7014), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bae68d0e-f6e0-4b3b-a186-6c0efb9668c2"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6749), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bb3378be-7796-4fb0-b273-6d13c643de69"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6679), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc6a16e0-3ecd-4155-8fa9-769d73bd267a"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6789), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf21b22d-124d-42f3-a64f-ab46ae1ebed6"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6905), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c180155d-ac70-4e0e-9f3d-9a8d3b14e26a"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6759), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c20859b5-afd2-412e-a251-22a3199bfe32"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6582), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2a42ef6-07f2-4bc3-a39e-d29f51fc2523"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6845), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c385ed6c-83c9-4212-9350-f726fa954ef8"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6996), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4b76cc2-e7c6-463f-91ea-c360e74d2c55"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6785), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7230bcb-cc48-40c8-af1e-ef7f8eaec428"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6700), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cbeb14e4-15c5-4148-8fd5-03682e72bcf6"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6752), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc595ac1-968b-4ab3-93ff-71556ae4f1cc"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7078), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce76e0ca-939b-4d92-8c2f-d1831b59f524"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6576), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d04d5404-15ea-4934-acf5-7550731337f3"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6544), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1b31466-c96e-4992-8d85-e359b829e6fc"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7028), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1f1ec0e-c2f3-4f53-ac11-16d988201083"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6998), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6d4e4b1-e420-4537-bad5-331f7fe255fd"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6957), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7b908c0-f80f-4811-9fac-df42a9e486f8"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6792), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da92e125-41d9-4766-b696-822aeca0da27"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6590), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db9dea2f-fbe8-4bc0-aef2-1f83b5ddeb2c"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6660), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbd4ceeb-1e0b-45c1-b2fb-7d4cdf948dcc"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6801), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc0fe3a9-2565-4616-aaf1-8449fdf86b5f"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6628), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc752e99-6d0f-490c-9692-d80bd1abb1ec"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6945), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc9a217c-38f4-42d5-a714-4307557b6da5"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6947), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df75386c-eec5-48f9-b06d-cd9c1024583d"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6597), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e04ffba5-bc61-424d-9cf0-ba988ab2b761"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6732), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e242369f-e43b-40a3-a488-4a9b90e0fe51"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6712), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2b28a37-6d2b-4998-969d-7a6a78bdd604"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7066), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2d02a8d-8438-4dc6-b8c8-57df3ee25575"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7080), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2d5af71-909a-4d3e-b604-34172494d799"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7073), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e301ba67-d7d6-4147-9967-14b21741c2bf"), "C", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6815), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e397b08f-96b6-473f-9615-7a12744cc09f"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6764), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e41ef2e7-133d-4538-8368-aca602c533de"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6745), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4a6fd30-8075-44cb-93db-b1d4e5cbaa78"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6655), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e61ba5f9-3d19-4314-b47a-144781fceefe"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6630), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e61de318-aa0a-4179-8cff-79022d95243a"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6768), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e68394b7-4ab9-47ee-a922-694cb0cc3512"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6959), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7fefd32-41a2-4f6f-9fd5-008688e75225"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6907), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e891825b-1f66-4e93-8149-5060f4dc253c"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6960), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea2efab5-0f5a-468a-96b4-1afc7c2a054e"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6979), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ebf6fb82-ea5d-4307-be05-359ae6badb2e"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7020), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec78dd9d-873a-48ae-9798-02d675d865a4"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6572), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("edf039d2-85a0-465f-9379-0fd95aa313b6"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6920), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee1f7136-0fe3-4d7b-b0f4-918378066fce"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7054), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef7d5123-5044-486f-b16a-e1a19918c3a2"), "B", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7076), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef9ca633-0bdf-4cbe-a540-e6baa4241f37"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6594), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f22f147f-3f05-44fc-87d6-c0aeea6f645a"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6783), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4daa8ef-88ea-4ea0-bf1d-3b06512e7c1c"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6891), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5b211f8-39be-4868-93e7-51223f05656b"), "J", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6808), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f69fccbc-25e9-41e3-8e6e-8be6444ee17b"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6551), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f6fbf357-c594-4b24-8ea5-b6c67a9a3d6d"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6975), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8085efd-33cd-4a35-ba4a-bd51b840c994"), "E", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6971), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f87052c0-4c6f-4b87-b4e2-f83d9c4f8ee8"), "F", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6954), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f87f9384-b99c-42c7-a70f-29916cc06a60"), "H", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6850), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa6d6b51-bac5-480a-b59f-2e9e063ec6a8"), "G", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6803), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb062eaa-7c95-47d8-831a-ff3e172eaec6"), "I", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6583), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb46388e-8204-4555-832a-10a7bf4610a6"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6772), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe15346a-d6c1-40ef-bd79-1e13780afaae"), "A", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6810), false, null, null, null, null, new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff99f71b-23d2-4df3-8823-5ed7ae2a1e2e"), "D", null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(6540), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("7162d774-35e9-48eb-9f3c-e319885b244b"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7414), new DateTime(2024, 12, 31, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7416), false, null, null, null, null, new Guid("0dc639dc-5bcd-49e6-b412-6897edb87c58"), new Guid("bfde53af-89ae-4e13-b88e-41ad06826fa3"), 1, new DateTime(2024, 12, 29, 22, 25, 25, 483, DateTimeKind.Local).AddTicks(7415) },
                    { new Guid("edcd6c4b-3001-4995-a48f-f7df35bbad2e"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7400), new DateTime(2024, 12, 30, 22, 23, 25, 483, DateTimeKind.Local).AddTicks(7408), false, null, null, null, null, new Guid("76180356-abe7-48f6-8e2a-1dba5a5f3a82"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 29, 22, 24, 25, 483, DateTimeKind.Local).AddTicks(7403) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("05d1a8c7-365d-413a-974f-f7ae2b618332"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7536), false, null, null, null, null, 60000m, new Guid("29565312-bb1c-47f4-a3be-da65c16b03ba"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("99a35524-5335-42e7-baa0-a508000c8c87"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("c9ba1b75-091e-4f65-a130-dbafb433c0e5"), null, new DateTime(2024, 12, 29, 15, 23, 25, 483, DateTimeKind.Utc).AddTicks(7529), false, null, null, null, null, 50000m, new Guid("0bc9d705-239f-4df7-99ab-dbd0e2c606cd"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("52b71ffd-fcad-4fd6-82ad-c5f25afae9af"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
