using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("3e91529c-8a0a-454f-b2bd-12a1ff581b71"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("60ac2f1c-5dcb-42e6-8361-3753b63b6b94"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("782cb184-268d-423e-a361-c9276edb73c0"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("857b4547-4fe9-4b3e-a2b8-fb9ec4a28bf6"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("990de630-49bc-41d2-84a6-72321ed83140"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("a286d6bf-dda3-4df9-a177-4282a0abc273"));

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), new Guid("9d16fbb6-2377-401d-8f47-8a232b98a371") });

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), new Guid("72f07a1f-568f-45a5-8754-882aa8f6437c") });

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), new Guid("1bebaaa3-d36d-4425-8257-d0cd5653eed2") });

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), new Guid("05532b57-9e63-4346-80c3-a8e52c63f41d") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("375e4e5e-35a9-4915-ba0c-b4c29d7dcb40"), new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), new Guid("4e21eb2f-313a-490b-bc27-0f90c225bd70") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2") });

            migrationBuilder.DeleteData(
                table: "Checkin",
                keyColumn: "ID",
                keyValue: new Guid("6ee53d14-7c37-48c3-8a63-cd605e11db2e"));

            migrationBuilder.DeleteData(
                table: "Checkin",
                keyColumn: "ID",
                keyValue: new Guid("eecb1091-aef2-4c33-aa86-13cf339f8623"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("e6b9514d-bd8b-4208-a0bf-cc959584c820"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("0580bc5e-00d8-4995-8ace-2fa68d36b8c3"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("2d65e2b9-64e9-44ed-a71b-5c4400818ed3"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("3269540f-bc84-42d9-8744-93690e47cf30"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("51b06880-1e62-4579-89da-4e10336be08a"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("59083b3f-9a46-463c-a52a-4c2c970067e0"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("85ca10bd-4aa3-42a9-a2cb-2169dce44572"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("b991e10d-8380-469d-9bac-efa369335868"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("c580e187-3d5b-41d9-aee8-e33b1b7cd0e1"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("e25e2df8-7a41-417f-a1cb-0d7c9a525056"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("18c79da6-999d-449e-b8b1-a81917290412"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("8d52e906-9bb3-439f-a94d-ba592cc94458"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("9a7745fe-edf3-4760-8c00-3f31de981a94"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("f1505424-c963-4e6c-93e0-57c713732b8d"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("f707fb95-e498-4e37-b094-454dbc1a4667"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("5341aac1-d5e5-49ff-8490-b8bf8ab33e67"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("95007f6e-8043-409e-aa59-18e21c112e13"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("c91817a4-9e1b-48d9-82d4-647d2f04e8e0"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("ca033979-d36e-4d4e-bf8a-61ac114f2d76"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("d20162d0-4898-4c09-a78f-e6dd5736676c"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("46b4c3d1-aa68-4607-901d-c3f0af508fd3"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("82edbda1-bc4c-4a7c-b42b-1cc7a1f0532e"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("8e05f530-e4fd-4723-98ad-dc4928cff696"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("bf1fa6c8-b068-4809-b30f-69ad579df588"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("194a7588-fbc4-450e-b8dc-0b2dfdce3b81"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("57622f9c-9054-4523-96fe-eab9b1dd7110"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("828c8a68-6beb-4349-9560-e17d67529e83"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("b78712ac-6542-4a0a-9abe-366d223242dd"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("c4e09c95-5f67-4090-80a8-2b022bd875c7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("dfb06127-4c7c-40a8-ac0e-f0f7eb017f03"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("f1f48ad0-9552-4f47-a773-c531beae1955"));

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "ID",
                keyValue: new Guid("8cbd081b-ec8a-46e5-b966-f311baf02366"));

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "ID",
                keyValue: new Guid("ec2aebea-b86a-4ea2-aaa7-642c30952b19"));

            migrationBuilder.DeleteData(
                table: "Point",
                keyColumn: "ID",
                keyValue: new Guid("619f405a-f47c-41b5-a8f1-b5a807c6ba56"));

            migrationBuilder.DeleteData(
                table: "Point",
                keyColumn: "ID",
                keyValue: new Guid("a72e6123-44c9-4559-b210-944fd2e2b5b5"));

            migrationBuilder.DeleteData(
                table: "RankMember",
                keyColumn: "ID",
                keyValue: new Guid("c95ed77a-48a9-4a32-b504-c0b69a4b193a"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("267ea482-5c2f-4c1c-8ff2-d48590b3c64d"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("2caba10d-d2f4-45e7-86ba-d2db43c36874"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("84dbc11c-dadb-48e3-a267-d825c94efaf9"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("f7f67a20-d1b2-42e3-9d42-1433fd550522"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0298ce8b-7940-4cf4-8e4e-4697551558a9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("030dad44-e578-4607-8f06-594344b1b39f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("03e8fb73-2774-466b-892b-d9fea6ea75de"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("057c5fd3-9031-453c-b9fa-efdab3a6a987"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("05e18bfc-2f04-4377-9ba9-67af7a6c3c89"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("06576851-1b89-4f9a-af24-0681ad4606e4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0913ab7e-0c42-456d-8ad1-c7a8c3b46756"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("094451f7-f288-409e-bc64-f1bf8f456a7b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0959ba95-ef4a-4879-8500-ef23e3f9f061"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0aa0f49f-8196-4532-bc67-50d8774aab9e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0c49f85e-6d48-4d0b-be44-5d2c3e46a421"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0e2b764e-c3c5-45ab-a109-89c803aa27de"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0e653c5d-d2ee-4a04-b798-4b059b7b50ac"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0fa73f1b-3b55-4db2-95e4-e72aa29ea8cd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("10a749f9-8bde-460f-bad3-8fc2105c08cb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("10bded72-6524-4b1a-9c3b-26525d68b56c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1153ec32-2178-442d-a4e0-18c4ebfaebf2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("11e34a1a-a396-47df-b255-95e4ff21020b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("12e9e87f-5fcc-423c-b4eb-5cd989cc8d7b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1305642b-ddc7-47eb-b6f6-25a7d79e34dc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1407d0e9-f31a-4990-80f2-28d4b52c5e01"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("15114317-8b62-484c-bb6c-17df847a466e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("15958238-7db6-47e0-8286-798f211a5143"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("15b02569-5c1c-44b4-b3b9-4c8f3a574d76"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("160f357a-d1bb-406d-9bab-213e68279545"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("16fc7780-5374-4651-8ef1-61cf60755850"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1954f554-1684-492a-948b-d3acc6ea503f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("19bca009-9e54-41a3-96f5-2a7ddeab4c25"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1a604720-1443-4076-a453-41972b656784"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1b8b98c6-5fda-4553-869f-04489deb7b3c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1b9666da-5ddd-4684-840d-77f9fc6ace49"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1f18bd99-7ef7-4f93-9f40-7184097f2542"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("20126c8e-f350-464d-9a5d-bdd574e844e7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("226fa531-93f5-43d8-a98f-79f971ffe237"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2405a779-9e91-480d-a2fa-6c274d1a792c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("24124c12-0187-4b9f-a2aa-113bddc63ada"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("25085e54-7d49-427c-85fa-0d7540e6542c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("25a17765-5d47-43db-8f0c-367a5ecf7762"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("25e9aa47-a8c3-4849-8d98-8f44c29ab4d1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("26932824-891d-4604-b9b1-d9b732c308a7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("27c11fe1-f393-49ce-ae45-a11fb3e9c9c1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2820cc73-6308-48ab-bd6c-f217cd8e75d5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("284b3f83-c296-4d8d-8f6f-eda0e8ed89ea"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("29ad314b-55af-4392-90ab-d35e2f64c072"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2c6edc47-c83e-4b33-beca-ff1ba70e9937"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2d209567-a1cc-498a-94c3-275a9333e66f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2effe7e4-e06c-4a09-a18e-32ceb580b4aa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2f22da55-f305-4690-b09d-6f5f3e556f70"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2f8ea3ae-f56d-4319-9c59-0301146e03be"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2fbc1687-a104-4ec4-a9b5-11a180d0ed4b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("33e42989-6473-4837-9e7e-7ad4f7de5576"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3403809f-60c4-4a01-9b6c-b0b685bb1355"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3553b7de-d4e1-41ee-8f1f-c8ae2fb7b9a3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3658a694-f31f-4ed1-a2da-14d8b36388d2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("36693146-0a77-42a1-ab52-5c15a642ddb5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("371acf93-795e-4733-8d79-ecb484431c43"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("38f0d38b-8f20-43cc-9748-cd0b96728310"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3b328b75-3ddf-4dac-adc9-7266bc96707e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3b978965-a628-441e-afad-acef3831224e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3bec4ebf-922f-41e9-8f2f-688b4f9fe8bd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3c48c974-8179-4c2b-8938-dfffe61e1bb7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3c85bd80-3d2b-4518-8cfc-a16314aab7fe"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3ca2663b-7cde-4de9-8bf4-12ff83181d63"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3e0d2047-148d-4a11-b599-6c23bc1dd800"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3ecc80e3-d267-42bd-ba74-fc017ab1b3c1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3fdef0e1-9027-4f6f-81ea-dd6e8eec6a73"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("42cf3a09-b659-4eef-8277-4491fc950098"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("43682ad2-86a8-470f-94a4-47126b949e88"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4603b573-e6f8-4fe4-8904-2c261cadcb4d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("46ff4781-7561-463e-af68-5762bbc0ef66"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("49211a1a-fa8a-4360-b06b-cf366108267c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("492e1585-cc1c-481b-a7cf-abaf85a5c042"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4a58bcff-b638-4241-a046-20df7b6ce01d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4b773583-7244-4984-a6de-54eb17fd5196"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4c9d05c9-361a-4f3e-bc30-3d9f23b0a11b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4d1d3620-b44a-42be-8f37-5821893f8f8c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4e09b9f1-8fba-4683-ad0f-96ae40471dfd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4ea11259-3931-4694-911c-a501c6ca290c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4eda1d35-09bd-4039-b181-79f152fade32"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4eebcac3-d6cf-4166-a66e-04f049b9fec6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("53919fc2-a477-42df-a5a6-b2a09e520f42"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5433e546-3f57-4064-9133-b242c1978e05"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("54cf1f66-2851-4cb1-a709-d1c8eb33b031"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("55988e6b-afa4-4e3e-87a4-f4ab601dd2bf"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("55f8b9ae-ee91-4588-991a-52f54e2182e0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("57419b68-0972-49ba-8005-268cc7c717f3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5c734282-31cf-4716-84ef-ca9dd6723795"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5e085df4-b2c8-4651-8075-c6424815a133"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5fc58952-8a63-4a4a-b7af-9743b86d2a57"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6022f202-52b2-4ed7-b024-2d3c02885211"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("612730ce-372c-4b18-aafc-1aa30529879b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("61c097d1-a9e5-49ab-890d-3e91c5bcf3e9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("62b61f89-06ce-499b-935f-0c9d0b53c96c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("64346f32-eb3f-4261-ba4f-4eb4e4f23659"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("65dc4d64-a030-47cc-a173-a38f647e7b5d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("67f1045a-3dd4-4d46-ab8c-22fdc49fec94"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("692539c1-c5ed-4134-a7b5-bfc31f206722"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6972c5bb-8612-4caf-8fcf-327ffa0e0ad2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6b4ed24c-0dc4-4913-b932-b14cfbf0a913"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6b87da0c-0f37-41e1-b915-e1d7ed92a001"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6c06db39-d7dd-4a56-8751-0baf0ac2b2f3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6cb903f7-657b-4080-8e52-0d32d95ac81e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6ffc6990-b6d8-406a-be4c-21f1a93779ce"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7026feae-b0ea-485f-a0d0-d24927f0935c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("72c2779c-3055-4960-926e-0257f66b1dde"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("73b6fbbd-270a-448e-99ab-ef87c02b422c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("75310f06-783a-437d-bc0f-c6b26015b118"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("758f356a-12c1-44d0-9e43-770220da0f24"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("77da2675-3f82-4468-b83d-88111c42a200"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("78907c3e-9449-4cf4-92c7-5f1715d80154"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("78f1e655-91ae-4f1c-a0b1-6433624e85c2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7930dfa7-35a7-40f5-8e60-92c1abb38905"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("79b97a9d-e2b4-47d4-9e28-e7410b009fe5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7a5fb23a-2077-4809-9faa-5b6a64357a9c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7cfa7689-7fd1-4102-a01b-156c6391f834"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("820e8112-102a-4c4b-a074-c7ce2bea429b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("82968295-af4d-4a24-bc0e-05ce83cffa56"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8415b417-115e-408c-a247-bb4c0990d0c6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("84a05109-90b3-423b-b072-f170fc04ced8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("860aa50c-e832-48d0-b486-b866da1f80ce"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("86882a98-cae5-4566-ba8f-9a0f4302b6ba"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("86dd7d25-257a-48c3-8a37-1757455c35a7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8992eae4-a624-4864-936e-a5a25e9a7fc4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8a666a2a-2f34-41ad-adb9-14182fd40b2a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8b047c10-af0a-492b-9767-1c97c8c7b0c8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8b20abe5-5714-44ac-962c-f730b4c39ea0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8b31f670-6bb1-4527-9e7f-3d3531e3f05c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8b459da5-e1a5-4117-ae8b-64051443ecb8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8d4dbb61-f753-4eef-b02c-535848bb0a3e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8e4f1df6-0a70-475b-9f04-14ba3a12867f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8e69ec79-2ed6-46cd-8eb7-2c6b13df3f99"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("90235478-fdc2-49c4-8360-dafffd6d0491"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("90a1cfde-360a-4fb3-9ba1-5069d185aca9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("91eccb5a-f459-4d49-8d1e-e440cc25c675"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("93b021af-e4df-402d-9cb8-eaa0c47d5a2e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("94056fa2-a4ff-4263-a6da-1cd0b66df25c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9423e05d-b4c3-4769-aeb3-1d46faf21d49"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("96c5cbdc-0a42-4c2d-b8c0-957d7db616ee"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("991728f7-e127-4906-8874-fa9ad82f21b5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("998d8b1e-e4fa-4a8e-9b23-30c9b9d5e7e8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("99926d3e-744a-4e31-b980-73903f5f835f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("99a76e12-38d7-42a0-81cd-fc35aeb1c99c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9a3f0a97-43d2-4aed-83f2-62750d0891df"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9cd5a829-e5b9-43c1-89f4-27f6c0be5bd2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9d29014c-6b11-401e-9e5c-ea0978045630"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9d45b47e-db3d-4a78-9a49-b0e222cd18e5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9dce3f75-c2b9-400a-98f7-f6909b514d00"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a158e363-67ff-455f-9e7e-a885192bb501"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a23828a2-5470-4a3f-bdd1-6d2cc49b86f1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a356205c-a6e5-405b-b896-f98ba1250b39"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a35ed728-1894-487c-b8cb-a6b92af339ba"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a41ad284-79aa-436b-97ae-e3c63088da43"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a497bcb0-f6ce-46bf-aec8-1ba4782577d7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a56972ab-16b5-4cdf-bffe-f7b2ad81dc57"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a624bf01-d257-4e77-8061-73814545eb5a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a63a52a7-6b67-44b8-a403-f14fcf10ad9e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a748e9d4-21b9-4bf0-a87d-3bb4e9b25529"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a7bcd8bb-ecf3-4359-8d97-515653c7ec1c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a815519a-9421-47cc-a2db-1c1dca9ff005"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a82f4627-f44f-4cca-977d-c56ba0e6d3f5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a86afdea-6793-4d19-938e-20702504e4d9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("aa69b0f6-7058-4d7c-aa7e-47a3cdbf2603"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ab16422f-4320-4db8-8898-ac87d0aaeab2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ab97e561-aa71-4763-b8aa-9e4f62bf8390"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("accc46d4-43c8-40af-bb51-745b95434fc7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ae0f4c55-38c2-4b54-82b0-b88fb7fcdae9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ae146f19-1b05-45e2-9d98-6c8ec61734d7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("af27dc5d-a8cc-46cb-bc7e-d342b5441407"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("af6c7f74-a191-45f0-8d39-146af98f48fd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b0efe870-7f54-4596-bff4-33c31d47aa5e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b1dd3fce-571a-4fa5-b097-366440f3cfe8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b2289ebe-b4ef-4ecb-827f-cb89376f61a7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b2d6b9a5-4527-4eae-98aa-acc626a55134"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b2dd15e3-0362-470a-8ad7-f6ed3cb13f86"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b2f7a370-4dee-44a2-95fd-8cd103b041a5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b7a28afa-5e8d-4c2e-8904-639afa1779df"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b830f5da-4caa-40b8-a11d-0e64da81fd49"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b833e7d4-be2f-4a6f-aab1-2ac3d075b943"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b87af90f-df41-40a0-96c7-06087070df5d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b9ef45a4-026a-4db3-b859-3583e70345e1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bb442e5d-92c0-472e-ba73-ec6c5eedc270"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bbaf6bc9-b917-42bb-8984-fe59631e5384"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bbcd147f-cbef-4000-b13f-0aa6d4ba8516"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bbed937b-0a90-4807-918f-fc073e60cc78"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("be9f27f1-98b0-452d-844d-c9d6d1ef9efd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bec3bde9-a21f-40e8-b0ee-f346ea580feb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c01a50ce-bcd3-4fdd-9967-ac5e7989e288"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c0952191-6fbd-4a24-bc3c-6c396dbb4fe4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c0e818a6-d164-46f8-8bf4-fff12fec60e6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c3088f6a-191a-49f4-9560-8a56edca8b7f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c3dc5aad-6745-404d-a73a-756a47f268f1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c4d4e47a-8465-4922-9d6e-d4730986cd39"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c5f81c59-2add-4a0e-829a-5d8e833008a4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c7e1f7e2-af02-4ac1-a813-bd65d857fb41"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c7fc7ef9-f158-4134-9494-c75c558a5b91"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c96accf2-32da-4fac-bcaf-83b785b8d0ee"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("cad66e04-c308-4a5e-945b-859ac8a679bc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("cc81b986-bd9e-40d1-89e4-84451fc1c30e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("cee6a926-b2ca-4d26-a3ef-aae8b3f4daf8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("cfb89d7a-b4a1-4063-ac65-cd7f879b270d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d237f53c-d3df-48ef-b374-5aab506e5e49"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d2b7cb1a-d57a-4129-9bb5-bfd7be1905c2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d315899a-e1d6-4f39-9d37-f1eca2f67361"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d3680103-19ef-4060-8fa3-0f9237b9d455"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d465be8d-fed2-486e-b647-a3fbef466fca"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d469dd17-d164-41e5-97dc-4da723ce441a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d48682ef-8404-4b27-822f-71f3f15e6bd6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d704f46f-f7f9-4d26-9327-8193c7701afa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d81672e6-7275-4cf0-a791-e0fdc46b96fd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d9b77c8d-9b5f-45b1-b37e-7368ab49c066"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("dce7c810-6469-41e1-a275-817287368179"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("dd25c3c6-f639-4165-b0f5-e183cb29c23d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("dd7d6971-fd6a-42c5-8fc6-1df41657ab50"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("de44b01b-c87a-404a-8b69-3adf04c12ffe"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("df3a1d78-7467-41e4-9267-99f045114eee"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e06fd387-b4bf-469c-b694-823a5c12f387"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e18f5f14-e759-40ca-a4d0-a07f6cad8346"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e1fef5e8-b126-45c3-a153-75f7f74d4fbf"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e338c113-cf04-49a0-86e7-841274fad4ac"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e4967a9e-16a1-4bc0-8620-93b6354c0420"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e4b2e925-0ae7-4b03-9867-fb2c5c5b21ff"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e59beef8-6bc1-416f-8bfd-e857afcfdc62"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e6a17191-235f-4e75-b795-3101fac183a2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e77dcf9e-cdfe-4683-be90-3e6eddc657e6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e8e7c9d0-73b9-4ba7-abfd-c57d9b8af414"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ea93f4df-b587-4009-9dcb-bbeaa4090ff1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ea9a6357-0ddf-4869-b00a-b532ee214e25"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ed0d2b09-a5aa-4010-96c5-b5310ca8d6e3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ed27dfb3-2762-4ec6-804e-d52a21b48691"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ef2c7175-01ce-4c31-b70d-be918ab69584"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ef596cc4-63ed-4ede-9cb2-e89af07f9219"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ef7d22e3-50cc-41d6-8496-63ec3a7105fb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f0fdb10c-7ccb-4428-8f20-9fa70ba4fcc0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f11685ad-ebea-4bd6-8f9f-d6c113ca769b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f2d72d68-9df9-435d-a983-d6a85a2e76ff"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f3c15a59-3947-43f4-9fa1-077dafe5522f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f3e40213-d36c-410a-bc97-3dff183713c1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f41c3fd7-9890-4464-a072-8ba6e6ebfb17"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f433cb19-f6e8-4a80-85bf-c19d8d33ad15"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f48714f4-3172-462f-8e88-451ec858f10f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f49c0dbf-8f8b-4600-9ec3-ac7637e22814"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f53c3deb-a6a6-4d41-a7b4-552fb243c43b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f59401ac-d038-4494-894d-58d80a93fd4a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f5ffe0c2-0e7c-4d8a-9ca2-1005ad926dbe"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fa7d288e-7c33-43e3-98e8-9e7afddd8835"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fdfafe34-ad08-4df1-8707-a394fb05675c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fff707df-d904-45f0-a628-bfafb6b396dc"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("c8eabc76-e12d-4442-9ea1-595f07a64610"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("1f7d5e68-d263-4b69-b6ef-dae69b104d82"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("9904c940-e1db-4000-9d77-08ae3963ae79"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("f1f2041c-2880-48c3-a9f5-7951fddc53ed"));

            migrationBuilder.DeleteData(
                table: "Show_release",
                keyColumn: "ID",
                keyValue: new Guid("9eea6f2f-0197-4a42-aca8-a7968872b28b"));

            migrationBuilder.DeleteData(
                table: "Show_release",
                keyColumn: "ID",
                keyValue: new Guid("acf35039-4425-4b35-8c9b-1cc8fa6f8f39"));

            migrationBuilder.DeleteData(
                table: "TicketPrice",
                keyColumn: "ID",
                keyValue: new Guid("0113e16f-3c57-40bb-a790-b8a726358762"));

            migrationBuilder.DeleteData(
                table: "TicketPrice",
                keyColumn: "ID",
                keyValue: new Guid("56336b15-1668-4323-9296-3eebea21bb4b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d9d09c89-2e79-438f-9c87-e78d20675314"));

            migrationBuilder.DeleteData(
                table: "WorkShift",
                keyColumn: "ID",
                keyValue: new Guid("21c3ffc3-e718-427f-a29d-1e709ecc2256"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("375e4e5e-35a9-4915-ba0c-b4c29d7dcb40"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("05532b57-9e63-4346-80c3-a8e52c63f41d"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("1bebaaa3-d36d-4425-8257-d0cd5653eed2"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("72f07a1f-568f-45a5-8754-882aa8f6437c"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("9d16fbb6-2377-401d-8f47-8a232b98a371"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("58b299f8-425f-453b-be54-5961427be7d9"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("74904160-7f95-4b64-8306-792190d835a3"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("11714696-0dc6-4369-927e-4300aeb42515"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("014c866d-d5ee-48c8-a990-36f25b611283"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("2285f27a-ffdd-42ab-9f26-d2c70ba0ae00"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("65701a83-4e06-419e-b519-69bd6873b439"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("e61149fd-7e1d-49ea-b988-acfc50e33f24"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("f41dd84a-fe43-4246-ad3c-5081968f1639"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ID",
                keyValue: new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ID",
                keyValue: new Guid("4e21eb2f-313a-490b-bc27-0f90c225bd70"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ID",
                keyValue: new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("1edfe016-5fdd-44b4-b5ff-4b30c2d80234"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("58db499c-91bd-4f84-a40c-0cba27f8f64a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c21907e4-9a32-4663-9733-151d9baf031f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fc76638d-ef88-4d3f-ab7d-eed8c6e5b636"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("336e0a18-355c-466a-8233-e15f6389c966"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("41056346-3a8e-4010-bf53-f55417208f99"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("e4d0f32d-8946-415a-962e-695e55519a0a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("116e3aa8-e0b9-4d61-a2f0-d48ad61d248b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7fa4ad10-5ed5-4e96-81e7-b000f067442e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d9ee1b5d-2cb9-473d-b0b5-8a8fb95410fe"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("05955192-97e1-4613-856d-55491351cb48"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("20292962-8107-4547-90e9-01cbc8f79676"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("5279817e-f995-4a90-9df9-fa1f5abecaaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("fe6b1b3f-ead7-443d-a247-051232a6f562"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("41a51549-cbf5-4498-aeb2-435292366172"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("79e57ee8-3f28-43f9-b5d0-96df7674f38b"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("424c07b0-8c6c-489b-b129-9198baaf52ee"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"));

            migrationBuilder.InsertData(
                table: "Checkin",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "TicketID", "TicketsID", "Type" },
                values: new object[,]
                {
                    { new Guid("92467e89-4a7a-410b-a93b-cf9d61669f14"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("61fdc3e8-003d-470d-b8ef-8e97693448f8"), null, "mua tại quầy" },
                    { new Guid("eb4b75d4-f854-454a-950b-b77f1e5f8abb"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("090bfefc-fb3d-4175-b95d-f63502b66791"), null, "mua tại quầy" }
                });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[] { new Guid("2656e75a-4fdc-448f-ac09-c26f4fccdf84"), "11:00 PM", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8141), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("22901e4a-efdd-45a0-9026-ab4cb71ba31c"), "Pháp" },
                    { new Guid("2b3d34f7-18ae-46f0-960c-0a6201bacef1"), "Vương Quốc Anh" },
                    { new Guid("32518acf-6328-4659-9258-6561e3257c61"), "Mỹ" },
                    { new Guid("3685f5b6-2834-4de5-94cd-f196c69ceb44"), "Hàn Quốc" },
                    { new Guid("59b0ca51-aefb-4d4b-ac55-fa8d88d9c2b3"), "Việt Nam" },
                    { new Guid("6f7c63b7-93f6-470b-a05f-5d1321bdb67a"), "Trung Quốc" },
                    { new Guid("b48b0b21-fa92-4e44-a735-4dcfc6d824e0"), "Ấn Độ" },
                    { new Guid("b633ced0-8837-488b-97b4-8fa32b7b454f"), "Úc" },
                    { new Guid("dbd68c17-ea41-425f-844c-1f69fc5fa0d9"), "Hồng Kông" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("32a446c3-5d15-4083-b93b-c99378eacc69"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("3db234f2-1681-4567-8025-d34bae46c88e"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("54ecb3dd-dfa2-4a1e-b267-2d7bc1855e83"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("62ddc6b3-0f21-4594-aab1-b021cd88d031"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("a54e0e2d-fd0a-44f4-8396-1c232b27ea22"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("b20463b7-4ad8-4868-8a90-b29dbf9ca606"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("b23f8d29-c708-4e6c-aa66-c4aa14ae82e7"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("b29b0aa3-da1d-4945-b53d-f355d8c00e24"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("eea3261b-aecb-467b-bf5e-564e554c0549"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("19c2f177-84de-4bcb-be46-54b9e907fe86"), "Combo 2", null, new DateTime(2024, 12, 13, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(276), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("44d7a7c5-231c-4608-868b-a66820dd79b6"), "Combo 1", null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(271), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("5277a5a0-34c4-4343-a210-735577a10e94"), "Combo 3", null, new DateTime(2024, 12, 12, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(290), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m },
                    { new Guid("f565bcab-cad2-4b77-b6f3-565f7d42edea"), "Combo 4", null, new DateTime(2024, 12, 11, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(294), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("0301b89c-1047-4e81-9d5f-15715781209f"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("405fc976-8e5c-401f-9893-b477e8cf3007"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("50406ad3-8c77-4a9e-a627-a7b97f99219f"), null, null, null, null, null, "Phiêu lưu", null, null },
                    { new Guid("5c1ff9a7-9f37-4bfc-915f-819537eec9da"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("6a79a38f-a058-43f9-8f6f-b86105b4ea5c"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("b6a642f1-e756-4b20-9db2-d345f10577e2"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("b787552c-f2e8-46ee-a03d-4fcd30329f80"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("c83255ee-af2b-4d90-8956-3c6d3fffebc9"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("c9b11136-8d4c-4c11-85ea-d98b7af232ee"), null, null, null, null, null, "Kinh dị", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1fc8b0a6-ac46-449d-b7f2-f5d02723e4d9"), null, null, null, null, null, "USA", null, null },
                    { new Guid("1fe13af5-6468-497a-87f6-a59aa2981c65"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("36760271-e0bc-48c5-b76c-25d9f652ce18"), null, null, null, null, null, "ThaiLans", null, null },
                    { new Guid("856939a3-9418-4b92-bbbf-dcd07d93f04e"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("d10dd9a7-c2a9-4f8e-887c-b24a3a4a31e0"), null, null, null, null, null, "VIE", null, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9780), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "0e9f825c-5346-44f1-a94d-7078909ce83a.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" },
                    { new Guid("9cc25c7d-7920-4e81-9fcc-b95b817e418d"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9876), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("17ebd165-bb6a-4efa-9c9f-c7a7f9df5c1d"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("a738f58b-4550-45d4-bf1b-84bd2d09e85d"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(6167));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[] { new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8701), null, null, null, null, null, "Room 2", 12, 150, 1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0003cabb-b903-4b78-98f8-1017cb58f8c3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0182644f-2648-44cb-a61d-8fa51277ea71"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("037fa924-ebbb-4324-9e62-bfebb991af05"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0428c8f8-cc49-415f-8822-90302327673d"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06706a5b-5984-49f8-8edc-56501df6fddc"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("07094428-9641-49b7-b65a-11950e038ba3"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("073599a1-cad5-40ee-9dec-3e21de302c11"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0eedcec6-e489-4e4d-8680-74228c4f4cfd"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1011f719-95b6-4cbb-bd51-ecebb08b994a"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10633c46-6d63-45f9-b12c-d990d1014fbb"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("197b4693-83c8-47da-b7b1-aba8fec0e51d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1981656f-e714-40f5-95b4-2a478f469251"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a13d4f5-72f6-4d53-902e-a56bbecc83bf"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1bd4ba1f-0f32-4e8d-8677-a5b4b7768c5b"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1d429f53-90ed-4d67-a77f-04c4436257b1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1e770f58-5777-49bf-adba-cf8319ed6d49"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("208006f9-943a-4aac-911c-155f8e60fad9"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20a4d6e3-7cc4-4049-9fd7-4557dcebcb3c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("22c341a1-90cc-4d2e-a063-d59f8f0a6fd9"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23bc281b-d7ab-43a8-81f5-0e3778e46b57"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23f3a2c5-8af7-4450-b0c7-91a3015e7223"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26080d37-897a-4f97-8a35-929095dc04f2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27539dde-7f5c-4103-86a3-800bb4744a8a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29c75df4-66e5-4a0a-8426-ac93f8574821"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2a9f3feb-55ac-4377-ade8-9599d44f3df0"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c25b99d-0d44-4b06-8f81-098dd9801e87"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("301ebd1f-8974-4714-89d3-2103d4c70030"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30f24307-703a-4d35-96f6-1aa8d21f2521"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a1bd285-b411-4f7d-bcbf-011e3a30d543"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b4606cc-3022-4ff9-b270-b17c95d8320b"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e9f37d5-852a-40e2-8935-d8002b07ce3a"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("469e8c83-7fe0-48c9-87a1-c0b3ed196523"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46ef28a0-2b20-43d8-a318-a9a5ed4595de"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("482aab09-083e-409c-a520-67f6e5195b5d"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4bf1d717-74e1-4fec-9aa9-cee48685e3ab"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("516c30f7-3de5-4263-89c0-22052c19f485"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("526134fa-d844-456f-a47a-84bc49cf4248"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("52848e44-53ac-491e-a470-8126b6ff2486"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5411d3ff-61d8-4fec-997c-2b823540b025"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55b31707-4fee-4cc5-ab30-82e1c1895706"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a8059f4-064f-4c3f-a127-7098cbdeceb8"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6102f93e-666d-416f-904c-52cd51f0a07c"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6163fb97-fdab-41ae-9e9b-3505635de83e"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67713442-bbef-4391-bf3b-26328d527a3b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6db876fe-8859-45f0-81ee-6ad5f9f36f71"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6f65e163-640b-4328-be50-3d4d5a949d3a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7717ed1d-83eb-4ead-869f-82170261f4dc"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77ecd087-65e4-44d1-a333-83fb05705660"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79657ba8-8021-4949-bdb0-bf29ee6f4a10"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a9bb132-a72b-45b1-9bc1-eb9a5bea3c09"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ab53f8b-2bd9-447a-b8df-421957e42211"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8003dc15-0f5c-4fbd-864b-3151f75f2af6"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83dba46c-7e8a-4e1e-84ce-ef1aa582234a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84dc31c1-363e-4931-b312-f88456496007"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86905252-bfd5-4281-b644-564945c38e61"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8736c108-d38b-408f-b2b7-1f1ff9e60a27"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87f736d5-c474-4e11-8748-8ac278adf5fc"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a2d41f4-b04e-46ba-93fb-446d24108d24"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c11eab4-ab4c-47d0-8db5-70b92c09b265"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91bd7cdd-6e9c-4d09-a57b-bedfecb59b8a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9319eb89-7328-4376-bdf7-ea4b99a792cf"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9b7261c7-5222-44a9-8e0c-ef9d64044721"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9be45d18-c1bf-4369-ac13-c135b356d574"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a212d30b-1945-4359-aaf8-dd06cee691d0"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a264e020-ad61-44d4-8747-b327343df3bc"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a2c7b6f4-fe06-4f0f-9c76-cd99956db4a6"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5318f9b-b87e-4c0f-8844-6355b779fbd0"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a992d951-0fea-4d7a-8669-ae585d6bf055"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ac014d7a-8104-4588-a642-ceefb7a43cd6"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("acaa181a-e750-4673-928b-7a09a655d987"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("acd5c1c7-04c1-4a3d-810d-57983a72da73"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ad7fdb61-fd5a-4f63-9b08-0d25d83db476"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b04cb7f8-27eb-4f8b-9ba1-427cf7920109"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b284e0d7-1c0f-4848-adc3-61a591ab3331"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7ebba10-c927-4bc3-93d0-e9f0359cd946"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b806ca49-0a33-480f-8d75-6079769ca570"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b8ad7bbd-45ac-4e30-a49e-dbb498af9afb"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ba683e97-c6ce-4afb-a603-9f489ebe6bc7"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bc95bf4e-16d0-46fd-a40f-1906843d7414"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bd5ee435-b6e6-4577-95aa-9681ab2e8e9c"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be526e30-5ab4-471b-be26-78c973b1f7c6"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c2f4e6aa-f2b5-40e4-8ec9-4acb21d9d9c0"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6370557-29fa-4b9b-9df8-0df94e5d09ed"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c6a6ed83-e438-4215-aaf7-f3b7483b468a"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7a5d80a-15ef-4f8e-9f5e-0063b5bd6df7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8912403-6317-435c-bba0-f75b622c4682"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("da254a48-861d-4a50-b3db-0eb8616882bf"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd1615de-e8ca-4696-bfd8-3738c6f1a27f"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e2d79552-c278-4ccf-bc7c-1d6d771bc2e7"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e35b0f60-7fc9-4539-8cb0-78c8e9356082"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e3c5863a-699b-43e0-80e1-ef4c4ef39fc0"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6bc4ff9-23f6-4128-b349-1dd857572c44"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef62a5c0-4b03-4b95-9270-d261f42b6163"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("efbf97ca-fbf8-4c22-9fb6-cd87fcfe5d99"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0d2fc16-2c46-4c27-bcec-6ec8bd757c7f"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3453ec8-10a9-4f5b-93c1-af9acbe4c8fa"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f62dea58-2db0-409c-a97f-ca60e1ba9ba9"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f64021f1-6420-4c68-927d-42cb600a025f"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f6f35df6-1231-4463-8fcf-2aabb0720241"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f8b4e195-a750-46f3-a3d6-815c22b55a51"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("786747a8-e346-4fbc-9719-5a0b5d1334bf"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8105), null, null, null, null, null, "Ghế đôi" },
                    { new Guid("edba9acf-365f-4fc0-86be-a48abea6b913"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(8101), null, null, null, null, null, "Ghế Vip" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("0a6e19bf-210c-45f1-b99a-1bbfa70dbc63"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("18d6285f-4889-4b72-b4a2-ba3d783cd166"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("45ebf83a-0e8e-4185-9cec-649b9d974772"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("50b2ed5f-d2bd-471c-85fd-cbaab826c4c9"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("6f714c17-4a94-4c8d-a31e-7cb765f99d3d"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 },
                    { new Guid("c2cb1d61-af94-45fc-81dd-4bc5a61de30a"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("d19b5a27-abf0-4d33-b47c-c8e371c7fd9b"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("e34fd4f6-ab05-4c50-981e-dfdc7b06a21e"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("e3b6fb9f-7c4d-486b-99de-c11a19f46fa3"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("ed82f068-fe15-45d6-9546-33c61b30875c"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("27f24726-2ebd-47a5-a582-1673579d8219"), "Quảng Ninh", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7727), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("4745c825-c8c6-4edf-94f2-63635792d615"), "Nghệ An", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7488), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("77befdab-a933-4095-b17d-62dd9f81dc3c"), "Nam Định", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7660), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("7e280cd0-a6fa-4ecc-b814-ba1b1098ea78"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7448), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("856046e2-c09d-44d2-a4bb-9c1a1d69afac"), "Hưng Yên", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7613), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("8662cd58-ad9c-4023-8984-ff54fc4d6fad"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(6681), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("ab7b8bcb-a18f-4cb6-883a-95d648d4ce85"), "Hải Phòng", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7343), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b286c02d-0296-40cc-9a19-d17e5ea949c1"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7257), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c0ceddb5-dc6a-4de7-be5b-680be163fb60"), "Bắc Ninh", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7524), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c12e4ec8-796e-4a23-aff5-bade30866158"), "Đà Nẵng", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7400), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("dbf2b65d-e65c-40ed-bf97-5cd02d0d0166"), "Thái Bình", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7560), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f95cda12-52a1-4b98-8a51-9252bd47b5a4"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(7763), new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "giaphipp@gmail.com", "Phùng Tiến Giáp", false, "images/mai.jpg", null, null, "LK25tQh1RqkKbrq4C2l6fw==", "0862774830", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("036bbb82-bf20-498e-8b5a-9aa81a9f2c9d"), "BILL010", null, new DateTime(2024, 12, 8, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1108), null, null, null, null, null, null, 2, 700000m, new Guid("77befdab-a933-4095-b17d-62dd9f81dc3c") },
                    { new Guid("1298f0f0-3988-4d12-afc7-c5a60d51aea1"), "BILL001", null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(690), null, null, null, null, null, null, 2, 500000m, new Guid("8662cd58-ad9c-4023-8984-ff54fc4d6fad") },
                    { new Guid("6f6fb26e-f50b-4fdd-bfb0-1137d244177d"), "BILL007", null, new DateTime(2024, 12, 9, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1069), null, null, null, null, null, null, 1, 800000m, new Guid("c0ceddb5-dc6a-4de7-be5b-680be163fb60") },
                    { new Guid("8344ee73-b85d-4e16-b907-90c708c1b36f"), "BILL009", null, new DateTime(2024, 12, 6, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1082), null, null, null, null, null, null, 0, 350000m, new Guid("856046e2-c09d-44d2-a4bb-9c1a1d69afac") },
                    { new Guid("8cff9d91-ee5e-42aa-8452-70a3dea86b26"), "BILL004", null, new DateTime(2024, 12, 12, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(857), null, null, null, null, null, null, 2, 200000m, new Guid("c12e4ec8-796e-4a23-aff5-bade30866158") },
                    { new Guid("8d67362f-88ce-4229-9c51-03231762801b"), "BILL006", null, new DateTime(2024, 12, 10, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(873), null, null, null, null, null, null, 2, 600000m, new Guid("4745c825-c8c6-4edf-94f2-63635792d615") },
                    { new Guid("955b5bdb-e0bc-4de9-9b77-b41f459384bd"), "BILL003", null, new DateTime(2024, 12, 13, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(702), null, null, null, null, null, null, 3, 150000m, new Guid("ab7b8bcb-a18f-4cb6-883a-95d648d4ce85") },
                    { new Guid("aba7646a-876e-4300-900f-29aaf08a7230"), "BILL008", null, new DateTime(2024, 12, 4, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1076), null, null, null, null, null, null, 2, 450000m, new Guid("dbf2b65d-e65c-40ed-bf97-5cd02d0d0166") },
                    { new Guid("abba750b-c1a9-4a17-b26b-2bd961244950"), "BILL002", null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(697), null, null, null, null, null, null, 2, 300000m, new Guid("b286c02d-0296-40cc-9a19-d17e5ea949c1") },
                    { new Guid("bd16e14e-525d-4a38-83c6-a475b53d7c3d"), "BILL005", null, new DateTime(2024, 12, 11, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(862), null, null, null, null, null, null, 2, 250000m, new Guid("7e280cd0-a6fa-4ecc-b814-ba1b1098ea78") },
                    { new Guid("f2316e55-7c9c-4e40-9716-1156487d0171"), "BILL0122", null, new DateTime(2024, 12, 10, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(904), null, null, null, null, null, null, 2, 680000m, new Guid("4745c825-c8c6-4edf-94f2-63635792d615") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("2984c609-1a13-4c6d-a85c-49d8f175f2d9"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9797), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("eea3261b-aecb-467b-bf5e-564e554c0549"), 120, new Guid("5c1ff9a7-9f37-4bfc-915f-819537eec9da"), "161cd6ca-380d-4627-8071-2d5af03a1cf2.png", new Guid("d10dd9a7-c2a9-4f8e-887c-b24a3a4a31e0"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("40a40998-c5a9-4575-8456-16259e610330"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9935), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("3db234f2-1681-4567-8025-d34bae46c88e"), 145, new Guid("c9b11136-8d4c-4c11-85ea-d98b7af232ee"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("5267073c-5652-4802-a58a-9343c1f195a7"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9888), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("eea3261b-aecb-467b-bf5e-564e554c0549"), 150, new Guid("5c1ff9a7-9f37-4bfc-915f-819537eec9da"), "5b626704-f3d1-482f-b77c-903284966efa.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("55b1b40c-684f-450a-8d56-33f31437d60f"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9949), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("54ecb3dd-dfa2-4a1e-b267-2d7bc1855e83"), 100, new Guid("405fc976-8e5c-401f-9893-b477e8cf3007"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" },
                    { new Guid("ade4b5c4-5741-4174-991f-faafc8a36da9"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9846), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("3db234f2-1681-4567-8025-d34bae46c88e"), 140, new Guid("c9b11136-8d4c-4c11-85ea-d98b7af232ee"), "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("b42a47aa-7e82-4a0e-8292-3b50dcc7d44d"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9863), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("54ecb3dd-dfa2-4a1e-b267-2d7bc1855e83"), 125, new Guid("405fc976-8e5c-401f-9893-b477e8cf3007"), "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("c24d288b-a8fc-4a78-ac86-71663975e517"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9833), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("a54e0e2d-fd0a-44f4-8396-1c232b27ea22"), 110, new Guid("b6a642f1-e756-4b20-9db2-d345f10577e2"), "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("ee6765d6-07ba-43a8-9e28-5e4309104f45"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 599, DateTimeKind.Local).AddTicks(9905), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("a54e0e2d-fd0a-44f4-8396-1c232b27ea22"), 130, new Guid("b6a642f1-e756-4b20-9db2-d345f10577e2"), "7502d22a-c967-400c-bc8c-3062d00c7fcc.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("18d4167f-81f6-4251-b481-50f4f235bb50"), null, null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1339), null, null, null, null, null, 150, new Guid("b286c02d-0296-40cc-9a19-d17e5ea949c1") },
                    { new Guid("80b3c799-01ae-4731-83d0-36d3c84d170f"), null, null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1334), null, null, null, null, null, 50, new Guid("8662cd58-ad9c-4023-8984-ff54fc4d6fad") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("7fc822ad-e56a-43b7-ad53-cfe285a0e90b"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1295), 1, new Guid("8662cd58-ad9c-4023-8984-ff54fc4d6fad") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("2fe215e1-7327-4476-acc7-a596b65ab5cc"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(58), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 22, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(56), new Guid("45ebf83a-0e8e-4185-9cec-649b9d974772"), null, 0 },
                    { new Guid("44b07734-4358-4c24-a7fc-c50b4c745a94"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(64), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 21, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(62), new Guid("e3b6fb9f-7c4d-486b-99de-c11a19f46fa3"), null, 0 },
                    { new Guid("4825e614-8354-4008-8d14-f5bd15868f5e"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(73), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 20, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(70), new Guid("18d6285f-4889-4b72-b4a2-ba3d783cd166"), null, 0 },
                    { new Guid("63019ba3-9c8c-4658-a9bc-85a0545fb87d"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(45), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 24, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(42), new Guid("50b2ed5f-d2bd-471c-85fd-cbaab826c4c9"), null, 0 },
                    { new Guid("8d661d4f-87ad-4de1-96af-ba0659d58a4b"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(80), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 19, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(77), new Guid("0a6e19bf-210c-45f1-b99a-1bbfa70dbc63"), null, 0 },
                    { new Guid("e3f3b770-d646-421b-9046-7996c4073b95"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(86), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 18, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(84), new Guid("6f714c17-4a94-4c8d-a31e-7cb765f99d3d"), null, 0 },
                    { new Guid("f8437617-4a4a-432d-be7a-63ddcd57c96b"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(53), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 23, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(50), new Guid("ed82f068-fe15-45d6-9546-33c61b30875c"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("036318c4-56ff-4440-811d-5df1d7c20e02"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("046998fe-cc5a-4ae5-949a-7be047c366d5"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0505f042-eda9-4b27-b17d-0897aa6404ee"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05a5fa47-41db-45cb-9329-46b78b5608fb"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0662febd-31e8-4361-aa1a-2518034f70c9"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("08f5137f-f543-4efb-a3cc-f567dfdbce6c"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("09bb922a-6936-49cb-a5d0-6671f8135f80"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0a59c56b-0ee8-4ec9-ac6a-a0f7bfaab8ac"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0b4dab6d-f3a7-4aa8-953a-fd2295a0db40"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0bf99806-9bfe-43f4-b56c-6c8123a595b7"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d00cf4f-28fc-4fa7-af6b-a33d4286bbc3"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0d04f14e-cbe0-4259-988c-685192b11276"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0f2567c0-9abd-410e-b7c2-2d40baf7c918"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("143d3ede-c577-473c-a3ce-bc042cec4351"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1ac0f6db-206c-4c9f-ac98-16f1489ceabb"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1c22ee1c-d0dd-4ad0-a271-4543ccba65f4"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f1eafbf-f0bc-4b6b-95e7-7f81a9b4d50d"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("23baf82a-c84b-4bc9-a29b-49a254562d50"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25b80ee3-cb94-4696-a099-4ad06850eb94"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25ff06a3-e907-4ee1-b814-45104b5772f3"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26988d8c-574e-4118-b119-8ce8f7d8f0a8"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26d56c54-1940-4f9f-966e-751085ee84f0"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("28169e62-1015-490b-a2c5-347e697a2650"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("28c58c77-25c5-4484-a7a7-fa79a919ff0a"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("297adf54-7f56-4bb2-a423-baa72221f1d4"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29a98e97-ac7b-40fb-822f-04db246b80d6"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29d64ca2-7529-4845-b9bc-50193c67fb79"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2b3e02fd-6185-4cfd-a207-6ff971d3ea5e"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c6c37a9-85ed-4b2e-9801-8a07856f93a9"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30374bbc-f79c-4348-8f20-c68c0141416f"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3062bdf1-ec77-40a8-8876-960d911f2464"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("30ca80ca-71cc-4132-99d7-73eb09328f0d"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("32fec03e-a881-4507-8185-2f93840a1f85"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36066f0f-4c78-4931-9697-68a3f028e5f4"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38636947-a15c-4ac5-87f2-c5f7d59dde89"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38ab9218-325a-4d8e-a1ca-b5b9418399ce"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("39607b52-5356-4a00-b881-457c7331cf7f"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3a6b7405-f44a-4fc6-ad91-32cf9ea813a9"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ca65963-bf0f-479e-8615-1c9261c35f26"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3f5df34f-4158-4604-bc5e-a6890a8f5e62"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4557802a-c102-4271-8edd-6964c763f708"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("48c8a9fd-4fa4-49a5-ba8b-ed6c66d405e8"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("493377ad-4af9-4745-af6f-bb0938f7380a"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b322c34-7531-4dc3-87a7-699fcac13e2f"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b985f2a-a8f0-4284-8049-ab797c50b007"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4fc59692-d09d-44ff-b95b-a0f086c9f20d"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("520fe912-cf91-4cad-86ff-e5001f26fd65"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53d02153-5bf9-4359-b22f-a5e3f99fb208"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54689038-8fce-4cfb-adb3-92dd6e434ae4"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55752402-f178-4396-8fd3-2cb9be19ceb5"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57364fe1-c8b9-4b76-8fcb-9856301ab253"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5a961cae-bd94-4872-ad20-aabfbf3fb587"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5b1d359d-b4d0-4886-b346-24ee990ae0e7"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e0f4632-90c5-4cc7-911c-9142b0d534a1"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ed0db12-166e-4e01-b973-2ad0d1282d4a"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5ff58b16-3ebe-40a8-8945-bb6d802514a4"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63335d7d-7a83-4136-afbd-e9a39123f37d"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6394411a-ec68-4fc6-bd74-eb4bd03db91d"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("63bab991-cabc-4239-8cc3-dc2bcd39959a"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("648b7c2a-4938-4fbf-b8c3-86902201cae5"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65a6faaa-562d-46e7-af75-a2c4be45acae"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65b3cd5f-5c6e-4262-a54d-6ad369ec9481"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("685ddc68-a8af-45d8-8c4f-880f43c9da19"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6e875eb2-b155-4580-bb56-7df47213ca2c"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("710582cb-44de-40c6-9c28-d979696c09c0"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72279ec7-b193-49d3-87f7-8dd4d4e9e30e"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("752b3190-45ba-4e4e-822c-b42eea100f43"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79d6d11f-d91c-4c96-ac55-7751a09fade8"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7bd999b1-9544-4ebd-9f30-9ffced11dda4"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7d6441c8-8409-4187-bfd9-3cdb8be1e50b"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7ec91f97-d4c2-4456-aed8-34e949f29690"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7f08011e-3f60-46ff-88b3-9ecdbc1b3b8c"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("814a3b2b-1da8-49bc-8c0e-120e69ee369c"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8267284e-4f34-4cb0-a7ae-c65f32e7c5fe"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("83dfacad-b85c-4d89-ab7c-ecc94587abab"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8459ebc8-b685-4180-a675-432e2fb10262"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84c8f814-b9f7-44ba-8bbb-f8273def9079"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8776cf58-e85f-4879-8bad-e0a21a325aae"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("87903522-e029-437d-9dce-cf16722d220d"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8805432d-807b-47f2-b540-953780c33b20"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("88404f23-4c7e-4f94-854d-678e0700fedb"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8996b611-7aab-474b-9e10-1a5fc2c984b0"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8c23066a-9e83-4e22-b22c-3f1b5a4b4eb2"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e34c140-bf25-492e-bc7d-2809003dfdc4"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8f1dcad2-16df-4530-8230-f8ca0d5f7bd4"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("903815c6-3418-4a80-aff2-bc7fe6c653ce"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("905bc195-5deb-48d7-a5b2-83070371a6cb"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90821704-f687-4b57-bed5-3ef22b963844"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("974afefe-5df6-426c-b245-26dfc80ffc09"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99ec52a3-50e9-4c1d-af99-a44bb96005b8"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9ab5f51c-4da7-4aaf-9d7a-9257c8a33f55"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9bc47962-e64a-4ccb-95bb-99bace7a8e95"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c1cb535-2399-41eb-8137-c7e82c733dcf"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9c6c1ffa-863e-4dc4-b080-2dace404a895"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f3766e0-0d43-401b-b174-8fc0ca272933"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9f48b87a-316a-4d02-8418-260df46f757d"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a1ebc9a2-04fd-48e9-9c8e-d53a36f7c9df"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a37b8793-afa9-4cb9-ba69-7b61c522b668"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a53b9004-eec2-460f-a6d3-9ae90cefd8a3"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a5477433-eced-4fcf-a920-56297381384e"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a75a963b-7ba0-4c46-93ba-292e4690ef7c"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae869408-7466-499b-a42c-6748c6ae940f"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2218460-5ed2-4056-863a-d2bd67a5f57a"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b3d51955-d2e2-4d89-8e57-89ebe296bed6"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b50fc317-3b2e-4242-bffe-60dca299389a"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b56d7819-6bf5-4a39-a41d-2a64333b3f70"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b60ba5cb-e48c-43dd-a14c-ddc6414f3f5a"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b71fc787-1627-416f-897b-a8fe1b7fc1a5"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b729edc1-c451-46b9-aff6-c902b074af43"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7595d40-fdcd-415f-976c-28950bad0ecd"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b8520ef4-a549-41e0-adde-cf8997868d64"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b95f5356-370e-4577-a54c-d7a6a715ae28"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbd3b69c-3cea-4118-96da-1bd0880d321f"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bcff1be5-f5f3-4e49-918f-c391833d4e71"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be616097-c695-47bb-996a-930a7c9a6275"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be7f079e-8cc6-4600-bd06-64132e815f5b"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bf3a6959-3308-4f30-b643-2d659ebc5385"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3c2b932-be4f-4475-8020-7a1c5466164e"), "B", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5cd6134-56d1-4613-9dd4-a58f976e43e5"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c8174bf4-87a8-41bb-a58d-4eddcea554db"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c94e5f5b-e5e6-4667-a984-055280add61f"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cb5a2d57-2ba7-4566-857b-338d633e7873"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cd5c867f-b909-40ca-a284-0f1751fe8ef3"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d0925d72-d371-4115-906b-35f4721fbb5a"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2484282-5da6-4e24-9e0c-f1408fd1807f"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d8703906-926e-4e65-973f-26fcf8216dff"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dc1d7db7-ba2b-4920-a9b6-153e43176316"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ddc54895-0187-4248-83b7-8a24fb2cad22"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1df94eb-f044-4f6a-9920-7c0cc0499395"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e40340b9-5050-452e-83ba-15ed0dba0465"), "D", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e460dcca-d60e-4c56-a420-c846a80e60ff"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e5475f48-574c-4750-bcaa-2e889b1230ca"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e60d28de-39ec-4e19-b20e-6aad9d3a54c9"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6739499-5287-4c59-9c9e-41bc16cb65a8"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("eff99472-e0d2-46a7-9775-45ea93385ad3"), "I", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f118089a-d76b-446c-8dbf-f82b6345c0b9"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2765836-a200-4245-8173-dce624777a08"), "F", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2ac80c1-f1ea-48e6-bf97-9ff3c1968fe5"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3a70a7e-dd24-45ae-aeac-0e938c13dc82"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f42d9501-e9c1-4689-b604-8f50d6a58db3"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f477b82d-0711-4060-87db-d4b819320a08"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f4abd245-ee36-430f-9581-2083f8a62df5"), "A", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5ed2bc8-5e35-4c36-b51d-b82821dcd4cc"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f74ceaec-69bf-46bb-8de4-f5b99069627d"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f774e99c-178b-44e5-b31f-8e22f15349f7"), "E", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f9d4d4e0-6a53-4f1d-ac15-c045e2683723"), "C", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fabd8e21-eb1d-4c0a-af07-199a3b5bb8d7"), "G", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fcdad6af-53b6-4a56-83da-9157a458079e"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fd7d5810-c327-47cc-8427-2a8c0de6ba9a"), "H", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fe1293fb-0fc2-40f6-8444-c6aeec4b49d8"), "J", null, null, null, null, null, null, null, new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[] { new Guid("851e7bce-ffc3-4cfd-bef6-ee2ebd32582d"), null, null, new DateTime(2024, 12, 15, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1), null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 14, 23, 10, 14, 599, DateTimeKind.Local).AddTicks(9994) });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("df00b7a4-5b44-43a3-b8fe-ff8c7a1ece19"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 15, 1, 9, 14, 600, DateTimeKind.Local).AddTicks(1371), new DateTime(2024, 12, 14, 21, 9, 14, 600, DateTimeKind.Local).AddTicks(1369), new Guid("8662cd58-ad9c-4023-8984-ff54fc4d6fad"), new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1368) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1298f0f0-3988-4d12-afc7-c5a60d51aea1"), new Guid("44d7a7c5-231c-4608-868b-a66820dd79b6"), null, new DateTime(2024, 12, 12, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1200), null, null, null, null, null, 1 },
                    { new Guid("8cff9d91-ee5e-42aa-8452-70a3dea86b26"), new Guid("f565bcab-cad2-4b77-b6f3-565f7d42edea"), null, new DateTime(2024, 12, 12, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1213), null, null, null, null, null, 4 },
                    { new Guid("955b5bdb-e0bc-4de9-9b77-b41f459384bd"), new Guid("5277a5a0-34c4-4343-a210-735577a10e94"), null, new DateTime(2024, 12, 13, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1209), null, null, null, null, null, 3 },
                    { new Guid("abba750b-c1a9-4a17-b26b-2bd961244950"), new Guid("19c2f177-84de-4bcb-be46-54b9e907fe86"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1206), null, null, null, null, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[] { new Guid("0b2d7efc-f825-4e48-92ee-b5c5dd702d8b"), null, null, new DateTime(2024, 12, 16, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(10), null, null, null, null, null, new Guid("2984c609-1a13-4c6d-a85c-49d8f175f2d9"), new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"), 1, new DateTime(2024, 12, 14, 23, 11, 14, 600, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("318ff581-94d3-40b8-a26d-4994643ffb4c"), null, null, null, null, null, null, null, new Guid("2984c609-1a13-4c6d-a85c-49d8f175f2d9"), 2100000m, new Guid("f8437617-4a4a-432d-be7a-63ddcd57c96b"), new Guid("1011f719-95b6-4cbb-bd51-ecebb08b994a"), 2 },
                    { new Guid("85753768-9656-45a2-b04b-84a42a11c7b0"), null, null, null, null, null, null, null, new Guid("c24d288b-a8fc-4a78-ac86-71663975e517"), 3100000m, new Guid("2fe215e1-7327-4476-acc7-a596b65ab5cc"), new Guid("06706a5b-5984-49f8-8edc-56501df6fddc"), 2 },
                    { new Guid("aa6fe455-4e03-4349-9656-49cc3ea32951"), null, null, null, null, null, null, null, new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"), 100000m, new Guid("63019ba3-9c8c-4658-a9bc-85a0545fb87d"), new Guid("27539dde-7f5c-4103-86a3-800bb4744a8a"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("090bfefc-fb3d-4175-b95d-f63502b66791"), null, null, null, null, null, null, null, 60000m, new Guid("f8437617-4a4a-432d-be7a-63ddcd57c96b"), new Guid("edba9acf-365f-4fc0-86be-a48abea6b913"), new Guid("ed82f068-fe15-45d6-9546-33c61b30875c"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("61fdc3e8-003d-470d-b8ef-8e97693448f8"), null, null, null, null, null, null, null, 50000m, new Guid("63019ba3-9c8c-4658-a9bc-85a0545fb87d"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("50b2ed5f-d2bd-471c-85fd-cbaab826c4c9"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1298f0f0-3988-4d12-afc7-c5a60d51aea1"), new Guid("aa6fe455-4e03-4349-9656-49cc3ea32951"), null, new DateTime(2024, 12, 13, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1239), null, null, null, null, null },
                    { new Guid("8cff9d91-ee5e-42aa-8452-70a3dea86b26"), new Guid("318ff581-94d3-40b8-a26d-4994643ffb4c"), null, new DateTime(2024, 12, 12, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1251), null, null, null, null, null },
                    { new Guid("955b5bdb-e0bc-4de9-9b77-b41f459384bd"), new Guid("85753768-9656-45a2-b04b-84a42a11c7b0"), null, new DateTime(2024, 12, 12, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1247), null, null, null, null, null },
                    { new Guid("abba750b-c1a9-4a17-b26b-2bd961244950"), new Guid("318ff581-94d3-40b8-a26d-4994643ffb4c"), null, new DateTime(2024, 12, 13, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1244), null, null, null, null, null },
                    { new Guid("bd16e14e-525d-4a38-83c6-a475b53d7c3d"), new Guid("aa6fe455-4e03-4349-9656-49cc3ea32951"), null, new DateTime(2024, 12, 14, 23, 9, 14, 600, DateTimeKind.Local).AddTicks(1262), null, null, null, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("036bbb82-bf20-498e-8b5a-9aa81a9f2c9d"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("6f6fb26e-f50b-4fdd-bfb0-1137d244177d"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("8344ee73-b85d-4e16-b907-90c708c1b36f"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("8d67362f-88ce-4229-9c51-03231762801b"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("aba7646a-876e-4300-900f-29aaf08a7230"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("f2316e55-7c9c-4e40-9716-1156487d0171"));

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("1298f0f0-3988-4d12-afc7-c5a60d51aea1"), new Guid("44d7a7c5-231c-4608-868b-a66820dd79b6") });

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("8cff9d91-ee5e-42aa-8452-70a3dea86b26"), new Guid("f565bcab-cad2-4b77-b6f3-565f7d42edea") });

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("955b5bdb-e0bc-4de9-9b77-b41f459384bd"), new Guid("5277a5a0-34c4-4343-a210-735577a10e94") });

            migrationBuilder.DeleteData(
                table: "BillCombos",
                keyColumns: new[] { "BillID", "FoodComboID" },
                keyValues: new object[] { new Guid("abba750b-c1a9-4a17-b26b-2bd961244950"), new Guid("19c2f177-84de-4bcb-be46-54b9e907fe86") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("1298f0f0-3988-4d12-afc7-c5a60d51aea1"), new Guid("aa6fe455-4e03-4349-9656-49cc3ea32951") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("8cff9d91-ee5e-42aa-8452-70a3dea86b26"), new Guid("318ff581-94d3-40b8-a26d-4994643ffb4c") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("955b5bdb-e0bc-4de9-9b77-b41f459384bd"), new Guid("85753768-9656-45a2-b04b-84a42a11c7b0") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("abba750b-c1a9-4a17-b26b-2bd961244950"), new Guid("318ff581-94d3-40b8-a26d-4994643ffb4c") });

            migrationBuilder.DeleteData(
                table: "BillTicket",
                keyColumns: new[] { "BillId", "TicketId" },
                keyValues: new object[] { new Guid("bd16e14e-525d-4a38-83c6-a475b53d7c3d"), new Guid("aa6fe455-4e03-4349-9656-49cc3ea32951") });

            migrationBuilder.DeleteData(
                table: "Checkin",
                keyColumn: "ID",
                keyValue: new Guid("92467e89-4a7a-410b-a93b-cf9d61669f14"));

            migrationBuilder.DeleteData(
                table: "Checkin",
                keyColumn: "ID",
                keyValue: new Guid("eb4b75d4-f854-454a-950b-b77f1e5f8abb"));

            migrationBuilder.DeleteData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("2656e75a-4fdc-448f-ac09-c26f4fccdf84"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("22901e4a-efdd-45a0-9026-ab4cb71ba31c"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("2b3d34f7-18ae-46f0-960c-0a6201bacef1"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("32518acf-6328-4659-9258-6561e3257c61"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("3685f5b6-2834-4de5-94cd-f196c69ceb44"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("59b0ca51-aefb-4d4b-ac55-fa8d88d9c2b3"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("6f7c63b7-93f6-470b-a05f-5d1321bdb67a"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("b48b0b21-fa92-4e44-a735-4dcfc6d824e0"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("b633ced0-8837-488b-97b4-8fa32b7b454f"));

            migrationBuilder.DeleteData(
                table: "Countrys",
                keyColumn: "ID",
                keyValue: new Guid("dbd68c17-ea41-425f-844c-1f69fc5fa0d9"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("32a446c3-5d15-4083-b93b-c99378eacc69"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("62ddc6b3-0f21-4594-aab1-b021cd88d031"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("b20463b7-4ad8-4868-8a90-b29dbf9ca606"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("b23f8d29-c708-4e6c-aa66-c4aa14ae82e7"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("b29b0aa3-da1d-4945-b53d-f355d8c00e24"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("0301b89c-1047-4e81-9d5f-15715781209f"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("50406ad3-8c77-4a9e-a627-a7b97f99219f"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("6a79a38f-a058-43f9-8f6f-b86105b4ea5c"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("b787552c-f2e8-46ee-a03d-4fcd30329f80"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("c83255ee-af2b-4d90-8956-3c6d3fffebc9"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("1fc8b0a6-ac46-449d-b7f2-f5d02723e4d9"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("1fe13af5-6468-497a-87f6-a59aa2981c65"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("36760271-e0bc-48c5-b76c-25d9f652ce18"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("856939a3-9418-4b92-bbbf-dcd07d93f04e"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("40a40998-c5a9-4575-8456-16259e610330"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("5267073c-5652-4802-a58a-9343c1f195a7"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("55b1b40c-684f-450a-8d56-33f31437d60f"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("9cc25c7d-7920-4e81-9fcc-b95b817e418d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("ade4b5c4-5741-4174-991f-faafc8a36da9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("b42a47aa-7e82-4a0e-8292-3b50dcc7d44d"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("ee6765d6-07ba-43a8-9e28-5e4309104f45"));

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "ID",
                keyValue: new Guid("17ebd165-bb6a-4efa-9c9f-c7a7f9df5c1d"));

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "ID",
                keyValue: new Guid("a738f58b-4550-45d4-bf1b-84bd2d09e85d"));

            migrationBuilder.DeleteData(
                table: "Point",
                keyColumn: "ID",
                keyValue: new Guid("18d4167f-81f6-4251-b481-50f4f235bb50"));

            migrationBuilder.DeleteData(
                table: "Point",
                keyColumn: "ID",
                keyValue: new Guid("80b3c799-01ae-4731-83d0-36d3c84d170f"));

            migrationBuilder.DeleteData(
                table: "RankMember",
                keyColumn: "ID",
                keyValue: new Guid("7fc822ad-e56a-43b7-ad53-cfe285a0e90b"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("44b07734-4358-4c24-a7fc-c50b4c745a94"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("4825e614-8354-4008-8d14-f5bd15868f5e"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("8d661d4f-87ad-4de1-96af-ba0659d58a4b"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("e3f3b770-d646-421b-9046-7996c4073b95"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0003cabb-b903-4b78-98f8-1017cb58f8c3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0182644f-2648-44cb-a61d-8fa51277ea71"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("036318c4-56ff-4440-811d-5df1d7c20e02"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("037fa924-ebbb-4324-9e62-bfebb991af05"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0428c8f8-cc49-415f-8822-90302327673d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("046998fe-cc5a-4ae5-949a-7be047c366d5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0505f042-eda9-4b27-b17d-0897aa6404ee"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("05a5fa47-41db-45cb-9329-46b78b5608fb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0662febd-31e8-4361-aa1a-2518034f70c9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("07094428-9641-49b7-b65a-11950e038ba3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("073599a1-cad5-40ee-9dec-3e21de302c11"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("08f5137f-f543-4efb-a3cc-f567dfdbce6c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("09bb922a-6936-49cb-a5d0-6671f8135f80"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0a59c56b-0ee8-4ec9-ac6a-a0f7bfaab8ac"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0b4dab6d-f3a7-4aa8-953a-fd2295a0db40"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0bf99806-9bfe-43f4-b56c-6c8123a595b7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0d00cf4f-28fc-4fa7-af6b-a33d4286bbc3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0d04f14e-cbe0-4259-988c-685192b11276"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0eedcec6-e489-4e4d-8680-74228c4f4cfd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("0f2567c0-9abd-410e-b7c2-2d40baf7c918"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("10633c46-6d63-45f9-b12c-d990d1014fbb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("143d3ede-c577-473c-a3ce-bc042cec4351"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("197b4693-83c8-47da-b7b1-aba8fec0e51d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1981656f-e714-40f5-95b4-2a478f469251"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1a13d4f5-72f6-4d53-902e-a56bbecc83bf"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1ac0f6db-206c-4c9f-ac98-16f1489ceabb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1bd4ba1f-0f32-4e8d-8677-a5b4b7768c5b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1c22ee1c-d0dd-4ad0-a271-4543ccba65f4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1d429f53-90ed-4d67-a77f-04c4436257b1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1e770f58-5777-49bf-adba-cf8319ed6d49"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1f1eafbf-f0bc-4b6b-95e7-7f81a9b4d50d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("208006f9-943a-4aac-911c-155f8e60fad9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("20a4d6e3-7cc4-4049-9fd7-4557dcebcb3c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("22c341a1-90cc-4d2e-a063-d59f8f0a6fd9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("23baf82a-c84b-4bc9-a29b-49a254562d50"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("23bc281b-d7ab-43a8-81f5-0e3778e46b57"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("23f3a2c5-8af7-4450-b0c7-91a3015e7223"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("25b80ee3-cb94-4696-a099-4ad06850eb94"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("25ff06a3-e907-4ee1-b814-45104b5772f3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("26080d37-897a-4f97-8a35-929095dc04f2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("26988d8c-574e-4118-b119-8ce8f7d8f0a8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("26d56c54-1940-4f9f-966e-751085ee84f0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("28169e62-1015-490b-a2c5-347e697a2650"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("28c58c77-25c5-4484-a7a7-fa79a919ff0a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("297adf54-7f56-4bb2-a423-baa72221f1d4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("29a98e97-ac7b-40fb-822f-04db246b80d6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("29c75df4-66e5-4a0a-8426-ac93f8574821"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("29d64ca2-7529-4845-b9bc-50193c67fb79"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2a9f3feb-55ac-4377-ade8-9599d44f3df0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2b3e02fd-6185-4cfd-a207-6ff971d3ea5e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2c25b99d-0d44-4b06-8f81-098dd9801e87"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("2c6c37a9-85ed-4b2e-9801-8a07856f93a9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("301ebd1f-8974-4714-89d3-2103d4c70030"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("30374bbc-f79c-4348-8f20-c68c0141416f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3062bdf1-ec77-40a8-8876-960d911f2464"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("30ca80ca-71cc-4132-99d7-73eb09328f0d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("30f24307-703a-4d35-96f6-1aa8d21f2521"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("32fec03e-a881-4507-8185-2f93840a1f85"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("36066f0f-4c78-4931-9697-68a3f028e5f4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("38636947-a15c-4ac5-87f2-c5f7d59dde89"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("38ab9218-325a-4d8e-a1ca-b5b9418399ce"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("39607b52-5356-4a00-b881-457c7331cf7f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3a1bd285-b411-4f7d-bcbf-011e3a30d543"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3a6b7405-f44a-4fc6-ad91-32cf9ea813a9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3b4606cc-3022-4ff9-b270-b17c95d8320b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3ca65963-bf0f-479e-8615-1c9261c35f26"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3e9f37d5-852a-40e2-8935-d8002b07ce3a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("3f5df34f-4158-4604-bc5e-a6890a8f5e62"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4557802a-c102-4271-8edd-6964c763f708"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("469e8c83-7fe0-48c9-87a1-c0b3ed196523"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("46ef28a0-2b20-43d8-a318-a9a5ed4595de"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("482aab09-083e-409c-a520-67f6e5195b5d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("48c8a9fd-4fa4-49a5-ba8b-ed6c66d405e8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("493377ad-4af9-4745-af6f-bb0938f7380a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4b322c34-7531-4dc3-87a7-699fcac13e2f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4b985f2a-a8f0-4284-8049-ab797c50b007"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4bf1d717-74e1-4fec-9aa9-cee48685e3ab"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("4fc59692-d09d-44ff-b95b-a0f086c9f20d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("516c30f7-3de5-4263-89c0-22052c19f485"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("520fe912-cf91-4cad-86ff-e5001f26fd65"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("526134fa-d844-456f-a47a-84bc49cf4248"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("52848e44-53ac-491e-a470-8126b6ff2486"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("53d02153-5bf9-4359-b22f-a5e3f99fb208"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5411d3ff-61d8-4fec-997c-2b823540b025"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("54689038-8fce-4cfb-adb3-92dd6e434ae4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("55752402-f178-4396-8fd3-2cb9be19ceb5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("55b31707-4fee-4cc5-ab30-82e1c1895706"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("57364fe1-c8b9-4b76-8fcb-9856301ab253"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5a8059f4-064f-4c3f-a127-7098cbdeceb8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5a961cae-bd94-4872-ad20-aabfbf3fb587"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5b1d359d-b4d0-4886-b346-24ee990ae0e7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5e0f4632-90c5-4cc7-911c-9142b0d534a1"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5ed0db12-166e-4e01-b973-2ad0d1282d4a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("5ff58b16-3ebe-40a8-8945-bb6d802514a4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6102f93e-666d-416f-904c-52cd51f0a07c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6163fb97-fdab-41ae-9e9b-3505635de83e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("63335d7d-7a83-4136-afbd-e9a39123f37d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6394411a-ec68-4fc6-bd74-eb4bd03db91d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("63bab991-cabc-4239-8cc3-dc2bcd39959a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("648b7c2a-4938-4fbf-b8c3-86902201cae5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("65a6faaa-562d-46e7-af75-a2c4be45acae"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("65b3cd5f-5c6e-4262-a54d-6ad369ec9481"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("67713442-bbef-4391-bf3b-26328d527a3b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("685ddc68-a8af-45d8-8c4f-880f43c9da19"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6db876fe-8859-45f0-81ee-6ad5f9f36f71"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6e875eb2-b155-4580-bb56-7df47213ca2c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("6f65e163-640b-4328-be50-3d4d5a949d3a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("710582cb-44de-40c6-9c28-d979696c09c0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("72279ec7-b193-49d3-87f7-8dd4d4e9e30e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("752b3190-45ba-4e4e-822c-b42eea100f43"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7717ed1d-83eb-4ead-869f-82170261f4dc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("77ecd087-65e4-44d1-a333-83fb05705660"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("79657ba8-8021-4949-bdb0-bf29ee6f4a10"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("79d6d11f-d91c-4c96-ac55-7751a09fade8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7a9bb132-a72b-45b1-9bc1-eb9a5bea3c09"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7ab53f8b-2bd9-447a-b8df-421957e42211"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7bd999b1-9544-4ebd-9f30-9ffced11dda4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7d6441c8-8409-4187-bfd9-3cdb8be1e50b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7ec91f97-d4c2-4456-aed8-34e949f29690"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("7f08011e-3f60-46ff-88b3-9ecdbc1b3b8c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8003dc15-0f5c-4fbd-864b-3151f75f2af6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("814a3b2b-1da8-49bc-8c0e-120e69ee369c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8267284e-4f34-4cb0-a7ae-c65f32e7c5fe"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("83dba46c-7e8a-4e1e-84ce-ef1aa582234a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("83dfacad-b85c-4d89-ab7c-ecc94587abab"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8459ebc8-b685-4180-a675-432e2fb10262"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("84c8f814-b9f7-44ba-8bbb-f8273def9079"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("84dc31c1-363e-4931-b312-f88456496007"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("86905252-bfd5-4281-b644-564945c38e61"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8736c108-d38b-408f-b2b7-1f1ff9e60a27"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8776cf58-e85f-4879-8bad-e0a21a325aae"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("87903522-e029-437d-9dce-cf16722d220d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("87f736d5-c474-4e11-8748-8ac278adf5fc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8805432d-807b-47f2-b540-953780c33b20"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("88404f23-4c7e-4f94-854d-678e0700fedb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8996b611-7aab-474b-9e10-1a5fc2c984b0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8a2d41f4-b04e-46ba-93fb-446d24108d24"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8c11eab4-ab4c-47d0-8db5-70b92c09b265"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8c23066a-9e83-4e22-b22c-3f1b5a4b4eb2"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8e34c140-bf25-492e-bc7d-2809003dfdc4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("8f1dcad2-16df-4530-8230-f8ca0d5f7bd4"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("903815c6-3418-4a80-aff2-bc7fe6c653ce"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("905bc195-5deb-48d7-a5b2-83070371a6cb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("90821704-f687-4b57-bed5-3ef22b963844"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("91bd7cdd-6e9c-4d09-a57b-bedfecb59b8a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9319eb89-7328-4376-bdf7-ea4b99a792cf"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("974afefe-5df6-426c-b245-26dfc80ffc09"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("99ec52a3-50e9-4c1d-af99-a44bb96005b8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9ab5f51c-4da7-4aaf-9d7a-9257c8a33f55"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9b7261c7-5222-44a9-8e0c-ef9d64044721"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9bc47962-e64a-4ccb-95bb-99bace7a8e95"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9be45d18-c1bf-4369-ac13-c135b356d574"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9c1cb535-2399-41eb-8137-c7e82c733dcf"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9c6c1ffa-863e-4dc4-b080-2dace404a895"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9f3766e0-0d43-401b-b174-8fc0ca272933"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("9f48b87a-316a-4d02-8418-260df46f757d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a1ebc9a2-04fd-48e9-9c8e-d53a36f7c9df"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a212d30b-1945-4359-aaf8-dd06cee691d0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a264e020-ad61-44d4-8747-b327343df3bc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a2c7b6f4-fe06-4f0f-9c76-cd99956db4a6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a37b8793-afa9-4cb9-ba69-7b61c522b668"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a5318f9b-b87e-4c0f-8844-6355b779fbd0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a53b9004-eec2-460f-a6d3-9ae90cefd8a3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a5477433-eced-4fcf-a920-56297381384e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a75a963b-7ba0-4c46-93ba-292e4690ef7c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("a992d951-0fea-4d7a-8669-ae585d6bf055"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ac014d7a-8104-4588-a642-ceefb7a43cd6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("acaa181a-e750-4673-928b-7a09a655d987"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("acd5c1c7-04c1-4a3d-810d-57983a72da73"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ad7fdb61-fd5a-4f63-9b08-0d25d83db476"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ae869408-7466-499b-a42c-6748c6ae940f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b04cb7f8-27eb-4f8b-9ba1-427cf7920109"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b2218460-5ed2-4056-863a-d2bd67a5f57a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b284e0d7-1c0f-4848-adc3-61a591ab3331"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b3d51955-d2e2-4d89-8e57-89ebe296bed6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b50fc317-3b2e-4242-bffe-60dca299389a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b56d7819-6bf5-4a39-a41d-2a64333b3f70"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b60ba5cb-e48c-43dd-a14c-ddc6414f3f5a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b71fc787-1627-416f-897b-a8fe1b7fc1a5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b729edc1-c451-46b9-aff6-c902b074af43"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b7595d40-fdcd-415f-976c-28950bad0ecd"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b7ebba10-c927-4bc3-93d0-e9f0359cd946"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b806ca49-0a33-480f-8d75-6079769ca570"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b8520ef4-a549-41e0-adde-cf8997868d64"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b8ad7bbd-45ac-4e30-a49e-dbb498af9afb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("b95f5356-370e-4577-a54c-d7a6a715ae28"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ba683e97-c6ce-4afb-a603-9f489ebe6bc7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bbd3b69c-3cea-4118-96da-1bd0880d321f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bc95bf4e-16d0-46fd-a40f-1906843d7414"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bcff1be5-f5f3-4e49-918f-c391833d4e71"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bd5ee435-b6e6-4577-95aa-9681ab2e8e9c"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("be526e30-5ab4-471b-be26-78c973b1f7c6"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("be616097-c695-47bb-996a-930a7c9a6275"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("be7f079e-8cc6-4600-bd06-64132e815f5b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("bf3a6959-3308-4f30-b643-2d659ebc5385"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c2f4e6aa-f2b5-40e4-8ec9-4acb21d9d9c0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c3c2b932-be4f-4475-8020-7a1c5466164e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c5cd6134-56d1-4613-9dd4-a58f976e43e5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c6370557-29fa-4b9b-9df8-0df94e5d09ed"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c6a6ed83-e438-4215-aaf7-f3b7483b468a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c7a5d80a-15ef-4f8e-9f5e-0063b5bd6df7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c8174bf4-87a8-41bb-a58d-4eddcea554db"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c8912403-6317-435c-bba0-f75b622c4682"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("c94e5f5b-e5e6-4667-a984-055280add61f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("cb5a2d57-2ba7-4566-857b-338d633e7873"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("cd5c867f-b909-40ca-a284-0f1751fe8ef3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d0925d72-d371-4115-906b-35f4721fbb5a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d2484282-5da6-4e24-9e0c-f1408fd1807f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("d8703906-926e-4e65-973f-26fcf8216dff"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("da254a48-861d-4a50-b3db-0eb8616882bf"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("dc1d7db7-ba2b-4920-a9b6-153e43176316"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("dd1615de-e8ca-4696-bfd8-3738c6f1a27f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ddc54895-0187-4248-83b7-8a24fb2cad22"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e1df94eb-f044-4f6a-9920-7c0cc0499395"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e2d79552-c278-4ccf-bc7c-1d6d771bc2e7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e35b0f60-7fc9-4539-8cb0-78c8e9356082"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e3c5863a-699b-43e0-80e1-ef4c4ef39fc0"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e40340b9-5050-452e-83ba-15ed0dba0465"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e460dcca-d60e-4c56-a420-c846a80e60ff"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e5475f48-574c-4750-bcaa-2e889b1230ca"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e60d28de-39ec-4e19-b20e-6aad9d3a54c9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e6739499-5287-4c59-9c9e-41bc16cb65a8"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("e6bc4ff9-23f6-4128-b349-1dd857572c44"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("ef62a5c0-4b03-4b95-9270-d261f42b6163"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("efbf97ca-fbf8-4c22-9fb6-cd87fcfe5d99"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("eff99472-e0d2-46a7-9775-45ea93385ad3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f0d2fc16-2c46-4c27-bcec-6ec8bd757c7f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f118089a-d76b-446c-8dbf-f82b6345c0b9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f2765836-a200-4245-8173-dce624777a08"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f2ac80c1-f1ea-48e6-bf97-9ff3c1968fe5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f3453ec8-10a9-4f5b-93c1-af9acbe4c8fa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f3a70a7e-dd24-45ae-aeac-0e938c13dc82"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f42d9501-e9c1-4689-b604-8f50d6a58db3"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f477b82d-0711-4060-87db-d4b819320a08"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f4abd245-ee36-430f-9581-2083f8a62df5"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f5ed2bc8-5e35-4c36-b51d-b82821dcd4cc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f62dea58-2db0-409c-a97f-ca60e1ba9ba9"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f64021f1-6420-4c68-927d-42cb600a025f"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f6f35df6-1231-4463-8fcf-2aabb0720241"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f74ceaec-69bf-46bb-8de4-f5b99069627d"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f774e99c-178b-44e5-b31f-8e22f15349f7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f8b4e195-a750-46f3-a3d6-815c22b55a51"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("f9d4d4e0-6a53-4f1d-ac15-c045e2683723"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fabd8e21-eb1d-4c0a-af07-199a3b5bb8d7"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fcdad6af-53b6-4a56-83da-9157a458079e"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fd7d5810-c327-47cc-8427-2a8c0de6ba9a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("fe1293fb-0fc2-40f6-8444-c6aeec4b49d8"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("786747a8-e346-4fbc-9719-5a0b5d1334bf"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("c2cb1d61-af94-45fc-81dd-4bc5a61de30a"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("d19b5a27-abf0-4d33-b47c-c8e371c7fd9b"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("e34fd4f6-ab05-4c50-981e-dfdc7b06a21e"));

            migrationBuilder.DeleteData(
                table: "Show_release",
                keyColumn: "ID",
                keyValue: new Guid("0b2d7efc-f825-4e48-92ee-b5c5dd702d8b"));

            migrationBuilder.DeleteData(
                table: "Show_release",
                keyColumn: "ID",
                keyValue: new Guid("851e7bce-ffc3-4cfd-bef6-ee2ebd32582d"));

            migrationBuilder.DeleteData(
                table: "TicketPrice",
                keyColumn: "ID",
                keyValue: new Guid("090bfefc-fb3d-4175-b95d-f63502b66791"));

            migrationBuilder.DeleteData(
                table: "TicketPrice",
                keyColumn: "ID",
                keyValue: new Guid("61fdc3e8-003d-470d-b8ef-8e97693448f8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("27f24726-2ebd-47a5-a582-1673579d8219"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("f95cda12-52a1-4b98-8a51-9252bd47b5a4"));

            migrationBuilder.DeleteData(
                table: "WorkShift",
                keyColumn: "ID",
                keyValue: new Guid("df00b7a4-5b44-43a3-b8fe-ff8c7a1ece19"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("1298f0f0-3988-4d12-afc7-c5a60d51aea1"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("8cff9d91-ee5e-42aa-8452-70a3dea86b26"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("955b5bdb-e0bc-4de9-9b77-b41f459384bd"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("abba750b-c1a9-4a17-b26b-2bd961244950"));

            migrationBuilder.DeleteData(
                table: "Bill",
                keyColumn: "ID",
                keyValue: new Guid("bd16e14e-525d-4a38-83c6-a475b53d7c3d"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("3db234f2-1681-4567-8025-d34bae46c88e"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("54ecb3dd-dfa2-4a1e-b267-2d7bc1855e83"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("19c2f177-84de-4bcb-be46-54b9e907fe86"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("44d7a7c5-231c-4608-868b-a66820dd79b6"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("5277a5a0-34c4-4343-a210-735577a10e94"));

            migrationBuilder.DeleteData(
                table: "FoodCombo",
                keyColumn: "ID",
                keyValue: new Guid("f565bcab-cad2-4b77-b6f3-565f7d42edea"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("405fc976-8e5c-401f-9893-b477e8cf3007"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("c9b11136-8d4c-4c11-85ea-d98b7af232ee"));

            migrationBuilder.DeleteData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("5d4fe878-43df-4fbf-aa12-cabc43d7f664"));

            migrationBuilder.DeleteData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("edba9acf-365f-4fc0-86be-a48abea6b913"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("0a6e19bf-210c-45f1-b99a-1bbfa70dbc63"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("18d6285f-4889-4b72-b4a2-ba3d783cd166"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("6f714c17-4a94-4c8d-a31e-7cb765f99d3d"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("e3b6fb9f-7c4d-486b-99de-c11a19f46fa3"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ID",
                keyValue: new Guid("318ff581-94d3-40b8-a26d-4994643ffb4c"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ID",
                keyValue: new Guid("85753768-9656-45a2-b04b-84a42a11c7b0"));

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "ID",
                keyValue: new Guid("aa6fe455-4e03-4349-9656-49cc3ea32951"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("4745c825-c8c6-4edf-94f2-63635792d615"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("77befdab-a933-4095-b17d-62dd9f81dc3c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("856046e2-c09d-44d2-a4bb-9c1a1d69afac"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c0ceddb5-dc6a-4de7-be5b-680be163fb60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("dbf2b65d-e65c-40ed-bf97-5cd02d0d0166"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("2984c609-1a13-4c6d-a85c-49d8f175f2d9"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("c24d288b-a8fc-4a78-ac86-71663975e517"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("2fe215e1-7327-4476-acc7-a596b65ab5cc"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("63019ba3-9c8c-4658-a9bc-85a0545fb87d"));

            migrationBuilder.DeleteData(
                table: "Screening",
                keyColumn: "ID",
                keyValue: new Guid("f8437617-4a4a-432d-be7a-63ddcd57c96b"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("06706a5b-5984-49f8-8edc-56501df6fddc"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("1011f719-95b6-4cbb-bd51-ecebb08b994a"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "ID",
                keyValue: new Guid("27539dde-7f5c-4103-86a3-800bb4744a8a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("7e280cd0-a6fa-4ecc-b814-ba1b1098ea78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("8662cd58-ad9c-4023-8984-ff54fc4d6fad"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("ab7b8bcb-a18f-4cb6-883a-95d648d4ce85"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("b286c02d-0296-40cc-9a19-d17e5ea949c1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: new Guid("c12e4ec8-796e-4a23-aff5-bade30866158"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("a54e0e2d-fd0a-44f4-8396-1c232b27ea22"));

            migrationBuilder.DeleteData(
                table: "Director",
                keyColumn: "ID",
                keyValue: new Guid("eea3261b-aecb-467b-bf5e-564e554c0549"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("5c1ff9a7-9f37-4bfc-915f-819537eec9da"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "ID",
                keyValue: new Guid("b6a642f1-e756-4b20-9db2-d345f10577e2"));

            migrationBuilder.DeleteData(
                table: "Lenguage",
                keyColumn: "ID",
                keyValue: new Guid("d10dd9a7-c2a9-4f8e-887c-b24a3a4a31e0"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: new Guid("917a062d-d62f-4a41-b26b-c3edd9550dec"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("45ebf83a-0e8e-4185-9cec-649b9d974772"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("50b2ed5f-d2bd-471c-85fd-cbaab826c4c9"));

            migrationBuilder.DeleteData(
                table: "ShowTimes",
                keyColumn: "ID",
                keyValue: new Guid("ed82f068-fe15-45d6-9546-33c61b30875c"));

            migrationBuilder.InsertData(
                table: "Checkin",
                columns: new[] { "ID", "Code", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "TicketID", "TicketsID", "Type" },
                values: new object[,]
                {
                    { new Guid("6ee53d14-7c37-48c3-8a63-cd605e11db2e"), "hgdsad", null, null, null, null, null, null, null, "hotdsot", new Guid("0113e16f-3c57-40bb-a790-b8a726358762"), null, "mua tại quầy" },
                    { new Guid("eecb1091-aef2-4c33-aa86-13cf339f8623"), "phonghhhhh", null, null, null, null, null, null, null, "hotdot", new Guid("56336b15-1668-4323-9296-3eebea21bb4b"), null, "mua tại quầy" }
                });

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "ID",
                keyValue: new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4675));

            migrationBuilder.InsertData(
                table: "Cinemas",
                columns: new[] { "ID", "ClosingHours", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Location", "ModifiedBy", "ModifiedTime", "Name", "OpeningHours", "PhoneNumber", "RoomNumber", "WebSite" },
                values: new object[] { new Guid("e6b9514d-bd8b-4208-a0bf-cc959584c820"), "11:00 PM", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4682), null, null, null, "Đà Nẵng", null, null, "Cinema B", "09:00 AM", "0987654321", 7, "www.cinemab.com" });

            migrationBuilder.InsertData(
                table: "Countrys",
                columns: new[] { "ID", "CountryName" },
                values: new object[,]
                {
                    { new Guid("0580bc5e-00d8-4995-8ace-2fa68d36b8c3"), "Hồng Kông" },
                    { new Guid("2d65e2b9-64e9-44ed-a71b-5c4400818ed3"), "Mỹ" },
                    { new Guid("3269540f-bc84-42d9-8744-93690e47cf30"), "Vương Quốc Anh" },
                    { new Guid("51b06880-1e62-4579-89da-4e10336be08a"), "Pháp" },
                    { new Guid("59083b3f-9a46-463c-a52a-4c2c970067e0"), "Ấn Độ" },
                    { new Guid("85ca10bd-4aa3-42a9-a2cb-2169dce44572"), "Úc" },
                    { new Guid("b991e10d-8380-469d-9bac-efa369335868"), "Trung Quốc" },
                    { new Guid("c580e187-3d5b-41d9-aee8-e33b1b7cd0e1"), "Hàn Quốc" },
                    { new Guid("e25e2df8-7a41-417f-a1cb-0d7c9a525056"), "Việt Nam" }
                });

            migrationBuilder.InsertData(
                table: "Director",
                columns: new[] { "ID", "Address", "Biography", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "FullName", "Gender", "ModifiedBy", "ModifiedTime", "Nationality", "Status" },
                values: new object[,]
                {
                    { new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"), "TP Hồ Chí Minh", "Ca sĩ, đạo diễn nổi tiếng với loạt phim hành động 'Lật Mặt' thu hút hàng triệu khán giả.", null, null, null, null, null, "Lý Hải", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("18c79da6-999d-449e-b8b1-a81917290412"), "Hà Nội", "Đạo diễn và diễn viên nổi tiếng với các bộ phim hài và tình cảm như 'Siêu Sao Siêu Ngố'.", null, null, null, null, null, "Đỗ Đức Thịnh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("41a51549-cbf5-4498-aeb2-435292366172"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim kinh dị và ly kỳ như 'Thiên Mệnh Anh Hùng', 'Mắt Biếc'.", null, null, null, null, null, "Victor Vũ", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("8d52e906-9bb3-439f-a94d-ba592cc94458"), "Hà Nội", "Đạo diễn nổi tiếng với các bộ phim lãng mạn và hài như 'Bỗng Dưng Muốn Khóc'.", null, null, null, null, null, "Vũ Ngọc Đãng", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("9a7745fe-edf3-4760-8c00-3f31de981a94"), "Cần Thơ", "Đạo diễn kiêm diễn viên nổi tiếng với các bộ phim hành động và lịch sử.", null, null, null, null, null, "Huỳnh Đông", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"), "Hồ Chí Minh", "Diễn viên, nhà sản xuất và đạo diễn nổi tiếng với các bộ phim hành động như 'Hai Phượng'.", null, null, null, null, null, "Ngô Thanh Vân", "Nữ", null, null, "Việt Nam", 1 },
                    { new Guid("f1505424-c963-4e6c-93e0-57c713732b8d"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim như 'Em Là Bà Nội Của Anh'.", null, null, null, null, null, "Phan Gia Nhật Linh", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"), "TP Hồ Chí Minh", "Đạo diễn kiêm nhà sản xuất phim nổi tiếng với các bộ phim hài hành động như 'Để Mai Tính', 'Tèo Em'.", null, null, null, null, null, "Charlie Nguyễn", "Nam", null, null, "Việt Nam", 1 },
                    { new Guid("f707fb95-e498-4e37-b094-454dbc1a4667"), "Hồ Chí Minh", "Đạo diễn nổi tiếng với các bộ phim hài hước và tình cảm như 'Nụ Hôn Thần Chết'.", null, null, null, null, null, "Nguyễn Quang Dũng", "Nam", null, null, "Việt Nam", 1 }
                });

            migrationBuilder.InsertData(
                table: "FoodCombo",
                columns: new[] { "ID", "Content", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "Images", "ModifiedBy", "ModifiedTime", "Quantity", "TotalPrice" },
                values: new object[,]
                {
                    { new Guid("05532b57-9e63-4346-80c3-a8e52c63f41d"), "Combo 1", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6350), null, null, null, "1 bắp 1 cola", "tải xuống.jfif", null, null, 1, 100000m },
                    { new Guid("1bebaaa3-d36d-4425-8257-d0cd5653eed2"), "Combo 2", null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6357), null, null, null, "2 bắp 2 cola", "tải xuống.jfif", null, null, 2, 150000m },
                    { new Guid("72f07a1f-568f-45a5-8754-882aa8f6437c"), "Combo 3", null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6363), null, null, null, "1 bắp bơ + 2 cola", "tải xuống.jfif", null, null, 3, 120000m },
                    { new Guid("9d16fbb6-2377-401d-8f47-8a232b98a371"), "Combo 4", null, new DateTime(2024, 12, 11, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6367), null, null, null, "2 bắp bơ 2 cola", "tải xuống.jfif", null, null, 4, 200000m }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "GenreName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"), null, null, null, null, null, "Hành động", null, null },
                    { new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"), null, null, null, null, null, "Tình cảm", null, null },
                    { new Guid("5341aac1-d5e5-49ff-8490-b8bf8ab33e67"), null, null, null, null, null, "Lãng mạn", null, null },
                    { new Guid("58b299f8-425f-453b-be54-5961427be7d9"), null, null, null, null, null, "Kinh dị", null, null },
                    { new Guid("74904160-7f95-4b64-8306-792190d835a3"), null, null, null, null, null, "Hoạt hình", null, null },
                    { new Guid("95007f6e-8043-409e-aa59-18e21c112e13"), null, null, null, null, null, "Tâm lý", null, null },
                    { new Guid("c91817a4-9e1b-48d9-82d4-647d2f04e8e0"), null, null, null, null, null, "Hài hước", null, null },
                    { new Guid("ca033979-d36e-4d4e-bf8a-61ac114f2d76"), null, null, null, null, null, "Khoa học viễn tưởng", null, null },
                    { new Guid("d20162d0-4898-4c09-a78f-e6dd5736676c"), null, null, null, null, null, "Phiêu lưu", null, null }
                });

            migrationBuilder.InsertData(
                table: "Lenguage",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "LanguageName", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("46b4c3d1-aa68-4607-901d-c3f0af508fd3"), null, null, null, null, null, "Korea", null, null },
                    { new Guid("79e57ee8-3f28-43f9-b5d0-96df7674f38b"), null, null, null, null, null, "VIE", null, null },
                    { new Guid("82edbda1-bc4c-4a7c-b42b-1cc7a1f0532e"), null, null, null, null, null, "JPN", null, null },
                    { new Guid("8e05f530-e4fd-4723-98ad-dc4928cff696"), null, null, null, null, null, "USA", null, null },
                    { new Guid("bf1fa6c8-b068-4809-b30f-69ad579df588"), null, null, null, null, null, "ThaiLans", null, null }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("194a7588-fbc4-450e-b8dc-0b2dfdce3b81"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5880), null, null, null, "Hành trình sinh tồn đầy kịch tính trong khu rừng bí ẩn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 115, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "rungthemanh.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Rừng Thế Mạng 2", new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=rungthemanh-trailer" },
                    { new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), 16, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5757), null, null, null, "Hành trình cảm động về tình cha con giữa Sài Gòn.", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 130, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "0e9f825c-5346-44f1-a94d-7078909ce83a.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Bố Già 2", new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=bogia2-trailer" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "QRCode", "Status" },
                values: new object[,]
                {
                    { new Guid("8cbd081b-ec8a-46e5-b966-f311baf02366"), null, null, null, null, null, null, null, "Credit Card", "hh2", 1 },
                    { new Guid("ec2aebea-b86a-4ea2-aaa7-642c30952b19"), null, null, null, null, null, null, null, "Cash", "mskt3", 1 }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(2745));

            migrationBuilder.UpdateData(
                table: "Room",
                keyColumn: "ID",
                keyValue: new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4720));

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "ID", "CinemasId", "ColumnNumber", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Name", "RowNumber", "SeatingCapacity", "Status" },
                values: new object[] { new Guid("11714696-0dc6-4369-927e-4300aeb42515"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 12, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4728), null, null, null, null, null, "Room 2", 12, 150, 1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0aa0f49f-8196-4532-bc67-50d8774aab9e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e653c5d-d2ee-4a04-b798-4b059b7b50ac"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0fa73f1b-3b55-4db2-95e4-e72aa29ea8cd"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10bded72-6524-4b1a-9c3b-26525d68b56c"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("116e3aa8-e0b9-4d61-a2f0-d48ad61d248b"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("11e34a1a-a396-47df-b255-95e4ff21020b"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("12e9e87f-5fcc-423c-b4eb-5cd989cc8d7b"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15114317-8b62-484c-bb6c-17df847a466e"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15b02569-5c1c-44b4-b3b9-4c8f3a574d76"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("160f357a-d1bb-406d-9bab-213e68279545"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1a604720-1443-4076-a453-41972b656784"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b8b98c6-5fda-4553-869f-04489deb7b3c"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1b9666da-5ddd-4684-840d-77f9fc6ace49"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2405a779-9e91-480d-a2fa-6c274d1a792c"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("24124c12-0187-4b9f-a2aa-113bddc63ada"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25a17765-5d47-43db-8f0c-367a5ecf7762"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("26932824-891d-4604-b9b1-d9b732c308a7"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("27c11fe1-f393-49ce-ae45-a11fb3e9c9c1"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("29ad314b-55af-4392-90ab-d35e2f64c072"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2c6edc47-c83e-4b33-beca-ff1ba70e9937"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2d209567-a1cc-498a-94c3-275a9333e66f"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f22da55-f305-4690-b09d-6f5f3e556f70"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3658a694-f31f-4ed1-a2da-14d8b36388d2"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("36693146-0a77-42a1-ab52-5c15a642ddb5"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b328b75-3ddf-4dac-adc9-7266bc96707e"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ca2663b-7cde-4de9-8bf4-12ff83181d63"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3ecc80e3-d267-42bd-ba74-fc017ab1b3c1"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("43682ad2-86a8-470f-94a4-47126b949e88"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("46ff4781-7561-463e-af68-5762bbc0ef66"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("49211a1a-fa8a-4360-b06b-cf366108267c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4a58bcff-b638-4241-a046-20df7b6ce01d"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4eda1d35-09bd-4039-b181-79f152fade32"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("53919fc2-a477-42df-a5a6-b2a09e520f42"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5c734282-31cf-4716-84ef-ca9dd6723795"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6022f202-52b2-4ed7-b024-2d3c02885211"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("61c097d1-a9e5-49ab-890d-3e91c5bcf3e9"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("62b61f89-06ce-499b-935f-0c9d0b53c96c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("67f1045a-3dd4-4d46-ab8c-22fdc49fec94"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("692539c1-c5ed-4134-a7b5-bfc31f206722"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6972c5bb-8612-4caf-8fcf-327ffa0e0ad2"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6c06db39-d7dd-4a56-8751-0baf0ac2b2f3"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6cb903f7-657b-4080-8e52-0d32d95ac81e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("73b6fbbd-270a-448e-99ab-ef87c02b422c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("758f356a-12c1-44d0-9e43-770220da0f24"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("77da2675-3f82-4468-b83d-88111c42a200"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78f1e655-91ae-4f1c-a0b1-6433624e85c2"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("79b97a9d-e2b4-47d4-9e28-e7410b009fe5"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7fa4ad10-5ed5-4e96-81e7-b000f067442e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("820e8112-102a-4c4b-a074-c7ce2bea429b"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("82968295-af4d-4a24-bc0e-05ce83cffa56"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8992eae4-a624-4864-936e-a5a25e9a7fc4"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b20abe5-5714-44ac-962c-f730b4c39ea0"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b31f670-6bb1-4527-9e7f-3d3531e3f05c"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b459da5-e1a5-4117-ae8b-64051443ecb8"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e4f1df6-0a70-475b-9f04-14ba3a12867f"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8e69ec79-2ed6-46cd-8eb7-2c6b13df3f99"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("91eccb5a-f459-4d49-8d1e-e440cc25c675"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("93b021af-e4df-402d-9cb8-eaa0c47d5a2e"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("94056fa2-a4ff-4263-a6da-1cd0b66df25c"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("991728f7-e127-4906-8874-fa9ad82f21b5"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9cd5a829-e5b9-43c1-89f4-27f6c0be5bd2"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d29014c-6b11-401e-9e5c-ea0978045630"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9dce3f75-c2b9-400a-98f7-f6909b514d00"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a41ad284-79aa-436b-97ae-e3c63088da43"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a56972ab-16b5-4cdf-bffe-f7b2ad81dc57"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a624bf01-d257-4e77-8061-73814545eb5a"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a82f4627-f44f-4cca-977d-c56ba0e6d3f5"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("accc46d4-43c8-40af-bb51-745b95434fc7"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af27dc5d-a8cc-46cb-bc7e-d342b5441407"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("af6c7f74-a191-45f0-8d39-146af98f48fd"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2d6b9a5-4527-4eae-98aa-acc626a55134"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2f7a370-4dee-44a2-95fd-8cd103b041a5"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b7a28afa-5e8d-4c2e-8904-639afa1779df"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b9ef45a4-026a-4db3-b859-3583e70345e1"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbcd147f-cbef-4000-b13f-0aa6d4ba8516"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("be9f27f1-98b0-452d-844d-c9d6d1ef9efd"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c01a50ce-bcd3-4fdd-9967-ac5e7989e288"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0e818a6-d164-46f8-8bf4-fff12fec60e6"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3088f6a-191a-49f4-9560-8a56edca8b7f"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c5f81c59-2add-4a0e-829a-5d8e833008a4"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7fc7ef9-f158-4134-9494-c75c558a5b91"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cc81b986-bd9e-40d1-89e4-84451fc1c30e"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d465be8d-fed2-486e-b647-a3fbef466fca"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d469dd17-d164-41e5-97dc-4da723ce441a"), "E", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d48682ef-8404-4b27-822f-71f3f15e6bd6"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9ee1b5d-2cb9-473d-b0b5-8a8fb95410fe"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dce7c810-6469-41e1-a275-817287368179"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd7d6971-fd6a-42c5-8fc6-1df41657ab50"), "I", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("de44b01b-c87a-404a-8b69-3adf04c12ffe"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e18f5f14-e759-40ca-a4d0-a07f6cad8346"), "C", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e1fef5e8-b126-45c3-a153-75f7f74d4fbf"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e6a17191-235f-4e75-b795-3101fac183a2"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea93f4df-b587-4009-9dcb-bbeaa4090ff1"), "G", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ea9a6357-0ddf-4869-b00a-b532ee214e25"), "B", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed27dfb3-2762-4ec6-804e-d52a21b48691"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f433cb19-f6e8-4a80-85bf-c19d8d33ad15"), "F", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f48714f4-3172-462f-8e88-451ec858f10f"), "J", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f49c0dbf-8f8b-4600-9ec3-ac7637e22814"), "D", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f5ffe0c2-0e7c-4d8a-9ca2-1005ad926dbe"), "A", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fdfafe34-ad08-4df1-8707-a394fb05675c"), "H", null, null, null, null, null, null, null, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "SeatType",
                keyColumn: "ID",
                keyValue: new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"),
                column: "CreatedTime",
                value: new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.InsertData(
                table: "SeatType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "SeatTypeName" },
                values: new object[,]
                {
                    { new Guid("014c866d-d5ee-48c8-a990-36f25b611283"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4635), null, null, null, null, null, "Ghế Vip" },
                    { new Guid("c8eabc76-e12d-4442-9ea1-595f07a64610"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4641), null, null, null, null, null, "Ghế đôi" }
                });

            migrationBuilder.InsertData(
                table: "ShowTimes",
                columns: new[] { "ID", "EndTime", "StartTime", "Status" },
                values: new object[,]
                {
                    { new Guid("1f7d5e68-d263-4b69-b6ef-dae69b104d82"), new TimeSpan(0, 1, 45, 0, 0), new TimeSpan(0, 23, 45, 0, 0), 1 },
                    { new Guid("2285f27a-ffdd-42ab-9f26-d2c70ba0ae00"), new TimeSpan(0, 21, 15, 0, 0), new TimeSpan(0, 19, 15, 0, 0), 1 },
                    { new Guid("424c07b0-8c6c-489b-b129-9198baaf52ee"), new TimeSpan(0, 14, 30, 0, 0), new TimeSpan(0, 12, 30, 0, 0), 1 },
                    { new Guid("65701a83-4e06-419e-b519-69bd6873b439"), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 17, 0, 0, 0), 1 },
                    { new Guid("9904c940-e1db-4000-9d77-08ae3963ae79"), new TimeSpan(0, 6, 30, 0, 0), new TimeSpan(0, 4, 30, 0, 0), 1 },
                    { new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"), new TimeSpan(0, 12, 15, 0, 0), new TimeSpan(0, 10, 15, 0, 0), 1 },
                    { new Guid("e61149fd-7e1d-49ea-b988-acfc50e33f24"), new TimeSpan(0, 16, 45, 0, 0), new TimeSpan(0, 14, 45, 0, 0), 1 },
                    { new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"), new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 8, 0, 0, 0), 1 },
                    { new Guid("f1f2041c-2880-48c3-a9f5-7951fddc53ed"), new TimeSpan(0, 4, 0, 0, 0), new TimeSpan(0, 2, 0, 0, 0), 1 },
                    { new Guid("f41dd84a-fe43-4246-ad3c-5081968f1639"), new TimeSpan(0, 23, 30, 0, 0), new TimeSpan(0, 21, 30, 0, 0), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Adderss", "CreatedBy", "CreatedTime", "DateOrBriht", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "Gender", "Images", "ModifiedBy", "ModifiedTime", "PassWord", "PhoneNumber", "RoleID", "Status" },
                values: new object[,]
                {
                    { new Guid("05955192-97e1-4613-856d-55491351cb48"), "TP. Hồ Chí Minh", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3879), new DateTime(1988, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "tungtran@gmail.com", "Trần Văn Tùng", true, "images/tung.jpg", null, null, "xagxKy3yHdGahKbyqOPTVw==", "0904123459", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("1edfe016-5fdd-44b4-b5ff-4b30c2d80234"), "Bắc Ninh", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3972), new DateTime(1990, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hungdo@gmail.com", "Đỗ Văn Hùng", true, "images/hung.jpg", null, null, "Vkp09BaAl5Z37bxssT1cgw==", "0906123461", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("20292962-8107-4547-90e9-01cbc8f79676"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3653), new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Hà Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("5279817e-f995-4a90-9df9-fa1f5abecaaa"), "Đà Nẵng", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3798), new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "thule@gmail.com", "Lê Thị Thu", false, "images/thu.jpg", null, null, "/0Hc+nV2EW4k7MbQwLea9w==", "0903123458", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("58db499c-91bd-4f84-a40c-0cba27f8f64a"), "Nam Định", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4151), new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "longle@gmail.com", "Lê Văn Long", true, "images/long.jpg", null, null, "RGkuvbVVFkKr2zs5agYGGA==", "0909123464", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("c21907e4-9a32-4663-9733-151d9baf031f"), "Hưng Yên", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4075), new DateTime(1994, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "hanhtran@gmail.com", "Trần Thị Hạnh", false, "images/hanh.jpg", null, null, "ysdNmRQJyatHr9hMky+o8w==", "0908123463", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd"), "Hà Nội", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3003), new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "mainguyen@gmail.com", "Nguyễn Thị Mai", false, "images/mai.jpg", null, null, "EqeaomOi6gtQioc0nIFCyg==", "0901123456", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("d9d09c89-2e79-438f-9c87-e78d20675314"), "Quảng Ninh", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4245), new DateTime(1997, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "ngocpham@gmail.com", "Phạm Thị Ngọc", false, "images/ngoc.jpg", null, null, "D7J1Ybv5ywfP4cyEongXOg==", "0910123465", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84"), "Nghệ An", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3929), new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "lanvu@gmail.com", "Vũ Thị Lan", false, "images/lan.jpg", null, null, "/yeXzzHJiJ8+12Q8V6mtSg==", "0905123460", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fc76638d-ef88-4d3f-ab7d-eed8c6e5b636"), "Thái Bình", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(4013), new DateTime(1985, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "binhnguyen@gmail.com", "Nguyễn Văn Bình", true, "images/binh.jpg", null, null, "dxri5kOk5FKRX1mmazryVA==", "0907123462", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("fe6b1b3f-ead7-443d-a247-051232a6f562"), "Hải Phòng", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(3727), new DateTime(1992, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, "nampham@gmail.com", "Phạm Văn Nam", true, "images/nam.jpg", null, null, "XZ7f/wWy3TkvPK4xrHeSuA==", "0902123457", new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "ID", "BillCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "PaymentMethodID", "Status", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), "BILL004", null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6704), null, null, null, null, null, null, 2, 200000m, new Guid("5279817e-f995-4a90-9df9-fa1f5abecaaa") },
                    { new Guid("375e4e5e-35a9-4915-ba0c-b4c29d7dcb40"), "BILL005", null, new DateTime(2024, 12, 11, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6710), null, null, null, null, null, null, 2, 250000m, new Guid("05955192-97e1-4613-856d-55491351cb48") },
                    { new Guid("3e91529c-8a0a-454f-b2bd-12a1ff581b71"), "BILL008", null, new DateTime(2024, 12, 4, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6740), null, null, null, null, null, null, 2, 450000m, new Guid("fc76638d-ef88-4d3f-ab7d-eed8c6e5b636") },
                    { new Guid("60ac2f1c-5dcb-42e6-8361-3753b63b6b94"), "BILL009", null, new DateTime(2024, 12, 6, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6749), null, null, null, null, null, null, 0, 350000m, new Guid("c21907e4-9a32-4663-9733-151d9baf031f") },
                    { new Guid("782cb184-268d-423e-a361-c9276edb73c0"), "BILL0122", null, new DateTime(2024, 12, 10, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6722), null, null, null, null, null, null, 2, 680000m, new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84") },
                    { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), "BILL003", null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6697), null, null, null, null, null, null, 3, 150000m, new Guid("fe6b1b3f-ead7-443d-a247-051232a6f562") },
                    { new Guid("857b4547-4fe9-4b3e-a2b8-fb9ec4a28bf6"), "BILL010", null, new DateTime(2024, 12, 8, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6754), null, null, null, null, null, null, 2, 700000m, new Guid("58db499c-91bd-4f84-a40c-0cba27f8f64a") },
                    { new Guid("990de630-49bc-41d2-84a6-72321ed83140"), "BILL006", null, new DateTime(2024, 12, 10, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6717), null, null, null, null, null, null, 2, 600000m, new Guid("f127af54-7b1e-47af-9e47-78b32b5e8d84") },
                    { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), "BILL002", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6691), null, null, null, null, null, null, 2, 300000m, new Guid("20292962-8107-4547-90e9-01cbc8f79676") },
                    { new Guid("a286d6bf-dda3-4df9-a177-4282a0abc273"), "BILL007", null, new DateTime(2024, 12, 9, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6735), null, null, null, null, null, null, 1, 800000m, new Guid("1edfe016-5fdd-44b4-b5ff-4b30c2d80234") },
                    { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), "BILL001", null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6676), null, null, null, null, null, null, 2, 500000m, new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "AgeAllowed", "CountryID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Description", "DirectorID", "Duration", "GenreID", "Images", "LenguageID", "ModifiedBy", "ModifiedTime", "Name", "StarTime", "Status", "Trailer" },
                values: new object[,]
                {
                    { new Guid("336e0a18-355c-466a-8233-e15f6389c966"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5805), null, null, null, "Cuộc sống đầy biến động của một gia đình truyền thống Việt.", new Guid("41a51549-cbf5-4498-aeb2-435292366172"), 110, new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"), "100f852c-f5b4-43f0-8560-84ab0b42b9b9.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Nhà Bà Nữ", new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=nhabanu-trailer" },
                    { new Guid("41056346-3a8e-4010-bf53-f55417208f99"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5785), null, null, null, "Những mâu thuẫn căng thẳng giữa các băng nhóm trong thế giới ngầm.", new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"), 120, new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"), "161cd6ca-380d-4627-8071-2d5af03a1cf2.png", new Guid("79e57ee8-3f28-43f9-b5d0-96df7674f38b"), null, null, "Chị Mười Ba: Cuộc Chiến Nhân Tình", new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=chimuoiba-trailer" },
                    { new Guid("57622f9c-9054-4523-96fe-eab9b1dd7110"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5950), null, null, null, "Phiên bản Việt của Người Nhện với những pha hành động gay cấn.", new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"), 145, new Guid("58b299f8-425f-453b-be54-5961427be7d9"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Người Nhện Việt Nam", new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=nguoinhenvietnam-trailer" },
                    { new Guid("828c8a68-6beb-4349-9560-e17d67529e83"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5897), null, null, null, "Câu chuyện tình yêu đầy lãng mạn và cảm động của Trịnh Công Sơn.", new Guid("0efc290f-8a6e-4337-a938-b6fb20ed55a3"), 150, new Guid("4a7778e6-1326-40e2-b9c1-54db44174fcf"), "5b626704-f3d1-482f-b77c-903284966efa.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Em Và Trịnh 2", new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=emvatrinh-trailer" },
                    { new Guid("b78712ac-6542-4a0a-9abe-366d223242dd"), 18, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5858), null, null, null, "Bữa tiệc đầy những bí mật được phơi bày qua trò chơi mạo hiểm.", new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"), 125, new Guid("74904160-7f95-4b64-8306-792190d835a3"), "2d2a89fa-61c6-4662-a2de-ab4b337c88d7.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Tiệc Trăng Máu 2", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=tiectrangmau-trailer" },
                    { new Guid("c4e09c95-5f67-4090-80a8-2b022bd875c7"), 12, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5915), null, null, null, "Tiếp tục câu chuyện tình yêu day dứt giữa Ngạn và Hà Lan.", new Guid("41a51549-cbf5-4498-aeb2-435292366172"), 130, new Guid("11187fb2-f4a3-4c9b-9836-1917a0ec9ccd"), "7502d22a-c967-400c-bc8c-3062d00c7fcc.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Mắt Biếc 2", new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=matbiec-trailer" },
                    { new Guid("dfb06127-4c7c-40a8-ac0e-f0f7eb017f03"), 15, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5841), null, null, null, "Cuộc sống sang chảnh và những bí mật động trời của giới thượng lưu.", new Guid("f6295612-dc9a-4d32-9d51-b74e27d23640"), 140, new Guid("58b299f8-425f-453b-be54-5961427be7d9"), "11d330e9-7ab3-49d6-bb78-0ab3acabf6cf.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Gái Già Lắm Chiêu 6", new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "https://www.youtube.com/watch?v=gaigialamchieu-trailer" },
                    { new Guid("f1f48ad0-9552-4f47-a773-c531beae1955"), 13, new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(5995), null, null, null, "Những câu chuyện tình yêu lãng mạn tại Sài Gòn mưa rơi.", new Guid("a801a90b-c768-4522-a6a2-aea4490668f6"), 100, new Guid("74904160-7f95-4b64-8306-792190d835a3"), "96cc9263-2adb-46f1-a015-fe0a18c4b781.png", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), null, null, "Sài Gòn Trong Cơn Mưa 2", new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "https://www.youtube.com/watch?v=saigonmuaroi-trailer" }
                });

            migrationBuilder.InsertData(
                table: "Point",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateEarned", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "TotalPoint", "UserID" },
                values: new object[,]
                {
                    { new Guid("619f405a-f47c-41b5-a8f1-b5a807c6ba56"), null, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6940), null, null, null, null, null, 50, new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd") },
                    { new Guid("a72e6123-44c9-4559-b210-944fd2e2b5b5"), null, null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6946), null, null, null, null, null, 150, new Guid("20292962-8107-4547-90e9-01cbc8f79676") }
                });

            migrationBuilder.InsertData(
                table: "RankMember",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "MinPoint", "ModifiedBy", "ModifiedTime", "Rank", "StarDate", "Status", "UserID" },
                values: new object[] { new Guid("c95ed77a-48a9-4a32-b504-c0b69a4b193a"), null, null, null, null, null, 100.0, null, null, "Gold", new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6913), 1, new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd") });

            migrationBuilder.InsertData(
                table: "Screening",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "ShowDate", "ShowTimeID", "Show_releaseID", "Status" },
                values: new object[,]
                {
                    { new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6099), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 24, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6095), new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"), null, 0 },
                    { new Guid("267ea482-5c2f-4c1c-8ff2-d48590b3c64d"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6141), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 19, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6138), new Guid("2285f27a-ffdd-42ab-9f26-d2c70ba0ae00"), null, 0 },
                    { new Guid("2caba10d-d2f4-45e7-86ba-d2db43c36874"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6129), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 20, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6126), new Guid("65701a83-4e06-419e-b519-69bd6873b439"), null, 0 },
                    { new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6108), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 23, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6104), new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"), null, 0 },
                    { new Guid("84dbc11c-dadb-48e3-a267-d825c94efaf9"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6122), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 21, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6120), new Guid("e61149fd-7e1d-49ea-b988-acfc50e33f24"), null, 0 },
                    { new Guid("e4d0f32d-8946-415a-962e-695e55519a0a"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6115), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 22, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6112), new Guid("424c07b0-8c6c-489b-b129-9198baaf52ee"), null, 0 },
                    { new Guid("f7f67a20-d1b2-42e3-9d42-1433fd550522"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6157), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new DateTime(2024, 12, 18, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6154), new Guid("f41dd84a-fe43-4246-ad3c-5081968f1639"), null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "ID", "Column", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoomID", "Row", "SeatNumber", "SeatTypeID", "Status" },
                values: new object[,]
                {
                    { new Guid("0298ce8b-7940-4cf4-8e4e-4697551558a9"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "H11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("030dad44-e578-4607-8f06-594344b1b39f"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "G12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("03e8fb73-2774-466b-892b-d9fea6ea75de"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "I3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("057c5fd3-9031-453c-b9fa-efdab3a6a987"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "F6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("05e18bfc-2f04-4377-9ba9-67af7a6c3c89"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "A5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("06576851-1b89-4f9a-af24-0681ad4606e4"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "F8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0913ab7e-0c42-456d-8ad1-c7a8c3b46756"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "H9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("094451f7-f288-409e-bc64-f1bf8f456a7b"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "A4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0959ba95-ef4a-4879-8500-ef23e3f9f061"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "F2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0c49f85e-6d48-4d0b-be44-5d2c3e46a421"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "C7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("0e2b764e-c3c5-45ab-a109-89c803aa27de"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "J6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("10a749f9-8bde-460f-bad3-8fc2105c08cb"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "C5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1153ec32-2178-442d-a4e0-18c4ebfaebf2"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "B14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1305642b-ddc7-47eb-b6f6-25a7d79e34dc"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "A15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1407d0e9-f31a-4990-80f2-28d4b52c5e01"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "H6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("15958238-7db6-47e0-8286-798f211a5143"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "I9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("16fc7780-5374-4651-8ef1-61cf60755850"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "F1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1954f554-1684-492a-948b-d3acc6ea503f"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "E7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("19bca009-9e54-41a3-96f5-2a7ddeab4c25"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "F10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("1f18bd99-7ef7-4f93-9f40-7184097f2542"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "H14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("20126c8e-f350-464d-9a5d-bdd574e844e7"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "I15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("226fa531-93f5-43d8-a98f-79f971ffe237"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "B4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25085e54-7d49-427c-85fa-0d7540e6542c"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "C11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("25e9aa47-a8c3-4849-8d98-8f44c29ab4d1"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "E11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2820cc73-6308-48ab-bd6c-f217cd8e75d5"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "F12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("284b3f83-c296-4d8d-8f6f-eda0e8ed89ea"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "I12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2effe7e4-e06c-4a09-a18e-32ceb580b4aa"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "J3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2f8ea3ae-f56d-4319-9c59-0301146e03be"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "H8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("2fbc1687-a104-4ec4-a9b5-11a180d0ed4b"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "C13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("33e42989-6473-4837-9e7e-7ad4f7de5576"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "J4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3403809f-60c4-4a01-9b6c-b0b685bb1355"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "G4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3553b7de-d4e1-41ee-8f1f-c8ae2fb7b9a3"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "C2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("371acf93-795e-4733-8d79-ecb484431c43"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "H15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("38f0d38b-8f20-43cc-9748-cd0b96728310"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "B10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3b978965-a628-441e-afad-acef3831224e"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "B11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3bec4ebf-922f-41e9-8f2f-688b4f9fe8bd"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "I13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c48c974-8179-4c2b-8938-dfffe61e1bb7"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "E14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3c85bd80-3d2b-4518-8cfc-a16314aab7fe"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "I11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3e0d2047-148d-4a11-b599-6c23bc1dd800"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "E3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("3fdef0e1-9027-4f6f-81ea-dd6e8eec6a73"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "H7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("42cf3a09-b659-4eef-8277-4491fc950098"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "C6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4603b573-e6f8-4fe4-8904-2c261cadcb4d"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "I8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("492e1585-cc1c-481b-a7cf-abaf85a5c042"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "G2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4b773583-7244-4984-a6de-54eb17fd5196"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "E1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4c9d05c9-361a-4f3e-bc30-3d9f23b0a11b"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "E6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4d1d3620-b44a-42be-8f37-5821893f8f8c"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "E12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4e09b9f1-8fba-4683-ad0f-96ae40471dfd"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "H1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4ea11259-3931-4694-911c-a501c6ca290c"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "F13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("4eebcac3-d6cf-4166-a66e-04f049b9fec6"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "H4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5433e546-3f57-4064-9133-b242c1978e05"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "J2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("54cf1f66-2851-4cb1-a709-d1c8eb33b031"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "D10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55988e6b-afa4-4e3e-87a4-f4ab601dd2bf"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "G13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("55f8b9ae-ee91-4588-991a-52f54e2182e0"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "F4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("57419b68-0972-49ba-8005-268cc7c717f3"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "A1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5e085df4-b2c8-4651-8075-c6424815a133"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "G10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("5fc58952-8a63-4a4a-b7af-9743b86d2a57"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "G15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("612730ce-372c-4b18-aafc-1aa30529879b"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "G1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("64346f32-eb3f-4261-ba4f-4eb4e4f23659"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "B3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("65dc4d64-a030-47cc-a173-a38f647e7b5d"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "D14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b4ed24c-0dc4-4913-b932-b14cfbf0a913"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "C9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6b87da0c-0f37-41e1-b915-e1d7ed92a001"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "E5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("6ffc6990-b6d8-406a-be4c-21f1a93779ce"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "J13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7026feae-b0ea-485f-a0d0-d24927f0935c"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "C14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("72c2779c-3055-4960-926e-0257f66b1dde"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "J5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("75310f06-783a-437d-bc0f-c6b26015b118"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "I6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("78907c3e-9449-4cf4-92c7-5f1715d80154"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "G7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7930dfa7-35a7-40f5-8e60-92c1abb38905"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "H5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7a5fb23a-2077-4809-9faa-5b6a64357a9c"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "F5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("7cfa7689-7fd1-4102-a01b-156c6391f834"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "A11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8415b417-115e-408c-a247-bb4c0990d0c6"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "F9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("84a05109-90b3-423b-b072-f170fc04ced8"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "B6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("860aa50c-e832-48d0-b486-b866da1f80ce"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "D4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86882a98-cae5-4566-ba8f-9a0f4302b6ba"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "B15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("86dd7d25-257a-48c3-8a37-1757455c35a7"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "D9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8a666a2a-2f34-41ad-adb9-14182fd40b2a"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "I5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8b047c10-af0a-492b-9767-1c97c8c7b0c8"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "J8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("8d4dbb61-f753-4eef-b02c-535848bb0a3e"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "D2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90235478-fdc2-49c4-8360-dafffd6d0491"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "H13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("90a1cfde-360a-4fb3-9ba1-5069d185aca9"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "B8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9423e05d-b4c3-4769-aeb3-1d46faf21d49"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "D12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("96c5cbdc-0a42-4c2d-b8c0-957d7db616ee"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "H3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("998d8b1e-e4fa-4a8e-9b23-30c9b9d5e7e8"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "C10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99926d3e-744a-4e31-b980-73903f5f835f"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "E8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("99a76e12-38d7-42a0-81cd-fc35aeb1c99c"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "B12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9a3f0a97-43d2-4aed-83f2-62750d0891df"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "B7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("9d45b47e-db3d-4a78-9a49-b0e222cd18e5"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "E13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a158e363-67ff-455f-9e7e-a885192bb501"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "F11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a23828a2-5470-4a3f-bdd1-6d2cc49b86f1"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "G6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a356205c-a6e5-405b-b896-f98ba1250b39"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "G9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a35ed728-1894-487c-b8cb-a6b92af339ba"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "B13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a497bcb0-f6ce-46bf-aec8-1ba4782577d7"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "C8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a63a52a7-6b67-44b8-a403-f14fcf10ad9e"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "C12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a748e9d4-21b9-4bf0-a87d-3bb4e9b25529"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "C3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a7bcd8bb-ecf3-4359-8d97-515653c7ec1c"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "B5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a815519a-9421-47cc-a2db-1c1dca9ff005"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "G8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("a86afdea-6793-4d19-938e-20702504e4d9"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "I14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("aa69b0f6-7058-4d7c-aa7e-47a3cdbf2603"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "J15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab16422f-4320-4db8-8898-ac87d0aaeab2"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "E15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ab97e561-aa71-4763-b8aa-9e4f62bf8390"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "H2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae0f4c55-38c2-4b54-82b0-b88fb7fcdae9"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "J7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ae146f19-1b05-45e2-9d98-6c8ec61734d7"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "D3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b0efe870-7f54-4596-bff4-33c31d47aa5e"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "E2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b1dd3fce-571a-4fa5-b097-366440f3cfe8"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "I1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2289ebe-b4ef-4ecb-827f-cb89376f61a7"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "A6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b2dd15e3-0362-470a-8ad7-f6ed3cb13f86"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "G11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b830f5da-4caa-40b8-a11d-0e64da81fd49"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "A7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b833e7d4-be2f-4a6f-aab1-2ac3d075b943"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "I4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("b87af90f-df41-40a0-96c7-06087070df5d"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "F7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bb442e5d-92c0-472e-ba73-ec6c5eedc270"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "E10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbaf6bc9-b917-42bb-8984-fe59631e5384"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "D11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bbed937b-0a90-4807-918f-fc073e60cc78"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "A10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("bec3bde9-a21f-40e8-b0ee-f346ea580feb"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "I7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c0952191-6fbd-4a24-bc3c-6c396dbb4fe4"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "G3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c3dc5aad-6745-404d-a73a-756a47f268f1"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "A9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c4d4e47a-8465-4922-9d6e-d4730986cd39"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "J14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c7e1f7e2-af02-4ac1-a813-bd65d857fb41"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "A12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("c96accf2-32da-4fac-bcaf-83b785b8d0ee"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "E4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cad66e04-c308-4a5e-945b-859ac8a679bc"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "A13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cee6a926-b2ca-4d26-a3ef-aae8b3f4daf8"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "G14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("cfb89d7a-b4a1-4063-ac65-cd7f879b270d"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "A2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d237f53c-d3df-48ef-b374-5aab506e5e49"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "13", "D13", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d2b7cb1a-d57a-4129-9bb5-bfd7be1905c2"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "B9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d315899a-e1d6-4f39-9d37-f1eca2f67361"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "J9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d3680103-19ef-4060-8fa3-0f9237b9d455"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "H10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d704f46f-f7f9-4d26-9327-8193c7701afa"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "J10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d81672e6-7275-4cf0-a791-e0fdc46b96fd"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "6", "D6", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("d9b77c8d-9b5f-45b1-b37e-7368ab49c066"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "D5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("dd25c3c6-f639-4165-b0f5-e183cb29c23d"), "G", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "5", "G5", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("df3a1d78-7467-41e4-9267-99f045114eee"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "A14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e06fd387-b4bf-469c-b694-823a5c12f387"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "4", "C4", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e338c113-cf04-49a0-86e7-841274fad4ac"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "D15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4967a9e-16a1-4bc0-8620-93b6354c0420"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "F15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e4b2e925-0ae7-4b03-9867-fb2c5c5b21ff"), "E", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "9", "E9", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e59beef8-6bc1-416f-8bfd-e857afcfdc62"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "A8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e77dcf9e-cdfe-4683-be90-3e6eddc657e6"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "J12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("e8e7c9d0-73b9-4ba7-abfd-c57d9b8af414"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "J1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ed0d2b09-a5aa-4010-96c5-b5310ca8d6e3"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "15", "C15", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef2c7175-01ce-4c31-b70d-be918ab69584"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "B2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef596cc4-63ed-4ede-9cb2-e89af07f9219"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "7", "D7", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("ef7d22e3-50cc-41d6-8496-63ec3a7105fb"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "2", "I2", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f0fdb10c-7ccb-4428-8f20-9fa70ba4fcc0"), "J", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "11", "J11", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f11685ad-ebea-4bd6-8f9f-d6c113ca769b"), "C", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "C1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f2d72d68-9df9-435d-a983-d6a85a2e76ff"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "14", "F14", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3c15a59-3947-43f4-9fa1-077dafe5522f"), "I", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "10", "I10", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f3e40213-d36c-410a-bc97-3dff183713c1"), "H", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "12", "H12", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f41c3fd7-9890-4464-a072-8ba6e6ebfb17"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "D1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f53c3deb-a6a6-4d41-a7b4-552fb243c43b"), "D", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "8", "D8", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("f59401ac-d038-4494-894d-58d80a93fd4a"), "A", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "A3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fa7d288e-7c33-43e3-98e8-9e7afddd8835"), "F", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "3", "F3", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 },
                    { new Guid("fff707df-d904-45f0-a628-bfafb6b396dc"), "B", null, null, null, null, null, null, null, new Guid("11714696-0dc6-4369-927e-4300aeb42515"), "1", "B1", new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[] { new Guid("9eea6f2f-0197-4a42-aca8-a7968872b28b"), null, null, new DateTime(2024, 12, 15, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6049), null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), 1, new DateTime(2024, 12, 14, 23, 4, 10, 318, DateTimeKind.Local).AddTicks(6043) });

            migrationBuilder.InsertData(
                table: "WorkShift",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "TimeEnd", "TimeStar", "UserID", "WorkDate" },
                values: new object[] { new Guid("21c3ffc3-e718-427f-a29d-1e709ecc2256"), null, null, null, null, null, null, null, 1, new DateTime(2024, 12, 15, 1, 3, 10, 318, DateTimeKind.Local).AddTicks(6978), new DateTime(2024, 12, 14, 21, 3, 10, 318, DateTimeKind.Local).AddTicks(6976), new Guid("d704b66e-1eda-4c60-b742-fa442d9a54dd"), new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.InsertData(
                table: "BillCombos",
                columns: new[] { "BillID", "FoodComboID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Quantity" },
                values: new object[,]
                {
                    { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), new Guid("9d16fbb6-2377-401d-8f47-8a232b98a371"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6822), null, null, null, null, null, 4 },
                    { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), new Guid("72f07a1f-568f-45a5-8754-882aa8f6437c"), null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6818), null, null, null, null, null, 3 },
                    { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), new Guid("1bebaaa3-d36d-4425-8257-d0cd5653eed2"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6815), null, null, null, null, null, 2 },
                    { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), new Guid("05532b57-9e63-4346-80c3-a8e52c63f41d"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6809), null, null, null, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "Show_release",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "DateRelease", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "RoomID", "Status", "TimeRelease" },
                values: new object[] { new Guid("acf35039-4425-4b35-8c9b-1cc8fa6f8f39"), null, null, new DateTime(2024, 12, 16, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6061), null, null, null, null, null, new Guid("41056346-3a8e-4010-bf53-f55417208f99"), new Guid("11714696-0dc6-4369-927e-4300aeb42515"), 1, new DateTime(2024, 12, 14, 23, 5, 10, 318, DateTimeKind.Local).AddTicks(6059) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "MovieID", "Price", "ScreningID", "SeatID", "Status" },
                values: new object[,]
                {
                    { new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"), null, null, null, null, null, null, null, new Guid("41056346-3a8e-4010-bf53-f55417208f99"), 2100000m, new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"), new Guid("116e3aa8-e0b9-4d61-a2f0-d48ad61d248b"), 2 },
                    { new Guid("4e21eb2f-313a-490b-bc27-0f90c225bd70"), null, null, null, null, null, null, null, new Guid("336e0a18-355c-466a-8233-e15f6389c966"), 3100000m, new Guid("e4d0f32d-8946-415a-962e-695e55519a0a"), new Guid("7fa4ad10-5ed5-4e96-81e7-b000f067442e"), 2 },
                    { new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"), null, null, null, null, null, null, null, new Guid("986ae6ae-d0c1-4690-89a0-b8282b4f04b8"), 100000m, new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"), new Guid("d9ee1b5d-2cb9-473d-b0b5-8a8fb95410fe"), 2 }
                });

            migrationBuilder.InsertData(
                table: "TicketPrice",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Price", "ScreeningID", "SeatTypeID", "ShowTimeID", "Status", "TicketPriceSettingID" },
                values: new object[,]
                {
                    { new Guid("0113e16f-3c57-40bb-a790-b8a726358762"), null, null, null, null, null, null, null, 60000m, new Guid("49799823-1e6a-4293-a7e9-0339a77e662e"), new Guid("014c866d-d5ee-48c8-a990-36f25b611283"), new Guid("b10aa9b7-b841-45f5-b2a4-9268ea7b02c1"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") },
                    { new Guid("56336b15-1668-4323-9296-3eebea21bb4b"), null, null, null, null, null, null, null, 50000m, new Guid("25964a94-06a4-4fb9-abe8-53d8ce8d0f86"), new Guid("8fb86c77-213f-4316-8a7a-43fee795514e"), new Guid("e6606128-b77d-4477-bf67-cb54e5224f23"), 1, new Guid("4bab0da1-d912-4a87-8e21-cb7a665657d3") }
                });

            migrationBuilder.InsertData(
                table: "BillTicket",
                columns: new[] { "BillId", "TicketId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime" },
                values: new object[,]
                {
                    { new Guid("1bfa880e-e366-4c50-a3bf-bd89a31a0c81"), new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6866), null, null, null, null, null },
                    { new Guid("375e4e5e-35a9-4915-ba0c-b4c29d7dcb40"), new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"), null, new DateTime(2024, 12, 14, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6876), null, null, null, null, null },
                    { new Guid("7dc71188-418c-430c-bf82-820e029ad5e3"), new Guid("4e21eb2f-313a-490b-bc27-0f90c225bd70"), null, new DateTime(2024, 12, 12, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6862), null, null, null, null, null },
                    { new Guid("a246a550-cb03-4969-80d4-42ad396e5d90"), new Guid("33c6fac9-4c4b-4699-9d0d-34f7506adf05"), null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6858), null, null, null, null, null },
                    { new Guid("b0814dbc-0e11-4c15-bc6e-5b8cc1821678"), new Guid("69d2c314-93a1-490f-9e8a-888640d63bb2"), null, new DateTime(2024, 12, 13, 23, 3, 10, 318, DateTimeKind.Local).AddTicks(6853), null, null, null, null, null }
                });
        }
    }
}
