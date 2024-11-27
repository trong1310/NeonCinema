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
                    { new Guid("8528fd4e-eb19-4950-b2e3-71564ef6e26c"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("a480d3cd-2a41-4c51-98e4-9d1239717fd2"), null, "mua tại quầy" },
                    { new Guid("98fc6e71-7294-4ff0-8928-4621f1b0e57b"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("2d9f3708-d873-46f8-a535-d7c699dec64b"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("559a0092-4a09-4374-935b-39250d57fc51"), "11:00 PM", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4144), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4138), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("08353c90-096c-4427-87f2-8424f1782bd3"), "Trung Quốc" },
                    { new Guid("0a582c87-b657-4fe2-8d13-0d069c894962"), "Úc" },
                    { new Guid("17e8ca0f-d2c4-4e27-ae55-69e78aeb7856"), "Việt Nam" },
                    { new Guid("30e826e0-2838-4326-a32b-d4b889a95454"), "Hàn Quốc" },
                    { new Guid("648594f7-5184-42f5-a684-630b68d5b43f"), "Vương Quốc Anh" },
                    { new Guid("78856539-5617-42fd-99fe-50b9eb1cdf30"), "Pháp" },
                    { new Guid("8145fc84-ff5a-4775-8880-642e383725a3"), "Ấn Độ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("aef1bba7-be08-4cc9-969a-5a7f544282b6"), "Hồng Kông" },
                    { new Guid("e0f0e41c-a79c-40b4-acb9-a765846f9635"), "Mỹ" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("2129855f-8f2b-47f0-9ae3-ecdb85cede0d"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("2b8f7f9d-90f8-4435-b63b-6505a7b96076"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("79eda1e5-499d-4ca5-a8fb-e60c764f4ce0"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8163e263-4bd5-474b-b305-7323e99c3ee2"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("8b9d97e6-c323-402b-9985-d1fcda199327"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("b1e251c2-5f7c-41ee-a0a3-5eb61369879b"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("ce68221c-78e4-4198-9b2a-a85a171751a8"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("d35ecf6f-bb34-4c0f-b38d-6f3ee20062b7"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f37a7279-e7b0-4b4a-a4fd-f237556c9489"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("760fc8a5-2615-4178-8b95-93ffe98a57ad"), "Combo 1", null, null, null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 20000m },
                    { new Guid("e0d9e604-6e78-4636-afbf-8ef534310b1d"), "Combo 2", null, null, null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 220000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0b218867-c720-4450-99a9-5f6be06e1a17"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("298c7288-6fc4-48cc-bc57-87382616f974"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("5ab763dc-7638-45cb-99d4-38ae09c52bad"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("696850a9-37bd-435d-a526-2003d832f0df"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("6c59eccc-3cf8-42f0-8ae3-212be9106abe"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("b57ff993-d62c-4dfc-90de-0f788ff614e8"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("c4438a3b-8ea5-4551-b19f-76957f25599f"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("e8da10a7-fbc3-456b-93b3-1137356ae06f"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("f4780501-e9ee-4d09-afd5-31ae58ca9638"), null, null, null, null, null, "Tình cảm", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("2e71e156-a391-433d-a502-ea14e2f6269f"), null, null, null, null, null, "USA", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("a09e3892-97f9-4ce8-9f0c-5e465c99fc10"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("a767e8ba-14b4-4302-b81e-ec4a45870874"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("e06c7c68-93a1-4c46-88fe-12625a2ee8ba"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("e602e215-ce40-4804-8bc0-80aed05754f7"), null, null, null, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("77d064a9-5a88-42a1-bfa8-9b3d2ae5c0b4"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("dd0d78a5-1c5a-4bcf-949b-83669425e035"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(2738), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(2784), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(2778), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("8f8e74ec-6da1-4b41-bd1b-83feaa46a519"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4114), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4109), null, null, null, null, null, "Ghế thường" },
                    { new Guid("a22f9a3b-4728-49de-9edf-34f47a1a9421"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4112), null, null, null, null, null, "Ghế Vip" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2f2fc044-1a82-4163-9524-fd702237ca4b"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("33ff2845-6dd1-43b5-9757-58c2754e64ab"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("345732f5-5d6b-4f67-8d58-50c995f335b4"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("7cb52e8e-db9a-4832-8519-5964be48c90e"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("a7383f63-e647-4d2e-b782-2c5a1c7cc15f"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("c79d2b15-9d9e-4e4d-9895-fda08e02930e"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("ee76c6ea-e167-4f4b-b7de-f2c6129913cf"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("fa97c02c-ecfd-42ef-b808-cea62b2271cf"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("fdc2e703-e4da-4fbe-b40c-24845634cde9"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("ff91ce7c-bd47-4996-9de0-dc1ceef2d523"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 }
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
                    { new Guid("220a7819-1e39-4867-b6ef-2b978c2a66cc"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4885), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("8b9d97e6-c323-402b-9985-d1fcda199327"), 120, new Guid("f4780501-e9ee-4d09-afd5-31ae58ca9638"), "chimuoiba.png", new Guid("e602e215-ce40-4804-8bc0-80aed05754f7"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("314473de-40f1-4612-b916-28a7c2b38a74"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4956), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("8163e263-4bd5-474b-b305-7323e99c3ee2"), 100, new Guid("5ab763dc-7638-45cb-99d4-38ae09c52bad"), "saigontrongmuaroi.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("31d24314-f829-4ab8-bac7-df82dd80ff2a"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4875), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "bogia2.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("3c1f3db4-9578-42b9-b283-2b5019fb2d4e"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4908), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("8163e263-4bd5-474b-b305-7323e99c3ee2"), 125, new Guid("5ab763dc-7638-45cb-99d4-38ae09c52bad"), "tiectrangmau.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("48dc8e9f-bb97-421d-846c-071f84cfa035"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4893), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("2129855f-8f2b-47f0-9ae3-ecdb85cede0d"), 110, new Guid("0b218867-c720-4450-99a9-5f6be06e1a17"), "nhabanu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("51dbea9d-16d9-4fb7-b0c5-882aec79c9f4"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4902), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("d35ecf6f-bb34-4c0f-b38d-6f3ee20062b7"), 140, new Guid("c4438a3b-8ea5-4551-b19f-76957f25599f"), "gaigialamchieu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("5205f9b8-cd2f-48a6-b1f0-70b7d4f86500"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4928), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("2129855f-8f2b-47f0-9ae3-ecdb85cede0d"), 130, new Guid("0b218867-c720-4450-99a9-5f6be06e1a17"), "matbiec.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("75feef8e-5e63-496e-ae88-fc8f16c40fd8"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4949), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("d35ecf6f-bb34-4c0f-b38d-6f3ee20062b7"), 145, new Guid("c4438a3b-8ea5-4551-b19f-76957f25599f"), "nguoinhenvietnam.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("aa03c41e-e2c1-4f29-9f6e-d29dcd9199eb"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4920), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("8b9d97e6-c323-402b-9985-d1fcda199327"), 150, new Guid("f4780501-e9ee-4d09-afd5-31ae58ca9638"), "emvatrinh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("eaf702a2-979a-44ae-bfa3-47e516ba0ddf"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4915), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4187), null, null, null, null, null, "Room 2", 0, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4182), null, null, null, null, null, "Room 1", 0, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("123a6b1d-17a0-4736-bf40-74c1c8198738"), "Nam Định", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3834), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("145ee07a-91aa-40ef-9721-3a498de58f8a"), "Hải Phòng", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3645), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("29cd0d87-74d3-4f31-98c8-315a2af17f66"), "TP. Hồ Chí Minh", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3696), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2e9262f6-f307-4061-a5be-ac8d5f8fba23"), "Hưng Yên", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3792), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("54221ea5-e947-43b1-be5f-30abe2f79d4b"), "Bắc Ninh", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3751), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("60b37219-68ea-471e-8967-e3a4a9bae5eb"), "Đà Nẵng", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3673), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("823c194e-adcd-468b-9c1c-c508c22f13db"), "Nghệ An", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3727), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8b1388ba-2bb6-4c3b-bee7-6cb7be991300"), "Hà Nội", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3606), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("93e775d8-b781-4243-824d-b8a65bfe4550"), "Quảng Ninh", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3860), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("acc78752-f87b-4206-92d0-9e9ff1434d4f"), "Thái Bình", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(3771), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fdc82ea7-c79c-4502-8e18-b37b413a1816"), "Hà Nội", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(2925), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("043b8a02-79c6-4b53-9620-df9a6e222a56"), "BILL009", null, new DateTime(2024, 11, 27, 5, 12, 36, 122, DateTimeKind.Local).AddTicks(5264), null, null, null, null, null, null, 0, 350000m, new Guid("2e9262f6-f307-4061-a5be-ac8d5f8fba23") },
                    { new Guid("0a44bfe0-132e-4d14-bd58-9a8e50ac720e"), "BILL002", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5238), null, null, null, null, null, null, 2, 300000m, new Guid("8b1388ba-2bb6-4c3b-bee7-6cb7be991300") },
                    { new Guid("6b278b13-fa52-4bda-8640-935b64dc1a6b"), "BILL003", null, new DateTime(2024, 11, 27, 7, 42, 36, 122, DateTimeKind.Local).AddTicks(5241), null, null, null, null, null, null, 3, 150000m, new Guid("145ee07a-91aa-40ef-9721-3a498de58f8a") },
                    { new Guid("ab5fd40c-56ae-41a4-be42-18093c864506"), "BILL010", null, new DateTime(2024, 11, 27, 4, 52, 36, 122, DateTimeKind.Local).AddTicks(5267), null, null, null, null, null, null, 2, 700000m, new Guid("123a6b1d-17a0-4736-bf40-74c1c8198738") },
                    { new Guid("c3835c82-8c72-4ff7-83cc-c24e077bd997"), "BILL006", null, new DateTime(2024, 11, 27, 6, 42, 36, 122, DateTimeKind.Local).AddTicks(5252), null, null, null, null, null, null, 2, 600000m, new Guid("823c194e-adcd-468b-9c1c-c508c22f13db") },
                    { new Guid("cf5f9a45-1030-4be8-9473-95d31e318b39"), "BILL004", null, new DateTime(2024, 11, 27, 7, 27, 36, 122, DateTimeKind.Local).AddTicks(5246), null, null, null, null, null, null, 2, 200000m, new Guid("60b37219-68ea-471e-8967-e3a4a9bae5eb") },
                    { new Guid("d647222a-ad0b-4f3b-bc72-3babb3d2db6a"), "BILL0122", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5255), null, null, null, null, null, null, 2, 680000m, new Guid("823c194e-adcd-468b-9c1c-c508c22f13db") },
                    { new Guid("da939aea-dd28-4ff0-8b1b-fa9a347ebf29"), "BILL001", null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5234), null, null, null, null, null, null, 2, 500000m, new Guid("fdc82ea7-c79c-4502-8e18-b37b413a1816") },
                    { new Guid("e38f8e56-32bc-47a0-b1fe-a774c3d6e41f"), "BILL008", null, new DateTime(2024, 11, 27, 5, 42, 36, 122, DateTimeKind.Local).AddTicks(5261), null, null, null, null, null, null, 2, 450000m, new Guid("acc78752-f87b-4206-92d0-9e9ff1434d4f") },
                    { new Guid("ea1aa202-422b-4d3a-b49b-5d26b87b9234"), "BILL005", null, new DateTime(2024, 11, 27, 7, 12, 36, 122, DateTimeKind.Local).AddTicks(5249), null, null, null, null, null, null, 2, 250000m, new Guid("29cd0d87-74d3-4f31-98c8-315a2af17f66") },
                    { new Guid("ea2f2d86-2d8f-4038-bb1e-627bc639719b"), "BILL007", null, new DateTime(2024, 11, 27, 6, 12, 36, 122, DateTimeKind.Local).AddTicks(5259), null, null, null, null, null, null, 1, 800000m, new Guid("54221ea5-e947-43b1-be5f-30abe2f79d4b") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("0c28b86b-f78b-4e84-b2c6-31344533fc22"), null, null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5351), null, null, null, null, null, 50, new Guid("fdc82ea7-c79c-4502-8e18-b37b413a1816") },
                    { new Guid("b11907ae-c62d-4e67-8866-7c8c07412cf8"), null, null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5355), null, null, null, null, null, 150, new Guid("8b1388ba-2bb6-4c3b-bee7-6cb7be991300") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("542234a0-76e9-4057-9639-290c342eed89"), null, null, null, null, null, 100, null, null, "Gold", new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5327), 1, new Guid("fdc82ea7-c79c-4502-8e18-b37b413a1816") });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0463b80a-6590-4e5e-8b9e-1b32612df4de"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("04980660-28d0-4a30-b5ef-0826362da43f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("08651043-8dd2-4e3a-a5c7-3a6ac3b0ba30"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0968845a-deca-4401-a300-fe682e32c104"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0a300269-0c94-4c0c-a996-c660b2f45803"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0c83372a-51b8-4412-a032-c1da8f939674"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0cefd211-a789-4e76-a085-8915f4ad7b3a"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0d77c7bd-5532-4121-beee-fb99fb5c4e41"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0e0379f3-26dd-473a-8e0a-d358f7c5a3a7"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0ea79491-a1d8-4b5a-852a-b98de01853cf"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("0fb402f2-b69d-42dd-a7bf-a720109feb44"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("10ce2ff4-8946-445e-9588-ec99de5dba7a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("10ee1c3a-da1f-48fa-a6aa-4dc62067435f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("12ca22e1-5fa8-4ab2-bc36-334bbd079543"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("13229f48-570c-4781-8a91-aa3b188c8358"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("13e81dd2-ac49-44d4-89ca-54f6d31579cb"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("14616062-c695-40b3-a3a0-264f0644cc7e"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("15ad14b9-36c7-4adc-827c-b598ccceefdc"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("168863eb-2023-4571-baf7-81288d84a196"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("175dcfda-332d-4a0e-aa9b-62bd2d385632"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("18519c83-d5f6-4686-adc6-a5beb5768c5f"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("19e70e63-9f6d-4186-975c-a778e44d1ca1"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1b8d76e9-89b8-4308-8547-78a1b055c8a6"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1c3dbdea-f018-481c-833b-9a1970e5af18"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1c795b1c-12ae-455f-8b2b-d7db5318ccc2"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1c9ff095-2bc4-4a6a-a98b-fe653d49cff3"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1d3bf075-6e9c-4e77-a1c7-05c1b3ee5b54"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1d7cc7b7-8d1f-4e3c-95c3-b982d8e7a6aa"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1fd58498-f960-40aa-bd05-8659e31a84c0"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("1fe7994e-a3f5-4701-b314-e81143a392d9"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("20572cbd-2a30-44e3-8db0-d56f22d98791"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("216b5702-4641-4247-895b-e4cc361719ed"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("252678ce-981c-4112-bd15-9dd3a7d3a104"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("258587c7-5cd6-4c53-af47-a1888556d21f"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("25b9dd32-508e-4fbe-9f5e-93a53715bd39"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2b6f9049-da00-4335-a021-fd67cbe38063"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2c178e3e-93fc-4e28-a159-95f4d021c2ea"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2cf268d1-ef73-4fed-aff3-d5b954b43cc8"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2eaeb9e5-9b33-49e7-80e3-95fb3a360cf3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2ee6e200-b2e6-4f26-af08-a9d37e433768"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("2ff6e081-9b2b-4473-b809-d1e87fedf0fd"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("32591cd9-7b86-461d-adf1-1700dbd7c27c"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("32f77791-0f6e-4fbd-9384-24188b5a3f99"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("343ef94d-0e07-4627-9314-bdea560cd3e5"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("350f80c3-d97e-4faf-8723-c4d8b50a5e1f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3847f679-9518-4956-96c3-fa7d552a127a"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("38f51593-5a59-4fd9-baca-81d90ea4f360"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3c1d2b54-6a59-4454-8190-682a03521241"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3c6a7916-e464-4566-a40e-0158371862b9"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3c8c14d4-c951-4e08-b02a-4a17f07892d6"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3d665853-4376-4af2-9b08-e30d2a99b1c2"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("3f2c1700-c53c-4d95-bf00-2c024d2152a5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4081ce2a-96d2-4e26-bf3c-20a401050f73"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4175fa01-8e9d-4743-8b8e-b706126dde52"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("425c2fdb-b7ab-4463-b442-58ad4bfbd6ab"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("42b7f590-3819-4170-a45e-7c043b07caef"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("42fbc48c-8444-43ea-a034-4c00f5390dc8"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("432d7bd4-961d-45a9-a5cb-02690542b1bb"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4372ec99-fec0-4d8a-b840-7768d70116ad"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("43998c25-6e2d-4973-8a09-92ff2d6b0333"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("43bfe225-3fed-4fc1-b8c5-326acb0479c9"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4418350c-5a05-477a-ac0b-420a59ce751a"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4695f04a-d279-4132-91c3-0d223381eb44"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4732db89-c07e-473e-a163-27f39589ddde"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("47fa9e12-a528-47ef-b3e4-e58426ec3ca4"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4826bd69-184e-4aa8-9ee7-54b450529c80"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4a600201-fc75-4d6d-843d-4811f46366e6"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4be3b289-c4bd-452a-a812-32ea07362f10"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4c6a41e0-8f72-44d1-8120-4eaf42e20d97"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4cda1489-c4f7-4df6-8d1b-b50c6e33f956"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4d974cfc-7b77-4527-abec-4cef44b83d47"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4d9dcca8-bd2c-407e-bca4-78085f1ef975"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4dde06a0-544b-49ea-b1db-396c5e79acd3"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4f3a6317-e8a9-41ed-b925-a5b83fbbce7a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("4f9d217c-5d2e-42fd-a6b9-11dbe453e217"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("52e4f802-c306-4a83-9dc9-3aa9eaa4ce50"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("53576978-fa67-43ac-81b9-a9134ddfa35f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("56105f38-f1ad-4842-8d72-fdeaced32e4d"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("576375ad-e3e8-4bb7-bbfe-97d58adb4531"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("58602215-103a-42a2-a2eb-92d87644d599"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("58b0ca74-a5af-4de9-98e7-a86e2f69208f"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5904113b-2c61-48a5-9047-48856dbd6206"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5b1c89da-8ddf-430e-ac45-94821e8300c4"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5b3e5320-f39e-4b83-88d2-d25385b1f6a0"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5bcb648e-55e7-4860-8878-c7cdba687368"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5ccdfe98-c1f8-4ba5-9bd6-b113684eceac"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5da61d72-a1b3-46a4-9d6a-0198742b90dd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5e56a282-4cb6-47e4-85c3-1328672de206"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5f1b11bf-c59b-40c1-a6c3-0c7f9d4fdccf"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("5f4d44f0-9ffb-4949-90c5-58e83087988a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("60ebe9f0-5e00-4e3a-8cb6-a40dec997cb9"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("63e6dc47-5ea9-439b-99d3-1f67fd0e360e"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("657d8d57-c2ea-4b22-b58c-b25d614758a4"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("66703985-d96b-468a-abf8-9fbb5d92dc4f"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("692a5f79-b234-41ac-8a48-4dfa6b96253d"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("698e977f-fbd5-49da-b22c-7b044692ebb3"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6a7efb19-1582-4c08-a347-2864a72358b1"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6b98c745-9746-4eea-af5e-5235666f2d64"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6dd3d325-cd07-4747-9cac-f9ccad59f07c"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6e07fd6a-ea42-403c-8125-5cbb94241820"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6e28ff04-15cd-40fb-8e31-5161891d29f8"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6e9dead6-30e2-4115-b4aa-67fca2b2c13e"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6ec6e462-c1ff-43ca-87be-768d94138282"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6ef2a17c-bce4-4a49-9b3a-689c8c5a0f9a"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6f856a63-27c4-46e7-8f46-ef68da9de115"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("6fb7f520-581a-4315-a2da-c4f94572563e"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("7073db88-1a42-4ebe-962d-2e57291363a1"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("70ea8c5a-55ca-46fe-a7a7-6f0d933548e0"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("71448b79-f598-4460-b0c5-a41e706821ca"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("71a4986f-582f-40fa-9280-dd93f243b2c3"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("74750445-2b4a-4fd7-8093-589c79b0eaa4"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("75086f2f-6e85-43c0-9801-70d0d507ba0b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("76ea70d9-70b8-42c9-85d7-ceaddd5301b8"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("79431b9d-5399-4840-9334-21dca8e07e96"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("812e90df-d336-41ff-807b-caa93477c3ae"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("81bb1395-790d-4d27-9e26-cf001fc755a8"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("840bfa72-bb25-4568-a047-7ec8d0e2a061"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("842c1ad4-6e6c-425d-ab11-36ae399c0720"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("88554110-a6bd-4cb0-8cf1-356a656d0f6b"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8862bc95-de21-484a-bf56-b35221177cec"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8a59d6b4-7cf2-4ab6-892b-c9cc6cc5d0e5"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("8c83abdb-977a-4095-8fef-4f381dd69dc3"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("91efd30c-65fd-4218-971d-baa9264cbcf3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("922523fc-223e-4c73-9c65-fea4d2f35ca3"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("922b2cc7-711b-4233-b255-ed9525d43fb1"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9554e31a-cfec-4d95-abd1-61fdfeb86c3f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("95aa5216-0b18-46ad-970e-73baf2584144"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("963956dd-3964-4d59-a11a-3acbc47b4cfa"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("96d5ee67-6fb8-4dcf-85c6-90ae308d6259"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("97b41ebe-795d-4324-9eef-84f260145d18"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("97ef8515-1c7d-402e-aac6-9926e8e50e52"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("98601fcc-82d7-4bfe-9189-9a9fd9e23f5f"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("99395125-cb5d-4e93-a94a-0dfa2200e5c9"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9cd7a3d2-9d45-430a-8b62-b8a77b9d26cb"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9d023c56-c291-49b8-9f1c-39dbc0f2abcd"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9d2cc54d-310b-41e5-89bb-02919321d03f"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9dd8b051-10f1-4189-bebb-b05598de08f9"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9e83e244-fd05-43cb-b4f8-e48a78ab9d34"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("9f484baf-1f41-45c2-8d0c-93d28d309a56"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a010509c-3345-40d8-8979-a5da17b6a35a"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a04b7af8-ec3c-400a-b5b6-00ebaf91ba05"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a07c24d7-c1e7-4b62-b40e-14841d73fb62"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a0cd0c00-764a-4e39-ac3d-ce0c5a62b19e"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a1247787-2397-48bb-98b7-7f3809f8ad7f"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a13d4f5e-2b65-480b-b15d-4e6255ec0571"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a13e915c-f00f-499b-a648-395e7c50c7ed"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a34ae854-182a-44e8-b447-725693b160bd"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a3d78884-2785-4cd2-b7a0-f9439e317036"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a41a3941-689c-4f08-a818-de0eba7d8476"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a4678df0-a80a-430e-9c5a-ba772c54905b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a468a2a2-bc8c-4232-b052-67a5c953a66c"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a468ed96-4487-4a7d-aeb6-7eb565a548e0"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a4f857a8-f2f1-4bdc-9d50-cd41c2b01cc6"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a6596226-0646-40c7-8630-ca6a3ef87f00"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a66f9a75-ed5f-47bc-a9c5-79942efebc25"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a6fdb6bb-785b-4019-b601-de7eee41cebd"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a8b0ace9-aa11-4565-b596-641af76e8bea"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9527cff-91e9-4f84-bbec-235f09ac26e6"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a99792c7-2a59-4e63-8e66-22e9ec5038cb"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9b6a8c1-5245-40f3-bafc-97d3193650e2"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("a9f2515d-ddcf-4164-9ab3-a4dd876af411"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aa061664-4007-422e-af2f-e84b1309e579"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ab395efb-d9cd-4ad5-b4cb-b3f67510cf67"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ab723b8e-93ac-4f80-ae55-f3857c817b38"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ac1673b4-a280-4409-bb15-207f2a9753ac"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("aebeb58b-e33f-4afb-a13b-0c60a9a582c6"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("af91fd5d-021a-4e26-918f-da7d8ddfb9b3"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b1c60ec3-b0ec-4231-9c8a-1e35bc4f1058"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b2168a5a-4769-468f-8030-6719063a5a23"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b42b4fd5-b71d-49d6-8fbd-cd8f06a70242"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b4ea002b-8634-46aa-80e7-7a2cc3360037"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b5071285-f55c-4b85-af80-c7105214a7a0"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b5efa481-5e29-47fa-a209-ed139f763b9c"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b635b9c5-ff3e-4987-a69d-6de98a8778d6"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b72731fc-e1f3-4eff-b6db-b5323e69eb21"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b82588f2-dbfc-47f1-964e-4cc4811eba83"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("b9a0ce3b-f265-4045-b149-d9b69dc7aaf7"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("baff3ef1-3b90-47ce-aae1-8e9f552d5243"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("bcaee07b-1b4f-419b-b172-5fa6f865b8d6"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("bddbd66b-c934-4a36-93cf-2bde27436014"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("be4b646c-0c75-48a0-8c8c-27c31a8c033d"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c0964f37-d369-4db4-9c1f-a7260c77c633"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c0984a9c-7727-42ac-8b08-d6fad4af576b"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c09972c4-5668-44d6-b513-6bba3123e806"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c25812e3-14d9-45bd-b796-ef2f072933b5"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c33c1044-d980-4688-bd54-f17dff383060"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c3d6a061-1fa5-4b0a-87b8-7b264e8e1d0a"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c54d6132-b57e-4be4-b0ab-78ed4aad3e17"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c5bb6163-15ca-4c33-af64-f22f962d7090"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c67c8efc-8be3-432a-a6cd-e221bee06db4"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c6986560-44e7-4fa7-a2c4-45519e74b0fb"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c977cf4e-234c-489a-a5e5-881b65906516"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c97c533e-7344-4b25-ab89-bed77ed64053"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("c99ad482-1246-4dce-8c64-a978585701a6"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cae1e57d-0db2-46f9-9630-0ae67708ec8e"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ceb8ac65-c517-4bd4-a9f3-3908645bb850"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("cee08c86-7cf0-43d7-99a7-310498b84842"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d1a9d3a0-785d-4b5f-bc2c-35ab026df0fd"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d2bccd58-7070-4752-ab83-fe833dacdff0"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d4cce596-2bb8-4580-83aa-c6f228a333c9"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d6c72e03-733b-4d8c-8fa4-828b756c2ea7"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d8879685-a2ca-4945-8eec-5eef841c055a"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("d9a8daab-fcb2-4e34-ae5c-679c58ed0d6b"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("dbd2d1c6-bcaa-4fd1-8ce0-925b1a5f2a36"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("dc9c9791-546f-4923-bd1d-779a1a41b140"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("dccf64af-5b54-45e9-bf66-8cd2932cceec"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e0492023-9c56-4291-a24e-6faf7f6a32dc"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e1b5e310-6e33-490f-946a-aad0315a1006"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e2966a8c-eb25-473c-8456-c6a688d98c9b"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e3085fff-190a-4439-a414-f01536461455"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e417a36b-ea36-4c54-82f9-74a46e3cbfb7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e58a99cc-2ddc-452b-a386-ab0bc18e6c2a"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e6360381-49b5-43da-a0a1-81e28e2825da"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e7aa89dc-af36-4f14-bd2b-d9b266459930"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e7cab6d0-fff1-4f5a-90e7-327eb499d479"), "C", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e7df4dd2-ee58-485b-bcad-7616c87aa9a9"), "J", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e93006b8-5729-45bd-9ce5-a8d148927dbb"), "D", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e948322a-eacc-475c-8527-e89ea2adc69e"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("e94fba94-7495-45d0-b206-1c928bd85c58"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("eab0058b-6571-4b38-a591-648a4433da62"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("eae12e10-89e9-4706-8e55-c9cc3f78e872"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ebf35e91-ee18-427b-bee9-3cd98829501d"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ec0dccc5-d082-49c3-91bb-89d3ab070d91"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ec705a4a-3c6b-4b6e-a49e-82904096aff1"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ee88a60f-dcd1-4f10-84d5-23525c28ea70"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ef2a5540-8349-4fe6-94ba-438b2e452662"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("efa90406-3414-420d-ad84-c83d57dd9c78"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f0a7dd6d-6334-4eec-ad44-254059ae03d4"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f278d746-8468-427d-869d-ef57fadff4d7"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f296481b-7e11-4ebf-bc6a-18b3da85dac2"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f464d7c2-a6c9-4575-98ed-441dc9d7c594"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f4a282d5-54da-4e92-a04e-0f607ba6b786"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f582893d-7496-45ee-a1b3-8d2e7f6a453f"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f5fe6b22-f553-441d-b413-e2ff044c2089"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f6127a0d-8e2f-45cf-b23c-d3771cead62f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f676bd89-80ac-42c8-b7c8-da0554856721"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f765df2a-3860-4752-bcdd-b6cd0fdc7fac"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f7a01e4e-733f-401d-a9f9-21634a7a7597"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f8108b23-05d9-41aa-9497-834800ffe3d0"), "F", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f9a5f0bb-3d41-49c6-8269-a9660ecc74e4"), "G", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("f9a8c038-d552-4f8d-bf23-ff7a77b217b3"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fa04b77e-dcb6-4b17-941b-95acebb18331"), "A", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fa333d72-7ddc-4c2a-b50b-c58a49a88c68"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fa70d85e-3012-4796-9f50-227e655f43f5"), "E", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fb9f5eee-da09-46dd-a4a7-c755a622f435"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fc4b6d41-7009-4dfc-bacb-d652222b58b2"), "H", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fce47a2e-7d69-4bda-834c-ec7ea20b8e6d"), "I", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fdb9a762-7832-4bd7-add6-49fdac0d5019"), "B", null, null, null, null, null, null, null, new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("fe969cdd-046d-42d9-85b2-779ecc75c4e2"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 },
                    { new Guid("ffd2c13e-cede-417b-af94-dbc2653188f7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("6e97edc2-6f11-4383-b880-95444e49f0e8"), null, null, new DateTime(2024, 11, 29, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5001), null, null, null, null, null, new Guid("220a7819-1e39-4867-b6ef-2b978c2a66cc"), new Guid("55407c6c-9137-4d13-9e70-31b9838e65b2"), 1, new DateTime(2024, 11, 27, 8, 14, 36, 122, DateTimeKind.Local).AddTicks(5000) },
                    { new Guid("8c427062-0556-49a1-85bf-ddb11bdcc223"), null, null, new DateTime(2024, 11, 28, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(4992), null, null, null, null, null, new Guid("31d24314-f829-4ab8-bac7-df82dd80ff2a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 11, 27, 8, 13, 36, 122, DateTimeKind.Local).AddTicks(4979) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("e533ec40-b314-4d0f-9453-b1ee50f2895c"), null, null, null, null, null, null, null, 1, new DateTime(2024, 11, 27, 10, 12, 36, 122, DateTimeKind.Local).AddTicks(5382), new DateTime(2024, 11, 27, 6, 12, 36, 122, DateTimeKind.Local).AddTicks(5381), new Guid("fdc82ea7-c79c-4502-8e18-b37b413a1816"), new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5380) });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_ReleaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("74978454-e40c-4107-8902-e8eebd82744a"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5022), null, null, null, null, null, new Guid("31d24314-f829-4ab8-bac7-df82dd80ff2a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 11, 29, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5020), new Guid("2f2fc044-1a82-4163-9524-fd702237ca4b"), new Guid("8c427062-0556-49a1-85bf-ddb11bdcc223"), 1 },
                    { new Guid("c416e152-f44d-4910-b116-6402f1351ddb"), null, new DateTime(2024, 11, 27, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5032), null, null, null, null, null, new Guid("31d24314-f829-4ab8-bac7-df82dd80ff2a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 1, 8, 12, 36, 122, DateTimeKind.Local).AddTicks(5026), new Guid("2f2fc044-1a82-4163-9524-fd702237ca4b"), new Guid("8c427062-0556-49a1-85bf-ddb11bdcc223"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("1df6b40d-6453-485a-9339-7a8f6fdb7043"), null, null, null, null, null, null, null, new Guid("31d24314-f829-4ab8-bac7-df82dd80ff2a"), 100000m, new Guid("74978454-e40c-4107-8902-e8eebd82744a"), new Guid("e1b5e310-6e33-490f-946a-aad0315a1006"), 2 },
                    { new Guid("49d91e5c-8d23-4673-98f8-d4c2f7933f00"), null, null, null, null, null, null, null, new Guid("220a7819-1e39-4867-b6ef-2b978c2a66cc"), 2100000m, new Guid("c416e152-f44d-4910-b116-6402f1351ddb"), new Guid("4f3a6317-e8a9-41ed-b925-a5b83fbbce7a"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("2d9f3708-d873-46f8-a535-d7c699dec64b"), null, null, null, null, null, null, null, 60m, new Guid("c416e152-f44d-4910-b116-6402f1351ddb"), new Guid("a22f9a3b-4728-49de-9edf-34f47a1a9421"), new Guid("345732f5-5d6b-4f67-8d58-50c995f335b4"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("a480d3cd-2a41-4c51-98e4-9d1239717fd2"), null, null, null, null, null, null, null, 50m, new Guid("74978454-e40c-4107-8902-e8eebd82744a"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("2f2fc044-1a82-4163-9524-fd702237ca4b"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0a44bfe0-132e-4d14-bd58-9a8e50ac720e"), new Guid("49d91e5c-8d23-4673-98f8-d4c2f7933f00"), null, null, null, null, null, null, null },
                    { new Guid("da939aea-dd28-4ff0-8b1b-fa9a347ebf29"), new Guid("1df6b40d-6453-485a-9339-7a8f6fdb7043"), null, null, null, null, null, null, null }
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
