using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initsa : Migration
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
                    { new Guid("3c3942af-70fe-475b-a636-5cb6187aaae8"), "11:00 PM", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9751), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9746), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0f7e33b7-d2c3-47e9-8683-4ddfdda164b9"), "Ấn Độ" },
                    { new Guid("35896d14-530f-4648-8a91-84cede7864cc"), "Hàn Quốc" },
                    { new Guid("4cd7b368-635b-416f-979e-5c5d331eb110"), "Trung Quốc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("95c6d565-7c16-459f-8593-355c979ac948"), "Mỹ" },
                    { new Guid("caf27fd0-76aa-4882-81a1-4d04aff3318f"), "Úc" },
                    { new Guid("d7907a15-239d-4818-843d-a939256eb395"), "Pháp" },
                    { new Guid("d8142359-2738-42fa-94d0-6097edfbd051"), "Hồng Kông" },
                    { new Guid("db017884-e7ad-4e78-9ab0-4d984fc4f4d5"), "Vương Quốc Anh" },
                    { new Guid("ff59e629-cb8f-4ad4-839b-a5663cc106c7"), "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9573), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("20b90756-b113-4d6b-baf2-a144437fe545"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9581), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("2d858c0f-a6e2-4228-abe9-97c54f8ea459"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9569), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("5caf76d2-edca-4f30-8af0-6b0cd93a6f1b"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9585), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9561), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("a41eb3b7-672b-4659-8870-98badc88ef6f"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9579), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b0da780c-7fee-47e3-9077-d36ff8e3e5e3"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9576), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b7d908d2-aeea-42ab-96bc-3d27b90d6c4e"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9571), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("efd64aaf-74ab-4e5f-8c2d-5cc13169b00a"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9567), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f3dff0a2-2130-44e7-a94a-135d1aab2e0a"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9577), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("85ba99f2-facd-4a40-aff5-d91bde447762"), "Combo 2", null, new DateTime(2025, 1, 2, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(908), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("b6bd8356-be31-4dc3-afd6-5418c3821ebc"), "Combo 4", null, new DateTime(2024, 12, 31, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(913), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("ba362c65-7d03-4e48-ba58-c8358188c12f"), "Combo 1", null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(904), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m },
                    { new Guid("db2ec796-33e8-4bc5-80e2-27d83f5318a5"), "Combo 3", null, new DateTime(2025, 1, 1, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(910), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("11fc32f2-9720-4efb-a104-6460d35e67e6"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9618), false, null, null, "Kinh dị", null, null },
                    { new Guid("41dba4f2-3c13-4bb3-9cf7-27a5e212199f"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9626), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("51d0012d-c1e7-4e8f-be62-cb1b35a8584d"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9617), false, null, null, "Hành động", null, null },
                    { new Guid("55faace2-4fd8-4268-9cc1-e2d029d6c442"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9633), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("897e8628-f464-45cf-8797-3921800d5cf5"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9628), false, null, null, "Hài hước", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9611), false, null, null, "Kịch tính", null, null },
                    { new Guid("a65e81c0-dea0-4a78-9f7d-8a85f4b7eada"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9615), false, null, null, "Tình cảm", null, null },
                    { new Guid("accd2604-dd0a-4ef0-9ce8-fce8de93d05e"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9629), false, null, null, "Lãng mạn", null, null },
                    { new Guid("c522e4de-15c1-4f51-b40b-ac645e39ea0f"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9625), false, null, null, "Hoạt hình", null, null },
                    { new Guid("f89cde20-e7db-4d23-8db2-bfc2c489f850"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9631), false, null, null, "Tâm lý", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("522b1844-c87b-4da6-9ae9-db0daa69f1ef"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9524), false, null, null, "JPN", null, null },
                    { new Guid("6788f50a-b0e5-4c5b-835e-4d740eb46714"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9526), false, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9518), false, null, null, "EN", null, null },
                    { new Guid("97361dba-3c18-4672-a008-55c92fa4bfea"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9528), false, null, null, "Korea", null, null },
                    { new Guid("d9e062ba-455f-4bdf-a321-c225e2736fce"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9525), false, null, null, "ThaiLans", null, null },
                    { new Guid("e6bc39a8-9e23-46cf-bec4-35bf824c3875"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9522), false, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(8554), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(8557), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(8337), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(8374), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(8371), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9714), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9716), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9710), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("146018f3-e058-4e33-bb08-f8ce4aab5fd9"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("212497d5-7cd4-4ad1-a2e0-e960babd8b72"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("27567a1a-59c9-4e07-aaa3-2421b171c760"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("2dfab786-30c7-4840-8ee3-59af102e09b0"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("42f300f7-5e48-432f-878b-48e63db072fd"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("500490e6-d3ab-454f-9324-157b16a4d789"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("85b72290-b0eb-4f63-a179-5393535216d0"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("c87ff0ba-e5ce-412d-b9fa-e46c2f28454f"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("e8ac2a81-5899-4678-906a-c68e474749c2"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("f1d2383d-6a70-46c0-b788-9c1fe10adcec"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(840), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("015430c5-0ab6-41d5-acaa-7fabb13961fe"), 16, new Guid("95c6d565-7c16-459f-8593-355c979ac948"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(629), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("51d0012d-c1e7-4e8f-be62-cb1b35a8584d"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("2a1bdcc3-7d7c-4b97-8923-08dc59ca1b1f"), 18, new Guid("d7907a15-239d-4818-843d-a939256eb395"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(601), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("efd64aaf-74ab-4e5f-8c2d-5cc13169b00a"), 81, new Guid("897e8628-f464-45cf-8797-3921800d5cf5"), "xich.jpg", new Guid("97361dba-3c18-4672-a008-55c92fa4bfea"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("2b7fb747-7322-46e5-bc4e-ca8bcbde0a07"), 13, new Guid("caf27fd0-76aa-4882-81a1-4d04aff3318f"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(609), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("2d858c0f-a6e2-4228-abe9-97c54f8ea459"), 113, new Guid("41dba4f2-3c13-4bb3-9cf7-27a5e212199f"), "congtubaclieu.jpg", new Guid("6788f50a-b0e5-4c5b-835e-4d740eb46714"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), 16, new Guid("d7907a15-239d-4818-843d-a939256eb395"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(591), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("897e8628-f464-45cf-8797-3921800d5cf5"), "ngaiquy.jpg", new Guid("97361dba-3c18-4672-a008-55c92fa4bfea"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("6697c52f-2cff-4c30-a7db-6fa0a467be25"), 15, new Guid("d7907a15-239d-4818-843d-a939256eb395"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(653), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("b7d908d2-aeea-42ab-96bc-3d27b90d6c4e"), 110, new Guid("41dba4f2-3c13-4bb3-9cf7-27a5e212199f"), "chuyennhabanh.png", new Guid("97361dba-3c18-4672-a008-55c92fa4bfea"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("67bfac18-f395-4a5f-ba2f-cf9a9b507e6b"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(646), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("2d858c0f-a6e2-4228-abe9-97c54f8ea459"), 110, new Guid("accd2604-dd0a-4ef0-9ce8-fce8de93d05e"), "tretraukhongduaduocdau.jpg", new Guid("e6bc39a8-9e23-46cf-bec4-35bf824c3875"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("7cb9e5af-9880-439f-8ce2-94b88cc3c5f3"), 13, new Guid("4cd7b368-635b-416f-979e-5c5d331eb110"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(687), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 134, new Guid("51d0012d-c1e7-4e8f-be62-cb1b35a8584d"), "cuocchien.jpg", new Guid("522b1844-c87b-4da6-9ae9-db0daa69f1ef"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("7ee86d79-5bd2-4e1c-820b-514b68da39b0"), 16, new Guid("d7907a15-239d-4818-843d-a939256eb395"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(615), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("b7d908d2-aeea-42ab-96bc-3d27b90d6c4e"), 109, new Guid("11fc32f2-9720-4efb-a104-6460d35e67e6"), "yeuem.jpg", new Guid("97361dba-3c18-4672-a008-55c92fa4bfea"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("81af3615-e8a4-4b71-bbfe-01ee265b04d6"), 13, new Guid("d7907a15-239d-4818-843d-a939256eb395"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(668), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 113, new Guid("accd2604-dd0a-4ef0-9ce8-fce8de93d05e"), "cuoixuyenbiengioi.jpg", new Guid("97361dba-3c18-4672-a008-55c92fa4bfea"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("8892cf4f-39af-473a-b7a8-4bfa401a4757"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(622), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 99, new Guid("897e8628-f464-45cf-8797-3921800d5cf5"), "tetamhon.jpg", new Guid("e6bc39a8-9e23-46cf-bec4-35bf824c3875"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("8affaa93-8228-4d08-bb37-8b7d93306c26"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(660), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 100, new Guid("accd2604-dd0a-4ef0-9ce8-fce8de93d05e"), "chayngaydi.jpg", new Guid("e6bc39a8-9e23-46cf-bec4-35bf824c3875"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("a398415c-9000-49ef-847c-fe4cff4eca9b"), 13, new Guid("95c6d565-7c16-459f-8593-355c979ac948"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(681), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 118, new Guid("f89cde20-e7db-4d23-8db2-bfc2c489f850"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("a6c7db3b-8acb-41a0-89e1-9ec1d4799148"), 13, new Guid("caf27fd0-76aa-4882-81a1-4d04aff3318f"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(639), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("efd64aaf-74ab-4e5f-8c2d-5cc13169b00a"), 120, new Guid("accd2604-dd0a-4ef0-9ce8-fce8de93d05e"), "botubaothu.jpg", new Guid("6788f50a-b0e5-4c5b-835e-4d740eb46714"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("b87c7759-e513-4deb-bf6c-7d71b02b2852"), 18, new Guid("95c6d565-7c16-459f-8593-355c979ac948"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(695), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 127, new Guid("51d0012d-c1e7-4e8f-be62-cb1b35a8584d"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("d151181d-92f8-4b2b-bf40-3e88b8c272a7"), 13, new Guid("caf27fd0-76aa-4882-81a1-4d04aff3318f"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(674), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("0951faaa-3ce4-4e22-9831-cffd4be2c97f"), 123, new Guid("897e8628-f464-45cf-8797-3921800d5cf5"), "kinhvanhoa.jpg", new Guid("6788f50a-b0e5-4c5b-835e-4d740eb46714"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9785), false, null, null, null, null, "Room 1", 12, 100, 1 },
                    { new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9789), false, null, null, null, null, "Room 2", 12, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("18fbb7c2-2daa-411e-a9f0-b57b3fbd5681"), "Bắc Ninh", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9348), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("44133169-5bde-40b3-a555-54a94faef1ff"), "TP. Hồ Chí Minh", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9290), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("46117c04-e5d7-427e-8a98-2ca1fbc3621b"), "Quảng Ninh", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9443), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("592d6a83-4e74-412b-a112-508206a77c73"), "Đà Nẵng", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9259), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6049ce44-ebcd-430e-8301-82563441d94f"), "Hà Nội", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9193), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("85aedf83-2a0d-472c-8023-701e622fd941"), "Thái Bình", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9373), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("887d1a75-0b1a-4001-b91d-776b6180630e"), "Hải Phòng", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9226), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9260df19-ae1d-4dc3-9f88-0fb9cac8ca07"), "Hưng Yên", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9401), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ab200e5d-a070-40ab-a88b-3135988215a3"), "Nghệ An", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9319), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b50e2228-d579-4dc9-8578-0116d4e9be28"), "Nam Định", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9423), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cbc329ab-5d0b-4c8a-b657-ba850e2a9ec4"), "Hà Nội", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(9468), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("feca919d-9b81-4e1f-84ba-ca8ab412d25f"), "Hà Nội", null, new DateTime(2025, 1, 3, 23, 14, 24, 625, DateTimeKind.Local).AddTicks(8681), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("073aa2e1-c4a9-4796-8aac-5913dcdaaa0d"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(796), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 11, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(795), new Guid("f1d2383d-6a70-46c0-b788-9c1fe10adcec"), null, 0 },
                    { new Guid("0d45d589-6f3b-4866-b92f-8ca76d536f49"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(801), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 10, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(799), new Guid("500490e6-d3ab-454f-9324-157b16a4d789"), null, 0 },
                    { new Guid("2115ddb4-be50-48ed-b34d-4c7fce71a4a7"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(810), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 8, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(809), new Guid("2dfab786-30c7-4840-8ee3-59af102e09b0"), null, 0 },
                    { new Guid("3dc54f82-fa26-49c7-ae23-5f49fdd5cc4d"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(804), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 9, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(803), new Guid("212497d5-7cd4-4ad1-a2e0-e960babd8b72"), null, 0 },
                    { new Guid("61095a31-49b5-4454-95ee-ce133c6ae069"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(814), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 7, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(813), new Guid("27567a1a-59c9-4e07-aaa3-2421b171c760"), null, 0 },
                    { new Guid("a58c93de-0c36-46ef-b2cf-b144102c82d5"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(793), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 12, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(792), new Guid("42f300f7-5e48-432f-878b-48e63db072fd"), null, 0 },
                    { new Guid("d5e11f4c-2477-4cf3-b24c-b82e6d9a0f36"), null, new DateTime(2025, 1, 3, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(788), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 13, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(786), new Guid("e8ac2a81-5899-4678-906a-c68e474749c2"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00366fff-99b4-479b-a2af-ec8afed363bb"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(418), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0261d1e9-8d4c-4637-afe2-8b02eb0427c7"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(222), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("085eaf48-284e-42dd-8bfc-14e9278cce94"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(58), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09db66a0-c9e8-4320-9044-868846eb2f82"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9870), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c4e6d18-4243-4271-b392-c8955585a5ea"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9817), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d0ca8d0-a44a-440e-b2dd-d1e08cdcc1ca"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9907), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d4141b1-7e3c-4152-89e7-25a7b47f955f"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(60), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d8eaf07-6165-4d1f-a6ea-7fd41b3f391c"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(207), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e5a8515-1eb3-4028-a96b-5336848ceba4"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(84), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fb1bac9-28f1-4018-8d9e-1161b280002f"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(232), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fec4b79-8688-427c-b314-5c4034b6c9b6"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(328), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11daa59e-c378-4026-88c0-b22e4e5163c7"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9945), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14cdd67f-d916-4d21-b5cd-907ea2e70001"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(231), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15eeca87-ac70-4bc1-a5d3-d1e16ef825b3"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9895), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("163a63d1-d9b5-43ba-89ca-8bcad3a2c7e1"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(43), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b748649-ee07-433e-a268-2c91f4a98db5"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(258), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ba125b6-297e-4fe0-8740-5c3053a4a477"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(184), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1dd4fc4e-fa2a-4f9d-941c-06ff55dfb1ea"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(167), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e8e035a-dab8-40cd-bd2c-56ad3bf824a2"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(57), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21b1d6c1-5951-41be-9b13-8c932813fd6c"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9912), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22aae47a-21ac-4b37-992b-d73162cdb933"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(117), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2303bab1-1afa-4423-9b92-47ef5446d929"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(127), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2529879d-0137-453b-95d7-72dae2895266"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(81), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25d23d71-cddc-4121-9fee-c45a27c324bd"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(172), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("261d8323-77e5-40b6-a7f1-4a5e6612b4e6"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(92), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26e342f2-819e-4567-a3b6-87653e37c3c4"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(251), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26fcbf9c-3db6-49ab-af77-d0481f805d21"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(316), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26fcc876-517d-4a15-b6a3-8d9164e408c2"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(45), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("279395c3-4294-4bfb-86e5-df63b717409a"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(62), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("279b3cda-54fb-4ead-8131-925dbf747959"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(376), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("291a69bf-c041-4d3c-b3b7-47e3e3e3fc5b"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9969), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a7cb53a-5835-437f-af29-112eef098062"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(149), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b1c2d43-7a21-4fc0-bd13-b6f39f05a78f"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(24), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b5feaa8-a39d-446f-acf3-0f462767a7ca"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(48), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d716171-4c54-4c8c-9298-b1c554987620"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(369), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2e074647-f079-4613-bed9-c28970154ee4"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(182), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ec3f8a7-1449-4a95-8fd8-b1a4c23541fb"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(305), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f1cf36e-8d4e-4dbf-b967-71ad6dc3b03b"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(72), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f98f31d-5aca-49bd-ac78-7d32e8193e4a"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(358), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3031161f-292f-462e-8154-c4c175c01e9f"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(7), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("312eafd8-68f5-4d20-87fc-0f2793a62ec3"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(229), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31cb8a80-a424-4c27-b8c7-8af8d754cb1e"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(181), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32d2dc8f-e72c-4f31-b723-71251f111f28"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(365), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("337d8e60-b517-4418-ab15-cc7aabbdf99b"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(205), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33997abf-7591-4d18-9217-7b2d3c027b9a"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(260), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34ab8796-487b-4d6b-85ae-0124fae12f12"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(332), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("35f5d916-2a5b-4208-81fb-f2c90d2d3f46"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(103), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3743dc36-eebf-4398-ae5f-a607f718accb"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9889), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3793e99c-f863-42c4-a64d-6c046ede9705"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(108), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37e1a1d7-7b66-4bf3-bb5d-5b1b443dbadc"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(226), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("394b5b00-65a4-4e76-bb9e-8a08100ea2d3"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(36), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39565b18-02b9-4c30-8eaf-db85d1c36b05"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9878), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3aa82d91-b7ff-46ab-8c11-37f87b22cfd3"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(239), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bf8ceda-3d25-4215-95b1-2578f1388695"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(202), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fa292ec-b389-4b60-a87f-62e048e2d37d"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(100), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fd80db6-f090-42f4-948f-5747f3449603"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(383), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("400ead98-2dd2-4e39-9e4e-7348e97c080d"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(397), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40fe557b-9f54-462c-9220-191142ddee56"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(4), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4274b613-a74b-4c3b-b63d-075b29b448ce"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9994), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("464bc431-1fc0-4ea7-9330-04accd8cb75c"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(51), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("469909c4-e948-47e6-b6c8-cf6599fde067"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(115), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46e80e65-0ff4-4795-82e2-df34727ba611"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(124), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46f4b11e-96fc-4b9d-a700-e069f60084e0"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(310), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("472fe15e-94b3-4796-8e9c-c766ed01f8ff"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(360), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("482a5648-6a18-4fcf-b07a-9ef1b6bf66d6"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9939), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("489bc340-20c8-4ec8-9d3b-d93620fc6a1f"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9861), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49ed9ce2-bd3f-442d-84af-e5dbe27e2970"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(55), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a0f5ee1-a221-40f9-afb9-b0749e30a261"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(340), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a105ef0-6c70-4beb-86a6-e26a5b8b2d1f"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(200), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ad7bd33-e5d6-4aa9-8df9-0d22748d3a82"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(337), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4cb7cf66-6bec-4c17-91fd-fe11305ba9f8"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(179), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d3aa27c-3f2b-4310-b0ce-e2dce10fb107"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(381), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d961b6b-39f0-4a08-947a-a68e1b5244a3"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(420), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e1b6ce7-f6f4-4832-8e3b-5ef462e5e622"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(105), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e606b90-9259-4db5-b497-e0d701743d3f"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(291), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4eb89de4-bfb0-43f7-bc8c-0f6b2ae09d07"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(15), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f14e313-d42c-4e95-8619-a45368691658"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9957), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f305a84-cf4b-4a01-b3ac-f9db3a3c10d4"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9927), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4faab824-ca3f-4b21-9e14-b1822f909076"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(165), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("504b5412-4561-41b4-adfe-13a2ddb8d25d"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(25), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50de2109-35d9-4a14-bd65-b6759d49bf53"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(139), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51daaefd-a2a8-4bcd-bb4e-6a1bc81a4484"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(194), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52910be0-3a3f-47cf-bf11-c82a73810583"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(22), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5401929a-b2d1-4195-98fb-a1c6581337bd"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(40), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("540961ab-3223-4359-a59b-18db6d29c45b"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(321), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57e43fa2-4879-4b07-8630-30260687adb7"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9885), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("581ca6a3-b639-46f5-a900-0e8dd04a274f"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b5b9f7d-91ae-465c-bf75-fde3bcd181d2"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(265), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b7c473f-040f-4ce5-89fb-e40dc7a308db"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9910), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b9d5db5-e4a4-4d70-9bb3-193b8e0d917b"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(79), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5beedec8-d37d-4026-993f-bfb9084ef572"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9901), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e27a603-fa69-448d-ae1d-f93db499df9d"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(163), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5eee81b9-6fee-48a1-a367-03a59653aec0"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9903), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6056ed43-9902-468e-a4e8-2b3cceda5ac6"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(159), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60dafa9d-f6b6-400e-9c08-0e386b06cb4b"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9971), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61593cf0-0537-441f-9441-342078af69f4"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(20), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61876342-cff4-4fbb-98b8-6781f87fc17e"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(374), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61f104d9-7081-4adb-b914-9b8026668f55"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(204), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62a83ca5-eb61-4901-b2fb-53972c3ca46b"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(129), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("638c1c2d-0106-4584-a28e-bc0d115471eb"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(399), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("642380e7-2041-47a0-8b07-beda70f7ff43"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(141), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("642b8101-166a-482d-9c5b-ba2ef0868a89"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(98), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("644d71c5-6217-422c-8fa9-d375473a5cad"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9872), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6484db0a-53eb-4d59-8fdc-d7463d6f0146"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(215), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64850543-27ab-49eb-941b-8c39e7ae9c83"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(27), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6848917b-4556-46bb-b76f-1052d62a6abc"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(77), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6955249a-4847-4317-bbc1-8b4ec29515df"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(110), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6993d7e3-67b8-4469-8fe8-71da6ec57b7e"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(121), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a12ed66-2479-411d-bd02-e382499ba6a7"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(423), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b0f5681-69ae-46d8-87e6-d3d3d10a2b2b"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(177), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e3bd334-db33-4148-aad8-1d960bd22cf0"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9951), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6eeffd01-f733-43b9-944f-695dcf2c68e1"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(64), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fb3b1fa-4f3a-477f-8ce6-2cb9c2107e58"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(219), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70cf37fa-4b7e-41d4-be66-ec84365366eb"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(162), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7309bd82-e96a-4ffe-844e-4078c195cebd"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(125), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("759d2402-33bf-4bf5-a886-8221ea71a31b"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9949), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("764e5550-737e-441d-9a25-5286185950d0"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(132), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7675ac60-2d89-474b-aab9-f0106459f829"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(269), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78c3be3c-cd02-435d-ab63-74ea5c9ca739"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(416), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c8a1e5e-2598-40f1-bc15-d6fa2bc50f5d"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(236), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cc707c4-c981-493b-979e-56e78ab93808"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(387), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d148118-8288-4720-b048-a60017fd2acd"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(422), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7def9e7b-216d-4397-b990-167bfabf64fc"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(390), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7e12f1f2-85d4-4712-adc1-40b3536c1048"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(10), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f55993f-10e5-491c-8562-406e83809496"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(407), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fff4f6b-cac4-4bba-a6fb-1a572bf6ef21"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9955), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81169380-53c3-4b99-af33-379930d40de4"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9942), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("817e4dd4-ca9b-464f-88e9-c5708369f0c2"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(157), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85a02826-7b92-4176-b4a8-98910579512d"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(75), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85eb437d-76f5-4ada-9e55-5ce26c61dd15"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9915), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86032e7d-e820-4437-b06f-676bfb337f30"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(247), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("873636e1-fd84-4539-8259-f3957f79efa8"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(326), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("892b28a2-9a0a-455d-a817-2656b0f707c0"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(169), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b78a0ad-4cb5-4b99-9f0b-c9aa108ec8da"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(284), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b81ab25-5028-4574-90d7-06edba09b477"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(409), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c2fcd09-0ec3-4452-a16c-a8c270f6682a"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(344), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8eaaf83f-69fc-4fa7-925b-ef6900636b52"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(378), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8fcdb1c9-46e1-4037-86c1-7a6e318f4720"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(221), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91fe1e1c-e2fc-4ea7-a674-2abb9ca993e1"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(261), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("951ead98-95e5-4e54-9add-6a5db436db50"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(152), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95d587e4-bccd-4c9f-adc7-adbe055fc931"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(73), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9667c286-b497-4d15-8c9a-8f46046b4bee"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(312), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96bf359b-acdf-425a-a5aa-90271fdac798"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(210), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96eb0e23-4ecb-4999-808d-35e673fa2763"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(393), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97d64010-e78c-41e8-845e-66546777b852"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(53), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97f90115-79bf-4825-9d81-60cc668f5314"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9944), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98b7a336-7017-49d7-ab3c-83a9547932b5"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(330), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99633a3e-c203-4b04-b852-9c042c33c662"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(2), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99d9795b-1923-4b75-b6a1-5fd34d34cd5c"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9931), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a99de86-6d8b-4de5-be57-0e2740eb456c"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(18), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e47cbd6-f61c-4b29-833a-e3c3eb2d3e8c"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(287), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f0b92b5-0887-4cd7-b33c-51be349419ae"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(154), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f4b8cc9-917c-4cb3-8b7e-df952d193ba6"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(214), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f931388-99b1-4784-b718-8dc07e322b08"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(282), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a071f44e-3933-41e6-b194-864e481a745c"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(12), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0868d38-0c2d-41c5-9d0f-63550413c5a5"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(274), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1e473cd-e3b5-4f6e-89c1-f5bf4e682b7c"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(209), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a21c31bb-7a89-4ad2-a780-aaad6871df11"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9959), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a38feff9-49e7-4c5e-af5a-f64eecaacdd5"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(280), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3a1853e-0448-4f90-a78f-a2f046613116"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9962), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a400c535-e3e1-4074-a52e-57ea89cdc056"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(272), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a41229ae-ba2e-4962-81ec-ba7ece47bd37"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9858), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a46c0357-2c29-4f4c-961a-302845c56558"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9929), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4b89887-5f5c-473b-8a99-5d47d4956c7b"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(253), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5fbd853-f4a2-4ddf-a95e-03a3dafdf671"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(17), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a747f046-dd0f-4923-b2ee-db5924ea532e"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9880), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9452e69-5609-497f-ba66-1048f129abc7"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9905), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aae62744-b387-462a-b171-a4a45bf6b390"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(354), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab3cfe9d-8adb-44ed-857d-b149b39b303e"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9935), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab80e6e8-6e0d-44cc-94de-abaee6e17959"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(42), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("adb864ce-2464-450f-8ae0-db35a6a4bb4e"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(285), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b00c8de0-bd04-42f8-b114-2b3f5bbf401e"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9933), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1c05cbd-9770-4e7a-a8eb-195c6627b1c7"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9998), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1cb909e-6fc1-4d71-950b-d3c6105a37b8"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9892), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b528ebb8-d6ab-4be2-addb-6f1963112d6a"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9855), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b56c7835-eb42-4f79-b33f-b2af8c1e537a"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9990), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6c463c3-e8ef-4bf1-9698-7816d44dcf31"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(325), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b82f5550-6a0c-40fc-8b0c-b2b38a050a0e"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9964), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba3a7ea7-5995-4749-b24e-ebe7a917d8e6"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9852), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc46ce2b-2d62-4606-9d27-4313c0fbbe79"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(192), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd10189c-9b32-44f2-9d95-93967f999995"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9961), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be7dfdab-d47f-4977-af88-273ae753be87"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(195), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c00a19d9-6fee-4b3a-b558-f6b2e5d0bd28"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9966), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c075f84b-a45f-46af-b81f-88ffaab1ee1d"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9947), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c192d808-20f2-4414-92ea-b5e45d5ed568"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9987), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2a10c7c-0f41-4544-9f77-8c03d9dcea3a"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9899), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4280c89-2338-40e1-828a-8bdb27032f1d"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(96), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c494ef92-aa70-48aa-8d1e-1b3787cf717c"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(303), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4b368d0-2f82-496a-8064-6a5bbe0ad5df"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(289), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4d0bfb8-b94c-4a1a-b101-34d82527f598"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(275), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4e4ab45-9790-4348-99fe-0f9632feae47"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(385), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c72f162a-d1fc-45b0-b04a-7650c8a158ce"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(111), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9a1b033-cd84-402e-ade9-87661baf0f53"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(314), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca55f6d6-73fa-4fb4-a3e1-36834c5ed0bc"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(363), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ca7bf5c5-40d1-47f1-8a92-27c62adc52b0"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(150), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb1b6292-09c6-4797-bf3a-c1ec63821f8c"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(392), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd5cb323-7509-4051-93f3-e83e22e0d9dc"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(307), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce535e83-ba35-474b-8f39-445d605e4100"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(339), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce71e879-98c7-4708-9101-7bf7b82811f9"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9992), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce914b5d-d252-493f-8570-fbbbff43bb10"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(412), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d09d32ab-c44b-473f-90f9-bd2251267758"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(68), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d10991ae-2427-4104-ade5-b02800f1b382"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(174), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2283cb6-8d27-4ec2-861e-e57efe5b3a1c"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9887), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3897069-cc6e-4c1e-8ffe-f64f9a7b8993"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(237), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5912a27-6dc6-4033-9035-652ca904ac91"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(414), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d71195df-25fc-47f0-aa40-2238b86adcad"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(380), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d74de3d8-8df0-416f-8622-8f0989b0de38"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9876), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7bc5c7e-082a-4872-b1fc-bf6b5411494e"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(234), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db131e3b-6a0b-47a1-8a56-69f14ce6ecbc"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9940), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e0cca3d3-328b-4495-bde2-3df333000771"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(367), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1093f12-f0e9-492a-9480-6a25bae2ba04"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(6), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1e8d76c-e9bb-470b-8667-76348c4eac85"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(346), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3e68525-5109-4b00-bfea-1db7cbe34f9a"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(270), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e43b6d12-00b8-4b5e-9c11-9f63c689554e"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(255), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4a24bdb-5b52-4133-9c9b-1565a9286711"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(47), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e595cd13-595c-4df0-8d84-8271ddecc835"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(119), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6fb856a-2334-436c-9d40-5e2f17a0ce90"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(101), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8d268f4-c447-41c3-a659-306a7044c56f"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9988), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e92c017e-12d3-4b2f-8df2-dd61a6d08e56"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(257), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e99e4703-a8cd-45b1-b56c-8b0df7dbb080"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(217), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9d7dc78-acd9-4668-b14f-f163737d16f4"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9995), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea9755a1-b36c-43be-ac88-3ee213266bcf"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(309), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eac36c76-cf1e-45b8-949c-aa48b3ff5219"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(277), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eae8bd44-5857-414d-bcfc-0cb0f95fbe3d"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(371), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed06a17a-ac37-4b79-9e18-95cb9149b2e5"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(320), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed35c9dc-87c4-452d-9818-02046dfe03dc"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(224), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed92c086-5b5d-4caf-8821-3d63a8e98cc6"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(136), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eeb924dc-3300-4f73-94e6-c00d06f9e51e"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(335), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef7e312b-5701-4c81-90d8-63a86295d937"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(362), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("efb1ec88-d362-4386-a430-d6357807c489"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(198), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f066be09-70ff-4bc7-9fc5-c4229fb7845a"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(250), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f10f1172-9fa3-4431-951a-dda99454bb32"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(323), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f24cd19c-5130-4ad8-8da0-f25389fa5cd4"), "H", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9874), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f33ab97e-413e-4677-8321-4dcb88681f40"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(342), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3d0559d-4021-4b69-9709-30c4e0635643"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(113), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3fb7e84-0a13-4328-9ea0-b3db6b1665b1"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(38), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f45f8191-9bd0-48bd-b1c6-d3e5deab0b00"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(131), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f66bfce2-c3c4-4a59-aad6-c91e4d27b3c4"), "D", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9954), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f74b93c4-1165-4525-bd17-8310c1e212ea"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(293), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7b16944-3322-4e65-a281-9e25fbd6871a"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(395), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f7dad010-1c67-4120-adb3-6737c3d8897b"), "E", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9909), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f86593bd-4b6d-42ef-b56c-fba3d3589ef2"), "C", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(70), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8fa78e2-b1e5-458c-b30e-7f2fde30cb15"), "F", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9890), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f97df626-f7b3-4062-80de-3a65ca9eae90"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(134), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fbb18f5e-21c7-4244-8c14-4f17ef208aad"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9896), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fca79778-abb3-4640-96f1-347282f44a36"), "J", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9925), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd8ac0b2-bec9-4d8f-93e5-84059c6a0c6f"), "B", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9883), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fea61104-0056-4598-8996-05e9a7bf9638"), "I", null, new DateTime(2025, 1, 3, 16, 14, 24, 625, DateTimeKind.Utc).AddTicks(9917), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("feabb299-0065-483a-afcf-0328e53ab853"), "A", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(267), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffd653d2-1352-4424-8554-641c8152deeb"), "G", null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(170), false, null, null, null, null, new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("3865efea-aede-452b-ad7f-8bfb25f3299b"), null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(757), new DateTime(2025, 1, 5, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(759), false, null, null, null, null, new Guid("2a1bdcc3-7d7c-4b97-8923-08dc59ca1b1f"), new Guid("dcba748c-b8e1-4c8d-8f6a-574736678944"), 1, new DateTime(2025, 1, 3, 23, 16, 24, 626, DateTimeKind.Local).AddTicks(758) },
                    { new Guid("fe12dc2b-95bb-474c-af5b-fafcfe4bf9c5"), null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(742), new DateTime(2025, 1, 4, 23, 14, 24, 626, DateTimeKind.Local).AddTicks(752), false, null, null, null, null, new Guid("37dfe56e-2e16-4ee3-ae18-2a92e6560187"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 3, 23, 15, 24, 626, DateTimeKind.Local).AddTicks(746) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("aad75bbe-70e2-473f-87fb-e0e2a31ad0f4"), null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(878), false, null, null, null, null, 60000m, new Guid("a58c93de-0c36-46ef-b2cf-b144102c82d5"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("42f300f7-5e48-432f-878b-48e63db072fd"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("c2a06f9f-f5a7-4c2e-a967-7bbdad39da0e"), null, new DateTime(2025, 1, 3, 16, 14, 24, 626, DateTimeKind.Utc).AddTicks(869), false, null, null, null, null, 50000m, new Guid("d5e11f4c-2477-4cf3-b24c-b82e6d9a0f36"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("e8ac2a81-5899-4678-906a-c68e474749c2"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
