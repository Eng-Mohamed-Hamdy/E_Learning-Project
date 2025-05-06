using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_learningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Geography");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 4, "Technology" },
                    { 5, "English" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8901), "Introduction to classical mechanics and thermodynamics." });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "InstructorName" },
                values: new object[] { new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8925), "Grasp the fundamentals of differential and integral calculus.", "Mr. Mohamed Ahmed" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseTitle", "CreatedAt", "Description", "Image", "InstructorName", "Price" },
                values: new object[] { "Introduction to Physical Geography", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8942), "Explore Earth's landforms, climate, and natural processes.", "physical_geography.jpg", "Dr. Hassan Fares", 110 });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Available", "CategoryId", "CourseTitle", "CreatedAt", "Description", "Image", "InstructorName", "Price" },
                values: new object[,]
                {
                    { 4, true, 1, "Chemistry Fundamentals", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8912), "Explore the basic principles of chemistry, atoms, and molecules.", "chemistry.jpg", "Dr. Fatima Khalil", 95 },
                    { 5, true, 1, "Introduction to Biology", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8915), "Learn about the science of life, from cells to ecosystems.", "biology.jpg", "Prof. Samira Zayd", 110 },
                    { 6, true, 1, "Astronomy: Exploring the Cosmos", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8919), "A journey through space, stars, planets, and galaxies.", "astronomy.jpg", "Mr. Karim Farouk", 125 },
                    { 7, true, 1, "Environmental Science Basics", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8922), "Understanding human impact on the environment and ecosystems.", "environmental.jpg", "Ms. Layla Ibrahim", 90 },
                    { 8, true, 2, "Algebra Essentials", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8928), "Master the core concepts of algebra, including equations and functions.", "algebra.jpg", "Ms. Hoda Salah", 75 },
                    { 9, true, 2, "Statistics and Probability", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8931), "Learn to analyze data and understand the principles of probability.", "statistics.jpg", "Mr. Tarek Mahmoud", 100 },
                    { 10, true, 2, "Geometry: Shapes and Space", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8936), "Explore Euclidean geometry, shapes, proofs, and spatial reasoning.", "geometry.jpg", "Dr. Ibrahim Youssef", 85 },
                    { 11, false, 2, "Trigonometry Fundamentals", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8939), "Understand angles, triangles, and trigonometric functions.", "trigonometry.jpg", "Ms. Nadia Hassan", 70 },
                    { 12, true, 3, "World Regional Geography", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8945), "A survey of the world's major cultural and physical regions.", "world_regions.jpg", "Prof. Mona Said", 115 },
                    { 13, true, 3, "Introduction to GIS", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8948), "Learn the basics of Geographic Information Systems and mapping.", "gis_intro.jpg", "Eng. Karim Ismail", 135 },
                    { 14, true, 3, "Urban Geography", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8951), "Study the spatial structure and development of cities.", "urban_geography.jpg", "Dr. Hassan Fares", 120 },
                    { 15, true, 3, "Climatology Basics", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8954), "Understanding weather patterns, climate zones, and climate change.", "climatology.jpg", "Ms. Salwa Ali", 110 },
                    { 16, true, 4, "Introduction to Python Programming", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8957), "Learn the fundamentals of programming using Python.", "python_intro.jpg", "Eng. Omar Sharif", 150 },
                    { 17, true, 4, "Web Development Basics (HTML, CSS, JS)", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9010), "Build your first websites using core web technologies.", "webdev_basics.jpg", "Ms. Reem Abbas", 140 },
                    { 18, true, 4, "Cybersecurity Fundamentals", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9014), "Understand the basics of cybersecurity threats and defenses.", "cybersecurity.jpg", "Mr. Ali Mansour", 160 },
                    { 19, true, 4, "Data Science Essentials", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9017), "An introduction to data analysis, visualization, and machine learning concepts.", "datascience.jpg", "Dr. Zainab Dawoud", 175 },
                    { 20, true, 4, "Cloud Computing with AWS", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9020), "Learn the basics of cloud services using Amazon Web Services.", "aws_cloud.png", "Eng. Rami Said", 180 },
                    { 21, true, 5, "English Grammar Essentials", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9023), "Master the core rules of English grammar and punctuation.", "grammar.jpg", "Ms. Sarah Jones", 90 },
                    { 22, true, 5, "Creative Writing: Fiction & Poetry", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9026), "Develop your skills in writing compelling stories and poems.", "creative_writing.jpg", "Mr. David Miller", 85 },
                    { 23, true, 5, "Advanced English Composition", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9029), "Learn techniques for crafting effective essays and reports.", "composition.jpg", "Dr. Emily White", 95 },
                    { 24, true, 5, "Business English Communication", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9032), "Improve your professional writing and speaking skills.", "business_english.jpg", "Mr. John Smith", 110 },
                    { 25, true, 5, "Survey of English Literature", new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9035), "Explore major authors and works from Old English to Modern.", "english_literature.jpg", "Prof. Laura Brown", 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 33, 51, 61, DateTimeKind.Local).AddTicks(5021), "Introduction to Physics" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "InstructorName" },
                values: new object[] { new DateTime(2025, 5, 1, 19, 33, 51, 61, DateTimeKind.Local).AddTicks(5080), "Learn the basics of Calculus", "Mr. Moahmed Ahmed" });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                columns: new[] { "CourseTitle", "CreatedAt", "Description", "Image", "InstructorName", "Price" },
                values: new object[] { "World History", new DateTime(2025, 5, 1, 19, 33, 51, 61, DateTimeKind.Local).AddTicks(5084), "A comprehensive look at World History", "history.jpg", "Mr. Sayed Alaa", 120 });
        }
    }
}
