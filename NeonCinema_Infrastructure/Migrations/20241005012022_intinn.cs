using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class intinn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("06923812-5cfb-46f7-afb2-466c11adbf37"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("0940c663-4838-4253-8901-23edd91d7659"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("dec2a64c-b505-400b-8617-55134225449f"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("fc8aa2b3-17f4-4d8e-be42-d862dd80b65e"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("1dd325f4-8604-4e37-9e73-6d6880b42a9e"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("45ff9fc3-3788-4eb1-8f9b-2abcbdcf9142"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("78baab91-02ae-45d9-8ed4-2ab9fe37f273"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("f04dfa90-ab3d-4a21-840c-5d8cc24927a0"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("430e3043-e6e9-40e6-b659-852ce0cc8c82"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("4eea0a29-ba57-45fb-8da1-a0103bee4a91"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("664651a1-98be-4762-91f5-542bfdc6677f"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("6b8bf3df-b8ad-419a-beed-4f5d9b7059ca"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("4129629c-567f-469f-a716-b704a86ea9d3"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("bd704b4b-237d-4050-93d6-3b8941fed447"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("e722d2a4-2da1-4a28-809d-752bc0e5d608"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "ID",
                keyValue: new Guid("2e7ac9cc-535b-4f95-bec1-de099c2f67a5"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "ID",
                keyValue: new Guid("c7db960f-e3dd-453c-a5a1-eab45d4a2fc9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c44233b-81e9-4086-8581-ae51a5a1ff1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("446d07e7-1e1e-4aee-800f-e90ce793407f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4abfb82d-0548-4d52-a7fe-f048f55017a8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("50438606-14e8-41ba-b8bd-632e6f052469"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5d139585-8ee3-43ec-ac73-06b524907041"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("72cff11a-caee-4043-aa28-ea889d2367d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8660461e-1efa-4ec1-8bde-0fd50a37bb85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("aaa8aa03-82b5-46ea-a6a5-231ef6740654"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e538e1f0-083f-4af8-9607-d91b263c7155"));

            migrationBuilder.DeleteData(
                table: "promotionTypes",
                keyColumn: "ID",
                keyValue: new Guid("2112db85-c2ca-4656-97e6-1dafbf816712"));

            migrationBuilder.DeleteData(
                table: "PromotionCodes",
                keyColumn: "ID",
                keyValue: new Guid("9c21f5ff-28e6-4195-a559-017504efd0e4"));

            migrationBuilder.DeleteData(
                table: "PromotionCodes",
                keyColumn: "ID",
                keyValue: new Guid("aff6e5ac-4239-45e2-b4c7-a3d2d6dd640d"));

            migrationBuilder.DeleteData(
                table: "promotionTypes",
                keyColumn: "ID",
                keyValue: new Guid("8a9616f2-f2f8-4071-9543-e3d07c8cd9f4"));

            migrationBuilder.DeleteData(
                table: "promotionTypes",
                keyColumn: "ID",
                keyValue: new Guid("e8b22302-9f5a-4fad-bfda-e500729427df"));

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("b82c52ff-a22e-40f8-a38c-64bff93bc992"), "Vương Quốc Anh" },
                    { new Guid("ccdb068d-4e88-48f7-a180-8c997cb2175a"), "Nhật Bản" },
                    { new Guid("d86b6f8d-772e-48b1-a3f9-2d164d13797b"), "Việt Nam" },
                    { new Guid("e7126555-da58-4668-b8c4-bd90d443f134"), "Trung Quốc" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("53cc7f6f-c996-4cc4-809d-33359992a918"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("651d3b1e-3fa2-4fd4-a212-1d0f77ae013e"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("ca2e3e94-0e25-4589-92e6-adc635e3679f"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 4 },
                    { new Guid("da3304f6-3775-4bcd-af7e-7367b57c4b4b"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 4 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("bfc1c695-2bff-4cf4-a7e1-08505d8dc9c7"), null, null, null, null, null, "2D", null, null },
                    { new Guid("c4b5a0dd-1cd8-4a80-9547-5acff9322e92"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("d3dc09bf-b23d-4e70-a400-90f913d0a58c"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("d70f2300-381c-425a-8162-a3cf34d228bf"), null, null, null, null, null, "Tình cảm", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("46f5ae75-a196-49fd-9719-3abbb56b8725"), null, null, null, null, null, "en", null, null },
                    { new Guid("68c0ab5b-9f8d-4b1c-ae17-2b4c92558c76"), null, null, null, null, null, "vi", null, null },
                    { new Guid("fe707ac9-7e27-46be-981f-e1be1c611aa1"), null, null, null, null, null, "ja", null, null }
                });

            migrationBuilder.InsertData(
                table: "PromotionCodes",
                columns: new[] { "ID", "Code", "EndDate", "MaxUsage", "StartDate" },
                values: new object[,]
                {
                    { new Guid("e5f32b71-a2b4-4d51-8f8a-77966e5ca00c"), "TET2024", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0519cdd-cce0-474f-b3a6-4855a6599367"), "VIP2024", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "PromotionUserID", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0fa95db0-ef07-409d-87a3-0141dbb0adda"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9339), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("3736c1f8-397d-4074-8ea1-2104ba01a8c8"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9469), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("413fd50f-563a-414b-9ff5-6bbbf7d835dd"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9519), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("74bb69f7-ae3d-4af5-b6be-b675aba4e96b"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9408), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("76700b28-96ba-45b8-a481-881cdebad879"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9379), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("79d5397a-7b58-4f87-9b42-2957a94cd8d2"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9495), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("9730aa75-e9c7-4c37-a7ac-5f3179ebbdea"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9546), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("be3cdc03-3344-476a-a027-f4af453c0ed5"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(8979), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("ed6d825d-cc33-4294-a828-f83b17d4e122"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 20, 22, 259, DateTimeKind.Local).AddTicks(9434), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "promotionTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("13e9b416-24bd-448b-81c5-4448890389b2"), "Khuyến mãi mua một sản phẩm, tặng kèm một sản phẩm khác", "Mua 1 tặng 1" },
                    { new Guid("596dea20-b3d2-443a-9fb0-0efa9ae3789b"), "Giảm giá theo phần trăm tổng hóa đơn", "Giảm giá phần trăm" },
                    { new Guid("61752b6e-345f-4760-99f3-dcdba56fa5d9"), "Giảm giá một số tiền cụ thể trên hóa đơn", "Giảm giá cố định" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "ID", "Description", "DiscountAmount", "EndDate", "IsActive", "Name", "PromotionCodeID", "PromotionTypeID", "StartDate", "UserID" },
                values: new object[,]
                {
                    { new Guid("eb462249-5821-47da-9c16-c89c9f076195"), "Giảm giá 20% cho tất cả khách hàng vào dịp Tết Nguyên Đán", 20m, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Khuyến mãi Tết Nguyên Đán", new Guid("e5f32b71-a2b4-4d51-8f8a-77966e5ca00c"), new Guid("61752b6e-345f-4760-99f3-dcdba56fa5d9"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("f3f982ae-1c48-4e24-af0f-ac7db7a4c8c8"), "Giảm giá 30% cho khách hàng VIP", 30m, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Giảm giá khách hàng VIP", new Guid("f0519cdd-cce0-474f-b3a6-4855a6599367"), new Guid("596dea20-b3d2-443a-9fb0-0efa9ae3789b"), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3c7c99b0-a49d-4aca-8b13-643fa0f0d5ed") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("b82c52ff-a22e-40f8-a38c-64bff93bc992"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("ccdb068d-4e88-48f7-a180-8c997cb2175a"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("d86b6f8d-772e-48b1-a3f9-2d164d13797b"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("e7126555-da58-4668-b8c4-bd90d443f134"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("53cc7f6f-c996-4cc4-809d-33359992a918"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("651d3b1e-3fa2-4fd4-a212-1d0f77ae013e"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("ca2e3e94-0e25-4589-92e6-adc635e3679f"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("da3304f6-3775-4bcd-af7e-7367b57c4b4b"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("bfc1c695-2bff-4cf4-a7e1-08505d8dc9c7"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("c4b5a0dd-1cd8-4a80-9547-5acff9322e92"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("d3dc09bf-b23d-4e70-a400-90f913d0a58c"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("d70f2300-381c-425a-8162-a3cf34d228bf"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("46f5ae75-a196-49fd-9719-3abbb56b8725"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("68c0ab5b-9f8d-4b1c-ae17-2b4c92558c76"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("fe707ac9-7e27-46be-981f-e1be1c611aa1"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "ID",
                keyValue: new Guid("eb462249-5821-47da-9c16-c89c9f076195"));

            migrationBuilder.DeleteData(
                table: "Promotions",
                keyColumn: "ID",
                keyValue: new Guid("f3f982ae-1c48-4e24-af0f-ac7db7a4c8c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0fa95db0-ef07-409d-87a3-0141dbb0adda"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3736c1f8-397d-4074-8ea1-2104ba01a8c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("413fd50f-563a-414b-9ff5-6bbbf7d835dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("74bb69f7-ae3d-4af5-b6be-b675aba4e96b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("76700b28-96ba-45b8-a481-881cdebad879"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("79d5397a-7b58-4f87-9b42-2957a94cd8d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("9730aa75-e9c7-4c37-a7ac-5f3179ebbdea"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("be3cdc03-3344-476a-a027-f4af453c0ed5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ed6d825d-cc33-4294-a828-f83b17d4e122"));

            migrationBuilder.DeleteData(
                table: "promotionTypes",
                keyColumn: "ID",
                keyValue: new Guid("13e9b416-24bd-448b-81c5-4448890389b2"));

            migrationBuilder.DeleteData(
                table: "PromotionCodes",
                keyColumn: "ID",
                keyValue: new Guid("e5f32b71-a2b4-4d51-8f8a-77966e5ca00c"));

            migrationBuilder.DeleteData(
                table: "PromotionCodes",
                keyColumn: "ID",
                keyValue: new Guid("f0519cdd-cce0-474f-b3a6-4855a6599367"));

            migrationBuilder.DeleteData(
                table: "promotionTypes",
                keyColumn: "ID",
                keyValue: new Guid("596dea20-b3d2-443a-9fb0-0efa9ae3789b"));

            migrationBuilder.DeleteData(
                table: "promotionTypes",
                keyColumn: "ID",
                keyValue: new Guid("61752b6e-345f-4760-99f3-dcdba56fa5d9"));

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("06923812-5cfb-46f7-afb2-466c11adbf37"), "Trung Quốc" },
                    { new Guid("0940c663-4838-4253-8901-23edd91d7659"), "Nhật Bản" },
                    { new Guid("dec2a64c-b505-400b-8617-55134225449f"), "Việt Nam" },
                    { new Guid("fc8aa2b3-17f4-4d8e-be42-d862dd80b65e"), "Vương Quốc Anh" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "BirthDate", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("1dd325f4-8604-4e37-9e73-6d6880b42a9e"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn B", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 4 },
                    { new Guid("45ff9fc3-3788-4eb1-8f9b-2abcbdcf9142"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn C", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 4 },
                    { new Guid("78baab91-02ae-45d9-8ed4-2ab9fe37f273"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn D", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 },
                    { new Guid("f04dfa90-ab3d-4a21-840c-5d8cc24927a0"), "Hà Nội", "Có", new DateTime(2000, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, null, "Nguyễn Văn A", "Nam", "\"image1.jpg\"", null, null, "Ha Noi", 1 }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("430e3043-e6e9-40e6-b659-852ce0cc8c82"), null, null, null, null, null, "2D", null, null },
                    { new Guid("4eea0a29-ba57-45fb-8da1-a0103bee4a91"), null, null, null, null, null, "Kịch tính", null, null },
                    { new Guid("664651a1-98be-4762-91f5-542bfdc6677f"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("6b8bf3df-b8ad-419a-beed-4f5d9b7059ca"), null, null, null, null, null, "Tình cảm", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("4129629c-567f-469f-a716-b704a86ea9d3"), null, null, null, null, null, "vi", null, null },
                    { new Guid("bd704b4b-237d-4050-93d6-3b8941fed447"), null, null, null, null, null, "en", null, null },
                    { new Guid("e722d2a4-2da1-4a28-809d-752bc0e5d608"), null, null, null, null, null, "ja", null, null }
                });

            migrationBuilder.InsertData(
                table: "PromotionCodes",
                columns: new[] { "ID", "Code", "EndDate", "MaxUsage", "StartDate" },
                values: new object[,]
                {
                    { new Guid("9c21f5ff-28e6-4195-a559-017504efd0e4"), "TET2024", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 100, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aff6e5ac-4239-45e2-b4c7-a3d2d6dd640d"), "VIP2024", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(676));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "PromotionUserID", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("3c44233b-81e9-4086-8581-ae51a5a1ff1e"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1152), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "admin@gmail.com", "Admin", true, "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("446d07e7-1e1e-4aee-800f-e90ce793407f"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1178), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "client@gmail.com", "Client", true, "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4abfb82d-0548-4d52-a7fe-f048f55017a8"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1199), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("50438606-14e8-41ba-b8bd-632e6f052469"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1300), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5d139585-8ee3-43ec-ac73-06b524907041"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1219), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("72cff11a-caee-4043-aa28-ea889d2367d3"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1263), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8660461e-1efa-4ec1-8bde-0fd50a37bb85"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1282), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("aaa8aa03-82b5-46ea-a6a5-231ef6740654"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(1245), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("e538e1f0-083f-4af8-9607-d91b263c7155"), "Ba Vi", null, new DateTime(2024, 10, 5, 8, 19, 36, 384, DateTimeKind.Local).AddTicks(775), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", true, "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("00000000-0000-0000-0000-000000000000"), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "promotionTypes",
                columns: new[] { "ID", "Description", "Name" },
                values: new object[,]
                {
                    { new Guid("2112db85-c2ca-4656-97e6-1dafbf816712"), "Khuyến mãi mua một sản phẩm, tặng kèm một sản phẩm khác", "Mua 1 tặng 1" },
                    { new Guid("8a9616f2-f2f8-4071-9543-e3d07c8cd9f4"), "Giảm giá theo phần trăm tổng hóa đơn", "Giảm giá phần trăm" },
                    { new Guid("e8b22302-9f5a-4fad-bfda-e500729427df"), "Giảm giá một số tiền cụ thể trên hóa đơn", "Giảm giá cố định" }
                });

            migrationBuilder.InsertData(
                table: "Promotions",
                columns: new[] { "ID", "Description", "DiscountAmount", "EndDate", "IsActive", "Name", "PromotionCodeID", "PromotionTypeID", "StartDate", "UserID" },
                values: new object[,]
                {
                    { new Guid("2e7ac9cc-535b-4f95-bec1-de099c2f67a5"), "Giảm giá 30% cho khách hàng VIP", 30m, new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Giảm giá khách hàng VIP", new Guid("aff6e5ac-4239-45e2-b4c7-a3d2d6dd640d"), new Guid("8a9616f2-f2f8-4071-9543-e3d07c8cd9f4"), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f37e5276-a107-4569-8fb2-0f8a344f4ce5") },
                    { new Guid("c7db960f-e3dd-453c-a5a1-eab45d4a2fc9"), "Giảm giá 20% cho tất cả khách hàng vào dịp Tết Nguyên Đán", 20m, new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Khuyến mãi Tết Nguyên Đán", new Guid("9c21f5ff-28e6-4195-a559-017504efd0e4"), new Guid("e8b22302-9f5a-4fad-bfda-e500729427df"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
