using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class MyCourse
    {
        [Key]
        public int MycourseId { get; set; }


        [ForeignKey("Student")]
        public Guid StudentId { get; set; }
        public User Student { get; set; }

        [ForeignKey("Course")]
        public int courseId { get; set; }
        public Course Course { get; set; }

    }
}
