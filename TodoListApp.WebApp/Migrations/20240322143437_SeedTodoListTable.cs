using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApp.Migrations
{
    public partial class SeedTodoListTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TodoLists",
                columns: new[] { "Id", "CreatedAt", "Description", "NumberOfTasks", "Title" },
                values: new object[] { 1, new DateTime(2024, 3, 22, 18, 34, 36, 512, DateTimeKind.Local).AddTicks(9381), "First List", 0, "List1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoLists",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
