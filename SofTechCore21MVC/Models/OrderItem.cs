using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// </summary>
    public class OrderItem
    {
       
        [Key, StringLength(50)]
        public int OrderItemID { get; set; }
        [Required, DisplayName("OrderItem ID")]
        public int GarmentID { get; set; }
        [Required, DisplayName("Garment ID")]
        public int ShoppingCartID { get; set; }
        [Required, StringLength(50), DisplayName("ShoppingCart ID")]
        private ShoppingCart[] contains;
        private Garment[] may_be_an;
        private Complaint[] is_featured_on;
        public virtual ICollection<Gender> Gender { get; set; }
        public virtual ICollection<Address> Address { get; set; }
        public virtual ICollection<PaymentCard> PaymentCard { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Favourite> Favourites { get; set; }
        public virtual ICollection<Complaint> Complaints { get; set; }
        /// Created a billing address model ///
        

        
       
        
        
       

       
    }
}
