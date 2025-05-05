using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        // Navigation property - Initialize the collection to prevent null reference issues
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
