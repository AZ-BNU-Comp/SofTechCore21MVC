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
        public int HouseNumber { get; set; }
        public string StreetName { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        private Customer Customer { get; set; }
       
        
        

        
    
       
       
        

    }
}
