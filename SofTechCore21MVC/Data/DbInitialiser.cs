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
            SeedCustomer(context);
            //SeedOrderItems(context);


        }

        private static void SeedCustomer(ApplicationDbContext context)
        {
            if (context.Customer.Any())
            {
                return;   // DB has been seeded
            }

            var customers = new Customer[]
            {
                new Customer
                {
                    FirstName = "Carson",
                    Surname = "Alexander",
                    BirthDate = new DateTime(1999, 5, 10),
                    Email = "carson@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 1,
                    PaymentCardID = 1
                },
                new Customer
                {
                    FirstName = "Oliver",
                    Surname = "Beatles",
                    BirthDate = new DateTime(1994, 9, 15),
                    Email = "oliver@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 2,
                    PaymentCardID = 2
                },
                new Customer
                {
                    FirstName = "Jack",
                    Surname = "Charles",
                    BirthDate = new DateTime(2000, 1, 16),
                    Email = "jack@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 3,
                    PaymentCardID = 3
                },
                new Customer
                {
                    FirstName = "Diana",
                    Surname = "Dell",
                    BirthDate = new DateTime(1990, 2, 17),
                    Email = "diana@gmail.com",
                    Gender = Gender.Female,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 4,
                    PaymentCardID = 4
                },
                new Customer
                {
                    FirstName = "Einstein",
                    Surname = "Eagle",
                    BirthDate = new DateTime(1989, 7, 18),
                    Email = "einstein@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 5,
                    PaymentCardID = 5
                },
                new Customer
                {
                    FirstName = "Fallon",
                    Surname = "Fox",
                    BirthDate = new DateTime(1980, 12, 19),
                    Email = "fallon@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 6,
                    PaymentCardID = 6
                },
                new Customer
                {
                    FirstName = "George",
                    Surname = "Gales",
                    BirthDate = new DateTime(1981, 3, 20),
                    Email = "george@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 7,
                    PaymentCardID = 7
                },
                new Customer
                {
                    FirstName = "Harry",
                    Surname = "Potter",
                    BirthDate = new DateTime(1982, 4, 21),
                    Email = "harry@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 8,
                    PaymentCardID = 8
                },
                new Customer
                {
                    FirstName = "Ian",
                    Surname = "Jones",
                    BirthDate = new DateTime(1983, 6, 22),
                    Email = "ian@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 9,
                    PaymentCardID = 9
                },
                new Customer
                {
                    FirstName = "Liam",
                    Surname = "Carrington",
                    BirthDate = new DateTime(1985, 11, 23),
                    Email = "liam@gmail.com",
                    Gender = Gender.Male,
                    PhoneNumber = PhoneTypes.Mobile,
                    AddressID = 10,
                    PaymentCardID = 10
                },
            };

            foreach (Customer c in customers)
            {
                context.Customer.Add(c);
            }

            context.SaveChanges();
        }

        private static void SeedAddresses(ApplicationDbContext context)
        {
                if (context.Address.Any())
                {
                    return;   // DB has been seeded
                }

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
                new PaymentCard
                {
                    CardName = "Carson Alexander",
                    CardNumber = "4462 9106 4126 2228",
                    CardType = CardType.Debit,
                    ExpiryMonth = 1,
                    ExpiryYear = 2022,
                    SecurityNumber = 121
                },
                new PaymentCard
                {
                    CardName = "Oliver Beatles",
                    CardNumber = "4462 9106 4126 2229",
                    CardType = CardType.Debit,
                    ExpiryMonth = 2,
                    ExpiryYear = 2022,
                    SecurityNumber = 122
                },
                new PaymentCard
                {
                    CardName = "Jack Charles",
                    CardNumber = "4462 9106 4126 2230",
                    CardType = CardType.Debit,
                    ExpiryMonth = 3,
                    ExpiryYear = 2022,
                    SecurityNumber = 123
                },
                new PaymentCard
                {
                    CardName = "Diana Dell",
                    CardNumber = "4462 9106 4126 2231",
                    CardType = CardType.Debit,
                    ExpiryMonth = 4,
                    ExpiryYear = 2022,
                    SecurityNumber = 124
                },
                new PaymentCard
                {
                    CardName = "Einstein Eagle",
                    CardNumber = "4462 9106 4126 2232",
                    CardType = CardType.Debit,
                    ExpiryMonth = 5,
                    ExpiryYear = 2022,
                    SecurityNumber = 125
                },
                new PaymentCard
                {
                    CardName = "Fallon Fox",
                    CardNumber = "4462 9106 4126 2233",
                    CardType = CardType.Debit,
                    ExpiryMonth = 6,
                    ExpiryYear = 2022,
                    SecurityNumber = 126
                },
                new PaymentCard
                {
                    CardName = "George Gales",
                    CardNumber = "5253 0315 2454 9330",
                    CardType = CardType.Credit,
                    ExpiryMonth = 8,
                    ExpiryYear = 2023,
                    SecurityNumber = 321
                },
                new PaymentCard
                {
                    CardName = "Harry Potter",
                    CardNumber = "5253 0315 2454 9331",
                    CardType = CardType.Credit,
                    ExpiryMonth = 9,
                    ExpiryYear = 2023,
                    SecurityNumber = 320
                },
                new PaymentCard
                {
                    CardName = "Ian Jones",
                    CardNumber = "4462 9106 4126 2234",
                    CardType = CardType.Debit,
                    ExpiryMonth = 7,
                    ExpiryYear = 2022,
                    SecurityNumber = 127
                },
                new PaymentCard
                {
                    CardName = "Liam Carrington",
                    CardNumber = "4462 9106 4126 2235",
                    CardType = CardType.Debit,
                    ExpiryMonth = 8,
                    ExpiryYear = 2022,
                    SecurityNumber = 128
                }
            };

            foreach (PaymentCard p in paymentCards)
            {
                context.PaymentCard.Add(p);
            }

            context.SaveChanges();
        }
    }
}
    //    private static void SeedOrderItems(ApplicationDbContext context)
    //    {
           
    //            {
                
    //            context.Orderitem.Add(p));


                
    //            };

            


           

            

        
            
    //}

