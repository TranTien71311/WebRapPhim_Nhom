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
    public class Seat_LevelController : Controller
    {
        private readonly DPContext _context;

        public Seat_LevelController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Seat_Level
        public async Task<IActionResult> Index()
        {
            return View(await _context.Seat_Levels.ToListAsync());
        }

        // GET: Admin/Seat_Level/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat_Level = await _context.Seat_Levels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (seat_Level == null)
            {
                return NotFound();
            }

            return View(seat_Level);
        }

        // GET: Admin/Seat_Level/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Seat_Level/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Status")] Seat_Level seat_Level)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seat_Level);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seat_Level);
        }

        // GET: Admin/Seat_Level/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat_Level = await _context.Seat_Levels.FindAsync(id);
            if (seat_Level == null)
            {
                return NotFound();
            }
            return View(seat_Level);
        }

        // POST: Admin/Seat_Level/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Status")] Seat_Level seat_Level)
        {
            if (id != seat_Level.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seat_Level);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Seat_LevelExists(seat_Level.ID))
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
            return View(seat_Level);
        }

        // GET: Admin/Seat_Level/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat_Level = await _context.Seat_Levels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (seat_Level == null)
            {
                return NotFound();
            }

            return View(seat_Level);
        }

        // POST: Admin/Seat_Level/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seat_Level = await _context.Seat_Levels.FindAsync(id);
            _context.Seat_Levels.Remove(seat_Level);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Seat_LevelExists(int id)
        {
            return _context.Seat_Levels.Any(e => e.ID == id);
        }
    }
}
