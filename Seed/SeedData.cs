using E_learningPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace E_learningPlatform.Seed
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Science"
                },
                new Category
                {
                    Id = 2,
                    Name = "Mathematics"
                },
                new Category
                {
                    Id = 3,
                    Name = "History"
                }
            );

            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    CourseId = 1,
                    CourseTitle = "Physics 101",
                    Description = "Introduction to Physics",
                    Image = "physics101.jpg",
                    Price = 100,
                    Available = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CategoryId = 1, // Science
                    InstructorName = "Mr. Ahmed Adel" // New property
                },
                new Course
                {
                    CourseId = 2,
                    CourseTitle = "Calculus for Beginners",
                    Description = "Learn the basics of Calculus",
                    Image = "calculus.jpg",
                    Price = 80,
                    Available = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CategoryId = 2, // Mathematics
                    InstructorName = "Mr. Moahmed Ahmed"
                },
                new Course
                {
                    CourseId = 3,
                    CourseTitle = "World History",
                    Description = "A comprehensive look at World History",
                    Image = "history.jpg",
                    Price = 120,
                    Available = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CategoryId = 3, // History
                    InstructorName = "Mr. Sayed Alaa"
                }
            );
        }
    }
}
