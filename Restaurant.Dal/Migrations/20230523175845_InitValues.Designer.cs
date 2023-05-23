﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Restaurant.Dal.Contexts;

#nullable disable

namespace Restaurant.Dal.Migrations
{
    [DbContext(typeof(RestaurantContext))]
    [Migration("20230523175845_InitValues")]
    partial class InitValues
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Restaurant.Dal.Entities.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.CommentToOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeOfOrder")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("CommentsToOrder");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.MenuPosition", b =>
                {
                    b.Property<Guid>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PositionId");

                    b.ToTable("MenuPositions");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("date");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("ClientId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.PositionInOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<Guid>("MenuPostionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId", "MenuPostionId");

                    b.HasIndex("MenuPostionId");

                    b.ToTable("PositionsInOrders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Table", b =>
                {
                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.Property<int>("AmountOfPlaces")
                        .HasColumnType("int");

                    b.HasKey("TableNumber");

                    b.ToTable("Tables");

                    b.HasCheckConstraint("CHK_PK_TableNumber", "TableNumber > 0");

                    b.HasData(
                        new
                        {
                            TableNumber = 1,
                            AmountOfPlaces = 1
                        },
                        new
                        {
                            TableNumber = 2,
                            AmountOfPlaces = 2
                        },
                        new
                        {
                            TableNumber = 3,
                            AmountOfPlaces = 3
                        },
                        new
                        {
                            TableNumber = 4,
                            AmountOfPlaces = 4
                        });
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.DeliveryOrder", b =>
                {
                    b.HasBaseType("Restaurant.Dal.Entities.Order");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("DeliveryOrders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Dish", b =>
                {
                    b.HasBaseType("Restaurant.Dal.Entities.MenuPosition");

                    b.Property<string>("TypeOfDish")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.ToTable("Dishes");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Drink", b =>
                {
                    b.HasBaseType("Restaurant.Dal.Entities.MenuPosition");

                    b.Property<string>("TypeOfDrink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.ToTable("Drinks");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.InRestaurantOrder", b =>
                {
                    b.HasBaseType("Restaurant.Dal.Entities.Order");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasIndex("TableNumber");

                    b.ToTable("InRestaurantOrders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Wine", b =>
                {
                    b.HasBaseType("Restaurant.Dal.Entities.MenuPosition");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBottle")
                        .HasColumnType("bit");

                    b.Property<string>("RegionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TypeOfWine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.ToTable("Wines");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.CommentToOrder", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Order", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.Client", "Client")
                        .WithMany("Orders")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.PositionInOrder", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.MenuPosition", "MenuPosition")
                        .WithMany("PositionsInOrders")
                        .HasForeignKey("MenuPostionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Restaurant.Dal.Entities.Order", "Order")
                        .WithMany("PositionsInOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuPosition");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.DeliveryOrder", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.Order", null)
                        .WithOne()
                        .HasForeignKey("Restaurant.Dal.Entities.DeliveryOrder", "OrderId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Dish", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.MenuPosition", null)
                        .WithOne()
                        .HasForeignKey("Restaurant.Dal.Entities.Dish", "PositionId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Drink", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.MenuPosition", null)
                        .WithOne()
                        .HasForeignKey("Restaurant.Dal.Entities.Drink", "PositionId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.InRestaurantOrder", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.Order", null)
                        .WithOne()
                        .HasForeignKey("Restaurant.Dal.Entities.InRestaurantOrder", "OrderId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("Restaurant.Dal.Entities.Table", "Table")
                        .WithMany("InRestaurantOrders")
                        .HasForeignKey("TableNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Table");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Wine", b =>
                {
                    b.HasOne("Restaurant.Dal.Entities.MenuPosition", null)
                        .WithOne()
                        .HasForeignKey("Restaurant.Dal.Entities.Wine", "PositionId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Client", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.MenuPosition", b =>
                {
                    b.Navigation("PositionsInOrders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Order", b =>
                {
                    b.Navigation("PositionsInOrders");
                });

            modelBuilder.Entity("Restaurant.Dal.Entities.Table", b =>
                {
                    b.Navigation("InRestaurantOrders");
                });
#pragma warning restore 612, 618
        }
    }
}