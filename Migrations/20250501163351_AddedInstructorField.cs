using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class AddedInstructorField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstructorName",
                table: "Courses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "InstructorName" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 33, 51, 61, DateTimeKind.Local).AddTicks(5021), "Mr. Ahmed Adel" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "InstructorName" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 33, 51, 61, DateTimeKind.Local).AddTicks(5080), "Mr. Moahmed Ahmed" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CreatedAt", "InstructorName" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 33, 51, 61, DateTimeKind.Local).AddTicks(5084), "Mr. Sayed Alaa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InstructorName",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 18, 13, 16, 692, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 18, 13, 16, 692, DateTimeKind.Local).AddTicks(9109));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 4, 22, 18, 13, 16, 692, DateTimeKind.Local).AddTicks(9115));
        }
    }
}
