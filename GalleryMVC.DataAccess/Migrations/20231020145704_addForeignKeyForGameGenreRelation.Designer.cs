﻿// <auto-generated />
using System;
using GalleryMVC.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryMVC.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231020145704_addForeignKeyForGameGenreRelation")]
    partial class addForeignKeyForGameGenreRelation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GalleryMVC.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Developer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("LastEditedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Price")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f431d3fb-715d-4488-bc54-83c60a08ceb0"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9922),
                            Developer = "CD PROJEKT RED",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9924),
                            Price = 59.99m,
                            Publisher = "CD PROJEKT RED",
                            Title = "Cyberpunk 2077"
                        },
                        new
                        {
                            Id = new Guid("b42eac5f-d04c-42ab-84f0-90bde24684a4"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9929),
                            Developer = "Bethesda Game Studios",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9930),
                            Price = 69.99m,
                            Publisher = "Bethesda Softworks",
                            Title = "Starfield"
                        },
                        new
                        {
                            Id = new Guid("c39a5af6-b09d-45d7-afa2-d5ce2ab8f02a"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9933),
                            Developer = "Valve",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9934),
                            Price = 0m,
                            Publisher = "Valve",
                            Title = "Dota 2"
                        },
                        new
                        {
                            Id = new Guid("d7325c69-f141-4cce-9b63-5b0cc5676a0c"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9937),
                            Developer = "Larian Studios",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9937),
                            Price = 59.99m,
                            Publisher = "Larian Studios",
                            Title = "Baldur's Gate 3"
                        },
                        new
                        {
                            Id = new Guid("1d9f7152-23d3-43d5-8ffc-94c77fee6892"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9960),
                            Developer = "Klei Entertainment",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9961),
                            Price = 9.99m,
                            Publisher = "Klei Entertainment",
                            Title = "Don't Starve"
                        },
                        new
                        {
                            Id = new Guid("b3fb3b64-1bff-41e2-8e2e-e23990bdaed8"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9964),
                            Developer = "Wube Software LTD.",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9965),
                            Price = 35.00m,
                            Publisher = "Wube Software LTD.",
                            Title = "Factorio"
                        },
                        new
                        {
                            Id = new Guid("ee92e02a-5e08-43a6-aebd-6633ce425045"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9967),
                            Developer = "Klei Entertainment",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9968),
                            Price = 24.99m,
                            Publisher = "Klei Entertainment",
                            Title = "Oxygen Not Included"
                        },
                        new
                        {
                            Id = new Guid("e4e7b7b0-516c-4683-80e3-44efc5af9adb"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9973),
                            Developer = "CD PROJEKT RED",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9974),
                            Price = 39.99m,
                            Publisher = "CD PROJEKT RED",
                            Title = "The Witcher 3: Wild Hunt"
                        },
                        new
                        {
                            Id = new Guid("73a3f799-d562-4045-875c-d6c998a41ccf"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9977),
                            Developer = "Bethesda Game Studios",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9978),
                            Price = 19.99m,
                            Publisher = "Bethesda Softworks",
                            Title = "The Elder Scrolls V: Skyrim"
                        },
                        new
                        {
                            Id = new Guid("1e70550e-baf5-486f-a844-077e981f68fa"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9980),
                            Developer = "Valve",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9981),
                            Price = 0m,
                            Publisher = "Valve",
                            Title = "Counter-Strike 2"
                        },
                        new
                        {
                            Id = new Guid("5f5c0555-6060-4934-b26b-b18c4e89409a"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9984),
                            Developer = "Larian Studios",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9985),
                            Price = 44.99m,
                            Publisher = "Larian Studios",
                            Title = "Divinity: Original Sin 2"
                        },
                        new
                        {
                            Id = new Guid("d6675e62-1943-4728-a860-90cfcaa3122d"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9987),
                            Developer = "ConcernedApe",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9988),
                            Price = 14.99m,
                            Publisher = "ConcernedApe",
                            Title = "Stardew Valley"
                        },
                        new
                        {
                            Id = new Guid("6501f156-c9b8-4660-8113-9c312795dc7b"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9995),
                            Developer = "FromSoftware",
                            GenreId = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 489, DateTimeKind.Utc).AddTicks(9995),
                            Price = 59.99m,
                            Publisher = "Activision",
                            Title = "Sekiro: Shadows Die Twice"
                        });
                });

            modelBuilder.Entity("GalleryMVC.Models.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastEditedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("dba676cf-43d9-4faa-a444-8ed95049d991"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(199),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(200),
                            Name = "TestId"
                        },
                        new
                        {
                            Id = new Guid("751115f6-9c16-4502-a75a-2464dfa4e1c5"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(205),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(206),
                            Name = "RPG"
                        },
                        new
                        {
                            Id = new Guid("a440ac27-a6ec-4af2-b873-f8a94be0bf08"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(208),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(209),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("6adc91b5-302f-41cf-bb36-ea76bdd9ae19"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(212),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(212),
                            Name = "Strategy"
                        },
                        new
                        {
                            Id = new Guid("1c631646-4fe5-45b9-9616-df78f3a72a00"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(214),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(215),
                            Name = "Free to Play"
                        },
                        new
                        {
                            Id = new Guid("56b65229-1ed4-45ef-a14f-217d9c9e44e0"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(217),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(217),
                            Name = "Adventure"
                        },
                        new
                        {
                            Id = new Guid("682ee567-144d-42fb-8177-1be81802a4e6"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(220),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(220),
                            Name = "Indie"
                        },
                        new
                        {
                            Id = new Guid("41efab7c-d555-42fb-b5b7-8f26335a83dc"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(222),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(223),
                            Name = "Simulation"
                        },
                        new
                        {
                            Id = new Guid("ed0ba1ca-87c7-4438-b519-cadd2f948a19"),
                            CreatedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(230),
                            LastEditedDate = new DateTime(2023, 10, 20, 14, 57, 3, 490, DateTimeKind.Utc).AddTicks(230),
                            Name = "Shooter"
                        });
                });

            modelBuilder.Entity("GalleryMVC.Models.Game", b =>
                {
                    b.HasOne("GalleryMVC.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}