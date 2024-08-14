using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NeonCinema_Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBillDeltais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillID",
                table: "BillDetail");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BillID",
                table: "BillDetail",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
