using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class CourseWithLessonsViewModel
    {
        // Course Properties
        public int CourseId { get; set; }
        
        [Required]
        public string CourseTitle { get; set; }
        
        public string? Description { get; set; }
        
        public string? Image { get; set; }
        
        [Required]
        public int Price { get; set; }
        
        public bool Available { get; set; } = true;
        
        [Required]
        public string InstructorName { get; set; }
        
        [Required]
        public int CategoryId { get; set; }
        
        // Lesson Properties
        public List<LessonViewModel> Lessons { get; set; } = new List<LessonViewModel>();
    }

    public class LessonViewModel
    {
        public int LessonId { get; set; }
        
        [Required]
        public string LessonTitle { get; set; }
        
        [Required]
        public string LessonVideo { get; set; }
    }
}