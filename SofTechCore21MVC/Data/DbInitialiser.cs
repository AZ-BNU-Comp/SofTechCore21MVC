using SofTechCore21MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofTechCore21MVC.Data
{
    public static class DbInitialiser
    {
        public static void SeedDb(ApplicationDbContext context)
        {
            SeedPaymentCards(context);
        }

        private static void SeedPaymentCards(ApplicationDbContext context)
        {
            if (context.PaymentCard.Any())
            {
                return;   // DB has been seeded
            }

            var PaymentCards = new PaymentCard[]
            {
                new PaymentCard
                {
                    CardName = "Joe Blogs",
                    CardNumber = "1234 5678 9101 1213",
                    CardType = CardType.Debit,
                    ExpiryMonth = 1,
                    ExpiryYear = 2022,
                    SecurityNumber = 123
                },
                new PaymentCard
                {
                    CardName = "Josephin Blogs",
                    CardNumber = "5987 6804 9101 1213",
                    CardType = CardType.Debit,
                    ExpiryMonth = 2,
                    ExpiryYear = 2022,
                    SecurityNumber = 124
                }
            };
        }
    }
}
