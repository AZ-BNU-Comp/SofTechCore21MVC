using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Rohail Siddiqui
    /// </summary>
    
    
    public class Top : Garment
    {
        private int topID;
        public int TopID
        {
            get
            {
                return topID;
            }
            set
            {
                topID = value;
            }
        }
        private int garmentID;
        public int GarmentID
        {
            get
            {
                return garmentID; 
            }
            set
            {
                garmentID = value;
            }
        }
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
