using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// </summary>
    public class Address
    {
        public int AddressID { get; set; }
        public int CustomerID { get; set; }
        private int houseNumber;
        public int HouseNumber
        {
            get
            {
                return houseNumber;
            }
            set
            {
                houseNumber = value;
            }
        }
        private string streetName;
        public string StreetName
        {
            get
            {
                return streetName;
            }
            set
            {
                streetName = value;
            }
        }
        private string county;
        public string County
        {
            get
            {
                return county;
            }
            set
            {
                county = value;
            }
        }
        private string city;
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        private string country;
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        private string postCode;
        public string PostCode
        {
            get
            {
                return postCode;
            }
            set
            {
                postCode = value;
            }
        }

        private Customer[] may_enter;

    }
}
