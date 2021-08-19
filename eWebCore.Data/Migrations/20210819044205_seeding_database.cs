using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eWebCore.Data.Migrations
{
    public partial class seeding_database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 19, 11, 42, 5, 505, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 19, 10, 19, 43, 79, DateTimeKind.Local).AddTicks(8565));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 19, 10, 19, 43, 79, DateTimeKind.Local).AddTicks(8565),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 19, 11, 42, 5, 505, DateTimeKind.Local).AddTicks(1080));
        }
    }
}
