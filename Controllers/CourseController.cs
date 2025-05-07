using Microsoft.AspNetCore.Mvc;
using E_learningPlatform.Data; 
using E_learningPlatform.Models;
using E_learningPlatform.DTO; 
using Microsoft.EntityFrameworkCore;
using System.Linq; 
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering; 

namespace E_learningPlatform.Controllers
{
    public class CourseController : Controller
    {
        private readonly ElearnDbContext _context;

        public CourseController(ElearnDbContext context)
        {
            _context = context;
        }

        // Get For Courses Page
        public async Task<IActionResult> Index(int category = 2)
        {
            var categories = await _context.Categories.ToListAsync();
            ViewData["Categories"] = categories;

            var courses = await _context.Courses
                .Include(c => c.Category)
                .Where(c => c.CategoryId == category)
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
                    InstructorName = c.InstructorName
                })
                .OrderBy(c => c.CourseTitle)
                .ToListAsync();

            return View(courses);
        }


        // Get for Course Details Page
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
         
                return NotFound("Course ID not provided.");
            }

 
            var course = await _context.Courses
                .Include(c => c.Category) 
                .Include(c => c.lessons)  
                .FirstOrDefaultAsync(m => m.CourseId == id.Value); 

            if (course == null)
            {
                return NotFound($"Course with ID {id} not found.");
            }

            return View(course); 
        }

       // Get Enroll with id
        public IActionResult Enroll(int id)
        {
         
            return RedirectToAction("Payment", "Enrollment", new { id = id }); // send to enrollment controller 
        }
    }
}