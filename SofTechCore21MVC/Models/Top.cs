using System;

namespace SofTechCore21MVC.Models
{
    public class Top : Garment
    {
        
        public int TopID { get; set; }
        
        public int GarmentID { get; set; }
        private Sleeves sleeves;
        public Sleeves Sleeves
        {
            get
            {
                return sleeves;
            }
            set
            {
                sleeves = value;
            }
        }

    }
}
