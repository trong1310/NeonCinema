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
                    { new Guid("72a66074-2ca4-45a7-9a14-c7c81baa473a"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("240378cb-b2b4-4987-88f4-b57a481c94c6"), null, "mua tại quầy" },
                    { new Guid("feb4162f-6a32-4927-bc2e-527d025391c3"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("2eed0f6b-68b8-445b-a405-bb3e94733b89"), null, "mua tại quầy" }
                });

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("4bb078b6-530a-4c7d-a965-eddb0c5dda79"), "11:00 PM", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5197), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10:00 PM", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5193), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1c2e0487-57a0-43a1-98b8-9ffb9b4eccff"), "Ấn Độ" },
                    { new Guid("4867731e-d763-497a-a0d8-4267ae5b9781"), "Hàn Quốc" },
                    { new Guid("57d65a52-b9ae-40a8-ae0f-6f13dad26b15"), "Úc" },
                    { new Guid("7d3e74e1-5740-4e24-b53d-1e96c996536f"), "Mỹ" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "Nhật Bản" },
                    { new Guid("94ac4478-d955-454b-86a0-225fa6dd811e"), "Vương Quốc Anh" },
                    { new Guid("9ed07cf7-975c-4df6-a6e2-e838ff77b15c"), "Pháp" },
                    { new Guid("aefeb05c-ff3d-45f4-bd15-ed16633ad274"), "Trung Quốc" },
                    { new Guid("b6678bf5-ce26-4e76-8f2d-95cd3bced833"), "Việt Nam" },
                    { new Guid("fc5dacd1-e114-491e-94ba-7ce41234f914"), "Hồng Kông" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0c760f9d-5894-45e7-8a7d-e8e426bc5a54"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("19ca3615-cdff-4ad0-aae3-dd86cd513950"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("1ccd4e92-41c7-4703-998c-1921b0decfd9"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("2aae8854-bbe7-42d9-badf-11526dbbce76"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("2d0ecaef-e95e-4fcb-b932-f05a9fba2fde"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("5499257b-a9e2-4c22-8994-102b3c54588c"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("68a38150-5ee7-4911-ba5d-1734d7cfb0c0"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("8022a6ac-fdf0-466d-9f0a-6df351e32739"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "TP Hồ Chí Minh", "Nghệ sĩ đa tài, nổi tiếng với các vai trò MC, diễn viên và đạo diễn. Được biết đến qua các bộ phim hài và điện ảnh như 'Bố Già'.", null, null, null, null, null, "Trấn Thành", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("e71b85f3-50e0-4322-9d86-37a25934ccfb"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("65697fb7-3630-436b-ba87-f14fb850cdc6"), "Combo 2", null, null, null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 220000m },
                    { new Guid("e3037b33-fb76-41fa-8eaa-8bb6be19ad85"), "Combo 1", null, null, null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 20000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0d361dac-dce1-4d2e-916b-c03b64b614ef"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("33065001-c526-4893-85d9-cbcc2c2f2606"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("5a17a2fb-6a2f-4ff6-aef2-069ba509da3b"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("60092a83-dbaf-4497-b850-078c6c993029"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("698d4b78-5154-4d62-8ea4-1302fad6c652"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("80d3618c-1ee5-4ee9-beac-50338e619109"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("a2b58267-5e9d-42f6-8cd4-39b8739b8285"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("b9a70fee-8a7a-4c99-b586-9df4df9d3613"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("cc2baf30-3e94-44f3-ba9f-1f408d798597"), null, null, null, null, null, "Phiêu lưu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("336385a9-21ff-426a-a978-2c6ada7f9ee1"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("48949f17-d2d8-431a-8062-e936bce55fd6"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, null, null, null, "EN", null, null },
                    { new Guid("910f5cef-679f-4afe-8bb2-5289cef9a3b7"), null, null, null, null, null, "USA", null, null },
                    { new Guid("a3912540-41f3-4926-a73c-d7265e4b1700"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("dd95986f-e5af-4b87-bc81-d204e0751068"), null, null, null, null, null, "JPN", null, null }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("2a266d61-6c75-4905-93e9-a875978518e7"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("9090c404-edde-488d-b01c-16c9f0a2ba35"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4137), null, null, null, null, null, "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4160), null, null, null, null, null, "Staff", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4158), null, null, null, null, null, "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("4e371d58-1177-41c1-8422-64cb63164603"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5165), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5162), null, null, null, null, null, "Ghế thường" },
                    { new Guid("f4582cee-32a9-4883-b534-ba1c9ed41d3f"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5167), null, null, null, null, null, "Ghế đôi" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("047ba41c-5910-4779-9aef-8c2175843284"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("0e04b9c9-dfa2-4c8f-86b1-be7147231bab"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("207e733e-d00a-47bb-a32d-48bb64bd1a33"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("94b95608-62ac-4e9c-b0d6-ab846038c2c6"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("a11694d8-5814-4f8e-944a-a950cfef2875"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("a2f88907-2620-4237-a198-5a16c13e8fb6"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("bf7f21b8-7d6a-4d99-be56-53b2ff4f26e9"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("da4d0fbb-39b3-4c8f-9caf-ea02636daa39"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("e0173875-be70-4c74-bf8b-e677a5f5dcd4"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("fc1419a6-82c1-442d-9412-8bc28bdfdf24"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 }
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
                    { new Guid("1a3a605f-833b-487d-ba26-7b9c7578e664"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5848), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("0c760f9d-5894-45e7-8a7d-e8e426bc5a54"), 140, new Guid("80d3618c-1ee5-4ee9-beac-50338e619109"), "gaigialamchieu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("26053232-f2c2-4fda-b617-afdcbb419f7c"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5888), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("0c760f9d-5894-45e7-8a7d-e8e426bc5a54"), 145, new Guid("80d3618c-1ee5-4ee9-beac-50338e619109"), "nguoinhenvietnam.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("47633ea9-9a25-491f-85d5-0fcac09ed62c"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5882), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("5499257b-a9e2-4c22-8994-102b3c54588c"), 130, new Guid("b9a70fee-8a7a-4c99-b586-9df4df9d3613"), "matbiec.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("79cdea41-044e-4e14-a2e7-48c3a223a767"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5860), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("68a38150-5ee7-4911-ba5d-1734d7cfb0c0"), 125, new Guid("60092a83-dbaf-4497-b850-078c6c993029"), "tiectrangmau.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("9dda574c-72f2-40f5-a13d-d10272e807ec"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5869), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("b133ba5a-dba4-48a9-8384-cdcec21c55cf"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5894), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("68a38150-5ee7-4911-ba5d-1734d7cfb0c0"), 100, new Guid("60092a83-dbaf-4497-b850-078c6c993029"), "saigontrongmuaroi.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5827), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "bogia2.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("c39721e0-1ab6-4e78-b33a-21094586b14a"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5835), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("e71b85f3-50e0-4322-9d86-37a25934ccfb"), 120, new Guid("33065001-c526-4893-85d9-cbcc2c2f2606"), "chimuoiba.png", new Guid("336385a9-21ff-426a-a978-2c6ada7f9ee1"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("d313c846-a580-43ad-882c-25d4df7869a8"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5875), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("e71b85f3-50e0-4322-9d86-37a25934ccfb"), 150, new Guid("33065001-c526-4893-85d9-cbcc2c2f2606"), "emvatrinh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("f654d43c-4642-4f32-9be1-edf4dd5e9b19"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5842), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("5499257b-a9e2-4c22-8994-102b3c54588c"), 110, new Guid("b9a70fee-8a7a-4c99-b586-9df4df9d3613"), "nhabanu.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5235), null, null, null, null, null, "Room 2", 0, 150, 1 },
                    { new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0, null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5229), null, null, null, null, null, "Room 1", 0, 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("11bf1bca-0688-471e-bf70-294d2b211b21"), "Thái Bình", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4835), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("28581ffc-8a1f-45dd-90f3-d219de723cad"), "Nam Định", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4878), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("45c29014-4bfd-45f4-9a72-96e2d2bc417d"), "Hà Nội", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4696), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6a86c934-8ce3-432a-8d21-98e85a4b3f5d"), "Đà Nẵng", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4746), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8458c8fd-3b08-4670-998f-5f5a024b41e8"), "Nghệ An", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4795), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("89a08df6-115b-4921-ba4e-91b343eccda7"), "Hải Phòng", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4722), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("98780399-8274-4052-b084-8475f66208fc"), "Hưng Yên", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4856), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b50c2397-547d-480a-be54-4fdd668bf634"), "Hà Nội", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4340), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d1173609-7f5b-43c1-87f9-1a6c608c0aba"), "Quảng Ninh", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4902), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d4ef2d29-2358-450c-bf41-c529aee15556"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4773), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("de2da2b1-0229-48c8-b8a1-67bd97ff78d8"), "Bắc Ninh", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(4816), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("42e05f9c-bbbf-4773-8309-02b4650fe548"), "BILL001", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6175), null, null, null, null, null, null, 2, 500000m, new Guid("b50c2397-547d-480a-be54-4fdd668bf634") },
                    { new Guid("645447ec-3b7c-4a76-9a7b-019df2dac7a9"), "BILL0122", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6192), null, null, null, null, null, null, 2, 680000m, new Guid("8458c8fd-3b08-4670-998f-5f5a024b41e8") },
                    { new Guid("7fa64961-3b85-4771-a7c5-efa227a5a3c5"), "BILL007", null, new DateTime(2024, 12, 3, 6, 24, 26, 35, DateTimeKind.Local).AddTicks(6194), null, null, null, null, null, null, 1, 800000m, new Guid("de2da2b1-0229-48c8-b8a1-67bd97ff78d8") },
                    { new Guid("87f77c44-76c8-498f-889f-29ce603aae30"), "BILL005", null, new DateTime(2024, 12, 3, 7, 24, 26, 35, DateTimeKind.Local).AddTicks(6187), null, null, null, null, null, null, 2, 250000m, new Guid("d4ef2d29-2358-450c-bf41-c529aee15556") },
                    { new Guid("8d1c8015-4c48-42eb-918b-2823aad90d4b"), "BILL006", null, new DateTime(2024, 12, 3, 6, 54, 26, 35, DateTimeKind.Local).AddTicks(6190), null, null, null, null, null, null, 2, 600000m, new Guid("8458c8fd-3b08-4670-998f-5f5a024b41e8") },
                    { new Guid("a36f8a70-3f54-4437-a883-6180cf016b5a"), "BILL003", null, new DateTime(2024, 12, 3, 7, 54, 26, 35, DateTimeKind.Local).AddTicks(6182), null, null, null, null, null, null, 3, 150000m, new Guid("89a08df6-115b-4921-ba4e-91b343eccda7") },
                    { new Guid("bc999f1c-c06e-4904-9785-13d259a20368"), "BILL004", null, new DateTime(2024, 12, 3, 7, 39, 26, 35, DateTimeKind.Local).AddTicks(6184), null, null, null, null, null, null, 2, 200000m, new Guid("6a86c934-8ce3-432a-8d21-98e85a4b3f5d") },
                    { new Guid("c2726ca4-a9ab-43c6-9f72-ceb912ac610c"), "BILL010", null, new DateTime(2024, 12, 3, 5, 4, 26, 35, DateTimeKind.Local).AddTicks(6205), null, null, null, null, null, null, 2, 700000m, new Guid("28581ffc-8a1f-45dd-90f3-d219de723cad") },
                    { new Guid("c79380c1-51ae-42ac-b397-7eff7d844636"), "BILL008", null, new DateTime(2024, 12, 3, 5, 54, 26, 35, DateTimeKind.Local).AddTicks(6199), null, null, null, null, null, null, 2, 450000m, new Guid("11bf1bca-0688-471e-bf70-294d2b211b21") },
                    { new Guid("dc072ec7-b559-4dc0-b76a-73559ccb63e9"), "BILL009", null, new DateTime(2024, 12, 3, 5, 24, 26, 35, DateTimeKind.Local).AddTicks(6202), null, null, null, null, null, null, 0, 350000m, new Guid("98780399-8274-4052-b084-8475f66208fc") },
                    { new Guid("fd19cedc-6a09-441c-87b8-e4f2567b05c1"), "BILL002", null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6179), null, null, null, null, null, null, 2, 300000m, new Guid("45c29014-4bfd-45f4-9a72-96e2d2bc417d") }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("150ced73-e35c-448a-a1f6-e1e42d6b8265"), null, null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6336), null, null, null, null, null, 150, new Guid("45c29014-4bfd-45f4-9a72-96e2d2bc417d") },
                    { new Guid("6caf3918-a776-42a7-b963-59adfba285d3"), null, null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6332), null, null, null, null, null, 50, new Guid("b50c2397-547d-480a-be54-4fdd668bf634") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("852e69ff-278a-48d1-a4f9-a38f8e9423ca"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6309), 1, new Guid("b50c2397-547d-480a-be54-4fdd668bf634") });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("01d10c30-fc55-47ca-916f-40e13bdd7488"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("01fdfb1a-1afc-467f-b89d-8ffcb2eb4ff1"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0239a113-ce97-4ca5-a6c6-0a0d5c98646f"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("02970d5e-d13e-4255-90f8-e01886299bed"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("083ed561-40e8-4096-9c91-ae9644cd3050"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0cf323d2-2af9-4761-b94e-337237d15e1d"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0fdbb52d-4e4a-41c1-9a2d-196d24d6fd1a"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("0fe0d595-2d92-458f-afbd-8bfde3ac1264"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("12b5f300-4044-4457-8fa3-d14f9390d653"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("12c8c370-31da-45d6-b24b-4b7113ce3b17"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("143c2bff-7ccd-4b0f-a830-45fc033e1a7f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1566808a-7251-4a8b-8a87-b167129019f1"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("167870d5-c96e-441f-91f5-56155cd0656f"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("17a79454-6168-49b2-9fe8-7918c0286caf"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1ae9b314-7f93-4c3d-98e7-836c18dbae11"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1de535ea-c6c4-462c-8f2c-2778b0a6344f"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("1fb34b00-3034-4e24-a994-bdc25f97016b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("21511348-af76-405f-9014-32e918a05cb0"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("220d77ca-0c72-4e7d-830c-4a2294a5dfbd"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("222850e2-5f9b-43c4-8959-1337ec521cc1"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("224bc00d-2bcb-4cac-b226-9f7f02c997d5"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("25c78cbf-6747-454e-a7c0-e020077c7015"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("25e0c2a0-b6f1-4f3e-8d52-c493620c08b9"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("25f3f84d-555f-400b-821f-5aa9b006e1b3"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("27d0eef6-6052-472b-b30f-b7216829615d"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("281da763-d4df-410c-a388-a91442511905"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("281fca88-dfe9-4a85-a0e3-b9087ca405fe"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2866c3bc-a59e-49e8-b1bc-4cbc4ea345b1"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2a336b82-daf4-4c1c-9199-bda95fa996a5"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2b486b9a-e531-4394-95d8-d47c32e2b0f5"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2b5d2ba1-929b-488d-95e5-004f5ee80eaf"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2b744346-33b4-40c1-b6d5-f60eb7f480e5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2bba7e6c-fdbf-44d6-afbf-4c508344295d"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2d0e112e-5d62-4d38-b8a8-954ed6292b2f"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2d5bf3cf-31c1-4442-9a1b-88dfe0c96deb"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2e21c6e9-1453-43e8-b50f-d8ffab9bfdf3"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2e86960e-20d2-49d2-9378-219ee65afa67"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("2f2ce4ab-04e4-499a-b286-4f28e6c62a55"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3087a8df-81b7-4006-8790-7d2f0fbffe36"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("31cd4824-a896-49cf-b269-35aa22f69140"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3442de54-b6cd-4412-94c5-3c152a80a1e3"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("37038575-7d26-49da-ba4d-20c006b1cb2b"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3760c1e4-1c7d-4b26-a1ae-1f9214ae0d33"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3b454826-8e83-4de5-869c-7d41fbdcf067"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3bc2c4b1-9577-4637-a4b6-c8d1c75d0ab1"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3e1d31ff-bb45-4150-b71f-c4f60839fc94"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3e40ac50-54b7-415b-8ca1-9418abccaa07"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("3ec1d71d-240d-4d72-824d-45a2a81bf436"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4116b688-77bd-4976-b1d7-f72cca108aa9"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("411fbfca-846f-4cf3-9c27-c896cff8d33b"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("44f27ce2-88f3-4373-be9f-dcac4efab625"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4729f349-c274-4ef7-b611-bf804bd09d48"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4761425d-644c-49d2-8485-efff39606468"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c7f92f3-3b8e-402e-aa5c-766067e87b70"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4c8f265b-3816-4a56-9264-a842ccf61669"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4d0eabf9-d686-4425-9405-d3415c90adcf"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("4fc52269-5cb9-40b0-8d4a-a215db6d53cf"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("512c0f59-5d8a-45d2-b655-3b100cbbd4d2"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("516b106a-3b14-445a-b373-96a50f75d840"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5374e5a3-9c58-46ad-984a-3d7f8ec3ef47"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("53f7cec9-b633-46a5-89b3-6607975764a7"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("54845851-0ad2-4261-93c2-6843bb714f1d"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("54b05213-82a6-4ae9-a26e-300f810c40e6"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("596cc74a-27e2-4ad2-ab99-744b2fa8d72f"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("59f65a28-18e3-4f9a-8f8d-cbab43948eee"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5a5d8108-ebc0-426a-8d85-c088e15603d9"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5c7560f8-b177-462d-82a6-a026192dc81d"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5d9abb4e-07d4-4057-9870-1ccf7e0ec1dd"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5ed1b1e4-bef6-4e68-9028-c126c61a80b3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("5f9a4f61-8ac1-4139-ad49-36eae2a245ce"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("60510c33-d7ef-4dc0-a9e0-6ad11925fdec"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("607ceb39-8941-451e-86e1-81ca6c322e26"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("60f3c78c-0f15-4f3b-938d-25694871d8aa"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("60fde64b-c69b-404c-9e73-262b59f33d9d"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("610c372b-7b7f-4c3b-bd56-b7dfab1fe218"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6163a7ad-fa85-4905-9eba-1282987ffdc6"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("642f1c9c-9d84-4d17-8d0c-39db0dbb7dd4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("64687c29-0294-4e6a-b048-15a63242bb84"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65756f90-1a9f-4a30-854c-5388e0028e3a"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("65ba145d-48c5-422b-86d0-f4f6c04d71c5"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("66f43e28-ce3a-49cc-b52a-64d213edd225"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("68257927-6bc3-4da1-b3bf-600ab5045799"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6bb3ed1d-b024-4099-931c-399c4f528270"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6c9d7ade-d429-4b93-bdd8-5583ae635548"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("6ffd8fe7-47dd-4053-9491-9977629fe291"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7103f6b1-057c-481d-9515-4fbd084d2db2"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("716d1108-1563-4dd9-b32e-7ba16a74d258"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("721953ad-1ed6-4971-ac21-7a067bc8b66c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("736769dc-c055-48f5-bd2b-8f9b3c82c7f8"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("74af992f-f5dc-46b9-96b0-4e3f1ef6323a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("754864f0-8386-4f99-bcca-02710ce2e53a"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("77f162cf-2e0f-4b1f-9ceb-a0a175b89f4b"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("78b6fad1-bb58-4924-854f-10e146dd207d"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("78de650e-c4b0-47d4-abfd-1500ffda5318"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7a0243a4-a41b-4f7f-abb3-112c2af2acae"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7b6cca71-294a-468a-9242-b00cc178f110"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7bbb8b91-0316-42b2-9656-0cbbcf84c49c"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7dad1567-0165-453a-8f28-8050b670a954"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7def16ec-7516-4b36-b136-efb42d021304"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("7e29a87f-5310-439c-88e5-06fd356d452f"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8139e77d-867f-4ba2-b16e-1f2b5369bce1"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("82ee9761-a67e-4c85-99ab-1dc8a99a9a66"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("83281254-31e0-462d-8f5c-45744f19c3c6"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("83ab1bd0-1391-40f6-b673-e34393510d37"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("840bc4cc-8a77-4eef-a7eb-1d195a8f60c4"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("85114c7a-d2c7-41a0-9770-de37031f9f60"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("85ca6e47-cfad-4a48-b2e6-82084894566c"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8628934b-df15-4c7c-a78c-f13ed3cba9fa"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("86b31a61-f6dd-4bf0-a407-0f4849280398"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8723c514-4200-42fe-915a-e085f9a602d9"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("88ba67c3-8350-41b2-9936-f1e4af890727"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("890e4385-42dd-4c22-8673-fd2adf17677c"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8942e8a1-711c-4295-af7f-4029ff675c7b"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8b9cd453-5a89-4e9d-a34f-2cee203a5101"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8ce365aa-6ec3-4fdd-bdad-4e88079ef5e7"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8d50c1b0-a194-49d9-836f-1e7c551fc2ff"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8e41e489-2e5c-4184-a604-2aa0009a661b"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8e74939c-6259-4cb2-9a38-2325f36be2e4"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8e940f39-a1ca-4c34-9a74-a10c115e76b1"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8f613ed9-b64c-4c91-9f26-9a558853b0c0"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("8ff4545b-b9d2-4732-863a-71cebf18d308"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("90c61d03-a1e3-400f-99b9-1774a636b97f"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("91291bd5-aa51-4e7e-a7e2-2e1d6cba950c"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("915b5017-be9b-45d5-96a7-88b33482ca4f"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("91ce2526-ad3a-4348-8eeb-b1aa3c9a1e7c"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("91e03815-d316-4da1-8ba2-41daedf8ddd3"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("947fbbd6-445d-4ce7-af4f-0630d284748b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9528ab6c-70a2-4fe6-b4c6-7dcb7dcbf6e6"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("953c0c81-f18f-4d04-9850-fa0332b6aac9"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("985c3194-53f5-4aca-8e4c-b95010f58a38"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9997a836-e432-4442-8d1a-18d443d608e6"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9a618fa8-3212-4974-9b57-9dc684370f6d"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9b8207fa-873b-477a-9bf5-a1c7422131bd"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9b94c719-fad6-4a0b-a969-db56b997f90e"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9c6bd7f2-b9f8-4c4b-a946-c8184b012633"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9cb6d025-70c7-44cf-b1c9-ffb9f2ce3b16"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("9e7b16a3-5989-4de5-8255-d8aa1ed4c737"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a0179515-8e1b-4614-be7b-664e7c809dfd"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a03faa90-b468-4c74-ade2-ab4f705f5089"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a3b3082c-783a-4557-8e09-f7e243d22fb7"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a3f5a016-186b-4bbd-afc2-c5483df65422"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a457a0fd-bd56-4ec8-b03f-0795c5427e3e"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a493b47e-61e7-4c49-8bd3-0fd7b843d882"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a526fef1-bac8-4d55-a89b-c465f8989cc3"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a78a09f4-bb5f-4170-97e7-73b53219d4a1"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a81d704c-ee14-4b88-a80b-491205615d82"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a8368b1b-bb0e-4ac1-813c-014ea100011e"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a9640830-da6c-4a36-82ec-c6e8d11243c6"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("a9ea32f0-a2ae-42a9-95ac-ce235f978e35"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("aac33aaf-44c3-493f-bfce-7536c123efc9"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ace95a17-b912-4980-9996-6d5234c441db"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ae9b34c9-3113-4410-8903-8120181df657"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("afcb4055-a97d-4e70-8e58-75910e5d5817"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b0384211-e24d-4079-925f-f8d27a2b1786"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b11b9ac6-cbfa-4743-a8c7-14014896e870"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b2b14782-0aad-480b-af67-bc600a23b2b3"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b2fbd2f6-3024-452d-8676-83bc528e98c3"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b5434cfc-d60c-41d3-b06a-cd24a6daa519"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b6546cf6-beb9-4110-88e7-1d8baaf72cf2"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b6cc74d7-d467-4fc7-b811-8c59f5988995"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b7b12950-aa29-4058-ba1a-7685705ad072"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("b9238731-4296-4321-b9ee-366378019ba0"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ba8e96fb-b295-449c-81de-66be3cba1939"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bab24225-2ae0-4c56-8b32-6bd914ff6100"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bafd4785-97b3-4b2e-bc13-9e2029af9315"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bb8affb9-cb61-4787-b280-0ec970873648"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bb9b45d4-2d0e-4a0f-803f-b5ea0d15bf04"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bba5e74a-5b91-4a97-b5d9-5225e17e1e1a"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bca73f4a-f9cc-4173-920f-6897c7c52d24"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bcc0daf1-516f-4100-a411-ac8bc6c8e1f7"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("be55cbe5-6f8b-4f43-a912-e86cb3e2b61b"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("bf0d14a5-2273-4dd3-90b1-b63c8cc8892b"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c0a6b25d-7c5d-4b91-8016-b39ff5a3f097"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c0f27980-3b57-4a4b-9ca8-8321293e3d02"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c3110c73-6a9c-4bbe-8751-9579309fdfdd"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c3405be8-a53d-49f8-99ac-03bf2fa96222"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c355adea-882e-4c1c-b597-2e2b83a0f7e4"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c5334081-0a35-4055-a510-5776cbb057d8"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c53384f4-5d52-452a-af27-e6dc9ddd7288"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c61a5134-b4f9-4313-bde8-4dc080c8e916"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c6c007d0-7056-4f95-87b7-5b5be33a3697"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c831be58-30cf-4d55-9957-ab69a3bf69f5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c8e3486f-dfa9-4e7a-b8e7-d87e7eeda413"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c9651b21-7a90-41e4-bcde-7c08c0d84ddd"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("c9aefb3a-94f5-4700-bcd1-46b1b7710825"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ca3609d6-f16c-449d-868f-e98aeb24ce30"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ca641b89-33be-4f5d-a5eb-154ccfe1e156"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("cb39a92d-6175-4991-81ca-d9de5777e0a8"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d099340e-8e8e-4c67-80ae-732b3268e75c"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d12c8cbd-8d84-4a36-abec-b08585757074"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d1a63df3-08eb-475b-a62f-0fd9cfea0364"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d2374ae9-96cc-4c29-8f63-96aac4822a80"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d264c8e8-3c4c-4bd2-89c8-8933217be4fb"), "H", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d47447a4-f2e3-4faa-a70b-f64ee7782782"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d4f35515-1b8e-4e65-8830-b2d81e9c0210"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d96d7dc0-e2ff-4d48-a158-624b7b5be206"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d9a4b066-3916-41bb-a884-b1778f319979"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d9a79b1f-28bf-4272-9348-2fd834b3f062"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d9e6707d-82ef-4fc9-93be-c2801714da69"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("d9e6b7db-ffc7-4f1e-89ef-4b16b4f4dd06"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("da4fcc27-4643-4c2b-8d9a-ac326d78a065"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("db147525-6a1b-4ed3-9d73-5c0474d7ba4c"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("db15ff20-9e72-46b0-9fb6-073f0a01bd73"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("db6047c0-4143-4c13-bb0e-2b19d3f8ac2d"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dcc0b481-5161-40d3-a954-1d9b63283f9a"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dd0b5acf-b6ab-4b59-9f7f-b5e819a23dcb"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dd4073e2-67ce-430d-b682-c2e481b80e81"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dd5c8b2f-cede-41fc-85cb-079aa32aed80"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("de23adf8-28dd-4cd0-a191-47a0e1827b44"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ded71396-4525-462e-ba2d-9bc5e1b583de"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("df5a5e0b-3daf-4d4d-8721-f06a0166c1c3"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dfe913f0-32c0-404f-b2fe-ff28afef8491"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("dfea5ec6-bcff-4bbd-8d68-ad192a9f4ac3"), "J", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e17f6571-fe7c-45a2-a5c6-f556bfdb745c"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e1c3b5da-e58d-4be4-ae3c-615339071ea2"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e2318afe-9c04-43b8-80be-dae096767d5f"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e27d6a84-b6d4-45a9-ad9c-11928e51f0bd"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e5ea8ae5-4043-4b70-8e1d-d5b1e4686af1"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e83f08c9-be40-46de-9a27-ba87d9be4e8f"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("e973bc5a-a635-4c2c-bf0b-d18a20a0eefc"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("eac91816-a1b2-4a04-92c5-d26a712a09d5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ebb222f0-b169-45fd-a275-1ba645700cfb"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("ec139f49-feef-44ed-b7d5-4fdc7f731a2e"), "G", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("edde375e-b5a1-45c7-b184-b2da9eb0f244"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("eea52ecd-bd3c-4e5b-8448-a8e322c05dbc"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("efa1c5fd-9829-440a-baba-7ad882274701"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f0e2de5f-d5de-4ffb-a110-50484749495e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f168607b-e879-47cf-8cc8-510327450e69"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f2c8dae3-ce71-47f1-9032-5d99067244d1"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f30256eb-6f80-491d-bf2f-264f43c4b8a1"), "A", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f37c715e-f036-4918-b7dd-fa616423406e"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f39f80a2-be36-4e05-a220-07011dea637b"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f3d410f6-c129-4c7e-a67b-dc8d8b6c12c7"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f4d07376-c450-494f-8e02-41a3e76804ba"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f552d554-3e97-4294-855e-d9606ab9b1c8"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f5cfc6d2-2207-4de5-8cfa-ead9aeac5e38"), "B", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f6307b8d-4802-4a63-b816-99918f91152d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f6b87982-edab-4a83-b450-5018e1dfb568"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f7ce5870-0b21-43da-99d0-0f226d486269"), "D", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f8182929-aa20-42a8-b8c6-4c84a50cd304"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f8410c6d-40c8-4a95-8381-81471dc8fbcf"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f86334c7-684b-4f09-ad3a-2f47fae12446"), "F", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f8ae7305-b30b-4a4c-bdaa-66372424abed"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f8f021ad-e03e-45a1-a758-00e16268cee3"), "I", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("f9b17ab8-7701-4b5e-8a57-21598bb2cc63"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fc6715f8-a19a-45da-bc0c-f01b403280fc"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fc9bf4eb-0e59-43cc-bfbb-ddad8901fd89"), "C", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fcd1f236-a369-4a99-829b-8f1e1b86e41e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fd385974-a768-470d-9874-9c7ae1855056"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 },
                    { new Guid("fe7d3814-efc7-4a54-9978-343b151264cb"), "E", null, null, null, null, null, null, null, new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[,]
                {
                    { new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), null, null, new DateTime(2024, 12, 4, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5930), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 3, 8, 25, 26, 35, DateTimeKind.Local).AddTicks(5925) },
                    { new Guid("b0c363ef-e39e-481c-a9af-95445ec76d06"), null, null, new DateTime(2024, 12, 5, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5936), null, null, null, null, null, new Guid("c39721e0-1ab6-4e78-b33a-21094586b14a"), new Guid("3cd33619-2ca1-4f3a-9da4-83a85913c8f0"), 1, new DateTime(2024, 12, 3, 8, 26, 26, 35, DateTimeKind.Local).AddTicks(5935) }
                });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("6648416c-cf56-4968-9441-e18372df5db9"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 3, 10, 24, 26, 35, DateTimeKind.Local).AddTicks(6361), new DateTime(2024, 12, 3, 6, 24, 26, 35, DateTimeKind.Local).AddTicks(6361), new Guid("b50c2397-547d-480a-be54-4fdd668bf634"), new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(6360) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("42e05f9c-bbbf-4773-8309-02b4650fe548"), new Guid("e3037b33-fb76-41fa-8eaa-8bb6be19ad85"), null, null, null, null, null, null, null, 0 },
                    { new Guid("fd19cedc-6a09-441c-87b8-e4f2567b05c1"), new Guid("65697fb7-3630-436b-ba87-f14fb850cdc6"), null, null, null, null, null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_ReleaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("0c9bf321-8f7a-4c54-b1be-55ab622239a4"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5979), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 9, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5978), new Guid("da4d0fbb-39b3-4c8f-9caf-ea02636daa39"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 },
                    { new Guid("47de8067-213a-4cb0-81ec-e6302eea1c8f"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5961), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 13, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5959), new Guid("047ba41c-5910-4779-9aef-8c2175843284"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 },
                    { new Guid("4985e019-3e4b-4bd0-b504-d1de963e8055"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5969), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 12, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5967), new Guid("a2f88907-2620-4237-a198-5a16c13e8fb6"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 },
                    { new Guid("5d989d97-8af5-4248-9f8c-4dc380a0a23f"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5972), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 11, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5971), new Guid("0e04b9c9-dfa2-4c8f-86b1-be7147231bab"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 },
                    { new Guid("65c91da6-4bb2-4e53-8f07-6d7bb6446f42"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5976), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 10, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5975), new Guid("e0173875-be70-4c74-bf8b-e677a5f5dcd4"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 },
                    { new Guid("b06e1e4d-641a-4fde-9090-8a8779d85c8c"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5990), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 7, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5989), new Guid("207e733e-d00a-47bb-a32d-48bb64bd1a33"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 },
                    { new Guid("f449a23e-ff5b-47e2-bb82-74d9b9601bf1"), null, new DateTime(2024, 12, 3, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5983), null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 8, 8, 24, 26, 35, DateTimeKind.Local).AddTicks(5982), new Guid("94b95608-62ac-4e9c-b0d6-ab846038c2c6"), new Guid("16ab728d-6c56-45f9-b92e-9c773a8c845f"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("c8029aff-f04d-4142-b266-2178a477c43e"), null, null, null, null, null, null, null, new Guid("c39721e0-1ab6-4e78-b33a-21094586b14a"), 2100000m, new Guid("4985e019-3e4b-4bd0-b504-d1de963e8055"), new Guid("12b5f300-4044-4457-8fa3-d14f9390d653"), 2 },
                    { new Guid("c9a39d51-2690-42c4-a479-4bda1316a9a0"), null, null, null, null, null, null, null, new Guid("bebc26d3-f734-46bf-b16d-42e67fb50e71"), 100000m, new Guid("47de8067-213a-4cb0-81ec-e6302eea1c8f"), new Guid("e5ea8ae5-4043-4b70-8e1d-d5b1e4686af1"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("240378cb-b2b4-4987-88f4-b57a481c94c6"), null, null, null, null, null, null, null, 50m, new Guid("47de8067-213a-4cb0-81ec-e6302eea1c8f"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("047ba41c-5910-4779-9aef-8c2175843284"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("2eed0f6b-68b8-445b-a405-bb3e94733b89"), null, null, null, null, null, null, null, 60m, new Guid("4985e019-3e4b-4bd0-b504-d1de963e8055"), new Guid("4e371d58-1177-41c1-8422-64cb63164603"), new Guid("a2f88907-2620-4237-a198-5a16c13e8fb6"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("42e05f9c-bbbf-4773-8309-02b4650fe548"), new Guid("c9a39d51-2690-42c4-a479-4bda1316a9a0"), null, null, null, null, null, null, null },
                    { new Guid("fd19cedc-6a09-441c-87b8-e4f2567b05c1"), new Guid("c8029aff-f04d-4142-b266-2178a477c43e"), null, null, null, null, null, null, null }
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
