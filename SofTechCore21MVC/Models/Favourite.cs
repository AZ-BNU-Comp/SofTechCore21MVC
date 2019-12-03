using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Hasan
    /// </summary>
    public class Favourite
    {

        public int FavouriteID { get; set; }

        public int GarmentID { get; set; }

        public int CustomerID { get; set; }
        
        // Navigation Properties

        public virtual Garment Garment { get; set; }

    }
}
