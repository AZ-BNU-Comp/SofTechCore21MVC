using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdol Hadi
    /// </summary> This page allows the cutomers to view all the garments that are available.


    public class Garment
    {
        public int GarmentID { get; set; }
        
        public string GarmentName { get; set; }

        public Gender Gender { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public Colours Colour { get; set; }

        public Sizes Size { get; set; }

  
        public decimal Price { get; set; }

        /// <summary>
        /// AH
        /// </summary>
  
        public decimal SpecialOfferPrice { get; set; }


        public bool IsAccessory { get; set; }

        public Department Department { get; set; }

        public Sleeves Sleeves { get; set; }
        public Length Length { get; set; }
        ///private Favourite[] is_a_chosen;
        ///private OrderItem[] is_;

        public Garment()
        {
            Length = Length.Non;
            Sleeves = Sleeves.Non;
        }
    }
}
