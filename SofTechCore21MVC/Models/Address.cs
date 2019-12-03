using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// </summary>
    public class Address
    {
        [Key, StringLength(50)]
        public int AddressID { get; set; }
        [StringLength(50)]
        public int CustomerID { get; set; }
        [Required, StringLength(50), DisplayName("Customer ID Name")]
        public int HouseNumber { get; set; }
        [Required, StringLength(50), DisplayName("HouseNumber")]
        public string StreetName { get; set; }
        [Required, DisplayName("Street Name")]
        public string County { get; set; }
        [Requried, DisplayName("County")]
        public string City { get; set; }
        [Required, DisplayName("City")]
        public string Country { get; set; }
        [Required, DisplayName("Country")]
        public string PostCode { get; set; }
        private Customer Customer { get; set; }
        public virtual ICollection<Gender> Gender {get; set;}
        public virtual ICollection<Customer>Customer {get; set;}
        public virtual ICollection<PaymentCard>PaymentCard {get; set;}
        public virtual ICollection<ShoppingCart>ShoppingCart {get; set;}
        public virtual ICollection<OrderItem>OrderItem {get; set;}
        public virtual ICollection<Review>Review{get; set;}
        public virtual ICollection<Favourite>Favourite{get; set;}
        public virtual ICollection<Complaint>Complaint{get; set;}
       
        
        

        
    
       
       
        

    }
}
