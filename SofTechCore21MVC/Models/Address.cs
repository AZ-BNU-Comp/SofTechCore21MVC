using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Abdikani Esse 21211756
    /// </summary>
    public class Address
    {
        private int addressID;
        public int AddressID
        {
            get
            {
                return addressID;
            }
            set
            {
                addressID = value;
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
