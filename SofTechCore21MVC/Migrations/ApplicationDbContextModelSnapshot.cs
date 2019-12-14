﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SofTechCore21MVC.Data;

namespace SofTechCore21MVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Country");

                    b.Property<int>("County");

                    b.Property<string>("HouseNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("AddressID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Complaint", b =>
                {
                    b.Property<int>("ComplaintID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ComplaintRecieved");

                    b.Property<bool>("ContainsPicture");

                    b.Property<int?>("CustomerID");

                    b.Property<int>("OrderItemID");

                    b.Property<string>("Statement")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.HasKey("ComplaintID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("OrderItemID");

                    b.ToTable("Complaint");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressID");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Gender");

                    b.Property<int>("PaymentCardID");

                    b.Property<int>("PhoneNumber");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("TelephoneNo")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("UserID")
                        .HasMaxLength(50);

                    b.HasKey("CustomerID");

                    b.HasIndex("AddressID");

                    b.HasIndex("PaymentCardID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Favourite", b =>
                {
                    b.Property<int>("FavouriteID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<int>("GarmentID");

                    b.HasKey("FavouriteID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("GarmentID");

                    b.ToTable("Favourite");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Garment", b =>
                {
                    b.Property<int>("GarmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Colour");

                    b.Property<int>("Department");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<string>("GarmentName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Gender");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsAccessory");

                    b.Property<int>("Length");

                    b.Property<decimal>("Price");

                    b.Property<int>("Size");

                    b.Property<int>("Sleeves");

                    b.Property<decimal>("SpecialOfferPrice");

                    b.HasKey("GarmentID");

                    b.ToTable("Garment");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GarmentID");

                    b.Property<decimal>("PurchasePrice");

                    b.Property<int>("Quantity");

                    b.Property<int>("ShoppingCartID");

                    b.HasKey("OrderItemID");

                    b.HasIndex("GarmentID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("Orderitem");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.PaymentCard", b =>
                {
                    b.Property<int>("PaymentCardID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardName")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("CardType");

                    b.Property<int>("ExpiryMonth");

                    b.Property<int>("ExpiryYear");

                    b.Property<int>("SecurityNumber")
                        .HasMaxLength(3);

                    b.HasKey("PaymentCardID");

                    b.ToTable("PaymentCard");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Review", b =>
                {
                    b.Property<int>("ReviewID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<int>("GarmentID");

                    b.Property<float>("Rating");

                    b.Property<int>("ReviewDate");

                    b.Property<string>("Statement")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ReviewID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("GarmentID");

                    b.ToTable("Review");
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerID");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<DateTime>("OrderDate");

                    b.Property<decimal>("Postage");

                    b.Property<int>("Status")
                        .HasMaxLength(50);

                    b.HasKey("ShoppingCartID");

                    b.HasIndex("CustomerID");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Complaint", b =>
                {
                    b.HasOne("SofTechCore21MVC.Models.Customer")
                        .WithMany("Complaints")
                        .HasForeignKey("CustomerID");

                    b.HasOne("SofTechCore21MVC.Models.OrderItem", "OrderItem")
                        .WithMany()
                        .HasForeignKey("OrderItemID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Customer", b =>
                {
                    b.HasOne("SofTechCore21MVC.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SofTechCore21MVC.Models.PaymentCard", "PaymentCard")
                        .WithMany()
                        .HasForeignKey("PaymentCardID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Favourite", b =>
                {
                    b.HasOne("SofTechCore21MVC.Models.Customer")
                        .WithMany("Favourites")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SofTechCore21MVC.Models.Garment", "Garment")
                        .WithMany()
                        .HasForeignKey("GarmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.OrderItem", b =>
                {
                    b.HasOne("SofTechCore21MVC.Models.Garment", "Garment")
                        .WithMany()
                        .HasForeignKey("GarmentID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SofTechCore21MVC.Models.ShoppingCart", "ShoppingCart")
                        .WithMany("OrderItems")
                        .HasForeignKey("ShoppingCartID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.Review", b =>
                {
                    b.HasOne("SofTechCore21MVC.Models.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SofTechCore21MVC.Models.Garment", "Garment")
                        .WithMany()
                        .HasForeignKey("GarmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SofTechCore21MVC.Models.ShoppingCart", b =>
                {
                    b.HasOne("SofTechCore21MVC.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}