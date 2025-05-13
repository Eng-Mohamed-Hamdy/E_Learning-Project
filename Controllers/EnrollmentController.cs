using Microsoft.AspNetCore.Mvc;
using E_learningPlatform.Data;
using E_learningPlatform.Models;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<IActionResult> Payment(int? id)
        {
            if (id == null) return NotFound();

            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.CourseId == id);

            if (course == null) return NotFound();

            ViewBag.CourseId = course.CourseId;
            ViewBag.CourseTitle = course.CourseTitle;
            ViewBag.Price = course.Price;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessPayment(int courseId)
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userIdString))
                return RedirectToAction("Login", "Account");

            var userId = Guid.Parse(userIdString);

            if (!await _context.Enrollments.AnyAsync(e => e.StudentId == userId && e.courseId == courseId))
            {
                _context.Enrollments.Add(new Enrollment
                {
                    StudentId = userId,
                    courseId = courseId,
                    PaymentMethod = "PayPal"
                });
            }

            if (!await _context.MyCourses.AnyAsync(mc => mc.StudentId == userId && mc.courseId == courseId))
            {
                _context.MyCourses.Add(new MyCourse
                {
                    StudentId = userId,
                    courseId = courseId
                });
            }

            if (_context.ChangeTracker.HasChanges())
            {
                await _context.SaveChangesAsync();
                TempData["Success"] = "Payment successful! Course added to My Course Page.";
            }
            else
            {
                TempData["Info"] = "You're already enrolled in this course.";
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

