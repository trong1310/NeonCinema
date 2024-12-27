using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class crdb : Migration
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
                    { new Guid("092d96c7-2c69-4f8e-84fc-cd48dd07a430"), "hgdsad", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2841), false, null, null, null, null, "hotdsot", new Guid("40a1d09f-bc20-4032-8992-55d371fe107c"), null, "mua tại quầy" },
                    { new Guid("7db008c8-f4b0-478e-bb00-682614212428"), "phonghhhhh", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2836), false, null, null, null, null, "hotdot", new Guid("55a3b040-f6d8-4250-a759-6d014b769f08"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("61b9b905-5a8f-42ed-a472-31d698d4775c"), "11:00 PM", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1856), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1852), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("001aca1a-ca5d-4dff-824d-b2a4e9a964b9"), "Hồng Kông" },
                    { new Guid("2df2567d-017d-4cea-81c0-11abe39afc6c"), "Pháp" },
                    { new Guid("39583972-1826-4fce-bb92-2cfe729077d1"), "Ấn Độ" },
                    { new Guid("3bf90405-9092-4767-99c7-3d92b4247594"), "Úc" },
                    { new Guid("7c59d6b9-0151-4d08-aefc-41d4fbc1f8ab"), "Việt Nam" },
                    { new Guid("8f46f6d9-6f2c-49fd-b8ff-abaeaadd2f96"), "Hàn Quốc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("cf9f2c65-681b-418c-b617-c720cec9e3dc"), "Trung Quốc" },
                    { new Guid("d462bea4-6e20-4f43-93bc-9fb97f7a9792"), "Mỹ" },
                    { new Guid("f05bc7f7-66ed-4b06-a489-8f7d8529dc1b"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("4c0b4dca-a18d-4689-8a94-8347bb3293ae"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1707), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("5af95dff-0a12-4c3d-ac8d-5127e30c6a78"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1715), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("5d97b4b5-4a9f-4635-a091-0f39a02edf55"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1705), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8a22dc2c-c56d-4556-8b61-1ed7c860dd2b"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1709), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1701), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b8bfcc55-02dc-4439-8e91-74ac57776861"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1713), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("bc66d9ba-103c-4ebd-aabe-84cb1fff7ca6"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1717), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("c748e1ba-dd27-4ff0-8947-809252f21e53"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1722), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1711), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("e3e76ff4-9ced-473a-9754-2d52d95c426b"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1718), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("613e8386-9ae6-4700-a9a8-cfdf67ad13d4"), "Combo 4", null, new DateTime(2024, 12, 24, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2816), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("9d3c9357-fd67-4b2d-b737-4557ea1fc5fe"), "Combo 1", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2808), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("c833abc7-1964-4e49-b22d-7cd6e06ba016"), "Combo 2", null, new DateTime(2024, 12, 26, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2811), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("d471abdc-e46d-4e2d-b8fe-c545e81cd335"), "Combo 3", null, new DateTime(2024, 12, 25, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2814), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("07b347c1-b1a3-45c7-b411-fb914c0b7c6a"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1750), false, null, null, "Kinh dị", null, null },
                    { new Guid("294c35ff-e25e-431b-9808-b74fc78a8a5c"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1761), false, null, null, "Hài hước", null, null },
                    { new Guid("2a0671fa-953c-4fd9-9599-16c4607fd3f2"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1747), false, null, null, "Tình cảm", null, null },
                    { new Guid("2fbdf460-91f6-434e-9c9e-ece3304f337a"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1749), false, null, null, "Hành động", null, null },
                    { new Guid("68139e61-c40e-4d27-af25-1ab3dd532aae"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1766), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("87610e7b-a2af-4261-a41d-d7aea6ccb612"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1759), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1745), false, null, null, "Kịch tính", null, null },
                    { new Guid("c6d6dffe-71cb-4675-bc9b-41f5096dd865"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1762), false, null, null, "Lãng mạn", null, null },
                    { new Guid("dd99d244-7369-4c6f-82a9-a7718a1472fc"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1764), false, null, null, "Tâm lý", null, null },
                    { new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1751), false, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("21090106-a63b-4141-a1cc-cfab812a73ed"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1675), false, null, null, "Korea", null, null },
                    { new Guid("35df00b2-f964-48e8-83ec-acf1738ed3dc"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1670), false, null, null, "JPN", null, null },
                    { new Guid("57fb5c92-3dab-4131-a9b2-1fc0c17ca966"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1673), false, null, null, "USA", null, null },
                    { new Guid("59606cf3-0452-4c46-bac5-3afe2204d8a3"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1672), false, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1664), false, null, null, "EN", null, null },
                    { new Guid("bd4d042e-351a-41c9-b268-2483f2ec77f3"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1669), false, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(884), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(886), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(739), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(757), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(755), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1831), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1833), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1828), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("04cd1bcc-ad8b-423c-bc58-867227a2efec"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("1d40e8e2-ffd2-4b25-aefc-eae849bfbdda"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("38725151-ffb9-4ca4-8e27-d692c180080e"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("3cc51eaf-4dd8-489b-b2f2-a5a7c6193ea8"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("6ec3f0a3-c1a9-4b14-8249-80aa4121a8d8"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("74e306fc-9f87-4c4b-92ac-09a893cade60"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("79e4a437-faaa-4bf9-8f57-f57bfc5b976b"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("7ee64acf-8424-4008-a1ad-eaa7707d23f7"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("8f179f09-ba79-4831-ac7b-84cde6e89ae7"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("c5a26a17-abcf-4db5-b5af-9fb51841e99d"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2761), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("21506ae3-8dd1-4502-a506-a91634a4bed8"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2644), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 134, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "cuocchien.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("2d1b1836-5c13-4851-8a29-2f1630542e9c"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2598), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("5d97b4b5-4a9f-4635-a091-0f39a02edf55"), 120, new Guid("2a0671fa-953c-4fd9-9599-16c4607fd3f2"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("5379db52-d1dd-4760-a2af-4edd9ee76436"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2625), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 113, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "cuoixuyenbiengioi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("57180261-fdd1-4666-b4be-60d8beec1e91"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2575), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("8a22dc2c-c56d-4556-8b61-1ed7c860dd2b"), 109, new Guid("07b347c1-b1a3-45c7-b411-fb914c0b7c6a"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("65122429-0767-448d-ad91-824fa8c4078f"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2631), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 123, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "kinhvanhoa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("6797c2c7-f997-4b20-9880-95c76fac0452"), 13, new Guid("8f46f6d9-6f2c-49fd-b8ff-abaeaadd2f96"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2568), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("4c0b4dca-a18d-4689-8a94-8347bb3293ae"), 113, new Guid("2fbdf460-91f6-434e-9c9e-ece3304f337a"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("82ab74f6-fe5a-4b42-85ef-ffd3525fc52e"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2589), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("832ff7f9-be24-4687-bec2-497c1292d82c"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2604), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("4c0b4dca-a18d-4689-8a94-8347bb3293ae"), 110, new Guid("2fbdf460-91f6-434e-9c9e-ece3304f337a"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("b9f0925b-f3e9-4b3e-bb56-faf5884161f0"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2581), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 99, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("bf05aab1-100e-4533-9a00-1f8df7f62d1b"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2562), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("5d97b4b5-4a9f-4635-a091-0f39a02edf55"), 81, new Guid("2fbdf460-91f6-434e-9c9e-ece3304f337a"), "xich.jpg", new Guid("bd4d042e-351a-41c9-b268-2483f2ec77f3"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("c4f63c40-b249-4f4d-b8ba-85bf1b0b86bf"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2618), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 100, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("cc19028b-9aad-43e0-9bf3-960ced9875ad"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2652), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 127, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2552), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("fe3d8f77-61bc-4006-a241-5d3bd62303f7"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2611), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("8a22dc2c-c56d-4556-8b61-1ed7c860dd2b"), 110, new Guid("07b347c1-b1a3-45c7-b411-fb914c0b7c6a"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("feb4674d-3c4d-4b0c-93c2-699ba23b8477"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2638), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("cabc2534-3eb3-4e46-ab3d-4fb763e64588"), 118, new Guid("f6e35db7-c1b5-44b4-b81c-c52a0fe1dafb"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, "https://youtu.be/1KtBhnTfq8I" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1885), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("ff00e42e-efd1-492a-943c-289257218054"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1890), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("2d98e42e-5afd-497e-9670-8cbd312d8be0"), "Thái Bình", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1528), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("39e1409c-14f7-48a2-ac08-45507b6b18d9"), "Nghệ An", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1491), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4737150f-321d-4a6f-8b8d-7625003a6519"), "Quảng Ninh", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1578), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4aaa269b-9b87-44a6-b997-6ad995d701b1"), "Hà Nội", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1369), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("55f13f14-8021-4aa6-823d-ff4881a877b0"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1471), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6c633916-de41-430d-aed1-ce8f5d3d7f78"), "Đà Nẵng", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1444), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("76dd92f5-0ee5-4d17-8f31-70ca1066e1d8"), "Hưng Yên", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1546), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7f85b818-f57e-4b71-8bbf-8e65f158177a"), "Hà Nội", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1020), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("920d85dc-9dfb-4361-bc13-a4a40099f5ef"), "Bắc Ninh", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1512), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bcbb7d91-b966-4aa7-b6f7-05deb8dd254d"), "Hải Phòng", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1415), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c2e723ca-6f53-4b69-bb43-cb30b5e12392"), "Hà Nội", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1624), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("d87b766d-94c9-43eb-9639-fe80bd3550f6"), "Nam Định", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(1563), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "AfterDiscount", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PromotionID", "Status", "Surcharge", "TotalPoint", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("144ebb9c-227e-427f-9b4b-06006514a8e6"), null, "BILL0122", null, new DateTime(2024, 12, 23, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2889), false, null, null, null, null, null, 2, null, null, 680000m, new Guid("39e1409c-14f7-48a2-ac08-45507b6b18d9") },
                    { new Guid("1e72ef44-afc0-4520-aa1d-df617c7d0f5d"), null, "BILL009", null, new DateTime(2024, 12, 19, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2898), false, null, null, null, null, null, 0, null, null, 350000m, new Guid("76dd92f5-0ee5-4d17-8f31-70ca1066e1d8") },
                    { new Guid("4ea98772-ac7c-4370-89ee-536719347027"), null, "BILL007", null, new DateTime(2024, 12, 22, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2892), false, null, null, null, null, null, 1, null, null, 800000m, new Guid("920d85dc-9dfb-4361-bc13-a4a40099f5ef") },
                    { new Guid("5418e5e4-cba1-4829-9442-08637e3e66a5"), null, "BILL002", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2865), false, null, null, null, null, null, 2, null, null, 300000m, new Guid("4aaa269b-9b87-44a6-b997-6ad995d701b1") },
                    { new Guid("5b4b00a2-ba77-4efd-b246-c71c90918a05"), null, "BILL001", null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2862), false, null, null, null, null, null, 2, null, null, 500000m, new Guid("7f85b818-f57e-4b71-8bbf-8e65f158177a") },
                    { new Guid("7e79b4d2-3f15-4a65-8821-8ff3f1bf260d"), null, "BILL006", null, new DateTime(2024, 12, 23, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2884), false, null, null, null, null, null, 2, null, null, 600000m, new Guid("39e1409c-14f7-48a2-ac08-45507b6b18d9") },
                    { new Guid("8d41f3c2-cf20-43fb-bb74-7607e8f984f2"), null, "BILL010", null, new DateTime(2024, 12, 21, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2901), false, null, null, null, null, null, 2, null, null, 700000m, new Guid("d87b766d-94c9-43eb-9639-fe80bd3550f6") },
                    { new Guid("be6090c5-a83f-4972-bfb8-f254368e107a"), null, "BILL005", null, new DateTime(2024, 12, 24, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2881), false, null, null, null, null, null, 2, null, null, 250000m, new Guid("55f13f14-8021-4aa6-823d-ff4881a877b0") },
                    { new Guid("d09e7742-3059-4b0e-91dd-15bfd9e53a81"), null, "BILL008", null, new DateTime(2024, 12, 17, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2895), false, null, null, null, null, null, 2, null, null, 450000m, new Guid("2d98e42e-5afd-497e-9670-8cbd312d8be0") },
                    { new Guid("e9f834ce-23f6-4df3-a351-408b1a65e08a"), null, "BILL004", null, new DateTime(2024, 12, 25, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2878), false, null, null, null, null, null, 2, null, null, 200000m, new Guid("6c633916-de41-430d-aed1-ce8f5d3d7f78") },
                    { new Guid("ff09fe74-8dc1-46de-919c-4a54cae060ea"), null, "BILL003", null, new DateTime(2024, 12, 26, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2868), false, null, null, null, null, null, 3, null, null, 150000m, new Guid("bcbb7d91-b966-4aa7-b6f7-05deb8dd254d") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("d24057db-9307-4f61-8986-01436349e47f"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2960), false, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2964), 1, new Guid("7f85b818-f57e-4b71-8bbf-8e65f158177a") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("013f2363-9594-44bb-bfba-5c477633f9b6"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2727), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2726), new Guid("04cd1bcc-ad8b-423c-bc58-867227a2efec"), null, 0 },
                    { new Guid("015d6e6e-23d2-4bb9-b0b2-083145d5def4"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2720), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 5, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2718), new Guid("3cc51eaf-4dd8-489b-b2f2-a5a7c6193ea8"), null, 0 },
                    { new Guid("02309158-b8a9-4975-b441-7a04b2709453"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2723), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 4, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2722), new Guid("1d40e8e2-ffd2-4b25-aefc-eae849bfbdda"), null, 0 },
                    { new Guid("1e6469d0-7c23-4089-8c34-93b56fc28772"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2739), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2738), new Guid("79e4a437-faaa-4bf9-8f57-f57bfc5b976b"), null, 0 },
                    { new Guid("4351c976-b605-4976-9e03-5deb8f0cd4d6"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2714), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 6, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2713), new Guid("c5a26a17-abcf-4db5-b5af-9fb51841e99d"), null, 0 },
                    { new Guid("4a64064f-9f14-4299-9155-522df816cb5c"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2730), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2729), new Guid("7ee64acf-8424-4008-a1ad-eaa7707d23f7"), null, 0 },
                    { new Guid("7e6ab3f7-f1e7-4803-a2cd-2a32dcf5d867"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2736), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2735), new Guid("74e306fc-9f87-4c4b-92ac-09a893cade60"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00179636-7f38-4b20-87f2-e1040e68c736"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2127), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("013ce950-aa06-483f-a2c5-574e80d072bb"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2105), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02037fab-8369-46f3-a4ec-3a1882b705d7"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2398), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02669bfe-d74f-44b2-86e0-1ad3ecbfef38"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2079), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("036fde21-9b0d-4f4f-a976-f8ed0f3d9cb9"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2325), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03f133d7-0bfa-4c8d-b7dc-8da0de4e3c77"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2275), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04a1cbf6-ed32-46cb-86c3-49ad18f59e57"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2256), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04ead300-1612-442b-8139-febbd5129d40"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1988), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0661251b-8ba5-45b2-ad0e-874fec89a12e"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2316), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06a0a731-12be-4133-96e9-9eb7f21af960"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2281), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("073141af-73ab-4867-b302-6ef90db6973c"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2395), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("07aad15b-591d-4ab9-8d3c-f7c2390e8207"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2200), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0806f124-9386-4896-8bf0-d809d1f55f24"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2007), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a3dc9bb-8273-4a70-8822-a5d15767fd3b"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2274), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e899ee2-786b-4bc7-a17a-d3d44fc030fe"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2245), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0ef8611a-0591-46c9-b493-2a623d2451bc"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2401), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f2554f8-455c-40c1-925f-3e6a9a0dbff5"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2056), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12f3d848-567b-4c61-aae1-94e276ffcb6c"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2182), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("166ac98e-9e17-4ed3-a338-76c6a1c96bef"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2326), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1831a85a-d746-4d6f-b7c4-8e773c1a2f31"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2283), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1890ab92-4283-4e27-949a-a5302ac9cf04"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2078), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18d993d0-dc6f-45e6-87ef-59658b250f9d"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2328), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("196edbe5-06e5-48da-b3c9-ff7105c76310"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2153), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c1b4c2c-86d9-48cb-ba29-771a940c21bc"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2028), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d2ff8a9-256b-484c-b734-39c01681bc9d"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2235), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f41b8eb-929d-4675-b8a1-6cf5e7c4c8e9"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2152), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f4df688-3d6d-421b-9043-1f86a2fbd3a8"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2025), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f98c684-2b94-4b82-8e1e-67d9222193d2"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1998), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22a47cbc-5fbc-4823-b853-cb177981afd2"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2384), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23c011bf-0a9b-40d2-b6f7-1ce4135e48d3"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2370), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24d7c1d5-fac1-452e-b695-8ea54739732f"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2298), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26ad3a11-6e3c-4915-8781-574b9027ca3b"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2276), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a4a0603-df79-4461-a1b6-5a5798520646"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1973), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c97cec5-f493-4006-a22b-f3c9209d3df1"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2096), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2cd5acf6-0643-433f-9a35-e8e6764bb0b9"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1969), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2dde87e2-9083-4b99-a0c5-0565c6ff5369"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2016), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e7e21d4-b50f-4943-ae6c-1d22c8cec7ea"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2329), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30dc688e-7519-4301-bc44-d9e7defb9d0f"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2027), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("316a44dd-e0d9-482d-8130-d4bebd7a1eb1"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2241), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31e67d41-9519-4d01-8371-81cadeb229d6"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2116), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32cc4163-26a2-4cf7-a026-96ef348031a5"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2033), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32f9120c-c803-49ff-a330-2e1c794819c7"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2228), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3484db4f-3937-4d3b-b804-03d0c13650d3"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2017), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34ea6292-6379-47ce-a577-6aee76c62836"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2196), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35671e96-48e7-4c82-9183-5aeb88922781"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2400), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("388ab0c4-0b93-4e5a-8a18-3ba88e8131d9"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2001), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("388edf23-5439-4259-b88e-11d4255164c1"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2021), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38c9548c-3b2f-42ca-abbf-7b952d3114d5"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2190), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("393fbd13-ca2c-4a9b-9ce2-2d31c1e7f01f"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1978), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d0a8c7d-2f65-4ced-8c4a-540ff6eaf4bb"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1991), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d663944-339e-427c-b14c-45c6bb202831"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2278), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e399ad0-f718-480c-a072-7341712f9e0a"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2378), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ef82c56-ccf4-4328-9560-7484ba84c4c5"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2030), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f8ef535-9c44-4441-a994-9544cfe186a6"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2074), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("402ccb2e-2c81-4403-9b83-774c037a58a0"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2224), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40735955-2d3d-44bb-84d9-c04a3cdb43fd"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2284), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40a581e2-ac52-4cee-909e-3ab689d839b4"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1972), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42ad5f5a-dc09-4f48-9194-53e6575a461f"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2082), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4329be44-2079-45ca-8347-c62c0ba4ae75"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2166), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45594798-585d-4de0-b1a9-c9fc79c93bf7"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2204), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46bdaa3a-f4e7-4626-ac56-870ae1795d44"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2301), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47c80146-2e20-4d92-862d-a109a9213bcb"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2251), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("489ec92f-be2f-4d3f-b6d5-2b05ef395d73"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2157), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49436b78-2e2b-45ad-95a1-47ed37eee627"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2380), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a77105a-7879-4a72-82f4-4adc7d202ea4"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1990), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4bbb20d8-d22e-419b-9329-035ced77792d"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2210), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4cc231c8-e785-4a14-a595-f17eea51fc19"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2101), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e3d555f-c2a0-4776-9b3d-912435cf2c71"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2252), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f202bae-655d-40b2-840d-ccb6142ba06f"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2174), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50965769-c6b4-454d-a786-7699a8a261c8"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2031), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52230e86-c9fd-4edb-82b9-23a0484b43ab"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2375), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("537f0247-8f2b-4121-9374-aabe123420f8"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2286), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53dc8be7-0fd0-4df2-a7fe-4b4400e0b372"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1996), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54487b51-5bdd-4bb2-99b4-1acd15f9afc7"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2396), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54ff23f5-d762-412d-b574-77d26e924da3"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1994), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58dc5e70-bf6b-4768-a0e0-14d1d57f986d"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1971), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59ae556f-fc83-41b7-94cf-7543e5cb2929"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2124), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a2bbc04-45aa-4d0d-8176-267a9dacd385"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2270), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a96f11b-6e89-4836-ac01-e0975ae7c665"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2371), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5aab7646-6958-4419-800a-853740082abd"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2313), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ac62283-506e-4b5e-9516-5e06d8635397"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1981), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c8520d9-abd4-404b-bc90-ad65e73a020e"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2366), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f4d08c7-b973-4394-b975-99979bd033ef"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2367), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60fe2826-9d6a-4139-b3b5-4342e4e99c8f"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2373), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6121c719-3f5c-4970-8b86-9f1aa312f51b"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2159), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("627e1bfa-8f6d-42f2-9673-f098d0569e92"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1951), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62aca964-d67d-449a-a9e9-39c99ed74eec"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2302), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62d2f6f6-0a67-4b94-9b7e-cdd5edf96e92"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2000), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6438500b-8e25-47e5-b304-984a3e4ff2c5"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2100), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67624cfd-5b99-4764-8b64-0d643a15540f"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2285), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67fc5b8a-d6d3-4157-96e5-8a500a8167bc"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2113), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("682bfeec-8e55-41e9-9c94-d3946c83bdf7"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2295), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68ab6fb6-2b94-452d-976c-167a202ce60f"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2189), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69688418-c33d-41fb-a71e-c38c379e0f57"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1954), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a3598a8-da1c-4306-a0fa-b18fdfc46fe5"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2128), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c270022-57c8-4117-9c4e-06f60525e904"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2266), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d2434f7-2a2b-4f85-856b-aa7541fff280"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2112), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6eb19ccc-c120-4ad0-9ccd-c4d7868e2eb8"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1911), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f45fd9a-8996-4727-a47a-0a0ca51519ba"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2097), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f90a264-cb52-47c9-9002-34d0f8c94cc4"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2045), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72561eb2-887d-41aa-a574-b9eeab024c8d"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1985), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("738d3e7d-3402-43c7-acee-73ad45b288b7"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2246), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7562044d-b2f9-4855-bff7-74e06b66fdcb"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2107), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7682c1d6-f9c8-47c3-822b-6263114a6bfc"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2151), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76bd7f28-69df-4873-8e1b-c629251b83ab"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2361), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7707013e-448f-4ce1-b31b-16ecbef30fef"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2382), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79093e83-126c-4624-b37f-4f382c78f97a"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2336), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a164d17-eb41-4754-8bb3-267d8c197c9d"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2317), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ea99a94-9930-4a26-9512-a23f1d7d8de2"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2193), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f52b140-4a09-49e5-ad95-8d72bf16f401"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2345), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fbfa431-36ac-4e23-a04d-f70f6605d8ea"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2163), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fd489bd-475d-40ea-82a5-b1515c2a3897"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2402), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80883b96-21a1-48a4-a79b-d7b4c5734aec"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2334), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8330cdc1-d238-4862-a5e1-de5153fefd74"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2146), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83ab2d4d-0d47-420d-bff0-be530116cd7e"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2247), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8460cbe1-6b2b-4c9b-8c35-3c36eb9b0d06"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2003), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8534500a-d11a-4332-a6fc-682db43d52fd"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2231), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8554f267-9ed3-4611-895f-e164d0378e72"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2022), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8663a1f7-e7fa-4f5f-9066-dba823aa3391"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2288), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87249c6a-18ee-48be-9cf8-fe95667d0556"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2162), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87694939-8824-43b3-a864-5d9331f6f333"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2132), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("885b85ec-2250-4cf0-bc64-9ff6b40d4e47"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2213), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("891a9af7-2e3b-497d-962c-ab1721a0e179"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2178), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8982dc8c-6e2a-4d39-9716-985f71b13697"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1999), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89c6cdde-f115-46a1-bc65-4970684d84c0"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2351), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b79b579-9c8e-4ddd-98ad-ece09b6db595"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2086), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8de0e5e2-db8f-4f36-8fb1-e5a326241264"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2070), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("903449b8-5bd2-476d-ade3-e5a13363e849"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2379), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9086f7df-842c-4ea7-ba2a-ed455d7f3c8f"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2199), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90a198e5-4215-4e6f-8c10-e24d7b988abd"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2343), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90a9a458-775b-42ca-b5fa-5c7ac3961510"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2269), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90d88759-69ae-46c8-9336-05dc6f3f8362"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1975), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("916b49b0-a673-4963-8477-fb6ded609b8b"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2059), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9236e1aa-edc5-4307-8729-a4d0065302a1"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2354), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("933d780d-f6e2-43e3-a7c9-702653865b29"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2201), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94243c6b-3029-4205-8e5b-a8518ba7f3c6"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2129), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9445bdc7-9fba-4438-9c20-1e18ab551888"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2358), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94844c7b-c536-4682-bafb-da21703b37b0"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2142), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94d05326-fbd8-48d6-be9c-8ffe4111e68b"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2362), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9707a79d-76af-4564-82c2-59d5dfe6e501"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2075), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98e420d1-3ff9-4eda-a4c3-a8e261a95b47"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1995), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("992e63e6-76b7-4027-b1b6-836ac68e6efe"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2049), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a6b4b1c-f6d0-47d3-88cf-194d502047d9"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2005), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bdc339f-a82e-4f31-be0b-e726ba2c8083"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2156), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c100f4c-20e5-4759-b896-b2dcda74c38d"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1984), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f1d9d00-ed43-4fc8-96f0-4cb12b056dbe"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2338), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fdba99b-c0f3-4f7b-8119-406b704e366d"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2226), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fdee38d-759b-47f1-be09-e3ccbc3013d4"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2255), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a020072d-0384-401f-994a-b1e8d95605ff"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2038), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a115e20d-a6d1-446e-b38c-8363ff1ad617"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2206), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a201f1f9-abe4-4459-9029-c849011bb65a"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2318), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a309a724-d81a-42f4-b528-8e9ab0a4059c"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2170), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a32e98df-942e-4fae-943d-09e40e6c86ec"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2342), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a33dad57-74a6-4aec-b06a-02ed15a1c472"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2102), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a57a1df1-00bc-4139-8d86-7a7b80ac8cb4"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2057), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a700d980-84e6-4183-8187-5c3a03431af7"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2315), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8a52096-1699-4d2f-a37c-ccd891370951"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2397), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac62d8c6-a3ba-45fa-97e0-8750e2dbc4a1"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2294), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad75e145-91dc-4245-a664-8fb453f1c428"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2215), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af1e8fa3-7a4d-4b23-b004-fb9683f5ca1d"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2060), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af8bf24d-0259-4d6e-acd6-a61849f0f557"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2087), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af9b2a38-327f-48b3-8cc8-287ec5de46ca"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2110), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0d5a278-8f4d-422e-ada4-dfe00da2d2c0"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1983), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2c08291-6c33-4263-8374-5ba374be6d08"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2299), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2ffd6c9-0d2e-4170-a660-35aacebcc0dc"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2392), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4f53df4-45b6-4b44-b0e5-929ceeb0e54a"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2036), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5aa4409-b499-4449-98c8-93f23af49918"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2044), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5bcb5ba-db8a-4220-8f92-8d82f2c154c0"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2191), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b809584a-61fc-4a81-a2a6-f66aa5d09111"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2257), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b90605d5-4d82-4741-8ec8-9decbbc4ae61"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2062), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9662ce9-f212-4feb-bfdf-0501adf3f36c"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2355), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9945e20-38f8-4347-9157-ab60ade7b230"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2243), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba700139-4ef7-4429-a0d0-eefb3343464f"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2330), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc8ee99b-da74-412b-be59-b109560e5e5d"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1957), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bdb053dc-a2a1-4618-af21-e4a1c8243cc8"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2019), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be53ee6a-dab5-4f71-b68f-3110db2617e1"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2098), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be703c66-a688-4f00-b438-e26cbed1e34a"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2122), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf39f101-5657-4047-baa0-85900837bbca"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2039), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0ed2a97-5941-4f34-a37f-4457ab6135fc"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2214), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c113318f-b458-4fd4-9d6e-ff5d45c0114b"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2320), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c15f3742-07b1-4aad-99ba-2754a486712d"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2085), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1a48378-6dd6-4189-babb-7713f74e8d4e"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2341), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c20e2247-e57c-4097-8aaa-b230ddfd001e"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2254), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3d3598e-2ae3-4320-83fe-6348f403287f"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2277), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c508b3b5-4147-4d50-b8ef-123013a14872"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2042), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5456b77-e7e5-4cd7-9fa7-d1fecb6def41"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2067), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c568b69c-d41d-4c72-8ec5-a2f849e303d0"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2391), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6eb60fb-0b8d-42bb-9bb2-f8ca010a0ffe"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2083), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6f05bd2-a181-4eec-aba7-19c102a986c2"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2236), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca687419-d288-4ac5-bcc5-c92eaba7086c"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2374), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb6c3e67-d511-42d1-8dd7-349247eed1ea"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2233), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf2c1266-bf68-4ce5-bcd0-96c5c0a55d5e"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2040), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfaf15a8-a23a-4880-95dd-78acfbdc4aaa"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2176), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0b17835-6643-404a-a818-d45eb7f2a725"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2068), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d24bb0ae-ca38-463d-b3c3-8c8eaca45f09"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2363), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2e0e91b-fb98-4950-84a9-aeb1622f83a9"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2240), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d30c53db-b5af-41d5-974f-a772772df35d"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2223), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4b0f17b-ccfe-492d-8283-493282b34dde"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2332), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d54b7bc0-00bc-49a2-8975-17d6ac46acd5"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2169), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d73d7027-14f0-4164-a06f-26bd9a655adf"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2032), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc1424da-2031-4cd9-9ece-da5aa57ed77b"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2109), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dca9a9e4-ccd4-4bd0-9010-097f02f3c649"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2383), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dcda12e1-8855-4914-a2a4-1057f0632fd8"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2172), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd442e5c-1fe6-45b3-b115-4c136db7b838"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2069), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd6596ad-2736-47a1-939f-ca2a05dc2a7a"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2148), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd83ca99-4f5b-410b-8b0d-c60fdc842e86"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2321), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dda05720-304f-4638-b0a1-d700d782bcef"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2312), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ded01858-0ab8-45ee-9ce0-ac8beeb1500c"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2026), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e25cc0cc-efed-4c4d-90d3-90efad20b47f"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2120), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e37ac373-d036-47c5-8a0b-f6cd3e59db8e"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2160), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3f0e617-fccb-40c5-81c9-bac03f4553df"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2048), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e67f54df-a855-453f-9371-d8f2fbfe2faa"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2237), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6d7c7dd-62f3-4503-bb06-55de5f6dc684"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2212), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e72fce14-5645-4c42-8be5-f683ac8867a2"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1959), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e76c4db2-745d-4268-a861-e5b6b5e169c9"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2272), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7d17b7b-efb3-45f4-af55-996c51aef815"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2111), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7f2d671-bce8-450d-85be-6a235d993685"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2205), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e87022a5-2ba4-497c-b876-0adaa97ef5d2"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2359), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e885dfea-10e6-4b2b-88b5-c1fc7ae22df3"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2356), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8d22c77-546b-4c90-b653-dbc091c57223"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2181), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e902145d-e82a-4288-8069-f8f19e57bf5f"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2164), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e96957c4-c777-4ccd-bf99-a6f2a3ba4e8b"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2259), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea2b3798-4add-4626-96e6-92718b52a519"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2065), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea6058d7-239a-4ad5-91b6-66b092e9047f"), "C", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2249), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb41c060-8236-4711-a803-dcb23f078704"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2339), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb508c73-80d1-4b09-a1d3-1e6c37c1bb24"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2203), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb5b9617-d333-486c-b509-52b07f96e202"), "G", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2290), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ebd928d2-d4be-466a-a4db-bccd601f624e"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2208), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec39a623-2e11-4965-a633-59c5050d2235"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(1986), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec96cfc7-95a0-46be-a2be-ad1118589c5a"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2368), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("edaab63f-f52d-4a8f-bd99-d71bd11f284c"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2103), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0817934-4fa5-43ab-ac15-276972dbab72"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2230), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f1600e5d-fcf0-4041-a0c7-3ee5d985f0ef"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2115), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f245c1db-e876-430d-bfe0-6f5518cb143b"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2041), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2ae564a-346a-4d26-a863-1eda2c1bbfd0"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2080), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f527fe39-a5fe-43bb-8681-54e44e8b974a"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2125), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f75886e2-2399-4b80-a24e-93be7d07cbd7"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2015), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa8b83e7-e38c-4b29-a584-c84eecd0a21d"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2171), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fafd95b4-e967-4d9e-b6ca-ac0d76056f9f"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2177), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb0c88d8-5190-4dc7-9ca7-8812f8e0ef7b"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2061), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc19c5a7-2275-47a8-906a-75f05fa20355"), "F", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2289), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc225e28-01eb-4ce0-8e11-42b2c68cb267"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2149), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc3341e9-6ccf-42fe-af20-919ceb4b0abd"), "A", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2297), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc87ac74-2f49-492c-8331-971833ae1d14"), "B", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2234), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdf342e4-2054-4c03-aeb9-0d11af7b47e4"), "J", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2195), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdf36d0a-40fb-4f39-a93d-2da2aa74438e"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2331), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe1c32b7-cc40-4ec4-9c7a-b28ae0072b77"), "E", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2072), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fea26f0b-4426-4bd1-9604-e7ccee84b61b"), "D", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2123), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fef95857-15d5-49ba-a067-7afbcc4f8e1f"), "H", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2293), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ff182690-dae6-4418-a6c9-353c6748f357"), "I", null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2244), false, null, null, null, null, new Guid("ff00e42e-efd1-492a-943c-289257218054"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("87ef80dd-1b89-463f-8c15-231679cebe98"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2684), new DateTime(2024, 12, 28, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2690), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 27, 3, 23, 53, 547, DateTimeKind.Local).AddTicks(2686) },
                    { new Guid("8d6d791e-bb5b-4459-a530-57ca81f00c18"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2693), new DateTime(2024, 12, 29, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2696), false, null, null, null, null, new Guid("bf05aab1-100e-4533-9a00-1f8df7f62d1b"), new Guid("ff00e42e-efd1-492a-943c-289257218054"), 1, new DateTime(2024, 12, 27, 3, 24, 53, 547, DateTimeKind.Local).AddTicks(2695) }
                });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("5418e5e4-cba1-4829-9442-08637e3e66a5"), new Guid("c833abc7-1964-4e49-b22d-7cd6e06ba016"), null, new DateTime(2024, 12, 27, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2944), false, null, null, null, null, 2 },
                    { new Guid("5b4b00a2-ba77-4efd-b246-c71c90918a05"), new Guid("9d3c9357-fd67-4b2d-b737-4557ea1fc5fe"), null, new DateTime(2024, 12, 25, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2941), false, null, null, null, null, 1 },
                    { new Guid("e9f834ce-23f6-4df3-a351-408b1a65e08a"), new Guid("613e8386-9ae6-4700-a9a8-cfdf67ad13d4"), null, new DateTime(2024, 12, 25, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2948), false, null, null, null, null, 4 },
                    { new Guid("ff09fe74-8dc1-46de-919c-4a54cae060ea"), new Guid("d471abdc-e46d-4e2d-b8fe-c545e81cd335"), null, new DateTime(2024, 12, 26, 3, 22, 53, 547, DateTimeKind.Local).AddTicks(2946), false, null, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "BillId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("0360bb94-c8c5-4b8f-a4dd-e66452a37b0e"), new Guid("5b4b00a2-ba77-4efd-b246-c71c90918a05"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2924), false, null, null, null, null, new Guid("6797c2c7-f997-4b20-9880-95c76fac0452"), 3100000m, new Guid("02309158-b8a9-4975-b441-7a04b2709453"), new Guid("69688418-c33d-41fb-a71e-c38c379e0f57"), 2 },
                    { new Guid("1cd50e40-eb82-4012-bb23-5becbcd1d61c"), new Guid("5b4b00a2-ba77-4efd-b246-c71c90918a05"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2915), false, null, null, null, null, new Guid("ddaf2c2c-a108-4417-819e-2549e42fcb98"), 100000m, new Guid("4351c976-b605-4976-9e03-5deb8f0cd4d6"), new Guid("6eb19ccc-c120-4ad0-9ccd-c4d7868e2eb8"), 2 },
                    { new Guid("61c42556-5788-4ab9-8fde-ca75b5ea013c"), new Guid("5b4b00a2-ba77-4efd-b246-c71c90918a05"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2920), false, null, null, null, null, new Guid("bf05aab1-100e-4533-9a00-1f8df7f62d1b"), 2100000m, new Guid("015d6e6e-23d2-4bb9-b0b2-083145d5def4"), new Guid("627e1bfa-8f6d-42f2-9673-f098d0569e92"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("40a1d09f-bc20-4032-8992-55d371fe107c"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2788), false, null, null, null, null, 60000m, new Guid("015d6e6e-23d2-4bb9-b0b2-083145d5def4"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("3cc51eaf-4dd8-489b-b2f2-a5a7c6193ea8"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("55a3b040-f6d8-4250-a759-6d014b769f08"), null, new DateTime(2024, 12, 26, 20, 22, 53, 547, DateTimeKind.Utc).AddTicks(2782), false, null, null, null, null, 50000m, new Guid("4351c976-b605-4976-9e03-5deb8f0cd4d6"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("c5a26a17-abcf-4db5-b5af-9fb51841e99d"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
