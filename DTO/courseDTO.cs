﻿using System.ComponentModel.DataAnnotations.Schema;

namespace E_learningPlatform.DTO
{
    public class courseDTO
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Price { get; set; }
        public bool Available { get; set; } = true;
        public string InstructorName { get; set; } // New property

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? UpdatedAt { get; set; }
        public int catogryid { get; set; }
        
        // Added property to store the category name
        public string? CategoryName { get; set; }
    }
}
