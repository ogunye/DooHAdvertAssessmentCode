﻿// <auto-generated />
using System;
using DooHAdvertAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DooHAdvertAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230703174221_firstMigration")]
    partial class firstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DooHAdvertAPI.Models.Adverts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Adverts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "London",
                            EndTime = new DateTime(2023, 7, 6, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/AeroTech Drones",
                            Priority = 9,
                            StartTime = new DateTime(2023, 7, 3, 18, 42, 21, 119, DateTimeKind.Local).AddTicks(3632)
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Bournemouth",
                            EndTime = new DateTime(2023, 7, 8, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/HumblePies",
                            Priority = 4,
                            StartTime = new DateTime(2023, 7, 2, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Sheffield",
                            EndTime = new DateTime(2023, 7, 8, 7, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/Java Coffee",
                            Priority = 6,
                            StartTime = new DateTime(2023, 7, 3, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Manchester",
                            EndTime = new DateTime(2023, 7, 9, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/LNN",
                            Priority = 6,
                            StartTime = new DateTime(2023, 7, 4, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Leeds",
                            EndTime = new DateTime(2023, 7, 10, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/LumoThread",
                            Priority = 2,
                            StartTime = new DateTime(2023, 7, 5, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Liverpool",
                            EndTime = new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/MackyCs",
                            Priority = 5,
                            StartTime = new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Brighton",
                            EndTime = new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/Solaris Solar",
                            Priority = 2,
                            StartTime = new DateTime(2023, 7, 6, 10, 30, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CityName = "Hove",
                            EndTime = new DateTime(2023, 7, 11, 5, 10, 0, 0, DateTimeKind.Unspecified),
                            Path = "Resources/Images/Solaris Solar",
                            Priority = 9,
                            StartTime = new DateTime(2023, 7, 3, 18, 42, 21, 119, DateTimeKind.Local).AddTicks(3714)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
