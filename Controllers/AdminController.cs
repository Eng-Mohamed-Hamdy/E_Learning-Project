using Microsoft.AspNetCore.Mvc;

namespace E_learningPlatform.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index() // admin dashboard
        {
            return View();
        }
    }
}
