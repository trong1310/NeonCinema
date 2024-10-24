using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDbsss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("7a36656d-994a-4c14-ab9a-51fb7bd640a3"), "10:00 PM", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1983), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("c5418e66-9307-4cdc-b892-df676c137b7f"), "11:00 PM", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1989), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("61ff603e-8a54-45ff-a4f0-129dd642e5f4"), "Trung Quốc" },
                    { new Guid("6f8b422d-0484-4a28-9959-c03221b4f02b"), "Việt Nam" },
                    { new Guid("71992100-b09c-4e28-b0b5-96f92a04ca46"), "Vương Quốc Anh" },
                    { new Guid("edc76c4b-53d1-46a2-afaa-90ad97104898"), "Nhật Bản" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0894773e-7f6b-4c93-a762-24eb0ac15cfd"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("2de0a83c-7882-4542-9aa6-c71af4dfe30a"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("6c5fbe6d-1d5c-4841-be52-cdb6adc6fafd"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("83c01261-6b11-4031-b5c5-a9d2f577d1ba"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1cb30688-3e73-4af0-b727-b306ed8bb53f"), null, null, null, null, null, "2D", null, null },
                    { new Guid("35b4c74b-c348-44a0-a706-d6d89e253364"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("9d64c6bd-8075-4631-b014-dfdbfe00ed39"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("ef669d88-d08a-4923-91be-1b29546ce781"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("5d39af8f-48f5-4e85-8ad9-beb3ab3fb971"), null, null, null, null, null, "vi", null, null },
                    { new Guid("9aad3a21-6f28-451b-95cf-e54573818fa0"), null, null, null, null, null, "ja", null, null },
                    { new Guid("d9d1c2d0-6d28-4c13-91df-152a4c373081"), null, null, null, null, null, "en", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("5987ddbe-3a27-4e3a-a9f8-16e0a6435336"), null, null, null, null, null, null, null, "Ghế Đôi" },
                    { new Guid("6cd43abb-926e-4b1c-a60d-76d61d6b1921"), null, null, null, null, null, null, null, "Ghế Thường" },
                    { new Guid("7f2df53c-3ab7-4cd4-bd63-186397ebbf0f"), null, null, null, null, null, null, null, "Ghế Vip" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("7b2cc6ea-fe34-47d1-9410-87ba7b51ddb1"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 },
                    { new Guid("883bccdc-21fa-4110-8bd6-8fe884c1f8f6"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("1bb7c5d9-9e0c-4daa-805e-00409e5a38bc"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1624), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("429ec940-36ee-4fac-bf5b-f39395b7900f"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1525), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("4eaff1a9-1227-4a0b-86de-4faff3399a95"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1565), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a5dc9b8b-7805-482e-8212-69c552e834ba"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1596), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a9934646-ebb7-4a51-be88-c5ebb29b0928"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1724), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b45a5614-c6f5-4c62-9533-0f77fad31032"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1163), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("d8114abc-3c73-4c64-adf0-88f4fac0cab7"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1650), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d81cc172-8507-4f93-b520-221927f02788"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1703), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fecfa95c-64a0-47ba-aee7-9cd0252254e2"), "Ba Vi", null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(1680), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "ActorID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("6f5587cc-4bd6-465b-a3c0-98e58e449380"), new Guid("127d38f8-f339-40a6-9626-0dbd122d7f5f"), 16, new Guid("71992100-b09c-4e28-b0b5-96f92a04ca46"), null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2181), null, null, null, "A thrilling mystery.", new Guid("0894773e-7f6b-4c93-a762-24eb0ac15cfd"), 150, new Guid("35b4c74b-c348-44a0-a706-d6d89e253364"), "movieB.jpg", new Guid("5d39af8f-48f5-4e85-8ad9-beb3ab3fb971"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" },
                    { new Guid("b70a7b54-5e80-45ff-8d07-b0a4570fa21e"), new Guid("127d38f8-f339-40a6-9626-0dbd122d7f5f"), 18, new Guid("edc76c4b-53d1-46a2-afaa-90ad97104898"), null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2172), null, null, null, "An exciting action movie.", new Guid("6c5fbe6d-1d5c-4841-be52-cdb6adc6fafd"), 120, new Guid("9d64c6bd-8075-4631-b014-dfdbfe00ed39"), "movieA.jpg", new Guid("d9d1c2d0-6d28-4c13-91df-152a4c373081"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("98e080ca-6f59-4177-8bcc-b60716c9406f"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("7f2df53c-3ab7-4cd4-bd63-186397ebbf0f"), 1 },
                    { new Guid("bd10e077-6c0f-4425-8911-3b1a02a493b2"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("6cd43abb-926e-4b1c-a60d-76d61d6b1921"), 1 },
                    { new Guid("ff5e294a-6db5-4ea9-bf43-7903d94f4abb"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("5987ddbe-3a27-4e3a-a9f8-16e0a6435336"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("2db5bac5-51aa-4d13-ba24-0fd01f3a05df"), new Guid("7a36656d-994a-4c14-ab9a-51fb7bd640a3"), null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2092), null, null, null, null, null, "Room 1", new Guid("98e080ca-6f59-4177-8bcc-b60716c9406f"), 100, 1 },
                    { new Guid("9d1b5548-b83b-42e2-bebd-a16b563069ea"), new Guid("c5418e66-9307-4cdc-b892-df676c137b7f"), null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2098), null, null, null, null, null, "Room 2", new Guid("98e080ca-6f59-4177-8bcc-b60716c9406f"), 150, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("90267d58-54eb-4f79-8b50-f6536c373a35"), null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2212), null, null, null, null, null, new Guid("b70a7b54-5e80-45ff-8d07-b0a4570fa21e"), new Guid("2db5bac5-51aa-4d13-ba24-0fd01f3a05df"), new DateTime(2024, 10, 26, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2205), new Guid("7b2cc6ea-fe34-47d1-9410-87ba7b51ddb1"), 1 },
                    { new Guid("fec62596-4a48-4e93-b349-3839f65ff199"), null, new DateTime(2024, 10, 24, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2216), null, null, null, null, null, new Guid("6f5587cc-4bd6-465b-a3c0-98e58e449380"), new Guid("9d1b5548-b83b-42e2-bebd-a16b563069ea"), new DateTime(2024, 10, 29, 16, 32, 42, 939, DateTimeKind.Local).AddTicks(2215), new Guid("883bccdc-21fa-4110-8bd6-8fe884c1f8f6"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("61ff603e-8a54-45ff-a4f0-129dd642e5f4"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("6f8b422d-0484-4a28-9959-c03221b4f02b"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("2de0a83c-7882-4542-9aa6-c71af4dfe30a"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("83c01261-6b11-4031-b5c5-a9d2f577d1ba"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("1cb30688-3e73-4af0-b727-b306ed8bb53f"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("ef669d88-d08a-4923-91be-1b29546ce781"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("9aad3a21-6f28-451b-95cf-e54573818fa0"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("90267d58-54eb-4f79-8b50-f6536c373a35"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("fec62596-4a48-4e93-b349-3839f65ff199"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bd10e077-6c0f-4425-8911-3b1a02a493b2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ff5e294a-6db5-4ea9-bf43-7903d94f4abb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1bb7c5d9-9e0c-4daa-805e-00409e5a38bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("429ec940-36ee-4fac-bf5b-f39395b7900f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4eaff1a9-1227-4a0b-86de-4faff3399a95"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a5dc9b8b-7805-482e-8212-69c552e834ba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a9934646-ebb7-4a51-be88-c5ebb29b0928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b45a5614-c6f5-4c62-9533-0f77fad31032"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d8114abc-3c73-4c64-adf0-88f4fac0cab7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d81cc172-8507-4f93-b520-221927f02788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fecfa95c-64a0-47ba-aee7-9cd0252254e2"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("6f5587cc-4bd6-465b-a3c0-98e58e449380"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("b70a7b54-5e80-45ff-8d07-b0a4570fa21e"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("2db5bac5-51aa-4d13-ba24-0fd01f3a05df"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("9d1b5548-b83b-42e2-bebd-a16b563069ea"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("5987ddbe-3a27-4e3a-a9f8-16e0a6435336"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("6cd43abb-926e-4b1c-a60d-76d61d6b1921"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("7b2cc6ea-fe34-47d1-9410-87ba7b51ddb1"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("883bccdc-21fa-4110-8bd6-8fe884c1f8f6"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("7a36656d-994a-4c14-ab9a-51fb7bd640a3"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("c5418e66-9307-4cdc-b892-df676c137b7f"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("71992100-b09c-4e28-b0b5-96f92a04ca46"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("edc76c4b-53d1-46a2-afaa-90ad97104898"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("0894773e-7f6b-4c93-a762-24eb0ac15cfd"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("6c5fbe6d-1d5c-4841-be52-cdb6adc6fafd"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("35b4c74b-c348-44a0-a706-d6d89e253364"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("9d64c6bd-8075-4631-b014-dfdbfe00ed39"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("5d39af8f-48f5-4e85-8ad9-beb3ab3fb971"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("d9d1c2d0-6d28-4c13-91df-152a4c373081"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("98e080ca-6f59-4177-8bcc-b60716c9406f"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("7f2df53c-3ab7-4cd4-bd63-186397ebbf0f"));

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
    }
}
