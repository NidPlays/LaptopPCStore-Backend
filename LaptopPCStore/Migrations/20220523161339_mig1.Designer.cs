﻿// <auto-generated />
using System;
using LaptopPCStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaptopPCStore.Migrations
{
    [DbContext(typeof(LaptopStoreContext))]
    [Migration("20220523161339_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LaptopPCStore.Models.Inventory", b =>
                {
                    b.Property<int>("inv_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("lap_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.HasKey("inv_id");

                    b.ToTable("inventories");
                });

            modelBuilder.Entity("LaptopPCStore.Models.Invoice", b =>
                {
                    b.Property<int>("invoice_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("inv_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("inv_mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("inv_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("inv_phone")
                        .HasColumnType("int");

                    b.Property<int>("lap_id")
                        .HasColumnType("int");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("invoice_id");

                    b.HasIndex("lap_id");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("LaptopPCStore.Models.Laptop", b =>
                {
                    b.Property<int>("lap_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("lap_battrey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_cat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_cpu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_disp_res")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_disp_rr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_disp_size")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_gpu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lap_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("lap_ram")
                        .HasColumnType("int");

                    b.Property<string>("lap_storage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("lap_id");

                    b.ToTable("laptops");
                });

            modelBuilder.Entity("LaptopPCStore.Models.Purchase", b =>
                {
                    b.Property<int>("purchase_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("lap_id")
                        .HasColumnType("int");

                    b.Property<int>("purchase_cost")
                        .HasColumnType("int");

                    b.Property<DateTime>("purchase_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("purchase_quantity")
                        .HasColumnType("int");

                    b.Property<int?>("ven_id")
                        .HasColumnType("int");

                    b.HasKey("purchase_id");

                    b.HasIndex("lap_id");

                    b.HasIndex("ven_id");

                    b.ToTable("purchases");
                });

            modelBuilder.Entity("LaptopPCStore.Models.Vendor", b =>
                {
                    b.Property<int>("ven_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ven_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ven_mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ven_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ven_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ven_id");

                    b.ToTable("vendors");
                });

            modelBuilder.Entity("LaptopPCStore.Models.Invoice", b =>
                {
                    b.HasOne("LaptopPCStore.Models.Laptop", "fk6")
                        .WithMany()
                        .HasForeignKey("lap_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("fk6");
                });

            modelBuilder.Entity("LaptopPCStore.Models.Purchase", b =>
                {
                    b.HasOne("LaptopPCStore.Models.Laptop", "fk3")
                        .WithMany()
                        .HasForeignKey("lap_id");

                    b.HasOne("LaptopPCStore.Models.Vendor", "fk2")
                        .WithMany()
                        .HasForeignKey("ven_id");

                    b.Navigation("fk2");

                    b.Navigation("fk3");
                });
#pragma warning restore 612, 618
        }
    }
}
