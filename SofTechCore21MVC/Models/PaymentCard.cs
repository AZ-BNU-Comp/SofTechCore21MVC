using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("Card Type")]
        public CardType CardType { get; set; }
        
        [Required]
        [StringLength(30)]
        [DisplayName("Card Name")]
        public string CardName { get; set; }
        
        // Using regular expressions would be better (#### #### #### ####)
        [Required]
        [StringLength(20, MinimumLength = 16)]
        [DisplayName("Card Number")]
        public string CardNumber { get; set; }
        
        [Required]
        [Range(1,12)]
        [DisplayName("Expiry Month")]
        public int ExpiryMonth { get; set; }

        [Required]
        [Range(2019, 2030)]
        [DisplayName("Expiry Year")]
        public int ExpiryYear { get; set; }

        [Required]
        [Range(100, 999)]
        [DisplayName("Security Number")]
        public int SecurityNumber { get; set; }

        public PaymentCard()
        {
            ExpiryYear = DateTime.Now.Year;
            SecurityNumber = 100;
        }
    }
}
