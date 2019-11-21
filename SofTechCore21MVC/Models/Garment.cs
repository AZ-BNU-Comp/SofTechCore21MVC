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
        private Gender gender;
        public Gender Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }
        private string imageUrl;
        public string ImageUrl
        {
            get
            {
                return imageUrl;
            }
            set
            {
                imageUrl = value;
            }
        }
        private Colours colour;
        public Colours Colour
        {
            get
            {
                return colour;
            }
            set
            {
                colour = value;
            }
        }
        private Sizes size;
        public Sizes Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
        private Decimal price;
        public Decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        /// <summary>
        /// AH
        /// </summary>
        private Decimal specialOfferPrice;
        public Decimal SpecialOfferPrice
        {
            get
            {
                return specialOfferPrice;
            }
            set
            {
                specialOfferPrice = value;
            }
        }
        private bool isAccessory;
        public bool IsAccessory
        {
            get
            {
                return isAccessory;
            }
            set
            {
                isAccessory = value;
            }
        }
        private Department department;
        public Department Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        private Favourite[] is_a_chosen;
        private OrderItem[] is_;

    }
}
