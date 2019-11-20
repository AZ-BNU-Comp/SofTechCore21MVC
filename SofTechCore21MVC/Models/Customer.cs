using System;
using System.Collections.Generic;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Ana Zorro
    /// </summary>
    public class Customer
    {
        public int CustomerID
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        
        public DateTime BirthDate
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public PhoneNumber PhoneNumber
        {
            get; set;
        }
        public Gender Gender
        {
            get; set;
        }

        public virtual Address Address { get; set; }
        
        public virtual PaymentCard PaymentCard { get; set; }

        public virtual ICollection<ShoppingCart> Orders { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Favourite> Favourites { get; set; }
        
        public virtual ICollection<Complaint> Complaints { get; set; }
        
        // NOT NEEDED
        // public virtual Invoice[] belongs_to;
    }
}
