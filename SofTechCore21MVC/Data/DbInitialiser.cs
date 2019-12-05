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

            var Customers = new Customer[]
            {
                //10
            };

            var PaymentCards = new PaymentCard[]
            {
                //10
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

            var Addresses = new Address[]
            {
                new Address
                {
                    City = "High Wycombe",
                    County = "Bucks",
                    Country = "United Kingdom"

                }
            };

            var OrderItems = new OrderItem[]
            {
                new OrderItem
                {
                    Garment = "Tops",

                }
            }
        }
    }
}
