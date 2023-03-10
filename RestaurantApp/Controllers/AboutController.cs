using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
