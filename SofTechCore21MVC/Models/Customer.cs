using System;
namespace SofTechCore21MVC
{
    /// <summary>
    /// Ana Zorro
    /// </summary>
    public class Customer
    {
        public int CustomerID
        {
            get; set;
        }
        public string FirstName
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        
        public DateTime BirthDate
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public PhoneNumber PhoneNumber
        {
            get; set;
        }
        public Gender Gender
        {
            get; set;
        }

        //public virtual ShoppingCart ShoppingCart;
        //public virtual Address Address;
        //public virtual PaymentCard holds;
        //public virtual Review[] is_done_by;

        //public virtual Favourites is_added_by;
        //public virtual Complaint[] is_sent_by;
        //public virtual Invoice[] belongs_to;

    }
}
