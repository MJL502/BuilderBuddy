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
    [Migration("20220726223013_July26Update")]
    partial class July26Update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.6");

            modelBuilder.Entity("BuilderBuddy.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BoxesOfScrews")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DrywallCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("DrywallSheets")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("JointCompoundCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("JointTapeCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("PoundsOfJointCompound")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ProjectDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("RollsOfTape")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ScrewsCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("TotalCost")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            BoxesOfScrews = 0m,
                            DrywallCost = 0m,
                            DrywallSheets = 0m,
                            JointCompoundCost = 0m,
                            JointTapeCost = 0m,
                            PoundsOfJointCompound = 0m,
                            ProjectDate = new DateTime(2022, 7, 26, 18, 30, 13, 593, DateTimeKind.Local).AddTicks(2863),
                            ProjectName = "Lincoln's Cabin",
                            RollsOfTape = 0m,
                            ScrewsCost = 0m,
                            TotalCost = 0m
                        });
                });

            modelBuilder.Entity("BuilderBuddy.Models.Wall", b =>
                {
                    b.Property<int>("WallID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Area")
                        .HasColumnType("TEXT");

                    b.Property<int>("Drywall")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("DrywallCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<int>("JointCompound")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("JointCompoundCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("JointTape")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("JointTapeCost")
                        .HasColumnType("TEXT");

                    b.Property<int>("Length")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Screws")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("ScrewsCost")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("WallCost")
                        .HasColumnType("TEXT");

                    b.HasKey("WallID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Wall");

                    b.HasData(
                        new
                        {
                            WallID = 1,
                            Area = 192m,
                            Drywall = 7,
                            DrywallCost = 105m,
                            Height = 8,
                            JointCompound = 11,
                            JointCompoundCost = 5.5m,
                            JointTape = 0.2464m,
                            JointTapeCost = 1.2320m,
                            Length = 24,
                            ProjectID = 1,
                            Screws = 212,
                            ScrewsCost = 7m,
                            WallCost = 118.7320m
                        },
                        new
                        {
                            WallID = 2,
                            Area = 128m,
                            Drywall = 4,
                            DrywallCost = 60m,
                            Height = 8,
                            JointCompound = 7,
                            JointCompoundCost = 3.5m,
                            JointTape = 0.1408m,
                            JointTapeCost = 0.7040m,
                            Length = 16,
                            ProjectID = 1,
                            Screws = 141,
                            ScrewsCost = 5m,
                            WallCost = 69.2040m
                        },
                        new
                        {
                            WallID = 3,
                            Area = 192m,
                            Drywall = 7,
                            DrywallCost = 105m,
                            Height = 8,
                            JointCompound = 11,
                            JointCompoundCost = 5.5m,
                            JointTape = 0.2464m,
                            JointTapeCost = 1.2320m,
                            Length = 24,
                            ProjectID = 1,
                            Screws = 212,
                            ScrewsCost = 7m,
                            WallCost = 118.7320m
                        },
                        new
                        {
                            WallID = 4,
                            Area = 128m,
                            Drywall = 4,
                            DrywallCost = 60m,
                            Height = 8,
                            JointCompound = 7,
                            JointCompoundCost = 3.5m,
                            JointTape = 0.1408m,
                            JointTapeCost = 0.7040m,
                            Length = 16,
                            ProjectID = 1,
                            Screws = 141,
                            ScrewsCost = 5m,
                            WallCost = 69.2040m
                        });
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
#pragma warning restore 612, 618
        }
    }
}