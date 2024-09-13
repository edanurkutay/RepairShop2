using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepairShop2.Data.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BillDate",
                table: "bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 13, 10, 50, 18, 245, DateTimeKind.Local).AddTicks(7088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 12, 16, 33, 54, 144, DateTimeKind.Local).AddTicks(3152));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BillDate",
                table: "bills",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 12, 16, 33, 54, 144, DateTimeKind.Local).AddTicks(3152),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 13, 10, 50, 18, 245, DateTimeKind.Local).AddTicks(7088));
        }
    }
}
