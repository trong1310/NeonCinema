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
                    { new Guid("6ee53d14-7c37-48c3-8a63-cd605e11db2e"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("0113e16f-3c57-40bb-a790-b8a726358762"), null, "mua tại quầy" },
                    { new Guid("eecb1091-aef2-4c33-aa86-13cf339f8623"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("56336b15-1668-4323-9296-3eebea21bb4b"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4675), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("e6b9514d-bd8b-4208-a0bf-cc959584c820"), "11:00 PM", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4682), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0580bc5e-00d8-4995-8ace-2fa68d36b8c3"), "Hồng Kông" },
                    { new Guid("2d65e2b9-64e9-44ed-a71b-5c4400818ed3"), "Mỹ" },
                    { new Guid("3269540f-bc84-42d9-8744-93690e47cf30"), "Vương Quốc Anh" },
                    { new Guid("51b06880-1e62-4579-89da-4e10336be08a"), "Pháp" },
                    { new Guid("59083b3f-9a46-463c-a52a-4c2c970067e0"), "Ấn Độ" },
                    { new Guid("85ca10bd-4aa3-42a9-a2cb-2169dce44572"), "Úc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("b991e10d-8380-469d-9bac-efa369335868"), "Trung Quốc" },
                    { new Guid("c580e187-3d5b-41d9-aee8-e33b1b7cd0e1"), "Hàn Quốc" },
                    { new Guid("e25e2df8-7a41-417f-a1cb-0d7c9a525056"), "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("18c79da6-999d-449e-b8b1-a81917290412"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("41a51549-cbf5-4498-aeb2-435292366172"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8d52e906-9bb3-439f-a94d-ba592cc94458"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9a7745fe-edf3-4760-8c00-3f31de981a94"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("f1505424-c963-4e6c-93e0-57c713732b8d"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f707fb95-e498-4e37-b094-454dbc1a4667"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("05532b57-9e63-4346-80c3-a8e52c63f41d"), "Combo 1", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6350), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("1bebaaa3-d36d-4425-8257-d0cd5653eed2"), "Combo 2", null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6357), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("72f07a1f-568f-45a5-8754-882aa8f6437c"), "Combo 3", null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6363), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m },
                    { new Guid("9d16fbb6-2377-401d-8f47-8a232b98a371"), "Combo 4", null, new DateTime(2024, 12, 11, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6367), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("5341aac1-d5e5-49ff-8490-b8bf8ab33e67"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("58b299f8-425f-453b-be54-5961427be7d9"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("74904160-7f95-4b64-8306-792190d835a3"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("95007f6e-8043-409e-aa59-18e21c112e13"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("c91817a4-9e1b-48d9-82d4-647d2f04e8e0"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("ca033979-d36e-4d4e-bf8a-61ac114f2d76"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("d20162d0-4898-4c09-a78f-e6dd5736676c"), null, null, null, null, null, "Phiêu lưu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("46b4c3d1-aa68-4607-901d-c3f0af508fd3"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("79e57ee8-3f28-43f9-b5d0-96df7674f38b"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("82edbda1-bc4c-4a7c-b42b-1cc7a1f0532e"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("8e05f530-e4fd-4723-98ad-dc4928cff696"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("bf1fa6c8-b068-4809-b30f-69ad579df588"), null, null, null, null, null, "ThaiLans", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("8cbd081b-ec8a-46e5-b966-f311baf02366"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("ec2aebea-b86a-4ea2-aaa7-642c30952b19"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(2710), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(2749), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(2745), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("014c866d-d5ee-48c8-a990-36f25b611283"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4635), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4629), null, null, null, null, null, "Ghế thường" },
                    { new Guid("c8eabc76-e12d-4442-9ea1-595f07a64610"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4641), null, null, null, null, null, "Ghế đôi" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1f7d5e68-d263-4b69-b6ef-dae69b104d82"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("2285f27a-ffdd-42ab-9f26-d2c70ba0ae00"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("424c07b0-8c6c-489b-b129-9198baaf52ee"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("65701a83-4e06-419e-b519-69bd6873b439"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("9904c940-e1db-4000-9d77-08ae3963ae79"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("e61149fd-7e1d-49ea-b988-acfc50e33f24"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("f1f2041c-2880-48c3-a9f5-7951fddc53ed"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("f41dd84a-fe43-4246-ad3c-5081968f1639"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 }
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
                    { new Guid("194a7588-fbc4-450e-b8dc-0b2dfdce3b81"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5880), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("336e0a18-355c-466a-8233-e15f6389c966"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5805), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("41a51549-cbf5-4498-aeb2-435292366172"), 110, new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"), "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("41056346-3a8e-4010-bf53-f55417208f99"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5785), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"), 120, new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"), "161cd6ca-380d-4627-8071-2d5af03a1cf2.png", new Guid("79e57ee8-3f28-43f9-b5d0-96df7674f38b"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("57622f9c-9054-4523-96fe-eab9b1dd7110"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5950), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"), 145, new Guid("58b299f8-425f-453b-be54-5961427be7d9"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("828c8a68-6beb-4349-9560-e17d67529e83"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5897), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"), 150, new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"), "5b626704-f3d1-482f-b77c-903284966efa.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5757), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "0e9f825c-5346-44f1-a94d-7078909ce83a.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("b78712ac-6542-4a0a-9abe-366d223242dd"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5858), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"), 125, new Guid("74904160-7f95-4b64-8306-792190d835a3"), "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("c4e09c95-5f67-4090-80a8-2b022bd875c7"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5915), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("41a51549-cbf5-4498-aeb2-435292366172"), 130, new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"), "7502d22a-c967-400c-bc8c-3062d00c7fcc.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("dfb06127-4c7c-40a8-ac0e-f0f7eb017f03"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5841), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"), 140, new Guid("58b299f8-425f-453b-be54-5961427be7d9"), "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("f1f48ad0-9552-4f47-a773-c531beae1955"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5995), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"), 100, new Guid("74904160-7f95-4b64-8306-792190d835a3"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("11714696-0dc6-4369-927e-4300aeb42515"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4728), null, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4720), null, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("05955192-97e1-4613-856d-55491351cb48"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3879), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1edfe016-5fdd-44b4-b5ff-4b30c2d80234"), "Bắc Ninh", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3972), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("20292962-8107-4547-90e9-01cbc8f79676"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3653), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5279817e-f995-4a90-9df9-fa1f5abecaaa"), "Đà Nẵng", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3798), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("58db499c-91bd-4f84-a40c-0cba27f8f64a"), "Nam Định", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4151), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c21907e4-9a32-4663-9733-151d9baf031f"), "Hưng Yên", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4075), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3003), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d9d09c89-2e79-438f-9c87-e78d20675314"), "Quảng Ninh", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4245), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84"), "Nghệ An", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3929), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fc76638d-ef88-4d3f-ab7d-eed8c6e5b636"), "Thái Bình", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4013), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fe6b1b3f-ead7-443d-a247-051232a6f562"), "Hải Phòng", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3727), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), "BILL004", null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6704), null, null, null, null, null, null, 2, 200000m, new Guid("5279817e-f995-4a90-9df9-fa1f5abecaaa") },
                    { new Guid("375e4e5e-35a9-4915-ba0c-b4c29d7dcb40"), "BILL005", null, new DateTime(2024, 12, 11, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6710), null, null, null, null, null, null, 2, 250000m, new Guid("05955192-97e1-4613-856d-55491351cb48") },
                    { new Guid("3e91529c-8a0a-454f-b2bd-12a1ff581b71"), "BILL008", null, new DateTime(2024, 12, 4, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6740), null, null, null, null, null, null, 2, 450000m, new Guid("fc76638d-ef88-4d3f-ab7d-eed8c6e5b636") },
                    { new Guid("60ac2f1c-5dcb-42e6-8361-3753b63b6b94"), "BILL009", null, new DateTime(2024, 12, 6, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6749), null, null, null, null, null, null, 0, 350000m, new Guid("c21907e4-9a32-4663-9733-151d9baf031f") },
                    { new Guid("782cb184-268d-423e-a361-c9276edb73c0"), "BILL0122", null, new DateTime(2024, 12, 10, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6722), null, null, null, null, null, null, 2, 680000m, new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84") },
                    { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), "BILL003", null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6697), null, null, null, null, null, null, 3, 150000m, new Guid("fe6b1b3f-ead7-443d-a247-051232a6f562") },
                    { new Guid("857b4547-4fe9-4b3e-a2b8-fb9ec4a28bf6"), "BILL010", null, new DateTime(2024, 12, 8, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6754), null, null, null, null, null, null, 2, 700000m, new Guid("58db499c-91bd-4f84-a40c-0cba27f8f64a") },
                    { new Guid("990de630-49bc-41d2-84a6-72321ed83140"), "BILL006", null, new DateTime(2024, 12, 10, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6717), null, null, null, null, null, null, 2, 600000m, new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84") },
                    { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), "BILL002", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6691), null, null, null, null, null, null, 2, 300000m, new Guid("20292962-8107-4547-90e9-01cbc8f79676") },
                    { new Guid("a286d6bf-dda3-4df9-a177-4282a0abc273"), "BILL007", null, new DateTime(2024, 12, 9, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6735), null, null, null, null, null, null, 1, 800000m, new Guid("1edfe016-5fdd-44b4-b5ff-4b30c2d80234") },
                    { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), "BILL001", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6676), null, null, null, null, null, null, 2, 500000m, new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("619f405a-f47c-41b5-a8f1-b5a807c6ba56"), null, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6940), null, null, null, null, null, 50, new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd") },
                    { new Guid("a72e6123-44c9-4559-b210-944fd2e2b5b5"), null, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6946), null, null, null, null, null, 150, new Guid("20292962-8107-4547-90e9-01cbc8f79676") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("c95ed77a-48a9-4a32-b504-c0b69a4b193a"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6913), 1, new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6099), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 24, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6095), new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"), null, 0 },
                    { new Guid("267ea482-5c2f-4c1c-8ff2-d48590b3c64d"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6141), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 19, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6138), new Guid("2285f27a-ffdd-42ab-9f26-d2c70ba0ae00"), null, 0 },
                    { new Guid("2caba10d-d2f4-45e7-86ba-d2db43c36874"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6129), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 20, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6126), new Guid("65701a83-4e06-419e-b519-69bd6873b439"), null, 0 },
                    { new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6108), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 23, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6104), new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"), null, 0 },
                    { new Guid("84dbc11c-dadb-48e3-a267-d825c94efaf9"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6122), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 21, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6120), new Guid("e61149fd-7e1d-49ea-b988-acfc50e33f24"), null, 0 },
                    { new Guid("e4d0f32d-8946-415a-962e-695e55519a0a"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6115), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 22, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6112), new Guid("424c07b0-8c6c-489b-b129-9198baaf52ee"), null, 0 },
                    { new Guid("f7f67a20-d1b2-42e3-9d42-1433fd550522"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6157), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 18, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6154), new Guid("f41dd84a-fe43-4246-ad3c-5081968f1639"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0298ce8b-7940-4cf4-8e4e-4697551558a9"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("030dad44-e578-4607-8f06-594344b1b39f"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03e8fb73-2774-466b-892b-d9fea6ea75de"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("057c5fd3-9031-453c-b9fa-efdab3a6a987"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05e18bfc-2f04-4377-9ba9-67af7a6c3c89"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06576851-1b89-4f9a-af24-0681ad4606e4"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0913ab7e-0c42-456d-8ad1-c7a8c3b46756"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("094451f7-f288-409e-bc64-f1bf8f456a7b"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0959ba95-ef4a-4879-8500-ef23e3f9f061"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0aa0f49f-8196-4532-bc67-50d8774aab9e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c49f85e-6d48-4d0b-be44-5d2c3e46a421"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e2b764e-c3c5-45ab-a109-89c803aa27de"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e653c5d-d2ee-4a04-b798-4b059b7b50ac"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fa73f1b-3b55-4db2-95e4-e72aa29ea8cd"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10a749f9-8bde-460f-bad3-8fc2105c08cb"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10bded72-6524-4b1a-9c3b-26525d68b56c"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1153ec32-2178-442d-a4e0-18c4ebfaebf2"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("116e3aa8-e0b9-4d61-a2f0-d48ad61d248b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11e34a1a-a396-47df-b255-95e4ff21020b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12e9e87f-5fcc-423c-b4eb-5cd989cc8d7b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1305642b-ddc7-47eb-b6f6-25a7d79e34dc"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1407d0e9-f31a-4990-80f2-28d4b52c5e01"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15114317-8b62-484c-bb6c-17df847a466e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15958238-7db6-47e0-8286-798f211a5143"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15b02569-5c1c-44b4-b3b9-4c8f3a574d76"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("160f357a-d1bb-406d-9bab-213e68279545"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16fc7780-5374-4651-8ef1-61cf60755850"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1954f554-1684-492a-948b-d3acc6ea503f"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19bca009-9e54-41a3-96f5-2a7ddeab4c25"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a604720-1443-4076-a453-41972b656784"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b8b98c6-5fda-4553-869f-04489deb7b3c"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b9666da-5ddd-4684-840d-77f9fc6ace49"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f18bd99-7ef7-4f93-9f40-7184097f2542"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20126c8e-f350-464d-9a5d-bdd574e844e7"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("226fa531-93f5-43d8-a98f-79f971ffe237"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2405a779-9e91-480d-a2fa-6c274d1a792c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24124c12-0187-4b9f-a2aa-113bddc63ada"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25085e54-7d49-427c-85fa-0d7540e6542c"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25a17765-5d47-43db-8f0c-367a5ecf7762"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25e9aa47-a8c3-4849-8d98-8f44c29ab4d1"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26932824-891d-4604-b9b1-d9b732c308a7"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27c11fe1-f393-49ce-ae45-a11fb3e9c9c1"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2820cc73-6308-48ab-bd6c-f217cd8e75d5"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("284b3f83-c296-4d8d-8f6f-eda0e8ed89ea"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29ad314b-55af-4392-90ab-d35e2f64c072"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c6edc47-c83e-4b33-beca-ff1ba70e9937"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d209567-a1cc-498a-94c3-275a9333e66f"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2effe7e4-e06c-4a09-a18e-32ceb580b4aa"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f22da55-f305-4690-b09d-6f5f3e556f70"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f8ea3ae-f56d-4319-9c59-0301146e03be"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2fbc1687-a104-4ec4-a9b5-11a180d0ed4b"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33e42989-6473-4837-9e7e-7ad4f7de5576"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3403809f-60c4-4a01-9b6c-b0b685bb1355"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3553b7de-d4e1-41ee-8f1f-c8ae2fb7b9a3"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3658a694-f31f-4ed1-a2da-14d8b36388d2"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36693146-0a77-42a1-ab52-5c15a642ddb5"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("371acf93-795e-4733-8d79-ecb484431c43"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38f0d38b-8f20-43cc-9748-cd0b96728310"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b328b75-3ddf-4dac-adc9-7266bc96707e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b978965-a628-441e-afad-acef3831224e"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bec4ebf-922f-41e9-8f2f-688b4f9fe8bd"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c48c974-8179-4c2b-8938-dfffe61e1bb7"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c85bd80-3d2b-4518-8cfc-a16314aab7fe"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ca2663b-7cde-4de9-8bf4-12ff83181d63"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e0d2047-148d-4a11-b599-6c23bc1dd800"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ecc80e3-d267-42bd-ba74-fc017ab1b3c1"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fdef0e1-9027-4f6f-81ea-dd6e8eec6a73"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42cf3a09-b659-4eef-8277-4491fc950098"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43682ad2-86a8-470f-94a4-47126b949e88"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4603b573-e6f8-4fe4-8904-2c261cadcb4d"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46ff4781-7561-463e-af68-5762bbc0ef66"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49211a1a-fa8a-4360-b06b-cf366108267c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("492e1585-cc1c-481b-a7cf-abaf85a5c042"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a58bcff-b638-4241-a046-20df7b6ce01d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b773583-7244-4984-a6de-54eb17fd5196"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c9d05c9-361a-4f3e-bc30-3d9f23b0a11b"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d1d3620-b44a-42be-8f37-5821893f8f8c"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e09b9f1-8fba-4683-ad0f-96ae40471dfd"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ea11259-3931-4694-911c-a501c6ca290c"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4eda1d35-09bd-4039-b181-79f152fade32"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4eebcac3-d6cf-4166-a66e-04f049b9fec6"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53919fc2-a477-42df-a5a6-b2a09e520f42"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5433e546-3f57-4064-9133-b242c1978e05"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54cf1f66-2851-4cb1-a709-d1c8eb33b031"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55988e6b-afa4-4e3e-87a4-f4ab601dd2bf"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55f8b9ae-ee91-4588-991a-52f54e2182e0"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57419b68-0972-49ba-8005-268cc7c717f3"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c734282-31cf-4716-84ef-ca9dd6723795"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e085df4-b2c8-4651-8075-c6424815a133"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fc58952-8a63-4a4a-b7af-9743b86d2a57"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6022f202-52b2-4ed7-b024-2d3c02885211"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("612730ce-372c-4b18-aafc-1aa30529879b"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61c097d1-a9e5-49ab-890d-3e91c5bcf3e9"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62b61f89-06ce-499b-935f-0c9d0b53c96c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64346f32-eb3f-4261-ba4f-4eb4e4f23659"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65dc4d64-a030-47cc-a173-a38f647e7b5d"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67f1045a-3dd4-4d46-ab8c-22fdc49fec94"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("692539c1-c5ed-4134-a7b5-bfc31f206722"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6972c5bb-8612-4caf-8fcf-327ffa0e0ad2"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b4ed24c-0dc4-4913-b932-b14cfbf0a913"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b87da0c-0f37-41e1-b915-e1d7ed92a001"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c06db39-d7dd-4a56-8751-0baf0ac2b2f3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6cb903f7-657b-4080-8e52-0d32d95ac81e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ffc6990-b6d8-406a-be4c-21f1a93779ce"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7026feae-b0ea-485f-a0d0-d24927f0935c"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72c2779c-3055-4960-926e-0257f66b1dde"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73b6fbbd-270a-448e-99ab-ef87c02b422c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75310f06-783a-437d-bc0f-c6b26015b118"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("758f356a-12c1-44d0-9e43-770220da0f24"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77da2675-3f82-4468-b83d-88111c42a200"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78907c3e-9449-4cf4-92c7-5f1715d80154"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78f1e655-91ae-4f1c-a0b1-6433624e85c2"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7930dfa7-35a7-40f5-8e60-92c1abb38905"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79b97a9d-e2b4-47d4-9e28-e7410b009fe5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a5fb23a-2077-4809-9faa-5b6a64357a9c"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cfa7689-7fd1-4102-a01b-156c6391f834"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fa4ad10-5ed5-4e96-81e7-b000f067442e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("820e8112-102a-4c4b-a074-c7ce2bea429b"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82968295-af4d-4a24-bc0e-05ce83cffa56"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8415b417-115e-408c-a247-bb4c0990d0c6"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84a05109-90b3-423b-b072-f170fc04ced8"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("860aa50c-e832-48d0-b486-b866da1f80ce"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86882a98-cae5-4566-ba8f-9a0f4302b6ba"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86dd7d25-257a-48c3-8a37-1757455c35a7"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8992eae4-a624-4864-936e-a5a25e9a7fc4"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a666a2a-2f34-41ad-adb9-14182fd40b2a"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b047c10-af0a-492b-9767-1c97c8c7b0c8"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b20abe5-5714-44ac-962c-f730b4c39ea0"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b31f670-6bb1-4527-9e7f-3d3531e3f05c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b459da5-e1a5-4117-ae8b-64051443ecb8"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d4dbb61-f753-4eef-b02c-535848bb0a3e"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e4f1df6-0a70-475b-9f04-14ba3a12867f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e69ec79-2ed6-46cd-8eb7-2c6b13df3f99"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90235478-fdc2-49c4-8360-dafffd6d0491"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90a1cfde-360a-4fb3-9ba1-5069d185aca9"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91eccb5a-f459-4d49-8d1e-e440cc25c675"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93b021af-e4df-402d-9cb8-eaa0c47d5a2e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94056fa2-a4ff-4263-a6da-1cd0b66df25c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9423e05d-b4c3-4769-aeb3-1d46faf21d49"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96c5cbdc-0a42-4c2d-b8c0-957d7db616ee"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("991728f7-e127-4906-8874-fa9ad82f21b5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("998d8b1e-e4fa-4a8e-9b23-30c9b9d5e7e8"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99926d3e-744a-4e31-b980-73903f5f835f"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99a76e12-38d7-42a0-81cd-fc35aeb1c99c"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a3f0a97-43d2-4aed-83f2-62750d0891df"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cd5a829-e5b9-43c1-89f4-27f6c0be5bd2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d29014c-6b11-401e-9e5c-ea0978045630"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d45b47e-db3d-4a78-9a49-b0e222cd18e5"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9dce3f75-c2b9-400a-98f7-f6909b514d00"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a158e363-67ff-455f-9e7e-a885192bb501"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a23828a2-5470-4a3f-bdd1-6d2cc49b86f1"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a356205c-a6e5-405b-b896-f98ba1250b39"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a35ed728-1894-487c-b8cb-a6b92af339ba"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a41ad284-79aa-436b-97ae-e3c63088da43"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a497bcb0-f6ce-46bf-aec8-1ba4782577d7"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a56972ab-16b5-4cdf-bffe-f7b2ad81dc57"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a624bf01-d257-4e77-8061-73814545eb5a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a63a52a7-6b67-44b8-a403-f14fcf10ad9e"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a748e9d4-21b9-4bf0-a87d-3bb4e9b25529"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7bcd8bb-ecf3-4359-8d97-515653c7ec1c"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a815519a-9421-47cc-a2db-1c1dca9ff005"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a82f4627-f44f-4cca-977d-c56ba0e6d3f5"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a86afdea-6793-4d19-938e-20702504e4d9"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa69b0f6-7058-4d7c-aa7e-47a3cdbf2603"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab16422f-4320-4db8-8898-ac87d0aaeab2"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab97e561-aa71-4763-b8aa-9e4f62bf8390"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("accc46d4-43c8-40af-bb51-745b95434fc7"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae0f4c55-38c2-4b54-82b0-b88fb7fcdae9"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae146f19-1b05-45e2-9d98-6c8ec61734d7"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af27dc5d-a8cc-46cb-bc7e-d342b5441407"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af6c7f74-a191-45f0-8d39-146af98f48fd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0efe870-7f54-4596-bff4-33c31d47aa5e"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1dd3fce-571a-4fa5-b097-366440f3cfe8"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2289ebe-b4ef-4ecb-827f-cb89376f61a7"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2d6b9a5-4527-4eae-98aa-acc626a55134"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2dd15e3-0362-470a-8ad7-f6ed3cb13f86"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2f7a370-4dee-44a2-95fd-8cd103b041a5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7a28afa-5e8d-4c2e-8904-639afa1779df"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b830f5da-4caa-40b8-a11d-0e64da81fd49"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b833e7d4-be2f-4a6f-aab1-2ac3d075b943"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b87af90f-df41-40a0-96c7-06087070df5d"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9ef45a4-026a-4db3-b859-3583e70345e1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bb442e5d-92c0-472e-ba73-ec6c5eedc270"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbaf6bc9-b917-42bb-8984-fe59631e5384"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbcd147f-cbef-4000-b13f-0aa6d4ba8516"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbed937b-0a90-4807-918f-fc073e60cc78"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be9f27f1-98b0-452d-844d-c9d6d1ef9efd"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bec3bde9-a21f-40e8-b0ee-f346ea580feb"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c01a50ce-bcd3-4fdd-9967-ac5e7989e288"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0952191-6fbd-4a24-bc3c-6c396dbb4fe4"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0e818a6-d164-46f8-8bf4-fff12fec60e6"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3088f6a-191a-49f4-9560-8a56edca8b7f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3dc5aad-6745-404d-a73a-756a47f268f1"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4d4e47a-8465-4922-9d6e-d4730986cd39"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5f81c59-2add-4a0e-829a-5d8e833008a4"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7e1f7e2-af02-4ac1-a813-bd65d857fb41"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7fc7ef9-f158-4134-9494-c75c558a5b91"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c96accf2-32da-4fac-bcaf-83b785b8d0ee"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cad66e04-c308-4a5e-945b-859ac8a679bc"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc81b986-bd9e-40d1-89e4-84451fc1c30e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cee6a926-b2ca-4d26-a3ef-aae8b3f4daf8"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfb89d7a-b4a1-4063-ac65-cd7f879b270d"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d237f53c-d3df-48ef-b374-5aab506e5e49"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2b7cb1a-d57a-4129-9bb5-bfd7be1905c2"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d315899a-e1d6-4f39-9d37-f1eca2f67361"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3680103-19ef-4060-8fa3-0f9237b9d455"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d465be8d-fed2-486e-b647-a3fbef466fca"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d469dd17-d164-41e5-97dc-4da723ce441a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d48682ef-8404-4b27-822f-71f3f15e6bd6"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d704f46f-f7f9-4d26-9327-8193c7701afa"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d81672e6-7275-4cf0-a791-e0fdc46b96fd"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9b77c8d-9b5f-45b1-b37e-7368ab49c066"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9ee1b5d-2cb9-473d-b0b5-8a8fb95410fe"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dce7c810-6469-41e1-a275-817287368179"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd25c3c6-f639-4165-b0f5-e183cb29c23d"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd7d6971-fd6a-42c5-8fc6-1df41657ab50"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de44b01b-c87a-404a-8b69-3adf04c12ffe"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df3a1d78-7467-41e4-9267-99f045114eee"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e06fd387-b4bf-469c-b694-823a5c12f387"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e18f5f14-e759-40ca-a4d0-a07f6cad8346"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1fef5e8-b126-45c3-a153-75f7f74d4fbf"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e338c113-cf04-49a0-86e7-841274fad4ac"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4967a9e-16a1-4bc0-8620-93b6354c0420"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4b2e925-0ae7-4b03-9867-fb2c5c5b21ff"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e59beef8-6bc1-416f-8bfd-e857afcfdc62"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6a17191-235f-4e75-b795-3101fac183a2"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e77dcf9e-cdfe-4683-be90-3e6eddc657e6"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8e7c9d0-73b9-4ba7-abfd-c57d9b8af414"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea93f4df-b587-4009-9dcb-bbeaa4090ff1"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea9a6357-0ddf-4869-b00a-b532ee214e25"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed0d2b09-a5aa-4010-96c5-b5310ca8d6e3"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed27dfb3-2762-4ec6-804e-d52a21b48691"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef2c7175-01ce-4c31-b70d-be918ab69584"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef596cc4-63ed-4ede-9cb2-e89af07f9219"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef7d22e3-50cc-41d6-8496-63ec3a7105fb"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0fdb10c-7ccb-4428-8f20-9fa70ba4fcc0"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f11685ad-ebea-4bd6-8f9f-d6c113ca769b"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2d72d68-9df9-435d-a983-d6a85a2e76ff"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3c15a59-3947-43f4-9fa1-077dafe5522f"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3e40213-d36c-410a-bc97-3dff183713c1"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f41c3fd7-9890-4464-a072-8ba6e6ebfb17"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f433cb19-f6e8-4a80-85bf-c19d8d33ad15"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f48714f4-3172-462f-8e88-451ec858f10f"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f49c0dbf-8f8b-4600-9ec3-ac7637e22814"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f53c3deb-a6a6-4d41-a7b4-552fb243c43b"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f59401ac-d038-4494-894d-58d80a93fd4a"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5ffe0c2-0e7c-4d8a-9ca2-1005ad926dbe"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa7d288e-7c33-43e3-98e8-9e7afddd8835"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdfafe34-ad08-4df1-8707-a394fb05675c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fff707df-d904-45f0-a628-bfafb6b396dc"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("9eea6f2f-0197-4a42-aca8-a7968872b28b"), null, null, new DateTime(2024, 12, 15, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6049), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 14, 23, 4, 10, 318, DateTimeKind.Local).AddTicks(6043) },
                    { new Guid("acf35039-4425-4b35-8c9b-1cc8fa6f8f39"), null, null, new DateTime(2024, 12, 16, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6061), null, null, null, null, null, new Guid("41056346-3a8e-4010-bf53-f55417208f99"), new Guid("11714696-0dc6-4369-927e-4300aeb42515"), 1, new DateTime(2024, 12, 14, 23, 5, 10, 318, DateTimeKind.Local).AddTicks(6059) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("21c3ffc3-e718-427f-a29d-1e709ecc2256"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 15, 1, 3, 10, 318, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 12, 14, 21, 3, 10, 318, DateTimeKind.Local).AddTicks(6976), new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd"), new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), new Guid("9d16fbb6-2377-401d-8f47-8a232b98a371"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6822), null, null, null, null, null, 4 },
                    { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), new Guid("72f07a1f-568f-45a5-8754-882aa8f6437c"), null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6818), null, null, null, null, null, 3 },
                    { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), new Guid("1bebaaa3-d36d-4425-8257-d0cd5653eed2"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6815), null, null, null, null, null, 2 },
                    { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), new Guid("05532b57-9e63-4346-80c3-a8e52c63f41d"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6809), null, null, null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"), null, null, null, null, null, null, null, new Guid("41056346-3a8e-4010-bf53-f55417208f99"), 2100000m, new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"), new Guid("116e3aa8-e0b9-4d61-a2f0-d48ad61d248b"), 2 },
                    { new Guid("4e21eb2f-313a-490b-bc27-0f90c225bd70"), null, null, null, null, null, null, null, new Guid("336e0a18-355c-466a-8233-e15f6389c966"), 3100000m, new Guid("e4d0f32d-8946-415a-962e-695e55519a0a"), new Guid("7fa4ad10-5ed5-4e96-81e7-b000f067442e"), 2 },
                    { new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"), null, null, null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), 100000m, new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"), new Guid("d9ee1b5d-2cb9-473d-b0b5-8a8fb95410fe"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("0113e16f-3c57-40bb-a790-b8a726358762"), null, null, null, null, null, null, null, 60000m, new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"), new Guid("014c866d-d5ee-48c8-a990-36f25b611283"), new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("56336b15-1668-4323-9296-3eebea21bb4b"), null, null, null, null, null, null, null, 50000m, new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6866), null, null, null, null, null },
                    { new Guid("375e4e5e-35a9-4915-ba0c-b4c29d7dcb40"), new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6876), null, null, null, null, null },
                    { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), new Guid("4e21eb2f-313a-490b-bc27-0f90c225bd70"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6862), null, null, null, null, null },
                    { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"), null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6858), null, null, null, null, null },
                    { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"), null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6853), null, null, null, null, null }
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
