using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learningPlatform.Models
{
    public class lesson
    {
        [Key]
        public int lessonId { get; set; }
        public string lessonTitle { get; set; }
        public string lessonDescription { get; set; }
        public string lessonContent { get; set; }
        public string lessonVideo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }


        // Navigation Properties
        [ForeignKey("Course")]
        public int courseId { get; set; }
        public Course Course { get; set; }


    }
}
