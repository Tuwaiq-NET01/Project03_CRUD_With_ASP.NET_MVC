﻿// <auto-generated />
using MVC_DB_Project.data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_DB_Project.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210605153622_CochesLeagueRelations")]
    partial class CochesLeagueRelations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("MVC_DB_Project.Models.CoacheModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int>("experience")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("nationality")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("MVC_DB_Project.Models.LeagueModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("numberOfTeams")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("leagues");
                });

            modelBuilder.Entity("MVC_DB_Project.Models.PlayerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CoacheId")
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CoacheId");

                    b.HasIndex("LeagueId");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("MVC_DB_Project.Models.TeamModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<int>("numberOfPlayers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MVC_DB_Project.Models.CoacheModel", b =>
                {
                    b.HasOne("MVC_DB_Project.Models.LeagueModel", "League")
                        .WithMany("Coaches")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_DB_Project.Models.PlayerModel", b =>
                {
                    b.HasOne("MVC_DB_Project.Models.CoacheModel", "Coache")
                        .WithMany("players")
                        .HasForeignKey("CoacheId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_DB_Project.Models.LeagueModel", "League")
                        .WithMany("players")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_DB_Project.Models.TeamModel", "Team")
                        .WithMany("players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
