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
                    { new Guid("3b779821-a75e-45bc-81ed-3bdb3ffe93db"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("86b71153-926d-457c-854d-024271d1e778"), null, "mua tại quầy" },
                    { new Guid("e919942e-d199-4dec-a084-b7edb5cc0a47"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("78d016e8-4576-451a-8d88-94345f647051"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("266a07c4-085a-4107-bfca-4df360902ff9"), "11:00 PM", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6321), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6317), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("2001eb05-7135-4600-bef0-5aa5171c0f5c"), "Việt Nam" },
                    { new Guid("28d9eea3-69df-4771-8714-441b412ca624"), "Hồng Kông" },
                    { new Guid("3197d64e-a350-4189-b244-bda8f1f80b9d"), "Trung Quốc" },
                    { new Guid("4d62239c-205a-4f2e-b52d-052469eabb72"), "Mỹ" },
                    { new Guid("5cdb03a3-af0e-4804-a689-4fce7635819e"), "Hàn Quốc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("9c919286-061f-4210-9160-1c439792b3c9"), "Ấn Độ" },
                    { new Guid("bd43a266-78a9-44e7-9c15-279c7a20e8ad"), "Úc" },
                    { new Guid("d47ba4d0-3693-40c9-af3b-493e484d443d"), "Pháp" },
                    { new Guid("ed97653a-37ea-4b28-ac1c-16c2fb3383bf"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("3bd9f07b-cc0c-44cd-a1f9-51bc13ac9e90"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("3fa590c7-6f76-4b06-92a5-baf3266c87a2"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("4a986c28-c44f-49c4-b36f-be2ec5670d6b"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("5206e0a6-4f71-43c2-9b2d-a383bbc44c6f"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("75990cef-426d-4bce-baa8-ba8ccd60b98e"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9ffc3267-c64f-4e77-8440-9b13a26735dc"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("cab25424-c0b6-425e-83cf-03aa92452625"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("efbec0c0-18cd-4425-bb61-229d76d3325d"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f4356434-eb0d-4e1a-8574-2f4fea9866ae"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("0a3ab75f-6b50-493e-a304-0dfe3f016224"), "Combo 1", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7248), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("0e9c1c39-8637-4396-a090-4532cbbce4cf"), "Combo 3", null, new DateTime(2024, 12, 18, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7255), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m },
                    { new Guid("0fb34f02-56d5-4a7e-8e08-c34158d55476"), "Combo 4", null, new DateTime(2024, 12, 17, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7257), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m },
                    { new Guid("7c91f522-edfa-4069-9081-76084824444f"), "Combo 2", null, new DateTime(2024, 12, 19, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7253), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("218761d0-87a0-4556-b352-269d24b2e50e"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("3c06b0d7-9a24-4565-a683-ca27a341d18c"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("56558515-b5e3-4a04-82b8-0f3608e9c457"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("6afd3072-3b79-43e3-abec-9254910f002f"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("870494d0-dc2e-4ce6-a011-a446cc258a16"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("9586b863-6fe3-40e7-ba99-93423ea1fb56"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("bb885bfe-4fa9-485e-9093-6254ad52cbac"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("d07332f6-272f-40fb-8517-66e7dd603d13"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("dc3801b1-3ebd-4e55-a6f3-001dbc7e9bb0"), null, null, null, null, null, "Khoa học viễn tưởng", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("5dd66787-be23-40e6-87de-a6380f7211d3"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("5e7ffc84-07cd-4546-815c-b567e09883fb"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("859d14b3-5797-4c72-a15d-8c18b4d8e621"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("abb3dcf4-e4c9-410e-8918-3969c964c58d"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("b53da73b-6fef-4117-adc9-07bc7523066f"), null, null, null, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("5b2d714a-cee6-4945-acb7-38aceac6c786"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("6445ced7-cdca-4766-93c8-1eb3d646ed81"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5363), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5382), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5379), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0bcc6f4b-ed7e-4236-a689-d808ec43fb49"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6297), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("1f786c88-eed1-42a3-8675-2b3c08c8d90f"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6299), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6294), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2d20440e-295b-4a77-b2f9-12d4dc9de95d"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("30e5de4c-ebef-4a67-b7ed-913b7d39595a"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("39c987d7-985d-4f42-94e6-0b0631004b8b"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("54205f76-545d-4f74-925b-2d1b4eded27e"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("7c531546-aca9-4cc5-8093-2117c401ee52"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("7edf38ac-debe-4586-8778-cedc18c773af"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("85f67169-0304-4d5d-b6f6-ef92ee571450"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("8c4b21da-92b7-48bc-aea5-fbf7a80d773b"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("ce540010-7cd4-44a6-99ea-0f4f70f017c1"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("f4c99958-4965-4164-9fd4-3e46f2c7ef67"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 }
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
                    { new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6984), null, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("1054fd18-dbe0-48c7-8d5a-287e4063ec7d"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7007), null, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("f4356434-eb0d-4e1a-8574-2f4fea9866ae"), 109, new Guid("56558515-b5e3-4a04-82b8-0f3608e9c457"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("451a6609-1152-461d-83e3-f98c91109d83"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7033), null, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("5206e0a6-4f71-43c2-9b2d-a383bbc44c6f"), 110, new Guid("218761d0-87a0-4556-b352-269d24b2e50e"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("463d9004-d3ad-4fc9-bc99-4543317a70e2"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7046), null, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("9ffc3267-c64f-4e77-8440-9b13a26735dc"), 100, new Guid("870494d0-dc2e-4ce6-a011-a446cc258a16"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("6a0fc096-7eff-409d-9db7-6014807a734f"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7028), null, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("3fa590c7-6f76-4b06-92a5-baf3266c87a2"), 120, new Guid("3c06b0d7-9a24-4565-a683-ca27a341d18c"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2k0jK_sWmwE" },
                    { new Guid("b0e726df-9faa-4791-90d4-a63a50459afc"), 13, new Guid("5cdb03a3-af0e-4804-a689-4fce7635819e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6998), null, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("5206e0a6-4f71-43c2-9b2d-a383bbc44c6f"), 113, new Guid("218761d0-87a0-4556-b352-269d24b2e50e"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("c60263d3-d219-4375-8686-1ad9401736c8"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7015), null, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("9ffc3267-c64f-4e77-8440-9b13a26735dc"), 99, new Guid("870494d0-dc2e-4ce6-a011-a446cc258a16"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("cfde067c-f50f-419a-ae6b-2c3541c03254"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7021), null, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("e8efd407-52bc-4fd9-a17a-03583dc5f9ed"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6993), null, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("3fa590c7-6f76-4b06-92a5-baf3266c87a2"), 81, new Guid("218761d0-87a0-4556-b352-269d24b2e50e"), "xich.jpg", new Guid("5e7ffc84-07cd-4546-815c-b567e09883fb"), null, null, "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("f94dce99-a897-4b22-a8c2-c275b3e281dd"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7039), null, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("f4356434-eb0d-4e1a-8574-2f4fea9866ae"), 110, new Guid("56558515-b5e3-4a04-82b8-0f3608e9c457"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/X3SY9XUlQAA" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6352), null, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6346), null, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("002876d8-d8b6-473a-abe1-86a32cac8d2b"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5909), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("0fd11f3a-9d54-4d7f-ba60-2ee18434fb57"), "Hải Phòng", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5870), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("118fee57-1e97-4b45-9b86-14d59b2e8ed5"), "Hà Nội", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6098), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("234413e2-3658-4d97-ba9b-e869c411b31a"), "Nam Định", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6025), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2457d50c-57da-4cce-8a21-4af939d8db3c"), "Bắc Ninh", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5956), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2e6728ca-cffd-452e-8feb-af2aac53a90f"), "Hà Nội", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5847), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("343ee4b9-2e7b-4bfa-93f7-fe31c9022bfc"), "Hưng Yên", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6005), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("55c46c4d-a88d-41f5-84f3-8caa0cb92a8d"), "Quảng Ninh", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(6042), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("561a5629-e969-4518-9b62-980df83f9a62"), "Đà Nẵng", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5891), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("665611d8-792d-44b0-9595-404ee3481383"), "Hà Nội", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5480), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("75eedd3b-3071-40c2-8bd8-6246934a7e70"), "Thái Bình", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5987), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b13db532-2e8c-43f8-bc1f-4826a97df998"), "Nghệ An", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(5937), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("09c96d1c-fd8b-4421-ae16-58af855180ff"), "BILL009", null, new DateTime(2024, 12, 12, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7336), null, null, null, null, null, null, 0, 350000m, new Guid("343ee4b9-2e7b-4bfa-93f7-fe31c9022bfc") },
                    { new Guid("182779ae-c3dd-4f18-8e6d-47c6dcb6da4d"), "BILL005", null, new DateTime(2024, 12, 17, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7317), null, null, null, null, null, null, 2, 250000m, new Guid("002876d8-d8b6-473a-abe1-86a32cac8d2b") },
                    { new Guid("19f54016-d059-450f-8761-83fea9e6c827"), "BILL002", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7306), null, null, null, null, null, null, 2, 300000m, new Guid("2e6728ca-cffd-452e-8feb-af2aac53a90f") },
                    { new Guid("26e0c676-aebb-42ec-9f40-0c2704b8a9e6"), "BILL0122", null, new DateTime(2024, 12, 16, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7323), null, null, null, null, null, null, 2, 680000m, new Guid("b13db532-2e8c-43f8-bc1f-4826a97df998") },
                    { new Guid("2d1c0ff4-36b9-4247-b7ea-b37e0ad7b351"), "BILL007", null, new DateTime(2024, 12, 15, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7331), null, null, null, null, null, null, 1, 800000m, new Guid("2457d50c-57da-4cce-8a21-4af939d8db3c") },
                    { new Guid("331927d7-7fb6-48da-95cf-fb3d6f5b654c"), "BILL003", null, new DateTime(2024, 12, 19, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7309), null, null, null, null, null, null, 3, 150000m, new Guid("0fd11f3a-9d54-4d7f-ba60-2ee18434fb57") },
                    { new Guid("37c7a5f4-fb67-4359-8b65-0749b4501d7b"), "BILL008", null, new DateTime(2024, 12, 10, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7333), null, null, null, null, null, null, 2, 450000m, new Guid("75eedd3b-3071-40c2-8bd8-6246934a7e70") },
                    { new Guid("81ea1354-13a5-4a11-be42-f8d1a054e0e0"), "BILL010", null, new DateTime(2024, 12, 14, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7338), null, null, null, null, null, null, 2, 700000m, new Guid("234413e2-3658-4d97-ba9b-e869c411b31a") },
                    { new Guid("8502a37b-9978-4def-ae81-9891339e5184"), "BILL006", null, new DateTime(2024, 12, 16, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7320), null, null, null, null, null, null, 2, 600000m, new Guid("b13db532-2e8c-43f8-bc1f-4826a97df998") },
                    { new Guid("872f7acf-2847-409e-be6f-1063d870a51a"), "BILL001", null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7303), null, null, null, null, null, null, 2, 500000m, new Guid("665611d8-792d-44b0-9595-404ee3481383") },
                    { new Guid("9438b2a5-8ae0-47d7-94b2-da6a6ff2a59e"), "BILL004", null, new DateTime(2024, 12, 18, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7315), null, null, null, null, null, null, 2, 200000m, new Guid("561a5629-e969-4518-9b62-980df83f9a62") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("568fbd71-e0e3-475a-8249-b387fc4d4383"), null, null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7428), null, null, null, null, null, 50, new Guid("665611d8-792d-44b0-9595-404ee3481383") },
                    { new Guid("bf71be9c-8a86-4231-ab94-fe3ff0053ebd"), null, null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7431), null, null, null, null, null, 150, new Guid("2e6728ca-cffd-452e-8feb-af2aac53a90f") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("18777456-fa8e-4e5f-9f0d-4fac6660d4ce"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7413), 1, new Guid("665611d8-792d-44b0-9595-404ee3481383") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("2914a021-90e1-4a50-a28e-6404da60a732"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7134), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 24, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7133), new Guid("ce540010-7cd4-44a6-99ea-0f4f70f017c1"), null, 0 },
                    { new Guid("3b5e272c-7044-44de-8957-07daba65cdf8"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7111), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 29, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7109), new Guid("30e5de4c-ebef-4a67-b7ed-913b7d39595a"), null, 0 },
                    { new Guid("464e72b6-4c28-4ad0-8cb1-1c5a7aacb29d"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7116), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 28, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7112), new Guid("7c531546-aca9-4cc5-8093-2117c401ee52"), null, 0 },
                    { new Guid("9d68c6a6-cbb3-443e-ae22-069411e426ed"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7106), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7104), new Guid("8c4b21da-92b7-48bc-aea5-fbf7a80d773b"), null, 0 },
                    { new Guid("c2a8665c-a5b0-4485-9606-5688c0139f83"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7125), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 25, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7124), new Guid("f4c99958-4965-4164-9fd4-3e46f2c7ef67"), null, 0 },
                    { new Guid("d44d42b0-b5de-4d2d-99ae-257f6b6596cb"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7119), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 27, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7118), new Guid("2d20440e-295b-4a77-b2f9-12d4dc9de95d"), null, 0 },
                    { new Guid("d696b65f-7554-440c-b86f-2c0d7d43d64f"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7122), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 26, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7121), new Guid("39c987d7-985d-4f42-94e6-0b0631004b8b"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("021c55da-a8be-42f0-801f-8d6987753e76"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02ce3c6e-1b08-447f-8fbb-7a008e5a67b4"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03102bcc-780a-4f27-8674-a339f85ef01d"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0434786c-91ed-4df0-9b0c-37b90340066f"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04733ce5-e272-49c4-9b58-884ef25abc05"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05694c42-646d-49e3-9028-a9f729fc2188"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("059af141-91fd-4c2b-a436-a81d1f83b5e3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05abd391-a7a5-4ad3-8f85-1163b49c77b9"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05cb27bc-7ab6-474f-9e19-c34e73493ce2"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06ff42bb-4bb2-45af-976a-d8dc8b3c6562"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0817521d-aeec-484e-afa7-ee2072d8c800"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a3af5c1-0476-4b21-8cf0-8a479947250e"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0bfdd849-6af6-45c1-923b-d2cfc505b6b5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e678362-3959-4647-854c-a0202cf5e3c0"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f1e35aa-07f4-46a0-9dc3-4c85c2072c7b"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10f11eb9-f3b2-45cd-b28c-e5593070c245"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11a94732-c5b2-4dc9-a18c-0b7b1a344583"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("125b4bbf-80d5-4b63-b8e4-6245285d1b2a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("141fcd5a-bba0-4ed4-b053-c4020213cbd3"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("14754d4b-b01a-4f82-bc43-930b0ea0cc78"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1490e771-a567-4ca3-84be-9ffb592d1bb9"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16223b38-6978-449e-8839-19a60830ddea"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16bde20d-6b9a-47e0-b7ae-3d8fd24fd96a"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("191c40d4-2459-4476-9352-74d97c376c9e"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19a2a1f0-5914-4712-8d89-9b74ca712781"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19c7ff4b-247b-4a58-8e0c-b7c00970e0a0"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1aac8648-9fc4-4f95-85ed-b52311eb3a6d"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1af7a536-80cd-4160-a2d0-09e59a256d11"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b2b6d2d-d157-4735-b94c-f8bc67ac1927"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b33fa97-fac5-42c8-9376-7abe12f0ea68"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b7488d5-649a-4971-a4fd-7293bb26d385"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c20b10c-5ba2-49f9-830b-24a6d5c841e4"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c262613-dc94-494d-b432-e98eff3efe7e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d8bd015-a90b-49ed-a5c2-f9f6aac44152"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d963c8a-cc8f-4e80-adcd-30835fcb9eb1"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f3bfa04-723b-414e-bf76-e54709418880"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20846dbb-99bd-47bc-89a6-ee08e7ef11c7"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21788357-bc6e-4014-8bcf-851b3add144a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21bd4e7a-0dd3-4277-90b8-b4067454b671"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2249d8ad-b98d-4101-a590-abd7fffe3a2d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2288fa2f-f46f-42e1-b730-89f38ca6fe48"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("238f74a8-e87c-4be2-bf32-f1225194cc71"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24aaebb8-a074-4534-add2-b49adb738bf0"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24cb10eb-b7f5-4d85-8623-90162438170a"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24d119b0-c064-41bb-b60d-ca037d38141d"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25ee88ab-0fdb-4279-a8c3-9952ad0dc30b"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("292d7488-6bfe-4235-ac1d-73454584811c"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ae9c763-7c53-4572-bc4b-1c45e225f732"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b43bf1d-2f70-4bc7-980d-fb4e505863df"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c10c654-3700-4d9b-81d2-cba8ad518ec4"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c781089-e74e-4062-a873-55af7e4f2184"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2db3ed7c-3866-40cb-ab96-68bae3d4be1a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ed76056-7ce0-4ec2-a4c3-94aba18819a2"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ee83260-3870-4f19-a7b5-794bec32a17b"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2fd3766a-dfb8-40ec-bff7-ed3b655538c4"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("304a8ea1-baad-4010-8372-12d7490b87b6"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30aff201-b8a7-402e-9410-37059b5af27f"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30e1b232-c214-44e2-8920-763d12f49bc7"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31cd3a93-b846-4f5c-98fc-03d3a46cb0b2"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31e0c6b7-6e05-4db9-a906-6973d1511d06"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31f756eb-18da-4983-a4ea-187c9175ccb6"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32cad2a4-bc06-420a-b7a2-cf5c328090ee"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33e38c7b-3613-4cd7-96e5-e03833d8fa1d"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("34bbc71d-f7f1-4f74-8bbe-a56f911a9aa7"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36d02e58-635b-492c-904a-9673af0ae386"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3978dbb0-506c-4119-82cd-34b7ca09aee0"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c00b890-0c16-477a-891f-1474b4a26d45"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3db65096-7a33-4833-ad08-f6465f781e08"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e870991-cec8-47a5-a517-a11050b9a80f"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f554bbc-26f9-4aa5-a016-649e7ee96441"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fe7be7b-97fd-41f8-b51a-e923b6948ab3"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("421ea1e5-0914-43d0-b730-e3876601c6b7"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43cbb0a6-70ff-4e42-bd58-325a293c12fa"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("488af5c3-c84d-4c77-8fa0-37660096fee6"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4894116c-ed72-4ae3-9953-70fa46b3e9be"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("497457a5-ccd3-4792-9c15-b50964a54281"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4983c34c-f755-462e-8a2a-f1261b21e4bd"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ba2d8f3-1f68-44d2-ba8a-2ce51c4f8876"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4f7460fd-185d-41ab-ab26-cf925b4fabb4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ff3e74c-3c6b-4438-8932-23ea3019eab6"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ff708e2-0648-4912-95c3-d0ee26cf725e"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5091a36e-90ec-459f-bf72-81fd18d6659e"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50939927-d75e-46f3-8f7d-58ecb8c93215"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51523e9e-1113-4f59-8753-c5195a241a1a"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5175351a-c578-4a8d-a9f2-e22b61e1e68e"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51b542f9-cb16-40ee-801d-98d3e21e64b9"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52c88f65-e8ae-4b8b-8902-c78918618dba"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("539a1c87-9aab-40b4-8582-200413c1f45d"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("555ef1ac-b079-4f56-8447-e90597127093"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55afbb0e-85ca-499f-b145-77b57b3a4522"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5773f349-a735-4136-b395-4ec3850b4dac"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("580c8a50-290b-4d3a-b13e-32e63dd32da8"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("58103fe0-bdc8-4f20-90b8-ccd9a6f4d66c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a19cc14-8c0a-41b9-9ec4-3a07cf36a7fa"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c0550ff-7391-4e7a-9f5f-525a6a693c95"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5d2d1e94-9f83-44d9-9be9-16d84444c7e7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5df355fe-a1a7-4972-827f-573989dfbbe1"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e86bd50-b954-418e-b779-458fbc01b240"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60633f69-a3c1-4a8f-beef-363cceb27454"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60b9788f-57f6-4d9c-9812-d13c391f1582"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60f35c7a-4d66-4a35-87e0-599c8866ca12"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6110b5e5-95f8-4455-aa8a-6e237728fee8"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62975242-2768-49e6-9727-1b91ce6de9bb"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62b01a63-afb4-4a96-9ad2-99744446ea94"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63c21a15-958c-463f-8da2-4c00c66d6228"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("644b278b-d0e9-4701-9c17-154bcad574d5"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64e17d84-6a5c-4540-9bd5-4b02c9668386"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65a27e30-d4e1-4a64-b49e-043df0c3bc8a"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6626584f-f962-409f-8849-62406751e234"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6785b35f-5043-40be-a410-031f70a5cd45"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6abc4955-083e-4bd2-9394-56bba809a096"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6bbc619e-03c2-4470-99b0-9ff310423799"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6d95e142-95ab-4274-82e2-b361dffdad2d"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ec61ee8-c4d9-49b1-a838-f342529d11fe"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("702cb288-9a27-492b-b1d9-8d3f6f116ada"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7033627f-ae6b-41cc-bac7-8715478650fe"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70d0907f-4fc8-43fd-b24a-4c29290da745"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("71f4ed98-10a2-4216-9459-fabf2bdf3acc"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("762f9d0b-9d6f-4bbb-992f-332a69fa9970"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76561104-03f9-4384-951f-c118704f5f99"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76d21304-d251-4154-acd0-eed84bf0c185"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77540e0e-9639-4bd6-9a75-c82a9094bb01"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7920cf22-691b-4d0c-82b7-39c0f96a9220"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79b3a1be-a406-47fe-ab8b-39196fa78918"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a704719-7dc7-4760-8791-2e4a06b20731"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cf3753c-cb4c-4449-8c4d-2f12a5cdc94e"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d951923-cb15-49ef-bcc2-fd65f7666b54"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f64d3fa-419d-4fba-bb94-db3be49e72bc"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fdf5538-6660-4bda-8033-7b42649447ab"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82e96c03-f75e-4d22-bbc3-1bde3a02ee01"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("838ed820-638e-46a9-89bf-2a7c17a54169"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83fa106b-6162-4578-a6e1-0416e1d1198f"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84bdf707-b543-4a82-ad71-ad73239ec226"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86eb8a38-3632-4367-9844-f4132067655b"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("872c000f-c267-4586-90a5-7967cfae2bdf"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("891c05f3-57de-46a3-bb1b-5d1ede2c6dd0"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("89a9fce9-c165-41c9-ae5c-6ce78c1810a9"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8aea8610-fa7f-43ac-a145-163b2c963f69"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f97de22-3077-48be-9333-b98b2027dc36"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8fc9b9aa-6f49-4bca-97cb-fedf1f4dde90"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9158fc56-4775-4e23-90b4-9fc6eae8ecbb"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("924491ed-9a04-4e0d-a5f0-659610c036cb"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92bcfd1d-08c6-4947-83f7-aedf7e0dbbcc"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("95f35a0a-018e-4158-a358-e33e5c8013c5"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96098bc0-39ab-4052-95ff-d16799143696"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("971f482f-5949-40b7-83ec-1e3b65d88036"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9797b62f-c9a8-404d-9aed-d4bb22e1b0ac"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("980de14b-da3a-469d-a817-5a1daf67c847"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99c99765-ee06-49a7-bf50-ce0b0086fa72"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cb30bfa-26a4-4c64-8eef-b12c858a1589"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a004e644-f0d2-4276-a611-8c2f9617c7ac"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a02ab03e-01e3-4fbe-89e1-54acf702be58"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1708361-33ee-494f-b939-f5d0ec5c6f97"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2301df6-135b-4fb0-8b14-2598db660198"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a253236b-42ee-409f-a9bc-1f1a446f9c93"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a4a3a4f8-6d96-43bf-80d7-23991fa7f4ae"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5a2f4b2-006a-4ea6-bc6e-6c2486a8c30c"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6ce8491-5e89-44a4-b290-c16cef737d33"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a762b97d-c642-46d2-9cc2-656ad217c8c5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a81561a9-ef9f-416f-899a-dc43913f03ee"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab3f9427-b4f5-4a90-b53e-5cc4c6de1bd7"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ada29c39-7de2-4274-8246-08f7185146bc"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae549346-b2bc-4dc7-bc24-1ce3c0e94490"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae726f9b-5140-4812-b224-8d3e9dcf3fdc"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aeab05f8-41c6-4629-a06a-c9831b96f123"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b062c19a-3798-44b0-a008-436d87fc1f3e"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b4213b61-2bda-4a67-b2c2-101c7580699c"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b5101ec4-e65f-411e-91c8-c3eef7ca30e1"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b54bc7ee-70f3-471e-9f01-ddf09a6b4e72"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b54f5ace-5119-47a5-a631-d9882011424f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b62a8ef4-5f46-44a3-b01e-23835a404bd1"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7088e35-90f4-43a6-ad1a-50a656681591"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b8176406-8548-4499-aec4-29d9359c7697"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b84d7e60-4b95-4873-a701-bc2a77590cef"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b8d0e293-4483-419e-be74-e31c521b9d8e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9053dd4-f315-4081-8d9d-970800f709ee"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbb4f2cd-6dd0-43e7-9ebd-19cb39608c01"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc0138ed-5b55-4ad5-8078-d264ab8fc14b"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bda81bdb-30f9-4dbb-b15e-74abebcea2f6"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("befbe883-562d-4da8-b01a-8816d101a11f"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c1e9850c-db58-4493-a458-980b0e7bbdbc"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c30ad71a-5974-468d-85c6-61a02709e7ad"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c43673fc-8dc8-41e9-b4f7-5fb9c9054022"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c52ce40f-60c2-4340-8010-8f99defb2be8"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c58b1014-8ee9-49d8-b687-b2f0e28f9f4c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6107042-07c0-404d-b84c-e821a7696f28"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c712eea5-1bee-4648-887a-6f87aa2c0679"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7fa03ee-50ae-48cc-aa7b-bf33d1ce29c0"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c850db16-29d8-44d5-90e5-6e10af29f9fb"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8b5c1de-3296-4dc0-a2de-7c2591aff347"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c98c2101-b365-4213-9210-e43d2366091b"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9931681-247e-490a-851b-e300f6787f26"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("caab21b7-e317-4b85-b64b-0df0eb8d9e09"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc947724-cde5-474d-8417-845c60b2049b"), "F", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cdf0574e-0e96-4c43-9fb1-99a917e546f5"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cdf8f387-f5b9-4138-a1af-87fdf11579ce"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ce9adee3-a8c0-4f04-8a6c-4030bb4ef03c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf080fac-bfe9-4bdc-9001-26ec7ba31c09"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf11ae14-9ed4-4b02-a7d9-690a4aa024a4"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d00e928c-6f31-4b33-810f-8ce08c0159f1"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d021547c-827c-4d46-a3de-2ebc691e35b3"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3162ff5-3964-47f3-a7c4-16b8817cbad5"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d400b6ef-df2e-49fa-9de3-7103d458fe25"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d44ce049-6584-4e1e-b6f2-e3d1c7276947"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d4ef5724-c9fc-453f-b2fb-f880b4224aaa"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d5abde5a-c9ba-4fbe-a187-7a7d24bd9380"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d7590e91-5d07-4f85-ad34-f36815abdc4b"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d85edbf7-f2bf-4ef0-9d9f-5c0e36594f02"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d89efd1b-c4b0-43b4-8f33-485c3e53c8e2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8c1d561-ed48-4d8b-b103-563e5396340b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8f5b335-0210-45a3-8ef2-8d41a4a793fd"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9704251-185e-449a-9313-bd14e27f7c0a"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9ad0abf-9859-4d19-8cb0-30aee0569ade"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dbd15d44-59e5-4d25-9e33-d996fb514bed"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc0c8f6d-3627-4f49-a9f1-9aeac33d3ef8"), "I", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddd82bd3-b52e-4d2c-b7f7-64b93e2aa21a"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e04b40f3-6e60-4c4a-94f3-93150294e697"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e18b634a-6e08-423c-8e7c-cbb5e9cf43ff"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1deb6b0-d382-45ed-8f1a-aa94e97f5942"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e26be36b-6728-4526-bec7-4a85719e3e26"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2aa7db1-2e48-4bdc-a840-84fbee83fbc0"), "J", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3034088-651d-4391-8dbf-55be157079e2"), "B", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e43f01c0-1d0f-4abf-b2fe-d8fb58d2be9b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4566cbb-acfd-4958-9d3b-2794276dc82e"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e49f0208-419d-472a-9255-a21675315d47"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e70e1e7b-7a99-4a5a-8201-5ad7e99169ae"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8d6e3b9-2e35-48dc-906d-c01e266d47f7"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea0c01d4-206a-4424-87d9-65fefb83b53d"), "D", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea7c3576-611d-41a8-a107-c10e870bafe8"), "C", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eaf43ce1-de93-416f-9cc7-1f3a8ba5f8eb"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ece9695a-0fed-4d55-99c2-f3d0661511f2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef9b7738-d70a-4239-9475-854cf39d871c"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("efbc8543-c8f7-49d6-9f7e-112429aa4afc"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f050800a-0036-49a8-a0bb-640afde68cfe"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f30612e6-729b-4470-b3cf-904ee354b60c"), "G", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5340148-e01d-48d6-b7d2-a184091ed3c4"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f74ec7c5-8fa6-4d22-99f3-81a62ca1c80c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8d2e82e-c6d9-4d24-8ac9-0ffa54e4640c"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9848305-1976-4939-a806-5c57491715ac"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9ec2770-b07f-4091-8d7b-c201ef257722"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fb44d3a8-76e6-4129-820e-2c1cb9bf7ba4"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc074f55-5f9a-475b-9e10-a30581bc9c27"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fc45747a-3500-43a7-941a-cdbca36bf53b"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fca79a62-5090-4c6c-8764-6c81bad703b3"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd8965f2-1216-4806-843a-cb6d70f70cdd"), "H", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdb7ec51-cd30-407f-aef6-e3e5aa8c3bb4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe08ea6c-d9bf-4968-b47b-9d741427742e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe34b139-b1e3-4bad-bf1e-e53f56f78ae8"), "A", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe633c65-79b9-48aa-9c74-74543b91cc1e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ffaae7b1-2a2a-4091-8df4-fde38178b0a3"), "E", null, null, null, null, null, null, null, new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("b82135b6-bd9c-49d9-8f0f-c8b4ac8c2075"), null, null, new DateTime(2024, 12, 22, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7083), null, null, null, null, null, new Guid("e8efd407-52bc-4fd9-a17a-03583dc5f9ed"), new Guid("6887c045-3c4e-41c7-be25-0f453ad7dca1"), 1, new DateTime(2024, 12, 20, 21, 40, 35, 667, DateTimeKind.Local).AddTicks(7082) },
                    { new Guid("eaa83ddf-53ce-410b-85ce-ce41ce0654a5"), null, null, new DateTime(2024, 12, 21, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7075), null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 20, 21, 39, 35, 667, DateTimeKind.Local).AddTicks(7068) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("00450e07-df6d-447c-8c5d-dfd248174f8e"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 20, 23, 38, 35, 667, DateTimeKind.Local).AddTicks(7450), new DateTime(2024, 12, 20, 19, 38, 35, 667, DateTimeKind.Local).AddTicks(7449), new Guid("665611d8-792d-44b0-9595-404ee3481383"), new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7449) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("19f54016-d059-450f-8761-83fea9e6c827"), new Guid("7c91f522-edfa-4069-9081-76084824444f"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7361), null, null, null, null, null, 2 },
                    { new Guid("331927d7-7fb6-48da-95cf-fb3d6f5b654c"), new Guid("0e9c1c39-8637-4396-a090-4532cbbce4cf"), null, new DateTime(2024, 12, 19, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7362), null, null, null, null, null, 3 },
                    { new Guid("872f7acf-2847-409e-be6f-1063d870a51a"), new Guid("0a3ab75f-6b50-493e-a304-0dfe3f016224"), null, new DateTime(2024, 12, 18, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7358), null, null, null, null, null, 1 },
                    { new Guid("9438b2a5-8ae0-47d7-94b2-da6a6ff2a59e"), new Guid("0fb34f02-56d5-4a7e-8e08-c34158d55476"), null, new DateTime(2024, 12, 18, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7364), null, null, null, null, null, 4 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("89146321-9b3a-451b-8b9f-98da236f87a2"), null, null, null, null, null, null, null, new Guid("b0e726df-9faa-4791-90d4-a63a50459afc"), 3100000m, new Guid("464e72b6-4c28-4ad0-8cb1-1c5a7aacb29d"), new Guid("1c20b10c-5ba2-49f9-830b-24a6d5c841e4"), 2 },
                    { new Guid("a948a6bb-c3d0-4997-b35d-6cd66dade47d"), null, null, null, null, null, null, null, new Guid("0676b1cb-d0e3-494f-9b39-b82aadd44aaa"), 100000m, new Guid("9d68c6a6-cbb3-443e-ae22-069411e426ed"), new Guid("1d8bd015-a90b-49ed-a5c2-f9f6aac44152"), 2 },
                    { new Guid("c7ca8129-6197-4e9e-86c8-130d2ce84232"), null, null, null, null, null, null, null, new Guid("e8efd407-52bc-4fd9-a17a-03583dc5f9ed"), 2100000m, new Guid("3b5e272c-7044-44de-8957-07daba65cdf8"), new Guid("021c55da-a8be-42f0-801f-8d6987753e76"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("78d016e8-4576-451a-8d88-94345f647051"), null, null, null, null, null, null, null, 50000m, new Guid("9d68c6a6-cbb3-443e-ae22-069411e426ed"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8c4b21da-92b7-48bc-aea5-fbf7a80d773b"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("86b71153-926d-457c-854d-024271d1e778"), null, null, null, null, null, null, null, 60000m, new Guid("3b5e272c-7044-44de-8957-07daba65cdf8"), new Guid("0bcc6f4b-ed7e-4236-a689-d808ec43fb49"), new Guid("30e5de4c-ebef-4a67-b7ed-913b7d39595a"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("182779ae-c3dd-4f18-8e6d-47c6dcb6da4d"), new Guid("a948a6bb-c3d0-4997-b35d-6cd66dade47d"), null, new DateTime(2024, 12, 20, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7394), null, null, null, null, null },
                    { new Guid("19f54016-d059-450f-8761-83fea9e6c827"), new Guid("c7ca8129-6197-4e9e-86c8-130d2ce84232"), null, new DateTime(2024, 12, 19, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7389), null, null, null, null, null },
                    { new Guid("331927d7-7fb6-48da-95cf-fb3d6f5b654c"), new Guid("89146321-9b3a-451b-8b9f-98da236f87a2"), null, new DateTime(2024, 12, 18, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7391), null, null, null, null, null },
                    { new Guid("872f7acf-2847-409e-be6f-1063d870a51a"), new Guid("a948a6bb-c3d0-4997-b35d-6cd66dade47d"), null, new DateTime(2024, 12, 19, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7387), null, null, null, null, null },
                    { new Guid("9438b2a5-8ae0-47d7-94b2-da6a6ff2a59e"), new Guid("c7ca8129-6197-4e9e-86c8-130d2ce84232"), null, new DateTime(2024, 12, 18, 21, 38, 35, 667, DateTimeKind.Local).AddTicks(7392), null, null, null, null, null }
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
