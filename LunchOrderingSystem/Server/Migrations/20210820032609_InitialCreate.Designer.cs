﻿// <auto-generated />
using System;
using LunchOrderingSystem.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LunchOrderingSystem.Server.Migrations
{
    [DbContext(typeof(MenuDbContext))]
    [Migration("20210820032609_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("LunchOrderingSystem.Server.OrderInfo", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserIP")
                        .HasColumnType("TEXT");

                    b.HasKey("OrderId");

                    b.ToTable("OrderInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
