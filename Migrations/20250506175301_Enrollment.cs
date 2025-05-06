using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_learningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class Enrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseUser",
                columns: table => new
                {
                    CoursesCourseId = table.Column<int>(type: "int", nullable: false),
                    studentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseUser", x => new { x.CoursesCourseId, x.studentsId });
                    table.ForeignKey(
                        name: "FK_CourseUser_AspNetUsers_studentsId",
                        column: x => x.studentsId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseUser_Courses_CoursesCourseId",
                        column: x => x.CoursesCourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    EnrollmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.EnrollmentId);
                    table.ForeignKey(
                        name: "FK_Enrollments_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Courses_courseId",
                        column: x => x.courseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MyCourses",
                columns: table => new
                {
                    MycourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyCourses", x => x.MycourseId);
                    table.ForeignKey(
                        name: "FK_MyCourses_AspNetUsers_StudentId",
                        column: x => x.StudentId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MyCourses_Courses_courseId",
                        column: x => x.courseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7115));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7166));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7173));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7176));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7184));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 53, 1, 224, DateTimeKind.Utc).AddTicks(7193));

            migrationBuilder.CreateIndex(
                name: "IX_CourseUser_studentsId",
                table: "CourseUser",
                column: "studentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_courseId",
                table: "Enrollments",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_MyCourses_courseId",
                table: "MyCourses",
                column: "courseId");

            migrationBuilder.CreateIndex(
                name: "IX_MyCourses_StudentId",
                table: "MyCourses",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseUser");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "MyCourses");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7959));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7927));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7930));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7953));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7962));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7974));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7984));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7987));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7993));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(7999));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 17, 25, 44, 419, DateTimeKind.Utc).AddTicks(8002));
        }
    }
}
