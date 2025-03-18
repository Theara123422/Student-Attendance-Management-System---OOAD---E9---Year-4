using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Student_Attendance_Management_System___OOAD___E9___Year_4.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEduAndStatusCol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Users",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "EducationalBackground",
                table: "Users",
                newName: "educational_background");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "updated_at",
                value: new DateTime(2025, 3, 18, 7, 4, 19, 158, DateTimeKind.Utc).AddTicks(5308));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "status",
                table: "Users",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "educational_background",
                table: "Users",
                newName: "EducationalBackground");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "updated_at",
                value: new DateTime(2025, 3, 18, 7, 1, 7, 60, DateTimeKind.Utc).AddTicks(1122));
        }
    }
}
