using Microsoft.EntityFrameworkCore;
using E_learningPlatform.DTO;
using E_learningPlatform.Models;
using System.Collections.Generic;
using E_learningPlatform.Seed;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace E_learningPlatform.Data
{
    public class ElearnDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public ElearnDbContext(DbContextOptions<ElearnDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exam>()
                        .HasOne(e => e.Lesson)
                        .WithMany()
                        .HasForeignKey(e => e.lessonId)
                        .OnDelete(DeleteBehavior.Restrict);

            SeedData.Seed(modelBuilder);
        }

        public DbSet<Course> Courses { get; set; }

        public DbSet<lesson> Lessons { get; set; }

        public DbSet<Exam> Exams { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<MyCourse> MyCourses { get; set; } 


    }
}
