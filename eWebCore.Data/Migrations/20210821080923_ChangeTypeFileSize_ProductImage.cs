using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eWebCore.Data.Migrations
{
    public partial class ChangeTypeFileSize_ProductImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "FileSize",
                table: "ProductImages",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "f8e8ab44-48b8-403c-bc14-9cdad51c0f42");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "92bb3a1b-96f6-48b9-a2cc-aa0afd54ac82", "AQAAAAEAACcQAAAAEGRwVshVz5nQ/vERIYgcyv7R20IJEwNwV2wOloB81ZthiwXrASMc16omry6KUh2f5Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 21, 15, 9, 22, 365, DateTimeKind.Local).AddTicks(458));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "FileSize",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "90fbc953-83a1-40c2-8595-9485ce0abf51");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c417c100-9b6d-4fbc-a430-56efbb138a9e", "AQAAAAEAACcQAAAAEIQ910jMPYlhs5koIx9jWRBk6ZxuA5AuVOoBXEh3jFR1bi6Qepfd+whNnwdD4ecBag==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 21, 10, 39, 1, 853, DateTimeKind.Local).AddTicks(9698));
        }
    }
}
