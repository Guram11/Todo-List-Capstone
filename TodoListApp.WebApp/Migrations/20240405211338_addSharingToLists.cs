using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApp.Migrations
{
    public partial class addSharingToLists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SharedTo",
                table: "TodoLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 1, 13, 38, 361, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 6, 1, 13, 38, 361, DateTimeKind.Local).AddTicks(3521));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SharedTo",
                table: "TodoLists");

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 21, 16, 43, 898, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 5, 21, 16, 43, 898, DateTimeKind.Local).AddTicks(8075));
        }
    }
}
