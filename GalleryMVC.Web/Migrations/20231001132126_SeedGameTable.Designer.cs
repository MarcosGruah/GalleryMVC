﻿// <auto-generated />
using System;
using GalleryMVC.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GalleryMVC.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231001132126_SeedGameTable")]
    partial class SeedGameTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.1.23419.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GalleryMVC.Web.Models.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GameId");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            GameId = new Guid("daf2e7e3-93c6-4ae9-bbab-bcb2ffac0ca8"),
                            Name = "World of Warcraft"
                        },
                        new
                        {
                            GameId = new Guid("e916c02f-53eb-43c0-bfbc-eaf714917cb7"),
                            Name = "Eve Online"
                        },
                        new
                        {
                            GameId = new Guid("ec7d7fb4-4688-48c4-9b49-018f68fc2c27"),
                            Name = "Dota 2"
                        },
                        new
                        {
                            GameId = new Guid("37c04cdf-36ec-4f36-a962-b94d05fce803"),
                            Name = "Baldur's Gate 3"
                        },
                        new
                        {
                            GameId = new Guid("28826e39-c217-46d4-a22a-37c26cdd48eb"),
                            Name = "Factorio"
                        },
                        new
                        {
                            GameId = new Guid("53db647b-80c1-4f85-80b3-0572fa579655"),
                            Name = "Counter-Strike 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}