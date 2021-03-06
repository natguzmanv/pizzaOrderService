﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OrderService.Models;

namespace OrderService.Migrations
{
    [DbContext(typeof(OrderServiceContext))]
    [Migration("20190331222313_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OrderService.Models.MenuItem", b =>
                {
                    b.Property<long>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Description");

                    b.Property<string>("ItemCode");

                    b.Property<string>("Name");

                    b.Property<long>("RestaurantId");

                    b.Property<int>("Size");

                    b.HasKey("MenuItemId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1L,
                            Cost = 50m,
                            ItemCode = "CZ01",
                            Name = "Caprichosa",
                            RestaurantId = 1L,
                            Size = 6
                        },
                        new
                        {
                            MenuItemId = 2L,
                            Cost = 70m,
                            ItemCode = "CZ02",
                            Name = "Vegetariana",
                            RestaurantId = 1L,
                            Size = 8
                        },
                        new
                        {
                            MenuItemId = 3L,
                            Cost = 70m,
                            ItemCode = "CZ03",
                            Name = "Margarita",
                            RestaurantId = 1L,
                            Size = 8
                        },
                        new
                        {
                            MenuItemId = 4L,
                            Cost = 60m,
                            ItemCode = "BK01",
                            Name = "Napolitana",
                            RestaurantId = 2L,
                            Size = 8
                        },
                        new
                        {
                            MenuItemId = 5L,
                            Cost = 80m,
                            ItemCode = "BK02",
                            Name = "Hawaiana",
                            RestaurantId = 2L,
                            Size = 10
                        },
                        new
                        {
                            MenuItemId = 6L,
                            Cost = 90m,
                            ItemCode = "BK03",
                            Name = "Veranera",
                            RestaurantId = 2L,
                            Size = 12
                        },
                        new
                        {
                            MenuItemId = 7L,
                            Cost = 55m,
                            ItemCode = "EL01",
                            Name = "Tropicana",
                            RestaurantId = 3L,
                            Size = 6
                        },
                        new
                        {
                            MenuItemId = 8L,
                            Cost = 70m,
                            ItemCode = "EL02",
                            Name = "Mexicana",
                            RestaurantId = 3L,
                            Size = 6
                        },
                        new
                        {
                            MenuItemId = 9L,
                            Cost = 75m,
                            ItemCode = "EL03",
                            Name = "Pepperoni",
                            RestaurantId = 3L,
                            Size = 8
                        });
                });

            modelBuilder.Entity("OrderService.Models.Order", b =>
                {
                    b.Property<long>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDateTime");

                    b.Property<int>("OrderStatus");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OrderService.Models.OrderItem", b =>
                {
                    b.Property<long>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ItemCode");

                    b.Property<long>("OrderId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("OrderService.Models.Restaurant", b =>
                {
                    b.Property<long>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("RestaurantCode");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1L,
                            Name = "Cozzolisi",
                            RestaurantCode = "PZ01"
                        },
                        new
                        {
                            RestaurantId = 2L,
                            Name = "Bricks",
                            RestaurantCode = "PZ02"
                        },
                        new
                        {
                            RestaurantId = 3L,
                            Name = "Elis",
                            RestaurantCode = "PZ03"
                        });
                });

            modelBuilder.Entity("OrderService.Models.MenuItem", b =>
                {
                    b.HasOne("OrderService.Models.Restaurant", "Restaurant")
                        .WithMany("MenuItems")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OrderService.Models.OrderItem", b =>
                {
                    b.HasOne("OrderService.Models.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
