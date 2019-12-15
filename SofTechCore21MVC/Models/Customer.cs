using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// This model represents a Customer of the SofTech website.
    /// Author: Ana Lucia Petinga Zorro
    /// </summary>
    public class Customer
    {
        public int CustomerID { get; set; }
        
        [StringLength(50)]
        public string UserID { get; set; }
        
        [Required]
        [StringLength(20)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        [DisplayName("Last Name")]
        public string Surname { get; set; }

        [Required]
        [Display(Name ="Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DisplayName("Phone Type")]
        public PhoneTypes PhoneNumber { get; set; }

        [Required]
        [StringLength(16, ErrorMessage = "Please enter a valid UK contact number")]
        [DisplayName("Phone Number")]
        public string TelephoneNo { get; set; }

        public Nullable<int> AddressID { get; set; }

        public Nullable<int> PaymentCardID { get; set; }
        
        // For simplicity use a single address
        public virtual Address Address { get; set; }

        // For simplicity use a single PaymentCard
        public virtual PaymentCard PaymentCard { get; set; }

        public virtual ICollection<ShoppingCart> Orders { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }

        public virtual ICollection<Favourite> Favourites { get; set; }

        public virtual ICollection<Complaint> Complaints { get; set; }

        public Customer()
        {
            PhoneNumber = PhoneTypes.Mobile;
        }
    }
}
