using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initDbas : Migration
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
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2210), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("9e11c6f0-21d7-475c-b167-bc05d3578fef"), "11:00 PM", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2214), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("3d9ceeac-de6b-4db8-9e3d-8b4b5da0355c"), "Úc" },
                    { new Guid("445be2cf-4b8b-40f0-8bbf-3789eff23c33"), "Vương Quốc Anh" },
                    { new Guid("7f5c675b-b6bc-4ccd-a258-294e819d42d0"), "Hàn Quốc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("93646867-6d8b-4373-be6b-82eb6d57eabf"), "Pháp" },
                    { new Guid("bd211e28-6d56-42af-b31d-8297df55f201"), "Hồng Kông" },
                    { new Guid("d6f3adf3-5e08-42a5-9e46-d5445aec8e31"), "Ấn Độ" },
                    { new Guid("f1df1b5b-d818-46b3-ab14-ef5be9f70a8f"), "Việt Nam" },
                    { new Guid("f8d146c7-9d0c-4322-9461-088e17959c42"), "Mỹ" },
                    { new Guid("fa7410b7-6d35-41ee-8246-f210673358bf"), "Trung Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2053), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("16f1bae5-4314-4ff3-9958-1eaaa8362910"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2064), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("2d10907f-a302-457a-a422-cbb93464f8c8"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2050), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("3cd7417b-fae5-41ee-9f9f-7989d509678b"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2051), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2042), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("980dc84f-858e-421e-a4c7-795149e98781"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2056), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("afe10177-bd4b-4c72-840b-d5ffe9b2a898"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2062), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b51381c7-4d5d-461a-9a45-bf49cc3c739b"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2047), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("be87e613-5de3-4ee9-8089-7d191066f4d3"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2058), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("e39bb2ad-648f-4648-9b5e-1b567541cc58"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2061), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("47b28129-b0c2-4a19-bd5f-fda09ae008fc"), "Combo 1", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3244), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("8c3857ee-2fd5-4f27-8d84-249492e1948d"), "Combo 3", null, new DateTime(2024, 12, 27, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3251), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("a71eeecd-b530-499e-a122-8831832cd267"), "Combo 4", null, new DateTime(2024, 12, 26, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3253), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("de158cfc-4136-4570-9bb7-f80e80d5abfc"), "Combo 2", null, new DateTime(2024, 12, 28, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3247), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0a64dacb-32a2-4b37-9c40-5241d34cc1b6"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2103), false, null, null, "Lãng mạn", null, null },
                    { new Guid("540f11f7-7dd3-4055-80fc-3e8a75d4f1bb"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2106), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("68745211-3216-45a3-b0a0-bd1fa5096f49"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2097), false, null, null, "Kinh dị", null, null },
                    { new Guid("6e488d1d-ed09-425d-a071-509d921884e0"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2100), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("8499cc5a-9fca-4810-8934-563a7dcf887f"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2105), false, null, null, "Tâm lý", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2091), false, null, null, "Kịch tính", null, null },
                    { new Guid("912b98cf-57f1-4499-b611-186764e1f62e"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2098), false, null, null, "Hoạt hình", null, null },
                    { new Guid("a9443bee-d855-4dac-929a-724e6c660810"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2102), false, null, null, "Hài hước", null, null },
                    { new Guid("d1e23777-7c78-4257-a901-6badc7faca47"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2096), false, null, null, "Hành động", null, null },
                    { new Guid("e683084d-d36f-48af-ac6f-3067e0e6797f"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2094), false, null, null, "Tình cảm", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("44bb5321-8946-4053-818f-a2886589e2b6"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(1994), false, null, null, "VIE", null, null },
                    { new Guid("56a86dd0-ebd7-48df-994b-05d02b6907be"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2001), false, null, null, "USA", null, null },
                    { new Guid("8197d25d-77a9-489a-8553-f108a1ccd77e"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(1997), false, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(1991), false, null, null, "EN", null, null },
                    { new Guid("c6c5458a-a6fd-42a5-af20-82cb2020ad66"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(1996), false, null, null, "JPN", null, null },
                    { new Guid("db494f33-2d6e-4fed-8c08-69a694ee962c"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2002), false, null, null, "Korea", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(1278), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(1281), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1143), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1169), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1167), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2178), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2180), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2175), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("0f658a49-10d4-4942-8399-f6db5e670698"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("1f69d690-2a2d-48fe-85dc-f3835e377c6f"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("98852d8b-66c9-4108-91ae-d3ee15f7bc83"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("9b9a74f5-0a3f-4640-824f-e56014783188"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("a9837934-91fb-4d17-a779-77e3a5cf932a"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("bdfc966b-0104-43f0-b0af-06dff38f8388"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("cacc6441-a349-4349-9ed8-857b27a16458"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("d745ee84-55ea-42cd-95bf-196e57338bc1"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("de9849f0-d2c9-4693-9111-eba61d96a6ff"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("f67924ed-2a63-4493-a626-6e3414b1922c"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(3186), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("28cc4540-a9d1-4431-a84d-5e0842400227"), 13, new Guid("3d9ceeac-de6b-4db8-9e3d-8b4b5da0355c"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3038), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 123, new Guid("a9443bee-d855-4dac-929a-724e6c660810"), "kinhvanhoa.jpg", new Guid("56a86dd0-ebd7-48df-994b-05d02b6907be"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("3125a386-a476-43b4-b1f4-780543639664"), 18, new Guid("f8d146c7-9d0c-4322-9461-088e17959c42"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3059), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 127, new Guid("d1e23777-7c78-4257-a901-6badc7faca47"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("36b90ac4-3bf1-4a9b-a140-534009a5e477"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3010), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("2d10907f-a302-457a-a422-cbb93464f8c8"), 110, new Guid("0a64dacb-32a2-4b37-9c40-5241d34cc1b6"), "tretraukhongduaduocdau.jpg", new Guid("44bb5321-8946-4053-818f-a2886589e2b6"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("4095e55a-c010-4ae4-aef3-5e9dafe4d7a6"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3024), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 100, new Guid("0a64dacb-32a2-4b37-9c40-5241d34cc1b6"), "chayngaydi.jpg", new Guid("44bb5321-8946-4053-818f-a2886589e2b6"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("457c7ff4-0e77-4c24-8620-1f3a27b84c8b"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2980), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 99, new Guid("a9443bee-d855-4dac-929a-724e6c660810"), "tetamhon.jpg", new Guid("44bb5321-8946-4053-818f-a2886589e2b6"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("4d3cda36-bcef-46c5-9eaf-6d611f23cc64"), 16, new Guid("93646867-6d8b-4373-be6b-82eb6d57eabf"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2972), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("3cd7417b-fae5-41ee-9f9f-7989d509678b"), 109, new Guid("68745211-3216-45a3-b0a0-bd1fa5096f49"), "yeuem.jpg", new Guid("db494f33-2d6e-4fed-8c08-69a694ee962c"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("50e1509f-17c5-4a30-bda4-e9c0ace7eec6"), 13, new Guid("f8d146c7-9d0c-4322-9461-088e17959c42"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3045), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 118, new Guid("8499cc5a-9fca-4810-8934-563a7dcf887f"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("5da4ded2-2eea-4981-8169-7c7ab1a6285a"), 18, new Guid("93646867-6d8b-4373-be6b-82eb6d57eabf"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2958), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("b51381c7-4d5d-461a-9a45-bf49cc3c739b"), 81, new Guid("a9443bee-d855-4dac-929a-724e6c660810"), "xich.jpg", new Guid("db494f33-2d6e-4fed-8c08-69a694ee962c"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("70876698-9bde-4086-b916-178b8aed68fb"), 13, new Guid("fa7410b7-6d35-41ee-8246-f210673358bf"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3052), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 134, new Guid("d1e23777-7c78-4257-a901-6badc7faca47"), "cuocchien.jpg", new Guid("c6c5458a-a6fd-42a5-af20-82cb2020ad66"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("76073b71-6187-4ce2-a6c4-f2fcfd0d4ac1"), 13, new Guid("3d9ceeac-de6b-4db8-9e3d-8b4b5da0355c"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2966), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("2d10907f-a302-457a-a422-cbb93464f8c8"), 113, new Guid("6e488d1d-ed09-425d-a071-509d921884e0"), "congtubaclieu.jpg", new Guid("56a86dd0-ebd7-48df-994b-05d02b6907be"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("a79d8a3c-94a2-438f-9502-304565cdfd5e"), 15, new Guid("93646867-6d8b-4373-be6b-82eb6d57eabf"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3016), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("3cd7417b-fae5-41ee-9f9f-7989d509678b"), 110, new Guid("6e488d1d-ed09-425d-a071-509d921884e0"), "chuyennhabanh.png", new Guid("db494f33-2d6e-4fed-8c08-69a694ee962c"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("b2678862-6fe7-49f9-9d70-8d86017ee7fd"), 13, new Guid("3d9ceeac-de6b-4db8-9e3d-8b4b5da0355c"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3003), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("b51381c7-4d5d-461a-9a45-bf49cc3c739b"), 120, new Guid("0a64dacb-32a2-4b37-9c40-5241d34cc1b6"), "botubaothu.jpg", new Guid("56a86dd0-ebd7-48df-994b-05d02b6907be"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("caf83f95-7467-4257-a56a-51ccb9186751"), 13, new Guid("93646867-6d8b-4373-be6b-82eb6d57eabf"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3031), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("045d738e-8a11-4a5e-ba4c-2437d25e7339"), 113, new Guid("0a64dacb-32a2-4b37-9c40-5241d34cc1b6"), "cuoixuyenbiengioi.jpg", new Guid("db494f33-2d6e-4fed-8c08-69a694ee962c"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), 16, new Guid("93646867-6d8b-4373-be6b-82eb6d57eabf"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2950), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("a9443bee-d855-4dac-929a-724e6c660810"), "ngaiquy.jpg", new Guid("db494f33-2d6e-4fed-8c08-69a694ee962c"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("f4fc0bb7-53a6-4482-9bfb-101caf945729"), 16, new Guid("f8d146c7-9d0c-4322-9461-088e17959c42"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2996), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("d1e23777-7c78-4257-a901-6badc7faca47"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2258), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(2262), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("112d0956-1aea-47fc-848f-0c8a08e94e0f"), "Hải Phòng", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1748), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("193d4f90-55ec-4cc5-96d3-4e389637bed0"), "Nam Định", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1901), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("199acef6-388f-4611-9d5d-1e3855ae78ef"), "Quảng Ninh", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1919), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("29a79e2b-1462-40d2-8862-4514666fce42"), "Thái Bình", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1862), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("48eef5fd-a111-4892-ba6e-1599be10f0e2"), "Hà Nội", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1344), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("59cd020d-c013-431d-8f47-025343ecd991"), "Hưng Yên", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1881), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7268b075-84bd-403d-94a5-a2668826eac8"), "Hà Nội", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1940), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("7f782509-0cda-42b2-96e0-111518419538"), "Hà Nội", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1723), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("823ca149-4ba3-4b1c-a550-bc55a3961dd8"), "Nghệ An", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1811), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9019b0fa-4810-4286-8fd3-93b9c35513c5"), "Đà Nẵng", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1771), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a643a692-d651-4082-89c4-48f7579b7635"), "Bắc Ninh", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1836), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ef2f9fcc-b34d-4b08-bf40-6c94abf26c8a"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(1790), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("1450cbd8-ada9-402c-b55a-cf00d75813da"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3154), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 2, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3153), new Guid("cacc6441-a349-4349-9ed8-857b27a16458"), null, 0 },
                    { new Guid("3d26027b-caa3-40cb-9156-dae82bb92790"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3146), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 4, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3145), new Guid("de9849f0-d2c9-4693-9111-eba61d96a6ff"), null, 0 },
                    { new Guid("4f1830e8-85eb-45a4-b94a-3452acb23948"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3143), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 5, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3142), new Guid("9b9a74f5-0a3f-4640-824f-e56014783188"), null, 0 },
                    { new Guid("6f2cf810-5bbe-4bb1-82d4-d94f56439f6d"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3138), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 6, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3137), new Guid("d745ee84-55ea-42cd-95bf-196e57338bc1"), null, 0 },
                    { new Guid("ab23abf1-ad9a-4ab8-8d67-e4c027569539"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3150), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 3, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3149), new Guid("f67924ed-2a63-4493-a626-6e3414b1922c"), null, 0 },
                    { new Guid("bfbc1c76-a5a6-4d32-a8c9-1960aab04435"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3135), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 7, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3134), new Guid("0f658a49-10d4-4942-8399-f6db5e670698"), null, 0 },
                    { new Guid("df8ed9da-7e0f-41fa-b92f-e4ee3be38d95"), null, new DateTime(2024, 12, 29, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3130), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 8, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3128), new Guid("1f69d690-2a2d-48fe-85dc-f3835e377c6f"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("008a7835-789c-4074-984a-82d0b7cbcd6a"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2544), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02b6925c-5680-4376-b5ea-bf8ebe1e2898"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2545), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08de8a67-0474-48ab-aeb9-b274a05a97cf"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2641), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08e61b18-bf7d-47a6-80af-9a37bc8f6c90"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2357), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a76ed6c-afba-4123-83c5-5f3ad476e38f"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2735), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b206626-e4f1-4c87-96ab-2d47aa3bc017"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2483), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b884afe-f0ea-46a5-b813-80d15b83f1ef"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2574), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e741ea6-4236-46b9-8414-ac639c233392"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2359), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fc0a29b-8be5-4e50-8ace-21597ffaa28a"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2647), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14192673-7adb-4b2c-bbf8-0a6aebbdf9a1"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2369), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14bc59e6-f77b-4555-8461-b2c2127728c1"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2421), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15e05f0b-3246-404c-a8b9-e1cea56f7dd1"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2609), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17622799-15d9-4d68-9cad-01f6b9e87559"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2717), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("17b6114f-cb74-4ac4-9724-5b9839c1a4f6"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2579), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a342180-51b5-4fb0-afdf-4487d0746833"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2666), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c00a0fe-7e0f-46d4-945f-6ac1392d630d"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2570), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1cb8876e-9783-491e-b472-160321c14bea"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2597), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d8f2b9b-6571-4fdc-95d9-5361d4d59806"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2619), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ee6445d-db4e-4843-864c-f6b86ee248da"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2431), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f751ff5-0b2a-46cb-8f4a-9cc515a99c3e"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2659), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2248545a-abf2-4e93-ab11-9a011e76fc39"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2355), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("226d108e-a0f1-476d-a4bf-d1a907bf9a45"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2763), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("227dc231-29af-467c-bcb5-65729cae546e"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2610), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2356128c-97d9-4691-8888-5409033630b9"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2424), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23fd016c-027c-4d98-9581-406d4db38c69"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2404), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23ff648d-e9ef-4ca0-8e5d-7e981771dfb0"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2621), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2440a16a-85ed-4a26-88cb-f006cde2db9e"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2732), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("255f37c3-b1ca-4f6f-9477-ffb75ea8f731"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2428), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27ec5bb3-b10c-4425-a06d-433c61bacdd3"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2542), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("281e5207-61b9-4e33-9aa2-2ffaae7249ba"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2567), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("288b7d19-219f-46f2-b426-ec16b9e69972"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2515), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("295b64d6-a763-48e1-b35b-b0fa56dee2b9"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2389), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a35278e-43e2-41a0-ba13-cd92121ba361"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2695), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b1f6a25-c605-43c2-a53a-95fa6bd213c4"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2608), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2dcb832c-6546-466b-8620-03e56a0bf2c0"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2673), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ff7a312-472e-4306-ac0b-80d95edc1db4"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2540), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3023379c-7d87-4829-abf4-64b8abaf34b9"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2472), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33e43895-86a7-4ede-951c-36c9e1a834c8"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2625), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35302103-5629-43bc-9314-a04218278552"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2708), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37039cbe-c380-4813-a165-4d04f0a7128a"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2755), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37707da3-fc05-4911-a603-34cccad16bc1"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2630), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3990bd55-b61c-419a-9fb6-e485ef028ed7"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2450), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39c36b46-ffae-4e28-a2c5-8f84154cb4ff"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2432), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b4e08f3-6f95-4978-a2e0-b43125ea2828"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2377), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cad47a1-bf25-4a9f-8948-c6a90860f962"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2485), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cf4a89d-64cf-46f0-bbb1-9200f2d6a46b"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2793), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3cfaab6e-2998-4828-bee3-afd0a88415e6"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2727), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e185e90-29d2-4fa5-a6d8-698dadfb6204"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2512), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e844d5f-abfb-47c0-bb97-018af2a6b8d7"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2536), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4089f558-599b-4c61-8bd2-debd8269cd5c"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2522), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4097f420-8d23-4da0-894d-c9fd139f9976"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2580), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42e8e47a-9e5b-4d53-9b4c-77e24ae51aff"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2748), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("441dea32-3682-4733-a84b-90c219e3a755"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2595), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4420e2ae-8c7a-4053-b1f8-8d2765b9d89c"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2605), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("457a6172-3fd2-4200-abea-4ba709b264b0"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2562), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45a8a15e-dce7-4c20-8064-7bd15ec71614"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2749), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("472b6706-ab18-490d-9873-a339d3391a52"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2624), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48568b33-ca98-4928-a2a0-577d828b03fb"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2617), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4990f723-4a02-45c4-8cc0-0aa62f230e93"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2382), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a1d5ec2-7eee-4575-ab82-d95d71136a98"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2362), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4be606df-0257-4770-bd1e-f49d191451fd"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2786), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d1eb254-6175-4349-bb69-a1b6db2bbee2"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2648), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d3e4e4e-0109-47b0-a45e-86396beaba4f"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2613), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dad65b4-d94a-4b2f-8d5f-0007cf6ed36b"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2342), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4dbfe7de-83af-4ca4-bfe1-9cb5c4693bb6"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2752), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ed4c13d-d91e-4cbb-aed2-679cf123e92a"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2571), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5094638d-4d67-46d4-bdf2-4438615a6a3d"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2336), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50c9cb0e-2f6e-4d17-ad27-59b3c3431c99"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2577), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52ba3ea5-aa37-4078-ab20-117a080a1a2d"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2691), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52bbe9da-f3ce-4cd6-8900-6521667687f7"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2541), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("540312c2-7d4d-4c30-8430-0f67ccdbd706"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2784), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("547646b2-39b6-47e6-8031-365ea174327b"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2709), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55266b5c-03ba-45a1-a645-e5f92222948f"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2643), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56c10102-3dac-4cf4-bb5c-b12e8480f8da"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2576), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56d4ab2d-a026-4e63-9cc1-1bfba371561e"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2737), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5727e82c-bcba-4ddd-b3b4-bf19fd4233f9"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2489), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("577dfb88-4ad9-4009-8759-6d0592f2a8ae"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2393), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58e7ccb2-a561-4970-aa03-27a50421542f"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2513), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a206a81-2c49-4e56-8532-9ef7b6d78eda"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2658), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d488b29-b257-4b57-b793-019776297e92"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2401), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d53e41c-e78a-4fda-a789-2d881e13d510"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2773), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d68083c-eb0b-4fce-b045-a82dcafbf991"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2426), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5eacba72-617e-4f0a-8817-168438e88cad"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2702), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ee6456d-3bd2-42cd-b6aa-062a67aff749"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2733), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f1ab3a5-e785-4124-8e82-76bfd5c1fd84"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2637), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f2bab9a-0b7e-4dcf-8e41-e543ce6e8465"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2726), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60226e50-7c26-4591-a13c-ffe15c5da528"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2650), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6167e158-27bb-4338-a837-5bc6c41e3b36"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2441), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6249b61a-9fab-4226-a41c-3f3b2e023c21"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2492), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("629ca302-a06d-479f-8be2-9b743984455e"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2392), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64a87847-3776-4d41-bfcf-44dee9041cd3"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2446), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6568ffc8-5a2d-4515-b5a0-cdd2b6969afe"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2468), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65d6f621-2de2-4012-a109-559a9547559e"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2770), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65ee1329-8c7c-4bba-a0f7-ed57702325ef"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2474), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("665e4aab-336c-426c-8620-65e6034c1808"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2685), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66776efe-bb2e-420e-9c52-46ee9fab7bde"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2360), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("66a04b06-6c4a-4011-833e-432152d7a855"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2293), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("699bd75e-46fc-4b66-9856-bd3a6eab3c11"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2693), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a680d4b-0439-43a9-86ff-669fbee055cf"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2407), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a6aaa47-4251-4d78-9eff-db8de2a27a00"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2506), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b40cfa3-15eb-4abb-ab21-85fa958023a5"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2646), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d1f75e3-c745-4b3a-9497-4727a126991c"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2558), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d9e8bfc-70ac-4b08-9ede-f929ad9db5a6"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2438), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e22a07f-8b12-40fd-b354-378af69b74e9"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2719), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e495f33-235e-4c39-b125-7676250f55c4"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2518), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e536d4e-6762-4237-af9d-f19312370db3"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2375), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70d1f000-aa19-4f02-9ff4-fba79d747d02"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2418), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71b21d7c-4d3f-4433-b9d2-bc45f860f4db"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2466), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("728819e7-91c5-4b75-8c72-dd1fb9888ef7"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2698), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72cd815f-a91f-4568-b23d-9097fe1b5c6f"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2759), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74507f76-6162-4362-bd07-7f1eda92a230"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2490), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76aa22b2-5629-4478-b5b6-3932861ea2f7"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2437), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76d0867d-322a-47fe-9d82-59751394a3eb"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2718), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76dc3920-daf1-45c4-b34d-61a7911f4a2b"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2386), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("777a4db9-c77f-48f3-9303-4dce150acf31"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2384), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77d0363c-ec1f-440b-ac49-a48d515377a3"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2598), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77eaf1f2-259f-4071-b6ad-9cfecbf1a17e"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2445), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("789a6289-45b2-42e1-a2cb-9a4260be88cf"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2697), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a8b8126-f29d-4c52-8748-3015873a91cd"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2754), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b47769f-11e1-4570-837f-b0042ab75122"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2504), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d709bc5-3851-4f6a-9b84-203e091b105e"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2639), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("80f5fca8-26df-40a9-8bfc-985d3f922b4a"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2353), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8125dc9e-14a8-4bc7-a9d1-5e580639900e"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2493), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("827cb26a-1207-46c5-909f-a745767c2b60"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2465), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("828cc178-ce3c-496e-8cb2-057738b8e6fb"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2395), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("842626fe-26ea-4f35-a337-1b5a5b9d6086"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2616), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84be6f2f-2f65-4612-93da-d1d75573e494"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2640), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("853fdce2-fe98-4d8c-960a-26a51b86d8a1"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2771), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8540d831-4f49-42cf-a4ba-72198d0cf1fb"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2566), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("860601bb-dfa5-4818-a8d2-f08002eb34c6"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2783), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86c823db-9da4-4201-9953-bd935b3eb0bb"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2692), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("871babed-bebd-456a-90e1-cee0ca0add2d"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2451), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8730da58-8c2f-4d67-b386-adbe2a389cb1"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2663), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87aac445-8017-4687-abd4-9ced3658d642"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2495), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87f0755e-4196-45aa-b509-27b910659dc4"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2469), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88946cf0-f55f-4ad4-82b2-c86dad9f4284"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2379), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89b1db8a-1d26-4bd4-9524-8e5524f5bee1"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2350), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89c5c619-f412-4500-8421-40e19caefc6d"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2464), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89cde8fa-178e-45ed-bf89-bbe2a6c924f2"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2664), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8bcdba27-f464-4b58-852c-c3b45bdeae3e"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2654), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d88bc39-a600-4063-8f0a-c0306b43820f"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2516), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e2488d9-ea40-4d23-b9fa-ed52fae9e072"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2620), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("912f7fba-cc51-451c-89b3-5d9928356a7e"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2738), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9157523b-f606-4cd9-8979-dd4c67b40036"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2778), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9317ae2d-b97d-4cdd-9c3c-e9878f581ab4"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2790), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93ea6a3e-8b6f-4a6c-acd9-47f032357ae0"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2527), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95292c5b-2ea1-466b-a7e1-a7e381e0ba17"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2668), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("965550ea-d0f2-4134-9217-4470b70e58c5"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2439), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96a840ad-542e-410c-b4fb-52d99ad48716"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2745), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9862e1a8-a93b-49a4-ab9f-305e05729a76"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2775), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98ab3eb7-bd50-4115-9508-874f4c811f9d"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2584), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99585367-3149-49d3-ae31-c9a61c7cf65d"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2396), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a4b7848-1f8d-4778-a7d6-63034880d04d"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2684), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a67bc65-111a-484f-892e-ba56c62ea784"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2534), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b25fb69-26bd-4f72-b892-36b2564f5042"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2758), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c881ce1-dd05-45c2-9612-3e0b1616e49c"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2560), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9caa3ec0-04c8-4110-b101-b792683a718b"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2606), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ce5674f-3b3a-40a7-8227-dd88454500a7"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2631), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9edb2531-1871-4175-9373-128a086038df"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2345), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f170b30-095e-484f-a056-ff36bacaeb7e"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2339), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fbe63fd-2891-494e-b677-1abac9fb254d"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2524), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a00f84fc-9bac-453e-baf7-bb83daa72b7a"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2672), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a192ef10-cd7b-4b21-be73-524905930965"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2406), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1c06532-8e3c-493a-b7e5-8b14511bdbc7"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2538), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1deaf6b-6b22-471a-a07e-ef546e92685a"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2604), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a309d4e1-b3b5-4d36-9fd0-00a79021c187"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2729), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a31a0c46-d214-4c14-a16a-86b121628f58"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2449), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4c1d0b3-07d5-4e55-84bb-2b1ea21e0168"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2780), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a78786d6-dbc8-4201-89cb-a67cc3d8beac"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2689), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7d903d4-788e-4327-a88b-d24919caef5d"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2531), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a8faf428-2b29-449e-bf84-759d7f3aa8f3"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2434), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa9c5f8b-93ad-4f3e-9ecf-4208c9805f86"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2420), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ada09f8c-01fc-487c-9b11-c042b735424c"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2486), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("afd93ed0-9096-4b8d-aaef-5ebaf912c66b"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2348), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3742bd6-536a-4bed-9038-26819544f4c6"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2789), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b674e37b-d506-43b4-90f2-59ff756cc6f4"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2400), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b686cdd2-e6a8-4a46-a043-c8cdc58496da"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2533), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b81ffd44-4ac4-4486-995a-890618d11356"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2742), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b89ee93e-8590-4add-bd46-cafd9482370b"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2798), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9055720-f5c6-403f-acf2-3941ddd1f1e7"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2777), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b96af857-e012-41ef-accc-1d5e16d01b99"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2682), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("badcb4ef-0b2b-46e2-8dbc-25472475a1de"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2671), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bafcdf5a-d7d7-4e44-87de-b068e3ca12e7"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2478), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc626f16-5633-48c6-bca5-43fda48d4c83"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2714), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be1615c9-b88b-4a07-89ce-9e17922d9c7a"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2794), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be17322d-e857-49c1-8934-fee22f512c18"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2435), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be4a1bba-b546-4d49-aa36-493976bb8529"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2521), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("beaca880-4eef-48c4-b4e9-854c029e66ea"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2628), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bed3a8b7-14b9-4a16-93a6-9739b8b94d08"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2502), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2564027-e08a-4cf3-a4b4-22d55e80dffe"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2792), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2ce0fb0-ff76-4d97-a918-b15bd6abc32c"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2479), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c401d2e2-1a15-4539-b8a1-a21045815175"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2594), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5fa1a0e-4fa2-41d2-88a9-d4fab366d437"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2425), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6df87f1-6a0e-4a0c-84d2-ff79d513e361"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2390), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7ae51b4-d04c-4871-a513-190757e85b33"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2453), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca0b8f2a-2cf9-400a-bec7-e6ce97c04b86"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2376), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc981033-ba86-431b-aa0f-2fc933a10236"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2443), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cca57440-57ce-4ab7-8adb-f37353745bf1"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2660), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd00f510-ba34-4f0c-9ccb-1a45ca1228d9"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2599), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf51b28f-c233-4239-893d-e65abcffc3ab"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2482), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0403502-e355-4e55-9a82-911e8c2e0165"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2471), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1c2b0ae-8c92-44b0-a4d0-fca27ac118b0"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2741), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1de9301-4055-405a-9037-9ac995f5e9fb"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2480), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d204ad90-16f5-45f0-b1f9-acc234ddc936"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2651), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2d835f6-6a4e-4504-b21d-bdfd7d2f77b2"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2688), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d332d532-151c-46a7-ab35-e9b15460747d"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2739), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d38c0e70-27fe-44ba-bd98-0968e59a6851"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2476), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3b71bf4-7f96-4324-a552-56c5545e8a1a"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2363), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3bc2064-a5d0-4259-b9e8-eb2aea35b5ab"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2653), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d43c0892-3bc4-4464-a6a3-ac5ac6126231"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2508), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d44ca0be-79df-4ce4-9066-3bbbdfce8e6a"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2705), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d50cee94-ca27-4976-bc4b-e4ba8aed0e1a"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2415), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5485336-cdef-4a10-a3b3-f44370703ea6"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2564), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6477869-cea7-4e5d-8a2c-274aa7eecd8e"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2601), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d6ddc5a3-cce1-4fa7-b741-2f11ec231ca8"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2510), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8e6088f-d929-4e1e-873e-7b4d02207fad"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2573), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9c9461c-93b9-4ea6-a9eb-0b8a21e36bdb"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2496), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da68007e-72ad-433f-b474-4c6942f70b2c"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2751), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da72aa45-18f3-457f-9ed6-d02fe4d8424d"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2612), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daf0b9c7-867f-40f3-a48c-c3c623472c87"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2711), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbc762f5-98b5-45ed-81fc-086134563130"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2373), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dda78d57-5967-4d32-bed0-ac1a6a7297e2"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2768), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("deb7a0b3-141b-4ef8-b289-9e30e2957274"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2715), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dec40928-e226-4608-ab49-d54f6270db1c"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2555), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dedd80d7-923d-4a17-baa7-d08acacccf89"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2623), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e37b0c65-1722-41be-8585-de4eced458b3"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2676), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4014321-b087-42cb-8ce4-60783d7d5487"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2559), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5b1c6c6-bddd-4a78-af30-b28aa2cbaf84"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2346), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6d81239-58be-4148-b7e3-2da4d151b65d"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2414), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea29e72a-755a-4f73-9b74-5f021058205c"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2403), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea8fa928-92b9-4416-9237-609c7c9e6957"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2761), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb151cea-256a-4066-b56f-78459dc869df"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2388), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb89a552-d111-4329-b2e5-f5d0e5bd6b11"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2747), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee08b822-445f-4c5f-8b1f-48a8d6312b5b"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2340), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0a65f84-a617-40ed-bf18-3adccbf231c7"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2781), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f117d3f7-8f99-496c-bcbe-f16e07c0648c"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2662), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f160b1b3-ddd2-4f59-97a6-441c306c6458"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2707), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f24dd809-3e67-40e9-b1cd-7f87bf898f15"), "C", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2380), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3eac527-87b4-4f87-ac8e-9911747e4d10"), "D", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2701), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f491a1d5-6b20-4453-8d6f-87eb79f56add"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2797), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4f89b30-1c01-4a21-92d6-8ef32f4b6301"), "E", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2422), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5910a92-4499-4577-9ca9-938f98b213fb"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2593), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7124576-703c-4293-b9f6-7c80f5261e88"), "J", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2801), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f85361be-3649-4173-a5e4-39bc1604d61b"), "B", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2553), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9497569-1519-4578-919b-c79b9bc53fb4"), "G", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2796), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9bc0e13-272a-4166-a871-813e2bf40261"), "I", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2655), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa30589f-4e3e-44d8-8374-2c63f1c5fb21"), "F", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2704), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fae1ed79-fc66-4a08-a525-64b0512e68e0"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2675), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc5730ab-56b3-4b51-8429-53fef1b3cfca"), "H", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2563), false, null, null, null, null, new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd467db9-1382-4557-866a-4ca2ab689bd2"), "A", null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(2447), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("45c540d1-521e-4f3b-8b41-7ef59a52bb86"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(3102), new DateTime(2024, 12, 31, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3104), false, null, null, null, null, new Guid("5da4ded2-2eea-4981-8169-7c7ab1a6285a"), new Guid("b69dfea6-f127-4ae4-944f-a2b709a5e2c9"), 1, new DateTime(2024, 12, 29, 23, 48, 43, 829, DateTimeKind.Local).AddTicks(3104) },
                    { new Guid("c742f413-ce6d-40a3-a499-5d701c47d772"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(3089), new DateTime(2024, 12, 30, 23, 46, 43, 829, DateTimeKind.Local).AddTicks(3098), false, null, null, null, null, new Guid("e299303b-0b82-420a-a927-edd0246b0e38"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 29, 23, 47, 43, 829, DateTimeKind.Local).AddTicks(3091) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("157198fa-fa46-491b-8e35-4a8b353268df"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(3215), false, null, null, null, null, 50000m, new Guid("df8ed9da-7e0f-41fa-b92f-e4ee3be38d95"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("1f69d690-2a2d-48fe-85dc-f3835e377c6f"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("7b57f885-61bf-411d-922a-c704c0e2ac1d"), null, new DateTime(2024, 12, 29, 16, 46, 43, 829, DateTimeKind.Utc).AddTicks(3223), false, null, null, null, null, 60000m, new Guid("bfbc1c76-a5a6-4d32-a8c9-1960aab04435"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("0f658a49-10d4-4942-8399-f6db5e670698"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
