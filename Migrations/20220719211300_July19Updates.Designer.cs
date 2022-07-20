﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BuilderBuddy.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220719211300_July19Updates")]
    partial class July19Updates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("BuilderBuddy.Models.Materials", b =>
                {
                    b.Property<int>("MaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("WallID")
                        .HasColumnType("INTEGER");

                    b.HasKey("MaterialID");

                    b.HasIndex("WallID");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ProjectDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            ProjectDate = new DateTime(2022, 7, 19, 17, 12, 59, 900, DateTimeKind.Local).AddTicks(8458),
                            ProjectName = "Lincoln's Cabin"
                        });
                });

            modelBuilder.Entity("BuilderBuddy.Models.Wall", b =>
                {
                    b.Property<int>("WallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("WallCost")
                        .HasColumnType("TEXT");

                    b.HasKey("WallID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Wall");

                    b.HasData(
                        new
                        {
                            WallID = 1,
                            Height = 8,
                            Length = 24,
                            ProjectID = 1
                        },
                        new
                        {
                            WallID = 2,
                            Height = 8,
                            Length = 16,
                            ProjectID = 1
                        },
                        new
                        {
                            WallID = 3,
                            Height = 8,
                            Length = 24,
                            ProjectID = 1
                        },
                        new
                        {
                            WallID = 4,
                            Height = 8,
                            Length = 16,
                            ProjectID = 1
                        });
                });

            modelBuilder.Entity("BuilderBuddy.Models.Materials", b =>
                {
                    b.HasOne("BuilderBuddy.Models.Wall", "Wall")
                        .WithMany("MaterialsNeeded")
                        .HasForeignKey("WallID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wall");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Wall", b =>
                {
                    b.HasOne("BuilderBuddy.Models.Project", "Project")
                        .WithMany("Walls")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Project", b =>
                {
                    b.Navigation("Walls");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Wall", b =>
                {
                    b.Navigation("MaterialsNeeded");
                });
#pragma warning restore 612, 618
        }
    }
}