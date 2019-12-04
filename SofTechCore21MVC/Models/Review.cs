using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Rohail
    /// </summary>
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        
        [Required]
        public int CustomerID { get; set; }
        
        [Required]
        public int GarmentID { get; set; }
        
        [Required, StringLength(50)]
        public string Title { get; set; }
        
        [Required, StringLength(4000, ErrorMessage = "There is a 4000 character limit.")]
        public string Statement { get; set; }
        
        [Range(1.0, 5.0)]
        public float Rating { get; set; }
        
        [Required, Display(Name = "Date of Review"), DataType(DataType.Date),
            DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public int ReviewDate { get; set; }

        // Navigation Properties

        public virtual Customer Customer { get; set; }

        public virtual Garment Garment { get; set; }
    }
}
