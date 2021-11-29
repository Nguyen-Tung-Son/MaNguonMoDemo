﻿// <auto-generated />
using System;
using DemoMVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoMVC.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211129135315_Create_table_Product")]
    partial class Create_table_Product
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DemoMVC.Models.Employee", b =>
                {
                    b.Property<string>("EmployeeId")
                        .HasColumnType("TEXT");

                    b.Property<string>("EmployeeName")
                        .HasColumnType("TEXT");

                    b.Property<int>("EmployeePhoneNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DemoMVC.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("DemoMVC.Models.Product", b =>
                {
                    b.Property<string>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.HasKey("ProductId");

                    b.ToTable("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
