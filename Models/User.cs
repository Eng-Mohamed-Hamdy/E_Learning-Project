using Microsoft.AspNetCore.Identity;

namespace E_learningPlatform.Models
{
    public class User : IdentityUser<Guid>
    {
        // Navigation property for student
        public ICollection<Course> Courses { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
