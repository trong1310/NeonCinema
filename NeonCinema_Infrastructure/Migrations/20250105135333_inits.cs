using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class inits : Migration
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
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4945), false, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("a9837959-3bda-4d19-bc35-41ec7abe66f3"), "11:00 PM", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4951), false, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0384b255-65e5-4c1c-9748-466b02566dee"), "Úc" },
                    { new Guid("671e9ed2-8ab2-472e-8aef-5313f17778a9"), "Mỹ" },
                    { new Guid("78e09cbd-c3a1-4183-9a75-e1efc982e220"), "Vương Quốc Anh" },
                    { new Guid("8c7634a5-7b4d-4c3d-984c-e2e7542ba2b0"), "Hồng Kông" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("b17d0a5c-6107-4c17-aed1-13fefc3b6c21"), "Trung Quốc" },
                    { new Guid("c520cc7f-3ad8-41b0-b382-ae186a32cbf4"), "Ấn Độ" },
                    { new Guid("da106ef3-551f-4306-897b-4720796128fb"), "Hàn Quốc" },
                    { new Guid("e38f72af-1ee6-4f66-8c39-423a1e23f7b0"), "Việt Nam" },
                    { new Guid("fc34330e-b34b-4f66-b038-562aec7987bf"), "Pháp" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4746), false, null, null, "Ngô Thanh Vân", 7, null, null, "Việt Nam", 1 },
                    { new Guid("326941fe-40bd-4414-8078-631f666eac36"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4742), false, null, null, "Charlie Nguyễn", 6, null, null, "Việt Nam", 1 },
                    { new Guid("711359ae-6ec9-4f31-a892-b8e57d09b1a4"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4757), false, null, null, "Huỳnh Đông", 6, null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4727), false, null, null, "Trấn Thành", 6, null, null, "Việt Nam", 1 },
                    { new Guid("9e05ae1c-3959-4743-b0e4-f3a2f30affe9"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4749), false, null, null, "Đỗ Đức Thịnh", 6, null, null, "Việt Nam", 1 },
                    { new Guid("ad7f07e0-4dfd-4a78-acd8-5c42781a9b66"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4752), false, null, null, "Vũ Ngọc Đãng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("b0267988-e346-433d-a3ce-e4b5b1eed7aa"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4740), false, null, null, "Victor Vũ", 6, null, null, "Việt Nam", 1 },
                    { new Guid("d467ceb8-7ab7-4ddf-b61e-72966acb8963"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4737), false, null, null, "Lý Hải", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f3041e7a-2fcf-44ff-86fd-dd9c24bc1b8b"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4754), false, null, null, "Nguyễn Quang Dũng", 6, null, null, "Việt Nam", 1 },
                    { new Guid("f9016ef9-2f4f-459d-9619-b59bb5797b8c"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4751), false, null, null, "Phan Gia Nhật Linh", 6, null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("19bdcd92-092d-41af-b694-9a5ef397ba7b"), "Combo 3", null, new DateTime(2025, 1, 3, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6220), false, null, null, "1 bắp + 1 Aquafina ", "combo3.png", null, null, 75000m },
                    { new Guid("2ca94415-d8a3-4981-9a03-d2b9fde3c798"), "Combo 2", null, new DateTime(2025, 1, 4, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6217), false, null, null, "1 bắp 2 cola", "combo2.png", null, null, 100000m },
                    { new Guid("83e7cd18-4aca-42ca-8622-5168772e508c"), "Combo 4", null, new DateTime(2025, 1, 2, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6223), false, null, null, "1 bắp + 1 cola + 1 khoai lắc", "combo4.png", null, null, 135000m },
                    { new Guid("9fd1eec5-46ad-4391-946f-1a8b664c91f6"), "Combo 1", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6214), false, null, null, "1 bắp 1 cola", "combo1.png", null, null, 80000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0f5f836f-369d-4d92-b331-903e40738c7d"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4813), false, null, null, "Tâm lý", null, null },
                    { new Guid("1d19ff8a-6435-400d-8ae2-0539057315b5"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4809), false, null, null, "Phiêu lưu", null, null },
                    { new Guid("5d9ce47a-96cf-443b-b48e-2d0a68c08bd2"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4812), false, null, null, "Lãng mạn", null, null },
                    { new Guid("6be9ea90-8751-4118-bd32-95ebf60ea791"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4811), false, null, null, "Hài hước", null, null },
                    { new Guid("6df0515d-598f-4d45-bf75-745d91913481"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4801), false, null, null, "Tình cảm", null, null },
                    { new Guid("78bd0fcc-9a59-4994-a7fd-1a3049655838"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4815), false, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("8e0eb858-6c76-42aa-8037-ff2ba3fe116b"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4807), false, null, null, "Hoạt hình", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4797), false, null, null, "Kịch tính", null, null },
                    { new Guid("faebf9c1-700a-40dc-8904-4e8f8a1c6816"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4803), false, null, null, "Hành động", null, null },
                    { new Guid("fe8bf80d-f00c-4a59-9ac8-8466ba7656d3"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4806), false, null, null, "Kinh dị", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("08ed13b9-c6fe-4010-acfc-c65960d84b08"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4681), false, null, null, "ThaiLans", null, null },
                    { new Guid("4c9c18a9-aa5c-408f-9683-26ac094b7833"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4683), false, null, null, "USA", null, null },
                    { new Guid("784ca197-43b0-433e-8e92-6aa54d85313c"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4677), false, null, null, "VIE", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4673), false, null, null, "EN", null, null },
                    { new Guid("c6d3c6c9-d41c-48bf-b748-529e9ffd4bab"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4686), false, null, null, "Korea", null, null },
                    { new Guid("e6e6934f-2f42-490e-9e68-76765fec2acc"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4680), false, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "MovieType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieTypeName" },
                values: new object[,]
                {
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4051), false, null, null, null, null, "3D" },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(4054), false, null, null, null, null, "2D" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(3894), false, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(3918), false, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(3915), false, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4915), false, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4917), false, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4911), false, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("26002850-6382-47a4-b54c-afb3cbbded63"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("4a2eacc3-392a-4f51-b3ff-71ae007ee8ec"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("5c33ca2d-2868-40d4-9200-1dab846b4a1a"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("71475752-bbf5-4b94-bf55-dd8cca9eab87"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("71c18e38-01ac-4c6b-acbd-2252562a8824"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("72087f4d-8741-4baa-ad49-c9a3edb2de0e"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("7a7fb16a-e2ad-42fb-aa5a-ba397162d615"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("9feedc3f-6a2d-45ee-95d6-91e02310fd3c"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("b554fba9-05dd-4eed-8ca2-c2afd6e90744"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("d74ecf54-09a4-4854-8d01-3702ae2f1ec7"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(6151), false, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "MovieTypeID", "Name", "StarTime", "Status", "Sub", "Trailer" },
                values: new object[,]
                {
                    { new Guid("0db05207-ad70-4cc3-9dd2-16def9397c95"), 13, new Guid("0384b255-65e5-4c1c-9748-466b02566dee"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5976), false, null, null, "Sau sự thành công của hai phim điện ảnh chuyển thể từ tác phẩm đình đám của nhà văn Nguyễn Nhật Ánh, một tác phẩm nổi bật khác của nhà văn hiện đại thành công nhất Việt Nam chuẩn bị được đưa lên màn ảnh rộng: “Kính Vạn Hoa”.", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 123, new Guid("6be9ea90-8751-4118-bd32-95ebf60ea791"), "kinhvanhoa.jpg", new Guid("4c9c18a9-aa5c-408f-9683-26ac094b7833"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KÍNH VẠN HOA: BẮT ĐỀN CON MA", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "https://youtu.be/EDDbR2jINsQ" },
                    { new Guid("0fec176c-edf5-4878-adfd-9b315ff0f223"), 13, new Guid("b17d0a5c-6107-4c17-aed1-13fefc3b6c21"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5992), false, null, null, "Một cuộc tấn công bất ngờ của Wulf – lãnh chúa Dunlending thông minh và tàn nhẫn muốn trả thù cho cái chết của cha mình, buộc Helm Hammerhand, Vua của Rohan, và người dân của ông phải thực hiện một cuộc chiến đấu cuối cùng táo bạo tại pháo đài cổ Hornburg", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 134, new Guid("faebf9c1-700a-40dc-8904-4e8f8a1c6816"), "cuocchien.jpg", new Guid("e6e6934f-2f42-490e-9e68-76765fec2acc"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "THE LORD OF THE RINGS: THE WAR OF THE ROHIRRIM", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/4pP71_7b_Y4" },
                    { new Guid("1110cdc1-fd26-4489-a712-db949caf12d1"), 13, new Guid("0384b255-65e5-4c1c-9748-466b02566dee"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5904), false, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("b0267988-e346-433d-a3ce-e4b5b1eed7aa"), 113, new Guid("1d19ff8a-6435-400d-8ae2-0539057315b5"), "congtubaclieu.jpg", new Guid("4c9c18a9-aa5c-408f-9683-26ac094b7833"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("3677c81c-c086-43f6-92e2-bc9ed41ed479"), 16, new Guid("fc34330e-b34b-4f66-b038-562aec7987bf"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5911), false, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("326941fe-40bd-4414-8078-631f666eac36"), 109, new Guid("fe8bf80d-f00c-4a59-9ac8-8466ba7656d3"), "yeuem.jpg", new Guid("c6d3c6c9-d41c-48bf-b748-529e9ffd4bab"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("3bb75180-c915-4919-8461-f7275c308cf2"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5944), false, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("b0267988-e346-433d-a3ce-e4b5b1eed7aa"), 110, new Guid("5d9ce47a-96cf-443b-b48e-2d0a68c08bd2"), "tretraukhongduaduocdau.jpg", new Guid("784ca197-43b0-433e-8e92-6aa54d85313c"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2025, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("3e21b9dc-c02c-42ab-9adc-e76b9459ecd0"), 13, new Guid("671e9ed2-8ab2-472e-8aef-5313f17778a9"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5985), false, null, null, "Sau khi Simba trở thành vua của Pride Lands quyết tâm cho đứa con của mình tiếp bước vị trí đầu đàn, trong khi nguồn gốc của người cha quá cố – Mufasa được khám phá.", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 118, new Guid("0f5f836f-369d-4d92-b331-903e40738c7d"), "mufasa.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "MUFASA: THE LION KING: VUA SƯ TỬ", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/1KtBhnTfq8I" },
                    { new Guid("65cd97b9-a991-4691-81e7-f63deb3b715b"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5919), false, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 99, new Guid("6be9ea90-8751-4118-bd32-95ebf60ea791"), "tetamhon.jpg", new Guid("784ca197-43b0-433e-8e92-6aa54d85313c"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("7805bd78-bb72-4c3e-9eb7-938589e7d690"), 16, new Guid("671e9ed2-8ab2-472e-8aef-5313f17778a9"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5929), false, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("faebf9c1-700a-40dc-8904-4e8f8a1c6816"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("7a25d298-4046-4de5-b557-27d9f7b09fcd"), 13, new Guid("fc34330e-b34b-4f66-b038-562aec7987bf"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5969), false, null, null, "Jin Bong là cựu cung thủ quốc gia và là người đoạt huy chương trong môn thể thao của mình. Anh hiện làm quản lý trong một công ty, nhưng công ty đang trong cuộc khủng hoảng tái cấu trúc. Vào thời điểm đó, công ty của anh đang thúc đẩy dự án Amazon.", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 113, new Guid("5d9ce47a-96cf-443b-b48e-2d0a68c08bd2"), "cuoixuyenbiengioi.jpg", new Guid("c6d3c6c9-d41c-48bf-b748-529e9ffd4bab"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "AMAZON BULLSEYE: CƯỜI XUYÊN BIÊN GIỚI", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/JedDZeuTrzQ" },
                    { new Guid("8d889005-bea8-43f3-9399-b880bacbdc5b"), 15, new Guid("fc34330e-b34b-4f66-b038-562aec7987bf"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5952), false, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("326941fe-40bd-4414-8078-631f666eac36"), 110, new Guid("1d19ff8a-6435-400d-8ae2-0539057315b5"), "chuyennhabanh.png", new Guid("c6d3c6c9-d41c-48bf-b748-529e9ffd4bab"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("b0fbc640-feb8-4187-a758-fd97b434cf2a"), 13, new Guid("0384b255-65e5-4c1c-9748-466b02566dee"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5936), false, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("d467ceb8-7ab7-4ddf-b61e-72966acb8963"), 120, new Guid("5d9ce47a-96cf-443b-b48e-2d0a68c08bd2"), "botubaothu.jpg", new Guid("4c9c18a9-aa5c-408f-9683-26ac094b7833"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BỘ TỨ BÁO THỦ", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("c114a6ac-c5eb-43f0-b7bc-c9c841e1ddbc"), 18, new Guid("671e9ed2-8ab2-472e-8aef-5313f17778a9"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6000), false, null, null, "Mối quan hệ phức tạp giữa Kraven với người cha tàn nhẫn, Nikolai Kravinoff, đã đưa anh vào con đường trả thù với hậu quả tàn khốc, thúc đẩy anh không chỉ trở thành thợ săn vĩ đại nhất thế giới mà còn là một trong những thợ săn đáng sợ nhất.", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 127, new Guid("faebf9c1-700a-40dc-8904-4e8f8a1c6816"), "thosanthulinh.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "KRAVEN THE HUNTER: THỢ SĂN THỦ LĨNH", new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0, "https://youtu.be/gnj_VBjwiqU" },
                    { new Guid("d28e36c9-e070-4410-bba1-88593349ba97"), 18, new Guid("fc34330e-b34b-4f66-b038-562aec7987bf"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5884), false, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("d467ceb8-7ab7-4ddf-b61e-72966acb8963"), 81, new Guid("6be9ea90-8751-4118-bd32-95ebf60ea791"), "xich.jpg", new Guid("c6d3c6c9-d41c-48bf-b748-529e9ffd4bab"), null, null, new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("dd2b5fc7-c8e8-4791-803d-a445478f3050"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5962), false, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("19e27ad8-043b-4987-b8f2-34fcdbbe948c"), 100, new Guid("5d9ce47a-96cf-443b-b48e-2d0a68c08bd2"), "chayngaydi.jpg", new Guid("784ca197-43b0-433e-8e92-6aa54d85313c"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 0, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), 16, new Guid("fc34330e-b34b-4f66-b038-562aec7987bf"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(5873), false, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("6be9ea90-8751-4118-bd32-95ebf60ea791"), "ngaiquy.jpg", new Guid("c6d3c6c9-d41c-48bf-b748-529e9ffd4bab"), null, null, new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1, "https://youtu.be/4d7xzz0cTVw" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4990), false, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4985), false, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("6541e157-ad33-4c4b-88e2-9b083405d2ba"), "Hà Nội", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4557), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "staff@gmail.com", "Staff", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "9876543210", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("d6479b87-0458-4401-b646-96061879f8dc"), "Hà Nội", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4584), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "admin@gmail.com", "Adminn", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0334583921", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("f1c166ec-4144-41a0-91d7-c8b3c4feabe2"), "Hà Nội", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4614), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("fc087be9-8af1-4f73-bdea-73ba949bb46b"), "Hà Nội", null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(4126), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, null, "client@gmail.com", "Client", false, "avt-default.jpg", null, null, "NRELDnTH4T5RRzAipPZ4Gw==", "0123456789", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("13cc9cf8-d4cf-43ee-a46d-fc0473a7c389"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6095), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 14, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6093), new Guid("4a2eacc3-392a-4f51-b3ff-71ae007ee8ec"), null, 0 },
                    { new Guid("309ea354-d608-4ede-9294-fc635d01b321"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6117), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 10, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6116), new Guid("71c18e38-01ac-4c6b-acbd-2252562a8824"), null, 0 },
                    { new Guid("7765beba-5770-418b-bd11-cdba7df7880e"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6103), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 12, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6101), new Guid("b554fba9-05dd-4eed-8ca2-c2afd6e90744"), null, 0 },
                    { new Guid("8401f921-4afa-4370-87af-b519c1ba921f"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6089), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 15, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6087), new Guid("26002850-6382-47a4-b54c-afb3cbbded63"), null, 0 },
                    { new Guid("c8a75c5b-e263-4199-82a5-a4f58e4a5d15"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6121), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 9, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6120), new Guid("7a7fb16a-e2ad-42fb-aa5a-ba397162d615"), null, 0 },
                    { new Guid("dd79ce36-0898-484e-9e19-8f42a2c5e51a"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6106), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 11, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6105), new Guid("5c33ca2d-2868-40d4-9200-1dab846b4a1a"), null, 0 },
                    { new Guid("faf1fb7a-bcd0-41eb-82b2-302cdce5e8bc"), null, new DateTime(2025, 1, 5, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6099), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 13, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6097), new Guid("72087f4d-8741-4baa-ad49-c9a3edb2de0e"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0030b386-9fca-48e5-9e04-aa673ab9a156"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5530), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("003f69be-d922-4b6d-becf-ef9d2b45917a"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5434), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00825ba5-0d42-4864-b4f9-66bf28410fde"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5498), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00fee17b-1a9d-449f-bfd6-15135dec5d58"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5673), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("010f00da-3b80-4c63-8f02-7ddc33c3a96a"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5197), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("013892ce-c9d6-412d-8882-7de9dd6bc120"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5305), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0327cc86-e438-4839-a126-06e88caa6aee"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5469), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("039c5fb3-a7a3-447d-bec4-8d8eeb624e47"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5675), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03e7b89c-6f42-4089-8c30-f24d7f75f8d6"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5521), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("040923cf-a4b1-4f82-a8db-3459f5ed711a"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5502), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0482420b-56d2-4092-ab6b-a3c2f5029151"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5414), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05b2a523-612e-4298-9958-04633ec61ca5"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5596), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05c1a786-7035-407f-9779-1efc91fe1e18"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5023), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06cd8ca4-1d2e-4d4a-97a4-60b645e24014"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5377), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06ee68f1-dfe4-450d-b03c-bb79408337ed"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5373), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("076403ba-336c-4569-b69f-8fbc27738330"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5391), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("084ca8ee-94d6-4ef6-b75e-6743dd2d7b7d"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5346), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08518de3-7814-4a0c-84b6-73c3a5c5fe44"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5504), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b2ce9f1-4be8-4690-9e33-a67e5c28f1e4"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5685), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c677895-8d3a-4e8f-8d69-3cda9b25de1d"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5397), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0eb065d7-5945-41d4-a18c-5475e319bc71"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5619), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fd6d8ed-e323-4771-abe2-511b400351fa"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5126), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10237010-6187-44a7-ab95-d5e8e49f81ca"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5602), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10682e73-b9b5-4a93-ab0c-ebea877aef33"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5331), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1324f4b1-f174-445e-b59f-7071bc845d3a"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5459), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("13457179-db42-47a6-96f0-bafa4ed3e7cf"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5339), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1478b34d-9dd1-4936-bc18-bda88332ec93"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5207), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16556f2e-e898-4811-8e84-d22de7f344e5"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5538), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19f45498-53da-4bc0-8ef0-5b596cb72ad1"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5371), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b06f965-6c8c-4f1c-bf9e-b19cf202b45b"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5681), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c18ded8-988b-42d1-90f5-ca613395e5d2"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5598), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d0c3353-4331-44b4-a1e4-7aa52a0c992b"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5210), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d8bf69c-2fb8-43a9-a03e-78896a16cc6c"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5091), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e1b7d64-d025-4181-b11b-0dbbcc7a637e"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5404), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e4bb3e7-2623-470e-89da-2d068346a266"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5094), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1fe3d05a-e068-4388-ab6c-8e6318247982"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5329), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2011b481-5011-40d4-93fc-abee839c2bfa"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5452), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21f1a818-4411-46f8-9db0-2b8a5c8dc8f2"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5281), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22dcc440-3f1e-472d-a6cc-14762c5df8d3"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5333), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24f82f11-94eb-490e-8d86-2fe53fbd221b"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5484), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27e6279d-60c7-4605-8063-e7792cea4950"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5492), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2974cc4d-5317-4e0e-826c-16e8d7cca0bf"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5275), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("299ed718-40c5-4916-b273-b4cd130eec25"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5314), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ae88630-8763-4022-bc8f-0b981b091fea"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5303), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d3a8fae-209d-42e5-b330-5115c2e1991a"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5277), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32c49e2a-ccaf-4ab5-b04d-69b94865e81c"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5221), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("336fe6ca-f530-42b9-8858-478e8d6f2ad8"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5609), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33c45517-f685-481f-8385-cf9537d603c0"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5426), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33cae004-2669-43fe-bcd2-79ac496dd76e"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5083), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3507b8a0-6ae3-4c43-ba4c-df96e661cb0c"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5307), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3550f901-304f-452e-a364-a967d71f866c"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5702), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37642f2e-e7dd-469e-9968-6410c45fef36"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5138), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37f62c28-eba8-41a7-8909-02fcee8d755e"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5151), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3801d80f-e866-4a07-821a-9b64ca9f96d4"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5149), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bb463ff-6846-4ef0-8089-7495552558ca"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5568), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bfc828e-dd06-4747-8339-71a0780fc25c"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5359), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d3283bd-c0db-4277-9ffa-426868fdd336"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5650), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3dca6584-37e9-43fe-8cca-313d4d33735a"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5375), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("40b95bfa-d37c-4abb-b659-81b4eb5d509e"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5201), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42f5667f-40f2-4ba2-b3ba-db84ad51432b"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5179), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45e9e437-aeef-430b-b01c-7eb49d2d474d"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5490), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("485cbb74-0cf9-48c2-8942-ffcc6df33b84"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5203), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a485370-12af-48b6-a25c-fbb9f2e98199"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5325), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4aa51bcd-1d19-4cfd-b8bc-71d4cd9de456"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5142), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b18436a-91b8-4ad5-aa38-17c440d90c3a"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5237), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c4245aa-f038-45b6-b805-8faae95d38ed"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5218), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d12858c-d6a2-4065-b8b7-166eb4851186"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5369), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d9577e3-e9fb-4fda-84b2-5c94507bf07f"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5554), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e1ef3c7-d1d8-4a39-abce-62ad4470d6de"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5241), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e7f0b8a-9eb1-4bb5-a091-4098a7eeec65"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5608), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f57d2b6-93e5-4e05-8dae-633a8a29cca0"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5219), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f70cf28-74dc-4efe-9a82-affba0145f61"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5445), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50749211-445d-451e-ad0e-d0b4d9b21178"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5420), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("533c0e13-4afd-4a64-9c95-2532256f8c19"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5239), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54174a9c-ddb9-41ad-b116-c9089124a889"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5659), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54ad42fe-3ea7-484b-9461-756feb30612f"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5512), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54c59c19-c996-4607-bb56-440431fc3614"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5604), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54d4de50-e0d4-42f4-83a2-9bcee4d7e64e"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5443), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55c487ca-4764-412b-9d5f-4b4b4e280ed7"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5632), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55fe68d7-9d12-40ac-b56f-e3bd5681eb1d"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5190), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56076cab-cf6a-4d52-8d80-8633ca22278c"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5129), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("561adf9b-8d34-4c9b-af7b-0fea3b234b70"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5073), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5623fe01-d0fc-4ce0-a99a-a8bf592c2575"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5621), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("563eea87-83f5-468f-8780-3dcc193b28fc"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5486), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57dda088-89a5-4eb6-b0f7-25012e84c21d"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5473), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59a54af6-fb0c-4cf6-bb2d-54c74cbd1acd"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5519), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5afa71ff-be0a-48d9-98bb-4eb085ce53ce"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5361), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b43a76f-c3c5-487a-8d41-b8db02e61a40"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5389), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b907f82-5cac-4916-bab7-ce611ceaea8f"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5122), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ca98a29-5c54-488a-a3b1-1993f965e406"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5177), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e43692a-3f3c-45ee-8453-7307e4b5233d"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5310), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5f6264bc-3a28-4cba-a8f5-64ce5e71110d"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5646), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fb9e08e-4d09-446e-9db5-b8020c056716"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5666), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ffdd9b8-592e-49d9-8e60-23e6a7894f5b"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5265), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ffde248-4332-4daa-aef4-08520a86aa86"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5214), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61151d10-8714-4675-9022-4da2403205b6"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5664), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("619218af-326f-4444-b454-2ef8d66fd03d"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5076), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("635c2b45-fbfc-4af6-acf1-a8798c1ffb2e"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5380), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63b15098-a2f6-4e17-8558-dcbdc3aedcf5"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5327), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63c76300-05f5-4486-b5ea-929890b1d9e4"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5124), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63fab87a-0410-4475-ab37-b3d2d6e99ba1"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5545), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6474af24-def4-4816-9082-f63fa59a0f58"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5448), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6529c19e-1b76-4b11-80fe-fdb461aff151"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5186), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("665b71e6-ffe9-4ee1-9b3a-254412d02dac"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5261), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68b5b63c-aa89-41a6-b5c0-d1a54eb4c127"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5680), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69a058b3-1480-4092-bb3e-592aa743dcec"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5557), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69b91c26-adf8-4259-9862-c315bfd258a1"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5430), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69c5b685-7bd5-450b-a287-6fc82e62de60"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5577), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a1e167f-a7f9-4c14-b675-e8e425782cb5"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5691), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c14b451-8154-494f-bcfc-74a61d6c8961"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5454), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e60228c-a1c8-4ed1-9495-cb5c0af0bb5f"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5458), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6fb0d828-32db-4a32-bef0-efca3dc57a2a"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5606), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70f21253-f419-433e-822d-d4faa9f7ab60"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5661), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72a9d009-7dbb-46d1-8755-ac039e0722b4"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5173), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73920ce2-5a13-4227-a021-7f93b3c8b2c5"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5344), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7462252e-38db-4550-aeae-a8ad6a6147e4"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5436), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("74e3dbc5-1652-4a52-93ee-fb3531038f10"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5387), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7601d14d-ffff-4cab-9ce9-e4412e40ebe1"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5477), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76380a71-9d7f-445f-80ae-0e010bfa97df"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5654), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76ffa7f6-d3c4-4209-8572-adf79826b775"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5540), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7794f744-4b19-4f68-b901-c4666bd3e1cd"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5447), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7827afcc-0214-4f59-8c29-85862bae4d96"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5617), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a0a78b1-2c3f-4879-b9b7-8942b87b5d08"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5134), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a63b242-7cd4-49b7-a4fa-dbb621ae5554"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5284), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b201628-3b1d-44e0-87d8-dc395580c3ef"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5199), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b3140e4-847c-4b96-8b59-05503c4aedb8"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5600), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c571be7-10b6-47e8-bd7f-586191be2e2c"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5562), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f1e3b89-2275-40d7-bcd7-b8659c1801cd"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5480), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("801c2447-51da-46f5-80ef-c25b23925aa4"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5424), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("81cfb1a1-8817-45f6-951a-188f92c02aeb"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5136), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8288e1db-6be2-42e8-83a2-5b2e46d3a43c"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5648), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82ce60a5-c5f7-4c18-bd0a-b8b97823bd48"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5205), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("830ca5ec-c4b3-4872-8772-89fb7d7a7974"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5246), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84abdea9-0ca0-4488-9d51-c3afae7b7ddb"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5078), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8537473e-92dd-4225-9738-b5cbe95338c5"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5250), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8642c355-aa27-467f-a6a6-29f0debddcb6"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5587), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87ba4645-509d-416b-a11b-d69d146f221c"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5400), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88d1d32c-a49d-45d2-8d89-29830b80f72e"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5441), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8906d095-0a94-4e96-9401-295018345fbf"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5195), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8948a8f3-fc72-4179-a042-682dd1e24e84"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5471), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b1f9821-236f-47b2-b1dd-03b13eeabba9"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5248), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ba8c41e-8af2-4feb-bcfb-e15b17a8cc77"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5575), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c7fc0b1-ae47-4b5a-9b4f-7f9322f7f054"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5342), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8cac18e6-8ec9-42f1-a3a2-6a2a45adb906"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5677), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d82fef4-ffa2-40f9-a80a-36c25a273bdf"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5087), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8dbe9949-8713-4a48-afce-984e75ea1569"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5385), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8fad716d-71a5-4053-88dd-01b0bd50dfad"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5155), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9281f190-cbeb-4b13-86d4-bf3889b5e227"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5657), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92991976-01d8-49f9-a10e-46cd4d8952a7"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5494), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93d7297d-fc89-4afa-971c-d994637d59cc"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5188), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94ec5102-85e7-4901-9d27-4469b0dd91ed"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5543), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95148df5-4921-4d43-8f6a-b09a976a20cf"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5402), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95aebd1a-bc51-4552-a77d-e97d5b2476c4"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5613), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95bdfb7e-b107-4b98-a9c6-3b7a9ff1d48b"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5668), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9744013c-186a-4976-8902-6437da0ef21d"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5508), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97f05113-7c37-45ab-aed4-1f70715fd670"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5510), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("98099f33-5a1e-4c39-809d-dea3d907c696"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5089), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b4f3b60-e4eb-4360-8fb7-37934eb992cb"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5279), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c2db257-9848-4501-8d60-336bef00bca5"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5549), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e620a9f-88d9-4099-a5a4-6d9b857967e6"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5559), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f5037ec-fc8a-4d4a-8f12-a6e3e9069ba0"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5482), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0ce0e21-0048-4861-bbda-a2e2634c01ef"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5547), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a19a3406-e126-4bae-8f9b-654d50836148"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5573), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a276650a-c0b7-49af-ae25-a4897f00ce01"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5184), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a513b0f7-a5e2-4889-b3e4-2959a2fbe661"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5384), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7febe07-3d73-4259-a3e8-39ea5ba8fceb"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5259), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a89245c0-21d4-4297-a32d-169aa1ad1eed"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5416), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9f2f40e-7a33-4f03-9de7-97a345bee9a7"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5263), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab440972-83d6-4acf-afe9-85c2932919de"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5080), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab809ceb-b03b-4e4a-8024-f534b8627c0b"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5438), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae47e6ce-1bc5-43ca-9d95-6d77e09dc3a4"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5171), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af70ae20-8c97-4705-9c6d-1092e46bb6b5"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5623), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1337f27-d712-442c-b494-f5130f9ca02d"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5367), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b19bd3a1-2c5c-4432-88f4-0862037dfed6"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5551), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b44d1936-094e-4ebb-b8c2-bad2caa8d9c3"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5566), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4aaecb6-e5dc-419c-9025-d0783a21f597"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5244), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5785ecc-e452-48ea-9fc5-3c42d88eb218"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5098), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5c61897-59ab-449b-801b-0f8833d2d7f9"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5312), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b6d1ecbb-a4be-4695-aacc-c3b2a7aef336"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5114), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba1158ff-ca34-4b44-b057-da5bb9ef2329"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5634), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bb026e55-a744-4b59-8655-ab9daa5967e7"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5395), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcaaa210-014e-4025-b8be-91b93c265ad0"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5571), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bfb82941-1fdb-46c1-9cae-ef4792191e87"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5625), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bfcc2dd2-e596-461a-9925-57e075ae39ce"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5671), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c00dbbc5-bfd2-47ed-afc7-2639a932ec5f"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5541), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1c9e848-67a5-4403-8d56-db1d511e8918"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5132), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c239ff06-75c3-44a2-a789-8166d11fdd06"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5432), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c33aed8f-0653-476c-82b0-cbee276247dd"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5363), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3dd5ccc-2273-4e48-ba9d-3fcf82bb9d1d"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5515), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c44f2fa9-060d-4b49-b480-722daa8b31b2"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5110), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c55f16db-2ad2-4228-91cf-fae8807ef2ff"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5301), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7a5f6f3-be45-4935-808a-44f31e9bcbfc"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5378), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8c3b521-a111-41de-b2f0-492a7209d464"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5528), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9546104-e27c-4ef5-95f3-ebdece7c679d"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5350), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9edb25c-bb44-4b1f-935d-ca71514ac5a1"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5689), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb1c50e4-00a0-438d-aa35-8ab2445f9c80"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5428), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb1dfd71-bd39-4431-8234-65d83c1ed39d"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5593), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb4a0b5e-d48f-42d3-8d66-36415940cb03"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5118), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ccf9517d-833d-4fa5-b39d-f14259a544a5"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5120), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cdc512b4-6425-45b8-93ef-71f7a172ccb5"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5534), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ceb88a0e-1c53-469f-b81c-3a1d635ed14c"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5591), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cecd85a7-70b2-4cb2-a47b-7fa7815d5d39"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5560), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfd782f3-9ce1-4533-8b34-f1dc2e8e396c"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5589), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d00510a3-a1cb-4110-b676-c52cb3ba94d1"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5271), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d01d2180-c1a1-4519-8e10-883722017c3e"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5683), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d029aaab-3038-47f3-9a87-8b78fe8867d6"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5642), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d1ee1ceb-d3f3-4950-8276-1e89a75fe40b"), "I", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5144), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3bb1907-bc3d-4fa4-bf55-a6bb3dc19f1f"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5644), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3f24594-8e39-4cef-a5c5-be1e008c0bde"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5140), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4d3c4f8-315f-4749-ad1e-c7e044fa1041"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5323), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d52d3bb0-8114-4dff-87d3-27f6b3905ac5"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5335), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d572b2d2-8d65-4f86-939b-e91da1e52a5a"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5656), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d70dc454-23dc-49bd-9fed-7eacb5a328e9"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5293), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7767682-1942-4e83-9ef4-bb00324f6e15"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5627), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8e04544-01d6-4f8a-976b-c95a9f553a3c"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5418), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d99ab4a3-52c6-4ab6-9947-90856da76537"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5299), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("daf7f1ae-f96c-4091-8741-62ce9d7619e2"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5256), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db4887ff-5ddc-4056-aed2-f035b20a59fc"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5412), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db72f00d-26ff-421d-ab84-46bc0bba8db2"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5193), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd03e279-6f87-47ea-9f7d-cdeebb075fb4"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5475), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de878ceb-277e-472e-89a8-6388141d26b1"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5108), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df370427-2ff3-48a5-942d-9a26fb95ab35"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5348), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df63d8cb-3882-4b71-8794-47978d86edb3"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5615), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2323cf5-8523-42d8-a81a-69599a67ab6e"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5233), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e26ec00e-0845-4e8d-a54c-09fe71e589a7"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5291), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e48f9fe1-f97d-4861-ab16-cb665dab35b8"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5564), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e52fb0c4-fd27-45e6-9766-05608cf9a214"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5181), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5c22842-af52-405f-8d4f-825de8c86945"), "G", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5269), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6045d72-dd8b-403e-baf2-bba6265621f0"), "B", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5183), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e69a14d6-f7f0-4c9e-8036-95e4993ac0eb"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5517), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6e08de8-318c-4cda-b61a-0d5e934847fd"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5532), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e7186871-4886-4f29-80e8-2558e9b21def"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5488), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e81cc4f9-2a12-4476-a4db-e5e826c93c49"), "D", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5393), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9b3eb43-4490-48ec-ab5d-f8cc9039e3e9"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5116), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea1c9e26-9be4-4274-970e-6d28354515b5"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5169), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eb8da347-d892-45f1-b7f4-599a646a3fbf"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5467), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec708872-d9be-49b6-abdc-35281f507284"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5630), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed64669d-12b1-4d10-8f90-ca18a69a4996"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5145), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eeb5e885-ef7d-461e-8680-336a1ae2fe24"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5253), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f11615dd-a47f-4910-8319-9ecab9688f2b"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5096), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2565aa8-4df1-4a93-90e6-a857d5637cda"), "C", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5153), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2ef4285-c9db-4328-9c67-c4a49973d2f6"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5450), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f426af3c-30b4-48e0-847c-4142b95105ba"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5267), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5f2505d-d302-4be8-afc5-090137005c96"), "A", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5506), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f6ada627-10e0-43bd-8fc6-d7afe8baf506"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5296), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb4bd68b-5c20-43d5-893d-61106ea77a72"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5216), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd3000d8-7cf0-4f5b-8ecb-409f9a90eb27"), "E", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5157), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe43460b-bde4-4af8-a44a-001794ed85ee"), "H", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5500), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffadff8a-01ab-4e30-bd42-864ab08afd1d"), "J", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5704), false, null, null, null, null, new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffdb116c-3db0-4643-b41c-1cd8aa3bbf38"), "F", null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(5212), false, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("9ec7b8bd-dc1b-41e3-8b97-3580fafd2709"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(6051), new DateTime(2025, 1, 7, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6056), false, null, null, null, null, new Guid("d28e36c9-e070-4410-bba1-88593349ba97"), new Guid("6f1c36f9-973e-43c0-8056-40b6dd86d539"), 1, new DateTime(2025, 1, 5, 20, 55, 33, 292, DateTimeKind.Local).AddTicks(6053) },
                    { new Guid("a3e94850-c772-4906-bd12-aa9064aa64f6"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(6037), new DateTime(2025, 1, 6, 20, 53, 33, 292, DateTimeKind.Local).AddTicks(6046), false, null, null, null, null, new Guid("e7122e9f-9ff7-407d-aa51-1cdaaf401f97"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2025, 1, 5, 20, 54, 33, 292, DateTimeKind.Local).AddTicks(6040) }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("19a24f67-7f2c-4e54-8d23-0eb984ae82be"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(6183), false, null, null, null, null, 60000m, new Guid("13cc9cf8-d4cf-43ee-a46d-fc0473a7c389"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("4a2eacc3-392a-4f51-b3ff-71ae007ee8ec"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("786414a9-698d-424d-88da-4097e7f8dfa0"), null, new DateTime(2025, 1, 5, 13, 53, 33, 292, DateTimeKind.Utc).AddTicks(6177), false, null, null, null, null, 50000m, new Guid("8401f921-4afa-4370-87af-b519c1ba921f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("26002850-6382-47a4-b54c-afb3cbbded63"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
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
