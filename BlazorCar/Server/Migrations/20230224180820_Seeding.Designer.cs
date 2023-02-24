﻿// <auto-generated />
using System;
using BlazorCar.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorCar.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230224180820_Seeding")]
    partial class Seeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorCar.Shared.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bodystyle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Colour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Doors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Engine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gearbox")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublic")
                        .HasColumnType("bit");

                    b.Property<string>("Mileage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bodystyle = "Hatchback",
                            CategoryId = 1,
                            Colour = "Rebel Blue",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8214),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Volvo V40 1996cc 5dr",
                            Doors = "5",
                            Engine = "2.0L Diesel",
                            Gearbox = "Automatic",
                            Image = "/images/v40.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "47,500",
                            OriginalPrice = 13000m,
                            Price = 12579m,
                            Title = "Volvo V40 Hatchback 2015"
                        },
                        new
                        {
                            Id = 2,
                            Bodystyle = "Hatchback",
                            CategoryId = 5,
                            Colour = "Panda",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8242),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Iconic Panda Tureno AE86 - 1570cc 3dr - Perfect for Delivering Tofu Across Akina!",
                            Doors = "3",
                            Engine = "1.6L Petrol",
                            Gearbox = "Manual",
                            Image = "/images/toyota-ae86.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "92820",
                            OriginalPrice = 29000m,
                            Price = 26000m,
                            Title = "Toyota AE86 - 1987"
                        },
                        new
                        {
                            Id = 3,
                            Bodystyle = "Hatchback",
                            CategoryId = 1,
                            Colour = "Blaze Red",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8245),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Vauxhall Corsa 1160cc 3dr",
                            Doors = "3",
                            Engine = "1.2L Petrol",
                            Gearbox = "Manual",
                            Image = "/images/corsa.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "48,500",
                            OriginalPrice = 5330m,
                            Price = 5325m,
                            Title = "Vauxhall Corsa Hatchback 2015"
                        },
                        new
                        {
                            Id = 4,
                            Bodystyle = "Estate",
                            CategoryId = 2,
                            Colour = "Corrida Red",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8247),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Skoda Octavia 1570cc 5dr",
                            Doors = "5",
                            Engine = "1.6L Diesel",
                            Gearbox = "Automatic",
                            Image = "/images/skoda-octavia-estate.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "48,500",
                            OriginalPrice = 10650m,
                            Price = 10650m,
                            Title = "Skoda Octavia Estate 2017"
                        },
                        new
                        {
                            Id = 5,
                            Bodystyle = "Estate",
                            CategoryId = 2,
                            Colour = "Black",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8249),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Skoda Octavia 2993cc 5dr",
                            Doors = "5",
                            Engine = "3.0L Diesel",
                            Gearbox = "Automatic",
                            Image = "/images/bmw-520d.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "11,200",
                            OriginalPrice = 44000m,
                            Price = 43500m,
                            Title = "BMW 520d Estate 2023"
                        },
                        new
                        {
                            Id = 6,
                            Bodystyle = "Hatchback",
                            CategoryId = 1,
                            Colour = "Black",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8251),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Honda Civic Type R 182hp Hot Hatchback 1570cc 3dr",
                            Doors = "3",
                            Engine = "1.6L Petrol",
                            Gearbox = "Manual",
                            Image = "/images/civic-1997.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "170000",
                            OriginalPrice = 8000m,
                            Price = 7000m,
                            Title = "Honda Civic Type R 1997"
                        },
                        new
                        {
                            Id = 7,
                            Bodystyle = "SUV",
                            CategoryId = 3,
                            Colour = "Grey",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8253),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "1.5L T5 Pro Volvo XC40 1570cc 3dr",
                            Doors = "5",
                            Engine = "1.5L Petrol",
                            Gearbox = "Manual",
                            Image = "/images/xc40.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "170000",
                            OriginalPrice = 41990m,
                            Price = 41990m,
                            Title = "Volvo XC40 2021"
                        },
                        new
                        {
                            Id = 8,
                            Bodystyle = "Coupe",
                            CategoryId = 5,
                            Colour = "Grey",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8255),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Nissan R34 2.6L Twin-Turbocharged RB26 2606cc 3dr",
                            Doors = "3",
                            Engine = "2.6L Petrol",
                            Gearbox = "Manual",
                            Image = "/images/r34-skyline.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "9000",
                            OriginalPrice = 39460m,
                            Price = 39460m,
                            Title = "Nissan Skyline GTR R34 2001"
                        },
                        new
                        {
                            Id = 9,
                            Bodystyle = "Coupe",
                            CategoryId = 4,
                            Colour = "Grey",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8259),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Porsche Cayman 718 GT4 RS Coupe 3997cc 3dr",
                            Doors = "3",
                            Engine = "4.0L Petrol",
                            Gearbox = "Automatic",
                            Image = "/images/porsche.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "2500",
                            OriginalPrice = 123400m,
                            Price = 123400m,
                            Title = "Porsche 718 Cayman GT4 RS 2022"
                        },
                        new
                        {
                            Id = 10,
                            Bodystyle = "Coupe",
                            CategoryId = 4,
                            Colour = "Red",
                            DateCreated = new DateTime(2023, 2, 24, 18, 8, 20, 241, DateTimeKind.Local).AddTicks(8262),
                            DateUpdated = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Honda NSX 3.0L VTEC 2997cc 3dr",
                            Doors = "3",
                            Engine = "3.0L Petrol",
                            Gearbox = "Manual",
                            Image = "/images/nsx.jpg",
                            IsDeleted = false,
                            IsPublic = false,
                            Mileage = "2500",
                            OriginalPrice = 86000m,
                            Price = 84000m,
                            Title = "Honda NSX 1990"
                        });
                });

            modelBuilder.Entity("BlazorCar.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Hatchback",
                            Url = "hatchback"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Estate",
                            Url = "estate"
                        },
                        new
                        {
                            Id = 3,
                            Name = "SUV",
                            Url = "suv"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Coupe",
                            Url = "coupe"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Specials",
                            Url = "specials"
                        });
                });

            modelBuilder.Entity("BlazorCar.Shared.Car", b =>
                {
                    b.HasOne("BlazorCar.Shared.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorCar.Shared.Category", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
