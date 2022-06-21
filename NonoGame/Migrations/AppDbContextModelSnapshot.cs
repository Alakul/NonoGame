﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NonoGame.DatabaseContext;

#nullable disable

namespace NonoGame.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("NonoGame.Model.Nonogram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Size")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Nonogram");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6321),
                            Image = "0;1;1;1;0;0;0;0;1;1;1;1;1;1;1;1;1;0;0;0;0;1;1;1;0",
                            Size = 5
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6354),
                            Image = "1;1;1;1;0;0;1;0;0;0;0;1;1;0;0;0;1;0;0;1;1;1;1;1;0",
                            Size = 5
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6357),
                            Image = "0;1;1;1;1;0;1;0;0;1;0;1;0;0;1;1;1;0;1;1;1;1;0;1;1",
                            Size = 5
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6359),
                            Image = "1;0;0;1;0;0;1;0;1;1;1;1;1;0;0;1;0;0;0;1;0;0;1;0;1;0;1;0;0;1;0;0;0;1;0;0;1;1;1;1;1;0;1;0;0;1;0;0;1",
                            Size = 7
                        },
                        new
                        {
                            Id = 5,
                            Date = new DateTime(2022, 6, 21, 18, 19, 22, 873, DateTimeKind.Local).AddTicks(6361),
                            Image = "0;0;1;0;0;0;0;1;0;0;1;1;1;1;1;0;1;1;1;0;1;0;0;0;1",
                            Size = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
