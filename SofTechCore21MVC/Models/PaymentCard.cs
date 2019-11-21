using System;

namespace SofTechCore21MVC.Models
{
    /// <summary>
    /// Ana Zorro
    /// </summary>
    public class PaymentCard
    {
        public string PaymentCardID { get; set; }
        public int CustomerID { get; set; }
        public CardType CardType { get; set; }
        public string CardName { get; set; }
        public string CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
        public int SecurityNumber { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
