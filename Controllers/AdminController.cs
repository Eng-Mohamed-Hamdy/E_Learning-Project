using E_learningPlatform.Data;
using E_learningPlatform.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace E_learningPlatform.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly ElearnDbContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;

        public AdminController(
            ElearnDbContext context,
            UserManager<User> userManager,
            RoleManager<IdentityRole<Guid>> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }        // Admin Dashboard
        public IActionResult Index()
        {
            // Basic stats
            var stats = new AdminDashboardViewModel
            {
                TotalUsers = _userManager.Users.Count(),
                TotalCourses = _context.Courses.Count(),
                TotalCategories = _context.Categories.Count(),
                      // New statistics
                TotalEnrollments = _context.Enrollments.Count(),
                TotalRevenue = _context.Enrollments.Sum(e => e.Course.Price),
                ActiveCourses = _context.Courses.Count(c => c.Available),
                InactiveCourses = _context.Courses.Count(c => !c.Available)
            };
              // Get top 5 courses by enrollment
            // First load all courses
            var courses = _context.Courses.ToList();
            
            // Create statistics for each course
            var courseStats = new List<CourseStatistic>();
            foreach (var course in courses)
            {
                // Count enrollments for this course
                var enrollmentCount = _context.Enrollments.Count(e => e.courseId == course.CourseId);
                
                courseStats.Add(new CourseStatistic
                {
                    CourseId = course.CourseId,
                    CourseTitle = course.CourseTitle,
                    EnrollmentCount = enrollmentCount,
                    Revenue = course.Price * enrollmentCount
                });
            }
            
            // Get top 5 courses
            stats.TopCourses = courseStats
                .OrderByDescending(c => c.EnrollmentCount)
                .Take(5)
                .ToList();// Get enrollments by category
            var enrollmentsByCategory = new Dictionary<string, int>();
            
            // Get all categories
            var categories = _context.Categories.ToList();
            
            // For each category, count enrollments
            foreach (var category in categories)
            {
                // Get courses in this category
                var courseIds = _context.Courses.Where(c => c.CategoryId == category.Id).Select(c => c.CourseId).ToList();
                
                // Count enrollments for these courses
                var enrollmentCount = _context.Enrollments.Count(e => courseIds.Contains(e.courseId));
                
                // Add to dictionary
                enrollmentsByCategory.Add(category.Name, enrollmentCount);
            }
            
            stats.EnrollmentsByCategory = enrollmentsByCategory;

            return View(stats);
        }

        // User Management
        public async Task<IActionResult> Users()
        {
            var users = await _userManager.Users.ToListAsync();
            var userViewModels = new List<UserViewModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                userViewModels.Add(new UserViewModel
                {
                    Id = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    Roles = roles
                });
            }
            return View(userViewModels);
        }

        // Edit User - GET
        [HttpGet]
        public async Task<IActionResult> EditUser(Guid userId)
        {            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return NotFound();

            var userRoles = await _userManager.GetRolesAsync(user);
            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName ?? string.Empty,
                Email = user.Email ?? string.Empty,
                Roles = userRoles
            };

            // Load all roles for the dropdown/checkboxes
            ViewBag.AllRoles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            return View(model);
        }

        // Edit User - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(EditUserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByIdAsync(model.Id.ToString());
                if (user == null) return NotFound();                // Update basic info
                user.UserName = model.UserName ?? string.Empty;
                user.Email = model.Email ?? string.Empty;
                var updateResult = await _userManager.UpdateAsync(user);

                if (updateResult.Succeeded)
                {                // Update roles
                    var currentRoles = await _userManager.GetRolesAsync(user);
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);
                    
                    // Check if SelectedRoles is not null before using it
                    if (model.SelectedRoles != null && model.SelectedRoles.Any())
                    {
                        await _userManager.AddToRolesAsync(user, model.SelectedRoles);
                    }

                    TempData["Success"] = "User updated successfully!";
                    return RedirectToAction("Users");
                }

                // Handle errors
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // Reload roles if validation fails
            ViewBag.AllRoles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUser(Guid userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user != null)
            {
                if (user.UserName == "Admin")
                {
                    TempData["Error"] = "Cannot delete the Super Admin.";
                    return RedirectToAction("Users");
                }

                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    TempData["Success"] = "User deleted successfully!";
                }
                else
                {
                    TempData["Error"] = "Failed to delete user.";
                }
            }
            return RedirectToAction("Users");
        }


        // Create Student
        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateStudent(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    UserName = model.UserName,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "Student");
                    TempData["Success"] = "Student created successfully!";
                    return RedirectToAction("Users");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View(model);
        }

        // Categories Management
        public async Task<IActionResult> Categories()
        {
            var categories = await _context.Categories
                .Include(c => c.Courses)
                .ToListAsync();
            return View(categories);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                // Check if a category with the same name already exists
                bool categoryExists = await _context.Categories.AnyAsync(c => c.Name.ToLower() == category.Name.ToLower());
                if (categoryExists)
                {
                    ModelState.AddModelError("Name", "A category with this name already exists.");
                    return View(category);
                }

                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Category created successfully!";
                return RedirectToAction("Categories");
            }
            return View(category);
        }

        [HttpGet]
        public async Task<IActionResult> EditCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(Category category)
        {
            if (ModelState.IsValid)
            {
                // Check if another category with the same name exists (excluding the current one)
                bool categoryExists = await _context.Categories
                    .AnyAsync(c => c.Id != category.Id && c.Name.ToLower() == category.Name.ToLower());
                    
                if (categoryExists)
                {
                    ModelState.AddModelError("Name", "A category with this name already exists.");
                    return View(category);
                }

                _context.Update(category);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Category updated successfully!";
                return RedirectToAction("Categories");
            }
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                // Check if there are any courses in this category
                var hasRelatedCourses = await _context.Courses.AnyAsync(c => c.CategoryId == id);
                
                if (hasRelatedCourses)
                {
                    TempData["Error"] = "Cannot delete category because it has related courses. Remove the courses first or reassign them to another category.";
                }
                else
                {
                    _context.Categories.Remove(category);
                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Category deleted successfully!";
                }
            }
            return RedirectToAction("Categories");
        }

        // Course Management
        public async Task<IActionResult> Courses()
        {
            var courses = await _context.Courses
                .Include(c => c.Category)
                .ToListAsync();
            return View(courses);
        }

        [HttpGet]
        public IActionResult CreateCourse()
        {
            // Create a view model with default empty lessons (e.g. 3 empty lesson fields to start)
            var viewModel = new CourseWithLessonsViewModel();
            for (int i = 0; i < 3; i++)
            {
                viewModel.Lessons.Add(new LessonViewModel());
            }

            // Populate categories for dropdown
            ViewBag.Categories = _context.Categories.ToList();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateCourse(CourseWithLessonsViewModel viewModel)
        {
            if (ModelState.IsValid)
            {                // Create new Course entity from view model
                var course = new Course
                {
                    CourseTitle = viewModel.CourseTitle,
                    Description = viewModel.Description,
                    Image = viewModel.Image,
                    Price = viewModel.Price,
                    Available = viewModel.Available,
                    InstructorName = viewModel.InstructorName,
                    CategoryId = viewModel.CategoryId,
                    CreatedAt = DateTime.UtcNow // Set the CreatedAt value
                };

                // Add the course first to get its ID
                _context.Courses.Add(course);
                await _context.SaveChangesAsync();

                // Now add lessons with the course ID
                foreach (var lessonViewModel in viewModel.Lessons.Where(l => !string.IsNullOrEmpty(l.LessonTitle) && !string.IsNullOrEmpty(l.LessonVideo)))
                {
                    var lesson = new lesson
                    {
                        lessonTitle = lessonViewModel.LessonTitle,
                        lessonVideo = lessonViewModel.LessonVideo,
                        courseId = course.CourseId
                    };
                    _context.Lessons.Add(lesson);
                }

                await _context.SaveChangesAsync();
                TempData["Success"] = "Course created successfully with lessons!";
                return RedirectToAction("Courses");
            }

            // If we got this far, something failed - redisplay form
            ViewBag.Categories = _context.Categories.ToList();
            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> EditCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }

            // Load associated lessons
            var lessons = await _context.Lessons
                .Where(l => l.courseId == id)
                .ToListAsync();
            
            // Create the view model
            var viewModel = new CourseWithLessonsViewModel
            {
                CourseId = course.CourseId,
                CourseTitle = course.CourseTitle,
                Description = course.Description,
                Image = course.Image,
                Price = course.Price,
                Available = course.Available,
                InstructorName = course.InstructorName,
                CategoryId = course.CategoryId
            };

            // Add existing lessons to the view model
            foreach (var lesson in lessons)
            {
                viewModel.Lessons.Add(new LessonViewModel
                {
                    LessonId = lesson.lessonId,
                    LessonTitle = lesson.lessonTitle,
                    LessonVideo = lesson.lessonVideo
                });
            }

            // Add a few empty lesson slots for new lessons
            for (int i = 0; i < 3; i++)
            {
                viewModel.Lessons.Add(new LessonViewModel());
            }

            // Populate categories for dropdown
            ViewBag.Categories = _context.Categories.ToList();
            return View(viewModel);
        }        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCourse(CourseWithLessonsViewModel viewModel)
        {
            // Log the model state for debugging
            if (!ModelState.IsValid)
            {
                foreach (var state in ModelState)
                {
                    if (state.Value.Errors.Count > 0)
                    {
                        Console.WriteLine($"Key: {state.Key}, Error: {string.Join(", ", state.Value.Errors.Select(e => e.ErrorMessage))}");
                    }
                }
            }
            
            // Continue if model is valid or force-process if data seems valid despite validation errors
            if (ModelState.IsValid || (viewModel.CourseId > 0 && !string.IsNullOrEmpty(viewModel.CourseTitle)))
            {
                try
                {
                    // Update the course details
                    var course = await _context.Courses.FindAsync(viewModel.CourseId);
                    if (course == null)
                    {
                        return NotFound();
                    }

                    // Update course properties
                    course.CourseTitle = viewModel.CourseTitle;
                    course.Description = viewModel.Description;
                    course.Image = viewModel.Image;
                    course.Price = viewModel.Price;
                    course.Available = viewModel.Available;
                    course.InstructorName = viewModel.InstructorName;
                    course.CategoryId = viewModel.CategoryId;

                    // Handle lessons - first get existing lessons
                    var existingLessons = await _context.Lessons
                        .Where(l => l.courseId == viewModel.CourseId)
                        .ToListAsync();

                    // Keep track of lessons that were submitted in the form
                    var submittedLessonIds = new HashSet<int>();

                    // Process each lesson from the view model
                    if (viewModel.Lessons != null)
                    {
                        foreach (var lessonVM in viewModel.Lessons)
                        {
                            // Skip empty lessons
                            if (string.IsNullOrEmpty(lessonVM.LessonTitle) || string.IsNullOrEmpty(lessonVM.LessonVideo))
                            {
                                continue;
                            }

                            if (lessonVM.LessonId > 0)
                            {
                                // Update existing lesson
                                var existingLesson = existingLessons.FirstOrDefault(l => l.lessonId == lessonVM.LessonId);
                                if (existingLesson != null)
                                {
                                    existingLesson.lessonTitle = lessonVM.LessonTitle;
                                    existingLesson.lessonVideo = lessonVM.LessonVideo;
                                    _context.Update(existingLesson);
                                    
                                    // Record this lesson as submitted
                                    submittedLessonIds.Add(lessonVM.LessonId);
                                }
                            }
                            else
                            {
                                // Add new lesson
                                var newLesson = new lesson
                                {
                                    lessonTitle = lessonVM.LessonTitle,
                                    lessonVideo = lessonVM.LessonVideo,
                                    courseId = viewModel.CourseId
                                };
                                _context.Lessons.Add(newLesson);
                            }
                        }                    // Delete lessons that were not included in the submission
                    // These are lessons that existed before but were removed by the user
                    foreach (var lesson in existingLessons)
                    {
                        // Remove lessons that were either not in the form or had empty titles/videos
                        if (!submittedLessonIds.Contains(lesson.lessonId))
                        {
                            _context.Lessons.Remove(lesson);
                        }
                    }
                    }

                    await _context.SaveChangesAsync();
                    TempData["Success"] = "Course and lessons updated successfully!";
                    return RedirectToAction("Courses");
                }
                catch (Exception ex)
                {
                    // Add more detailed error information
                    ModelState.AddModelError(string.Empty, $"Error saving changes: {ex.Message}");
                    if (ex.InnerException != null)
                    {
                        ModelState.AddModelError(string.Empty, $"Inner error: {ex.InnerException.Message}");
                    }

                    if (!CourseExists(viewModel.CourseId))
                    {
                        return NotFound();
                    }
                }
            }

            // If we got this far, something failed - redisplay form
            ViewBag.Categories = _context.Categories.ToList();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCourse(int id)
        {
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Course deleted successfully!";
            }
            return RedirectToAction("Courses");
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.CourseId == id);
        }
    }
}