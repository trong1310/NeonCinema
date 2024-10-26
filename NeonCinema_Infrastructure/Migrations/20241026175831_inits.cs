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

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Director");

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Director");

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("085843d3-d209-48d4-b057-16de98a4c2cb"), "10:00 PM", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8281), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("0cde329f-8d9d-48d8-837c-718eb11d6e33"), "11:00 PM", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8285), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("4707a91f-a70c-469f-950d-9d46f444f863"), "Trung Quốc" },
                    { new Guid("6a0b5f29-c690-421a-b533-a33b28001df8"), "Vương Quốc Anh" },
                    { new Guid("8420754e-ec7e-454e-b139-5c1f73415291"), "Việt Nam" },
                    { new Guid("ce0b1621-bc07-4592-a23b-89db18c5c062"), "Nhật Bản" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("110c3689-f486-4d0f-8c5c-821628d09dea"), "Hà Nội", "Có", null, null, null, null, null, "Nguyễn Văn A", "Nam", null, null, "Ha Noi", 1 },
                    { new Guid("683a86d5-e7bf-42d5-af29-9253a252e450"), "Hà Nội", "Có", null, null, null, null, null, "Nguyễn Văn D", "Nam", null, null, "Ha Noi", 1 },
                    { new Guid("a8b15ce5-224b-4b19-8e04-e9b32804b7e8"), "Hà Nội", "Có", null, null, null, null, null, "Nguyễn Văn B", "Nam", null, null, "Ha Noi", 5 },
                    { new Guid("aa331925-9e0c-4456-8fc3-cd988e8b3cb9"), "Hà Nội", "Có", null, null, null, null, null, "Nguyễn Văn C", "Nam", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0a567314-e5ec-4287-8a00-341ae3ca99b7"), null, null, null, null, null, "2D", null, null },
                    { new Guid("483d395b-0b81-4ad5-b90a-53f0e1579e10"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("6d3d4f2b-30e4-4366-9a00-560e606318da"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("b7060813-a93b-4579-a4eb-1ce15be4e115"), null, null, null, null, null, "Kịch tính", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("17aad787-a30b-4709-b19c-7e7210c62243"), null, null, null, null, null, "en", null, null },
                    { new Guid("6c8b867e-5d8a-4b0e-bfa5-5dc330d272bd"), null, null, null, null, null, "vi", null, null },
                    { new Guid("d5c7bad1-278c-44f7-9a4f-5de733a8549a"), null, null, null, null, null, "ja", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7362));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7383));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("63d68983-c093-4497-92f0-c48e14949296"), null, null, null, null, null, null, null, "Ghế Đôi" },
                    { new Guid("69227313-0ce7-48ab-aac2-f14296834d2c"), null, null, null, null, null, null, null, "Ghế Thường" },
                    { new Guid("83dda8d6-8a52-429a-a9dd-8c62fbb8b577"), null, null, null, null, null, null, null, "Ghế Vip" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2d75798c-a41b-4280-8afd-9285d01c5cc8"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { new Guid("df90d64f-9303-4712-bed3-c4fdd0f22759"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("093b9f0a-3357-4012-9556-82383f1dbb68"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7943), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1cfad227-0e17-4401-bf23-d5064333eeba"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7474), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("2fd5af82-404c-45a0-bd27-8af25b78e75a"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8072), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("81795828-735a-401b-9606-20c44b815bac"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8028), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("868c1e6d-918e-4322-afdd-f5cd2942848b"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7921), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b8fd163a-7e7b-400f-9bca-10857d618955"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8098), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c4a68954-7c8d-4b46-add6-a0627889b647"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8002), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d9c0effd-5db7-4095-8d3c-093e21a9102d"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(7880), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("ee07c07f-6c42-43f5-aa2c-16f748131484"), "Ba Vi", null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8051), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("16375289-1ace-451a-a14c-8e742cedd2e2"), 18, new Guid("ce0b1621-bc07-4592-a23b-89db18c5c062"), null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8481), null, null, null, "An exciting action movie.", new Guid("110c3689-f486-4d0f-8c5c-821628d09dea"), 120, new Guid("b7060813-a93b-4579-a4eb-1ce15be4e115"), "movieA.jpg", new Guid("17aad787-a30b-4709-b19c-7e7210c62243"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" },
                    { new Guid("90467a2f-29d3-44dd-bcdd-bacc21eab424"), 16, new Guid("6a0b5f29-c690-421a-b533-a33b28001df8"), null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8490), null, null, null, "A thrilling mystery.", new Guid("683a86d5-e7bf-42d5-af29-9253a252e450"), 150, new Guid("483d395b-0b81-4ad5-b90a-53f0e1579e10"), "movieB.jpg", new Guid("6c8b867e-5d8a-4b0e-bfa5-5dc330d272bd"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("49e5c11f-57ca-4ebb-a387-310a9f4b1d22"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("83dda8d6-8a52-429a-a9dd-8c62fbb8b577"), 1 },
                    { new Guid("77a9ec5d-5505-4a83-b476-d5d4cb79ded8"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("63d68983-c093-4497-92f0-c48e14949296"), 1 },
                    { new Guid("f15ab7e0-97fe-4a21-b8fb-9354cb82f136"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("69227313-0ce7-48ab-aac2-f14296834d2c"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("7c08367b-12a3-408b-8052-f9d11e43f0d4"), new Guid("0cde329f-8d9d-48d8-837c-718eb11d6e33"), null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8408), null, null, null, null, null, "Room 2", new Guid("49e5c11f-57ca-4ebb-a387-310a9f4b1d22"), 150, 1 },
                    { new Guid("a8adeefa-1ef0-4a2b-8d4d-8d1af7bf0aac"), new Guid("085843d3-d209-48d4-b057-16de98a4c2cb"), null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8404), null, null, null, null, null, "Room 1", new Guid("49e5c11f-57ca-4ebb-a387-310a9f4b1d22"), 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("5cadd08b-77e2-481b-b0f9-831b44f27f01"), null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8528), null, null, null, null, null, new Guid("90467a2f-29d3-44dd-bcdd-bacc21eab424"), new Guid("7c08367b-12a3-408b-8052-f9d11e43f0d4"), new DateTime(2024, 11, 1, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8527), new Guid("df90d64f-9303-4712-bed3-c4fdd0f22759"), 1 },
                    { new Guid("a4c99eec-fb1c-4091-936d-15796626b0c7"), null, new DateTime(2024, 10, 27, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8524), null, null, null, null, null, new Guid("16375289-1ace-451a-a14c-8e742cedd2e2"), new Guid("a8adeefa-1ef0-4a2b-8d4d-8d1af7bf0aac"), new DateTime(2024, 10, 29, 0, 58, 31, 585, DateTimeKind.Local).AddTicks(8516), new Guid("2d75798c-a41b-4280-8afd-9285d01c5cc8"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("4707a91f-a70c-469f-950d-9d46f444f863"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("8420754e-ec7e-454e-b139-5c1f73415291"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("a8b15ce5-224b-4b19-8e04-e9b32804b7e8"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("aa331925-9e0c-4456-8fc3-cd988e8b3cb9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("0a567314-e5ec-4287-8a00-341ae3ca99b7"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("6d3d4f2b-30e4-4366-9a00-560e606318da"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("d5c7bad1-278c-44f7-9a4f-5de733a8549a"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("5cadd08b-77e2-481b-b0f9-831b44f27f01"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("a4c99eec-fb1c-4091-936d-15796626b0c7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("77a9ec5d-5505-4a83-b476-d5d4cb79ded8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f15ab7e0-97fe-4a21-b8fb-9354cb82f136"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("093b9f0a-3357-4012-9556-82383f1dbb68"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1cfad227-0e17-4401-bf23-d5064333eeba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2fd5af82-404c-45a0-bd27-8af25b78e75a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("81795828-735a-401b-9606-20c44b815bac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("868c1e6d-918e-4322-afdd-f5cd2942848b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b8fd163a-7e7b-400f-9bca-10857d618955"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c4a68954-7c8d-4b46-add6-a0627889b647"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9c0effd-5db7-4095-8d3c-093e21a9102d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ee07c07f-6c42-43f5-aa2c-16f748131484"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("16375289-1ace-451a-a14c-8e742cedd2e2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("90467a2f-29d3-44dd-bcdd-bacc21eab424"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("7c08367b-12a3-408b-8052-f9d11e43f0d4"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("a8adeefa-1ef0-4a2b-8d4d-8d1af7bf0aac"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("63d68983-c093-4497-92f0-c48e14949296"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("69227313-0ce7-48ab-aac2-f14296834d2c"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("2d75798c-a41b-4280-8afd-9285d01c5cc8"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("df90d64f-9303-4712-bed3-c4fdd0f22759"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("085843d3-d209-48d4-b057-16de98a4c2cb"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("0cde329f-8d9d-48d8-837c-718eb11d6e33"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("6a0b5f29-c690-421a-b533-a33b28001df8"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("ce0b1621-bc07-4592-a23b-89db18c5c062"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("110c3689-f486-4d0f-8c5c-821628d09dea"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("683a86d5-e7bf-42d5-af29-9253a252e450"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("483d395b-0b81-4ad5-b90a-53f0e1579e10"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("b7060813-a93b-4579-a4eb-1ce15be4e115"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("17aad787-a30b-4709-b19c-7e7210c62243"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("6c8b867e-5d8a-4b0e-bfa5-5dc330d272bd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("49e5c11f-57ca-4ebb-a387-310a9f4b1d22"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("83dda8d6-8a52-429a-a9dd-8c62fbb8b577"));

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Director",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Director",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
