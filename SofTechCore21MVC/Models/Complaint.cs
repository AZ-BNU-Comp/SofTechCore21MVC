using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Hasan
    /// </summary>
    public class Complaint
    {
        [Key]
        public int ComplaintID { get; set; }
        

        //public int GarmentID { get; set; }

        //public int CustomerID { get; set; }

        
            [Required]
        public int OrderItemID { get; set; }

        [Required, StringLength(4000), DisplayName("Statement")]
        public string Statement { get; set; }
        [Required]
        public bool ContainsPicture { get; set; }
        [Required, DataType(DataType.DateTime)]
        public DateTime ComplaintRecieved { get; set; }

        // Navigation Properties

        public virtual OrderItem OrderItem { get; set; }
    }
}
