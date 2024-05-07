using Microsoft.AspNetCore.Mvc;
using RunGroopApp.Data;
using RunGroopApp.Models;

namespace RunGroopApp.Controllers
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }

        //public IActionResult Detail(int id)
        //{
            
        //}
    }
}
