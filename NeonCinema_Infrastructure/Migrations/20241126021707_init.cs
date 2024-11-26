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
                    { new Guid("0553f8c2-932e-4bed-88a2-54d54c2f495a"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("303639bc-f9b0-4680-bff7-6f20c7723705"), null, "mua tại quầy" },
                    { new Guid("0d7b0cd9-1b7c-4440-bf6c-a1928bfb08c1"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("5c42b476-6a1f-4e9e-9008-f3543867a819"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4585), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("a96f5d8c-f3d7-4121-903d-88d76d306949"), "11:00 PM", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4589), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("2d3c61ca-eb48-4cea-90c9-421a4d5f623d"), "Hồng Kông" },
                    { new Guid("39ef0d87-6c12-4bce-a4c8-b3abdcf8b3b5"), "Vương Quốc Anh" },
                    { new Guid("56ee9420-544a-4958-8c7b-a258f13a0fff"), "Úc" },
                    { new Guid("57b3323e-a648-4722-81b3-fdc0b5a0164e"), "Ấn Độ" },
                    { new Guid("7be7bb32-72a1-42f2-ab62-a71859d84ab3"), "Việt Nam" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("c16544da-8c56-4b69-afee-29b750697306"), "Trung Quốc" },
                    { new Guid("d13e491b-adcc-44de-8d77-c3facaeabc64"), "Hàn Quốc" },
                    { new Guid("d433e37d-1b5b-4a2e-af25-667b020d24aa"), "Pháp" },
                    { new Guid("d44ecf78-0e45-4371-9f59-9324f77abefc"), "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("03253950-83de-441b-a604-9835a92edd0f"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("1f802416-a02b-4c37-8e28-99f70a58dc21"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("2931935c-8e88-4f38-8d15-972665074f2f"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("4e520403-6d3f-4de7-be4d-39265ff5d9c0"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("7b45bce0-3380-4799-9916-06dabebe8690"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("80ba9ea6-dc3b-4cf6-8b1c-07943c188d70"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("87c95c7c-e324-47a4-a0e5-9f39f7ee0cb1"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9b9abca6-e046-483b-abdc-d73007738a79"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("c8e1421a-174b-4a49-b978-3450e9e1f7b5"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("57dd6c97-df7a-4d00-afbd-d62702d1ebe7"), "Combo 2", null, null, null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 220000m },
                    { new Guid("f12fd76c-4aa0-40fc-9068-b7dfac763e9d"), "Combo 1", null, null, null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 20000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("24694a28-532b-4ba1-89c4-f365e56ad0e4"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("369bd13a-c532-4d0c-b258-9ba64954e39d"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("9751e419-d686-4ffc-ad87-14449310772d"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("9cd90fd8-709d-4009-a80e-6da734854248"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("c130de70-00a8-4f5f-9840-7c0b0f9a0f7d"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("cba709d0-3256-4151-8253-f28063aca957"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("de65a019-e9f2-458b-b484-4c35efe80724"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("faa178af-49c9-4bab-8670-b4cde03209a2"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("fd7cf549-d902-49fd-9f37-6cbc05db3f92"), null, null, null, null, null, "Lãng mạn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("25a6eb31-d097-4b6b-9a90-c5a857916662"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("2de027e6-6477-471d-8d50-461f20ce09cc"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "en", null, null },
                    { new Guid("964ad539-9bef-4657-94f0-81e2f8c58f1b"), null, null, null, null, null, "ja", null, null },
                    { new Guid("b7c87c90-6a37-403e-bf6f-76fa499944d2"), null, null, null, null, null, "vi", null, null },
                    { new Guid("e5efe4a6-c3e1-4038-ba9f-e3c039224647"), null, null, null, null, null, "USA", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("6a974be2-3476-485b-8166-d102118ab9f6"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("a6fe1659-4804-4254-b88c-c7e21246d7f8"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(3472), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(3497), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(3495), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("35d105cf-1801-49d8-9033-95c645dc8ab7"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4551), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4548), null, null, null, null, null, "Ghế thường" },
                    { new Guid("d7241173-c94c-4f4a-945b-a81d20aa9ced"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4555), null, null, null, null, null, "Ghế đôi" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1f7bfa72-b454-489e-92e5-828ec8c66de0"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("390bb6a5-f4f0-463a-a5a8-6e559d85e39d"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("628ad6e2-da9c-4ecd-93bd-591b26a68878"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("76c30b72-81be-482d-a23b-d214d1aa27f5"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("abaf4ea1-97a4-4c26-a601-545185d37578"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("c38f997b-dc64-4f7f-825c-96dfbf3a4720"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("ed32bf83-7689-4c75-a9cb-e56e8ee5045f"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("f5a9aa3d-603b-4b7a-8e50-a8f5f4cf5516"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("f5dfbd64-e28d-4819-9b8a-e0488f316978"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("f9887893-4352-4f95-8ad8-372c936ca583"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "TicketPriceSettings",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PriceAfter17hWeekDay", "PriceAfter17hWeekeend", "PriceBefore17hWeekDay", "PriceBefore17hWeekeend", "Surcharge3D", "Surcharge4D", "SurchargeCouple", "SurchargeIMAX", "SurchargeVIP" },
                values: new object[] { new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3"), null, null, null, null, null, null, null, 60m, 70m, 50m, 60m, 30m, 40m, 50m, 50m, 30m });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("183fcf19-ae43-4831-b713-e787856ba847"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5326), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("87c95c7c-e324-47a4-a0e5-9f39f7ee0cb1"), 145, new Guid("9751e419-d686-4ffc-ad87-14449310772d"), "nguoinhenvietnam.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("2d8e700c-7430-4fb1-ad72-547f6bcc5bcf"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5311), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("03253950-83de-441b-a604-9835a92edd0f"), 150, new Guid("9cd90fd8-709d-4009-a80e-6da734854248"), "emvatrinh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("6e49a42b-ce4b-4041-af54-b2e23885691e"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5335), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("1f802416-a02b-4c37-8e28-99f70a58dc21"), 100, new Guid("c130de70-00a8-4f5f-9840-7c0b0f9a0f7d"), "saigontrongmuaroi.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("8c1c90d5-7087-4825-8144-fab28eb2edc7"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5305), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("8f947c19-187d-48d9-8b21-7f2cfcccb239"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5297), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("1f802416-a02b-4c37-8e28-99f70a58dc21"), 125, new Guid("c130de70-00a8-4f5f-9840-7c0b0f9a0f7d"), "tiectrangmau.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("95cf92ad-75ac-4648-874e-2aae85366293"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5317), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("7b45bce0-3380-4799-9916-06dabebe8690"), 130, new Guid("faa178af-49c9-4bab-8670-b4cde03209a2"), "matbiec.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("b80eaa86-a702-41f2-af67-cfc3554fdfc1"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5275), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("03253950-83de-441b-a604-9835a92edd0f"), 120, new Guid("9cd90fd8-709d-4009-a80e-6da734854248"), "chimuoiba.png", new Guid("b7c87c90-6a37-403e-bf6f-76fa499944d2"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("c6d4353e-8ede-4999-8229-f7821fb4f02a"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5264), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "bogia2.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("e5a70c6d-1fa6-42c1-ae06-f15c73583d51"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5282), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("7b45bce0-3380-4799-9916-06dabebe8690"), 110, new Guid("faa178af-49c9-4bab-8670-b4cde03209a2"), "nhabanu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("eeb1bae9-075d-473c-a1c1-89c8ad95dd20"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5289), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("87c95c7c-e324-47a4-a0e5-9f39f7ee0cb1"), 140, new Guid("9751e419-d686-4ffc-ad87-14449310772d"), "gaigialamchieu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4621), null, null, null, null, null, "Room 1", 0, 100, 1 },
                    { new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4627), null, null, null, null, null, "Room 2", 0, 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0a6a1be3-4cb5-46de-b86b-cc83589b6b7d"), "Quảng Ninh", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4289), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("16ce2b28-f372-4837-b996-ab172c713fdb"), "Hưng Yên", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4210), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("42a6eb44-3f2f-4a2e-8e23-d34439e768bc"), "Hà Nội", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(3623), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5c0ef7b5-1ee8-4332-86c3-cdb0e30e4ecb"), "Hải Phòng", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4041), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6d90c9e2-7a86-450d-9ecc-65fe7800174e"), "Nam Định", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4261), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("74495c18-beee-4150-a20b-d663a6973304"), "Bắc Ninh", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4162), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("79c36a65-1f8d-4c1f-a343-604ff5b3dc2f"), "Hà Nội", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4012), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ad2b2f2c-f101-443c-8417-53ad43327bbc"), "Nghệ An", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4129), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b06222c4-f043-4cf7-a112-6485470a7226"), "Thái Bình", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4186), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bf7c6159-0370-41f6-89bd-3a6f0a7ea7da"), "TP. Hồ Chí Minh", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4103), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c5e3a059-884c-4e56-ba28-2315e4bb9c0d"), "Đà Nẵng", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(4069), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("2779796a-29c7-4c81-b7ca-a394d2291715"), "BILL008", null, new DateTime(2024, 11, 26, 6, 47, 6, 833, DateTimeKind.Local).AddTicks(5639), null, null, null, null, null, null, 2, 450000m, new Guid("b06222c4-f043-4cf7-a112-6485470a7226") },
                    { new Guid("3544fc7d-eb4f-48b5-83c7-160e7e96960b"), "BILL009", null, new DateTime(2024, 11, 26, 6, 17, 6, 833, DateTimeKind.Local).AddTicks(5644), null, null, null, null, null, null, 0, 350000m, new Guid("16ce2b28-f372-4837-b996-ab172c713fdb") },
                    { new Guid("4ac183a3-07f0-41e7-a8eb-39ecba595323"), "BILL0122", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5635), null, null, null, null, null, null, 2, 680000m, new Guid("ad2b2f2c-f101-443c-8417-53ad43327bbc") },
                    { new Guid("7a4ccfa2-6421-4a48-a83f-e0107f33d141"), "BILL004", null, new DateTime(2024, 11, 26, 8, 32, 6, 833, DateTimeKind.Local).AddTicks(5626), null, null, null, null, null, null, 2, 200000m, new Guid("c5e3a059-884c-4e56-ba28-2315e4bb9c0d") },
                    { new Guid("7da7748e-d62c-45b9-8b5b-501de02b3ea8"), "BILL001", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5610), null, null, null, null, null, null, 2, 500000m, new Guid("42a6eb44-3f2f-4a2e-8e23-d34439e768bc") },
                    { new Guid("86154b16-1a92-48d7-b324-31f8c9660067"), "BILL005", null, new DateTime(2024, 11, 26, 8, 17, 6, 833, DateTimeKind.Local).AddTicks(5629), null, null, null, null, null, null, 2, 250000m, new Guid("bf7c6159-0370-41f6-89bd-3a6f0a7ea7da") },
                    { new Guid("86e39416-8457-48d2-9572-6d666f83d540"), "BILL002", null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5616), null, null, null, null, null, null, 2, 300000m, new Guid("79c36a65-1f8d-4c1f-a343-604ff5b3dc2f") },
                    { new Guid("896952f4-4789-458c-ae95-a90dc39631d2"), "BILL007", null, new DateTime(2024, 11, 26, 7, 17, 6, 833, DateTimeKind.Local).AddTicks(5637), null, null, null, null, null, null, 1, 800000m, new Guid("74495c18-beee-4150-a20b-d663a6973304") },
                    { new Guid("a4a93a7a-6edd-4926-a990-a2345ce94a81"), "BILL010", null, new DateTime(2024, 11, 26, 5, 57, 6, 833, DateTimeKind.Local).AddTicks(5648), null, null, null, null, null, null, 2, 700000m, new Guid("6d90c9e2-7a86-450d-9ecc-65fe7800174e") },
                    { new Guid("bfa2fa66-fa82-419a-b6b7-1eaf743db0a5"), "BILL003", null, new DateTime(2024, 11, 26, 8, 47, 6, 833, DateTimeKind.Local).AddTicks(5624), null, null, null, null, null, null, 3, 150000m, new Guid("5c0ef7b5-1ee8-4332-86c3-cdb0e30e4ecb") },
                    { new Guid("d7ed166c-9591-4859-83b3-814b945815e5"), "BILL006", null, new DateTime(2024, 11, 26, 7, 47, 6, 833, DateTimeKind.Local).AddTicks(5632), null, null, null, null, null, null, 2, 600000m, new Guid("ad2b2f2c-f101-443c-8417-53ad43327bbc") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("cf1b9273-54dc-40cd-9ebc-0c64795249ef"), null, null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5728), null, null, null, null, null, 50, new Guid("42a6eb44-3f2f-4a2e-8e23-d34439e768bc") },
                    { new Guid("d37e7195-7da4-4e51-96b9-5465f8f2f777"), null, null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5732), null, null, null, null, null, 150, new Guid("79c36a65-1f8d-4c1f-a343-604ff5b3dc2f") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("04d0b938-dda8-4339-8212-3cb0b86b7464"), null, null, null, null, null, 100, null, null, "Gold", new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5709), 1, new Guid("42a6eb44-3f2f-4a2e-8e23-d34439e768bc") });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("06575929-a15f-4d45-822a-f9593767a6d0"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("068a61c5-9cde-4f56-a5a8-4b68a8630434"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("07213105-84e8-4c2a-9efa-61f12beff9cd"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("08f3e984-052f-4f1b-884c-9cc4d3b595c8"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0921b24f-7be8-4df7-85b3-67aa4190065b"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("09c5f803-4586-4caa-8474-b5edaa1c9be4"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0a4653ec-efb4-49f9-8be8-2e096773db33"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0b83b445-5c67-44cd-89f8-9352cbfef432"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0c4d2222-0c35-4067-a3c2-23c19a38ea49"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0cdb7b62-bce2-49b9-90cd-db703661e033"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0d341a0d-e402-4416-8456-6a365fde50ea"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0f27890a-2177-4efd-805a-1fad2258c3a2"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0fa6ce36-157d-4884-a622-335fbfe78905"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("143aeebe-091a-4486-bd3d-584a9deedcbc"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("14474aea-37b5-484b-a69a-01364b477868"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("147718cf-56ac-4335-8405-55cabfc7b038"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("147bc502-24f1-4c3b-9a55-c0643856df9b"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("14976b50-641e-4816-bdb2-abac39accf58"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1518f811-81b3-4099-b471-6b5439be6a18"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1a41b7b9-9b94-4be5-b03f-c117cd70b980"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1ad8e2bc-cb9b-4d5b-97fd-3349fd772e61"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1afd68c6-cfcf-4bec-b6ed-e3499352241d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1d86d28e-61bd-4719-8f54-bdfe8b51e9ef"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1e55c9e2-a043-4a02-8a9e-0a7c5bd7986f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1ec0f120-c8aa-4352-9c18-aac5e14120c4"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1f2a6679-3424-47b0-8904-b763c797ddf4"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1f723419-d10b-4b50-a7cc-47146077aec3"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2014ed8a-c6ae-4008-8dfc-67bf8dcc3145"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("20c8395e-716d-4e8d-bb1b-db252519a1dc"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2104d1cb-73bb-4c92-8d54-055fa82d9784"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2172df84-36d9-4847-98b0-84343a28c95e"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("219f0324-b235-4166-a4a5-25a03c072c51"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("221a363e-bc05-4679-9805-bf5f76ff304f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("22aefad1-2ccb-4f62-aab1-cf3d537cf4cd"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("23fa9c14-58f0-42df-bfdf-536aaae8c282"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("248b15f5-4758-4ca0-82db-4b8b66940a54"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2496043b-3a52-4fa9-bb7e-9e3ff0bd3451"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2534b1ee-5cf4-4e6d-b844-26c9ce827cc9"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("267182b1-379d-43f8-a647-1071b4ae7461"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2846119a-9e48-4c92-9e89-cdfe22c2c52b"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("286e4bb1-318d-40e3-bef2-f5dd5f8ed1ec"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2dd04fa6-59d5-45d4-b39c-46db28dd210c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3063048d-b88d-49d5-a380-3cb51a8829c5"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("320fa792-3749-4501-9187-499764615a6b"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3483242d-fa92-4c59-a77d-f06c52af17f8"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("37b2ab01-026b-4b98-b6fd-5c7c8e8ce629"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("38364028-bde5-40ba-bb05-a2a997e68645"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3ab80427-fdce-4a59-9e28-fdeb46561b70"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3ac1c3c8-dafe-44b7-bab3-3df2b3e8700e"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3ad77d2e-4a41-4e6d-8aeb-304390f44339"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3b43dcc5-d155-4eac-95be-997c1cb79657"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3c0a9ad3-1c7b-49bc-adff-407855e92084"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3ca7b643-24ad-497b-acb6-474c33cc8834"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3d2ae700-01c8-4bce-aba7-925b03aebb25"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3e2d3369-8d5b-4732-a4c3-73fea0acde61"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3e6b9131-54d5-43a9-b911-8d00b188ca7f"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3ec39c96-bbb6-408f-a614-e1097959d3ac"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3ecbb027-d76e-4f4a-9a10-c9b5ce6dfcf6"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("420de416-5ca3-489a-a135-f77358bf98f5"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("433bc67a-9a6a-484b-827f-4801271333a3"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("436acf78-e0c9-470a-b429-8aa2e9a8b997"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4370a823-57a8-49a9-b584-b1608f8800ba"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("442aed37-0f9c-44cc-ad04-542f51b87f41"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("445ab527-0028-4b94-8f40-5a39d01136cc"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("44b265b1-9552-4b2b-bfa7-06cd23e5f74f"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("45245b5f-ff6e-4ccd-97b2-68c73529d787"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("453ead7b-485e-4c3d-a2a2-fae8401b9dfd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("45997e39-a8f3-4acc-9852-4d6737af2fc4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("46a6153d-82e2-4c00-b005-07a63d44c66e"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("48ec3d67-af2c-4313-8897-c45e7963676b"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4b18bfc8-4c6e-40d2-bfeb-511aa829556c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4de53a28-7488-4507-bd06-024c68dce677"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4df461f6-843f-4ed1-94a6-df301b9c60a0"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4f64cebc-8fd9-4a9a-ada1-2dea96a22842"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4fb9873e-f3a1-4b69-98b3-d4e019093a23"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("502faa25-dc0c-4909-8647-6b8ee3ae814c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("505defd5-1d8a-4bef-9571-136e7faf06bb"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5093aadb-e1c7-4123-81a6-0df1fd330172"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5116c43c-6a00-4bf8-9deb-902402ad8e07"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("51f9f807-b5c3-4a95-a8f8-e5b65c7c60b5"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5579e4ce-67a1-45b9-8240-9187c3fcc5fc"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5593b277-d51e-4d14-a926-b99a1bceae81"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("55ed0d7b-3cfa-496c-8e6d-ef2b4083d859"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5700b5e3-7ca7-412b-836d-f67861156569"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("58feee8c-eb43-42ca-997f-db308c219092"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("597dadce-af87-4142-bef7-fed457cfaef3"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5a34c627-09ec-4b42-ae13-12a0afc7d920"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5bceb489-72de-4d54-9566-594954437d70"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5c3c925c-f00f-4f1d-968e-162633d1cc5c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5cd67040-39de-478a-b07c-fbf901a9bc9f"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5e82cedf-41dd-4404-a0aa-5688fd68d274"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5eb0f473-5644-44a2-b19c-26ad5a38baef"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("605511b6-dedc-4610-b837-f983db58d95e"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6123e90c-8124-4438-bafe-de2ba718fcbd"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("618a740b-000c-46d1-9e2a-d902edff6af4"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("62895c29-fd7b-4491-b72b-0b0323fd4b59"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("62a41439-dc41-4d40-8b41-a496920a9cf1"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6452b331-a156-413f-b27a-f37b4c437b6c"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("66b7f29b-a5f4-44a0-8405-b65fdf600231"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("675af43f-5c2d-4cb9-908a-835cbc44e6f6"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("697c6518-2b58-42d4-8a18-c003415fbb27"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6c19b69b-55c3-402c-973e-a1e2bbbb8bb8"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6ce9c773-8a3a-41d7-82d7-c15e5b2fd4dd"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6d716e25-352a-49d6-97ac-c468996b3e53"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6de36333-0eb9-4a77-975a-3b5c3a1964a0"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6f207662-24d3-4ba1-be8a-f809937b2c41"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6fdabf74-2609-4138-975d-5294984032f1"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("702bb477-c755-4b64-aba4-ba6f49d6160f"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("70fdb784-bdf5-435d-83e6-26b7f3315526"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("74cbd69c-de19-401f-a541-dbdb9a4e231e"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("75650382-30a6-403b-b767-e856f0b779fc"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("75f64d23-e247-4052-b793-21bcb9e0f690"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("798b7b86-ebe8-4257-902b-92ea9429680f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7a6bf7a8-0bad-4547-a978-387578cb9f49"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7a79dc3d-4749-4a17-b9ba-b3fbd7dc421a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7b4d33ff-f65e-4663-8a6b-ea2320856d36"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7d332635-aadf-4728-b164-0e7a3a7e7184"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7d3db00c-034d-4966-8327-bd6ecfd572ad"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7d78e7e0-6c11-40f1-a60b-b26ac68ec8bd"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7ddf3137-b6a9-4252-b1a9-617d3be90e7e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7de2fe33-9765-4141-abf9-858e1d35756d"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7e5a2964-e88f-485d-964a-11ab5c7ea7b2"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7eb81063-a3b3-46e2-bc03-e9832d3024e4"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("80e57b16-731a-4784-b815-8fa511e0ef7c"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8141c459-aff7-4b9c-99ff-5255d1135ada"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("81bfa33b-0fe4-4cac-854f-e6e40cdeedf7"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("82b9385e-61dd-4106-aad3-2fd0bf3c2be1"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8300b2f5-03e0-45cd-9b13-6eea8902b4b0"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8337f93d-cdd4-43bf-ad9b-178f206d520a"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("84145ed6-1008-4056-a582-ff0c38993e56"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("84c651ee-dcd2-44e1-b0ee-fb6d766f42ce"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8574a2a5-686d-47ff-8921-c653501e3d78"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("85d5f856-d400-4426-991d-eb93eb584b49"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("874eafea-d7d6-4ae4-bbec-55d63ce211e4"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8758b1f2-57b3-458a-90f9-ede7ae1443af"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8860562f-ee81-4179-91a1-ca9f77ca32c5"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8868ef3b-524c-49ac-9d0d-418d0530d9f3"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8a7f7205-1b21-4f5b-bde9-097f23dee387"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8c7a3963-cb10-4457-8afb-a0f139d9c873"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8d8b9b38-49fb-49ed-ae03-d200102c243a"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8db8f5d0-e9d7-479b-b8e6-a1039f62d2c5"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8e967205-87ba-4406-862d-9647d33170d2"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8fd34e41-c24e-4995-bb0f-b8de992e2794"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("906155bd-6206-4115-af94-cab97108b5e9"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("91f8dcf7-9fcc-4d76-88ac-2d0ec0f11d09"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9221ab41-302e-47f0-88f3-076b41e70815"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9260892e-059b-4fa0-96af-9bdb083802d0"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("92c86667-4a07-40d7-b204-047f663ff27b"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9305055d-4420-45c1-a8a7-bf225f85f64d"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9310e2a3-efbf-4c83-aa4b-1639f1e055f3"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("934103b4-d0d9-402d-a336-714a18feba85"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("93cf8ffb-395e-4a4d-88f0-6c3b2ed90b4a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("95bdf334-1961-46ed-92d6-d6923cabc779"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("95e56fd8-6383-4487-905c-c9e605737db9"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("96402bc8-4850-4ea5-ae78-982bc697d324"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("969824a1-2798-416f-ba03-06f2a719914f"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9705174f-58cc-483a-8146-b576ee6fdf67"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("976cefb9-66a2-46c0-b8c5-44ab98b35364"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9812279c-0a40-42b0-b358-2b601d5c1662"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9a2fe3e0-b61d-4ae3-ba30-0aa045855a36"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9a4474f0-66b9-4009-8170-35a187fa172c"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9b217669-d49a-43ff-9edf-325bafb6b855"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9e795a14-5a1b-4ab1-8091-985fd349deb7"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a21c1b53-b265-4cff-9b3d-3da863429b9f"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a2234309-e93f-4b8c-9294-695d0ecef201"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a3f6e5c7-7a3c-42fa-914c-19e7c49b353a"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a4bfa81f-b5e8-4a53-9548-b97077d8438d"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a537d5a9-e08a-4389-a08c-5abb5147830d"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a5ee2a54-825c-446e-8288-81b935d9b50b"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a61459e8-7292-48fa-a9b2-73f8a7e40d23"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a787ce7a-165b-4fcb-93a1-bfebc9911b75"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a88a56da-d9c1-4ea3-81ee-26f155c25c5f"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9163026-dde8-472f-a7d2-c7000c13cba0"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9b3d542-df47-420b-aba5-291b587d3262"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aa61bd7c-005d-4acc-b4cf-b9c1ea0b8404"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aaa8d40e-d343-4b0e-aa12-cabad722a0c7"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aac96122-5d53-403a-bf02-964ed85876a4"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ab677b57-bb24-4651-a09d-2035f20c496d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aee8e3c3-11e7-4754-9a46-2629b7959f0d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b19ee4f5-b91b-4bfe-ae66-3426f7fa4b44"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b2849d72-64f8-47ae-89dd-bc97c39d51fa"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b3066ba5-b4fe-4b3c-b9ad-51290d484ba1"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b35860b9-50f1-416e-96c2-f9ace0626529"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b50a203c-5f8e-4e4c-9389-0aff9dd8e965"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b78d1b35-071a-4dd4-b7cc-f54e6b0b6bb0"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b985fd65-7787-4c22-a8ff-a37793541dae"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ba474629-2516-4ca4-b090-98d4488d9a1d"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ba6ec660-45a5-4ca6-9c70-87ed8e786b9e"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("bc997e4a-be7f-48d2-956b-7495b17f6b69"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("bd068051-2387-4030-ae97-9e2b01fb850a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("bd5bd5df-9419-4041-93ce-fcb55aba1745"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("be2719c8-0554-4489-ab33-85d5c2714323"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("befdf689-348e-4eba-be34-e67faaa92063"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c02209c9-7516-432f-b442-cbbe98574114"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c0de7bb4-be92-45d8-9bdb-9d91945088c2"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c1999db0-7eb4-4865-9223-5a1737d89339"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c4e6b57d-95aa-408a-9560-90f31bc7be4c"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c5b4d7ac-1d72-43b9-a9c2-d38e925c2c74"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c6e362c0-50c7-4e40-9766-de147b4d73a5"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c70c7cbc-407b-4699-bd77-e5e7bc06989f"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c89348c6-6d4c-494e-8225-6b51cb26b2e6"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c94c1534-ac8e-449d-a0e1-3f29d57b2917"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ca8fc10a-8da5-4d2b-8766-df8f9f92736a"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cd98b634-dcad-4cf0-adf2-a48bdf047fb4"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ce45d78c-8ef8-46d3-bdee-af8183eb4c02"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cf20efa9-cdbe-41d1-821d-2f67bf7e15b6"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cf85b160-1ff6-474b-a5dd-8a73bad120b7"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cfb85004-ca7f-4d25-826c-3ce54e656cdf"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d1427dda-9168-4a4a-a950-999367b81ebb"), "I", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d234f026-11d4-4caf-93d5-bf0b52877039"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d245760e-4d09-49a5-8b57-fd0dcf43c78d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d2d37ccf-c06b-4a7a-adde-24779c58ccac"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d41251eb-2166-44be-b3d5-253e0d1aa006"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d56b599b-7e95-4077-abf3-bbcec55efefb"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d600625e-f793-428b-abda-82f0b92f1d21"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d6ccf5c1-1eab-4d7f-802d-e606617b7941"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d7d2e42a-64d1-4802-8ff8-dfbc194aa507"), "B", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d80e4a98-06ee-4b37-9b27-418f83bcbf83"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("da823647-19ff-43e4-b337-1b0179a50554"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("db5ddc95-2122-4041-b6e8-6d5a79767db9"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("dbe8d204-79c9-498e-842b-3b0c9b7a8ca9"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("de625a04-f257-4a6a-b163-72e12f97208e"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("df7e4397-28f2-4340-9865-fbaae03ef43a"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e053f98b-27ec-49a9-ae0a-9161d65ff020"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e0e285e1-e88e-4bba-86da-767627d9483b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e0fc7a88-1b7b-4ea0-8213-cb5eea732434"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e63c0638-7a93-4f2b-b4ea-dc2ebc1005dc"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e727edd7-960f-41a0-b284-94cb31a69ebf"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e7bb48d0-8135-42c5-8d55-fdc747e11b21"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e827ae73-0413-4ea7-bd5f-22aad5e38851"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e874b3e2-b308-4cd6-bd70-0072d60a9268"), "H", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e8d4baef-7387-4120-b1c7-8cab014def16"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("eaa6150a-eed0-4374-afd0-ed6f05e5a727"), "E", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ed458319-e863-46d1-913f-981bb4ce4199"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("edbdfefb-6c40-45a7-9f88-8e58452c42de"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("edc4f900-1706-46eb-a9a1-48a565db3740"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("edfc4dd7-091a-4f5e-b8ed-5938d52f26b1"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f40ca320-5d43-4ef5-998c-96844546decd"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f4e1fb07-d61e-468b-b0a2-bb08692925fa"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f50c0f87-4b3a-4476-9868-786cc8d29a51"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f5553c2b-4154-455a-952e-df389ffe7a34"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f563dec3-2cb5-4cfc-82f8-25c3c0dc076f"), "C", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f566b360-7ce4-4d3d-846a-48754aaceade"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f721a40e-8d5a-45cc-b8d1-5eb16dcb32b1"), "A", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f7a04a32-4f37-4e38-bba6-662e9f909ff9"), "D", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f7d3e19d-9cba-4d22-b211-a9645b06f8a1"), "F", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f838c016-eb1b-4655-ab94-e558c93cc3b3"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fb5a77cb-d05c-4a60-8a44-f115dcdbbfbe"), "J", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fdee337d-4989-4fe1-af16-4388741471c0"), "G", null, null, null, null, null, null, null, new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ff232541-c1b8-4931-9950-5f716ed6ec98"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("ba60981f-539a-4e8f-b049-1db58e3d9de5"), null, null, new DateTime(2024, 11, 28, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5381), null, null, null, null, null, new Guid("b80eaa86-a702-41f2-af67-cfc3554fdfc1"), new Guid("f3e43305-b39a-4582-b2f4-9353df9f5614"), 1, new DateTime(2024, 11, 26, 9, 19, 6, 833, DateTimeKind.Local).AddTicks(5380) },
                    { new Guid("f557903a-7341-43ec-b2fd-699990121633"), null, null, new DateTime(2024, 11, 27, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5374), null, null, null, null, null, new Guid("c6d4353e-8ede-4999-8229-f7821fb4f02a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 11, 26, 9, 18, 6, 833, DateTimeKind.Local).AddTicks(5369) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("db8da23a-e4e9-4be3-b1bb-7935ae2d407f"), null, null, null, null, null, null, null, 1, new DateTime(2024, 11, 26, 11, 17, 6, 833, DateTimeKind.Local).AddTicks(5764), new DateTime(2024, 11, 26, 7, 17, 6, 833, DateTimeKind.Local).AddTicks(5763), new Guid("42a6eb44-3f2f-4a2e-8e23-d34439e768bc"), new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_ReleaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("b640b127-7637-4015-ae69-b48c7622882d"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5409), null, null, null, null, null, new Guid("c6d4353e-8ede-4999-8229-f7821fb4f02a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 11, 28, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5407), new Guid("1f7bfa72-b454-489e-92e5-828ec8c66de0"), new Guid("f557903a-7341-43ec-b2fd-699990121633"), 1 },
                    { new Guid("f791e9c9-b4c8-4571-945c-c57252c62b55"), null, new DateTime(2024, 11, 26, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5415), null, null, null, null, null, new Guid("c6d4353e-8ede-4999-8229-f7821fb4f02a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 11, 30, 9, 17, 6, 833, DateTimeKind.Local).AddTicks(5414), new Guid("1f7bfa72-b454-489e-92e5-828ec8c66de0"), new Guid("f557903a-7341-43ec-b2fd-699990121633"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("186d361e-d7d2-41bf-ae7d-64947dcae261"), null, null, null, null, null, null, null, new Guid("b80eaa86-a702-41f2-af67-cfc3554fdfc1"), 2100000m, new Guid("f791e9c9-b4c8-4571-945c-c57252c62b55"), new Guid("1ec0f120-c8aa-4352-9c18-aac5e14120c4"), 2 },
                    { new Guid("52e4ff2b-8c6e-444b-bb59-ea69b10d2ec4"), null, null, null, null, null, null, null, new Guid("c6d4353e-8ede-4999-8229-f7821fb4f02a"), 100000m, new Guid("b640b127-7637-4015-ae69-b48c7622882d"), new Guid("edfc4dd7-091a-4f5e-b8ed-5938d52f26b1"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("303639bc-f9b0-4680-bff7-6f20c7723705"), null, null, null, null, null, null, null, 50m, new Guid("b640b127-7637-4015-ae69-b48c7622882d"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("1f7bfa72-b454-489e-92e5-828ec8c66de0"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("5c42b476-6a1f-4e9e-9008-f3543867a819"), null, null, null, null, null, null, null, 60m, new Guid("f791e9c9-b4c8-4571-945c-c57252c62b55"), new Guid("35d105cf-1801-49d8-9033-95c645dc8ab7"), new Guid("628ad6e2-da9c-4ecd-93bd-591b26a68878"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("7da7748e-d62c-45b9-8b5b-501de02b3ea8"), new Guid("52e4ff2b-8c6e-444b-bb59-ea69b10d2ec4"), null, null, null, null, null, null, null },
                    { new Guid("86e39416-8457-48d2-9572-6d666f83d540"), new Guid("186d361e-d7d2-41bf-ae7d-64947dcae261"), null, null, null, null, null, null, null }
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
