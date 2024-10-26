using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initdbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("20401373-3eaa-4759-9354-5b81df96ea79"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("7010e16c-f7bf-4611-b43c-b8f036db5229"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("c123d2fc-e797-46ff-8fce-9dcc4ee86ad7"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("f04a00b8-c6c6-4a7c-8ab1-6c2134a832c7"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("0c764a00-c3d8-4f07-af03-d7ee32136a16"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("fcc1504d-50aa-4b35-a8ec-79f0fd76fec5"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("087c25e2-598c-4525-a97a-267ec0045b1a"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("9004871d-d2f0-4efb-a262-ef52d1dd481f"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("a78ac51e-b8da-4271-94ae-a9c54504081c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("da00d790-51cb-43e9-897f-f0aaf1f96836"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f728f80a-a380-4798-b893-773adbb86f1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("184791c8-1813-4e2e-96c2-bce44a1be456"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1e4af7c4-06ac-4fcc-a9e6-c479a265cff0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("28c784f2-8428-4ac9-94f8-3b52d0060455"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2a032931-b5b8-4804-bffc-f8caabce2fda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("52f385fe-897c-470e-92d0-a96e4478dd00"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("59e91613-a847-4728-9b94-f5649886aec5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a1755ce1-bd97-4c56-9e60-2f70bc888ae0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4abae85-c63a-40d8-93a9-a5a882ac6257"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("eb4eeca2-b44c-4c02-b048-aed443ccfa32"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("891aadd6-03f7-4b29-b984-ace296452352"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("f27ba3ca-21e0-486c-b927-13f1799cc367"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("65d5e3cb-ecc5-4671-a3d3-5095bae00cea"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("f473f8fc-0e21-45e6-a8dd-3fe966ccf5e8"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("d7891998-7f39-4a61-9630-c5948656dad5"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("f1eae834-4e2d-4120-8684-9b96f76615e1"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("2e40ae9d-1c6b-495d-bcfa-49006105ef13"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("ba82e82f-c12c-49a0-b812-862905aaf649"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("19dd0077-52bd-406d-a83f-1fc613a8eeb7"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("e36e8397-c8dc-44ae-9a01-58185435c101"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("2539b1cf-f38e-4c53-8d8b-4c4a0637e959"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("ef24d097-ff1c-47d7-854f-832e84c430bf"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("5946eff2-6783-4646-b1f9-e6749ccae986"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("9a56e587-844f-4a87-afb7-b17501d1ecbb"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("12dd2634-2264-4dca-9182-1124e8663962"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("88b28301-2f42-49a8-8992-f68395726b4b"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("bdd95cb7-195c-4d30-a39a-07a630d27cf2"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("d086d64b-19e3-4c89-b4d5-3e145a9125b6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f0cab9e1-c471-459c-a8ee-c0ea1a242404"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("3a3e3e44-6fd6-45f8-8562-95598f4f1397"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("80cd43e1-679e-43c2-891b-ea2bd9aae2b7"), "10:00 PM", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9113), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("ea46be5e-169f-4fd7-b982-f6085f5af35f"), "11:00 PM", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9122), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("bcd4e09a-60d2-4b2c-8f2e-db75dada7a4d"), "Nhật Bản" },
                    { new Guid("d2a5a470-f5af-430f-9096-7e66655fda88"), "Vương Quốc Anh" },
                    { new Guid("e1319216-d5f2-43d8-9d21-7a4d65bf9d69"), "Việt Nam" },
                    { new Guid("ff8579a1-22b9-452d-bf58-5e66ee74ad89"), "Trung Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("85b085dc-85f9-432c-a39b-a629413c2ffa"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("b01da296-de40-4a49-b7ec-3d03dd7afacb"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("cedfb8e3-8713-4629-a840-ec6acd10d1f3"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("d004fb02-de31-40b3-987d-4466eb4145c1"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("498623c2-4ca3-4f3e-b3d3-d5ac16c481b9"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("6ceea4b0-7cf3-40f2-a71e-2e5baf15d5f3"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("a47a4149-6efc-43ba-9958-23791e715b94"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("d6c40f45-a1b8-47a1-ab1e-35fb89231a02"), null, null, null, null, null, "2D", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("b49380a8-2ba5-4ddc-9c4f-ec4e42caa81c"), null, null, null, null, null, "ja", null, null },
                    { new Guid("d466a83e-29d5-44ff-8fc7-41d5d626873e"), null, null, null, null, null, "vi", null, null },
                    { new Guid("f8874e4b-95cf-488a-92a0-3c81ff613cb2"), null, null, null, null, null, "en", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("a4ec0119-b344-4b64-bc29-085a08698b61"), null, null, null, null, null, null, null, "Ghế Vip" },
                    { new Guid("b97515a6-d463-412d-94c0-099c5d9df7a0"), null, null, null, null, null, null, null, "Ghế Đôi" },
                    { new Guid("bc72cf62-dc70-41b3-af61-a1e840928eb7"), null, null, null, null, null, null, null, "Ghế Thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1f730bc0-0399-418d-bd12-a0fe76c81487"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 },
                    { new Guid("e16c957c-3bae-4007-9918-0bdc3cc122e4"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("1c5e26b1-d2bb-47ea-b1ca-33d326555c2e"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8620), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("59716e8b-640d-460e-8691-2e0e6d9de012"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8705), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("82cfa8ba-ba2f-475c-b765-36863340f8a5"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8782), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8d0a52da-54ba-42ea-a2f3-c614faa09069"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8802), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("93b36bfb-f666-46cb-89b6-e7dc43368e91"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8671), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9c26be86-55f2-44b4-a312-03115a19a767"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8742), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ba3ba035-c283-4051-a2c9-c7473c7603b8"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8184), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("c3837afe-899d-471b-bb95-8b4b4bc011fe"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8649), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("e8c709e0-4511-4836-a4c6-9f6238e4915c"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(8763), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("58eddf0c-a63f-42eb-a918-c56ce1a71621"), 18, new Guid("bcd4e09a-60d2-4b2c-8f2e-db75dada7a4d"), null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9428), null, null, null, "An exciting action movie.", new Guid("85b085dc-85f9-432c-a39b-a629413c2ffa"), 120, new Guid("498623c2-4ca3-4f3e-b3d3-d5ac16c481b9"), "movieA.jpg", new Guid("f8874e4b-95cf-488a-92a0-3c81ff613cb2"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" },
                    { new Guid("a92a6b08-9672-44e0-8184-d930b3d0dbfb"), 16, new Guid("d2a5a470-f5af-430f-9096-7e66655fda88"), null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9439), null, null, null, "A thrilling mystery.", new Guid("b01da296-de40-4a49-b7ec-3d03dd7afacb"), 150, new Guid("a47a4149-6efc-43ba-9958-23791e715b94"), "movieB.jpg", new Guid("d466a83e-29d5-44ff-8fc7-41d5d626873e"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("3c720579-fede-44f0-b388-72a15c1d8ca6"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("b97515a6-d463-412d-94c0-099c5d9df7a0"), 1 },
                    { new Guid("d0651655-b75e-4ea8-9962-1b17e9430254"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("a4ec0119-b344-4b64-bc29-085a08698b61"), 1 },
                    { new Guid("e4296c5a-1d5a-4e7b-8796-f74e45c658c9"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("bc72cf62-dc70-41b3-af61-a1e840928eb7"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("12a2952e-99dc-4296-b26b-5d5fe39b1075"), new Guid("ea46be5e-169f-4fd7-b982-f6085f5af35f"), null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9320), null, null, null, null, null, "Room 2", new Guid("d0651655-b75e-4ea8-9962-1b17e9430254"), 150, 1 },
                    { new Guid("2ef2ab8c-5eb4-44d9-b8a8-53e259bc6585"), new Guid("80cd43e1-679e-43c2-891b-ea2bd9aae2b7"), null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9314), null, null, null, null, null, "Room 1", new Guid("d0651655-b75e-4ea8-9962-1b17e9430254"), 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("27a90edb-5ae7-4d02-82c9-5f7753a85f25"), null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9486), null, null, null, null, null, new Guid("a92a6b08-9672-44e0-8184-d930b3d0dbfb"), new Guid("12a2952e-99dc-4296-b26b-5d5fe39b1075"), new DateTime(2024, 11, 1, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9485), new Guid("1f730bc0-0399-418d-bd12-a0fe76c81487"), 1 },
                    { new Guid("6e10d903-77c5-49a0-a2c7-eab7505556f3"), null, new DateTime(2024, 10, 27, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9481), null, null, null, null, null, new Guid("58eddf0c-a63f-42eb-a918-c56ce1a71621"), new Guid("2ef2ab8c-5eb4-44d9-b8a8-53e259bc6585"), new DateTime(2024, 10, 29, 0, 47, 24, 657, DateTimeKind.Local).AddTicks(9472), new Guid("e16c957c-3bae-4007-9918-0bdc3cc122e4"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("e1319216-d5f2-43d8-9d21-7a4d65bf9d69"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("ff8579a1-22b9-452d-bf58-5e66ee74ad89"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("cedfb8e3-8713-4629-a840-ec6acd10d1f3"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("d004fb02-de31-40b3-987d-4466eb4145c1"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("6ceea4b0-7cf3-40f2-a71e-2e5baf15d5f3"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("d6c40f45-a1b8-47a1-ab1e-35fb89231a02"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("b49380a8-2ba5-4ddc-9c4f-ec4e42caa81c"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("27a90edb-5ae7-4d02-82c9-5f7753a85f25"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("6e10d903-77c5-49a0-a2c7-eab7505556f3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3c720579-fede-44f0-b388-72a15c1d8ca6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e4296c5a-1d5a-4e7b-8796-f74e45c658c9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1c5e26b1-d2bb-47ea-b1ca-33d326555c2e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("59716e8b-640d-460e-8691-2e0e6d9de012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("82cfa8ba-ba2f-475c-b765-36863340f8a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8d0a52da-54ba-42ea-a2f3-c614faa09069"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93b36bfb-f666-46cb-89b6-e7dc43368e91"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9c26be86-55f2-44b4-a312-03115a19a767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba3ba035-c283-4051-a2c9-c7473c7603b8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c3837afe-899d-471b-bb95-8b4b4bc011fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e8c709e0-4511-4836-a4c6-9f6238e4915c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("58eddf0c-a63f-42eb-a918-c56ce1a71621"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("a92a6b08-9672-44e0-8184-d930b3d0dbfb"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("12a2952e-99dc-4296-b26b-5d5fe39b1075"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("2ef2ab8c-5eb4-44d9-b8a8-53e259bc6585"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("b97515a6-d463-412d-94c0-099c5d9df7a0"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("bc72cf62-dc70-41b3-af61-a1e840928eb7"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("1f730bc0-0399-418d-bd12-a0fe76c81487"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("e16c957c-3bae-4007-9918-0bdc3cc122e4"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("80cd43e1-679e-43c2-891b-ea2bd9aae2b7"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("ea46be5e-169f-4fd7-b982-f6085f5af35f"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("bcd4e09a-60d2-4b2c-8f2e-db75dada7a4d"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("d2a5a470-f5af-430f-9096-7e66655fda88"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("85b085dc-85f9-432c-a39b-a629413c2ffa"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("b01da296-de40-4a49-b7ec-3d03dd7afacb"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("498623c2-4ca3-4f3e-b3d3-d5ac16c481b9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("a47a4149-6efc-43ba-9958-23791e715b94"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("d466a83e-29d5-44ff-8fc7-41d5d626873e"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("f8874e4b-95cf-488a-92a0-3c81ff613cb2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d0651655-b75e-4ea8-9962-1b17e9430254"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("a4ec0119-b344-4b64-bc29-085a08698b61"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("19dd0077-52bd-406d-a83f-1fc613a8eeb7"), "11:00 PM", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7412), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("e36e8397-c8dc-44ae-9a01-58185435c101"), "10:00 PM", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7405), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("20401373-3eaa-4759-9354-5b81df96ea79"), "Trung Quốc" },
                    { new Guid("2539b1cf-f38e-4c53-8d8b-4c4a0637e959"), "Vương Quốc Anh" },
                    { new Guid("7010e16c-f7bf-4611-b43c-b8f036db5229"), "Việt Nam" },
                    { new Guid("ef24d097-ff1c-47d7-854f-832e84c430bf"), "Nhật Bản" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("5946eff2-6783-4646-b1f9-e6749ccae986"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("9a56e587-844f-4a87-afb7-b17501d1ecbb"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("c123d2fc-e797-46ff-8fce-9dcc4ee86ad7"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("f04a00b8-c6c6-4a7c-8ab1-6c2134a832c7"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0c764a00-c3d8-4f07-af03-d7ee32136a16"), null, null, null, null, null, "2D", null, null },
                    { new Guid("12dd2634-2264-4dca-9182-1124e8663962"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("88b28301-2f42-49a8-8992-f68395726b4b"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("fcc1504d-50aa-4b35-a8ec-79f0fd76fec5"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("087c25e2-598c-4525-a97a-267ec0045b1a"), null, null, null, null, null, "ja", null, null },
                    { new Guid("bdd95cb7-195c-4d30-a39a-07a630d27cf2"), null, null, null, null, null, "en", null, null },
                    { new Guid("d086d64b-19e3-4c89-b4d5-3e145a9125b6"), null, null, null, null, null, "vi", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("3a3e3e44-6fd6-45f8-8562-95598f4f1397"), null, null, null, null, null, null, null, "Ghế Vip" },
                    { new Guid("d7891998-7f39-4a61-9630-c5948656dad5"), null, null, null, null, null, null, null, "Ghế Đôi" },
                    { new Guid("f1eae834-4e2d-4120-8684-9b96f76615e1"), null, null, null, null, null, null, null, "Ghế Thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2e40ae9d-1c6b-495d-bcfa-49006105ef13"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 },
                    { new Guid("ba82e82f-c12c-49a0-b812-862905aaf649"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("184791c8-1813-4e2e-96c2-bce44a1be456"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7006), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1e4af7c4-06ac-4fcc-a9e6-c479a265cff0"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6382), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("28c784f2-8428-4ac9-94f8-3b52d0060455"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7053), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2a032931-b5b8-4804-bffc-f8caabce2fda"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7118), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("52f385fe-897c-470e-92d0-a96e4478dd00"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6980), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("59e91613-a847-4728-9b94-f5649886aec5"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6953), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a1755ce1-bd97-4c56-9e60-2f70bc888ae0"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7080), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("e4abae85-c63a-40d8-93a9-a5a882ac6257"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(6924), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("eb4eeca2-b44c-4c02-b048-aed443ccfa32"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7140), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("891aadd6-03f7-4b29-b984-ace296452352"), 16, new Guid("2539b1cf-f38e-4c53-8d8b-4c4a0637e959"), null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7675), null, null, null, "A thrilling mystery.", new Guid("5946eff2-6783-4646-b1f9-e6749ccae986"), 150, new Guid("12dd2634-2264-4dca-9182-1124e8663962"), "movieB.jpg", new Guid("d086d64b-19e3-4c89-b4d5-3e145a9125b6"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" },
                    { new Guid("f27ba3ca-21e0-486c-b927-13f1799cc367"), 18, new Guid("ef24d097-ff1c-47d7-854f-832e84c430bf"), null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7667), null, null, null, "An exciting action movie.", new Guid("9a56e587-844f-4a87-afb7-b17501d1ecbb"), 120, new Guid("88b28301-2f42-49a8-8992-f68395726b4b"), "movieA.jpg", new Guid("bdd95cb7-195c-4d30-a39a-07a630d27cf2"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("da00d790-51cb-43e9-897f-f0aaf1f96836"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("d7891998-7f39-4a61-9630-c5948656dad5"), 1 },
                    { new Guid("f0cab9e1-c471-459c-a8ee-c0ea1a242404"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("3a3e3e44-6fd6-45f8-8562-95598f4f1397"), 1 },
                    { new Guid("f728f80a-a380-4798-b893-773adbb86f1c"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("f1eae834-4e2d-4120-8684-9b96f76615e1"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("65d5e3cb-ecc5-4671-a3d3-5095bae00cea"), new Guid("19dd0077-52bd-406d-a83f-1fc613a8eeb7"), null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7576), null, null, null, null, null, "Room 2", new Guid("f0cab9e1-c471-459c-a8ee-c0ea1a242404"), 150, 1 },
                    { new Guid("f473f8fc-0e21-45e6-a8dd-3fe966ccf5e8"), new Guid("e36e8397-c8dc-44ae-9a01-58185435c101"), null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7569), null, null, null, null, null, "Room 1", new Guid("f0cab9e1-c471-459c-a8ee-c0ea1a242404"), 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("9004871d-d2f0-4efb-a262-ef52d1dd481f"), null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7719), null, null, null, null, null, new Guid("891aadd6-03f7-4b29-b984-ace296452352"), new Guid("65d5e3cb-ecc5-4671-a3d3-5095bae00cea"), new DateTime(2024, 11, 1, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7718), new Guid("2e40ae9d-1c6b-495d-bcfa-49006105ef13"), 1 },
                    { new Guid("a78ac51e-b8da-4271-94ae-a9c54504081c"), null, new DateTime(2024, 10, 27, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7714), null, null, null, null, null, new Guid("f27ba3ca-21e0-486c-b927-13f1799cc367"), new Guid("f473f8fc-0e21-45e6-a8dd-3fe966ccf5e8"), new DateTime(2024, 10, 29, 0, 46, 54, 652, DateTimeKind.Local).AddTicks(7704), new Guid("ba82e82f-c12c-49a0-b812-862905aaf649"), 1 }
                });
        }
    }
}
