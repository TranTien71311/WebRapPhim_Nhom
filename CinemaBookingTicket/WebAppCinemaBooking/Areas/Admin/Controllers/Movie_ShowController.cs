using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppCinemaBooking.Areas.Admin.Data;
using WebAppCinemaBooking.Areas.Admin.Models;

namespace WebAppCinemaBooking.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Movie_ShowController : Controller
    {
        private readonly DPContext _context;

        public Movie_ShowController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Movie_Show
        public async Task<IActionResult> Index()
        {
            var dPContext = _context.Movie_Shows.Include(m => m.Movie).Include(m => m.Room);
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Movie_Show/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie_Show = await _context.Movie_Shows
                .Include(m => m.Movie)
                .Include(m => m.Room)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie_Show == null)
            {
                return NotFound();
            }

            return View(movie_Show);
        }

        // GET: Admin/Movie_Show/Create
        public IActionResult Create(int idCinema,DateTime? date)
        {
            if (idCinema == null)
            {
                return NotFound();
            }
            if(date == null)
            {
                date = DateTime.Now;
            }

            var listShow = _context.Movie_Shows.Include(m => m.Movie).Include(m => m.Room).Include(m => m.Room.Cinema).Where(m => m.Room.Cinema_ID.Equals(idCinema)).Where(m=>m.Start_Show.Equals(date)).ToArray();
            var listRoom = _context.Rooms.Where(r => r.Cinema_ID.Equals(idCinema)).ToArray();
            var cinema = _context.Cinemas.Where(c => c.ID.Equals(idCinema)).First();
            ViewBag.listShow = listShow;
            ViewBag.listRoom = listRoom;
            ViewBag.Cinema = cinema;



            ViewData["Movie_ID"] = new SelectList(_context.Movies, "ID", "Directors");
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name");
            return View();
        }

        // POST: Admin/Movie_Show/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Start_Show,Status,Room_ID,Movie_ID")] Movie_Show movie_Show)
        {
            if (ModelState.IsValid)
            {
                _context.Add(movie_Show);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Movie_ID"] = new SelectList(_context.Movies, "ID", "Directors", movie_Show.Movie_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", movie_Show.Room_ID);
            return View(movie_Show);
        }

        // GET: Admin/Movie_Show/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie_Show = await _context.Movie_Shows.FindAsync(id);
            if (movie_Show == null)
            {
                return NotFound();
            }
            ViewData["Movie_ID"] = new SelectList(_context.Movies, "ID", "Directors", movie_Show.Movie_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", movie_Show.Room_ID);
            return View(movie_Show);
        }

        // POST: Admin/Movie_Show/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Start_Show,Status,Room_ID,Movie_ID")] Movie_Show movie_Show)
        {
            if (id != movie_Show.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(movie_Show);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Movie_ShowExists(movie_Show.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Movie_ID"] = new SelectList(_context.Movies, "ID", "Directors", movie_Show.Movie_ID);
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", movie_Show.Room_ID);
            return View(movie_Show);
        }

        // GET: Admin/Movie_Show/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var movie_Show = await _context.Movie_Shows
                .Include(m => m.Movie)
                .Include(m => m.Room)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (movie_Show == null)
            {
                return NotFound();
            }

            return View(movie_Show);
        }

        // POST: Admin/Movie_Show/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var movie_Show = await _context.Movie_Shows.FindAsync(id);
            _context.Movie_Shows.Remove(movie_Show);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Movie_ShowExists(int id)
        {
            return _context.Movie_Shows.Any(e => e.ID == id);
        }
    }
}
