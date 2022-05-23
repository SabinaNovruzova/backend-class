using Microsoft.AspNetCore.Mvc;
using practice.DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace practice.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var sliders = _context.sliders.ToList();
            return View(sliders);
        }
    }
}
