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
        public int GarmentID { get; set; }

        [Required] 
        [StringLength(20)]
        [DisplayName("Garment Name")]
        public string GarmentName { get; set; }

        public Gender Gender { get; set; }

        [Required]
        [StringLength(4000)]
        [DisplayName("Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.Url)]
        [DisplayName("Image URL")]
        public string ImageUrl { get; set; }

        public Colours Colour { get; set; }

        public Sizes Size { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [DataType(DataType.Currency)]
        [DisplayName("Offer Price")]
        public decimal SpecialOfferPrice { get; set; }

        public bool IsAccessory { get; set; }

        public Department Department { get; set; }

        // Tops have sleeves
        public Sleeves Sleeves { get; set; }

        // Trousers have a length
        public Length Length { get; set; }

        /// <summary>
        /// AH Navigation
        /// </summary>

        // 
 

        public Garment()
        {
            Length = Length.Non;
            Sleeves = Sleeves.Non;
            IsAccessory = false;
        }
    }
}
