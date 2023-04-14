using Microsoft.AspNetCore.Mvc;

namespace Individual_Project_DevExtreme.Controllers
{
    public class WeatherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
