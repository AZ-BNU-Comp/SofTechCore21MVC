using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Ana Zorro
    /// </summary>
    public class PaymentCard
    {
        [Key]
        public string PaymentCardID { get; set; }
        [Required]
        public int CustomerID { get; set; }
        [Required]
        public CardType CardType { get; set; }
        [Required, StringLength(30)]
        public string CardName { get; set; }
        [Required, StringLength(16, MinimumLength = 16)]
        public string CardNumber { get; set; }
        [Required, Range(1,12)]
        public int ExpiryMonth { get; set; }
        [Required, Range(2019, 2030)]
        public int ExpiryYear { get; set; }
        [Required, StringLength(3, ErrorMessage = "Please enter 3 digits",MinimumLength =3)]
        public int SecurityNumber { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }

    }
}
