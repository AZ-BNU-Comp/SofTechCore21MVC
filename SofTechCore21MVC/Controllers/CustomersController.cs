using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SofTechCore21MVC.Data;
using SofTechCore21MVC.Models;

namespace SofTechCore21MVC.Controllers
{
    public class CustomersController : Controller
    {
        public const string BIRTH_DATE_SORT_PARAM = "BirthDateSortParm";

        private readonly ApplicationDbContext _context;

        public CustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Customers
        public async Task<IActionResult> Index(string sortOrder, 
                                               string currentFilter, 
                                               string searchString, 
                                               int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData[BIRTH_DATE_SORT_PARAM] = sortOrder == "BirthDate" ? "birthdate_desc" : "BirthDate";
            ViewData["GenderSortParm"] = sortOrder == "Gender" ? "gender_desc" : "Gender";
            ViewData["EmailSortParm"] = sortOrder == "Email" ? "email_desc" : "Email";
            ViewData["PhoneNumberSortParm"] = sortOrder == "PhoneNumber" ? "phonenumber_desc" : "PhoneNumber";
            ViewData["TelephoneNoSortParm"] = sortOrder == "TelephoneNo" ? "telephoneno_desc" : "TelephoneNo";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var customers = from c in _context.Customer select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(c => c.Surname.Contains(searchString)
                                       || c.FirstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    customers = customers.OrderByDescending(c => c.Surname);
                    break;
                case "birthdate_desc":
                    customers = customers.OrderByDescending(c => c.BirthDate);
                    break;
                case "BirthDate":
                    customers = customers.OrderBy(c => c.BirthDate);
                    break;
                case "gender_desc":
                    customers = customers.OrderByDescending(c => c.Gender);
                    break;
                case "Gender":
                    customers = customers.OrderBy(c => c.Gender);
                    break;
                case "email_desc":
                    customers = customers.OrderByDescending(c => c.Email);
                    break;
                case "Email":
                    customers = customers.OrderBy(c => c.Email);
                    break;
                case "phonenumber_desc":
                    customers = customers.OrderByDescending(c => c.PhoneNumber);
                    break;
                case "PhoneNumber":
                    customers = customers.OrderBy(c => c.PhoneNumber);
                    break;
                case "telephoneno_desc":
                    customers = customers.OrderByDescending(c => c.TelephoneNo);
                    break;
                case "TelephoneNo":
                    customers = customers.OrderBy(c => c.TelephoneNo);
                    break;
                default:
                    customers = customers.OrderBy(c => c.Surname);
                    break;
            }

            int pageSize = 4;
            return View(await PaginatedList<Customer>.CreateAsync(customers.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerID == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerID,UserID,FirstName,Surname,BirthDate,Gender,Email,PhoneNumber,TelephoneNo,AddressID,PaymentCardID")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerID,UserID,FirstName,Surname,BirthDate,Gender,Email,PhoneNumber,TelephoneNo,AddressID,PaymentCardID")] Customer customer)
        {
            if (id != customer.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerID))
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
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerID == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerID == id);
        }
    }
}
