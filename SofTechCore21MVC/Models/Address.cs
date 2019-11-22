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
        public int HouseNumberID { get; set; }
        public string StreetNameID { get; set; }
        public string CountyID { get; set; }
        public string CityID { get; set; }
        public string CountryID { get; set; }
        public string PostCodeID { get; set; }
        private Customer Customer { get; set; }
       
        
        

        
    
       
       
        

    }
}
