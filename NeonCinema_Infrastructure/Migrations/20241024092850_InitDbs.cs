using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("e09edd00-881a-4f97-b6bf-ee00bcef4c80"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("f295331f-9224-4406-a387-63f950355b95"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("8ee654bc-77a5-4171-8377-7ffcc5b26e30"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("c77b7e37-07e7-41d2-896b-b22e32c10cfb"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("9854c67e-97af-41a0-9a8a-6428813d16d9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("fb5eb441-296e-4922-be45-e6703b23923a"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("ef0ee229-41eb-45b2-9955-fb119c01d7aa"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("d0240d92-f54e-41ee-8411-5df27025f2aa"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("d4381cc4-ad66-4128-87db-30fc1907aac8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4f8ffb50-db8a-44dc-99eb-4f5d04aacb51"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9cdb6942-9b2f-4492-8904-92c91a2a4f2d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("102f82fa-524b-4208-a0b3-2f8a8b5ac3f7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3a843c31-9564-4818-b168-89dff985a1e2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6fd2cbf7-a0e4-405e-8877-ecfcaa8f6a84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("731b7ad8-5ec1-45ef-9f0e-aab278365286"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7d3f333e-3ff1-4214-b254-83d558ecfd22"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("811df57b-1346-419b-a681-811fa27c7c4f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("93acf7b5-a16b-4f95-8957-ecb42042b1fd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a0cd6f36-53ac-46b2-99f7-aacbf5acd162"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cfe8a704-d583-488e-a2e7-1dd6c6e81f25"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("845dce00-6dc3-4bfc-8454-5c58077da2bf"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("d399ebe8-f204-4d9f-85dd-2197f6282663"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("6ff045e2-0044-42e5-93e5-94a4df35a292"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("e6240079-f05f-40fd-9cba-98158dc4690f"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("8a3eaa9f-6f83-45c1-bf2d-8457d0948f6c"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("d6cfc8e5-5e3d-4b25-8dd3-3fc10dbbb0a4"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("89613507-30c2-4c56-9f5d-3cfcb8061987"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("f384307a-a0f9-4471-88c8-616308e43de0"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("636376cd-c288-4e09-ac6d-8ad3b9143f0b"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("8f70aa55-b2d4-4f1b-801b-0337612c70af"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("0234f54f-3cc5-4fe8-bb13-532fee5327af"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("1b2444db-c8bc-4104-8efd-e29e410fb11a"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("0eab970f-9bc6-47ae-b921-c1d29ab31291"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("5ff3bbc6-f6f8-4baa-9db7-750484df14c9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("09158f57-de4d-4845-baef-5cf520bfa0bd"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("ddb0ff1c-c3aa-410a-b584-363e9b6e95d5"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("0a9a7ac1-eb33-48db-a5ec-883ad8f2229d"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("c3f0d20d-e111-4ce4-857c-0e5aad467776"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("311d2379-5f75-482c-8d26-0bcfc82ee3f8"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("359b55ca-899f-4a0c-b673-2b03b13bcc71"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("4518bbb7-3142-4e7c-9753-67eaab5966f7"), "10:00 PM", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9070), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("e6e06ff0-683a-451c-ad02-9e4a32b845da"), "11:00 PM", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9074), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("00ccb47f-cdb4-451a-a447-44c1fcaf9cd6"), "Trung Quốc" },
                    { new Guid("33550bd3-32c7-4b0d-81ad-0221b86520fb"), "Vương Quốc Anh" },
                    { new Guid("e4678749-c850-4a74-9205-8fee74a15ec6"), "Nhật Bản" },
                    { new Guid("fffc7c98-1fa1-460b-b6de-d129e3c399ca"), "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("536038c0-8e92-498d-88a5-ee2094d5a5cf"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("7979861e-5ad6-4040-91bb-12ba84b07f35"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("a571674f-6655-47f7-86fb-8094d85254e9"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("a592e9bc-e37e-4a76-b84b-da722d012d57"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0fc1ac87-cf42-4914-bd7e-cf56f4ec1fc8"), null, null, null, null, null, "2D", null, null },
                    { new Guid("6eaef783-5326-4a69-bb6f-d2da6d5a5424"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("866e8f26-6824-4dfa-af75-baae7618c309"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("9e4e2b69-38a6-4203-812d-606eb44374e1"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("272d0e3b-4182-4478-a23d-6238776c4beb"), null, null, null, null, null, "ja", null, null },
                    { new Guid("727277c6-2546-4082-8e0c-faf5dd7552d3"), null, null, null, null, null, "en", null, null },
                    { new Guid("d7306f34-2724-4cdd-901c-91cf91b13a27"), null, null, null, null, null, "vi", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(7861));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("8196d479-2a65-43a4-ae9a-ecf2d7769cf8"), null, null, null, null, null, null, null, "Ghế Thường" },
                    { new Guid("968b88cd-8e3d-444b-b4f9-f42d63c57756"), null, null, null, null, null, null, null, "Ghế Đôi" },
                    { new Guid("f4b0f880-a152-4eb9-a79b-9ae3a5e290e6"), null, null, null, null, null, null, null, "Ghế Vip" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("eee06523-90ac-469a-b649-76a7d0a92933"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { new Guid("f5a1522a-33c0-4957-a3f5-0a71d955cfc1"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0c2495fa-be28-494b-ba11-c86dd632185e"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8528), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1eb772a2-2222-42d4-a5e0-d86d690b167f"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8473), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("25dcec12-9764-4000-a44b-ed816d50101b"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8679), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4c8f8f0c-3d39-41fb-aff0-b9e07e3d992f"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8570), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("67a906c5-2c4e-49ef-8084-cd7a8daf0d3c"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(7969), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("b78c96dd-efaf-4dd9-89f1-e0ed715b4767"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8635), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cb1d58f1-5325-4e6b-b92d-aafc7dc43048"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8754), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f076c7cf-c76b-465c-b5d6-715be1456bd5"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8708), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f6b448ac-d0dd-4507-b3dd-ccc6bcbf5888"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(8600), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "ActorID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("675429e0-0c1e-4e76-aa36-16abe40fbc5f"), new Guid("127d38f8-f339-40a6-9626-0dbd122d7f5f"), 18, new Guid("e4678749-c850-4a74-9205-8fee74a15ec6"), null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9319), null, null, null, "An exciting action movie.", new Guid("7979861e-5ad6-4040-91bb-12ba84b07f35"), 120, new Guid("866e8f26-6824-4dfa-af75-baae7618c309"), "movieA.jpg", new Guid("727277c6-2546-4082-8e0c-faf5dd7552d3"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" },
                    { new Guid("d320772f-72a6-4de3-9258-60ad66c43295"), new Guid("127d38f8-f339-40a6-9626-0dbd122d7f5f"), 16, new Guid("33550bd3-32c7-4b0d-81ad-0221b86520fb"), null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9343), null, null, null, "A thrilling mystery.", new Guid("a571674f-6655-47f7-86fb-8094d85254e9"), 150, new Guid("6eaef783-5326-4a69-bb6f-d2da6d5a5424"), "movieB.jpg", new Guid("d7306f34-2724-4cdd-901c-91cf91b13a27"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("1a514fb3-6327-4c52-b60d-ddef2fb6e49e"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("968b88cd-8e3d-444b-b4f9-f42d63c57756"), 1 },
                    { new Guid("c616f33a-0457-4824-9b9a-55af15f740fe"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("8196d479-2a65-43a4-ae9a-ecf2d7769cf8"), 1 },
                    { new Guid("d2d2f7e6-26f3-4bee-b3b6-892fe56f8763"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("f4b0f880-a152-4eb9-a79b-9ae3a5e290e6"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("5bf5d368-920e-43be-b3ba-0325f68d235f"), new Guid("e6e06ff0-683a-451c-ad02-9e4a32b845da"), null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9228), null, null, null, null, null, "Room 2", new Guid("d2d2f7e6-26f3-4bee-b3b6-892fe56f8763"), 150, 1 },
                    { new Guid("5c41f800-2811-4204-88fc-ceb6d42cf6dd"), new Guid("4518bbb7-3142-4e7c-9753-67eaab5966f7"), null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9225), null, null, null, null, null, "Room 1", new Guid("d2d2f7e6-26f3-4bee-b3b6-892fe56f8763"), 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("80907bce-e929-44d2-8361-5942b38ba8ce"), null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9384), null, null, null, null, null, new Guid("d320772f-72a6-4de3-9258-60ad66c43295"), new Guid("5bf5d368-920e-43be-b3ba-0325f68d235f"), new DateTime(2024, 10, 29, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9383), new Guid("f5a1522a-33c0-4957-a3f5-0a71d955cfc1"), 1 },
                    { new Guid("d9f8da96-cf16-4f8c-a7f0-499556d1bc3e"), null, new DateTime(2024, 10, 24, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9380), null, null, null, null, null, new Guid("675429e0-0c1e-4e76-aa36-16abe40fbc5f"), new Guid("5c41f800-2811-4204-88fc-ceb6d42cf6dd"), new DateTime(2024, 10, 26, 16, 28, 50, 68, DateTimeKind.Local).AddTicks(9372), new Guid("eee06523-90ac-469a-b649-76a7d0a92933"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("00ccb47f-cdb4-451a-a447-44c1fcaf9cd6"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("fffc7c98-1fa1-460b-b6de-d129e3c399ca"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("536038c0-8e92-498d-88a5-ee2094d5a5cf"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("a592e9bc-e37e-4a76-b84b-da722d012d57"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("0fc1ac87-cf42-4914-bd7e-cf56f4ec1fc8"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("9e4e2b69-38a6-4203-812d-606eb44374e1"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("272d0e3b-4182-4478-a23d-6238776c4beb"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("80907bce-e929-44d2-8361-5942b38ba8ce"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("d9f8da96-cf16-4f8c-a7f0-499556d1bc3e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1a514fb3-6327-4c52-b60d-ddef2fb6e49e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c616f33a-0457-4824-9b9a-55af15f740fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0c2495fa-be28-494b-ba11-c86dd632185e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1eb772a2-2222-42d4-a5e0-d86d690b167f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("25dcec12-9764-4000-a44b-ed816d50101b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4c8f8f0c-3d39-41fb-aff0-b9e07e3d992f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("67a906c5-2c4e-49ef-8084-cd7a8daf0d3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b78c96dd-efaf-4dd9-89f1-e0ed715b4767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cb1d58f1-5325-4e6b-b92d-aafc7dc43048"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f076c7cf-c76b-465c-b5d6-715be1456bd5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f6b448ac-d0dd-4507-b3dd-ccc6bcbf5888"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("675429e0-0c1e-4e76-aa36-16abe40fbc5f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("d320772f-72a6-4de3-9258-60ad66c43295"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("5bf5d368-920e-43be-b3ba-0325f68d235f"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("5c41f800-2811-4204-88fc-ceb6d42cf6dd"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("8196d479-2a65-43a4-ae9a-ecf2d7769cf8"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("968b88cd-8e3d-444b-b4f9-f42d63c57756"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("eee06523-90ac-469a-b649-76a7d0a92933"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("f5a1522a-33c0-4957-a3f5-0a71d955cfc1"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("4518bbb7-3142-4e7c-9753-67eaab5966f7"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("e6e06ff0-683a-451c-ad02-9e4a32b845da"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("33550bd3-32c7-4b0d-81ad-0221b86520fb"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("e4678749-c850-4a74-9205-8fee74a15ec6"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("7979861e-5ad6-4040-91bb-12ba84b07f35"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("a571674f-6655-47f7-86fb-8094d85254e9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("6eaef783-5326-4a69-bb6f-d2da6d5a5424"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("866e8f26-6824-4dfa-af75-baae7618c309"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("727277c6-2546-4082-8e0c-faf5dd7552d3"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("d7306f34-2724-4cdd-901c-91cf91b13a27"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d2d2f7e6-26f3-4bee-b3b6-892fe56f8763"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("f4b0f880-a152-4eb9-a79b-9ae3a5e290e6"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("636376cd-c288-4e09-ac6d-8ad3b9143f0b"), "10:00 PM", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3351), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("8f70aa55-b2d4-4f1b-801b-0337612c70af"), "11:00 PM", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3356), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0234f54f-3cc5-4fe8-bb13-532fee5327af"), "Nhật Bản" },
                    { new Guid("1b2444db-c8bc-4104-8efd-e29e410fb11a"), "Vương Quốc Anh" },
                    { new Guid("e09edd00-881a-4f97-b6bf-ee00bcef4c80"), "Việt Nam" },
                    { new Guid("f295331f-9224-4406-a387-63f950355b95"), "Trung Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0eab970f-9bc6-47ae-b921-c1d29ab31291"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("5ff3bbc6-f6f8-4baa-9db7-750484df14c9"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("8ee654bc-77a5-4171-8377-7ffcc5b26e30"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("c77b7e37-07e7-41d2-896b-b22e32c10cfb"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("09158f57-de4d-4845-baef-5cf520bfa0bd"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("9854c67e-97af-41a0-9a8a-6428813d16d9"), null, null, null, null, null, "2D", null, null },
                    { new Guid("ddb0ff1c-c3aa-410a-b584-363e9b6e95d5"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("fb5eb441-296e-4922-be45-e6703b23923a"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0a9a7ac1-eb33-48db-a5ec-883ad8f2229d"), null, null, null, null, null, "vi", null, null },
                    { new Guid("c3f0d20d-e111-4ce4-857c-0e5aad467776"), null, null, null, null, null, "en", null, null },
                    { new Guid("ef0ee229-41eb-45b2-9955-fb119c01d7aa"), null, null, null, null, null, "ja", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("359b55ca-899f-4a0c-b673-2b03b13bcc71"), null, null, null, null, null, null, null, "Ghế Vip" },
                    { new Guid("8a3eaa9f-6f83-45c1-bf2d-8457d0948f6c"), null, null, null, null, null, null, null, "Ghế Thường" },
                    { new Guid("d6cfc8e5-5e3d-4b25-8dd3-3fc10dbbb0a4"), null, null, null, null, null, null, null, "Ghế Đôi" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("89613507-30c2-4c56-9f5d-3cfcb8061987"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { new Guid("f384307a-a0f9-4471-88c8-616308e43de0"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("102f82fa-524b-4208-a0b3-2f8a8b5ac3f7"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3064), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3a843c31-9564-4818-b168-89dff985a1e2"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2939), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6fd2cbf7-a0e4-405e-8877-ecfcaa8f6a84"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3042), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("731b7ad8-5ec1-45ef-9f0e-aab278365286"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3084), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7d3f333e-3ff1-4214-b254-83d558ecfd22"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3011), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("811df57b-1346-419b-a681-811fa27c7c4f"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2544), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("93acf7b5-a16b-4f95-8957-ecb42042b1fd"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2961), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a0cd6f36-53ac-46b2-99f7-aacbf5acd162"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2988), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cfe8a704-d583-488e-a2e7-1dd6c6e81f25"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(2909), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "ActorID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("845dce00-6dc3-4bfc-8454-5c58077da2bf"), new Guid("127d38f8-f339-40a6-9626-0dbd122d7f5f"), 16, new Guid("1b2444db-c8bc-4104-8efd-e29e410fb11a"), null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3548), null, null, null, "A thrilling mystery.", new Guid("5ff3bbc6-f6f8-4baa-9db7-750484df14c9"), 150, new Guid("09158f57-de4d-4845-baef-5cf520bfa0bd"), "movieB.jpg", new Guid("0a9a7ac1-eb33-48db-a5ec-883ad8f2229d"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" },
                    { new Guid("d399ebe8-f204-4d9f-85dd-2197f6282663"), new Guid("127d38f8-f339-40a6-9626-0dbd122d7f5f"), 18, new Guid("0234f54f-3cc5-4fe8-bb13-532fee5327af"), null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3538), null, null, null, "An exciting action movie.", new Guid("0eab970f-9bc6-47ae-b921-c1d29ab31291"), 120, new Guid("ddb0ff1c-c3aa-410a-b584-363e9b6e95d5"), "movieA.jpg", new Guid("c3f0d20d-e111-4ce4-857c-0e5aad467776"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("311d2379-5f75-482c-8d26-0bcfc82ee3f8"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("359b55ca-899f-4a0c-b673-2b03b13bcc71"), 1 },
                    { new Guid("4f8ffb50-db8a-44dc-99eb-4f5d04aacb51"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("d6cfc8e5-5e3d-4b25-8dd3-3fc10dbbb0a4"), 1 },
                    { new Guid("9cdb6942-9b2f-4492-8904-92c91a2a4f2d"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("8a3eaa9f-6f83-45c1-bf2d-8457d0948f6c"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("6ff045e2-0044-42e5-93e5-94a4df35a292"), new Guid("636376cd-c288-4e09-ac6d-8ad3b9143f0b"), null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3453), null, null, null, null, null, "Room 1", new Guid("311d2379-5f75-482c-8d26-0bcfc82ee3f8"), 100, 1 },
                    { new Guid("e6240079-f05f-40fd-9cba-98158dc4690f"), new Guid("8f70aa55-b2d4-4f1b-801b-0337612c70af"), null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3458), null, null, null, null, null, "Room 2", new Guid("311d2379-5f75-482c-8d26-0bcfc82ee3f8"), 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("d0240d92-f54e-41ee-8411-5df27025f2aa"), null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3584), null, null, null, null, null, new Guid("845dce00-6dc3-4bfc-8454-5c58077da2bf"), new Guid("e6240079-f05f-40fd-9cba-98158dc4690f"), new DateTime(2024, 10, 29, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3583), new Guid("f384307a-a0f9-4471-88c8-616308e43de0"), 1 },
                    { new Guid("d4381cc4-ad66-4128-87db-30fc1907aac8"), null, new DateTime(2024, 10, 24, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3579), null, null, null, null, null, new Guid("d399ebe8-f204-4d9f-85dd-2197f6282663"), new Guid("6ff045e2-0044-42e5-93e5-94a4df35a292"), new DateTime(2024, 10, 26, 16, 27, 1, 21, DateTimeKind.Local).AddTicks(3572), new Guid("89613507-30c2-4c56-9f5d-3cfcb8061987"), 1 }
                });
        }
    }
}
