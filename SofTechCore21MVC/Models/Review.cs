using System;
using System.Collections;
using System.Collections.Generic;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Ana Zorro
    /// </summary>
    public class Review
    {
        public int ReviewID { get; set; }
        public int CustomerID { get; set; }
        public int GarmentID { get; set; }
        public string Title { get; set; }
        public string Statement { get; set; }
        public float Rating { get; set; }
        public int ReviewDate { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
