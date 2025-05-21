using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class handlePaths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2604));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 21, 4, 17, 39, 527, DateTimeKind.Utc).AddTicks(2687));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    lessonId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExamDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExamTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exams_Courses_courseId",
                        column: x => x.courseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Lessons_lessonId",
                        column: x => x.lessonId,
                        principalTable: "Lessons",
                        principalColumn: "lessonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5610));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5578));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5583));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5596));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5607));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5619));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5628));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5712));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5723));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5729));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 7, 0, 25, 7, 79, DateTimeKind.Utc).AddTicks(5732));

            migrationBuilder.CreateIndex(
                name: "IX_Exams_courseId",
                table: "Exams",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_lessonId",
                table: "Exams",
                column: "lessonId");
        }
    }
}
