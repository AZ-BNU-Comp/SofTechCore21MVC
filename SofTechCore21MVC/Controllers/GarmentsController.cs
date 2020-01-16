using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SofTechCore21MVC.Data;
using SofTechCore21MVC.Models;

namespace SofTechCore21MVC.Controllers
{
    public class GarmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GarmentsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Garments
        public async Task<IActionResult> Index()
        {
            return View(await _context.Garment.ToListAsync());
        }

        // GET: Garments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var garment = await _context.Garment
                .FirstOrDefaultAsync(m => m.GarmentID == id);
            if (garment == null)
            {
                return NotFound();
            }

            return View(garment);
        }

        // GET: Garments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Garments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GarmentID,GarmentName,Gender,Description,ImageUrl,Colour,Size,Price,SpecialOfferPrice,IsAccessory,Department,Sleeves,Length")] Garment garment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(garment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(garment);
        }

        // GET: Garments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var garment = await _context.Garment.FindAsync(id);
            if (garment == null)
            {
                return NotFound();
            }
            return View(garment);
        }

        // POST: Garments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GarmentID,GarmentName,Gender,Description,ImageUrl,Colour,Size,Price,SpecialOfferPrice,IsAccessory,Department,Sleeves,Length")] Garment garment)
        {
            if (id != garment.GarmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(garment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GarmentExists(garment.GarmentID))
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
            return View(garment);
        }

        // GET: Garments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var garment = await _context.Garment
                .FirstOrDefaultAsync(m => m.GarmentID == id);
            if (garment == null)
            {
                return NotFound();
            }

            return View(garment);
        }

        // POST: Garments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var garment = await _context.Garment.FindAsync(id);
            _context.Garment.Remove(garment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GarmentExists(int id)
        {
            return _context.Garment.Any(e => e.GarmentID == id);
        }
    }
}
