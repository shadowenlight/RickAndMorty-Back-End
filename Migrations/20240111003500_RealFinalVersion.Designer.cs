﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RickAndMorty.Data;

#nullable disable

namespace RickAndMorty.Migrations
{
    [DbContext(typeof(RickAndMortyDbContext))]
    [Migration("20240111003500_RealFinalVersion")]
    partial class RealFinalVersion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CharacterEpisode", b =>
                {
                    b.Property<int>("Charactersid")
                        .HasColumnType("int");

                    b.Property<int>("episodeid")
                        .HasColumnType("int");

                    b.HasKey("Charactersid", "episodeid");

                    b.HasIndex("episodeid");

                    b.ToTable("CharacterEpisode");
                });

            modelBuilder.Entity("RickAndMorty.Models.Character", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("locationId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("originId")
                        .HasColumnType("int");

                    b.Property<string>("species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("locationId");

                    b.HasIndex("originId");

                    b.ToTable("characters");
                });

            modelBuilder.Entity("RickAndMorty.Models.Episode", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("air_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("episode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("episodes");
                });

            modelBuilder.Entity("RickAndMorty.Models.Location", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("locations");
                });

            modelBuilder.Entity("CharacterEpisode", b =>
                {
                    b.HasOne("RickAndMorty.Models.Character", null)
                        .WithMany()
                        .HasForeignKey("Charactersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RickAndMorty.Models.Episode", null)
                        .WithMany()
                        .HasForeignKey("episodeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RickAndMorty.Models.Character", b =>
                {
                    b.HasOne("RickAndMorty.Models.Location", "location")
                        .WithMany()
                        .HasForeignKey("locationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("RickAndMorty.Models.Location", "origin")
                        .WithMany()
                        .HasForeignKey("originId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("location");

                    b.Navigation("origin");
                });
#pragma warning restore 612, 618
        }
    }
}
