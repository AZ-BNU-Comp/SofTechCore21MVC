using System;

namespace SofTechCore21MVC.Models
{
    public class Favourite
    {

        public int FavouriteID { get; set; }

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
        private int customerID;
        public int CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }

        //private Customer[] may_add_Garments_to;

        private Garment may_be_part_of;

    }
}
