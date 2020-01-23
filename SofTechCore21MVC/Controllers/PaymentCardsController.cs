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
        public async Task<IActionResult> Index(string sortOrder,
                                               string currentFilter,
                                               string searchString,
                                               int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["CardTypeSortParm"] = String.IsNullOrEmpty(sortOrder) ? "cardtype_desc" : "CardType";
            ViewData["CardNameSortParm"] = sortOrder == "CardName" ? "cardname_desc" : "CardName";
            ViewData["CardNumberSortParm"] = sortOrder == "CardNumber" ? "cardnumber_desc" : "CardNumber";
            ViewData["ExpiryMonthSortParm"] = sortOrder == "ExpiryMonth" ? "expirymonth_desc" : "ExpiryMonth";
            ViewData["ExpiryYearSortParm"] = sortOrder == "ExpiryYear" ? "expiryyear_desc" : "ExpiryYear";
            ViewData["SecurityNumberSortParm"] = sortOrder == "SecurityNumber" ? "securitynumber_desc" : "SecurityNumber";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var paymentcards = from p in _context.PaymentCard select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                paymentcards = paymentcards.Where(p => p.CardNumber.Contains(searchString)
                                       || p.CardName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "cardtype_desc":
                    paymentcards = paymentcards.OrderByDescending(c => c.CardType);
                    break;
                case "cardname_desc":
                    paymentcards = paymentcards.OrderByDescending(c => c.CardName);
                    break;
                case "cardnumber_desc":
                    paymentcards = paymentcards.OrderBy(c => c.CardNumber);
                    break;
                case "expirymonth_desc":
                    paymentcards = paymentcards.OrderByDescending(c => c.ExpiryMonth);
                    break;
                case "expiryyear_desc":
                    paymentcards = paymentcards.OrderBy(c => c.ExpiryYear);
                    break;
                case "securitynumber_desc":
                    paymentcards = paymentcards.OrderByDescending(c => c.SecurityNumber);
                    break;
            }

            int pageSize = 4;
            return View(await PaginatedList<PaymentCard>.CreateAsync(paymentcards.AsNoTracking(), pageNumber ?? 1, pageSize));
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
            PaymentCard paymentCard = new PaymentCard();

            return View(paymentCard);
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