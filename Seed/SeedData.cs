using E_learningPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

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
                new Category { Id = 3, Name = "Geography" },
                new Category { Id = 4, Name = "Technology" },
                new Category { Id = 5, Name = "English" }
            );

            // --- Seed Courses ---
            modelBuilder.Entity<Course>().HasData(
                // == Science (Category 1) ==
                new Course { CourseId = 1, CourseTitle = "Physics 101", Description = "Introduction to classical mechanics and thermodynamics.", Image = "physics101.jpg", Price = 100, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 1, InstructorName = "Mr. Ahmed Adel" },
                new Course { CourseId = 4, CourseTitle = "Chemistry Fundamentals", Description = "Explore the basic principles of chemistry, atoms, and molecules.", Image = "chemistry.jpg", Price = 95, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 1, InstructorName = "Dr. Fatima Khalil" },
                new Course { CourseId = 5, CourseTitle = "Introduction to Biology", Description = "Learn about the science of life, from cells to ecosystems.", Image = "biology.jpg", Price = 110, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 1, InstructorName = "Prof. Samira Zayd" },
                new Course { CourseId = 6, CourseTitle = "Astronomy: Exploring the Cosmos", Description = "A journey through space, stars, planets, and galaxies.", Image = "astronomy.jpg", Price = 125, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 1, InstructorName = "Mr. Karim Farouk" },
                new Course { CourseId = 7, CourseTitle = "Environmental Science Basics", Description = "Understanding human impact on the environment and ecosystems.", Image = "environmental.jpg", Price = 90, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 1, InstructorName = "Ms. Layla Ibrahim" },

                // == Mathematics (Category 2) ==
                new Course { CourseId = 2, CourseTitle = "Calculus for Beginners", Description = "Grasp the fundamentals of differential and integral calculus.", Image = "calculus.jpg", Price = 80, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 2, InstructorName = "Mr. Mohamed Ahmed" },
                new Course { CourseId = 8, CourseTitle = "Algebra Essentials", Description = "Master the core concepts of algebra, including equations and functions.", Image = "algebra.jpg", Price = 75, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 2, InstructorName = "Ms. Hoda Salah" },
                new Course { CourseId = 9, CourseTitle = "Statistics and Probability", Description = "Learn to analyze data and understand the principles of probability.", Image = "statistics.jpg", Price = 100, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 2, InstructorName = "Mr. Tarek Mahmoud" },
                new Course { CourseId = 10, CourseTitle = "Geometry: Shapes and Space", Description = "Explore Euclidean geometry, shapes, proofs, and spatial reasoning.", Image = "geometry.jpg", Price = 85, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 2, InstructorName = "Dr. Ibrahim Youssef" },
                new Course { CourseId = 11, CourseTitle = "Trigonometry Fundamentals", Description = "Understand angles, triangles, and trigonometric functions.", Image = "trigonometry.jpg", Price = 70, Available = false, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 2, InstructorName = "Ms. Nadia Hassan" },

                // == Geography (Category 3) ==
                new Course { CourseId = 3, CourseTitle = "Introduction to Physical Geography", Description = "Explore Earth's landforms, climate, and natural processes.", Image = "physical_geography.jpg", Price = 110, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 3, InstructorName = "Dr. Hassan Fares" },
                new Course { CourseId = 12, CourseTitle = "World Regional Geography", Description = "A survey of the world's major cultural and physical regions.", Image = "world_regions.jpg", Price = 115, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 3, InstructorName = "Prof. Mona Said" },
                new Course { CourseId = 13, CourseTitle = "Introduction to GIS", Description = "Learn the basics of Geographic Information Systems and mapping.", Image = "gis_intro.jpg", Price = 135, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 3, InstructorName = "Eng. Karim Ismail" },
                new Course { CourseId = 14, CourseTitle = "Urban Geography", Description = "Study the spatial structure and development of cities.", Image = "urban_geography.jpg", Price = 120, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 3, InstructorName = "Dr. Hassan Fares" },
                new Course { CourseId = 15, CourseTitle = "Climatology Basics", Description = "Understanding weather patterns, climate zones, and climate change.", Image = "climatology.jpg", Price = 110, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 3, InstructorName = "Ms. Salwa Ali" },

                // == Technology (Category 4) ==
                new Course { CourseId = 16, CourseTitle = "Introduction to Python Programming", Description = "Learn the fundamentals of programming using Python.", Image = "python_intro.jpg", Price = 150, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 4, InstructorName = "Eng. Omar Sharif" },
                new Course { CourseId = 17, CourseTitle = "Web Development Basics (HTML, CSS, JS)", Description = "Build your first websites using core web technologies.", Image = "webdev_basics.jpg", Price = 140, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 4, InstructorName = "Ms. Reem Abbas" },
                new Course { CourseId = 18, CourseTitle = "Cybersecurity Fundamentals", Description = "Understand the basics of cybersecurity threats and defenses.", Image = "cybersecurity.jpg", Price = 160, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 4, InstructorName = "Mr. Ali Mansour" },
                new Course { CourseId = 19, CourseTitle = "Data Science Essentials", Description = "An introduction to data analysis, visualization, and machine learning concepts.", Image = "datascience.jpg", Price = 175, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 4, InstructorName = "Dr. Zainab Dawoud" },
                new Course { CourseId = 20, CourseTitle = "Cloud Computing with AWS", Description = "Learn the basics of cloud services using Amazon Web Services.", Image = "aws_cloud.png", Price = 180, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 4, InstructorName = "Eng. Rami Said" },

                // == English (Category 5) ==
                new Course { CourseId = 21, CourseTitle = "English Grammar Essentials", Description = "Master the core rules of English grammar and punctuation.", Image = "grammar.jpg", Price = 90, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 5, InstructorName = "Ms. Sarah Jones" },
                new Course { CourseId = 22, CourseTitle = "Creative Writing: Fiction & Poetry", Description = "Develop your skills in writing compelling stories and poems.", Image = "creative_writing.jpg", Price = 85, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 5, InstructorName = "Mr. David Miller" },
                new Course { CourseId = 23, CourseTitle = "Advanced English Composition", Description = "Learn techniques for crafting effective essays and reports.", Image = "composition.jpg", Price = 95, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 5, InstructorName = "Dr. Emily White" },
                new Course { CourseId = 24, CourseTitle = "Business English Communication", Description = "Improve your professional writing and speaking skills.", Image = "business_english.jpg", Price = 110, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 5, InstructorName = "Mr. John Smith" },
                new Course { CourseId = 25, CourseTitle = "Survey of English Literature", Description = "Explore major authors and works from Old English to Modern.", Image = "english_literature.jpg", Price = 100, Available = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow, CategoryId = 5, InstructorName = "Prof. Laura Brown" }
            );

            // --- Seed Lessons ---
            // Note: Video names are placeholders. Lesson titles are now direct topics.
            modelBuilder.Entity<lesson>().HasData(
                // == Lessons for Science Courses ==
                // CourseId = 1: Physics 101
                new lesson { lessonId = 1, courseId = 1, lessonTitle = "Introduction to Mechanics", lessonVideo = "physics_101_L1.mp4" },
                new lesson { lessonId = 2, courseId = 1, lessonTitle = "Kinematics and Motion", lessonVideo = "physics_101_L2.mp4" },
                new lesson { lessonId = 3, courseId = 1, lessonTitle = "Newton's Laws of Motion", lessonVideo = "physics_101_L3.mp4" },
                new lesson { lessonId = 4, courseId = 1, lessonTitle = "Work, Energy, and Power", lessonVideo = "physics_101_L4.mp4" },
                new lesson { lessonId = 5, courseId = 1, lessonTitle = "Basics of Thermodynamics", lessonVideo = "physics_101_L5.mp4" },

                // CourseId = 4: Chemistry Fundamentals
                new lesson { lessonId = 6, courseId = 4, lessonTitle = "Atoms, Molecules, and Ions", lessonVideo = "chemistry_L1.mp4" },
                new lesson { lessonId = 7, courseId = 4, lessonTitle = "Chemical Bonding", lessonVideo = "chemistry_L2.mp4" },
                new lesson { lessonId = 8, courseId = 4, lessonTitle = "Stoichiometry and Moles", lessonVideo = "chemistry_L3.mp4" },
                new lesson { lessonId = 9, courseId = 4, lessonTitle = "States of Matter (Gas, Liquid, Solid)", lessonVideo = "chemistry_L4.mp4" },
                new lesson { lessonId = 10, courseId = 4, lessonTitle = "Types of Chemical Reactions", lessonVideo = "chemistry_L5.mp4" },

                // CourseId = 5: Introduction to Biology
                new lesson { lessonId = 11, courseId = 5, lessonTitle = "The Science of Life and The Cell", lessonVideo = "biology_L1.mp4" },
                new lesson { lessonId = 12, courseId = 5, lessonTitle = "Genetics and DNA", lessonVideo = "biology_L2.mp4" },
                new lesson { lessonId = 13, courseId = 5, lessonTitle = "Evolution and Natural Selection", lessonVideo = "biology_L3.mp4" },
                new lesson { lessonId = 14, courseId = 5, lessonTitle = "Introduction to Ecology", lessonVideo = "biology_L4.mp4" },
                new lesson { lessonId = 15, courseId = 5, lessonTitle = "Human Anatomy Overview", lessonVideo = "biology_L5.mp4" },

                // CourseId = 6: Astronomy: Exploring the Cosmos
                new lesson { lessonId = 16, courseId = 6, lessonTitle = "Our Solar System", lessonVideo = "astronomy_L1.mp4" },
                new lesson { lessonId = 17, courseId = 6, lessonTitle = "Stars, Nebulae, and Galaxies", lessonVideo = "astronomy_L2.mp4" },
                new lesson { lessonId = 18, courseId = 6, lessonTitle = "The Big Bang and Cosmology", lessonVideo = "astronomy_L3.mp4" },
                new lesson { lessonId = 19, courseId = 6, lessonTitle = "Telescopes and Observation", lessonVideo = "astronomy_L4.mp4" },
                new lesson { lessonId = 20, courseId = 6, lessonTitle = "The Future of Space Exploration", lessonVideo = "astronomy_L5.mp4" },

                // CourseId = 7: Environmental Science Basics
                new lesson { lessonId = 21, courseId = 7, lessonTitle = "Introduction to Ecosystems", lessonVideo = "env_science_L1.mp4" },
                new lesson { lessonId = 22, courseId = 7, lessonTitle = "Pollution and Its Effects", lessonVideo = "env_science_L2.mp4" },
                new lesson { lessonId = 23, courseId = 7, lessonTitle = "Biodiversity and Conservation", lessonVideo = "env_science_L3.mp4" },
                new lesson { lessonId = 24, courseId = 7, lessonTitle = "Understanding Climate Change", lessonVideo = "env_science_L4.mp4" },
                new lesson { lessonId = 25, courseId = 7, lessonTitle = "Sustainable Practices", lessonVideo = "env_science_L5.mp4" },

                // == Lessons for Mathematics Courses ==
                // CourseId = 2: Calculus for Beginners
                new lesson { lessonId = 26, courseId = 2, lessonTitle = "Introduction to Limits", lessonVideo = "calculus_L1.mp4" },
                new lesson { lessonId = 27, courseId = 2, lessonTitle = "Derivatives and Differentiation Rules", lessonVideo = "calculus_L2.mp4" },
                new lesson { lessonId = 28, courseId = 2, lessonTitle = "Applications of Derivatives", lessonVideo = "calculus_L3.mp4" },
                new lesson { lessonId = 29, courseId = 2, lessonTitle = "Introduction to Integrals", lessonVideo = "calculus_L4.mp4" },
                new lesson { lessonId = 30, courseId = 2, lessonTitle = "The Fundamental Theorem of Calculus", lessonVideo = "calculus_L5.mp4" },

                // CourseId = 8: Algebra Essentials
                new lesson { lessonId = 31, courseId = 8, lessonTitle = "Real Numbers and Operations", lessonVideo = "algebra_L1.mp4" },
                new lesson { lessonId = 32, courseId = 8, lessonTitle = "Solving Linear Equations and Inequalities", lessonVideo = "algebra_L22.mp4" },
                new lesson { lessonId = 33, courseId = 8, lessonTitle = "Polynomials and Factoring", lessonVideo = "algebra_L3.mp4" },
                new lesson { lessonId = 34, courseId = 8, lessonTitle = "Rational Expressions", lessonVideo = "algebra_L4.mp4" },
                new lesson { lessonId = 35, courseId = 8, lessonTitle = "Functions and Graphs", lessonVideo = "algebra_L5.mp4" },

                // CourseId = 9: Statistics and Probability
                new lesson { lessonId = 36, courseId = 9, lessonTitle = "Introduction to Statistics and Data", lessonVideo = "statistics_L1.mp4" },
                new lesson { lessonId = 37, courseId = 9, lessonTitle = "Descriptive Statistics (Mean, Median, Mode)", lessonVideo = "statistics_L2.mp4" },
                new lesson { lessonId = 38, courseId = 9, lessonTitle = "Basic Probability Concepts", lessonVideo = "statistics_L3.mp4" },
                new lesson { lessonId = 39, courseId = 9, lessonTitle = "Discrete and Continuous Distributions", lessonVideo = "statistics_L4.mp4" },
                new lesson { lessonId = 40, courseId = 9, lessonTitle = "Introduction to Hypothesis Testing", lessonVideo = "statistics_L5.mp4" },

                // CourseId = 10: Geometry: Shapes and Space
                new lesson { lessonId = 41, courseId = 10, lessonTitle = "Points, Lines, Angles, and Planes", lessonVideo = "geometry_L1.mp4" },
                new lesson { lessonId = 42, courseId = 10, lessonTitle = "Triangles and Their Properties", lessonVideo = "geometry_L2.mp4" },
                new lesson { lessonId = 43, courseId = 10, lessonTitle = "Quadrilaterals and Polygons", lessonVideo = "geometry_L3.mp4" },
                new lesson { lessonId = 44, courseId = 10, lessonTitle = "Circles", lessonVideo = "geometry_L4.mp4" },
                new lesson { lessonId = 45, courseId = 10, lessonTitle = "Area, Perimeter, and Volume", lessonVideo = "geometry_L5.mp4" },

                // CourseId = 11: Trigonometry Fundamentals
                new lesson { lessonId = 46, courseId = 11, lessonTitle = "Angles and Radian Measure", lessonVideo = "trigonometry_L1.mp4" },
                new lesson { lessonId = 47, courseId = 11, lessonTitle = "Right Triangle Trigonometry (SOH CAH TOA)", lessonVideo = "trigonometry_L2.mp4" },
                new lesson { lessonId = 48, courseId = 11, lessonTitle = "The Unit Circle", lessonVideo = "trigonometry_L3.mp4" },
                new lesson { lessonId = 49, courseId = 11, lessonTitle = "Graphs of Trigonometric Functions", lessonVideo = "trigonometry_L4.mp4" },
                new lesson { lessonId = 50, courseId = 11, lessonTitle = "Basic Trigonometric Identities", lessonVideo = "trigonometry_L5.mp4" },

                // == Lessons for Geography Courses ==
                // CourseId = 3: Introduction to Physical Geography
                new lesson { lessonId = 51, courseId = 3, lessonTitle = "What is Physical Geography?", lessonVideo = "phys_geo_L1.mp4" },
                new lesson { lessonId = 52, courseId = 3, lessonTitle = "Earth's Atmosphere and Weather", lessonVideo = "phys_geo_L2.mp4" },
                new lesson { lessonId = 53, courseId = 3, lessonTitle = "Landforms and Geomorphology", lessonVideo = "phys_geo_L3.mp4" },
                new lesson { lessonId = 54, courseId = 3, lessonTitle = "Water Systems: Oceans and Rivers", lessonVideo = "phys_geo_L4.mp4" },
                new lesson { lessonId = 55, courseId = 3, lessonTitle = "Biogeography and Ecosystems", lessonVideo = "phys_geo_L5.mp4" },

                // CourseId = 12: World Regional Geography
                new lesson { lessonId = 56, courseId = 12, lessonTitle = "Introduction to Regions", lessonVideo = "world_regions_L1.mp4" },
                new lesson { lessonId = 57, courseId = 12, lessonTitle = "North and South America", lessonVideo = "world_regions_L2.mp4" },
                new lesson { lessonId = 58, courseId = 12, lessonTitle = "Europe and Russia", lessonVideo = "world_regions_L3.mp4" },
                new lesson { lessonId = 59, courseId = 12, lessonTitle = "Asia and the Middle East", lessonVideo = "world_regions_L4.mp4" },
                new lesson { lessonId = 60, courseId = 12, lessonTitle = "Africa and Oceania", lessonVideo = "world_regions_L5.mp4" },

                // CourseId = 13: Introduction to GIS
                new lesson { lessonId = 61, courseId = 13, lessonTitle = "What is GIS and Spatial Data?", lessonVideo = "gis_L1.mp4" },
                new lesson { lessonId = 62, courseId = 13, lessonTitle = "Vector and Raster Data Models", lessonVideo = "gis_L2.mp4" },
                new lesson { lessonId = 63, courseId = 13, lessonTitle = "Basic Spatial Analysis", lessonVideo = "gis_L3.mp4" },
                new lesson { lessonId = 64, courseId = 13, lessonTitle = "Map Projections and Coordinate Systems", lessonVideo = "gis_L4.mp4" },
                new lesson { lessonId = 65, courseId = 13, lessonTitle = "Introduction to Cartography and Map Design", lessonVideo = "gis_L5.mp4" },

                // CourseId = 14: Urban Geography
                new lesson { lessonId = 66, courseId = 14, lessonTitle = "The Study of Cities", lessonVideo = "urban_geo_L1.mp4" },
                new lesson { lessonId = 67, courseId = 14, lessonTitle = "Urbanization and City Origins", lessonVideo = "urban_geo_L2.mp4" },
                new lesson { lessonId = 68, courseId = 14, lessonTitle = "Internal Structure of Cities (Models)", lessonVideo = "urban_geo_L3.mp4" },
                new lesson { lessonId = 69, courseId = 14, lessonTitle = "Urban Challenges (Housing, Transport)", lessonVideo = "urban_geo_L4.mp4" },
                new lesson { lessonId = 70, courseId = 14, lessonTitle = "Global Cities and Future Urban Trends", lessonVideo = "urban_geo_L5.mp4" },

                // CourseId = 15: Climatology Basics
                new lesson { lessonId = 71, courseId = 15, lessonTitle = "Earth's Climate System", lessonVideo = "climatology_L1.mp4" },
                new lesson { lessonId = 72, courseId = 15, lessonTitle = "Atmospheric Circulation", lessonVideo = "climatology_L2.mp4" },
                new lesson { lessonId = 73, courseId = 15, lessonTitle = "World Climate Zones (Koppen System)", lessonVideo = "climatology_L3.mp4" },
                new lesson { lessonId = 74, courseId = 15, lessonTitle = "Climate Change: Causes and Impacts", lessonVideo = "climatology_L4.mp4" },
                new lesson { lessonId = 75, courseId = 15, lessonTitle = "Paleoclimatology (Past Climates)", lessonVideo = "climatology_L5.mp4" },

                // == Lessons for Technology Courses ==
                // CourseId = 16: Introduction to Python Programming
                new lesson { lessonId = 76, courseId = 16, lessonTitle = "Introduction and Setup", lessonVideo = "python_L1.mp4" },
                new lesson { lessonId = 77, courseId = 16, lessonTitle = "Variables, Data Types, and Operators", lessonVideo = "python_L2.mp4" },
                new lesson { lessonId = 78, courseId = 16, lessonTitle = "Control Flow (If, Loops)", lessonVideo = "python_L3.mp4" },
                new lesson { lessonId = 79, courseId = 16, lessonTitle = "Functions and Modules", lessonVideo = "python_L4.mp4" },
                new lesson { lessonId = 80, courseId = 16, lessonTitle = "Basic Data Structures (Lists, Dictionaries)", lessonVideo = "python_L5.mp4" },

                // CourseId = 17: Web Development Basics (HTML, CSS, JS)
                new lesson { lessonId = 81, courseId = 17, lessonTitle = "Introduction to HTML", lessonVideo = "webdev_L1.mp4" },
                new lesson { lessonId = 82, courseId = 17, lessonTitle = "Styling with CSS", lessonVideo = "webdev_L2.mp4" },
                new lesson { lessonId = 83, courseId = 17, lessonTitle = "CSS Box Model and Layouts", lessonVideo = "webdev_L3.mp4" },
                new lesson { lessonId = 84, courseId = 17, lessonTitle = "Introduction to JavaScript", lessonVideo = "webdev_L4.mp4" },
                new lesson { lessonId = 85, courseId = 17, lessonTitle = "JavaScript DOM Manipulation", lessonVideo = "webdev_L5.mp4" },

                // CourseId = 18: Cybersecurity Fundamentals
                new lesson { lessonId = 86, courseId = 18, lessonTitle = "Introduction to Cybersecurity Threats", lessonVideo = "cybersecurity_L1.mp4" },
                new lesson { lessonId = 87, courseId = 18, lessonTitle = "Network Security Basics", lessonVideo = "cybersecurity_L2.mp4" },
                new lesson { lessonId = 88, courseId = 18, lessonTitle = "Cryptography Essentials", lessonVideo = "cybersecurity_L3.mp4" },
                new lesson { lessonId = 89, courseId = 18, lessonTitle = "Web Application Security", lessonVideo = "cybersecurity_L4.mp4" },
                new lesson { lessonId = 90, courseId = 18, lessonTitle = "Security Policies and Best Practices", lessonVideo = "cybersecurity_L5.mp4" },

                // CourseId = 19: Data Science Essentials
                new lesson { lessonId = 91, courseId = 19, lessonTitle = "What is Data Science?", lessonVideo = "datascience_L1.mp4" },
                new lesson { lessonId = 92, courseId = 19, lessonTitle = "Data Acquisition and Cleaning", lessonVideo = "datascience_L2.mp4" },
                new lesson { lessonId = 93, courseId = 19, lessonTitle = "Exploratory Data Analysis (EDA)", lessonVideo = "datascience_L3.mp4" },
                new lesson { lessonId = 94, courseId = 19, lessonTitle = "Introduction to Machine Learning Concepts", lessonVideo = "datascience_L4.mp4" },
                new lesson { lessonId = 95, courseId = 19, lessonTitle = "Data Visualization Techniques", lessonVideo = "datascience_L5.mp4" },

                // CourseId = 20: Cloud Computing with AWS
                new lesson { lessonId = 96, courseId = 20, lessonTitle = "Introduction to Cloud Computing and AWS", lessonVideo = "aws_cloud_L1.mp4" },
                new lesson { lessonId = 97, courseId = 20, lessonTitle = "Core AWS Services (EC2, S3)", lessonVideo = "aws_cloud_L2.mp4" },
                new lesson { lessonId = 98, courseId = 20, lessonTitle = "AWS Networking (VPC)", lessonVideo = "aws_cloud_L3.mp4" },
                new lesson { lessonId = 99, courseId = 20, lessonTitle = "AWS Databases (RDS, DynamoDB)", lessonVideo = "aws_cloud_L4.mp4" },
                new lesson { lessonId = 100, courseId = 20, lessonTitle = "AWS Security and IAM", lessonVideo = "aws_cloud_L5.mp4" },

                // == Lessons for English Courses ==
                // CourseId = 21: English Grammar Essentials
                new lesson { lessonId = 101, courseId = 21, lessonTitle = "Parts of Speech (Nouns, Verbs, Adjectives)", lessonVideo = "grammar_L1.mp4" },
                new lesson { lessonId = 102, courseId = 21, lessonTitle = "Sentence Structure (Subjects, Predicates, Clauses)", lessonVideo = "grammar_L2.mp4" },
                new lesson { lessonId = 103, courseId = 21, lessonTitle = "Verb Tenses and Forms", lessonVideo = "grammar_L3.mp4" },
                new lesson { lessonId = 104, courseId = 21, lessonTitle = "Punctuation (Commas, Semicolons, Apostrophes)", lessonVideo = "grammar_L4.mp4" },
                new lesson { lessonId = 105, courseId = 21, lessonTitle = "Common Grammatical Errors", lessonVideo = "grammar_L5.mp4" },

                // CourseId = 22: Creative Writing: Fiction & Poetry
                new lesson { lessonId = 106, courseId = 22, lessonTitle = "Finding Inspiration and Ideas", lessonVideo = "creative_write_L1.mp4" },
                new lesson { lessonId = 107, courseId = 22, lessonTitle = "Character Development", lessonVideo = "creative_write_L2.mp4" },
                new lesson { lessonId = 108, courseId = 22, lessonTitle = "Plotting and Story Structure", lessonVideo = "creative_write_L3.mp4" },
                new lesson { lessonId = 109, courseId = 22, lessonTitle = "Writing Vivid Descriptions and Settings", lessonVideo = "creative_write_L4.mp4" },
                new lesson { lessonId = 110, courseId = 22, lessonTitle = "Introduction to Poetic Forms", lessonVideo = "creative_write_L5.mp4" },

                // CourseId = 23: Advanced English Composition
                new lesson { lessonId = 111, courseId = 23, lessonTitle = "Understanding the Writing Process", lessonVideo = "composition_L1.mp4" },
                new lesson { lessonId = 112, courseId = 23, lessonTitle = "Crafting Strong Thesis Statements", lessonVideo = "composition_L2.mp4" },
                new lesson { lessonId = 113, courseId = 23, lessonTitle = "Developing Effective Paragraphs", lessonVideo = "composition_L3.mp4" },
                new lesson { lessonId = 114, courseId = 23, lessonTitle = "Argumentation and Persuasion", lessonVideo = "composition_L4.mp4" },
                new lesson { lessonId = 115, courseId = 23, lessonTitle = "Research, Citation, and Avoiding Plagiarism", lessonVideo = "composition_L5.mp4" },

                // CourseId = 24: Business English Communication
                new lesson { lessonId = 116, courseId = 24, lessonTitle = "Professional Email Etiquette", lessonVideo = "business_english_L1.mp4" },
                new lesson { lessonId = 117, courseId = 24, lessonTitle = "Writing Effective Memos and Reports", lessonVideo = "business_english_L2.mp4" },
                new lesson { lessonId = 118, courseId = 24, lessonTitle = "Delivering Engaging Presentations", lessonVideo = "business_english_L3.mp4" },
                new lesson { lessonId = 119, courseId = 24, lessonTitle = "Language for Meetings and Negotiations", lessonVideo = "business_english_L4.mp4" },
                new lesson { lessonId = 120, courseId = 24, lessonTitle = "Cross-Cultural Communication", lessonVideo = "business_english_L5.mp4" },

                // CourseId = 25: Survey of English Literature
                new lesson { lessonId = 121, courseId = 25, lessonTitle = "Old English and Medieval Literature (Beowulf, Chaucer)", lessonVideo = "eng_lit_L1.mp4" },
                new lesson { lessonId = 122, courseId = 25, lessonTitle = "The Renaissance (Shakespeare, Marlowe)", lessonVideo = "eng_lit_L2.mp4" },
                new lesson { lessonId = 123, courseId = 25, lessonTitle = "18th and 19th Century Literature (Austen, Dickens)", lessonVideo = "eng_lit_L3.mp4" },
                new lesson { lessonId = 124, courseId = 25, lessonTitle = "Modernism (Woolf, Eliot, Joyce)", lessonVideo = "eng_lit_L4.mp4" },
                new lesson { lessonId = 125, courseId = 25, lessonTitle = "Contemporary Literature and Trends", lessonVideo = "eng_lit_L5.mp4" }
            );
        }
    }
}