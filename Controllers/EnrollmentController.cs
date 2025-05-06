using Microsoft.AspNetCore.Mvc;
using E_learningPlatform.Data;
using E_learningPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace E_learningPlatform.Controllers
{
    [Authorize]
    public class EnrollmentController : Controller
    {
        private readonly ElearnDbContext _context;

        public EnrollmentController(ElearnDbContext context)
        {
            _context = context;
        }

        // Get for payment page ( takes course id )
        public async Task<IActionResult> Payment(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.CourseId == id);

            if (course == null)
            {
                return NotFound();
            }

            var viewModel = new PaymentViewModel
            {
                CourseId = course.CourseId,
                CourseTitle = course.CourseTitle,
                Price = course.Price
            };

            return View(viewModel);
        }

        // Post for payment ( adding course to MyCourses page after payment success )
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessPayment(PaymentViewModel model)
        {
            //if (!ModelState.IsValid) // no validations for now 
            //{
            //    return View("Payment", model);
            //}

            // Get the current user's ID
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account");
            }

            // Create a new enrollment record
            var enrollment = new Enrollment
            {
                StudentId = Guid.Parse(userId),
                courseId = model.CourseId,
                PaymentMethod = model.PaymentMethod
            };
            _context.Enrollments.Add(enrollment);

            // add to MyCourses for the student
            var myCourse = new MyCourse
            {
                StudentId = Guid.Parse(userId),
                courseId = model.CourseId
            };

            _context.MyCourses.Add(myCourse);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyCourses");
        }

        // Get for MyCourses Page
        public async Task<IActionResult> MyCourses()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
            {
                return RedirectToAction("Login", "Account");
            }

            // Get all courses enrolled by the current Student
            var myCourses = await _context.MyCourses
                .Include(mc => mc.Course)
                .Where(mc => mc.StudentId == Guid.Parse(userId))
                .ToListAsync();

            return View(myCourses);
        }

        public async Task<IActionResult> MyCoursePage(int courseId)
        {
            var MyCoursePage = _context.Lessons
                .Where(l => l.courseId == courseId)
                .ToList(); 

            return View(MyCoursePage); 
        }

    }
}

