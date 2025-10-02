using Microsoft.AspNetCore.Mvc;

namespace project_asp.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //post method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register()
        {
            return View();
        }
    }
}
