using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialNeon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1184100b-7935-479b-8cfd-4156f335050c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c8e92aca-f876-4fdf-816c-d8a7c4b2077e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e3593038-ae8c-4006-8146-d7f197a0c30d"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(1551), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(1592), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(1590), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "ConfirmCode", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "SeenTime", "Status" },
                values: new object[,]
                {
                    { new Guid("06316899-18ac-4d87-9418-80061f99f26f"), "Ba Vi", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(2153), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", "Nam", "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 },
                    { new Guid("1612135c-78cc-4eee-a27f-70eaf25b0596"), "Quảng Ninh", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(2320), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1998, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "dangduccuong@gmail.com", "Đặng Đức Cường", "Nam", "dangduccuong.jpg", null, null, "p2nLU1k2wcxFcCfKDcbOqA==", "0334999999", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, 1 },
                    { new Guid("1d283930-fd80-45d8-be71-c8e6d9202f86"), "Đà Nẵng", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(2272), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1993, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lequanghao@gmail.com", "Le Quang Hào", "Nam", "lequanghao.jpg", null, null, "U7sIXJ9LjRA17ukcZVphvA==", "0334777777", new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, 1 },
                    { new Guid("25d1e5f7-5125-4f9c-90fa-1d7889fb9767"), "Hà Nội", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(2204), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1995, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "dangxuanphong@gmail.com", "Đặng Xuân Phong", "Nam", "dangxuanphong.jpg", null, null, "rOyYvIqs6TuDXEGtKhoWiQ==", "0334666666", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 },
                    { new Guid("7e8ec026-aabb-410a-9a49-eeea6cb9ff70"), "Ba Vi", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(1739), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 },
                    { new Guid("aa27af43-84da-46b9-9463-a2c6453889b0"), "Hồ Chí Minh", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(2298), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nguyenvantrong@gmail.com", "Nguyễn Văn Trọng", "Nam", "nguyenvantrong.jpg", null, null, "3YoIHNiO5Cetmhcozn5ztg==", "0334888888", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, 1 },
                    { new Guid("bbee9411-b706-4841-a668-82beb3232537"), "Ba Vi", null, null, new DateTimeOffset(new DateTime(2024, 9, 18, 15, 5, 13, 74, DateTimeKind.Unspecified).AddTicks(2181), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", "Nam", "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("06316899-18ac-4d87-9418-80061f99f26f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1612135c-78cc-4eee-a27f-70eaf25b0596"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1d283930-fd80-45d8-be71-c8e6d9202f86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("25d1e5f7-5125-4f9c-90fa-1d7889fb9767"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e8ec026-aabb-410a-9a49-eeea6cb9ff70"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aa27af43-84da-46b9-9463-a2c6453889b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("bbee9411-b706-4841-a668-82beb3232537"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 9, 16, 22, 30, 3, 657, DateTimeKind.Unspecified).AddTicks(4783), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 9, 16, 22, 30, 3, 657, DateTimeKind.Unspecified).AddTicks(4856), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 9, 16, 22, 30, 3, 657, DateTimeKind.Unspecified).AddTicks(4847), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "ConfirmCode", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "SeenTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1184100b-7935-479b-8cfd-4156f335050c"), "Ba Vi", null, null, new DateTimeOffset(new DateTime(2024, 9, 16, 22, 30, 3, 657, DateTimeKind.Unspecified).AddTicks(5993), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", "Nam", "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 },
                    { new Guid("c8e92aca-f876-4fdf-816c-d8a7c4b2077e"), "Ba Vi", null, null, new DateTimeOffset(new DateTime(2024, 9, 16, 22, 30, 3, 657, DateTimeKind.Unspecified).AddTicks(5086), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 },
                    { new Guid("e3593038-ae8c-4006-8146-d7f197a0c30d"), "Ba Vi", null, null, new DateTimeOffset(new DateTime(2024, 9, 16, 22, 30, 3, 657, DateTimeKind.Unspecified).AddTicks(5799), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", "Nam", "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1 }
                });
        }
    }
}
