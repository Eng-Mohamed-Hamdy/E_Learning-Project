using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learningPlatform.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        
        [Required]
        public string CourseTitle { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; } = true;

        [Required]
        public string InstructorName { get; set; } = string.Empty;

        // We'll set this manually in the controller
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        // Foreign key
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        public virtual ICollection<User> students { get; set; } = new List<User>();
        public ICollection<lesson> lessons { get; set; } = new List<lesson>();

        public virtual ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
