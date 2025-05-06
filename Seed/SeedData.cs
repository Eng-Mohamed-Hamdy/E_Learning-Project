using E_learningPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace E_learningPlatform.Seed
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // --- Seed Categories ---
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Science" },
                new Category { Id = 2, Name = "Mathematics" },
                new Category { Id = 3, Name = "Geography" }, // Changed from History
                new Category { Id = 4, Name = "Technology" },
                new Category { Id = 5, Name = "English" }
            );

            // --- Seed Courses ---
            modelBuilder.Entity<Course>().HasData(
                // == Science (Category 1) ==
                new Course
                {
                    CourseId = 1,
                    CourseTitle = "Physics 101",
                    Description = "Introduction to classical mechanics and thermodynamics.",
                    Image = "physics101.jpg",
                    Price = 100,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 1, // Science
                    InstructorName = "Mr. Ahmed Adel"
                },
                new Course
                {
                    CourseId = 4,
                    CourseTitle = "Chemistry Fundamentals",
                    Description = "Explore the basic principles of chemistry, atoms, and molecules.",
                    Image = "chemistry.jpg",
                    Price = 95,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 1, // Science
                    InstructorName = "Dr. Fatima Khalil"
                },
                new Course
                {
                    CourseId = 5,
                    CourseTitle = "Introduction to Biology",
                    Description = "Learn about the science of life, from cells to ecosystems.",
                    Image = "biology.jpg",
                    Price = 110,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 1, // Science
                    InstructorName = "Prof. Samira Zayd"
                },
                 new Course
                 {
                     CourseId = 6,
                     CourseTitle = "Astronomy: Exploring the Cosmos",
                     Description = "A journey through space, stars, planets, and galaxies.",
                     Image = "astronomy.jpg",
                     Price = 125,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 1, // Science
                     InstructorName = "Mr. Karim Farouk"
                 },
                 new Course
                 {
                     CourseId = 7,
                     CourseTitle = "Environmental Science Basics",
                     Description = "Understanding human impact on the environment and ecosystems.",
                     Image = "environmental.jpg",
                     Price = 90,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 1, // Science
                     InstructorName = "Ms. Layla Ibrahim"
                 },

                // == Mathematics (Category 2) ==
                new Course
                {
                    CourseId = 2,
                    CourseTitle = "Calculus for Beginners",
                    Description = "Grasp the fundamentals of differential and integral calculus.",
                    Image = "calculus.jpg",
                    Price = 80,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 2, // Mathematics
                    InstructorName = "Mr. Mohamed Ahmed"
                },
                 new Course
                 {
                     CourseId = 8,
                     CourseTitle = "Algebra Essentials",
                     Description = "Master the core concepts of algebra, including equations and functions.",
                     Image = "algebra.jpg",
                     Price = 75,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 2, // Mathematics
                     InstructorName = "Ms. Hoda Salah"
                 },
                 new Course
                 {
                     CourseId = 9,
                     CourseTitle = "Statistics and Probability",
                     Description = "Learn to analyze data and understand the principles of probability.",
                     Image = "statistics.jpg",
                     Price = 100,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 2, // Mathematics
                     InstructorName = "Mr. Tarek Mahmoud"
                 },
                 new Course
                 {
                     CourseId = 10,
                     CourseTitle = "Geometry: Shapes and Space",
                     Description = "Explore Euclidean geometry, shapes, proofs, and spatial reasoning.",
                     Image = "geometry.jpg",
                     Price = 85,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 2, // Mathematics
                     InstructorName = "Dr. Ibrahim Youssef"
                 },
                 new Course
                 {
                     CourseId = 11,
                     CourseTitle = "Trigonometry Fundamentals",
                     Description = "Understand angles, triangles, and trigonometric functions.",
                     Image = "trigonometry.jpg",
                     Price = 70,
                     Available = false,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 2, // Mathematics
                     InstructorName = "Ms. Nadia Hassan"
                 },

                // == Geography (Category 3) 
                new Course
                {
                    CourseId = 3, 
                    CourseTitle = "Introduction to Physical Geography",
                    Description = "Explore Earth's landforms, climate, and natural processes.",
                    Image = "physical_geography.jpg",
                    Price = 110, 
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 3, 
                    InstructorName = "Dr. Hassan Fares" 
                },
                new Course
                {
                    CourseId = 12,
                    CourseTitle = "World Regional Geography",
                    Description = "A survey of the world's major cultural and physical regions.",
                    Image = "world_regions.jpg",
                    Price = 115,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 3, // Geography
                    InstructorName = "Prof. Mona Said" // New Instructor
                },
                 new Course
                 {
                     CourseId = 13, 
                     CourseTitle = "Introduction to GIS",
                     Description = "Learn the basics of Geographic Information Systems and mapping.",
                     Image = "gis_intro.jpg",
                     Price = 135, 
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 3, // Geography
                     InstructorName = "Eng. Karim Ismail" 
                 },
                 new Course
                 {
                     CourseId = 14, 
                     CourseTitle = "Urban Geography",
                     Description = "Study the spatial structure and development of cities.",
                     Image = "urban_geography.jpg",
                     Price = 120,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 3, // Geography
                     InstructorName = "Dr. Hassan Fares" 
                 },
                 new Course
                 {
                     CourseId = 15, 
                     CourseTitle = "Climatology Basics",
                     Description = "Understanding weather patterns, climate zones, and climate change.",
                     Image = "climatology.jpg",
                     Price = 110,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 3, // Geography
                     InstructorName = "Ms. Salwa Ali" 
                 },

                // == Technology (Category 4) ==
                new Course
                {
                    CourseId = 16,
                    CourseTitle = "Introduction to Python Programming",
                    Description = "Learn the fundamentals of programming using Python.",
                    Image = "python_intro.jpg",
                    Price = 150,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 4, // Technology
                    InstructorName = "Eng. Omar Sharif"
                },
                 new Course
                 {
                     CourseId = 17,
                     CourseTitle = "Web Development Basics (HTML, CSS, JS)",
                     Description = "Build your first websites using core web technologies.",
                     Image = "webdev_basics.jpg",
                     Price = 140,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 4, // Technology
                     InstructorName = "Ms. Reem Abbas"
                 },
                 new Course
                 {
                     CourseId = 18,
                     CourseTitle = "Cybersecurity Fundamentals",
                     Description = "Understand the basics of cybersecurity threats and defenses.",
                     Image = "cybersecurity.jpg",
                     Price = 160,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 4, // Technology
                     InstructorName = "Mr. Ali Mansour"
                 },
                 new Course
                 {
                     CourseId = 19,
                     CourseTitle = "Data Science Essentials",
                     Description = "An introduction to data analysis, visualization, and machine learning concepts.",
                     Image = "datascience.jpg",
                     Price = 175,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 4, // Technology
                     InstructorName = "Dr. Zainab Dawoud"
                 },
                 new Course
                 {
                     CourseId = 20,
                     CourseTitle = "Cloud Computing with AWS",
                     Description = "Learn the basics of cloud services using Amazon Web Services.",
                     Image = "aws_cloud.png",
                     Price = 180,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 4, // Technology
                     InstructorName = "Eng. Rami Said"
                 },

                // == English (Category 5) ==
                new Course
                {
                    CourseId = 21,
                    CourseTitle = "English Grammar Essentials",
                    Description = "Master the core rules of English grammar and punctuation.",
                    Image = "grammar.jpg",
                    Price = 90,
                    Available = true,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    CategoryId = 5, // English
                    InstructorName = "Ms. Sarah Jones"
                },
                 new Course
                 {
                     CourseId = 22,
                     CourseTitle = "Creative Writing: Fiction & Poetry",
                     Description = "Develop your skills in writing compelling stories and poems.",
                     Image = "creative_writing.jpg",
                     Price = 85,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 5, // English
                     InstructorName = "Mr. David Miller"
                 },
                 new Course
                 {
                     CourseId = 23,
                     CourseTitle = "Advanced English Composition",
                     Description = "Learn techniques for crafting effective essays and reports.",
                     Image = "composition.jpg",
                     Price = 95,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 5, // English
                     InstructorName = "Dr. Emily White"
                 },
                 new Course
                 {
                     CourseId = 24,
                     CourseTitle = "Business English Communication",
                     Description = "Improve your professional writing and speaking skills.",
                     Image = "business_english.jpg",
                     Price = 110,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 5, // English
                     InstructorName = "Mr. John Smith"
                 },
                 new Course
                 {
                     CourseId = 25,
                     CourseTitle = "Survey of English Literature",
                     Description = "Explore major authors and works from Old English to Modern.",
                     Image = "english_literature.jpg",
                     Price = 100,
                     Available = true,
                     CreatedAt = DateTime.UtcNow,
                     UpdatedAt = DateTime.UtcNow,
                     CategoryId = 5, // English
                     InstructorName = "Prof. Laura Brown"
                 }
            );
        }
    }
}