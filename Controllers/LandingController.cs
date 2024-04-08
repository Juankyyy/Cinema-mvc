using Microsoft.AspNetCore.Mvc;

namespace Cinema.Controllers
{
    public class LandingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}