using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
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
                    { new Guid("4e3cb2df-dc6e-4a6a-b712-b50f75243e45"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("08a04980-8d69-41e7-aa04-c6db30e52bed"), null, "mua tại quầy" },
                    { new Guid("bb4cd6a7-b1c7-4445-8bbc-35800db90516"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("df17e7f0-3335-474e-a3a5-3c6a6e9309e0"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("3efc46cd-17bf-4954-879f-d44cd55a018c"), "11:00 PM", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5304), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5299), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("07e56a61-26a4-4233-8f76-3442e1d170ad"), "Vương Quốc Anh" },
                    { new Guid("1bee33d4-667e-414d-b983-954f43cc4497"), "Hàn Quốc" },
                    { new Guid("35d1602a-9f82-4f5e-a90c-2f52de8ffb4b"), "Trung Quốc" },
                    { new Guid("3937f089-9dc5-4432-8009-4226bc820945"), "Úc" },
                    { new Guid("8cdf5849-3a81-453b-a295-b55747cabdcd"), "Việt Nam" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("9cf4c512-596b-47ab-8f8f-744b3962a4e8"), "Hồng Kông" },
                    { new Guid("b448ff01-4bf9-428a-970d-4b8024a76d6c"), "Ấn Độ" },
                    { new Guid("cf2f0bdb-f786-4eee-ba7a-3a3d4cb42f4c"), "Pháp" },
                    { new Guid("d6d9705a-117e-46c4-b91f-0d62d145f8dc"), "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("4ed7e092-2388-4ee0-a1dc-627f15a375aa"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("56be9675-33fc-4f5d-a279-ad1b51fefb71"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("5f345c71-2564-4352-af82-7f9341f6c1fc"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("66e3321f-44ba-4512-8afc-04e8f0c9cc33"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("6f348b1e-0141-43ea-bfd7-28ae67a96e07"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("adac0c1d-b734-493f-a5a7-b959e9a2dc3f"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("ee79f61e-f1da-48d9-bc66-3b997b790364"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("f201e8a4-5891-4ad1-9e3c-870db90bc1bc"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f31795c7-6a8f-415d-a1c2-c1e5fa15974c"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("8d82a3ce-0a9e-4a86-a490-700efa299466"), "Combo 1", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7408), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("9e225ad7-9e54-482c-99d6-0b89c3c5b590"), "Combo 4", null, new DateTime(2024, 12, 19, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7420), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m },
                    { new Guid("c61e4c08-0a1b-4fb0-a8f4-4c7be54bde21"), "Combo 2", null, new DateTime(2024, 12, 21, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7412), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("d445d49f-dcc1-427e-a920-54e34a6d3f9e"), "Combo 3", null, new DateTime(2024, 12, 20, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7415), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("066fd802-bdb5-4017-8881-af63b9919f06"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("08fc61ee-c252-4f0c-b541-63067e106900"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("13f4f983-df84-4a49-8726-365420789a2a"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("384a311e-c3b9-438a-bcf8-12ea14964708"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("830e5c95-6fb3-4674-97c0-65dd69e73b62"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("84b47ee9-ee64-4e69-817a-a65db806bc06"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("a911a460-7e61-41bb-aa4c-7d61804df42b"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("c0373a74-f97a-4a64-b6c6-e9b796db7229"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("d3990b80-3f0d-418b-8b33-e5f514e4bf53"), null, null, null, null, null, "Lãng mạn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0ad5f5cb-eb08-40e5-8b55-82be0bd2c6e2"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("1b2715f5-f2fe-4f48-ba83-a7b3539c4887"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("7f069cb5-fb17-46b8-8411-c2f307f3a256"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("81c05a6a-5e18-4ce8-9738-9c58b36e2078"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("d5ae7b1f-3fd7-4dec-bd9e-fcd4e839ba74"), null, null, null, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("08de0305-c69c-4b3d-b6aa-7525260ef4f3"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 },
                    { new Guid("2f7241ec-1852-4d4f-86b4-6bf0e30ef71b"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(1430), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(1467), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(1454), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5257), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("587ff198-12d1-4eb4-9ce7-909da4af6bcb"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5259), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5251), null, null, null, null, null, "Ghế thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("12f9af2a-ddf6-4456-a648-59975e94707f"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("1b004116-825e-47bf-ba9a-3b775936d347"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("34278222-6c93-48a4-b435-1f84d09e7cb0"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("49fe4ff9-8983-47e2-b0a0-784dc7e4d34c"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("525b63de-b585-47f5-8908-20f39c59786d"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("917826bb-8abd-406b-9e40-610bc5e7220d"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("b8af2995-d8af-4d2e-af15-b82c0cba76b7"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("ce413f67-00ae-4a25-b7e9-931dcc615202"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("d9310fbb-3ae6-4b02-80bd-e4e9ad77ef7a"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("e4a30344-57f3-43c9-b494-0731ab7a922e"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 }
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
                    { new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6764), null, null, null, "Một bác sĩ chuyên khoa tim nghi ngờ cái chết của con gái mình sau một cuộc trừ tà, tin rằng trái tim cô bé vẫn đập. Trong đám tang cô bé, anh và một linh mục đã tranh cãi về sự thật, mỗi người đều cố gắng chứng minh lập trường của mình có thể cứu cô bé.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "ngaiquy.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "DEVILS STAY: NGÀI QUỶ", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/4d7xzz0cTVw" },
                    { new Guid("2037b062-4a07-4f33-8bde-be2ba5012be2"), 13, new Guid("1bee33d4-667e-414d-b983-954f43cc4497"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6909), null, null, null, "Lấy cảm hứng từ giai thoại nổi tiếng của nhân vật được mệnh danh là thiên hạ đệ nhất chơi ngông, Công Tử Bạc Liêu lấy bối cảnh Nam Kỳ Lục Tỉnh xưa của Việt Nam. Từ con trai của chủ ngân hàng đầu tiên của Việt Nam trở thành \"Công Tử Bạc Liêu\".", new Guid("4ed7e092-2388-4ee0-a1dc-627f15a375aa"), 113, new Guid("13f4f983-df84-4a49-8726-365420789a2a"), "congtubaclieu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "CÔNG TỬ BẠC LIÊU", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/wqJXnO_TKpY" },
                    { new Guid("6b463723-45cc-44d5-9645-edb2f154aa2d"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6990), null, null, null, "Đây là một bộ phim hài về gia đình. Phim kể câu chuyện về một người đàn ông là sinh viên y khoa ưu tú quyết định trở thành một linh mục.", new Guid("5f345c71-2564-4352-af82-7f9341f6c1fc"), 110, new Guid("c0373a74-f97a-4a64-b6c6-e9b796db7229"), "chuyennhabanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "ABOUT FAMILY: CHUYỆN NHÀ BÁNH XẾP", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/X3SY9XUlQAA" },
                    { new Guid("8af796f9-ac9e-4409-ac3c-b6150a7dd101"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6935), null, null, null, "Trong văn hóa Java, Sengkolo là một thực thể tiêu cực thường ám ảnh con người, mang lại vận rủi và tai họa. Vào đêm đầu tiên của Suro, Sengkolo di chuyển để nhắm vào một số weton là con mồi của mình.", new Guid("ee79f61e-f1da-48d9-bc66-3b997b790364"), 99, new Guid("830e5c95-6fb3-4674-97c0-65dd69e73b62"), "tetamhon.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "SENGKOLO: MALAM SATU SURO", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/-Sux3ihKodI?si=bbzqRn3w7kxqDaEi" },
                    { new Guid("9b4e7710-3f37-4ace-b6f9-4cb4616e455f"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6970), null, null, null, "Lần đầu tiên nhìn thấy cô gái yêu nhạc rock xinh đẹp Jinny, cậu bé Song đã yêu. Chú Pong – một cựu Rocker giúp Song lập ban nhạc Bad Boyz Band để Song có thể mời Jinny tham gia. Tuy nhiên Jenny lại lọt vào mắt nhà sản xuất âm nhạc tên Arm.", new Guid("4ed7e092-2388-4ee0-a1dc-627f15a375aa"), 110, new Guid("13f4f983-df84-4a49-8726-365420789a2a"), "tretraukhongduaduocdau.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "BAD BOYZ BAND: TRẺ TRÂU KHÔNG ĐÙA ĐƯỢC ĐÂU", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/GKqrTQGHE3s" },
                    { new Guid("ad685b90-6939-4617-a4a7-94ad6f4c1ac6"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6999), null, null, null, "Nakrob, một kẻ lừa đảo bất động sản trẻ tuổi, phát hiện ra một khách sạn trên sườn đồi bị bỏ hoang gần bãi biển. Nhìn thấy cơ hội, anh ta quyết định biến nó thành một vụ lừa đảo khách sạn sang trọng.", new Guid("ee79f61e-f1da-48d9-bc66-3b997b790364"), 100, new Guid("830e5c95-6fb3-4674-97c0-65dd69e73b62"), "chayngaydi.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "404 RUN RUN: CHẠY NGAY ĐI", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/jS6TZkBB0lY" },
                    { new Guid("de348493-9128-4e17-aca2-c587a3100b53"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6777), null, null, null, "5 học sinh nghiên cứu hồ sơ cựu học sinh của một trường học bị chiếm đóng về những trải nghiệm siêu nhiên và các cô gái mất tích. Người hướng dẫn của họ tạo ra những sự kiện kỳ ​​lạ đưa họ đến một cái cây cổ thụ, nơi mà hiệu trưởng vô tình đào được xương.", new Guid("66e3321f-44ba-4512-8afc-04e8f0c9cc33"), 81, new Guid("13f4f983-df84-4a49-8726-365420789a2a"), "xich.jpg", new Guid("0ad5f5cb-eb08-40e5-8b55-82be0bd2c6e2"), null, null, "BLINDING SOULS: XÍCH: TRÓI HỒN YỂM XÁC", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("e6a06e15-ff13-4656-af71-2cee1a8aa05a"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6921), null, null, null, "Một cô gái khiếm thính và một anh giao hàng tìm thấy sự kết nối bất chấp rào cản giao tiếp. Họ sử dụng ẩn dụ về những chú chim nước và cây cối kiên trì để tượng trưng cho việc vượt qua những trở ngại trong chuyện tình cảm và dẫn đến sự gắn bó.", new Guid("5f345c71-2564-4352-af82-7f9341f6c1fc"), 109, new Guid("c0373a74-f97a-4a64-b6c6-e9b796db7229"), "yeuem.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "HEAR ME: OUR SUMMER: YÊU EM KHÔNG CẦN LỜI NÓI", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://youtu.be/JzY-5ZtVD88" },
                    { new Guid("ea818e95-699f-4bfc-8fbd-f69c1497bb6d"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6948), null, null, null, "Phần hậu truyện của Nhím Sonic 1 và 2, đồng thời cũng là phần phim liên kết với Knuckles (2024).", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 100, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "SONIC.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "SONIC THE HEDGEHOG: NHÍM SONIC 3", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2gFjV9v7QVE" },
                    { new Guid("eedc1e2f-0d13-4dc0-91ac-3aa8a4116f44"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(6957), null, null, null, "Bộ tứ báo thủ bao gồm Chét-Xi-Cà, Dì Bốn, Cậu Mười Một, Con Kiều chính thức xuất hiện cùng với phi vụ báo thế kỉ. Nghe nói kế hoạch tiếp theo là ở Đà Lạt, liệu bốn báo thủ sẽ quậy Tết tung nóc cỡ nào?", new Guid("66e3321f-44ba-4512-8afc-04e8f0c9cc33"), 120, new Guid("066fd802-bdb5-4017-8881-af63b9919f06"), "botubaothu.jpg", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "BỘ TỨ BÁO THỦ", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://youtu.be/2k0jK_sWmwE" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5357), null, null, null, null, null, "Room 2", 12, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(5352), null, null, null, null, null, "Room 1", 12, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("03943d29-da79-4132-8b53-cec2676de52b"), "Hà Nội", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(1710), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("04404f15-dec1-4270-b9f3-aa08d445b89d"), "Đà Nẵng", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4118), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("04e42b08-a4a5-4c36-bcf4-cab72476c630"), "Hà Nội", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(2482), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("173c89f0-a914-4cd8-b857-15689a3c1627"), "Thái Bình", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4415), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("18087c8b-2f56-460e-81af-9f8f73d1f0d6"), "Hải Phòng", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(3879), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("19ffd207-9487-4f88-80d3-8464492de89a"), "Nam Định", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4503), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("231a8e72-a922-4dd9-8237-423b9c24190c"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4167), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("601475ed-9906-47c8-afd6-39dbb12b9584"), "Nghệ An", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4208), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7b06aeb9-e9a7-44ac-b2d2-f6d3c73ef9ee"), "Bắc Ninh", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4370), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("983ee067-9141-4e18-a551-1c308e276a24"), "Quảng Ninh", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4568), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ca449a4b-9197-4525-b700-979970843fda"), "Hưng Yên", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4466), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cde536d4-290f-4f33-bedb-777440cd6ef8"), "Hà Nội", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(4604), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("2d93567f-c3f3-4ecf-b89f-ae22dbc5c681"), "BILL009", null, new DateTime(2024, 12, 14, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7541), null, null, null, null, null, null, 0, 350000m, new Guid("ca449a4b-9197-4525-b700-979970843fda") },
                    { new Guid("3a5f6f5b-867c-4438-8f3d-3da81ff13f9b"), "BILL001", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7508), null, null, null, null, null, null, 2, 500000m, new Guid("03943d29-da79-4132-8b53-cec2676de52b") },
                    { new Guid("57e7c05e-87f5-483a-84eb-15b024de8c03"), "BILL002", null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7512), null, null, null, null, null, null, 2, 300000m, new Guid("04e42b08-a4a5-4c36-bcf4-cab72476c630") },
                    { new Guid("5e41c5fb-7f05-45f8-8863-9e8d505ddc31"), "BILL010", null, new DateTime(2024, 12, 16, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7544), null, null, null, null, null, null, 2, 700000m, new Guid("19ffd207-9487-4f88-80d3-8464492de89a") },
                    { new Guid("77401f5f-942f-4156-9ce8-9b69e73387ca"), "BILL0122", null, new DateTime(2024, 12, 18, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7530), null, null, null, null, null, null, 2, 680000m, new Guid("601475ed-9906-47c8-afd6-39dbb12b9584") },
                    { new Guid("784a21e7-2256-4946-bf24-899f645f8f9e"), "BILL008", null, new DateTime(2024, 12, 12, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7537), null, null, null, null, null, null, 2, 450000m, new Guid("173c89f0-a914-4cd8-b857-15689a3c1627") },
                    { new Guid("a9dfaec2-d30e-437f-9ebf-8eee5aac3b5a"), "BILL007", null, new DateTime(2024, 12, 17, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7533), null, null, null, null, null, null, 1, 800000m, new Guid("7b06aeb9-e9a7-44ac-b2d2-f6d3c73ef9ee") },
                    { new Guid("acb24aa3-a5ef-4a45-baa9-025963adc97a"), "BILL006", null, new DateTime(2024, 12, 18, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7527), null, null, null, null, null, null, 2, 600000m, new Guid("601475ed-9906-47c8-afd6-39dbb12b9584") },
                    { new Guid("cab620ad-153d-4042-bb7a-96b9da2979e8"), "BILL004", null, new DateTime(2024, 12, 20, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7518), null, null, null, null, null, null, 2, 200000m, new Guid("04404f15-dec1-4270-b9f3-aa08d445b89d") },
                    { new Guid("d386125e-7757-46ee-9436-f27ee980a427"), "BILL003", null, new DateTime(2024, 12, 21, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7515), null, null, null, null, null, null, 3, 150000m, new Guid("18087c8b-2f56-460e-81af-9f8f73d1f0d6") },
                    { new Guid("f205e2e5-5e72-4c54-ba30-5a5978aa0bd2"), "BILL005", null, new DateTime(2024, 12, 19, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7521), null, null, null, null, null, null, 2, 250000m, new Guid("231a8e72-a922-4dd9-8237-423b9c24190c") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("acbd8e42-1d49-4023-aa6b-e96c657c4fa1"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7736), 1, new Guid("03943d29-da79-4132-8b53-cec2676de52b") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("040dc696-b3f5-4d53-88c9-5f8213a93274"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7147), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 27, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7145), new Guid("917826bb-8abd-406b-9e40-610bc5e7220d"), null, 0 },
                    { new Guid("17d398f0-1c20-4496-9914-42fdcbf4332a"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7142), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 28, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7140), new Guid("525b63de-b585-47f5-8908-20f39c59786d"), null, 0 },
                    { new Guid("24e9f29b-479c-465e-9eab-d2d359748b0e"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7151), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 26, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7149), new Guid("ce413f67-00ae-4a25-b7e9-931dcc615202"), null, 0 },
                    { new Guid("3e24ddf3-29b4-4c74-a0a8-925d506eccbe"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7119), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2025, 1, 1, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7116), new Guid("49fe4ff9-8983-47e2-b0a0-784dc7e4d34c"), null, 0 },
                    { new Guid("7fe94c33-8ad5-4bca-bc27-4b3c808faf6f"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7137), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 29, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7136), new Guid("1b004116-825e-47bf-ba9a-3b775936d347"), null, 0 },
                    { new Guid("b5593e5f-eafb-42a9-b801-fa3dcb511dfb"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7129), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 31, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7127), new Guid("12f9af2a-ddf6-4456-a648-59975e94707f"), null, 0 },
                    { new Guid("efb45afd-7b33-47de-9554-97e9f4d1b0e8"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7133), false, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 30, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7132), new Guid("e4a30344-57f3-43c9-b494-0731ab7a922e"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("002c38ea-6bdd-4cdc-adb4-09be42b10f42"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("00307fda-d03e-4a42-ab0f-0782284c76cd"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02207771-2005-4454-8684-bd4ed32a2655"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("023ee449-52b4-4250-a300-e5561f40b83b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("026c7482-7caf-44c6-99d5-c9139e25bc16"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("02dcb6fe-9388-4374-b223-39e72335c8dd"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03c8116a-072f-4a88-b69d-16117eb98e22"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04031f06-eee2-46ac-b1e4-ba187a02bd64"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("04e663a5-7ed5-4664-a798-485a70b06cb4"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("060d0f85-6e63-4167-8fc2-f48dbdf07c1d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("067480e2-0459-47fd-bca2-2c65e673b2c8"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0798fd39-dff5-44e2-810f-fb53fd42157e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09de58e4-f17a-40b1-8d87-970d1e419726"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0cf4798a-3758-454d-a192-fff949a15fc6"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d8763f1-631b-43c5-af5b-47917350da08"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e0c8391-fc9b-4f46-a736-1834f995ab9b"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0edf6530-05eb-4508-8faa-f6f3f4cb343c"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0efcb989-e5a6-4b59-a7dc-74011ebb594a"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11dd9117-747e-487a-93a6-b5b09308b6d0"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1322c62a-97dc-4d28-b95a-ff1d8183d68b"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1484a2b1-ce7d-4ae4-b52e-cf934bf24732"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("158b4329-31ca-4065-ba30-fd5a5949f1d8"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15b24bc8-41d0-4bd4-8830-686c070fb478"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16652452-e0ed-4cd0-9999-f48a5f7299ff"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("166a10c1-4db9-4376-a2df-eec483102684"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("178abd10-aaa6-48ca-a7b4-813f726468fb"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("18eba849-bc97-431e-ba44-3d67f7880796"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1980d980-3338-4811-9e61-9ae8f9b97846"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1bed997f-485a-4c00-9be6-59e933fc37be"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c08d14c-a7e6-4392-b9a9-a1907de6d300"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c1b31b5-e8d5-418d-9cf6-55b4ea5edd57"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c6d5949-22cb-44fc-86aa-ee0d3581326e"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e0d3fde-253d-4923-b771-271a32948101"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20f951a9-9ccd-41f0-9c07-090d318a93f4"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("217cf7b3-e5e4-478b-9da6-743780e97637"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("21f24c15-40de-4488-8f7d-cc6688b9321f"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22960ef8-fc16-4f79-bfff-7daffdd0468e"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23f0b8ea-6dde-4531-8c36-8438dbff9235"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("240593d9-3c4e-42a0-89fe-76e606093f7b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("259e3dd7-e59e-4a28-a998-5a58ad3fb50a"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25f96ae4-2c2a-4de4-b9a9-3b728d190381"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("268d287d-d465-4b6c-81d4-d25fe12d74a6"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("286d6bf0-6eac-47a8-93de-87b31aca6ecb"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("288e2078-6720-4b87-90bd-91ceb13fe810"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29c4226b-8175-47ea-a07c-05f9b895e429"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2ca1de6f-e0f5-4bbd-a3ac-12425ff2fde9"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2da5dbe0-86e9-40c4-8c04-f7eb96dcee98"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2dbb8937-5920-41c1-9467-81726cf01cef"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2df5445d-eec3-4dbc-9bb7-03d550857ea9"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f885e09-56b5-4496-8fa4-b60e616313de"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3026786e-c6ab-4e53-a9a7-9502cfd4bf48"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3143e0e5-7cd9-488f-8abb-32c73c348d12"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("31a9031a-e535-43b6-ab0e-47efe418da38"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32a4920b-5a39-454a-9003-a8c9532fd0ed"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32cac87a-6b8e-4cac-a1dc-48b80ba6418a"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("342d4697-eeb4-45c6-bc45-bfe71acf9630"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("349ff66a-5326-4688-8ccb-b4bdf9399a37"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36d6fdb6-0c38-4656-8c55-b31bafd7a548"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("37d4189b-dc7c-4ba0-82be-cfbc5aacb0aa"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3851de08-4563-4e8e-a2c6-9070a50e6681"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3aab7ddc-075c-47d5-8e40-132307a93f11"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ab6b89c-9668-45b9-8042-37658ad06b3d"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ab99b3f-5ba0-47c9-9c59-052227e50bc7"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bb3c0d9-2694-4131-8f81-67f79244bb03"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3d306b0e-b9c0-4841-8c90-41a1178f26d4"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e42e853-de4a-47c6-bd83-9b1fcd7d79b7"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e5b2bb3-8190-4829-980c-ee4aeb33341d"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("400a2164-3ac1-4106-8bd2-98c0cd121a58"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("401d406b-ec38-432c-988e-457c17d45c4e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("411e6e2d-5065-4c65-bdf3-65149b22d745"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("41d61462-364b-4f0d-bfba-f98b1c2b74aa"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42309f3a-a663-4a8d-a9bf-d09e9eac0973"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("44a0fb37-3ab7-4768-a25b-af542e2bfef4"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("45f42bd3-9e42-42ee-a69d-be9de88e4370"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4622dc21-3add-4b1c-8f94-ca53dad53c78"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("479e550a-f958-4622-b085-8dc660e2b572"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("47b5fb6c-32bf-4c83-97ca-7381fd2ea781"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4899bff1-59c0-4af8-ab82-8ce5741b6dd8"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ec710b9-08de-47b0-b666-e8723cd9f731"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("50bded8c-b41f-4554-98d5-217d76aecfbd"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("51ffbb73-638b-4579-9e43-6ce99fa5aa09"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52b979ba-3826-4743-a607-9e0376bfdfa9"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5348f6a3-2766-45ec-a79f-a704dedc1200"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("566d3166-9293-41b7-8e78-c94a5a8b36fd"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("56f78485-be55-4264-87fe-dece3cc5ec67"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5776da69-3fec-4313-8a4f-d9de16b69833"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57a3ce6d-78a3-44a0-809f-7553b0a6c2ee"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("59be8ec1-1541-45a4-b93f-b3b3ef5a81ab"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5acd71ac-7b15-4442-b9a9-7f0fc42cabe8"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c7bdd7b-a1b9-4758-ab8f-bce8b702b00e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c7ec12f-36f6-4c72-ba7e-89ad7be95a06"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5cea5e43-5908-4497-89e5-47c89339a922"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fc3a44d-88e2-4285-a6e1-5fc52f985822"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fdbfc16-dbf6-4806-b883-4f3e4616c186"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("60e3a4b5-ffdf-4471-8052-c150950ca53b"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61484f03-b17f-4ad2-b135-adc2813963d6"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("617a1e92-456b-44d6-bc9c-ff5fa7ddb9eb"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("618bf822-36ed-4a23-a025-d678d80755e2"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("630e51a2-568b-4528-b3a6-2a7ff250daa2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("641207c7-d21d-453e-a0fb-9a206f8290e9"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64dbfe26-4397-4936-95ea-4c6a73cb32d9"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("650829b8-7189-4798-aa5d-4e2bde9a9566"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65e61707-b15d-404b-b9b5-95b787297e7a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6605e107-fad3-41a4-9a2c-17138254e67c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6721e23a-0a8c-437f-acb9-543e65dfff4c"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("673e3f96-9de4-4bd6-b36f-3fa81e58d2e2"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68339ced-d90f-4eab-9a05-15835caba099"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("68da3598-7fe0-4b7c-bbf3-c5b1c7d83d9e"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("698ac1ad-c29d-40e4-8b84-c11535edaa2d"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("69d29890-3554-437f-97c1-5dce386b1fb2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a22b372-f881-4b94-b265-e50fa40b68f6"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6a26c5b0-10ea-4b3d-9091-54841cd743af"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6acaebcb-959b-4f66-b38a-667ad30e8b77"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b49fa55-668f-4c31-9140-243b31fc1a01"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e5d2f17-8af3-418e-8b1c-649d3b28fca1"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ed7ea79-8e14-47f3-90ab-9785a885e7fd"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ee99443-096f-4335-81df-27c4e78b8eda"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f0b49b7-6b33-48ef-96f7-0757506ab880"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("707308d8-181d-4806-9315-5a3610b0b84e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70f27c8c-d3e0-4a75-81f8-0492358e03d6"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("70f9439c-bb22-4586-be60-034fedbee1bf"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7125d38a-a3d7-4e0c-8731-c8d1b9050454"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("727515d6-d738-4375-a4a8-391fa839d9aa"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("731058c7-6ef1-477b-8542-c22872d617d9"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73a744b3-07e9-4bdb-9c6c-2f7ccca31480"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7585eebc-e88a-475b-9ff2-36c01885632f"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("76820592-3b71-44cf-8e5b-0d0badd967d5"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("783821c1-79dd-4530-942c-282d70a41d0d"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78bdf4ed-ca57-490d-b33c-5a3403eb4354"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78fca3f3-f68e-4382-a0e0-cb2adc5b0f20"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79067d14-9d34-44f2-ba40-3780dda466a4"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7941d112-d7ff-44ca-8f57-cd75c3d56e28"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b67bc7b-d207-4eec-b045-00cf1bc8a1f8"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7b898e46-a874-4d30-9cea-a1be91ff2fdf"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7c2a8c01-a6d5-4ae5-b76b-b998283f605e"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d614aef-5b63-4dc5-ad67-6a85d18c7242"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8223e2c6-4254-420b-82b3-b98b68fecdd9"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8382bae5-9878-4972-9c1c-fcf2a7fec681"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("852e6876-c7f4-4afa-b622-0d1afa0c6e54"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8533e3d6-6877-4f80-8875-e48cbb15bd60"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("85606fce-604c-47e9-b0b6-6ad675677e52"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86281bb2-2bfe-4a59-b523-7846c00139e7"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("888f92f9-a93e-4ab6-9b25-8a115171bb4a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88ba5471-cfa0-4bc9-bcae-c9e9b43dba9e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c51880d-e4fb-4360-97cd-2f013c9ff90c"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d398a9d-5e6c-4d3f-b8d3-2ba61b64788c"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e64b27d-1891-4d11-ab04-10a9e4d8bab1"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e66627d-e5d0-458a-94b1-a09a2f8e9ea0"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8ececad7-7164-4c69-9fa8-be8ae1855172"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8fa52b13-16f0-4a9d-b292-8289f7506875"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("904d36c4-5bcc-4c77-9155-4d5cfb72ab3a"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("92eaa0df-c595-4e27-b92e-148d52e9e5a4"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93a65a31-1cc7-4798-a1f3-0ed55f7e9325"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93ac6b66-d0a5-41f7-8fbf-03e70e2a5be0"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96cc0755-66c4-4b0b-906f-fa4ab80dbf76"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("97df86d8-92f3-4f30-b78f-f64f9772e4af"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("999b678c-3883-4e62-852c-aa7127500cca"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a3ed16d-396c-4dfd-a72a-dce65897c708"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cdac3b7-56a4-4500-b480-ce6c8d7be8c8"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cdc3449-1439-4de0-9552-d1c2b1553f29"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d1026cf-e8cd-4435-8fe3-c121d6a83c73"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e0042f0-9057-4cd5-a9d4-85ba50580c68"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9e907a1f-266c-460f-a889-a22da5a3c82b"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fd2632d-b5dd-4d5b-ac16-209d0e506258"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9fdf53b3-1543-4fa0-a5b7-135b5b3c0335"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a0b7fc4f-77b7-4dd1-8e9d-d15a0411fe02"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a11f59c2-0741-4c5a-80ef-a604ab9ba5cf"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a35958b6-8a38-4bbb-b5c8-75605e5f1c02"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a3a994f2-1f92-4615-b7f1-095c0d357c78"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a40293fc-0bd9-4786-836c-28066d9f1c9c"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a44b651b-2c14-4a7f-871c-d9592e289078"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a6e9f005-ea7b-42e2-8dc0-a6a909ebb55d"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7b88510-851f-4216-a5ab-30ca498533ba"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a88f92b4-e36d-4890-9980-2f5770b927f4"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a94cb32a-528d-4186-aa40-4934607f1282"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9884d2a-7ac3-4b28-94bd-82cc0f3a6997"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a9cbd80b-4e8a-4df4-9e0f-50a2c44a3d1b"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa94d446-5cf2-43b7-a523-51faa1ab4a75"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aab50aca-254b-4e27-a595-6951b1ba3db1"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aab69d6e-6705-49ce-89af-bca38c2a83d9"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac22072d-7cc5-46f8-a3bd-7ecb4b7a4f66"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aed238d4-1ba2-4a1d-ad30-392a833de53d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af04e695-e6b0-40ea-acd6-33b4f9743bf8"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af0d2071-647f-4e0e-affe-e03d97970dec"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b090f9d6-6042-41c2-8653-a03bdc91ed15"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2fdbf42-e185-458b-ac75-ff2bb62d97cd"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b569aaf4-3e92-4338-9174-160fe33bb7b2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b74baea6-38dd-424d-b318-08d88dd8a42a"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7e08243-79e7-433a-b0ce-77d8c37a1d8f"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b95b0f76-4e28-4a82-af55-8af581a88454"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bb16d9f1-c180-411e-bf5d-8e3147fa0e16"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bba15cf5-c3c6-4d24-bc89-cdb598a7eb5b"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcc730c9-26ee-4d9c-8e12-833fd6bc5be4"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bda86b7b-1f57-4777-ad5a-0d783f16ac49"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bdf52602-82f0-41b9-a819-e3ce3384b3b4"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be7455a1-f3a1-475b-82cf-9f77d4fc4bed"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2595ba7-f5cb-4623-bdf3-d2c6660efd6e"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4af3a8d-bc32-4774-abab-9f1c2f9dc17e"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6b1c9f6-1a27-4370-bc55-9b3cd12c9712"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7fd8c1c-556d-49bd-b63b-1f1a2bb39780"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c82b0591-bf8c-4f6b-8f84-6e97ee38f14b"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c9038465-78c0-4883-9e02-ff53c8d66633"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cac2b8ce-d311-4808-bb2b-33b4c0eb9ce7"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb1fc4a0-dc9e-4ab5-9114-6c65f80396a2"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd19bb4e-20ba-498a-b01f-75882979d871"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd2be238-62b2-4420-9a17-4a3ba5f31527"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf609348-8137-4eac-af23-0a2d3f5e869d"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf6c6b50-921b-4c34-bcef-abfb8527a74e"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cf98b191-3792-4f4b-bd6e-6c1cd7f1e188"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0fbec32-dc81-4681-82aa-980ad946aaa5"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d341f8a9-a7f1-47b9-9769-874e433c4ba3"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d451a991-a4ce-4ab1-b5c4-1925e8adfcba"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d47b8a59-135f-479c-a172-0fa0c00644c5"), "A", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d65d012c-6491-40c1-8f18-77bb243243fd"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d873c861-1128-4150-b41f-a70431af016c"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8a4e595-60e9-421a-9da3-68196b3b7fda"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d903a884-8e36-4f06-9a92-fd94f7234a8e"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d98ba9d5-3a28-4d21-9bbb-d3c6399593ff"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da14bc0e-7f91-47b7-9443-fdabcef146d6"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dac640c9-9a72-4c87-b910-c3a25e417ab2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("db91fa4d-94a7-41dc-a03c-0d1d1afdd3c1"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddd322ed-c829-4b72-8d39-bb359151e79e"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e022774b-58d0-402e-950a-2dcbadf6ecf5"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e123422f-2bc2-44a9-ad27-bc4a0c82cfdf"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e228a082-03e0-4407-ab17-c1a9cfeeb273"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e309d485-f19a-4626-bb27-534aef1d0741"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e33ccafb-9c2a-46dc-9aae-fd01511306c8"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e36ef387-0352-4080-bad3-6f268ec7653e"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5eff4f0-5f06-4df4-9a05-aa00667fe22d"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5f443b5-9fcc-4dd8-a458-5a675ac751c5"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5f9b2f9-0e2b-4a2c-86d6-ca1abb82b772"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6451bab-9d87-4fef-9987-756344998b75"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e9082e41-27e3-4cdc-b6b3-d241615424ee"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e90de53b-256f-4816-a0e5-f23bdcccce58"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea319ae6-d75f-4ea4-ad62-5e53b39ca6ad"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea88d09f-b2b4-44db-b8e1-36d763a52bf3"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ec24fdf5-fd1b-4259-9eb0-759e32bfdc56"), "B", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ecf0968d-e36e-4f59-aefc-e943d1d19eca"), "D", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ee5c1e31-747c-4f64-8ccf-ea1d1fef9c50"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eea273cb-d20b-4c67-824e-5c4fdee68df7"), "C", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eeee70bc-6629-4fc5-8343-19ef060e0866"), "F", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("efe08bc7-a41b-477c-b1f7-ae78d5b00cec"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f01be9a8-27ea-4003-a166-1f182e20671b"), "H", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f12296ef-9811-4e2c-b62f-c851eedf6dde"), "G", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f27d3cc0-059d-48dd-a6ab-d5ba99388755"), "E", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4affbe7-e7f5-477f-b811-9511ba424c5c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9c3b7d4-e36b-4fc0-b30a-d0702138f528"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa35a57e-f56a-4876-a896-929386c8cd5b"), "I", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd3b80e5-368d-4056-a1f9-79a8cbdb3bda"), "J", null, null, null, null, null, null, null, new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fec5a568-10be-42e6-9310-6afe9e098a87"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("4ad8dc80-aac2-406b-a094-f02db7ca18e6"), null, null, new DateTime(2024, 12, 23, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7072), null, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 22, 14, 44, 16, 399, DateTimeKind.Local).AddTicks(7062) },
                    { new Guid("8b704ad3-d69c-4442-a434-bef6409d4efc"), null, null, new DateTime(2024, 12, 24, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7079), null, null, null, null, null, new Guid("de348493-9128-4e17-aca2-c587a3100b53"), new Guid("15efba0d-9828-4049-9aa8-4eb61d17fec1"), 1, new DateTime(2024, 12, 22, 14, 45, 16, 399, DateTimeKind.Local).AddTicks(7078) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("75acfb77-1043-4960-a76c-e466e27dcd52"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 22, 16, 43, 16, 399, DateTimeKind.Local).AddTicks(7770), new DateTime(2024, 12, 22, 12, 43, 16, 399, DateTimeKind.Local).AddTicks(7769), new Guid("03943d29-da79-4132-8b53-cec2676de52b"), new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7768) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("3a5f6f5b-867c-4438-8f3d-3da81ff13f9b"), new Guid("8d82a3ce-0a9e-4a86-a490-700efa299466"), null, new DateTime(2024, 12, 20, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7636), null, null, null, null, null, 1 },
                    { new Guid("57e7c05e-87f5-483a-84eb-15b024de8c03"), new Guid("c61e4c08-0a1b-4fb0-a8f4-4c7be54bde21"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7641), null, null, null, null, null, 2 },
                    { new Guid("cab620ad-153d-4042-bb7a-96b9da2979e8"), new Guid("9e225ad7-9e54-482c-99d6-0b89c3c5b590"), null, new DateTime(2024, 12, 20, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7645), null, null, null, null, null, 4 },
                    { new Guid("d386125e-7757-46ee-9436-f27ee980a427"), new Guid("d445d49f-dcc1-427e-a920-54e34a6d3f9e"), null, new DateTime(2024, 12, 21, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7643), null, null, null, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("31023ea1-0092-4863-bc9e-174cb1cf3d74"), null, null, null, null, null, null, null, new Guid("2037b062-4a07-4f33-8bde-be2ba5012be2"), 3100000m, new Guid("efb45afd-7b33-47de-9554-97e9f4d1b0e8"), new Guid("d65d012c-6491-40c1-8f18-77bb243243fd"), 2 },
                    { new Guid("8d265284-3421-4e94-9c77-0ba551da582b"), null, null, null, null, null, null, null, new Guid("179efd0f-cffb-4d28-9c58-085eb5a673b7"), 100000m, new Guid("3e24ddf3-29b4-4c74-a0a8-925d506eccbe"), new Guid("727515d6-d738-4375-a4a8-391fa839d9aa"), 2 },
                    { new Guid("fa163be5-ffe9-4f11-8f20-9f5d55c8b8a4"), null, null, null, null, null, null, null, new Guid("de348493-9128-4e17-aca2-c587a3100b53"), 2100000m, new Guid("b5593e5f-eafb-42a9-b801-fa3dcb511dfb"), new Guid("888f92f9-a93e-4ab6-9b25-8a115171bb4a"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("08a04980-8d69-41e7-aa04-c6db30e52bed"), null, null, null, null, null, null, null, 60000m, new Guid("b5593e5f-eafb-42a9-b801-fa3dcb511dfb"), new Guid("0ce08fd6-0d1d-4c61-8b8b-7827baff7fe1"), new Guid("12f9af2a-ddf6-4456-a648-59975e94707f"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("df17e7f0-3335-474e-a3a5-3c6a6e9309e0"), null, null, null, null, null, null, null, 50000m, new Guid("3e24ddf3-29b4-4c74-a0a8-925d506eccbe"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("49fe4ff9-8983-47e2-b0a0-784dc7e4d34c"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("3a5f6f5b-867c-4438-8f3d-3da81ff13f9b"), new Guid("8d265284-3421-4e94-9c77-0ba551da582b"), null, new DateTime(2024, 12, 21, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7682), null, null, null, null, null },
                    { new Guid("57e7c05e-87f5-483a-84eb-15b024de8c03"), new Guid("fa163be5-ffe9-4f11-8f20-9f5d55c8b8a4"), null, new DateTime(2024, 12, 21, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7685), null, null, null, null, null },
                    { new Guid("cab620ad-153d-4042-bb7a-96b9da2979e8"), new Guid("fa163be5-ffe9-4f11-8f20-9f5d55c8b8a4"), null, new DateTime(2024, 12, 20, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7688), null, null, null, null, null },
                    { new Guid("d386125e-7757-46ee-9436-f27ee980a427"), new Guid("31023ea1-0092-4863-bc9e-174cb1cf3d74"), null, new DateTime(2024, 12, 20, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7686), null, null, null, null, null },
                    { new Guid("f205e2e5-5e72-4c54-ba30-5a5978aa0bd2"), new Guid("8d265284-3421-4e94-9c77-0ba551da582b"), null, new DateTime(2024, 12, 22, 14, 43, 16, 399, DateTimeKind.Local).AddTicks(7694), null, null, null, null, null }
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
                name: "IX_PendingPoint_BillID",
                table: "PendingPoint",
                column: "BillID");

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
                name: "PendingPoint");

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
                name: "Ticket");

            migrationBuilder.DropTable(
                name: "MovieType");

            migrationBuilder.DropTable(
                name: "TicketPrice");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "WorkShift");

            migrationBuilder.DropTable(
                name: "Seat");

            migrationBuilder.DropTable(
                name: "Screening");

            migrationBuilder.DropTable(
                name: "TicketPriceSettings");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

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
