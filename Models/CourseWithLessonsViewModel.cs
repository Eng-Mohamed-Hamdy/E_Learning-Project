using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class CourseWithLessonsViewModel
    {
        // Course Properties
        public int CourseId { get; set; }
        
        [Required(ErrorMessage = "Course title is required")]
        public string CourseTitle { get; set; } = string.Empty;
        
        public string? Description { get; set; }
        
        public string? Image { get; set; }
        
        [Required(ErrorMessage = "Price is required")]
        public int Price { get; set; }
        
        public bool Available { get; set; } = true;
        
        [Required(ErrorMessage = "Instructor name is required")]
        public string InstructorName { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Category is required")]
        public int CategoryId { get; set; }
        
        // Lesson Properties
        public List<LessonViewModel> Lessons { get; set; } = new List<LessonViewModel>();
    }

    public class LessonViewModel
    {
        public int LessonId { get; set; }
        
        // Required only if the lesson is visible or being submitted
        public string LessonTitle { get; set; } = string.Empty;
        
        // Required only if the lesson is visible or being submitted
        public string LessonVideo { get; set; } = string.Empty;
    }
}