using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Hasan
    /// </summary>
    public class Complaint
    {
        public int ComplaintID { get; set; }

        //public int GarmentID { get; set; }

        //public int CustomerID { get; set; }

        public int OrderItemID { get; set; }

        public string Statement { get; set; }

        public bool ContainsPicture { get; set; }

        public DateTime ComplaintRecieved { get; set; }

        // Navigation Properties

        public virtual OrderItem OrderItem { get; set; }
    }
}
