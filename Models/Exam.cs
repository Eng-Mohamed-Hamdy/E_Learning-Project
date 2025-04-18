using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learningPlatform.Models
{
    public class Exam
    {
        [Key]
        public int Id { get; set; }
        public string ExamTitle { get; set; }
        public string ExamDescription { get; set; }
        public string Grade { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }

        // Navigation Properties
        [ForeignKey("Course")]
        public int courseId { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Lesson")]
        public int lessonId { get; set; }
        public lesson Lesson { get; set; }

    

    }
}
