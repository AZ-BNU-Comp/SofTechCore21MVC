using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdol Hadi
    /// </summary> This page allows the cutomers to view all the garments that are available.


    public class Garment
    {
        [Key]
        public int GarmentID { get; set; }

        [Required, StringLength(20), DisplayName("Garment Name")]
        public string GarmentName { get; set; }

        public Gender Gender { get; set; }

        [Required, StringLength(4000), DisplayName("Description")]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public Colours Colour { get; set; }

        public Sizes Size { get; set; }

        [Required, DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal Price { get; set; }

        /// <summary>
        /// AH
        /// </summary>

        [Required, DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal SpecialOfferPrice { get; set; }

        [Required]
        public bool IsAccessory { get; set; }

        public Department Department { get; set; }

        // Tops have sleeves
        public Sleeves Sleeves { get; set; }

        // Trousers have a length
        public Length Length { get; set; }

        // 
        ///private Favourite[] is_a_chosen;
        ///private OrderItem[] is_;

        public Garment()
        {
            Length = Length.Non;
            Sleeves = Sleeves.Non;
        }
    }
}
