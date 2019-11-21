using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Rohail Siddiqui
    /// </summary>

    public class Trousers : Garment
    {
        private int trousersID;
        public int TrousersID
        {
            get
            {
                return trousersID;
            }
            set
            {
                trousersID = value;
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
        private Length length;
        public Length Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

    }
}
