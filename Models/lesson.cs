using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_learningPlatform.Models
{
    public class lesson
    {
        [Key]
        public int lessonId { get; set; }
        public string lessonTitle { get; set; }

        public string lessonVideo { get; set; }



        // Navigation Properties
        [ForeignKey("Course")]
        public int courseId { get; set; }
        public Course Course { get; set; }


    }
}
