﻿using Microsoft.AspNetCore.Mvc;

namespace RunGroopApp.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
