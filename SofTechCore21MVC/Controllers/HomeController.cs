using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SofTechCore21MVC.Data;
using SofTechCore21MVC.Models;

namespace SofTechCore21MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
       [Authorize]
        public IActionResult MyAccount()
        {
            CustomerViewModel model = new CustomerViewModel();

            string user = User.Identity.Name;

            if (user == null)
            {
                return NotFound();
            }

            var customer = _context.Customer
                .FirstOrDefault(m => m.Email == user);

            if (customer == null)
            {
                return NotFound();
            }

            model.Customer = customer;

            var paymentCard = _context.PaymentCard.FirstOrDefault(p => p.PaymentCardID == customer.PaymentCardID);
            model.PaymentCard = paymentCard;

            var address = _context.Address.FirstOrDefault(a => a.AddressID == customer.AddressID);
            model.Address = address;

            return View(model);
        }
        public IActionResult Women()
        {
            return View();
        }
        public IActionResult Men()
        {
            return View();
        }
        public IActionResult Accessories()
        {
            return View();
        }
        public IActionResult CustomerService()
        {
            return View();
        }
    }
}
