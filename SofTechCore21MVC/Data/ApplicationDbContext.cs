using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SofTechCore21MVC.Models;

namespace SofTechCore21MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PaymentCard> PaymentCard { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<ShoppingCart> ShoppingCart { get; set; }

        public DbSet<OrderItem> Orderitem { get; set; }

        public DbSet<Address> Address { get; set; }

        public DbSet<Garment> Garment { get; set; }
             


    }
}
