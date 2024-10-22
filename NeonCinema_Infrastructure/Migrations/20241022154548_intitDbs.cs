using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intitDbs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("37779021-6c8f-4cff-b545-6c059cdebdde"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("9fa51f01-1061-4f84-91ae-dfecf52ced63"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("dc5d8887-739a-4cd3-839a-a409ac639894"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("e18f4af8-1c54-4c18-a715-c498e44f9a45"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("03416427-99f1-4532-a9bd-dfe8afa09900"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("54760ba7-96eb-4bc2-9ea6-d927180987b4"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("595a8a92-a9ff-4a1a-8616-de4261ed0caf"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("77b5e4cf-2927-4864-8d21-36457c489800"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("35b17a37-69ed-4449-bfc5-c22788dfe9e9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("41c7b1c8-2995-42dd-9d04-2b0c43075b1f"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("5040ded8-efc4-44be-bd67-8fd6f1a40a00"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("dd96011a-69d0-49cd-a8cf-d4f26e155e73"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("72d2f050-867c-4800-a864-749e82694c42"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("a4871a01-41f5-45be-8d3d-46ec6289f432"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("e3491288-5bfa-4a03-9cdf-126538200751"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("145af103-288e-4930-8ee4-6dd0bbf00be1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("271d1750-9d3a-441a-9b5f-665f5582a289"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4963dba7-c79b-48cf-9f34-1553b16e21fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("520d7148-1cf1-4431-8ef9-52277a5c0c99"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6a141fa3-ef8d-41a4-bd45-b4ee4b3ff825"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74c272fa-0cde-4af4-80f9-474bdc9d3311"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7a2a5eea-de91-4655-a0e7-d71c7b6e1080"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7debba98-a0e8-46a4-a7ce-d388f3af16c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9a343d1f-e22f-4392-8dc7-91e3bb10f40c"));

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("1e7c9424-4e79-45a5-b27e-2dc256d5b9fb"), "Trung Quốc" },
                    { new Guid("57badfac-91b1-44f4-b5ac-968c9753feeb"), "Vương Quốc Anh" },
                    { new Guid("f22e6b69-fd58-48ba-8c1d-898d74f12eac"), "Việt Nam" },
                    { new Guid("f3271e25-eede-4a80-b9c5-b912d2908bab"), "Nhật Bản" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("1ef08494-bd13-42bf-8785-d8928ce36871"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("c847b63f-3849-48dc-9fc1-17bf29aa9b2f"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("d269f3ff-c876-44a1-b350-7a4abd972559"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("fc3ea008-94f1-4097-901a-5764ba3c32c7"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0f0dfeed-dfb6-4fb5-bde1-b46b1ceb2363"), null, null, null, null, null, "2D", null, null },
                    { new Guid("3421cbe2-b201-47fd-a7f1-2746c98c9841"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("68da1164-5ab8-4160-8a60-55f2bc69ef2a"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("d4f3d1e4-9106-4cfb-b717-9ffdd8f7ea8e"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("194cdf73-d5b7-411d-afe3-0bec6a362b2c"), null, null, null, null, null, "en", null, null },
                    { new Guid("3e3acc6d-69a1-42bc-ae90-c97af4473a25"), null, null, null, null, null, "ja", null, null },
                    { new Guid("ff3acb8b-420d-417c-9bfd-8d6193a174c2"), null, null, null, null, null, "vi", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0033ffa4-c917-4cfd-bc86-bd8728dc42fa"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2759), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("29f4fcd9-b6f0-467b-9e60-73dae0f9a987"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2684), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("51bf8775-2ad8-42f6-93da-e2fffff8bb5e"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2726), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5f9e09a6-1801-4fa3-8419-5a1692ffd88d"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2634), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("6f3a3887-db76-4b76-82de-d76bf9ef9064"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2889), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("82e31ca0-2f8d-420d-b84b-2206e7d0024f"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2831), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c17b83b6-d926-420e-a9f2-7cf67a3c0e4d"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2859), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("efc58df5-7336-4ccd-bbcc-1bcf83cd557d"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2307), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("fbf34fdd-b524-49c8-ab25-4879e6d591db"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 45, 47, 787, DateTimeKind.Local).AddTicks(2792), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("1e7c9424-4e79-45a5-b27e-2dc256d5b9fb"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("57badfac-91b1-44f4-b5ac-968c9753feeb"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("f22e6b69-fd58-48ba-8c1d-898d74f12eac"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("f3271e25-eede-4a80-b9c5-b912d2908bab"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("1ef08494-bd13-42bf-8785-d8928ce36871"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("c847b63f-3849-48dc-9fc1-17bf29aa9b2f"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("d269f3ff-c876-44a1-b350-7a4abd972559"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("fc3ea008-94f1-4097-901a-5764ba3c32c7"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("0f0dfeed-dfb6-4fb5-bde1-b46b1ceb2363"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("3421cbe2-b201-47fd-a7f1-2746c98c9841"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("68da1164-5ab8-4160-8a60-55f2bc69ef2a"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("d4f3d1e4-9106-4cfb-b717-9ffdd8f7ea8e"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("194cdf73-d5b7-411d-afe3-0bec6a362b2c"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("3e3acc6d-69a1-42bc-ae90-c97af4473a25"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("ff3acb8b-420d-417c-9bfd-8d6193a174c2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0033ffa4-c917-4cfd-bc86-bd8728dc42fa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("29f4fcd9-b6f0-467b-9e60-73dae0f9a987"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("51bf8775-2ad8-42f6-93da-e2fffff8bb5e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5f9e09a6-1801-4fa3-8419-5a1692ffd88d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("6f3a3887-db76-4b76-82de-d76bf9ef9064"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("82e31ca0-2f8d-420d-b84b-2206e7d0024f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c17b83b6-d926-420e-a9f2-7cf67a3c0e4d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("efc58df5-7336-4ccd-bbcc-1bcf83cd557d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fbf34fdd-b524-49c8-ab25-4879e6d591db"));

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("37779021-6c8f-4cff-b545-6c059cdebdde"), "Việt Nam" },
                    { new Guid("9fa51f01-1061-4f84-91ae-dfecf52ced63"), "Nhật Bản" },
                    { new Guid("dc5d8887-739a-4cd3-839a-a409ac639894"), "Vương Quốc Anh" },
                    { new Guid("e18f4af8-1c54-4c18-a715-c498e44f9a45"), "Trung Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("03416427-99f1-4532-a9bd-dfe8afa09900"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("54760ba7-96eb-4bc2-9ea6-d927180987b4"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 5 },
                    { new Guid("595a8a92-a9ff-4a1a-8616-de4261ed0caf"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("77b5e4cf-2927-4864-8d21-36457c489800"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("35b17a37-69ed-4449-bfc5-c22788dfe9e9"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("41c7b1c8-2995-42dd-9d04-2b0c43075b1f"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("5040ded8-efc4-44be-bd67-8fd6f1a40a00"), null, null, null, null, null, "2D", null, null },
                    { new Guid("dd96011a-69d0-49cd-a8cf-d4f26e155e73"), null, null, null, null, null, "Hoạt hình", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("72d2f050-867c-4800-a864-749e82694c42"), null, null, null, null, null, "en", null, null },
                    { new Guid("a4871a01-41f5-45be-8d3d-46ec6289f432"), null, null, null, null, null, "vi", null, null },
                    { new Guid("e3491288-5bfa-4a03-9cdf-126538200751"), null, null, null, null, null, "ja", null, null }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("145af103-288e-4930-8ee4-6dd0bbf00be1"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8428), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("271d1750-9d3a-441a-9b5f-665f5582a289"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8633), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4963dba7-c79b-48cf-9f34-1553b16e21fa"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(7923), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("520d7148-1cf1-4431-8ef9-52277a5c0c99"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8670), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6a141fa3-ef8d-41a4-bd45-b4ee4b3ff825"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8378), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("74c272fa-0cde-4af4-80f9-474bdc9d3311"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8710), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7a2a5eea-de91-4655-a0e7-d71c7b6e1080"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8587), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7debba98-a0e8-46a4-a7ce-d388f3af16c2"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8758), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9a343d1f-e22f-4392-8dc7-91e3bb10f40c"), "Ba Vi", null, new DateTime(2024, 10, 22, 22, 44, 21, 148, DateTimeKind.Local).AddTicks(8478), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });
        }
    }
}
