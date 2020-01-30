using SofTechCore21MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SofTechCore21MVC.Models.Address;

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

            SeedGarment(context);
            SeedShoppingCart(context);
            SeedOrderItems(context);
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
                    TelephoneNo = "07654 789 456",
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
                    TelephoneNo = "07654 123 123",
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
                    TelephoneNo = "01296 666 456",
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
                    TelephoneNo = "07666 123 456",
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
                    TelephoneNo = "07688 123 456",
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
                    TelephoneNo = "07654 109 456",
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
                    TelephoneNo = "07644 123 456",
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
                    TelephoneNo = "07677 123 456",
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
                    TelephoneNo = "07654 888 456",
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
                    PhoneNumber = PhoneTypes.Landline,
                    TelephoneNo = "01296 123 456",
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
        private static void SeedGarment(ApplicationDbContext context)
        {
            if (context.Garment.Any())
            {
                return;
            }

            var items = new Garment[]
            {
                new Garment
                {
                    Colour = Colours.Black,
                    Department = Department.Business,
                    Description = "Add a description here",
                    GarmentName = "Garment 1",
                    Gender = Gender.Female,
                    Price = 9,
                    Length = Length.Regular,
                    Size = Sizes.Medium,
                    Sleeves = Sleeves.Long,
                    ImageUrl = "Garment01.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.Grey,
                    Department = Department.Mathematics,
                    Description = "Add a description here",
                    GarmentName = "Garment 2",
                    Gender = Gender.Male,
                    Price = 8,
                    Length = Length.Long,
                    Size = Sizes.Large,
                    Sleeves = Sleeves.Short,
                    ImageUrl = "Garment02.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.White,
                    Department = Department.Science,
                    Description = "Add a description here",
                    GarmentName = "Garment 3",
                    Gender = Gender.Female,
                    Price = 4,
                    Length = Length.Short,
                    Size = Sizes.Small,
                    Sleeves = Sleeves.Long,
                    ImageUrl = "Garment03.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.NavyBlue,
                    Department = Department.Computing,
                    Description = "Add a description here",
                    GarmentName = "Garment 4",
                    Gender = Gender.Male,
                    Price = 5,
                    Length = Length.Short,
                    Size = Sizes.Medium,
                    Sleeves = Sleeves.Short,
                    ImageUrl = "Garment04.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.Burgundy,
                    Department = Department.Mathematics,
                    Description = "Add a description here",
                    GarmentName = "Garment 5",
                    Gender = Gender.Female,
                    Price = 3,
                    Length = Length.Long,
                    Size = Sizes.Small,
                    Sleeves = Sleeves.Short,
                    ImageUrl = "Garment05.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.NavyBlue,
                    Department = Department.Sports,
                    Description = "Add a description here",
                    GarmentName = "Garment 6",
                    Gender = Gender.Male,
                    Price = 4,
                    Length = Length.Regular,
                    Size = Sizes.Medium,
                    Sleeves = Sleeves.Long,
                    ImageUrl = "Garment06.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.Black,
                    Department = Department.Science,
                    Description = "Add a description here",
                    GarmentName = "Garment 7",
                    Gender = Gender.Female,
                    Price = 7,
                    Length = Length.Short,
                    Size = Sizes.Large,
                    Sleeves = Sleeves.Short,
                    ImageUrl = "Garment07.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.White,
                    Department = Department.Business,
                    Description = "Add a description here",
                    GarmentName = "Garment 8",
                    Gender = Gender.Male,
                    Price = 10,
                    Length = Length.Long,
                    Size = Sizes.Medium,
                    Sleeves = Sleeves.Long,
                    ImageUrl = "Garment08.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.Grey,
                    Department = Department.Computing,
                    Description = "Add a description here",
                    GarmentName = "Garment 9",
                    Gender = Gender.Female,
                    Price = 11,
                    Length = Length.Regular,
                    Size = Sizes.Large,
                    Sleeves = Sleeves.Long,
                    ImageUrl = "Garment09.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                },
                new Garment
                {
                    Colour = Colours.Black,
                    Department = Department.Science,
                    Description = "Add a description here",
                    GarmentName = "Garment 10",
                    Gender = Gender.Male,
                    Price = 17,
                    Length = Length.Short,
                    Size = Sizes.Small,
                    Sleeves = Sleeves.Short,
                    ImageUrl = "Garment10.jpg",
                    IsAccessory = false,
                    SpecialOfferPrice = 0
                }
            };

            foreach (Garment g in items)
            {
                context.Garment.Add(g);
            };

            context.SaveChanges();
        }

        private static void SeedShoppingCart(ApplicationDbContext context)
        {
            if (context.ShoppingCart.Any())
            {
                return;
            }

            var items = new ShoppingCart[]
            {
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 3, 19),
                    OrderDate = new DateTime (2020, 3, 17),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 1
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 8, 23),
                    OrderDate = new DateTime (2020, 7, 8),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 2
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 9, 21),
                    OrderDate = new DateTime (2020, 3, 14),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 3
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 5, 10),
                    OrderDate = new DateTime (2020, 3, 17),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 4
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 8, 12),
                    OrderDate = new DateTime (2020, 5, 16),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 5
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 10, 13),
                    OrderDate = new DateTime (2020, 9, 12),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 6
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 8, 6),
                    OrderDate = new DateTime (2020, 9, 14),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 7
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 5, 17),
                    OrderDate = new DateTime (2020, 2, 14),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 8
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 2, 17),
                    OrderDate = new DateTime (2020, 6, 19),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 9
                },
                new ShoppingCart
                {
                    DeliveryDate = new DateTime (2020, 3,19),
                    OrderDate = new DateTime (2020, 2, 17),
                    Status = OrderStatus.Delivered,
                    Postage = new Decimal (2.99),
                    CustomerID = 10
                }
            };

            foreach (ShoppingCart s in items)
            {
                context.ShoppingCart.Add(s);
            };

            context.SaveChanges();
        }
        private static void SeedOrderItems(ApplicationDbContext context)
        {
            if (context.Orderitem.Any())
            {
                return;
            }

            var items = new OrderItem[]
            {
                new OrderItem
                {
                    Quantity = 2,
                    PurchasePrice = 10,
                    GarmentID = 2,
                    ShoppingCartID = 1,
                },
                new OrderItem
                {
                    Quantity = 3,
                    PurchasePrice = 15,
                    GarmentID = 2,
                    ShoppingCartID = 1,
                },    
                new OrderItem
                {
                    Quantity = 4,
                    PurchasePrice = 20,
                    GarmentID = 3,
                    ShoppingCartID = 3,
                },    
                new OrderItem
                {
                    Quantity = 5,
                    PurchasePrice = 25,
                    GarmentID = 4,
                    ShoppingCartID = 4,
                },    
                new OrderItem
                {
                    Quantity = 6,
                    PurchasePrice = 30,
                    GarmentID = 5,
                    ShoppingCartID = 5,
                },    
                new OrderItem
                {
                    Quantity = 7,
                    PurchasePrice = 35,
                    GarmentID = 6,
                    ShoppingCartID = 4,
                },    
                new OrderItem
                {
                    Quantity = 8,
                    PurchasePrice = 40,
                    GarmentID = 7,
                    ShoppingCartID = 5,
                },    
                new OrderItem
                {
                    Quantity = 9,
                    PurchasePrice = 45,
                    GarmentID = 8,
                    ShoppingCartID = 5,
                },    
                new OrderItem
                {
                    Quantity = 10,
                    PurchasePrice = 50,
                    GarmentID = 9,
                    ShoppingCartID = 6,
                },    
                new OrderItem
                {
                    Quantity = 11,
                    PurchasePrice = 55,
                    GarmentID = 10,
                    ShoppingCartID = 7,
                },    
                new OrderItem
                {
                    Quantity = 12,
                    PurchasePrice = 60,
                    GarmentID = 1,
                    ShoppingCartID = 8,
                },    
                new OrderItem
                {
                    Quantity = 13,
                    PurchasePrice = 65,
                    GarmentID = 10,
                    ShoppingCartID = 9,
                },    
                new OrderItem
                {
                    Quantity = 14,
                    PurchasePrice = 70,
                    GarmentID = 8,
                    ShoppingCartID = 10,
                }
                //,new OrderItem
                //{
                //    Quantity = 15,
                //    PurchasePrice = 75,
                //    GarmentID = 14,
                //    ShoppingCartID = 11,
                //},    new OrderItem
                //{
                //    Quantity = 16,
                //    PurchasePrice = 80,
                //    GarmentID = 15,
                //    ShoppingCartID = 12,
                //},    new OrderItem
                //{
                //    Quantity = 17,
                //    PurchasePrice = 85,
                //    GarmentID = 16,
                //    ShoppingCartID = 13,
                //},    new OrderItem
                //{
                //    Quantity = 18,
                //    PurchasePrice = 90,
                //    GarmentID = 17,
                //    ShoppingCartID = 14,
                //},    new OrderItem
                //{
                //    Quantity = 19,
                //    PurchasePrice = 95,
                //    GarmentID = 18,
                //    ShoppingCartID = 15,
                //},    new OrderItem
                //{
                //    Quantity = 20,
                //    PurchasePrice = 100,
                //    GarmentID = 19,
                //    ShoppingCartID = 16,
                //},    new OrderItem
                //{
                //    Quantity = 21,
                //    PurchasePrice = 105,
                //    GarmentID = 20,
                //    ShoppingCartID = 17,
                //},    new OrderItem
                //{
                //    Quantity = 22,
                //    PurchasePrice = 110,
                //    GarmentID = 21,
                //    ShoppingCartID = 18,
                //},    new OrderItem
                //{
                //    Quantity = 23,
                //    PurchasePrice = 115,
                //    GarmentID = 22,
                //    ShoppingCartID = 19,
                //},    new OrderItem
                //{
                //    Quantity = 24,
                //    PurchasePrice = 120,
                //    GarmentID = 21,
                //    ShoppingCartID = 20,
                //},    new OrderItem
                //{
                //    Quantity = 25,
                //    PurchasePrice = 125,
                //    GarmentID = 22,
                //    ShoppingCartID = 21,
                //},    new OrderItem
                //{
                //    Quantity = 26,
                //    PurchasePrice = 130,
                //    GarmentID = 23,
                //    ShoppingCartID = 22,
                //},    new OrderItem
                //{
                //    Quantity = 27,
                //    PurchasePrice = 135,
                //    GarmentID = 24,
                //    ShoppingCartID = 23,
                //},    new OrderItem
                //{
                //    Quantity = 28,
                //    PurchasePrice = 140,
                //    GarmentID = 25,
                //    ShoppingCartID = 24,
                //},    new OrderItem
                //{
                //    Quantity = 29,
                //    PurchasePrice = 145,
                //    GarmentID = 26,
                //    ShoppingCartID = 25,
                //},    new OrderItem
                //{
                //    Quantity = 30,
                //    PurchasePrice = 150,
                //    GarmentID = 27,
                //    ShoppingCartID = 26,
                //},    new OrderItem
                //{
                //    Quantity = 31,
                //    PurchasePrice = 155,
                //    GarmentID = 28,
                //    ShoppingCartID = 27,
                //},    new OrderItem
                //{
                //    Quantity = 32,
                //    PurchasePrice = 160,
                //    GarmentID = 29,
                //    ShoppingCartID = 28,
                //},


            };

            foreach (OrderItem i in items)
            {
                context.Orderitem.Add(i);
            };

            context.SaveChanges();
        }

    } // end class
} // end namespace

