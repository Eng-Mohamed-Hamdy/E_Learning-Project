using System.Diagnostics;
using E_learningPlatform.Models;
using Microsoft.AspNetCore.Mvc;
using E_learningPlatform.Data;
using Microsoft.EntityFrameworkCore;
using E_learningPlatform.DTO;
using System.Linq;
using System.Threading.Tasks;

namespace E_learningPlatform.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ElearnDbContext _context;

        public HomeController(ILogger<HomeController> logger, ElearnDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Get featured courses (for example: most recent or select a few)
            var featuredCourses = await _context.Courses
                .Include(c => c.Category)
                .Where(c => c.Available == true)
                .OrderByDescending(c => c.CreatedAt)
                .Take(3) // Take 3 featured courses
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
                    CategoryName = c.Category.Name,
                    InstructorName = c.InstructorName  // Add this line
                })
                .ToListAsync();

            return View(featuredCourses);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
