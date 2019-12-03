using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Rohail Siddiqui
    /// </summary>
    
    
    public class Top : Garment
    {
        public int TopID { get; set; }

        private Sleeves sleeves;
        
        public Sleeves Sleeves { get; set; }

    }
}
