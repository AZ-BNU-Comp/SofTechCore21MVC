using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// This view model contains the information for a Customer account of the SofTech website.
    /// Author: Ana Lucia Petinga Zorro
    /// </summary>
    public class CustomerViewModel
    {
        public Customer Customer { get; set; }

        public PaymentCard PaymentCard { get; set; }

        public Address Address { get; set; }

        public IEnumerable<Review> Reviews { get; set; }

        public IEnumerable<Complaint> Complaints { get; set; }

        public IEnumerable<ShoppingCart> Orders { get; set; }

        public IEnumerable<Favourite> Favourites { get; set; }
    }
}
