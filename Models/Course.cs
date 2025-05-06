using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learningPlatform.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CourseTitle { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; } = true;

        [Required]
        public string InstructorName { get; set; } // New property

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        // Foreign key
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        public virtual ICollection<User> students { get; set; }
        public ICollection<lesson> lessons { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}
