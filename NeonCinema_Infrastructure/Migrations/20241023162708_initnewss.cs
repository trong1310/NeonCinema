using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initnewss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("0023ef76-6613-4ef0-8de7-dfa2877bf5c3"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("1754c1cd-0eb5-43db-93de-23403e814e57"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("04300f96-84e1-4316-8d0f-2a489341068f"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("5e575b31-2f44-4ad6-b1df-2d1a5972cb1e"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("874e4577-412c-4c3d-ac4f-2e15cac465ad"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("ba5455eb-fe4a-4b08-8a81-b80125269e7f"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("65e47379-44d9-47a7-8a4d-d56551a6e7b6"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("7d3f0333-8b87-4459-a76e-ce3c7b96639e"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("7e8a3410-cb70-46b5-8c2e-08ffd3d02f36"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("24305498-79c8-432e-a5aa-278046acb971"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4852a5d8-0f2a-4f1a-ae2b-8dcb04793414"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1b8400a5-9602-4025-a2bb-a84d79ef98c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("62f868ba-38b9-458e-8aa7-1302d4fe4ced"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("632f908a-0ef5-4590-b9ab-66d1626e3308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8089722c-3fc3-4d74-975a-86ddeb74a83e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("941b7ee2-4a3b-433c-aaf3-55741d3cb69f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9be0d956-8cfa-4580-ad4f-0cd00028f6d8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf4dcbbc-3ed9-4942-b702-284e17f8c09a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ca0e2c1a-8583-4fc2-a59e-b4a0a40c0981"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e4c0dbda-5d59-4b86-a869-469aa62e831c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("71d5e3cd-eec8-46ee-b91a-c390b7bfad5c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("dc54054e-f86a-4aca-a3e5-902748a4f7d6"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("55a8a41d-70df-4223-94e2-fe7f9c1123ea"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("f11858a8-c9b4-4610-bec2-270fc11d9ddd"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("0aac95eb-b40a-418d-b669-b3d40659de19"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("dff8356c-4ef6-48f2-8915-f6e2b8a994f0"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("714755a1-be4e-472e-8b47-56c29e3b7936"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("9907377e-775c-4c57-91da-6bca3bd48569"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("30b4a0b1-f898-49c8-91e8-f9d23f7a5e66"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("6e34120f-7bfe-42af-a5af-ec02adf309b9"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("23cb162f-df23-4f4c-a24b-482ec5961421"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("7e509f35-c4d4-45b5-9305-4157969897dd"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("4ad0a35f-16f1-45d2-ad0a-3ce4435472e8"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("7207e24d-6d58-4598-ae47-6b75d57afac7"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("06848a57-8738-4d38-b637-5d91e2a19f6b"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("4a49dea9-ae94-48f7-8886-f670dd6118ce"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("7582b15b-35f3-485b-a803-3431db94e24f"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("f4759d29-d9d3-44be-b822-869c9bbf59ff"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5e57233c-5f28-430e-92d9-fb8aa057afb4"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("d555f10a-0e6f-49e8-9feb-8c369567b4ef"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("6077f7df-3c6f-4904-950a-053daa307856"), "10:00 PM", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8449), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" },
                    { new Guid("78243cc1-835b-4f34-b12d-bfa83688edf9"), "11:00 PM", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8454), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("20a7015e-0db4-45d6-9274-49722ff8b6ed"), "Trung Quốc" },
                    { new Guid("25ac65c9-609d-42f4-9ee8-d046dcae072d"), "Việt Nam" },
                    { new Guid("5a856a02-19b2-4160-ae90-e7248a56f61d"), "Nhật Bản" },
                    { new Guid("f222972d-fc10-4298-96c3-e6b50cbe3c4c"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0fa39925-db4e-4d95-b583-7b9cab876a44"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("3fb0113c-d7b5-4618-8266-230f1d04d026"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("746573d9-459c-44e3-a331-44e5bdb86d66"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("940336c5-c118-4339-b033-5a21d54439b7"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("100ecf48-53b7-4ced-8176-38e49b9f3078"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("6937c0af-f951-4ab6-a19c-48ed83570b70"), null, null, null, null, null, "2D", null, null },
                    { new Guid("7c52f0f4-0b39-40ed-960b-0f6a7f12e786"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("b272734b-bb4e-42c0-b57f-4c48aeba76f2"), null, null, null, null, null, "Kịch tính", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("153bf43b-8bf5-431d-b77d-0c2936fbfd83"), null, null, null, null, null, "ja", null, null },
                    { new Guid("273e2d05-9c67-44f2-b3ec-64b0b1aa4953"), null, null, null, null, null, "vi", null, null },
                    { new Guid("71713956-0db6-42d1-b5e7-e25df649acdd"), null, null, null, null, null, "en", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7295));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("262e1173-a7a3-481c-84c0-cddeac726752"), null, null, null, null, null, null, null, 400000m, "Ghế Đôi" },
                    { new Guid("cda00f3f-8fee-45e0-a5ff-0d5e21dedf79"), null, null, null, null, null, null, null, 500000m, "Ghế Vip" },
                    { new Guid("e6e3d186-39bf-4c47-9792-72d811f30282"), null, null, null, null, null, null, null, 250000m, "Ghế Thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("2a8e7e39-b2a6-465d-b501-0bfb72cdbc27"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 },
                    { new Guid("efd476a2-d643-4097-b0bb-58966116653b"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("348eb032-b960-4d7c-989e-8ad748f3963b"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7958), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3d9ed4e5-10f5-4cb5-b3c9-ab8dd7fa6b7c"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8055), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8c6921e3-948d-476d-9661-0fc7d20cd0a6"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7468), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("9d8fc51e-ee35-40b9-963e-d7f231d06ff6"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8024), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("a7656347-f9be-4549-9420-1e6a2ac57932"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8146), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bd7d8299-af0b-400b-849e-4fad0e011110"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8082), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bf96ba4d-0731-43c5-9f52-df87b72eef1f"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7998), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c76d3483-562c-4eb2-a323-d0545b9be911"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(7925), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("edc4aef0-bf81-42b9-9576-716a8419a35c"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8123), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("b8f5a6cf-5d7e-4786-9af8-0a1e0accb3d8"), 16, new Guid("f222972d-fc10-4298-96c3-e6b50cbe3c4c"), null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8884), null, null, null, "A thrilling mystery.", new Guid("3fb0113c-d7b5-4618-8266-230f1d04d026"), 150, new Guid("100ecf48-53b7-4ced-8176-38e49b9f3078"), "movieB.jpg", new Guid("273e2d05-9c67-44f2-b3ec-64b0b1aa4953"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" },
                    { new Guid("c0472444-12fe-4cb9-991c-d7d1c871d856"), 18, new Guid("5a856a02-19b2-4160-ae90-e7248a56f61d"), null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8865), null, null, null, "An exciting action movie.", new Guid("0fa39925-db4e-4d95-b583-7b9cab876a44"), 120, new Guid("b272734b-bb4e-42c0-b57f-4c48aeba76f2"), "movieA.jpg", new Guid("71713956-0db6-42d1-b5e7-e25df649acdd"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("1ada5402-9b91-409b-b6b8-483986bf8494"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("cda00f3f-8fee-45e0-a5ff-0d5e21dedf79"), 1 },
                    { new Guid("251b56ad-947c-4537-ae74-5c10cf8f90cb"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("e6e3d186-39bf-4c47-9792-72d811f30282"), 1 },
                    { new Guid("89b9db84-505d-43b4-84a4-fb514e897c28"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("262e1173-a7a3-481c-84c0-cddeac726752"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("07ef48ce-ea3f-44e4-964f-d0eb83aeb662"), new Guid("78243cc1-835b-4f34-b12d-bfa83688edf9"), null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8730), null, null, null, null, null, "Room 2", new Guid("1ada5402-9b91-409b-b6b8-483986bf8494"), 150, 1 },
                    { new Guid("5fb0c2f7-10e6-4cc0-b5fc-e0869e9a77e7"), new Guid("6077f7df-3c6f-4904-950a-053daa307856"), null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8724), null, null, null, null, null, "Room 1", new Guid("1ada5402-9b91-409b-b6b8-483986bf8494"), 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("1dc29f67-b9f7-4629-9c9d-6abcc1a8456b"), null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8954), null, null, null, null, null, new Guid("c0472444-12fe-4cb9-991c-d7d1c871d856"), new Guid("5fb0c2f7-10e6-4cc0-b5fc-e0869e9a77e7"), new DateTime(2024, 10, 25, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8939), new Guid("efd476a2-d643-4097-b0bb-58966116653b"), 1 },
                    { new Guid("9137088b-0e0b-4b31-8a93-d19ebad2f3aa"), null, new DateTime(2024, 10, 23, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8965), null, null, null, null, null, new Guid("b8f5a6cf-5d7e-4786-9af8-0a1e0accb3d8"), new Guid("07ef48ce-ea3f-44e4-964f-d0eb83aeb662"), new DateTime(2024, 10, 28, 23, 27, 7, 711, DateTimeKind.Local).AddTicks(8963), new Guid("2a8e7e39-b2a6-465d-b501-0bfb72cdbc27"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("20a7015e-0db4-45d6-9274-49722ff8b6ed"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("25ac65c9-609d-42f4-9ee8-d046dcae072d"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("746573d9-459c-44e3-a331-44e5bdb86d66"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("940336c5-c118-4339-b033-5a21d54439b7"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("6937c0af-f951-4ab6-a19c-48ed83570b70"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("7c52f0f4-0b39-40ed-960b-0f6a7f12e786"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("153bf43b-8bf5-431d-b77d-0c2936fbfd83"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("1dc29f67-b9f7-4629-9c9d-6abcc1a8456b"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("9137088b-0e0b-4b31-8a93-d19ebad2f3aa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("251b56ad-947c-4537-ae74-5c10cf8f90cb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("89b9db84-505d-43b4-84a4-fb514e897c28"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("348eb032-b960-4d7c-989e-8ad748f3963b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3d9ed4e5-10f5-4cb5-b3c9-ab8dd7fa6b7c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8c6921e3-948d-476d-9661-0fc7d20cd0a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9d8fc51e-ee35-40b9-963e-d7f231d06ff6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("a7656347-f9be-4549-9420-1e6a2ac57932"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bd7d8299-af0b-400b-849e-4fad0e011110"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bf96ba4d-0731-43c5-9f52-df87b72eef1f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c76d3483-562c-4eb2-a323-d0545b9be911"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("edc4aef0-bf81-42b9-9576-716a8419a35c"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("b8f5a6cf-5d7e-4786-9af8-0a1e0accb3d8"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("c0472444-12fe-4cb9-991c-d7d1c871d856"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("07ef48ce-ea3f-44e4-964f-d0eb83aeb662"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("5fb0c2f7-10e6-4cc0-b5fc-e0869e9a77e7"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("262e1173-a7a3-481c-84c0-cddeac726752"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("e6e3d186-39bf-4c47-9792-72d811f30282"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("2a8e7e39-b2a6-465d-b501-0bfb72cdbc27"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("efd476a2-d643-4097-b0bb-58966116653b"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("6077f7df-3c6f-4904-950a-053daa307856"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("78243cc1-835b-4f34-b12d-bfa83688edf9"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("5a856a02-19b2-4160-ae90-e7248a56f61d"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("f222972d-fc10-4298-96c3-e6b50cbe3c4c"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("0fa39925-db4e-4d95-b583-7b9cab876a44"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("3fb0113c-d7b5-4618-8266-230f1d04d026"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("100ecf48-53b7-4ced-8176-38e49b9f3078"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("b272734b-bb4e-42c0-b57f-4c48aeba76f2"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("273e2d05-9c67-44f2-b3ec-64b0b1aa4953"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("71713956-0db6-42d1-b5e7-e25df649acdd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1ada5402-9b91-409b-b6b8-483986bf8494"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("cda00f3f-8fee-45e0-a5ff-0d5e21dedf79"));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[,]
                {
                    { new Guid("30b4a0b1-f898-49c8-91e8-f9d23f7a5e66"), "11:00 PM", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2917), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" },
                    { new Guid("6e34120f-7bfe-42af-a5af-ec02adf309b9"), "10:00 PM", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2913), null, null, null, "Hà Nội", null, null, "Cinema A", "08:00 AM", "0123456789", 5, "www.cinemaa.com" }
                });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0023ef76-6613-4ef0-8de7-dfa2877bf5c3"), "Việt Nam" },
                    { new Guid("1754c1cd-0eb5-43db-93de-23403e814e57"), "Trung Quốc" },
                    { new Guid("23cb162f-df23-4f4c-a24b-482ec5961421"), "Vương Quốc Anh" },
                    { new Guid("7e509f35-c4d4-45b5-9305-4157969897dd"), "Nhật Bản" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("04300f96-84e1-4316-8d0f-2a489341068f"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("4ad0a35f-16f1-45d2-ad0a-3ce4435472e8"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("5e575b31-2f44-4ad6-b1df-2d1a5972cb1e"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("7207e24d-6d58-4598-ae47-6b75d57afac7"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("06848a57-8738-4d38-b637-5d91e2a19f6b"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("4a49dea9-ae94-48f7-8886-f670dd6118ce"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("874e4577-412c-4c3d-ac4f-2e15cac465ad"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("ba5455eb-fe4a-4b08-8a81-b80125269e7f"), null, null, null, null, null, "2D", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("65e47379-44d9-47a7-8a4d-d56551a6e7b6"), null, null, null, null, null, "ja", null, null },
                    { new Guid("7582b15b-35f3-485b-a803-3431db94e24f"), null, null, null, null, null, "vi", null, null },
                    { new Guid("f4759d29-d9d3-44be-b822-869c9bbf59ff"), null, null, null, null, null, "en", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("0aac95eb-b40a-418d-b669-b3d40659de19"), null, null, null, null, null, null, null, 400000m, "Ghế Đôi" },
                    { new Guid("d555f10a-0e6f-49e8-9feb-8c369567b4ef"), null, null, null, null, null, null, null, 500000m, "Ghế Vip" },
                    { new Guid("dff8356c-4ef6-48f2-8915-f6e2b8a994f0"), null, null, null, null, null, null, null, 250000m, "Ghế Thường" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("714755a1-be4e-472e-8b47-56c29e3b7936"), new TimeSpan(0, 20, 30, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1 },
                    { new Guid("9907377e-775c-4c57-91da-6bca3bd48569"), new TimeSpan(0, 16, 30, 0, 0), new TimeSpan(0, 14, 0, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("1b8400a5-9602-4025-a2bb-a84d79ef98c8"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2490), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("62f868ba-38b9-458e-8aa7-1302d4fe4ced"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2564), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("632f908a-0ef5-4590-b9ab-66d1626e3308"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2588), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8089722c-3fc3-4d74-975a-86ddeb74a83e"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2514), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("941b7ee2-4a3b-433c-aaf3-55741d3cb69f"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2668), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9be0d956-8cfa-4580-ad4f-0cd00028f6d8"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2641), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("bf4dcbbc-3ed9-4942-b702-284e17f8c09a"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2620), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ca0e2c1a-8583-4fc2-a59e-b4a0a40c0981"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2087), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("e4c0dbda-5d59-4b86-a869-469aa62e831c"), "Ba Vi", null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(2461), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("71d5e3cd-eec8-46ee-b91a-c390b7bfad5c"), 16, new Guid("23cb162f-df23-4f4c-a24b-482ec5961421"), null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3177), null, null, null, "A thrilling mystery.", new Guid("4ad0a35f-16f1-45d2-ad0a-3ce4435472e8"), 150, new Guid("4a49dea9-ae94-48f7-8886-f670dd6118ce"), "movieB.jpg", new Guid("7582b15b-35f3-485b-a803-3431db94e24f"), null, null, "Movie B", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerB.mp4" },
                    { new Guid("dc54054e-f86a-4aca-a3e5-902748a4f7d6"), 18, new Guid("7e509f35-c4d4-45b5-9305-4157969897dd"), null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3167), null, null, null, "An exciting action movie.", new Guid("7207e24d-6d58-4598-ae47-6b75d57afac7"), 120, new Guid("06848a57-8738-4d38-b637-5d91e2a19f6b"), "movieA.jpg", new Guid("f4759d29-d9d3-44be-b822-869c9bbf59ff"), null, null, "Movie A", new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "trailerA.mp4" }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("24305498-79c8-432e-a5aa-278046acb971"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("dff8356c-4ef6-48f2-8915-f6e2b8a994f0"), 1 },
                    { new Guid("4852a5d8-0f2a-4f1a-ae2b-8dcb04793414"), "2", null, null, null, null, null, null, null, "2", "2", new Guid("0aac95eb-b40a-418d-b669-b3d40659de19"), 1 },
                    { new Guid("5e57233c-5f28-430e-92d9-fb8aa057afb4"), "1", null, null, null, null, null, null, null, "1", "1", new Guid("d555f10a-0e6f-49e8-9feb-8c369567b4ef"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "SeatID", "SeatingCapacity", "Status" },
                values: new object[,]
                {
                    { new Guid("55a8a41d-70df-4223-94e2-fe7f9c1123ea"), new Guid("30b4a0b1-f898-49c8-91e8-f9d23f7a5e66"), null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3074), null, null, null, null, null, "Room 2", new Guid("5e57233c-5f28-430e-92d9-fb8aa057afb4"), 150, 1 },
                    { new Guid("f11858a8-c9b4-4610-bec2-270fc11d9ddd"), new Guid("6e34120f-7bfe-42af-a5af-ec02adf309b9"), null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3069), null, null, null, null, null, "Room 1", new Guid("5e57233c-5f28-430e-92d9-fb8aa057afb4"), 100, 1 }
                });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Status" },
                values: new object[,]
                {
                    { new Guid("7d3f0333-8b87-4459-a76e-ce3c7b96639e"), null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3224), null, null, null, null, null, new Guid("71d5e3cd-eec8-46ee-b91a-c390b7bfad5c"), new Guid("55a8a41d-70df-4223-94e2-fe7f9c1123ea"), new DateTime(2024, 10, 28, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3223), new Guid("714755a1-be4e-472e-8b47-56c29e3b7936"), 1 },
                    { new Guid("7e8a3410-cb70-46b5-8c2e-08ffd3d02f36"), null, new DateTime(2024, 10, 23, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3219), null, null, null, null, null, new Guid("dc54054e-f86a-4aca-a3e5-902748a4f7d6"), new Guid("f11858a8-c9b4-4610-bec2-270fc11d9ddd"), new DateTime(2024, 10, 25, 23, 25, 41, 174, DateTimeKind.Local).AddTicks(3209), new Guid("9907377e-775c-4c57-91da-6bca3bd48569"), 1 }
                });
        }
    }
}
