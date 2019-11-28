using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// </summary>
    public class OrderItem
    {
       
        public int OrderItemID { get; set; }
        public int GarmentID { get; set; }
        public int ShoppingCartID { get; set; }
        private ShoppingCart[] contains;
        private Garment[] may_be_an;
        private Complaint[] is_featured_on;

        
       
        
        
       

       
    }
}
