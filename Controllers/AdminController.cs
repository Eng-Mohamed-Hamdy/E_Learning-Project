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
        }

        // Admin Dashboard
        public IActionResult Index()
        {
            var stats = new AdminDashboardViewModel
            {
                TotalUsers = _userManager.Users.Count(),
                TotalCourses = _context.Courses.Count(),
                TotalCategories = _context.Categories.Count()
            };
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
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) return NotFound();

            var userRoles = await _userManager.GetRolesAsync(user);
            var model = new EditUserViewModel
            {
                Id = user.Id,
                UserName = user.UserName,
                Email = user.Email,
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
                if (user == null) return NotFound();

                // Update basic info
                user.UserName = model.UserName;
                user.Email = model.Email;
                var updateResult = await _userManager.UpdateAsync(user);

                if (updateResult.Succeeded)
                {
                    // Update roles
                    var currentRoles = await _userManager.GetRolesAsync(user);
                    await _userManager.RemoveFromRolesAsync(user, currentRoles);
                    await _userManager.AddToRolesAsync(user, model.SelectedRoles);

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
    }
}