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
    public class SeatsController : Controller
    {
        private readonly DPContext _context;

        public SeatsController(DPContext context)
        {
            _context = context;
        }

        // GET: Admin/Seats
        public async Task<IActionResult> Index(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dPContext = _context.Seats.Include(s => s.Room).Include(s => s.Seat_Level).Where(s=>s.Room_ID.Equals(id));    
            return View(await dPContext.ToListAsync());
        }

        // GET: Admin/Seats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat = await _context.Seats
                .Include(s => s.Room)
                .Include(s => s.Seat_Level)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (seat == null)
            {
                return NotFound();
            }

            return View(seat);
        }

        // GET: Admin/Seats/Create
        public IActionResult Create()
        {
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name");
            ViewData["Seat_Level_ID"] = new SelectList(_context.Seat_Levels, "ID", "Name");
            return View();
        }

        // POST: Admin/Seats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Row_ID,Col_ID,Status,Room_ID,Seat_Level_ID")] Seat seat)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seat);
                await _context.SaveChangesAsync();
                return Redirect("/Admin/Seats/Index/" + seat.Room_ID);
            }
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", seat.Room_ID);
            ViewData["Seat_Level_ID"] = new SelectList(_context.Seat_Levels, "ID", "Name", seat.Seat_Level_ID);
            return View(seat);
        }

        // GET: Admin/Seats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat = await _context.Seats.FindAsync(id);
            if (seat == null)
            {
                return NotFound();
            }
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", seat.Room_ID);
            ViewData["Seat_Level_ID"] = new SelectList(_context.Seat_Levels, "ID", "Name", seat.Seat_Level_ID);
            return View(seat);
        }

        // POST: Admin/Seats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Row_ID,Col_ID,Status,Room_ID,Seat_Level_ID")] Seat seat)
        {
            if (id != seat.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seat);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeatExists(seat.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return Redirect("/Admin/Seats/Index/" + seat.Room_ID);
            }
            ViewData["Room_ID"] = new SelectList(_context.Rooms, "ID", "Name", seat.Room_ID);
            ViewData["Seat_Level_ID"] = new SelectList(_context.Seat_Levels, "ID", "Name", seat.Seat_Level_ID);
            return View(seat);
        }

        // GET: Admin/Seats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seat = await _context.Seats
                .Include(s => s.Room)
                .Include(s => s.Seat_Level)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (seat == null)
            {
                return NotFound();
            }

            return View(seat);
        }

        // POST: Admin/Seats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seat = await _context.Seats.FindAsync(id);
            _context.Seats.Remove(seat);
            await _context.SaveChangesAsync();
            return Redirect("/Admin/Seats/Index/" + seat.Room_ID);
        }

        private bool SeatExists(int id)
        {
            return _context.Seats.Any(e => e.ID == id);
        }
    }
}
