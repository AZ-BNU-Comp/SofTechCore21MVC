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
    public class PaymentCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaymentCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PaymentCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.PaymentCard.ToListAsync());
        }

        // GET: PaymentCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.PaymentCard
                .FirstOrDefaultAsync(m => m.PaymentCardID == id);
            if (paymentCard == null)
            {
                return NotFound();
            }

            return View(paymentCard);
        }

        // GET: PaymentCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaymentCards/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaymentCardID,CardType,CardName,CardNumber,ExpiryMonth,ExpiryYear,SecurityNumber")] PaymentCard paymentCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(paymentCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(paymentCard);
        }

        // GET: PaymentCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.PaymentCard.FindAsync(id);
            if (paymentCard == null)
            {
                return NotFound();
            }
            return View(paymentCard);
        }

        // POST: PaymentCards/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaymentCardID,CardType,CardName,CardNumber,ExpiryMonth,ExpiryYear,SecurityNumber")] PaymentCard paymentCard)
        {
            if (id != paymentCard.PaymentCardID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(paymentCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PaymentCardExists(paymentCard.PaymentCardID))
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
            return View(paymentCard);
        }

        // GET: PaymentCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var paymentCard = await _context.PaymentCard
                .FirstOrDefaultAsync(m => m.PaymentCardID == id);
            if (paymentCard == null)
            {
                return NotFound();
            }

            return View(paymentCard);
        }

        // POST: PaymentCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var paymentCard = await _context.PaymentCard.FindAsync(id);
            _context.PaymentCard.Remove(paymentCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PaymentCardExists(int id)
        {
            return _context.PaymentCard.Any(e => e.PaymentCardID == id);
        }
    }
}