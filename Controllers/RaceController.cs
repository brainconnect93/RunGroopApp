using Microsoft.AspNetCore.Mvc;

namespace RunGroopApp.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
