using System;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Hasan
    /// </summary>
    public class Favourite
    {
        public int FavouriteID { get; set; }

        [Required]
        public int GarmentID { get; set; }

        [Required]
        public int CustomerID { get; set; }
        
        // Navigation Properties

        public virtual Garment Garment { get; set; }

    }
}
