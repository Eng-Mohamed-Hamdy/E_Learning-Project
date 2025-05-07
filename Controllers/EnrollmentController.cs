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
            // Get the current user's ID
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userIdString))
                return RedirectToAction("Login", "Account");

            var userId = Guid.Parse(userIdString);
            var courseId = model.CourseId;

            // Check if enrollment already exists
            var alreadyEnrolled = await _context.Enrollments
                .AnyAsync(e => e.StudentId == userId && e.courseId == courseId);
            if (!alreadyEnrolled)
            {
                var enrollment = new Enrollment
                {
                    StudentId = userId,
                    courseId = courseId,
                    PaymentMethod = model.PaymentMethod
                };
                _context.Enrollments.Add(enrollment);
            }

            // Check if MyCourse record already exists
            var hasCourse = await _context.MyCourses
                .AnyAsync(mc => mc.StudentId == userId && mc.courseId == courseId);
            if (!hasCourse)
            {
                var myCourse = new MyCourse
                {
                    StudentId = userId,
                    courseId = courseId
                };
                _context.MyCourses.Add(myCourse);
            }

            // Save only if we added anything
            if (!_context.ChangeTracker.HasChanges())
            {
                // nothing to save; maybe set a TempData message?
                TempData["Info"] = "You’re already enrolled in this course.";
            }
            else
            {
                await _context.SaveChangesAsync();
                TempData["Success"] = "Payment successful! The course has been added to your dashboard.";
            }

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

