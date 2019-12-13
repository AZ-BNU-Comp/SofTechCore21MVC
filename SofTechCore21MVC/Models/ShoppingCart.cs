using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdol
    /// </summary>
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }

        [Required]
        public int CustomerID { get; set; }

        [Required, Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime OrderDate { get; set; }

        [Required, Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }

        [Required, StringLength(50), Display(Name = "Status")]
        public OrderStatus Status { get; set; }

        [Required] 
        public decimal Postage { get; set; }

        // navigation properties (relationships)
        [Required]

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Customer Customer { get; set; }
    }

    public enum OrderStatus
    {
        Recieved,
        Packaged,
        Delivered,
        Cancelled,
        Closed
    }

}
