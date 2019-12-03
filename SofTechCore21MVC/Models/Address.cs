using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// Feedback: int does not need StringLength
    /// Annotations should be above the properties
    /// Use enum where ever possible
    /// </summary>
    public class Address
    {
        [Key]
        public int AddressID { get; set; }
        
        //public int CustomerID { get; set; }

        [Required, StringLength(20), DisplayName("House No/Name")]
        public string HouseNumber { get; set; }

        
        [Required, StringLength(20), DisplayName("Street Name")]
        public string StreetName { get; set; }

        public Counties County { get; set; }

        [Required, StringLength(20)]
        public string City { get; set; }

        [Required, StringLength(20)]
        public string PostCode { get; set; }

        public Countries Country { get; set; }

        //private Customer Customer { get; set; }

        //public virtual ICollection<Gender> Gender {get; set;}
        //public virtual ICollection<Customer>Customer {get; set;}
        //public virtual ICollection<PaymentCard>PaymentCard {get; set;}
        //public virtual ICollection<ShoppingCart>ShoppingCart {get; set;}
        //public virtual ICollection<OrderItem>OrderItem {get; set;}
        //public virtual ICollection<Review>Review{get; set;}
        //public virtual ICollection<Favourite>Favourite{get; set;}
        //public virtual ICollection<Complaint>Complaint{get; set;}
    }

    public enum Counties 
    { 
        Bucks,
        Cambridge,
        Essex,
        Herts
    }

    public enum Countries 
    { 
        UK,
        USA,
        FRA,
        ITA
    }
}
