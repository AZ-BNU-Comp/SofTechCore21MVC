using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// </summary>
    public class OrderItem
    {
       
        [Key]
        public int OrderItemID { get; set; }

        [Required, DisplayName("Garment")]
        public int GarmentID { get; set; }

        public int ShoppingCartID { get; set; }

        [Range(1, 10)]
        public int Quantity { get; set; }

        [Required, DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString ="{C:0}")]
        public decimal PurchasePrice { get; set; }

        // Navigation Properties
        
        public virtual ShoppingCart ShoppingCart { get; set; }
        
        public virtual Garment Garment { get; set; }

    }
}
