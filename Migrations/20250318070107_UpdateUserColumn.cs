using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EducationalBackground",
                table: "Users",
                type: "varchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "EducationalBackground", "Status", "updated_at" },
                values: new object[] { "Computer Science", 0, new DateTime(2025, 3, 18, 7, 1, 7, 60, DateTimeKind.Utc).AddTicks(1122) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationalBackground",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "updated_at",
                value: new DateTime(2025, 3, 18, 6, 8, 12, 114, DateTimeKind.Utc).AddTicks(9117));
        }
    }
}
