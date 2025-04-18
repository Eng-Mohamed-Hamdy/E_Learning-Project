using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_learningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Science" },
                    { 2, "Mathematics" },
                    { 3, "History" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Available", "CategoryId", "CourseTitle", "CreatedAt", "Description", "Image", "Price" },
                values: new object[,]
                {
                    { 1, true, 1, "Physics 101", new DateTime(2025, 4, 18, 14, 10, 52, 338, DateTimeKind.Local).AddTicks(412), "Introduction to Physics", "physics101.jpg", 100 },
                    { 2, true, 2, "Calculus for Beginners", new DateTime(2025, 4, 18, 14, 10, 52, 338, DateTimeKind.Local).AddTicks(497), "Learn the basics of Calculus", "calculus.jpg", 80 },
                    { 3, true, 3, "World History", new DateTime(2025, 4, 18, 14, 10, 52, 338, DateTimeKind.Local).AddTicks(502), "A comprehensive look at World History", "history.jpg", 120 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
