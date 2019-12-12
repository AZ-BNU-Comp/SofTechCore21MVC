using SofTechCore21MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SofTechCore21MVC.Data
{
    /// <summary>
    /// Abdol Garment and Shopping Cart
    /// Abdi Address and Order Item
    /// </summary>
    public static class DbInitialiser
    {
        public static void SeedDb(ApplicationDbContext context)
        {
            SeedPaymentCards(context);
            SeedAddresses(context);
            SeedOrderItems(context);
            
        }

        private static void SeedAddresses(ApplicationDbContext context)
        {
            var addresses = new Address[]
            {
                new Address
                {
                    City = "High Wycombe",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "7",
                    StreetName = "Telford Way",
                    PostCode = "HP13 5TA"
                },
                new Address
                {
                    City = "High Wycombe",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "12",
                    StreetName = "One Way Road",
                    PostCode = "HP1 1ET"
                },
                new Address
                {
                    City = "Aylesbury",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "11",
                    StreetName = "Johns Roady",
                    PostCode = "HP20 1BA"
                },
                new Address
                {
                    City = "Milton Keyes",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "48",
                    StreetName = "Score Avenue",
                    PostCode = "MK16 4NU"
                },
                new Address
                {
                    City = "Marlow",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "99",
                    StreetName = "Fort Way",
                    PostCode = "HP77 AVP"
                },
                new Address
                {
                    City = "Waddesdon",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "102",
                    StreetName = "Highend Avenue",
                    PostCode = "HP8 2NS"
                },
                new Address
                {
                    City = "Winslow",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "1",
                    StreetName = "New House Way",
                    PostCode = "HP1 ANS"
                },
                new Address
                {
                    City = "Buckingham",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "2",
                    StreetName = "Raven Close",
                    PostCode = "HP43 9ST"
                },
                new Address
                {
                    City = "Amsersham",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "9",
                    StreetName = "Fortnorth",
                    PostCode = "HP9 4NB"
                },
                new Address
                {
                    City = "Wendover",
                    County = Counties.Bucks,
                    Country = Countries.UK,
                    HouseNumber = "4",
                    StreetName = "Hills Way",
                    PostCode = "HP22 9TA"
                },
            };

            foreach (Address a in addresses)
            {
                context.Address.Add(a);
            }

            context.SaveChanges();

        }

        private static void SeedPaymentCards(ApplicationDbContext context)
        {
            if (context.PaymentCard.Any())
            {
                return;   // DB has been seeded
            }

            var paymentCards = new PaymentCard[]
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
                },
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

            foreach (PaymentCard p in paymentCards)
            {
                context.PaymentCard.Add(p);
            }

            context.SaveChanges();
        }
        private static void SeedOrderItems(ApplicationDbContext context)
        {
           
                {
                
                context.

                
                }

            


           

            

        
            
    }

