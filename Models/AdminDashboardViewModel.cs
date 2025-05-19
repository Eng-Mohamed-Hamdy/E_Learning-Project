using System.Collections.Generic;

namespace E_learningPlatform.Models
{
    public class AdminDashboardViewModel
    {
        public int TotalUsers { get; set; }
        public int TotalCourses { get; set; }
        public int TotalCategories { get; set; }
        
        // New statistics
        public int TotalEnrollments { get; set; }
        public decimal TotalRevenue { get; set; }
        public int ActiveCourses { get; set; }
        public int InactiveCourses { get; set; }
        public int NewUsersThisMonth { get; set; }
        public int NewEnrollmentsThisMonth { get; set; }
        
        // Top performing courses by enrollment count
        public List<CourseStatistic> TopCourses { get; set; } = new List<CourseStatistic>();
        
        // Enrollments per category
        public Dictionary<string, int> EnrollmentsByCategory { get; set; } = new Dictionary<string, int>();
    }
    
    public class CourseStatistic
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public int EnrollmentCount { get; set; }
        public decimal Revenue { get; set; }
    }
}