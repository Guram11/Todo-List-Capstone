using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApp.Migrations
{
    public partial class addStatusPropertyToTasks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "TodoTasks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 9, 52, 40, DateTimeKind.Local).AddTicks(6072));

            migrationBuilder.UpdateData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 9, 52, 40, DateTimeKind.Local).AddTicks(6409));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "TodoTasks");

            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 13, 25, 20, 278, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 8, 13, 25, 20, 278, DateTimeKind.Local).AddTicks(923));
        }
    }
}
