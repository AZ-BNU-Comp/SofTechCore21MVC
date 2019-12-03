using System;
using System.Collections.Generic;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdol
    /// </summary>
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public OrderStatus Status { get; set; }

        public decimal Postage { get; set; }

        // navigation properties (relationships)

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
