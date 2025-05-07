using E_learningPlatform.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System; 
using System.Threading.Tasks;

namespace E_learningPlatform.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager; 
        private readonly ILogger<AccountController> _logger;


        public AccountController(
            UserManager<User> userManager,
            SignInManager<User> signInManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            ILogger<AccountController> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _logger = logger;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register() // register page
        {
            ViewBag.Roles = new List<string> { "Student" };
            return View();
        }


        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model) // register action
        {
            ViewBag.Roles = new List<string> { "Student" }; 

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
                    _logger.LogInformation($"User {model.UserName} created a new account with password.");

                    // --- Assign Role ---
                    if (!string.IsNullOrEmpty(model.Role))
                    {

                        var roleExists = await _roleManager.RoleExistsAsync(model.Role);
                        if (roleExists)
                        {
                            var roleResult = await _userManager.AddToRoleAsync(user, model.Role);
                            if (!roleResult.Succeeded)
                            {
                                _logger.LogError($"Could not add user {user.UserName} to role {model.Role}.");
                            }
                            else
                            {
                                _logger.LogInformation($"User {user.UserName} added to role {model.Role}.");
                            }
                        }
                        else
                        {
                            _logger.LogWarning($"Role {model.Role} not found for user {user.UserName}.");
 
                        }
                    }



                    return RedirectToAction("Login", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }


            return View(model);
        }


        
        [AllowAnonymous]
        public IActionResult Login(string? returnUrl = null) // login page
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

 
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null) // login action
        {
            ViewData["ReturnUrl"] = returnUrl;
            returnUrl ??= Url.Content("~/"); //  redirect to home

            if (ModelState.IsValid)
            {
                // Find the user by email first
                var user = await _userManager.FindByEmailAsync(model.Email);
                
                // If user exists, try to sign in with the found username
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, isPersistent: false, lockoutOnFailure: false);

                    if (result.Succeeded)
                    {
                        _logger.LogInformation($"User {model.Email} logged in.");
                        return LocalRedirect(returnUrl);
                    }
                }
                
                // If we got this far, something failed
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            }

            return View(model);
        }

        // POST: /Account/Logout
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            _logger.LogInformation("User logged out.");
            return RedirectToAction("Index", "Home");
        }


    }
}