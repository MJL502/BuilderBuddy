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
    [Migration("20220710144034_UpdateWithTestInfo")]
    partial class UpdateWithTestInfo
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

                    b.Property<int>("NumberOfRooms")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ProjectDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProjectName")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TotalCost")
                        .HasColumnType("TEXT");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberofWalls")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("RoomCost")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoomName")
                        .HasColumnType("TEXT");

                    b.HasKey("RoomID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Room");
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

                    b.Property<int>("RoomID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("WallCost")
                        .HasColumnType("TEXT");

                    b.HasKey("WallID");

                    b.HasIndex("RoomID");

                    b.ToTable("Wall");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Room", b =>
                {
                    b.HasOne("BuilderBuddy.Models.Project", null)
                        .WithMany("Rooms")
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuilderBuddy.Models.Wall", b =>
                {
                    b.HasOne("BuilderBuddy.Models.Room", null)
                        .WithMany("Walls")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BuilderBuddy.Models.Project", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("BuilderBuddy.Models.Room", b =>
                {
                    b.Navigation("Walls");
                });
#pragma warning restore 612, 618
        }
    }
}