﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Wordle.DAL;

#nullable disable

namespace Wordle.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Wordle.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CurrentDate")
                        .HasColumnType("DATETIME2");

                    b.Property<int>("CurrentPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("CurrentWordId")
                        .HasColumnType("int");

                    b.Property<int>("NumTries")
                        .HasColumnType("int");

                    b.Property<int?>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int?>("StatGameId")
                        .HasColumnType("int");

                    b.Property<int?>("StatPlayerId")
                        .HasColumnType("int");

                    b.Property<int>("WordId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.HasIndex("WordId");

                    b.HasIndex("StatPlayerId", "StatGameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Wordle.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Language")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Wordle.Models.Stat", b =>
                {
                    b.Property<int>("PlayerId")
                        .HasColumnType("int");

                    b.Property<int>("GameId")
                        .HasColumnType("int");

                    b.Property<int>("GamesPlayed")
                        .HasColumnType("int");

                    b.Property<int>("GamesWon")
                        .HasColumnType("int");

                    b.Property<int>("MaxStreak")
                        .HasColumnType("int");

                    b.Property<int>("Streak")
                        .HasColumnType("int");

                    b.Property<int>("WinPercentage")
                        .HasColumnType("int");

                    b.HasKey("PlayerId", "GameId");

                    b.HasIndex("GameId");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("Stats");
                });

            modelBuilder.Entity("Wordle.Models.Word", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int?>("GameId")
                        .HasColumnType("int");

                    b.Property<string>("Term")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.HasKey("Id");

                    b.HasIndex("GameId");

                    b.ToTable("Words");
                });

            modelBuilder.Entity("Wordle.Models.Game", b =>
                {
                    b.HasOne("Wordle.Models.Player", "Player")
                        .WithMany("Games")
                        .HasForeignKey("PlayerId");

                    b.HasOne("Wordle.Models.Word", "Word")
                        .WithMany()
                        .HasForeignKey("WordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wordle.Models.Stat", null)
                        .WithMany("Games")
                        .HasForeignKey("StatPlayerId", "StatGameId");

                    b.Navigation("Player");

                    b.Navigation("Word");
                });

            modelBuilder.Entity("Wordle.Models.Stat", b =>
                {
                    b.HasOne("Wordle.Models.Game", "Game")
                        .WithMany()
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Wordle.Models.Player", "Player")
                        .WithOne("Stats")
                        .HasForeignKey("Wordle.Models.Stat", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Game");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Wordle.Models.Word", b =>
                {
                    b.HasOne("Wordle.Models.Game", null)
                        .WithMany("Words")
                        .HasForeignKey("GameId");
                });

            modelBuilder.Entity("Wordle.Models.Game", b =>
                {
                    b.Navigation("Words");
                });

            modelBuilder.Entity("Wordle.Models.Player", b =>
                {
                    b.Navigation("Games");

                    b.Navigation("Stats")
                        .IsRequired();
                });

            modelBuilder.Entity("Wordle.Models.Stat", b =>
                {
                    b.Navigation("Games");
                });
#pragma warning restore 612, 618
        }
    }
}
