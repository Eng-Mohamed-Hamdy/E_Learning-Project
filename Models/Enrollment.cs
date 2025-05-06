using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }

        public string PaymentMethod { get; set; }

        [ForeignKey("Student")]
        public Guid StudentId { get; set; }

        [ForeignKey("Course")]
        public int courseId { get; set; }

        // Navigation property 
        public Course Course { get; set; }
        public User Student { get; set; }
    }
}
