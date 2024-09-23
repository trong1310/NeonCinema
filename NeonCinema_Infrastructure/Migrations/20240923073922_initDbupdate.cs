using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initDbupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("75bdaead-5c24-44b0-a69e-d84866425c55"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("129ba6ed-4f3d-4aa4-935a-7d23b5a7fecc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5303f301-5f21-42a8-b268-e651247d1bc8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58a66b44-b648-4988-9b41-e8939f95b96e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("70a59bd8-9b6f-40e9-9806-6627f23b5624"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("cca41d8c-afd8-4fd8-831e-34ad84c3cb96"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("e9ef9359-2ecb-4dc0-9787-ae8ae66e7b3c"));

            migrationBuilder.AddColumn<string>(
                name: "Images",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("4e9a5b9f-44f3-4a68-897c-0e92f8831e8a"),
                column: "Images",
                value: "flims2.jpg");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("4008d984-b1f5-47eb-b1a8-fa4d23cb7b30"), 18, new Guid("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"), null, null, null, null, "Câu chuyện này tập trung vào cuộc sống sau về hưu của một cảnh sát ở một xóm nhỏ của Sài Gòn. Dù đã rời khỏi ngành công an, tinh thần đoàn kết và lòng yêu nghề của chú cảnh sát vẫn rạng ngời. Trong một thời gian dài sống tại khu vực này, chú quyết định hợp tác với những thanh niên có hoàn cảnh và tính cách cá biệt để thực hiện một phi vụ điều tra bí ẩn.\r\n\r\nCuộc hợp tác bất ngờ này không chỉ kéo chú cảnh sát trở lại cuộc sống căng thẳng và hối hả của việc làm cảnh sát, mà còn khiến cho cuộc sống của họ trở nên rối ren và hài hước. Họ quyết định mua lại một quán cơm tấm tại xóm nhỏ để che mắt tội phạm và làm nơi tập trung thực hiện các hoạt động điều tra.\r\n\r\nKhông lâu sau, quán cơm tấm của họ trở nên nổi tiếng trong khu vực với những dĩa cơm thơm ngon và phục vụ tận tâm. Điều này không chỉ thu hút sự quan tâm của người dân trong khu vực mà còn của những khách hàng xa xôi. Sự thành công của quán cơm tấm bắt đầu tạo ra những trở ngại cho phi vụ điều tra của họ, và họ phải đối mặt với nhiều tình huống dở khóc dở cười trong quá trình điều tra.", new Guid("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de"), 100, new Guid("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"), "flims2.jpg", new Guid("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"), null, null, "Nghề siêu dễ", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "inception_trailer.mp4" },
                    { new Guid("92687070-c3a5-4599-a153-189730caaabc"), 18, new Guid("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"), null, null, null, null, "Bộ phim tương tác với đề tài giới tính thứ 3 qua cuộc sống của Mến và Nhớ. Tại miền Tây sông nước, sự kỳ thị và áp lực xã hội đặt lên họ trở thành hình mẫu tiêu biểu cho câu chuyện về sự đấu tranh vì tình yêu và sự chấp nhận. Cặp đôi Mến - Nhớ đã phải vượt qua những khó khăn và thách thức đặt ra bởi xã hội và cuộc sống hàng ngày để tìm kiếm hạnh phúc của mình.\r\n\r\nTuy nhiên, bi kịch không ngờ đến khi Nhớ bắt đầu từ bỏ, dẫn đến việc anh bắt đầu du nhập vào những mối quan hệ mới với những cô gái khác... Cuộc hành trình của họ đánh dấu một câu chuyện đầy bi thương về tình yêu và sự thay đổi trong một xã hội định kiến.", new Guid("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de"), 100, new Guid("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"), "flims3.jpg", new Guid("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"), null, null, "Mến gái miền Tây", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "inception_trailer.mp4" },
                    { new Guid("dc418704-38c2-4128-aaf4-9772051969db"), 18, new Guid("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"), null, null, null, null, "Bộ phim tương tác với đề tài giới tính thứ 3 qua cuộc sống của Mến và Nhớ. Tại miền Tây sông nước, sự kỳ thị và áp lực xã hội đặt lên họ trở thành hình mẫu tiêu biểu cho câu chuyện về sự đấu tranh vì tình yêu và sự chấp nhận. Cặp đôi Mến - Nhớ đã phải vượt qua những khó khăn và thách thức đặt ra bởi xã hội và cuộc sống hàng ngày để tìm kiếm hạnh phúc của mình.\r\n\r\nTuy nhiên, bi kịch không ngờ đến khi Nhớ bắt đầu từ bỏ, dẫn đến việc anh bắt đầu du nhập vào những mối quan hệ mới với những cô gái khác... Cuộc hành trình của họ đánh dấu một câu chuyện đầy bi thương về tình yêu và sự thay đổi trong một xã hội định kiến.", new Guid("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de"), 100, new Guid("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"), "flims3.jpg", new Guid("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"), null, null, "Mến gái miền Tây", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "inception_trailer.mp4" },
                    { new Guid("e6e03e8e-2384-463a-8346-880a9789b6c7"), 18, new Guid("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"), null, null, null, null, "Câu chuyện này tập trung vào cuộc sống sau về hưu của một cảnh sát ở một xóm nhỏ của Sài Gòn. Dù đã rời khỏi ngành công an, tinh thần đoàn kết và lòng yêu nghề của chú cảnh sát vẫn rạng ngời. Trong một thời gian dài sống tại khu vực này, chú quyết định hợp tác với những thanh niên có hoàn cảnh và tính cách cá biệt để thực hiện một phi vụ điều tra bí ẩn.\r\n\r\nCuộc hợp tác bất ngờ này không chỉ kéo chú cảnh sát trở lại cuộc sống căng thẳng và hối hả của việc làm cảnh sát, mà còn khiến cho cuộc sống của họ trở nên rối ren và hài hước. Họ quyết định mua lại một quán cơm tấm tại xóm nhỏ để che mắt tội phạm và làm nơi tập trung thực hiện các hoạt động điều tra.\r\n\r\nKhông lâu sau, quán cơm tấm của họ trở nên nổi tiếng trong khu vực với những dĩa cơm thơm ngon và phục vụ tận tâm. Điều này không chỉ thu hút sự quan tâm của người dân trong khu vực mà còn của những khách hàng xa xôi. Sự thành công của quán cơm tấm bắt đầu tạo ra những trở ngại cho phi vụ điều tra của họ, và họ phải đối mặt với nhiều tình huống dở khóc dở cười trong quá trình điều tra.", new Guid("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de"), 100, new Guid("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"), "flims1.jpg", new Guid("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"), null, null, "Nghề siêu dễ", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "inception_trailer.mp4" },
                    { new Guid("e707beb6-dd16-46c9-898a-8f27094fee10"), 18, new Guid("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"), null, null, null, null, "Bộ phim tương tác với đề tài giới tính thứ 3 qua cuộc sống của Mến và Nhớ. Tại miền Tây sông nước, sự kỳ thị và áp lực xã hội đặt lên họ trở thành hình mẫu tiêu biểu cho câu chuyện về sự đấu tranh vì tình yêu và sự chấp nhận. Cặp đôi Mến - Nhớ đã phải vượt qua những khó khăn và thách thức đặt ra bởi xã hội và cuộc sống hàng ngày để tìm kiếm hạnh phúc của mình.\r\n\r\nTuy nhiên, bi kịch không ngờ đến khi Nhớ bắt đầu từ bỏ, dẫn đến việc anh bắt đầu du nhập vào những mối quan hệ mới với những cô gái khác... Cuộc hành trình của họ đánh dấu một câu chuyện đầy bi thương về tình yêu và sự thay đổi trong một xã hội định kiến.", new Guid("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de"), 100, new Guid("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"), "flims3.jpg", new Guid("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"), null, null, "Mến gái miền Tây", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "inception_trailer.mp4" }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("0fc74633-8805-425e-91c0-53e944138790"), "Ba Vi", null, new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(7082), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("15218d81-a5df-49ae-bd85-bf59047f47b0"), "Ba Vi", null, new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(7015), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "client@gmail.com", "Client", "Nam", "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("3c46d883-31ca-4bac-90eb-b8cf3c0dd1db"), "Ba Vi", null, new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(6256), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("5ad4aa91-6d14-460a-936a-0fd110eb9724"), "Ba Vi", null, new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(6977), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin@gmail.com", "Admin", "Nam", "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("76b46709-216e-4a74-94f4-63e1d4b06b9d"), "Ba Vi", null, new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(7121), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c9da6f91-f6f7-41ee-b77a-3d4b76cfd1b2"), "Ba Vi", null, new DateTime(2024, 9, 23, 14, 39, 22, 433, DateTimeKind.Local).AddTicks(7052), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("4008d984-b1f5-47eb-b1a8-fa4d23cb7b30"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("92687070-c3a5-4599-a153-189730caaabc"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("dc418704-38c2-4128-aaf4-9772051969db"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("e6e03e8e-2384-463a-8346-880a9789b6c7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("e707beb6-dd16-46c9-898a-8f27094fee10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("0fc74633-8805-425e-91c0-53e944138790"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("15218d81-a5df-49ae-bd85-bf59047f47b0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("3c46d883-31ca-4bac-90eb-b8cf3c0dd1db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5ad4aa91-6d14-460a-936a-0fd110eb9724"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("76b46709-216e-4a74-94f4-63e1d4b06b9d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c9da6f91-f6f7-41ee-b77a-3d4b76cfd1b2"));

            migrationBuilder.DropColumn(
                name: "Images",
                table: "Movies");

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[] { new Guid("75bdaead-5c24-44b0-a69e-d84866425c55"), 18, new Guid("4b2a3f4c-6e7d-4f7e-8c2d-d4d5f6a0b1c3"), null, null, null, null, "Câu chuyện này tập trung vào cuộc sống sau về hưu của một cảnh sát ở một xóm nhỏ của Sài Gòn. Dù đã rời khỏi ngành công an, tinh thần đoàn kết và lòng yêu nghề của chú cảnh sát vẫn rạng ngời. Trong một thời gian dài sống tại khu vực này, chú quyết định hợp tác với những thanh niên có hoàn cảnh và tính cách cá biệt để thực hiện một phi vụ điều tra bí ẩn.\r\n\r\nCuộc hợp tác bất ngờ này không chỉ kéo chú cảnh sát trở lại cuộc sống căng thẳng và hối hả của việc làm cảnh sát, mà còn khiến cho cuộc sống của họ trở nên rối ren và hài hước. Họ quyết định mua lại một quán cơm tấm tại xóm nhỏ để che mắt tội phạm và làm nơi tập trung thực hiện các hoạt động điều tra.\r\n\r\nKhông lâu sau, quán cơm tấm của họ trở nên nổi tiếng trong khu vực với những dĩa cơm thơm ngon và phục vụ tận tâm. Điều này không chỉ thu hút sự quan tâm của người dân trong khu vực mà còn của những khách hàng xa xôi. Sự thành công của quán cơm tấm bắt đầu tạo ra những trở ngại cho phi vụ điều tra của họ, và họ phải đối mặt với nhiều tình huống dở khóc dở cười trong quá trình điều tra.", new Guid("5a1d9b1a-71f2-4e29-b3a5-8f4c0a5e94de"), 100, new Guid("7c3f9d2e-31e2-4d23-82c8-805c9c1a2309"), new Guid("9a5d3f1c-b0c5-40c5-9d84-b0b8c4d6a1d7"), null, null, "Nghề siêu dễ", new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "inception_trailer.mp4" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("129ba6ed-4f3d-4aa4-935a-7d23b5a7fecc"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(6849), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "vantrongvt1310@gmail.com", "Nguyễn Văn Trọng", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0334583920", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5303f301-5f21-42a8-b268-e651247d1bc8"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(6766), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "admin@gmail.com", "Admin", "Nam", "images.jpg", null, null, "CNGfZLm8IgV4PLYHIuAxaA==", "0334555555", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("58a66b44-b648-4988-9b41-e8939f95b96e"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(6900), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Phongdxph35748@fpt.edu.vn", "Đặng Xuân Phong", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0356400122", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("70a59bd8-9b6f-40e9-9806-6627f23b5624"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(6811), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "client@gmail.com", "Client", "Nam", "images.jpg", null, null, "uwIZujummuxfCG/M104Pww==", "0334555555", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("cca41d8c-afd8-4fd8-831e-34ad84c3cb96"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(6046), new DateTime(2004, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "giapptph39723@fpt.edu.vn", "Phùng Tiến Giáp", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("e9ef9359-2ecb-4dc0-9787-ae8ae66e7b3c"), "Ba Vi", null, new DateTime(2024, 9, 23, 10, 31, 0, 709, DateTimeKind.Local).AddTicks(6949), new DateTime(2004, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "cuongddpc07789@fpt.edu.vn", "Đặng Đức Cường", "Nam", "images.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0879130050", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });
        }
    }
}
