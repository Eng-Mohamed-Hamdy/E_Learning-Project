using Microsoft.AspNetCore.Mvc;
using E_learningPlatform.Data;
using E_learningPlatform.Models;
using E_learningPlatform.DTO;
using Microsoft.EntityFrameworkCore;

namespace E_learningPlatform.Controllers
{
    public class CourseController : Controller
    {
        private readonly ElearnDbContext _context;

        public CourseController(ElearnDbContext context)
        {
            _context = context;
        }

        // GET: /Course
        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses
                .Select(c => new courseDTO
                {
                    CourseId = c.CourseId,
                    CourseTitle = c.CourseTitle,
                    Description = c.Description,
                    Image = c.Image,
                    Price = c.Price,
                    Available = c.Available,
                    CreatedAt = c.CreatedAt,
                    UpdatedAt = c.UpdatedAt,
                    catogryid = c.CategoryId,
                    InstructorName = c.InstructorName // Add this line
                })
                .ToListAsync();

            return View(courses); 
        }
    }
}
