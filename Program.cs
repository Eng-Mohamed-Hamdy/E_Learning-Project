using E_learningPlatform.Data;
using E_learningPlatform.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System; 
using Microsoft.Extensions.Logging;

namespace E_learningPlatform
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // --- Database Context ---
            var connectionString = builder.Configuration.GetConnectionString("db") ?? throw new InvalidOperationException("Connection string 'db' not found.");
            builder.Services.AddDbContext<ElearnDbContext>(options =>
                options.UseSqlServer(connectionString));

            // --- Identity Services ---
            builder.Services.AddIdentity<User, IdentityRole<Guid>>(options => 
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = false; 
                options.Password.RequireUppercase = false; 
                options.Password.RequireNonAlphanumeric = false;
                options.SignIn.RequireConfirmedAccount = false; 
                options.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ElearnDbContext>() 
            .AddDefaultTokenProviders();

            // --- Configure Cookie Authentication ---
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(60);

                options.LoginPath = "/Account/Login"; 
                options.AccessDeniedPath = "/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            // Add services to the container.
            builder.Services.AddControllersWithViews();



            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

  
            app.UseAuthentication(); 
            app.UseAuthorization();  

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var roleManager = services.GetRequiredService<RoleManager<IdentityRole<Guid>>>();
                    var userManager = services.GetRequiredService<UserManager<User>>();
                    var logger = services.GetRequiredService<ILogger<Program>>();

                    logger.LogInformation("Seeding Database Roles and Admin User...");

                    // Roles
                    string[] roleNames = { "Admin", "Student" };
                    foreach (var roleName in roleNames)
                    {
                        var roleExist = await roleManager.RoleExistsAsync(roleName);
                        if (!roleExist)
                        {
                            var roleResult = await roleManager.CreateAsync(new IdentityRole<Guid>(roleName));
                            if (roleResult.Succeeded)
                            {
                                logger.LogInformation($"Role '{roleName}' created successfully.");
                            }
                            else
                            {
                                logger.LogError($"Error creating role '{roleName}'. Errors: {string.Join(", ", roleResult.Errors.Select(e => e.Description))}");
                            }
                        }
                    }

                    // Seed Admin User
                    string adminEmail = "admin@gmail.com";
                    string adminUserName = "Admin";
                    var adminUser = await userManager.FindByEmailAsync(adminEmail);

                    if (adminUser == null)
                    {
                        adminUser = new User
                        {
                            UserName = adminUserName,
                            Email = adminEmail,
                            EmailConfirmed = true 
                        };
  
                        var adminPassword = "123456"; 
                        var createAdminResult = await userManager.CreateAsync(adminUser, adminPassword);

                        if (createAdminResult.Succeeded)
                        {
                            logger.LogInformation("Admin user created successfully.");
                            // Assign Admin role
                            var addToRoleResult = await userManager.AddToRoleAsync(adminUser, "Admin");
                            if (addToRoleResult.Succeeded)
                            {
                                logger.LogInformation("Admin user added to 'Admin' role.");
                            }
                            else
                            {
                                logger.LogError($"Error adding Admin user to 'Admin' role: {string.Join(", ", addToRoleResult.Errors.Select(e => e.Description))}");
                            }
                        }
                        else
                        {
                            logger.LogError($"Error creating admin user: {string.Join(", ", createAdminResult.Errors.Select(e => e.Description))}");
                        }
                    }
                    else
                    {
                        logger.LogInformation("Admin user already exists.");
                    }
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred while seeding the database.");
                }
            }
           

            app.Run();
        }
    }
} 