using System;
using System.Collections.Generic;

namespace SofTechCore21MVC.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }

        public int CustomerID { get; set; }

        public int OrderDate { get; set; }

        public string Status { get; set; }

        // navigation properties (relationships)

        public virtual ICollection<OrderItem> OrderItems { get; set; }

        public virtual Customer Customer { get; set; }
    }

}
