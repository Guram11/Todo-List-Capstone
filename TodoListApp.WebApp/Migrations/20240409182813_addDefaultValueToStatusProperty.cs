using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApp.Migrations
{
    public partial class addDefaultValueToStatusProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 28, 12, 833, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "TodoTasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2024, 4, 9, 22, 28, 12, 833, DateTimeKind.Local).AddTicks(993));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
