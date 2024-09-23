using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitDba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1c2fb24f-c5a6-4fb5-8b2e-23487d204ad3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4d42b98f-29ad-4e24-a85b-442a55fdee02"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5c127f61-2c5f-4c25-a3a0-98a86e8a0a4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8ba3de96-9d6c-432e-a56d-13415e2eab85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("90f60b71-8683-46df-976f-6e35fac38c85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c143a1cc-c8d4-4bae-bb25-5348b16e1e38"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(4467));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(4486));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(4484));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("2c522db4-27ce-4151-9701-9e5eee752f8c"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(4999), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "client@gmail.com", "Client", "Nam", "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("625caf9d-fb8e-4988-96d3-cdef6ff379de"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(5088), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7e319fe5-0d16-480c-bae6-2b621a6882be"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(5029), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ba294c84-b2c2-4547-96b2-4992f76dcfeb"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(5061), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c626c1a7-2ea7-41a9-9ba5-c52af19fa545"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(4969), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin@gmail.com", "Admin", "Nam", "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("cba9c85c-1051-4c04-8a4e-40bc149d99c9"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 2, 50, 581, DateTimeKind.Local).AddTicks(4579), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("2c522db4-27ce-4151-9701-9e5eee752f8c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("625caf9d-fb8e-4988-96d3-cdef6ff379de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e319fe5-0d16-480c-bae6-2b621a6882be"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ba294c84-b2c2-4547-96b2-4992f76dcfeb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c626c1a7-2ea7-41a9-9ba5-c52af19fa545"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cba9c85c-1051-4c04-8a4e-40bc149d99c9"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2204));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2227));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("1c2fb24f-c5a6-4fb5-8b2e-23487d204ad3"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2711), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "client@gmail.com", "Client", "Nam", "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4d42b98f-29ad-4e24-a85b-442a55fdee02"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2750), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5c127f61-2c5f-4c25-a3a0-98a86e8a0a4a"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2686), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin@gmail.com", "Admin", "Nam", "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("8ba3de96-9d6c-432e-a56d-13415e2eab85"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2317), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("90f60b71-8683-46df-976f-6e35fac38c85"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2769), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c143a1cc-c8d4-4bae-bb25-5348b16e1e38"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 1, 49, 800, DateTimeKind.Local).AddTicks(2730), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });
        }
    }
}
