using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Create([Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Status")] Seat_Level seat_Level,IFormFile ful, IFormFile ful_selected, IFormFile ful_checked)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seat_Level);
                await _context.SaveChangesAsync();
                var tenImg = seat_Level.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", tenImg);
                var tenImgSelected = seat_Level.ID + "_selected." + ful_selected.FileName.Split(".")[ful_selected.FileName.Split(".").Length - 1];
                var pathSelected = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", tenImgSelected);
                var tenImgChecked = seat_Level.ID + "_checked." + ful_checked.FileName.Split(".")[ful_checked.FileName.Split(".").Length - 1];
                var pathChecked = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", tenImgChecked);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ful.CopyToAsync(stream);

                }
                using (var stream = new FileStream(pathSelected, FileMode.Create))
                {
                    await ful_selected.CopyToAsync(stream);

                }
                using (var stream = new FileStream(pathChecked, FileMode.Create))
                {
                    await ful_checked.CopyToAsync(stream);

                }
                seat_Level.Image = tenImg;
                seat_Level.Image_Checked =tenImgChecked;
                seat_Level.Image_Selected = tenImgSelected;
                _context.Update(seat_Level);
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
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Image,Image_Selected,Image_Checked,Count_Cell,Price,Status")] Seat_Level seat_Level,IFormFile ful, IFormFile ful_selected, IFormFile ful_checked)
        {
            if (id != seat_Level.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (ful != null)
                    {
                        var tenImg = seat_Level.ID + "." + ful.FileName.Split(".")[ful.FileName.Split(".").Length - 1];
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", seat_Level.Image);
                        System.IO.File.Delete(path);
                        path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", tenImg);
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await ful.CopyToAsync(stream);
                        }
                        seat_Level.Image = tenImg;
                    }
                    if (ful_selected != null)
                    {
                        var tenImgSelected = seat_Level.ID + "_selected." + ful_selected.FileName.Split(".")[ful_selected.FileName.Split(".").Length - 1];
                        var pathSelected = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", seat_Level.Image_Selected);
                        System.IO.File.Delete(pathSelected);
                        pathSelected = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", tenImgSelected);
                        using (var stream = new FileStream(pathSelected, FileMode.Create))
                        {
                            await ful_selected.CopyToAsync(stream);
                        }
                        seat_Level.Image_Selected = tenImgSelected;
                    }
                    if (ful_checked != null)
                    {
                        var tenImgChecked = seat_Level.ID + "_checked." + ful_checked.FileName.Split(".")[ful_checked.FileName.Split(".").Length - 1];
                        var pathChecked = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", seat_Level.Image_Checked);
                        System.IO.File.Delete(pathChecked);
                        pathChecked = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Uploads/Seat_Level", tenImgChecked);
                        using (var stream = new FileStream(pathChecked, FileMode.Create))
                        {
                            await ful_checked.CopyToAsync(stream);
                        }
                        seat_Level.Image_Checked = tenImgChecked;
                    }
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
        public async Task<IActionResult> Active(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seatlv = await _context.Seat_Levels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (seatlv == null)
            {
                return NotFound();
            }
            seatlv.Status = 1;
            _context.Seat_Levels.Update(seatlv);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UnActive(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seatlv = await _context.Seat_Levels
                .FirstOrDefaultAsync(m => m.ID == id);
            if (seatlv == null)
            {
                return NotFound();
            }
            seatlv.Status = 0;
            _context.Seat_Levels.Update(seatlv);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
