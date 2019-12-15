using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// This model represents the PaymentCard details of a Customer of the SofTech website.
    /// Author: Ana Lucia Petinga Zorro
    /// </summary>
    public class PaymentCard
    {
        public int PaymentCardID { get; set; }
        
        public CardType CardType { get; set; }
        
        [Required]
        [StringLength(30)]
        public string CardName { get; set; }
        
        // Using regular expressions would be better (#### #### #### ####)
        [Required]
        [StringLength(20, MinimumLength = 16)]
        public string CardNumber { get; set; }
        
        [Required]
        [Range(1,12)]
        public int ExpiryMonth { get; set; }

        [Required]
        [Range(2019, 2030)]
        public int ExpiryYear { get; set; }

        [Required, Range(100, 999)]
        public int SecurityNumber { get; set; }
    }
}
