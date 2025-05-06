using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_learningPlatform.Migrations
{
    /// <inheritdoc />
    public partial class lessons : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "lessonContent",
                table: "Lessons");

            migrationBuilder.DropColumn(
                name: "lessonDescription",
                table: "Lessons");

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

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "lessonId", "courseId", "lessonTitle", "lessonVideo" },
                values: new object[,]
                {
                    { 1, 1, "Introduction to Mechanics", "physics_101_L1.mp4" },
                    { 2, 1, "Kinematics and Motion", "physics_101_L2.mp4" },
                    { 3, 1, "Newton's Laws of Motion", "physics_101_L3.mp4" },
                    { 4, 1, "Work, Energy, and Power", "physics_101_L4.mp4" },
                    { 5, 1, "Basics of Thermodynamics", "physics_101_L5.mp4" },
                    { 6, 4, "Atoms, Molecules, and Ions", "chemistry_L1.mp4" },
                    { 7, 4, "Chemical Bonding", "chemistry_L2.mp4" },
                    { 8, 4, "Stoichiometry and Moles", "chemistry_L3.mp4" },
                    { 9, 4, "States of Matter (Gas, Liquid, Solid)", "chemistry_L4.mp4" },
                    { 10, 4, "Types of Chemical Reactions", "chemistry_L5.mp4" },
                    { 11, 5, "The Science of Life and The Cell", "biology_L1.mp4" },
                    { 12, 5, "Genetics and DNA", "biology_L2.mp4" },
                    { 13, 5, "Evolution and Natural Selection", "biology_L3.mp4" },
                    { 14, 5, "Introduction to Ecology", "biology_L4.mp4" },
                    { 15, 5, "Human Anatomy Overview", "biology_L5.mp4" },
                    { 16, 6, "Our Solar System", "astronomy_L1.mp4" },
                    { 17, 6, "Stars, Nebulae, and Galaxies", "astronomy_L2.mp4" },
                    { 18, 6, "The Big Bang and Cosmology", "astronomy_L3.mp4" },
                    { 19, 6, "Telescopes and Observation", "astronomy_L4.mp4" },
                    { 20, 6, "The Future of Space Exploration", "astronomy_L5.mp4" },
                    { 21, 7, "Introduction to Ecosystems", "env_science_L1.mp4" },
                    { 22, 7, "Pollution and Its Effects", "env_science_L2.mp4" },
                    { 23, 7, "Biodiversity and Conservation", "env_science_L3.mp4" },
                    { 24, 7, "Understanding Climate Change", "env_science_L4.mp4" },
                    { 25, 7, "Sustainable Practices", "env_science_L5.mp4" },
                    { 26, 2, "Introduction to Limits", "calculus_L1.mp4" },
                    { 27, 2, "Derivatives and Differentiation Rules", "calculus_L2.mp4" },
                    { 28, 2, "Applications of Derivatives", "calculus_L3.mp4" },
                    { 29, 2, "Introduction to Integrals", "calculus_L4.mp4" },
                    { 30, 2, "The Fundamental Theorem of Calculus", "calculus_L5.mp4" },
                    { 31, 8, "Real Numbers and Operations", "algebra_L1.mp4" },
                    { 32, 8, "Solving Linear Equations and Inequalities", "algebra_L2.mp4" },
                    { 33, 8, "Polynomials and Factoring", "algebra_L3.mp4" },
                    { 34, 8, "Rational Expressions", "algebra_L4.mp4" },
                    { 35, 8, "Functions and Graphs", "algebra_L5.mp4" },
                    { 36, 9, "Introduction to Statistics and Data", "statistics_L1.mp4" },
                    { 37, 9, "Descriptive Statistics (Mean, Median, Mode)", "statistics_L2.mp4" },
                    { 38, 9, "Basic Probability Concepts", "statistics_L3.mp4" },
                    { 39, 9, "Discrete and Continuous Distributions", "statistics_L4.mp4" },
                    { 40, 9, "Introduction to Hypothesis Testing", "statistics_L5.mp4" },
                    { 41, 10, "Points, Lines, Angles, and Planes", "geometry_L1.mp4" },
                    { 42, 10, "Triangles and Their Properties", "geometry_L2.mp4" },
                    { 43, 10, "Quadrilaterals and Polygons", "geometry_L3.mp4" },
                    { 44, 10, "Circles", "geometry_L4.mp4" },
                    { 45, 10, "Area, Perimeter, and Volume", "geometry_L5.mp4" },
                    { 46, 11, "Angles and Radian Measure", "trigonometry_L1.mp4" },
                    { 47, 11, "Right Triangle Trigonometry (SOH CAH TOA)", "trigonometry_L2.mp4" },
                    { 48, 11, "The Unit Circle", "trigonometry_L3.mp4" },
                    { 49, 11, "Graphs of Trigonometric Functions", "trigonometry_L4.mp4" },
                    { 50, 11, "Basic Trigonometric Identities", "trigonometry_L5.mp4" },
                    { 51, 3, "What is Physical Geography?", "phys_geo_L1.mp4" },
                    { 52, 3, "Earth's Atmosphere and Weather", "phys_geo_L2.mp4" },
                    { 53, 3, "Landforms and Geomorphology", "phys_geo_L3.mp4" },
                    { 54, 3, "Water Systems: Oceans and Rivers", "phys_geo_L4.mp4" },
                    { 55, 3, "Biogeography and Ecosystems", "phys_geo_L5.mp4" },
                    { 56, 12, "Introduction to Regions", "world_regions_L1.mp4" },
                    { 57, 12, "North and South America", "world_regions_L2.mp4" },
                    { 58, 12, "Europe and Russia", "world_regions_L3.mp4" },
                    { 59, 12, "Asia and the Middle East", "world_regions_L4.mp4" },
                    { 60, 12, "Africa and Oceania", "world_regions_L5.mp4" },
                    { 61, 13, "What is GIS and Spatial Data?", "gis_L1.mp4" },
                    { 62, 13, "Vector and Raster Data Models", "gis_L2.mp4" },
                    { 63, 13, "Basic Spatial Analysis", "gis_L3.mp4" },
                    { 64, 13, "Map Projections and Coordinate Systems", "gis_L4.mp4" },
                    { 65, 13, "Introduction to Cartography and Map Design", "gis_L5.mp4" },
                    { 66, 14, "The Study of Cities", "urban_geo_L1.mp4" },
                    { 67, 14, "Urbanization and City Origins", "urban_geo_L2.mp4" },
                    { 68, 14, "Internal Structure of Cities (Models)", "urban_geo_L3.mp4" },
                    { 69, 14, "Urban Challenges (Housing, Transport)", "urban_geo_L4.mp4" },
                    { 70, 14, "Global Cities and Future Urban Trends", "urban_geo_L5.mp4" },
                    { 71, 15, "Earth's Climate System", "climatology_L1.mp4" },
                    { 72, 15, "Atmospheric Circulation", "climatology_L2.mp4" },
                    { 73, 15, "World Climate Zones (Koppen System)", "climatology_L3.mp4" },
                    { 74, 15, "Climate Change: Causes and Impacts", "climatology_L4.mp4" },
                    { 75, 15, "Paleoclimatology (Past Climates)", "climatology_L5.mp4" },
                    { 76, 16, "Introduction and Setup", "python_L1.mp4" },
                    { 77, 16, "Variables, Data Types, and Operators", "python_L2.mp4" },
                    { 78, 16, "Control Flow (If, Loops)", "python_L3.mp4" },
                    { 79, 16, "Functions and Modules", "python_L4.mp4" },
                    { 80, 16, "Basic Data Structures (Lists, Dictionaries)", "python_L5.mp4" },
                    { 81, 17, "Introduction to HTML", "webdev_L1.mp4" },
                    { 82, 17, "Styling with CSS", "webdev_L2.mp4" },
                    { 83, 17, "CSS Box Model and Layouts", "webdev_L3.mp4" },
                    { 84, 17, "Introduction to JavaScript", "webdev_L4.mp4" },
                    { 85, 17, "JavaScript DOM Manipulation", "webdev_L5.mp4" },
                    { 86, 18, "Introduction to Cybersecurity Threats", "cybersecurity_L1.mp4" },
                    { 87, 18, "Network Security Basics", "cybersecurity_L2.mp4" },
                    { 88, 18, "Cryptography Essentials", "cybersecurity_L3.mp4" },
                    { 89, 18, "Web Application Security", "cybersecurity_L4.mp4" },
                    { 90, 18, "Security Policies and Best Practices", "cybersecurity_L5.mp4" },
                    { 91, 19, "What is Data Science?", "datascience_L1.mp4" },
                    { 92, 19, "Data Acquisition and Cleaning", "datascience_L2.mp4" },
                    { 93, 19, "Exploratory Data Analysis (EDA)", "datascience_L3.mp4" },
                    { 94, 19, "Introduction to Machine Learning Concepts", "datascience_L4.mp4" },
                    { 95, 19, "Data Visualization Techniques", "datascience_L5.mp4" },
                    { 96, 20, "Introduction to Cloud Computing and AWS", "aws_cloud_L1.mp4" },
                    { 97, 20, "Core AWS Services (EC2, S3)", "aws_cloud_L2.mp4" },
                    { 98, 20, "AWS Networking (VPC)", "aws_cloud_L3.mp4" },
                    { 99, 20, "AWS Databases (RDS, DynamoDB)", "aws_cloud_L4.mp4" },
                    { 100, 20, "AWS Security and IAM", "aws_cloud_L5.mp4" },
                    { 101, 21, "Parts of Speech (Nouns, Verbs, Adjectives)", "grammar_L1.mp4" },
                    { 102, 21, "Sentence Structure (Subjects, Predicates, Clauses)", "grammar_L2.mp4" },
                    { 103, 21, "Verb Tenses and Forms", "grammar_L3.mp4" },
                    { 104, 21, "Punctuation (Commas, Semicolons, Apostrophes)", "grammar_L4.mp4" },
                    { 105, 21, "Common Grammatical Errors", "grammar_L5.mp4" },
                    { 106, 22, "Finding Inspiration and Ideas", "creative_write_L1.mp4" },
                    { 107, 22, "Character Development", "creative_write_L2.mp4" },
                    { 108, 22, "Plotting and Story Structure", "creative_write_L3.mp4" },
                    { 109, 22, "Writing Vivid Descriptions and Settings", "creative_write_L4.mp4" },
                    { 110, 22, "Introduction to Poetic Forms", "creative_write_L5.mp4" },
                    { 111, 23, "Understanding the Writing Process", "composition_L1.mp4" },
                    { 112, 23, "Crafting Strong Thesis Statements", "composition_L2.mp4" },
                    { 113, 23, "Developing Effective Paragraphs", "composition_L3.mp4" },
                    { 114, 23, "Argumentation and Persuasion", "composition_L4.mp4" },
                    { 115, 23, "Research, Citation, and Avoiding Plagiarism", "composition_L5.mp4" },
                    { 116, 24, "Professional Email Etiquette", "business_english_L1.mp4" },
                    { 117, 24, "Writing Effective Memos and Reports", "business_english_L2.mp4" },
                    { 118, 24, "Delivering Engaging Presentations", "business_english_L3.mp4" },
                    { 119, 24, "Language for Meetings and Negotiations", "business_english_L4.mp4" },
                    { 120, 24, "Cross-Cultural Communication", "business_english_L5.mp4" },
                    { 121, 25, "Old English and Medieval Literature (Beowulf, Chaucer)", "eng_lit_L1.mp4" },
                    { 122, 25, "The Renaissance (Shakespeare, Marlowe)", "eng_lit_L2.mp4" },
                    { 123, 25, "18th and 19th Century Literature (Austen, Dickens)", "eng_lit_L3.mp4" },
                    { 124, 25, "Modernism (Woolf, Eliot, Joyce)", "eng_lit_L4.mp4" },
                    { 125, 25, "Contemporary Literature and Trends", "eng_lit_L5.mp4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "lessonId",
                keyValue: 125);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "lessonContent",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "lessonDescription",
                table: "Lessons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8922));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8928));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8931));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8939));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2025, 5, 6, 2, 42, 2, 942, DateTimeKind.Utc).AddTicks(9035));
        }
    }
}
