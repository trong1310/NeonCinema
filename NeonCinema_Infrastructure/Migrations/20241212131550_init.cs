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
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
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
                name: "PaymentMethod",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    QRCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_PaymentMethod", x => x.ID);
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
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StarTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeAllowed = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LenguageID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectorID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    DateOrBriht = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "CategoryMovies",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovieTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_CategoryMovies", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CategoryMovies_MovieType_MovieTypeID",
                        column: x => x.MovieTypeID,
                        principalTable: "MovieType",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CategoryMovies_Movies_MovieID",
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    BillCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Bill_PaymentMethod_PaymentMethodID",
                        column: x => x.PaymentMethodID,
                        principalTable: "PaymentMethod",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Bill_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Point",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalPoint = table.Column<int>(type: "int", fixedLength: true, nullable: false, defaultValue: 0),
                    DateEarned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Point", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Point_Users_UserID",
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
                name: "WorkShift",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeStar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkShift", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WorkShift_Users_UserID",
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
                name: "ShiftChange",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShiftName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    NewShift = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    RequetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    WorkShiftID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftChange", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShiftChange_WorkShift_WorkShiftID",
                        column: x => x.WorkShiftID,
                        principalTable: "WorkShift",
                        principalColumn: "ID");
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
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                name: "BillTicket",
                columns: table => new
                {
                    BillId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TicketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: true),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillTicket", x => new { x.BillId, x.TicketId });
                    table.ForeignKey(
                        name: "FK_BillTicket_Bill_BillId",
                        column: x => x.BillId,
                        principalTable: "Bill",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BillTicket_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
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
                    { new Guid("352f7313-d541-4d31-9b44-4831f0776e51"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("23e5b1ce-5140-4668-ad7e-bf82c47f766d"), null, "mua tại quầy" },
                    { new Guid("d382e186-2556-4de0-9975-8bb646e815f2"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("97e33c1c-53fc-4e6a-a0b1-3376f4093876"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("24b756ec-6343-4c59-badf-362747d528bb"), "11:00 PM", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4275), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4271), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1889d446-8628-491a-8b29-066d89434bab"), "Pháp" },
                    { new Guid("558a4808-807e-4ed7-8c72-b12b280b5628"), "Việt Nam" },
                    { new Guid("614f5f0e-f194-4528-a5a3-243fa2e2bd8f"), "Hồng Kông" },
                    { new Guid("6db5a7af-f98e-4614-badf-afa19656a053"), "Mỹ" },
                    { new Guid("73a9529c-b12d-4cc3-8eac-38c85b5ea437"), "Vương Quốc Anh" },
                    { new Guid("8a417891-810f-45d7-a410-b08ee09b1621"), "Ấn Độ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("a321833d-b3c9-47bc-93b2-72c5dcbf832f"), "Hàn Quốc" },
                    { new Guid("cec87460-6ea9-4271-9328-6c2976da18c2"), "Trung Quốc" },
                    { new Guid("dc6d6cea-2ddb-443a-bcd7-39aabf893c02"), "Úc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("17ab49fb-84aa-4999-b461-a01931a4bf1b"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("1eb296b7-89f2-491d-a737-538820d3a9de"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("2f74a07b-2f51-4808-b350-f33425e84a22"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("60efe940-1f5b-496a-ae20-8c16e2980c1b"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("61187500-9737-48f4-b5d0-915fcaeaaa21"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("674221f3-9347-4156-91dc-0c22f5d59ad0"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("71bba996-5787-414e-826b-58c85560e0f4"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("df62e6a1-4200-4878-893b-44078dd3f613"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f2804469-b1a9-42ab-b582-61210d24c660"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("2710ac23-36ac-449b-8fa8-28b344af517e"), "Combo 2", null, new DateTime(2024, 12, 11, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5246), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("3ab81ce7-8ac4-4826-b57f-b5ae756a7c36"), "Combo 4", null, new DateTime(2024, 12, 9, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5252), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m },
                    { new Guid("6a58ef37-f303-428a-b309-64f0472293c0"), "Combo 1", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5242), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("f46417de-b2e3-48dd-91c2-322633bbaf12"), "Combo 3", null, new DateTime(2024, 12, 10, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5249), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0768595f-063d-47c9-89fb-58769dee4dd6"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("10fa8f87-2958-483d-9240-620d67764b5a"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("67f1d424-81a0-4393-8e96-c16930148b69"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("8c441bb3-2738-4ec5-80e1-d026c1d647f0"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("972afd1e-e0cd-4cd4-b0d5-68e1441a7dec"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("9855291f-7470-4f7c-a662-b04b27fdcc1e"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("b43997c1-50cd-4324-ae25-8cbddd579797"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("b4c7194a-778f-4664-a9c7-e8450cdb0f03"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("e9fc2a9e-5b07-4992-8681-500753738a64"), null, null, null, null, null, "Lãng mạn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("21ea0cf6-3405-42d0-b355-d30302a8e20d"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("2f64fa19-cc8a-4802-ad9d-84597ddda3c8"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("4c872381-bbfa-4729-bfb2-334d9f688607"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("a7411e37-d4fa-4144-b680-8a4ef706ff2b"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("bea2a961-1932-4cf6-bcb9-16f4e110c0aa"), null, null, null, null, null, "Korea", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("15e12ebc-edb5-4f6c-bac0-374334d800f9"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("7b925de9-b66e-4ff2-a444-76a60050a857"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3242), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3267), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3265), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("18045597-f862-4c0d-ad83-6d20c9dedcfd"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4251), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("82e89da5-0736-42ec-aa3b-a9ff41b64c56"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4250), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4247), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("02b3548e-c45f-40ca-b29f-299d7fbef6e4"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("1cab16c5-e3eb-48da-974e-80ea7ea60459"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("2ed22b61-c22c-4d68-a5cd-0be64424817f"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("42ac2e65-d487-4f63-91db-f6a76af1103d"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("664e706d-213b-48cb-a6ca-5179b6e7a64c"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("7741ea44-1366-43a3-9f5b-571c1d2fc950"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("be931950-0631-4c42-8dc4-abde7fcc3f01"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("bf315f63-9434-4acb-8f25-8c5ab19b97a2"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("ef31af51-5c32-41e4-9e87-1f88a332fcd9"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("f99da7fe-60d8-4505-b900-2877b9556fa7"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, null, null, null, null, null, null, 60000m, 70000m, 50000m, 60000m, 30000m, 40000m, 50000m, 50000m, 30000m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("0ae3a568-598d-4531-b961-388636446ea3"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4905), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("df62e6a1-4200-4878-893b-44078dd3f613"), 110, new Guid("0768595f-063d-47c9-89fb-58769dee4dd6"), "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4890), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "0e9f825c-5346-44f1-a94d-7078909ce83a.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("1297ca46-4ed2-422d-b13c-37aa56d50fa3"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5003), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("17ab49fb-84aa-4999-b461-a01931a4bf1b"), 150, new Guid("b43997c1-50cd-4324-ae25-8cbddd579797"), "5b626704-f3d1-482f-b77c-903284966efa.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("2b6dccb3-4694-459d-a2a9-965d5241ac9d"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4898), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("17ab49fb-84aa-4999-b461-a01931a4bf1b"), 120, new Guid("b43997c1-50cd-4324-ae25-8cbddd579797"), "161cd6ca-380d-4627-8071-2d5af03a1cf2.png", new Guid("2f64fa19-cc8a-4802-ad9d-84597ddda3c8"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("46bb4e45-1180-47a3-9fb6-92653b0375e5"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4919), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("f2804469-b1a9-42ab-b582-61210d24c660"), 125, new Guid("b4c7194a-778f-4664-a9c7-e8450cdb0f03"), "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("4a091ad2-35b5-4985-a9f1-7f04dd5a23df"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5016), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("71bba996-5787-414e-826b-58c85560e0f4"), 145, new Guid("67f1d424-81a0-4393-8e96-c16930148b69"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("4b8fa74e-8deb-4073-947b-25921782cf7e"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4925), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("60b33cd9-e275-4734-8ec3-40e2efdf15f6"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5022), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("f2804469-b1a9-42ab-b582-61210d24c660"), 100, new Guid("b4c7194a-778f-4664-a9c7-e8450cdb0f03"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("620e64b1-7de0-4f01-bd27-0a29b183fb67"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5010), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("df62e6a1-4200-4878-893b-44078dd3f613"), 130, new Guid("0768595f-063d-47c9-89fb-58769dee4dd6"), "7502d22a-c967-400c-bc8c-3062d00c7fcc.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("8369f439-8739-41c3-aab7-6444b3e89ea2"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4910), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("71bba996-5787-414e-826b-58c85560e0f4"), 140, new Guid("67f1d424-81a0-4393-8e96-c16930148b69"), "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4299), null, null, null, null, null, "Room 1", 0, 100, 1 },
                    { new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4303), null, null, null, null, null, "Room 2", 0, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("02ff5cda-020b-41b0-b4fe-3e5e26ffb2f6"), "Nghệ An", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3900), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("12756bb9-dcf7-4747-87ff-510c4e049ab0"), "Nam Định", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3995), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1d444bf4-122b-4a2f-b6cb-1c863fc8e7ae"), "Đà Nẵng", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3834), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("57af0c2d-deef-49b7-942c-547fc0b68078"), "Hà Nội", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3408), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5a13504e-cce4-4f25-bbc3-62c65c2885a6"), "Hưng Yên", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3972), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("637c2b51-73ec-43c2-8792-6298fc568ee2"), "Quảng Ninh", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(4019), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("677eb1dd-a966-479f-aa26-02ebbb6ede81"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3876), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6862d8dc-d801-40c6-a6dc-bf6b893e7f7a"), "Hải Phòng", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3808), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8cfa2e3a-79cd-4123-bc4d-c242fc99a172"), "Hà Nội", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3777), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f0ea6645-7166-4514-9c43-cfad9f3c0290"), "Thái Bình", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3953), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f6d710f6-6794-4e3b-a9dd-13c6b8a83082"), "Bắc Ninh", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(3921), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("0850d9ad-27d0-4948-aea2-8f35452c31b8"), "BILL007", null, new DateTime(2024, 12, 7, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5326), null, null, null, null, null, null, 1, 800000m, new Guid("f6d710f6-6794-4e3b-a9dd-13c6b8a83082") },
                    { new Guid("0f56a8ea-afc1-4565-b65f-e5bcd3201446"), "BILL004", null, new DateTime(2024, 12, 10, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5313), null, null, null, null, null, null, 2, 200000m, new Guid("1d444bf4-122b-4a2f-b6cb-1c863fc8e7ae") },
                    { new Guid("112cecff-a9e8-497d-adee-a64c8f48b591"), "BILL006", null, new DateTime(2024, 12, 8, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5321), null, null, null, null, null, null, 2, 600000m, new Guid("02ff5cda-020b-41b0-b4fe-3e5e26ffb2f6") },
                    { new Guid("1919da4e-de11-40a8-9dc4-fe56919c37d6"), "BILL010", null, new DateTime(2024, 12, 6, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5339), null, null, null, null, null, null, 2, 700000m, new Guid("12756bb9-dcf7-4747-87ff-510c4e049ab0") },
                    { new Guid("59d08dea-dc45-4df4-919e-5585243b3034"), "BILL008", null, new DateTime(2024, 12, 2, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5328), null, null, null, null, null, null, 2, 450000m, new Guid("f0ea6645-7166-4514-9c43-cfad9f3c0290") },
                    { new Guid("8ca936fc-38ef-43de-8abc-e22f90eeb028"), "BILL005", null, new DateTime(2024, 12, 9, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5317), null, null, null, null, null, null, 2, 250000m, new Guid("677eb1dd-a966-479f-aa26-02ebbb6ede81") },
                    { new Guid("9f88a78a-3e02-4745-808e-7d68d20f0abc"), "BILL001", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5305), null, null, null, null, null, null, 2, 500000m, new Guid("57af0c2d-deef-49b7-942c-547fc0b68078") },
                    { new Guid("a42e65e3-d770-446c-8586-cdd9fdf49e48"), "BILL002", null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5309), null, null, null, null, null, null, 2, 300000m, new Guid("8cfa2e3a-79cd-4123-bc4d-c242fc99a172") },
                    { new Guid("aca8c410-852f-4a05-bbe6-e8fdbb0f86f1"), "BILL0122", null, new DateTime(2024, 12, 8, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5324), null, null, null, null, null, null, 2, 680000m, new Guid("02ff5cda-020b-41b0-b4fe-3e5e26ffb2f6") },
                    { new Guid("b4657a1c-4d6e-4403-a836-b893296dc6cd"), "BILL009", null, new DateTime(2024, 12, 4, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5337), null, null, null, null, null, null, 0, 350000m, new Guid("5a13504e-cce4-4f25-bbc3-62c65c2885a6") },
                    { new Guid("cf166114-9766-4676-ba68-a534f8caedca"), "BILL003", null, new DateTime(2024, 12, 11, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5311), null, null, null, null, null, null, 3, 150000m, new Guid("6862d8dc-d801-40c6-a6dc-bf6b893e7f7a") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("9f21c4e4-ccc7-4f42-be4f-e7b83ec8b1a7"), null, null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5435), null, null, null, null, null, 150, new Guid("8cfa2e3a-79cd-4123-bc4d-c242fc99a172") },
                    { new Guid("c384d47e-c77f-4f85-997b-b4d11a1802e8"), null, null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5431), null, null, null, null, null, 50, new Guid("57af0c2d-deef-49b7-942c-547fc0b68078") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("c7759833-9d00-413d-9d4b-c218ee5a56a3"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5412), 1, new Guid("57af0c2d-deef-49b7-942c-547fc0b68078") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("1ee7e0e3-54b1-428c-9092-792bf010e4cd"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5096), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 20, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5095), new Guid("be931950-0631-4c42-8dc4-abde7fcc3f01"), null, 0 },
                    { new Guid("74e96e10-0005-468b-a9bd-fed9222093ed"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5088), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 22, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5087), new Guid("7741ea44-1366-43a3-9f5b-571c1d2fc950"), null, 0 },
                    { new Guid("74feffd0-8fa9-423f-b3c2-ce14dba6b509"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5093), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 21, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5092), new Guid("42ac2e65-d487-4f63-91db-f6a76af1103d"), null, 0 },
                    { new Guid("99ca10dc-85a1-4863-bd6a-cacc6b2ea805"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5102), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 18, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5101), new Guid("bf315f63-9434-4acb-8f25-8c5ab19b97a2"), null, 0 },
                    { new Guid("9bfedb50-1b70-4f5a-b7ec-4564f32ece16"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5099), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 19, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5098), new Guid("02b3548e-c45f-40ca-b29f-299d7fbef6e4"), null, 0 },
                    { new Guid("a40d03e1-92b5-46be-84b0-a5cbab07cdbb"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5108), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 16, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5107), new Guid("2ed22b61-c22c-4d68-a5cd-0be64424817f"), null, 0 },
                    { new Guid("e7386111-b678-428e-a70b-ae31fade168b"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5105), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 17, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5104), new Guid("1cab16c5-e3eb-48da-974e-80ea7ea60459"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0025b6fe-da0a-4a8c-b8df-56fad07e45b4"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("00b46c23-4a9f-44ae-a0f0-48cc0093c095"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("01efbb07-6126-4345-bb3c-c95768afbd1f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("032d2032-5aa6-45fe-8395-2a3630388a5d"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("03e45823-1322-4467-94db-8b81212df180"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("062a5dad-0256-4bdf-ae7a-2ab96153092c"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("064899aa-8020-4624-bf85-2ef736d50eac"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("06cbb416-8816-4ca0-9603-9b28071bc4ae"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("06eb60ef-262b-4674-a466-bc93cd53a6cf"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("087a64b6-68c8-42d9-89c3-edc6a46f74cd"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("091cd020-db43-44fe-9ab5-7d8037a79ce3"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("09aead39-2524-46c8-9014-aa7fdb6a12bb"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0d5f1f1b-14e7-46ca-b32d-81120f5a0c25"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0e335351-3bc6-4c80-9915-c0b7d771a7c0"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0f94e769-8c1a-4591-815d-9cd408cff747"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("100970a2-f23f-4df7-8ce0-ab6a68b4cf76"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("11919535-bcee-4e7a-838b-84025615a92f"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("11cfe682-738a-4ebd-abbb-fe017793180d"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("129fc864-b4b9-4bcf-9f07-9c42266bfb68"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("12dbdd1d-280f-4efe-9e9f-39f1606a373c"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("140c8cd5-f487-4be4-bc67-f44d8d9023d9"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("14e367df-c5b0-42cb-8fc3-a9060229fe13"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("15d58dd0-608b-4776-949a-6f0a1376bd1e"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("16727431-a98f-40e8-8556-2436d844bb57"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("16b1972f-53a5-44b5-85b8-7b97a4df98cc"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("16e7a54e-6fc2-4b1e-8784-3ea93d83c9a7"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1c83340c-8172-4c18-9326-793eea36037d"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1cc77cb2-b081-449f-a889-714244d5b4b7"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1d41ecf3-861c-4c75-972a-cdf1fdbfbe72"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1d444337-ff4a-4d01-82e6-418fc96bc314"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1d7d4519-98b5-46f6-bf9a-c6244ebc9eb4"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1e2d4521-1b3a-4fea-86d3-d4ed0fbab07f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1e8a7c5d-c623-4e51-88fc-7b610e7d1151"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1eec846e-1e1e-4f8e-9fea-42fa3e7f9dbb"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2077a7cc-e5ec-46d0-87e7-4d61095a80cb"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("209ef632-d87f-415b-9bee-307b3d266c6f"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("21115d86-b779-46d5-a7ce-bd1e45cf5986"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("23528efc-a4d8-4d66-99c4-ff6e3818adfa"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2461887e-79d2-4fbd-80f9-5063c135de4b"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2461d7ae-767b-4fda-ac7d-db23f4e9b2aa"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("275a1963-9903-42a5-a9a2-5b2aa2cbe878"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("275b7cee-e65c-4d1d-8277-d9ecaea60f8f"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2784abf8-90eb-43d2-99bf-f6f5e2f51fb6"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("28dbcf3d-cea6-41a3-8ac8-39b5ba0d2be3"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2917c8e6-14e4-4f09-ae61-a521361d09ee"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2b572ea7-7f76-4ba3-abb7-0d1f657fc77a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2c345765-ad79-4630-8639-65979af37f0a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2c4063c2-5605-4642-87bf-e266f98f1fd2"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2d3e0eef-16d0-485c-87d5-58490ffd43b4"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2def41e1-6177-47a6-818e-6c3a5a197409"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2e45426e-cea1-477e-95ef-9230cb15976c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2f9a29c6-acbf-4a2f-ad26-e8b3845be87a"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("307c994e-2dc6-4c22-8465-ebffdef714ff"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("31255efd-7b60-40c5-ac69-a6df8241f834"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("31b00361-31fa-44bb-ac39-1539526f0207"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("32bf6cbd-01a7-40db-a09e-4dfed3213005"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("335dd054-f0be-4032-8b9d-8eee9917933f"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("339f7491-c88e-44b3-99f4-48b661fa19b2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("344b832e-4e32-445e-8065-e5f8941a346a"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("35e35553-eb7a-451b-ac81-f85a476695ea"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("35e5b4db-dcda-4d1a-aabd-2a6c763ae1e6"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3603f38d-ac1b-4b2d-92f6-a26b23ec191c"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("378cbae2-8b51-4868-8f90-c31d00f2428d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("37edabc0-3c67-4da2-b7c7-fe2c6af7dbf7"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("390e0ad5-98e6-4eae-9374-4188d9c3db4c"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("39b6263d-7fbc-4d30-981e-dbcbf3740f9a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3d18c8bc-eb18-4706-9182-f6fccece527b"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3d1a1911-cdd2-4c43-858c-9a729b79e3a2"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3e8bfaf4-d6b3-4b93-8064-d433d32b2442"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3ecf66de-abe3-4ff6-85d9-85ba63cdaf02"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3fcf9dae-af8c-4cc6-b5be-d8467b8a8be1"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("412762ef-67fa-4731-9944-51825947301b"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("41b68642-670f-47c1-a748-697d88f00d0d"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("41bebe5e-a43f-4a3c-b541-7ef6fd771ad0"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4219f460-b74e-483a-9fa3-118aa8252be5"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4321fd94-1457-4a01-b9ab-d5ae15bed0c6"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("43fd44f1-9785-4b87-8f90-b881ec6d4651"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("447020ca-2168-41c9-9eb2-1dab2b33bb12"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4515fba0-a31a-4380-ab1a-31540b6afe77"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("458ce89b-13ab-490c-baf5-1b94dc18767e"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("49e4a214-67b4-4bd0-b459-52a06cd57ef0"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4a4d3c06-cb58-41c3-87c1-8e0b1c1ce72d"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4a916863-6e18-4823-a790-36d522166726"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4ae00091-6611-4cb1-a140-95838ae59d57"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c1841de-bc6c-4f3f-871a-af7f3b826cea"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4cbdc767-7a97-485c-9b7b-b9ffb73d4208"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4d103798-6c6c-43fb-ac3e-eac2b299eb1c"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4e15803a-a58f-45d0-9759-159e0ea3062e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4f586f26-34bc-4c2c-8351-7ca71fe4bfbf"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("501cae7a-a112-47e9-996c-de4ec4f1c02a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5081ed5f-5417-4959-8b1c-ab5ab61f20ab"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("50ff9ea3-f3d7-461c-bfd6-fd6bd4f339d4"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("51e8b5ec-b5d6-4592-b845-c6ebf1cb34d3"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("54428903-d265-440e-b5e6-6fcf22f70939"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("54aa3c7c-8c77-45ea-8c65-58f04b17a3e7"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("556b6f53-097a-4d1d-9679-b8691ed50ea2"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5651446a-13fb-4bf9-97c9-f7d2916edb7d"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("56d788af-79aa-4602-80d6-00e93e90bc11"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("56dbedf3-512c-476c-8b61-28a9acb73adf"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("58203f1f-21cd-4e5f-9cb4-f35570eafcff"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5910cddf-19bf-4fd9-872e-e0d8628f682c"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5919db3d-41b5-46cb-959d-e61d55c0635b"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5a40d260-26a1-4763-9be3-48b47f16cf3a"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5c77d82d-9022-433a-94b6-1f7889129e55"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5e54efb6-029c-4a4f-ac73-16a6bb409f07"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("60d3445a-14fd-49bd-a66a-2e3e8bf94785"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("63af550e-e45e-41c7-bc90-b62a5cde71f9"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6406d1a0-a18a-4eea-b5d2-b05c0011e8a1"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("648907fb-f660-4ed3-9fb3-665ae8cdc61a"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65015211-5e44-4141-ba38-e886a852ec92"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65501e85-37d8-4e26-9c92-a0769b8efce7"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65bedb7f-9f0b-4a07-af27-f6596ef76e85"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65dc79cb-d94f-4a7b-9f62-ae2ba1690f60"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65dd4e18-4255-4470-a5f4-380ada7e162f"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6674a427-d3b6-4452-b061-df6977e61be6"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("681e12fa-e669-441b-8de7-d96a7979131d"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("686c2977-0807-4c0d-9a52-c4b3e661e0b4"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("692a420e-0938-4de4-a9a1-39c8d19e81e7"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6a0df8ba-8b8f-449b-90ae-ace8e59a5144"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6b42f08d-e8a5-49b9-9523-7b361b2d92d7"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6cf15489-c424-4ac6-8c2c-a2a9230058fd"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6dc84aa4-9e3d-45bd-ba77-a65b44c79f42"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("70c7cd43-52c3-45f1-b00f-a9c1f035d606"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7414b74a-2968-4402-8bc3-233f2cffcd06"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("744780f7-5332-46fe-ba25-f1b885e3da4e"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("75190c92-9100-46a4-962b-a6f2c8b091d9"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("75b40baf-e93a-4312-98e9-440ec6b2adf4"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("75b98273-e26d-4430-a5bf-2a9e3369ae84"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7779c2c6-1757-4989-9918-3e8b0cfc2e1b"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("797dc24e-4bd0-4829-9781-0c8be3017f95"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7bbe64fe-a545-48fa-b2ce-d14f07d3473f"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7bd0a7ba-0d5e-43ee-bded-571607f655d2"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7d60fd98-38c0-495b-9ab4-d770c396a129"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7e083af2-da3a-4666-b6be-a9f1a3528345"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7f32fae5-1770-42ce-8617-cb547ba924da"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("83e64c6d-3839-490b-8f47-c7339d52e672"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("84a184e2-b311-49db-952d-a47203b6192b"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("85dda60c-0e42-45dc-8e9b-112dba5b20b5"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8a3be138-38e8-446a-b1a8-21467a09cb3e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8ad5ef0c-24d9-41de-9b90-25a90c51c235"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8b018ff5-6aa5-4ca7-bdb1-da9eea4fcfbd"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8b7fe7cc-3157-4ae6-9b47-f25baabe4b12"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8bdea498-ed29-40c4-a2bc-60eac5c55db2"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8dd66121-e5a3-4e77-8e30-b24aa768c7e6"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8efd6a6e-21d2-4b5f-9c06-960c4562fcf2"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8f702053-1397-41bf-af04-fa8fdc4f8730"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8f8b7d8e-77b5-4d84-aa3e-07ff150f8ead"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("90902119-57d2-43f0-a69a-5a0acccf4695"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("90b3c2e1-1337-4331-94c6-7b292f64a523"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("91d36b58-8752-436b-976f-d4837dc52183"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("92359718-4cfd-49b8-ae73-c34058ea8929"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("92a1fde9-6521-4dd4-9c5c-4c2e1bdc5a76"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("94c0ac92-ca3a-41a5-b3a4-314a215afd19"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("95754058-11fb-4e84-9b45-a7d1cf78fd0b"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9736f8c6-248a-4c98-871b-d53922aa461f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9754fefa-8036-4584-96a3-96cd5c29292e"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("97a15343-a55c-4483-92d1-b9017b2b3cb8"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9ae2b8e5-6fa5-46f7-8341-43d9a79d5312"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9c8854ca-983a-4963-b35e-d34994ff9349"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9cc7bfb0-f344-47ee-a17b-d1c9df7e742e"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9d174625-47fa-4c6b-8525-0dc2acf2f3da"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9dc66dc1-7d48-4f39-90ca-941b876400ca"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9ea30c75-6c11-4b77-8928-8be2ae7fe968"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a136520f-eefe-4b37-a130-d6a801959ae1"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a18caa0a-6f39-4335-928d-e80d10d94644"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a19be51a-f105-482b-95db-f1d85e29efa1"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a207c89a-2331-42f2-958e-cbc44b7ebf53"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a2799fe5-f05f-46ac-8452-4b548ce01446"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a2e91995-c36d-4b5a-ad04-51a39aa5c8c3"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a3ed4419-e248-4a33-9b09-527485019e54"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a64da915-904b-4f0d-bd6e-d06b8e6fec1b"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a6635c0e-ce57-4d30-9b12-e32f9bb0d44e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a9127c94-7594-4a4a-947c-86006d691bae"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a9a4db68-7c84-412b-b5aa-4f07bcfe1d75"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("aaea1b16-8df2-4071-8ca2-86af1f2c63ee"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ac99d227-f1c4-40ae-b34a-06a085428d97"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ace669cf-2b4d-4bb3-ba21-a97cda030767"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ad60033e-a922-4186-bf8f-83c444f0f5ee"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ae59869c-6533-4970-98bb-856583f98f97"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("afe466f6-3801-4263-b332-d5cf236d1ad6"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b108705c-c45d-4a83-ae96-4b6cd4ba8784"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b1badd8d-a1b7-4855-b01f-e9bcee48e967"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b1eebae5-ff53-4ef8-81ca-4d02d5784cf6"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b316672e-8fd1-4fd2-be54-26f56dfbda49"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b3647b4d-9162-4fe2-8248-3abd02eab2c3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b36d0dd3-da19-46a6-9508-552966baed7c"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b38f0122-3eb2-4964-8a09-00f2b67202d1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b521b29e-3bf7-44ad-abc8-d1797bec4dd7"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b588e0da-c727-425f-a087-0843dafad614"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b8f33cf4-1051-4be8-874b-65f2204d8871"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b9c2786b-c972-432c-b416-50ce606b06bf"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b9d26c63-2a32-4172-8747-eb90a290df4d"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bdeb0085-f29b-42f2-8abe-b4356222ae1b"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("beb8dbe8-c97e-45bd-812a-6572efcb56dd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c1708800-23fa-4550-8d0f-2afa479d6b82"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c1711291-5477-4c67-a149-1969a19667fa"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c268e912-58a1-48ae-9c06-0bef1f40a84a"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c2a8734a-8e59-4c91-b3e0-943d2434b675"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c2a87a5d-4572-4fcf-b243-1e509a598400"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c3b8c278-77ec-4615-993a-84469a94dadc"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c45a6ea8-3b0a-4c98-826f-c4308c17b564"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c4e3eef7-7c19-4f28-825a-b18882a9cd09"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c6d09041-75c8-404c-81be-13165d176c99"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c77e9815-ee47-4a69-bf73-de2a7adb3512"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cbace41b-9a5b-4238-bc47-30d4f022c475"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cdf12b82-8577-4e2e-a593-5b4be98283cd"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cf4ad7ac-9a86-41b4-95fb-b327385d46d7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cf6c82b6-2d9d-46d1-b9ee-86d0670829cb"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d152f745-56db-4193-a3d2-319da1f8eb21"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d1ddacad-0bc2-4692-b08b-2af2abe74c0d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d37e552f-09eb-4c63-b1b5-3de28fa7989c"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d5f13588-66df-4290-94ca-5da3409343e2"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d8b8aee4-3f22-4898-92aa-04c1559ff170"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d9262539-2fba-4bb8-923e-baa266154606"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d9854160-e1ff-4723-b62b-e5193a2486cc"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("db2213ee-42af-472c-8b8b-7f2745a3bee0"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("debe896a-7bd0-48dc-ad1b-a9c06106c627"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e270824a-d458-48cc-8185-b7bcbfd192a2"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e347f5e4-9587-41fe-a353-642cfb95a1c3"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e36779c0-a1d6-4403-9e90-69eab6cbb08f"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e4604066-e037-422b-9ad8-58c5425481f2"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e4b9ca59-9cd3-4563-861a-1f92b88c30d8"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e551b1e8-c2fc-44ae-a476-0bd3708396ef"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e55bd5fa-bab1-484e-bc94-22a7de313e50"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e6230a0d-27ed-46b5-87d4-61f2e5eb2cc4"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e644be49-03d2-427f-a273-2fd35ea174fb"), "H", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e79de8a5-29fd-43a5-9c94-b797d7c7d2a9"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e85294bf-c866-44d9-bfa0-8505d8be46b3"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e97c1cc9-54f9-4a10-8901-8c5cb9b4bcd7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ea25534a-ad71-422d-a4f5-8e841957d245"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ead9ff05-5865-42f1-8f1e-21aa57db0bec"), "E", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ebc9cc31-e99f-4dc1-b51b-d53609d6df86"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ec6b850b-c8f4-40e8-bcbb-3d98fe21ac7a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ed2ce55f-e6a1-4d86-9eaa-4c97694973d6"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("efeafb30-8260-4975-9424-a59f89e1039b"), "D", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f0c96f8f-b43f-4a88-808a-94d1d366f464"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f17c179f-cca6-4fb3-a1a0-ade4b0d06344"), "F", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f1b9bbd7-f6a0-4e2f-a3ab-3ef1ddff1efe"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f2195982-2e4b-4c82-8444-8b82ce1e5f62"), "B", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f2ed150f-f7b6-4bd3-b496-b150d7b0907a"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f49cc272-36d2-45ac-854b-650211aa4c3e"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f5d0b265-7aec-4ae0-a44a-8781dc704d2e"), "A", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f6ded9a3-607f-4e8f-be7c-cfc3612420dc"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f729db31-278c-4fc9-9099-b5bbb1827a5e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f7e6740b-3631-455d-a9c5-560922cafe47"), "G", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fb1d3d34-4a45-4d54-9f65-d8287080dcd9"), "C", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fb625360-0a61-4b95-8d44-463b327dd569"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fc59773b-5801-4d91-9665-3d32f1b078a2"), "J", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fcfb0f03-6efc-4e7c-8c95-b3d5d70cdc8f"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("feeb8438-8361-4533-8920-a076344ffddc"), "I", null, null, null, null, null, null, null, new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("2c0b8489-8ce4-45d2-8471-b584fc4da9fa"), null, null, new DateTime(2024, 12, 13, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5054), null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 12, 20, 16, 50, 184, DateTimeKind.Local).AddTicks(5049) },
                    { new Guid("f14767c1-5a25-4662-9a2b-bfcd85595d44"), null, null, new DateTime(2024, 12, 14, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5061), null, null, null, null, null, new Guid("2b6dccb3-4694-459d-a2a9-965d5241ac9d"), new Guid("b1a47d24-0477-4ce6-8213-1c397e673ad8"), 1, new DateTime(2024, 12, 12, 20, 17, 50, 184, DateTimeKind.Local).AddTicks(5060) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("b3c14739-3689-42bf-a9d3-60c5e0e80758"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 12, 22, 15, 50, 184, DateTimeKind.Local).AddTicks(5455), new DateTime(2024, 12, 12, 18, 15, 50, 184, DateTimeKind.Local).AddTicks(5454), new Guid("57af0c2d-deef-49b7-942c-547fc0b68078"), new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5453) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("0f56a8ea-afc1-4565-b65f-e5bcd3201446"), new Guid("3ab81ce7-8ac4-4826-b57f-b5ae756a7c36"), null, new DateTime(2024, 12, 10, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5366), null, null, null, null, null, 4 },
                    { new Guid("9f88a78a-3e02-4745-808e-7d68d20f0abc"), new Guid("6a58ef37-f303-428a-b309-64f0472293c0"), null, new DateTime(2024, 12, 10, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5361), null, null, null, null, null, 1 },
                    { new Guid("a42e65e3-d770-446c-8586-cdd9fdf49e48"), new Guid("2710ac23-36ac-449b-8fa8-28b344af517e"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5363), null, null, null, null, null, 2 },
                    { new Guid("cf166114-9766-4676-ba68-a534f8caedca"), new Guid("f46417de-b2e3-48dd-91c2-322633bbaf12"), null, new DateTime(2024, 12, 11, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5364), null, null, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("315fe0ae-9782-400a-b5d5-6f44836ab6e0"), null, null, null, null, null, null, null, new Guid("2b6dccb3-4694-459d-a2a9-965d5241ac9d"), 2100000m, new Guid("74feffd0-8fa9-423f-b3c2-ce14dba6b509"), new Guid("9c8854ca-983a-4963-b35e-d34994ff9349"), 2 },
                    { new Guid("94bfc761-61a5-4452-b080-5f8bfbd85587"), null, null, null, null, null, null, null, new Guid("0ae3a568-598d-4531-b961-388636446ea3"), 3100000m, new Guid("1ee7e0e3-54b1-428c-9092-792bf010e4cd"), new Guid("31255efd-7b60-40c5-ac69-a6df8241f834"), 2 },
                    { new Guid("c8d1f9c9-7358-4f2b-b0b1-26eafa898430"), null, null, null, null, null, null, null, new Guid("1244257e-9e1b-488a-b72e-038a077f0c26"), 100000m, new Guid("74e96e10-0005-468b-a9bd-fed9222093ed"), new Guid("2e45426e-cea1-477e-95ef-9230cb15976c"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("23e5b1ce-5140-4668-ad7e-bf82c47f766d"), null, null, null, null, null, null, null, 50000m, new Guid("74e96e10-0005-468b-a9bd-fed9222093ed"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("7741ea44-1366-43a3-9f5b-571c1d2fc950"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("97e33c1c-53fc-4e6a-a0b1-3376f4093876"), null, null, null, null, null, null, null, 60000m, new Guid("74feffd0-8fa9-423f-b3c2-ce14dba6b509"), new Guid("82e89da5-0736-42ec-aa3b-a9ff41b64c56"), new Guid("42ac2e65-d487-4f63-91db-f6a76af1103d"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0f56a8ea-afc1-4565-b65f-e5bcd3201446"), new Guid("315fe0ae-9782-400a-b5d5-6f44836ab6e0"), null, new DateTime(2024, 12, 10, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5389), null, null, null, null, null },
                    { new Guid("8ca936fc-38ef-43de-8abc-e22f90eeb028"), new Guid("c8d1f9c9-7358-4f2b-b0b1-26eafa898430"), null, new DateTime(2024, 12, 12, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5391), null, null, null, null, null },
                    { new Guid("9f88a78a-3e02-4745-808e-7d68d20f0abc"), new Guid("c8d1f9c9-7358-4f2b-b0b1-26eafa898430"), null, new DateTime(2024, 12, 11, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5384), null, null, null, null, null },
                    { new Guid("a42e65e3-d770-446c-8586-cdd9fdf49e48"), new Guid("315fe0ae-9782-400a-b5d5-6f44836ab6e0"), null, new DateTime(2024, 12, 11, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5386), null, null, null, null, null },
                    { new Guid("cf166114-9766-4676-ba68-a534f8caedca"), new Guid("94bfc761-61a5-4452-b080-5f8bfbd85587"), null, new DateTime(2024, 12, 10, 20, 15, 50, 184, DateTimeKind.Local).AddTicks(5388), null, null, null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovies_ActorID",
                table: "ActorMovies",
                column: "ActorID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_PaymentMethodID",
                table: "Bill",
                column: "PaymentMethodID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserID",
                table: "Bill",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BillCombos_FoodComboID",
                table: "BillCombos",
                column: "FoodComboID");

            migrationBuilder.CreateIndex(
                name: "IX_BillTicket_TicketId",
                table: "BillTicket",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovies_MovieID",
                table: "CategoryMovies",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMovies_MovieTypeID",
                table: "CategoryMovies",
                column: "MovieTypeID");

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
                name: "IX_Point_UserID",
                table: "Point",
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
                name: "IX_ShiftChange_WorkShiftID",
                table: "ShiftChange",
                column: "WorkShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_Show_release_MovieID",
                table: "Show_release",
                column: "MovieID");

            migrationBuilder.CreateIndex(
                name: "IX_Show_release_RoomID",
                table: "Show_release",
                column: "RoomID");

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

            migrationBuilder.CreateIndex(
                name: "IX_WorkShift_UserID",
                table: "WorkShift",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovies");

            migrationBuilder.DropTable(
                name: "BillCombos");

            migrationBuilder.DropTable(
                name: "BillTicket");

            migrationBuilder.DropTable(
                name: "CategoryMovies");

            migrationBuilder.DropTable(
                name: "Checkin");

            migrationBuilder.DropTable(
                name: "Point");

            migrationBuilder.DropTable(
                name: "PromotionUsers");

            migrationBuilder.DropTable(
                name: "RankMember");

            migrationBuilder.DropTable(
                name: "SeatShowTimeStatuss");

            migrationBuilder.DropTable(
                name: "ShiftChange");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DropTable(
                name: "FoodCombo");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "MovieType");

            migrationBuilder.DropTable(
                name: "TicketPrice");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "WorkShift");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "TicketPriceSettings");

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
                name: "Cinemas");
        }
    }
}
