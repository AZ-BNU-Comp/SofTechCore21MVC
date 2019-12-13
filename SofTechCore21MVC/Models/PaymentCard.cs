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
        public int PaymentCardID { get; set; }
        
        public CardType CardType { get; set; }
        
        [Required, StringLength(30)]
        public string CardName { get; set; }
        
        // Using regular expressions would be better (#### #### #### ####)
        [Required, StringLength(20, MinimumLength = 20)]
        public string CardNumber { get; set; }
        
        [Required, Range(1,12)]
        public int ExpiryMonth { get; set; }

        [Required, Range(2019, 2030)]
        public int ExpiryYear { get; set; }

        [Required, StringLength(3, ErrorMessage = "Please enter 3 digits",MinimumLength =3)]
        public int SecurityNumber { get; set; }
    }
}
