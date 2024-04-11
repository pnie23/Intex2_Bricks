﻿// <auto-generated />
using System;
using Intex2_Bricks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Intex2_Bricks.Migrations.Bricks
{
    [DbContext(typeof(BricksContext))]
    [Migration("20240411184402_Initial11")]
    partial class Initial11
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("Intex2_Bricks.Models.Cart+CartLine", b =>
                {
                    b.Property<int>("CartLineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Ordertransaction_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("product_Id")
                        .HasColumnType("INTEGER");

                    b.HasKey("CartLineId");

                    b.HasIndex("Ordertransaction_Id");

                    b.HasIndex("product_Id");

                    b.ToTable("CartLine");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.Customer", b =>
                {
                    b.Property<int>("customer_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("birth_date")
                        .HasColumnType("TEXT");

                    b.Property<string>("country_of_residence")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("last_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("customer_Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.IBRecommendation", b =>
                {
                    b.Property<int>("product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Recommended_Product_1_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_1_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_1_Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_1_Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_2_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_2_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_2_Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_2_Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_3_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_3_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_3_Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_3_Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_4_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_4_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_4_Price")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_4_Year")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("product_Id");

                    b.ToTable("IBRecommendations");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.LineItem", b =>
                {
                    b.Property<int>("transaction_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("product_Id")
                        .HasColumnType("INTEGER");

                    b.Property<int>("qty")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("rating")
                        .HasColumnType("INTEGER");

                    b.HasKey("transaction_Id", "product_Id");

                    b.HasIndex("product_Id");

                    b.ToTable("LineItems");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.Order", b =>
                {
                    b.Property<int>("transaction_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Prediction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("amount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("bank")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("country_of_transaction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("customer_Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("day_of_week")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("entry_mode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("fraud")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("fulfilled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("shipping_address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("time")
                        .HasColumnType("INTEGER");

                    b.Property<string>("type_of_card")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("type_of_transaction")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("transaction_Id");

                    b.HasIndex("customer_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.Product", b =>
                {
                    b.Property<int>("product_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("img_link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("num_parts")
                        .HasColumnType("INTEGER");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<string>("primary_color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("secondary_color")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("product_Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.UBRecommendation", b =>
                {
                    b.Property<int?>("customer_Id")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Recommended_Product_1_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_1_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Recommended_Product_1_Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Recommended_Product_1_Year")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Recommended_Product_2_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_2_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Recommended_Product_2_Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Recommended_Product_2_Year")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Recommended_Product_3_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_3_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Recommended_Product_3_Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Recommended_Product_3_Year")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Recommended_Product_4_Img_Link")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Recommended_Product_4_Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Recommended_Product_4_Price")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Recommended_Product_4_Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("customer_Id");

                    b.ToTable("UBRecommendations");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.Cart+CartLine", b =>
                {
                    b.HasOne("Intex2_Bricks.Models.Order", null)
                        .WithMany("Lines")
                        .HasForeignKey("Ordertransaction_Id");

                    b.HasOne("Intex2_Bricks.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.LineItem", b =>
                {
                    b.HasOne("Intex2_Bricks.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("product_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Intex2_Bricks.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("transaction_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.Order", b =>
                {
                    b.HasOne("Intex2_Bricks.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("customer_Id");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.UBRecommendation", b =>
                {
                    b.HasOne("Intex2_Bricks.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("customer_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Intex2_Bricks.Models.Order", b =>
                {
                    b.Navigation("Lines");
                });
#pragma warning restore 612, 618
        }
    }
}
