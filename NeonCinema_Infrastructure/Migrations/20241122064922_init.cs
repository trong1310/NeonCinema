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
                    PriceBefore17hWeekDay = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    PriceAfter17hWeekDay = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    PriceBefore17hWeekeend = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    PriceAfter17hWeekeend = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    Surcharge3D = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    Surcharge4D = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    SurchargeIMAX = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    SurchargeVIP = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    SurchargeCouple = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false, defaultValue: 0m),
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
                    MinPoint = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
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
                name: "Screening",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShowTimeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovieID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoomID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Show_ReleaseID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Screening_Show_release_Show_ReleaseID",
                        column: x => x.Show_ReleaseID,
                        principalTable: "Show_release",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
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
                    Price = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
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
                    Price = table.Column<decimal>(type: "decimal(18,3)", precision: 18, scale: 3, nullable: false),
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
                    { new Guid("3cff7106-f1d3-4363-b1a7-224424de90c0"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("968bd795-aefd-4b19-b1c0-0a306413414d"), null, "mua tại quầy" },
                    { new Guid("c1ba0f48-f3b1-48d9-b20e-667b67f64d1a"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("6117b259-7699-4049-bd72-d5630a82360e"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2315), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("dc47209d-41e8-4e13-970d-c997e51d067a"), "11:00 PM", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2322), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("023cea70-9950-4fff-8c78-621842e190d6"), "Pháp" },
                    { new Guid("20e2448a-dae1-43cb-b52b-652974f0765c"), "Vương Quốc Anh" },
                    { new Guid("575bd13d-4eb6-4258-ab7a-891196499532"), "Mỹ" },
                    { new Guid("67cfeba5-8c64-4f42-98cd-152f8851e8d8"), "Ấn Độ" },
                    { new Guid("8b025953-fb87-4106-8000-dadd6eb44dab"), "Trung Quốc" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("be26292c-d207-4504-91c6-e07a020694bc"), "Việt Nam" },
                    { new Guid("e090c2b3-2d67-4730-a727-bcf998c05e7d"), "Hồng Kông" },
                    { new Guid("e210b20f-a1a6-452d-bd99-b68fa3a86921"), "Hàn Quốc" },
                    { new Guid("fde07115-88bc-41d2-983d-efb678ee24dd"), "Úc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("3d3b6c47-4825-491d-9a4a-d7f1050882b8"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("53b1413c-8a97-44ce-9c3d-653b921f05d2"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("662ad7b7-112f-42a0-9543-caa5b886422b"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8691fa2e-94c9-417d-b5fa-393ed04fc504"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9aa71eb9-19f3-4a5d-8d2a-8956fd168785"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9af6ac32-495f-4341-85b9-6fb7c138f8e9"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("c8fbba22-6da0-4c13-8f53-6e162bbfbf37"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("d4e7d5b8-8aa7-4bc4-bd4c-133c2d92e78c"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("d59e661b-38bf-4c66-90e8-4433c6369f61"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("aa047db5-90b8-422a-88e6-6919518a5585"), "Combo 2", null, null, null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 220000m },
                    { new Guid("cfa6da51-7f27-4f9d-a9a0-282d430f6f00"), "Combo 1", null, null, null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 20000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("053ee2b2-be16-4065-97bf-402e0a53e3c8"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("07aa7d2c-dd17-4d76-9d63-71039f75994e"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("147c2aa9-83f7-4fc1-ac85-a1d982f1b535"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("1c26f0e7-e309-419d-b7ab-d247c3e5ac98"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("4a0a0cfa-fb86-45af-a1a5-efd0cd78459a"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("5abbb3e8-9110-4932-9bd0-4bf817a68c0f"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("70e1e5b2-67d8-4a52-97b7-c0fc3da87c2d"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("ac5d60bc-0043-43b9-9f59-817c9cd34f9d"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("bbc5bce1-390f-4f32-8b3e-2d018c5284de"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("5ef8ef6e-b2d0-4105-90fe-cfc5aac8b8c8"), null, null, null, null, null, "vi", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "en", null, null },
                    { new Guid("a91dce54-b279-4cee-9107-8138983d76b8"), null, null, null, null, null, "ja", null, null },
                    { new Guid("c4c7b819-b1d0-485a-9f47-9588892a1bfd"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("f0511b15-375b-4deb-b831-726a0c6a59a6"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("f3ee53a1-4b17-4fcf-87c6-ef1b71fff555"), null, null, null, null, null, "USA", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("0cea9a36-d057-43c9-a3e2-4571f3cbdd44"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 },
                    { new Guid("4efccab0-5b52-49b0-8491-25cec841a19a"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(754), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(787), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(780), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("120911cc-7ca6-419d-b322-bf05dbd93b44"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2270), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2262), null, null, null, null, null, "Ghế thường" },
                    { new Guid("a1a1d2e2-d1a6-4b26-8229-2d3178fa85cf"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2268), null, null, null, null, null, "Ghế Vip" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("008e6a3c-a82e-41b1-b2ef-fbce3ae02caa"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("0e5c088c-a261-4a86-95ad-09c3b603436b"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("0f689538-05bd-4540-ac54-c30dbde04107"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("1369a3eb-a1fd-4da7-ba70-7ab3c3450a53"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("1be33fda-b9bb-4960-bd5d-fd9cd6f188e2"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("32cf12f9-b7cf-4cab-9652-7f3b4fb86fc1"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("3c2ec207-dd4d-40ca-8e85-c63df1803c4c"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("6001f9df-d03a-4660-803b-2552283e2de5"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("85aedb00-c72a-4330-8bdc-86428f8b07ea"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("fc11b69e-8a5d-4b08-ae7d-bdab3da02155"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, null, null, null, null, null, null, 70m, 90m, 50m, 60m, 30m, 50m, 200m, 100m, 150m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("169fd978-6ac6-4961-8215-7f84682ad3ef"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3516), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("d59e661b-38bf-4c66-90e8-4433c6369f61"), 100, new Guid("bbc5bce1-390f-4f32-8b3e-2d018c5284de"), "saigontrongmuaroi.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("2be5c82d-566c-4e6a-a636-c7b7f8d90760"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3453), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("9af6ac32-495f-4341-85b9-6fb7c138f8e9"), 140, new Guid("4a0a0cfa-fb86-45af-a1a5-efd0cd78459a"), "gaigialamchieu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("4ab10d5f-67e5-414a-8f59-f59a48b1441e"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3464), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("d59e661b-38bf-4c66-90e8-4433c6369f61"), 125, new Guid("bbc5bce1-390f-4f32-8b3e-2d018c5284de"), "tiectrangmau.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("55a4ac91-39fc-4e96-9ea8-9ccbfc8a4373"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3414), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "bogia2.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("7638a948-005d-4982-8e8e-036ab9e56bc0"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3494), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("d4e7d5b8-8aa7-4bc4-bd4c-133c2d92e78c"), 130, new Guid("053ee2b2-be16-4065-97bf-402e0a53e3c8"), "matbiec.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("770d9a8d-78a8-417d-8f64-2914c6a45f1b"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3477), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("c6db356c-8e69-49b7-a0dc-35be6702973a"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3486), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("53b1413c-8a97-44ce-9c3d-653b921f05d2"), 150, new Guid("07aa7d2c-dd17-4d76-9d63-71039f75994e"), "emvatrinh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("c87bc449-7804-46f9-974d-083af5f28e42"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3504), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("9af6ac32-495f-4341-85b9-6fb7c138f8e9"), 145, new Guid("4a0a0cfa-fb86-45af-a1a5-efd0cd78459a"), "nguoinhenvietnam.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("e083ddce-cf0b-4acb-8d85-ae1522b2be7c"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3442), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("d4e7d5b8-8aa7-4bc4-bd4c-133c2d92e78c"), 110, new Guid("053ee2b2-be16-4065-97bf-402e0a53e3c8"), "nhabanu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("e444aa6c-29ca-41b4-b6b7-ee24a23eca5a"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3428), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("53b1413c-8a97-44ce-9c3d-653b921f05d2"), 120, new Guid("07aa7d2c-dd17-4d76-9d63-71039f75994e"), "chimuoiba.png", new Guid("5ef8ef6e-b2d0-4105-90fe-cfc5aac8b8c8"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2361), null, null, null, null, null, "Room 1", 0, 100, 1 },
                    { new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(2369), null, null, null, null, null, "Room 2", 0, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("14e174ec-ce3f-4f7a-9d74-14e41a97625c"), "Đà Nẵng", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1599), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2cf4fc41-d606-411c-97c3-fc994bf08b52"), "Hưng Yên", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1772), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3cfd43ef-f249-4ab7-ac9e-553609f3d9d3"), "Hà Nội", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1507), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4d52fec9-7fee-461c-92f0-5c07b9a76c82"), "Thái Bình", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1737), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("84be52af-8292-4c05-8a2b-0f6b9a1aeb61"), "TP. Hồ Chí Minh", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1638), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a7c8044a-c0b0-43e2-9da5-55521ab27a68"), "Nghệ An", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1674), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b138cd93-ee4f-4941-9a88-a07e32b39b09"), "Hà Nội", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1034), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bdca9c05-e13c-49f6-9c92-6a73f493f420"), "Bắc Ninh", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1705), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c1211a01-29ec-4ee7-a011-cd9ad2164b02"), "Hải Phòng", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1554), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("dddc958e-f2c0-4c14-85b5-eece5d2bcec3"), "Nam Định", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1818), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f64252d0-fb65-4926-96b4-be35019462ba"), "Quảng Ninh", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(1853), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("01480894-7683-412f-9ce4-b0fd89f7984b"), "BILL010", null, new DateTime(2024, 11, 22, 10, 29, 22, 650, DateTimeKind.Local).AddTicks(3964), null, null, null, null, null, null, 2, 700000m, new Guid("dddc958e-f2c0-4c14-85b5-eece5d2bcec3") },
                    { new Guid("4b9cf38e-6457-45d6-a78d-296d7fae0f59"), "BILL004", null, new DateTime(2024, 11, 22, 13, 4, 22, 650, DateTimeKind.Local).AddTicks(3930), null, null, null, null, null, null, 2, 200000m, new Guid("14e174ec-ce3f-4f7a-9d74-14e41a97625c") },
                    { new Guid("6110a993-4427-4184-89ae-80ac4b19ade7"), "BILL006", null, new DateTime(2024, 11, 22, 12, 19, 22, 650, DateTimeKind.Local).AddTicks(3945), null, null, null, null, null, null, 2, 600000m, new Guid("a7c8044a-c0b0-43e2-9da5-55521ab27a68") },
                    { new Guid("627f667f-6dd1-4501-af12-29a80bb141f7"), "BILL002", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3924), null, null, null, null, null, null, 2, 300000m, new Guid("3cfd43ef-f249-4ab7-ac9e-553609f3d9d3") },
                    { new Guid("62940c88-b9ef-44e5-ba72-183751798df4"), "BILL0122", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3949), null, null, null, null, null, null, 2, 680000m, new Guid("a7c8044a-c0b0-43e2-9da5-55521ab27a68") },
                    { new Guid("6b7dd135-ba43-443d-b270-196f27a10a0f"), "BILL009", null, new DateTime(2024, 11, 22, 10, 49, 22, 650, DateTimeKind.Local).AddTicks(3961), null, null, null, null, null, null, 0, 350000m, new Guid("2cf4fc41-d606-411c-97c3-fc994bf08b52") },
                    { new Guid("7784e7ec-3a5f-4320-b0ee-2d5ed5cd4f98"), "BILL007", null, new DateTime(2024, 11, 22, 11, 49, 22, 650, DateTimeKind.Local).AddTicks(3952), null, null, null, null, null, null, 1, 800000m, new Guid("bdca9c05-e13c-49f6-9c92-6a73f493f420") },
                    { new Guid("93bfaa54-934e-4dd7-93f0-fc5c05f18037"), "BILL003", null, new DateTime(2024, 11, 22, 13, 19, 22, 650, DateTimeKind.Local).AddTicks(3927), null, null, null, null, null, null, 3, 150000m, new Guid("c1211a01-29ec-4ee7-a011-cd9ad2164b02") },
                    { new Guid("98c0bb78-980a-4b0d-a135-1ccc4f3cf4e5"), "BILL005", null, new DateTime(2024, 11, 22, 12, 49, 22, 650, DateTimeKind.Local).AddTicks(3938), null, null, null, null, null, null, 2, 250000m, new Guid("84be52af-8292-4c05-8a2b-0f6b9a1aeb61") },
                    { new Guid("c809a17d-ea49-45f7-9be4-f1612101b715"), "BILL001", null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3917), null, null, null, null, null, null, 2, 500000m, new Guid("b138cd93-ee4f-4941-9a88-a07e32b39b09") },
                    { new Guid("cae93145-47ed-49f7-914b-69776afed526"), "BILL008", null, new DateTime(2024, 11, 22, 11, 19, 22, 650, DateTimeKind.Local).AddTicks(3956), null, null, null, null, null, null, 2, 450000m, new Guid("4d52fec9-7fee-461c-92f0-5c07b9a76c82") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("6460f5c2-e98c-4272-b227-c3f62aa82ba7"), null, null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(4155), null, null, null, null, null, 150, new Guid("3cfd43ef-f249-4ab7-ac9e-553609f3d9d3") },
                    { new Guid("bb0fa470-b9f0-40f1-a287-a9dfdc4461af"), null, null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(4148), null, null, null, null, null, 50, new Guid("b138cd93-ee4f-4941-9a88-a07e32b39b09") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("a4d85645-95ef-48ec-92cd-56c075c00e42"), null, null, null, null, null, 100, null, null, "Gold", new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(4051), 1, new Guid("b138cd93-ee4f-4941-9a88-a07e32b39b09") });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("00389ed3-dc87-4b98-af51-45cf406129d2"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("00f1f7eb-f0ef-4022-b73b-6d676569c33f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("017db34b-3b9b-4c0f-b410-e9490ce94b1b"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("023cdb5a-ad69-4d71-9eb0-c07aeb965eaa"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("05163e07-8f3e-46a5-be03-6650ff876211"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("053f5cd9-c3b7-43bf-a183-d328b3786b5b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0a219caa-2568-43fa-9c31-0bc146ede645"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0ab60795-1303-4d67-a759-001b40e63377"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0ae0b837-dc34-49b4-af00-4b4e1eecfef6"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0f1fb18f-fa11-4c5a-8157-67701fb04261"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("10571dd9-8030-4bfe-b33e-1c95526ffe76"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("107ee1e3-004f-411c-a20e-d3be5edf0169"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("10a274e9-b770-489c-b168-e6872ec7ae5a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1193893a-7b44-48f9-93d6-cecf59929407"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("11c478c7-797f-4c23-8905-247ba4551d50"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("11ccc609-623a-4b78-acc8-c0b297f7aa93"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("14da7d7a-3581-4e91-b380-582a43f72cf5"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("15b6cbcb-2620-4678-a789-b5263d62b111"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("16157c0f-4b31-4f8a-b26d-a01b7f7dfc0d"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("167a113a-1aef-42c1-8e05-60f2b0196b39"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("16a2b6b3-9948-483d-99cb-9a7eb7bc9cce"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("181c8426-5781-4830-b002-ff8506f6e457"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("18da639a-af4e-4a6a-afb9-f7a430eb647e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("191e0c17-52d1-47c5-89c9-23877ed97eb7"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1931b706-ca5d-48d6-868c-e634ccb6cd7b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("19ba5e4d-d00c-412e-b38a-3615e6f6f1b4"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1c495e0b-ea76-4823-9032-39cd7aa6f9a9"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1ca17b47-d7f8-4ed8-b543-2bceb0219771"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1cf82a4d-eb90-488d-a3a7-1bc873b1cd54"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1d904b6c-ac93-43ad-b6dc-968c60be5212"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("20bb6359-a0bf-45fc-88ad-7fabe5ed2fd2"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("212b7050-2a07-4337-8143-372e551a4b6b"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2226f2ff-dd63-49f6-9678-326a655320ac"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("22c8ce74-cd75-456b-abcd-61e1051b1bb7"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("25b0ad7e-dd79-4b03-a6c3-87481b1641c0"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("264b50e6-4032-4c0a-bfe7-f53c5d0cf5e3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("27f83c44-0d22-4de2-b00b-630c6ef5a02c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("288e5b4f-4158-4f90-8c86-d293eb538630"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("294b5c20-254a-4677-becc-65944743e8c9"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("29d48872-011a-4cd3-a23b-65576dcaae20"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("29dd7db2-fe56-4286-be8a-9b1a8382b5b0"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2afcaf7b-c591-4726-925e-e2e956917185"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2b32a7c5-9224-40a1-b44e-88a44a126fa4"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2bcae8e0-a0e5-411f-9f45-f97fdab87c90"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2d28fb23-e679-4bc2-b04c-69d0d74e9bff"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2d8f040e-8969-41d7-841c-ecbe7d1870ac"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2e1fe4d9-256c-43b5-a1e4-a1b44475fb3b"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2e795832-766f-45e3-9f06-81402abef447"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3087194e-2413-4db2-a869-784404f1be83"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("30bf6b26-c026-4c3f-af2f-4c7a273f30de"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("30ff28c7-ae17-4e33-a71c-ff43095c4c75"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("32ee7ee4-4d84-4858-8b9d-0e9b4668d516"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("343ab268-91c5-4537-a895-5cde175b711a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("35dbb435-8210-4645-b1d2-553150de3855"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("360ca5e5-ddb2-4e0e-986c-b9f9aec515eb"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("36d15942-5f61-41b5-a52e-96ba6dfd8c74"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3a64f557-f434-4239-9ce3-7f32cd651faa"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3be30f6b-304d-4300-8f0e-12aa72fbd141"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3c3290ca-416d-477a-bfcb-4e892d1d6f09"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3c9a1374-d217-421e-b5ea-16fdda33ce21"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3d7b9f9e-9881-42bb-888e-b8634dd0975d"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3e609606-d9b3-4f7c-b3cc-d6ebab913c2c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4149ef7d-d2dc-46a8-ba40-ba18eab3587c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("42f47ee7-8695-4b4a-a076-6c51f95c0cd7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4327c4b3-16ee-4d1e-8be1-4abacd0de361"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("43524099-e478-4d8d-90cf-a306b31d39b9"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("435f2adc-ca7a-46f7-9b27-85ba0b79faff"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4379887c-1d01-4a4f-870b-08d9e1ed715f"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("44855c67-4508-46fa-bf74-378613291a5a"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4501c526-4393-48f1-964c-ab72445671c9"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("46737410-b3e8-4229-b4df-1173a7043b06"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("498203c1-b87a-4215-9634-3ebd8e2442e6"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("49be70f0-fd2f-460c-853a-1e070c63bd64"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4a9a36a5-2da3-4a23-bd8d-0783b08b91a5"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4ad3135e-538b-42d0-b08d-c52915ccb2d8"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4bc7ca3c-4d8f-41e7-967b-0339ce6e03b1"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4cac1b77-73e2-4243-b0c6-36275a62e07e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4d97e412-f594-4237-89ff-71b5cf8447eb"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4e6a354b-b639-4e85-a568-f7cb64e1be60"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("508b77ab-3f92-4b3a-a307-9ad9659efcf1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("53820b93-b3a7-432d-a613-b5e038c0190d"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("539b561e-3624-4457-a100-b6a266e6dc2f"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5466e03e-004d-41d7-b10c-9151327ed8a2"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("551ab299-a4f2-4a2b-98a9-5c1c64d697de"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5611a8e7-68b7-443e-b617-d428a18c8366"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("563738b2-d03a-46aa-9ae3-021b67b2df41"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5754804e-e736-4da9-900f-8111eff3dfd5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("57662235-d9f6-4709-bae8-00c647cc474c"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("582119c4-e5ba-4b07-a4e8-0432d0319869"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("58dd8c53-3397-477c-a7d1-0a784aa5308e"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("59013bfd-2fc7-4077-848d-d272007299ab"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("59cf69c4-555e-4351-8f04-12e7cc88b811"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5a33e03d-09ea-45a3-b1b8-b435325bfca7"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5a7e6879-de2a-438a-9c54-97d850a53c65"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5c86bcf9-d32d-4f64-a7ce-ff7fcd9f2be9"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5d5bafca-1478-47b6-b12c-6cb1b99325f0"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5f2e8fc9-5c6e-46b1-a7d9-f9175cb209ca"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5f9f34d2-2013-414e-ae31-69de85dcb169"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5fc9d005-dbd2-4dae-8ff0-4466b5a08f42"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("62d7a539-7226-4a65-907b-534d1803429d"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("62d8ba85-67eb-4c40-b096-4bfc64e066cb"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("63182338-cb23-49e9-b411-7e3a0ffc68dc"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6343affa-6002-4acb-92d3-f3e72d07f427"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("649eb8d6-3143-404b-b224-9e21f2d606e3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("65838305-c143-4445-8534-21403f41a3a2"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("69be9f16-6c5d-4c2b-8d6f-557bcd99540b"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("69c2ccca-3ff0-40cf-9858-cf9bc91b8377"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6a4fedbd-83a9-4d76-85bf-1140b243f008"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6aec0ab1-cec9-4f8c-813f-f8d74d44e208"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6b4547c5-198f-41fe-bfc7-fb3839e29c0e"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6bd798f2-09b1-4c4d-9a9c-adf422b85257"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("71dd26c3-874f-4af2-94ec-a1295c0ad7dd"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("72998a3a-ecea-403e-9e87-cc3fc6f3a35f"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7357ec64-a1f6-4c01-90af-4efe90948436"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("73994edf-7b41-4b8b-bf59-85a67f3176d3"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("75d95faa-e5a3-43d3-92ef-2a925b17c5c3"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("771fa63c-4cb2-4f71-b556-d9c04bea096f"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("792d9e23-434f-428c-bbf5-69a518e28e7d"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7944e75f-45ee-4a82-8422-8838f777d354"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("79a81293-5873-440d-84c9-35b165e8fca1"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("79cd6fe8-7770-49dc-9f9f-bdebd57a4d93"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("79f5eab4-d19a-4332-967c-eebf1fe08228"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7a384cb6-a8d2-45af-ae26-63cc3ad34bf8"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7c428606-dca3-4107-9081-e61bdc4c5dc7"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7f97792f-8362-410f-a1ce-07a45d0e3c50"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("80871677-0bc4-468d-8cff-be2b707720c3"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("80a3250d-f35e-4ae1-990f-948a9a1f0631"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("813e6f17-2ecb-4885-9706-27d430486839"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("81dd7a26-0a65-4f54-b197-df2b666dbcaf"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("847a22bd-35a5-4aa9-b397-5f1911ffd4ee"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("85c6e55c-1bed-4fa0-a701-34329e40d577"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("86e5141b-95f6-4dd8-b1f8-8914a89278ab"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8861ad34-6809-4ac8-9b24-02f7a8e9e093"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("892f816a-fba0-4c60-888a-b980232be2e0"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8b03bf42-c781-488e-8a03-0cb92b5c4494"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8b03c38b-ddad-44d8-a135-1c9a8ee6c764"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8b644123-cea1-4847-a287-fa7b94c5329a"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8dde7137-465e-48ea-b253-14a55dec4ab9"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8e207522-c90e-4fa0-af97-9b517cbf75f1"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8eb54ce7-120d-4461-bf5e-5fe7f626e0e1"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("917def69-eb74-44bb-bc7a-dfcb82abdf1f"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("91d84008-6c2b-4266-a627-6bde485dc55d"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("91f0c9e5-10b7-4dfb-9adc-1e422f2f2e1a"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("93016de9-9b6d-48dd-a59a-53fa26df16bf"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("93fdeb1b-ccfc-4329-8ea7-af48a5f1959a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("95275c1d-5e37-4191-8540-dadcc05b6e5b"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("96f2ce1f-4216-4b4b-b4e3-77dbda7ea874"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9721bbea-e8fa-47b7-96f5-5daf01b940a1"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9931782a-de88-4183-b7f7-ffc6c2ca95a3"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("99428314-80ab-4129-b1bc-1470fb634e81"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("99aa2ae2-f482-49ff-a331-fd576cdb8c8e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9a73af3a-668f-4f9c-99d6-7b3e79c6c003"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9c066e28-8fd4-45c2-8b8f-820212dea858"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9c44dc51-cd06-4711-9f1e-6b2926a803f1"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9c8225be-939d-40e9-a3b6-540137e077ea"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9d9d4009-1c88-4c74-b469-2c2f6aa804e5"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9dfe9f2e-2df2-4637-a49e-e644110e1fc1"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a08ead39-1bbc-43f6-a38f-d4852f953a8b"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a0cad77f-025f-4fea-8525-6bbbdd6e6cad"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a0e10ecf-0ed1-48f2-89cf-7fd8ba0e76ce"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a13e8a1a-1591-493c-9bb0-970adb524b21"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a160583a-df0f-4071-a98c-ce85b4a4c1fe"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a395e2a7-728f-4896-8dab-87ffa19f84b7"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a4b4c2fb-733f-4be1-ba0a-22cb46d7da22"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a55cfbab-5061-4d1d-a279-037c27232c67"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a80f302b-fe83-41e5-b698-996be93d1ae6"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a88080d3-db9a-452e-ba59-c6256a22b039"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9212dc7-c4d0-4dcb-a597-5ec543dae243"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9c432ad-1e41-48b9-99a7-1000b4eaeb59"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ab68beaa-21b7-41b0-aad8-b688a0f06095"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("abdef1dd-07d4-4d03-9a8f-613e00e07fac"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("acaa01e1-9273-48f1-928e-dab6be13cf58"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aeee83dc-f005-4bbf-a9cc-094c0f821447"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("afd6a9df-c3a6-47b5-bf9f-41d809f62aee"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("afe63e24-de1f-454e-a1b2-b2930da0c395"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b117c738-bc27-490d-be8f-654ab54a0dfd"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b47e95be-e096-4c14-a48f-9c545a0ca7a2"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b4ef87f3-9a5d-4e9d-80f8-bbf44c6123bd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b51798a7-1b95-4a24-a4f7-7ae26f57c252"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b6a4f52c-759c-461c-93a7-fd0dea282790"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b6e41779-0b60-4e95-977a-7e9bbad3944f"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b97e1aae-4a3c-454b-ade7-62299a78fb2e"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b9fc4a45-f611-463c-a88c-a669ff1a9930"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("bda61e9a-bd17-44d5-8f74-798c9190c8c7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c0617c4f-6033-4a76-a083-de33843ff1e2"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c186ebe0-6c6b-4fb3-bd1d-b7e261196768"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c1a4644c-ead8-40ed-b444-20bffb55db55"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c3507653-f296-40ac-bf8d-fb614c751235"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c371fd38-23ba-4b09-8c10-cf84fef89570"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c3ed5ac7-44dc-4380-8852-acb9c81ff1e5"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c43a409b-290d-4908-8cc9-e2faa7ccd2b5"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c5ee1630-8858-47dd-ae6b-44279b8660a0"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c77ec69c-566b-4b37-b72d-682b7b19dc94"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c824c035-009b-430a-a5b5-1c53d9f69811"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c934a57d-da65-411b-9e8d-b1cc8e13026e"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c9cf2206-79d0-491a-bb62-0d11a5ea6115"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cab206e3-46c5-423b-a5ad-cdf4cc4b30da"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cc34aa04-8dff-446e-9d97-3c5096d12e45"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cd5ef85b-b0a9-42f8-95c1-74209de29bba"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cf00ef38-686a-491e-b042-e1c76ea9957b"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cfcda634-9690-4c95-bced-492db97e34cb"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d08a1b99-4874-447d-861d-4c9c0637b7cf"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d46928ed-a9f2-46ac-b06e-285faaded8b8"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d46cbc79-b14a-4478-a826-ee4f99987dab"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d559d6a1-029b-4d08-9142-7f79b68c846e"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d7a1fd82-882c-4ec3-856c-238b83f785bd"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d81901b4-7e23-416d-b7d6-79fd74a2ec4d"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d83c0091-5a8b-438a-a2d7-0a4a88452965"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d86366c8-cf28-46c3-b2d5-8592c24a04c4"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d9fcf40e-deb7-43c1-a118-e695a9929e03"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("da89e5df-41ba-45c8-be7f-37f074e6341d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("dc1c0c02-4a15-4a14-9070-6790a9023f40"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("dd9890ef-6d3e-44ef-b791-bf3f8a6e2010"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("de11516e-9126-4245-808d-3f95d508795a"), "I", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e118136a-5e8e-420e-b2bb-36588568b05f"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e2381648-b8dd-4351-8e87-13ab069bc1a9"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e3e86f20-81cf-41f5-8071-a29a3494b4d4"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e5451988-c100-4641-aee6-f129f2d92055"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e71c7128-fb29-4345-8a08-98c8ade3cd98"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e8583431-5184-4b12-a470-38e8dec48b07"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e8fd8e6b-9ead-4768-b501-3ff781140a62"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e942ddd3-893e-4b00-81bd-b4ce4de8f56a"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e9c68579-880d-40ab-b939-8553990bd146"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e9cfeefd-964f-48a3-97b0-4dc980c68027"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ea635520-1a85-4f7c-9a15-e94bc49e6f8f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("eaa13259-23e3-4706-b9ae-ad85c24d6fee"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("eaf95ebf-8c30-4239-a801-71ffe48ae46e"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ec5b9f74-db93-4c51-8835-dc38b186ce8a"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ef0f91ce-d76e-4f2b-9fba-15862a942d3d"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f0a68b00-a9b9-479a-a396-12cfb8ca08e4"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f20c23b1-c0d8-4695-bbf1-df6990f04fc2"), "F", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f2e64eaf-87fc-4289-8833-ec079febd2f7"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f3a5652a-d767-4f8c-89c5-da620eec5681"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f46a27bc-fef0-4072-84b1-b4152542ef42"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f52255f6-9dd9-4d95-8d14-efd0957c35b6"), "J", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f59c5e85-18a6-481c-8d6f-b657ab6df422"), "A", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f60f4051-4922-468c-83d8-93271663338b"), "C", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f70d70af-4750-4128-9cbd-182007a7ff71"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f7e3d259-ef12-4770-969d-ae516d5a217d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f8d8030d-ad34-442d-ad1f-0182c64ff718"), "D", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f8d909c0-2820-46e6-814c-b16548dd2511"), "E", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f9882a79-ad9d-42bf-ab99-484e391a79b5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f9db0a2b-ce09-473c-98ab-f1d26eae8939"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fa081088-ed48-404e-8802-de2ad1202ed5"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fae58ba4-5243-4bd8-866a-f37a89e2c88d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fdcaf8d9-7983-4f9d-94e2-c3151a1dae9e"), "H", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fe296ab6-2b17-4504-8597-cee9c0a6cd6d"), "G", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fe57aa94-75d4-4f18-af28-09783bb444e5"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fefe1711-afb3-4634-a7ab-7e0b4f01e3c3"), "B", null, null, null, null, null, null, null, new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ff2452c9-e67e-42fb-a062-5836a258e3a7"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("8abb34b3-c1c4-4044-b8eb-73a14fad9d07"), null, null, new DateTime(2024, 11, 24, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3577), null, null, null, null, null, new Guid("e444aa6c-29ca-41b4-b6b7-ee24a23eca5a"), new Guid("a0fd6bb5-6b44-43df-8855-252a63a00ef5"), 1, new DateTime(2024, 11, 22, 13, 51, 22, 650, DateTimeKind.Local).AddTicks(3576) },
                    { new Guid("d781d179-3ac4-4674-9d49-2f73f8f3ff37"), null, null, new DateTime(2024, 11, 23, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3568), null, null, null, null, null, new Guid("55a4ac91-39fc-4e96-9ea8-9ccbfc8a4373"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 11, 22, 13, 50, 22, 650, DateTimeKind.Local).AddTicks(3562) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("3e398695-ee06-4a63-8650-cef9648fb731"), null, null, null, null, null, null, null, 1, new DateTime(2024, 11, 22, 15, 49, 22, 650, DateTimeKind.Local).AddTicks(4191), new DateTime(2024, 11, 22, 11, 49, 22, 650, DateTimeKind.Local).AddTicks(4190), new Guid("b138cd93-ee4f-4941-9a88-a07e32b39b09"), new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(4189) });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_ReleaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("87eb3673-5dbe-498d-9c0f-56033e37d6c1"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3620), null, null, null, null, null, new Guid("55a4ac91-39fc-4e96-9ea8-9ccbfc8a4373"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 11, 26, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3618), new Guid("1369a3eb-a1fd-4da7-ba70-7ab3c3450a53"), new Guid("d781d179-3ac4-4674-9d49-2f73f8f3ff37"), 1 },
                    { new Guid("9b4f7532-79ee-4c96-a85d-14f3ac8f013e"), null, new DateTime(2024, 11, 22, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3610), null, null, null, null, null, new Guid("55a4ac91-39fc-4e96-9ea8-9ccbfc8a4373"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 11, 24, 13, 49, 22, 650, DateTimeKind.Local).AddTicks(3607), new Guid("1369a3eb-a1fd-4da7-ba70-7ab3c3450a53"), new Guid("d781d179-3ac4-4674-9d49-2f73f8f3ff37"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("913f0326-1533-4b12-b600-d90e9302837e"), null, null, null, null, null, null, null, new Guid("e444aa6c-29ca-41b4-b6b7-ee24a23eca5a"), 2100000m, new Guid("87eb3673-5dbe-498d-9c0f-56033e37d6c1"), new Guid("343ab268-91c5-4537-a895-5cde175b711a"), 2 },
                    { new Guid("a8d54afe-93a7-4b62-bb09-e6111c16df72"), null, null, null, null, null, null, null, new Guid("55a4ac91-39fc-4e96-9ea8-9ccbfc8a4373"), 100000m, new Guid("9b4f7532-79ee-4c96-a85d-14f3ac8f013e"), new Guid("f9882a79-ad9d-42bf-ab99-484e391a79b5"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("6117b259-7699-4049-bd72-d5630a82360e"), null, null, null, null, null, null, null, 60000m, new Guid("87eb3673-5dbe-498d-9c0f-56033e37d6c1"), new Guid("a1a1d2e2-d1a6-4b26-8229-2d3178fa85cf"), new Guid("1be33fda-b9bb-4960-bd5d-fd9cd6f188e2"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("968bd795-aefd-4b19-b1c0-0a306413414d"), null, null, null, null, null, null, null, 50000m, new Guid("9b4f7532-79ee-4c96-a85d-14f3ac8f013e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("1369a3eb-a1fd-4da7-ba70-7ab3c3450a53"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("627f667f-6dd1-4501-af12-29a80bb141f7"), new Guid("913f0326-1533-4b12-b600-d90e9302837e"), null, null, null, null, null, null, null },
                    { new Guid("c809a17d-ea49-45f7-9be4-f1612101b715"), new Guid("a8d54afe-93a7-4b62-bb09-e6111c16df72"), null, null, null, null, null, null, null }
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
                name: "IX_Screening_Show_ReleaseID",
                table: "Screening",
                column: "Show_ReleaseID");

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
