using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppCinemaBooking.Areas.Admin.Data;

namespace WebAppCinemaBooking.Controllers
{
    public class HomeController : Controller
    {
        private readonly DPContext _context;

        public HomeController(DPContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            Random rand = new Random();
            ViewData["rand"] = rand.Next().ToString();
            return View(await _context.Movies.ToListAsync()); 
        }
    }
}
