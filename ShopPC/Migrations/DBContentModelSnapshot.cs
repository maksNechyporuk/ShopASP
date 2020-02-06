﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Main.MockData;

namespace Shop.Migrations
{
    [DbContext(typeof(DBContent))]
    partial class DBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Main.Models.CPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("CPU");
                });

            modelBuilder.Entity("Shop.Main.Models.CategoryCPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryCPU");
                });

            modelBuilder.Entity("Shop.Main.Models.CategoryGPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryGPU");
                });

            modelBuilder.Entity("Shop.Main.Models.CategoryMB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryMB");
                });

            modelBuilder.Entity("Shop.Main.Models.CategoryPhone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryPhone");
                });

            modelBuilder.Entity("Shop.Main.Models.CategoryRAM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategoryRAM");
                });

            modelBuilder.Entity("Shop.Main.Models.CategorySSD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("CategorySSD");
                });

            modelBuilder.Entity("Shop.Main.Models.GPU", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("GPU");
                });

            modelBuilder.Entity("Shop.Main.Models.MB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("MB");
                });

            modelBuilder.Entity("Shop.Main.Models.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Shop.Main.Models.RAM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("RAM");
                });

            modelBuilder.Entity("Shop.Main.Models.SSD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId");

                    b.Property<string>("Description");

                    b.Property<string>("Img");

                    b.Property<string>("Name");

                    b.Property<long>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("SSD");
                });

            modelBuilder.Entity("Shop.Main.Models.CPU", b =>
                {
                    b.HasOne("Shop.Main.Models.CategoryCPU", "Category")
                        .WithMany("CPUs")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.Main.Models.GPU", b =>
                {
                    b.HasOne("Shop.Main.Models.CategoryGPU", "Category")
                        .WithMany("GPUs")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.Main.Models.MB", b =>
                {
                    b.HasOne("Shop.Main.Models.CategoryMB", "Category")
                        .WithMany("MBs")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.Main.Models.Phone", b =>
                {
                    b.HasOne("Shop.Main.Models.CategoryPhone", "Category")
                        .WithMany("Phones")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.Main.Models.RAM", b =>
                {
                    b.HasOne("Shop.Main.Models.CategoryRAM", "Category")
                        .WithMany("RAMs")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("Shop.Main.Models.SSD", b =>
                {
                    b.HasOne("Shop.Main.Models.CategorySSD", "Category")
                        .WithMany("SSDs")
                        .HasForeignKey("CategoryId");
                });
#pragma warning restore 612, 618
        }
    }
}
