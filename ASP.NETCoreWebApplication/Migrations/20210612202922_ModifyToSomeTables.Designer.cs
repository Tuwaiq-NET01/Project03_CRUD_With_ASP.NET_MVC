﻿// <auto-generated />
using ASP.NETCoreWebApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASP.NETCoreWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612202922_ModifyToSomeTables")]
    partial class ModifyToSomeTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ASP.NETCoreWebApplication.Models.AnimeModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasMaxLength(255);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Anime");
                });

            modelBuilder.Entity("ASP.NETCoreWebApplication.Models.AnimeQuotesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CharDescreption")
                        .HasColumnType("text");

                    b.Property<string>("Character")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Quote")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("AnimeQuotes");
                });

            modelBuilder.Entity("ASP.NETCoreWebApplication.Models.UserInfoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserInfo");
                });

            modelBuilder.Entity("ASP.NETCoreWebApplication.Models.UsersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("UserInfoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserInfoId")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("ASP.NETCoreWebApplication.Models.AnimeModel", b =>
                {
                    b.HasOne("ASP.NETCoreWebApplication.Models.UsersModel", "User")
                        .WithMany("Anime")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ASP.NETCoreWebApplication.Models.UsersModel", b =>
                {
                    b.HasOne("ASP.NETCoreWebApplication.Models.UserInfoModel", "UserInfo")
                        .WithOne("Users")
                        .HasForeignKey("ASP.NETCoreWebApplication.Models.UsersModel", "UserInfoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
