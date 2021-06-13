﻿// <auto-generated />
using Hakam.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hakam.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612100805_v1")]
    partial class v1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hakam.Models.PodcastModel", b =>
                {
                    b.Property<int>("Podcast_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Podcast_Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Podcast_Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Podcast_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speaker_ID")
                        .HasColumnType("int");

                    b.HasKey("Podcast_ID");

                    b.ToTable("Podcasts");
                });

            modelBuilder.Entity("Hakam.Models.QuoteModel", b =>
                {
                    b.Property<int>("Quote_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Quote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Speaker_ID")
                        .HasColumnType("int");

                    b.HasKey("Quote_ID");

                    b.ToTable("Qoutes");
                });

            modelBuilder.Entity("Hakam.Models.SpeakerModel", b =>
                {
                    b.Property<int>("Speaker_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Speaker_FamousFor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Speeaker_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Speaker_ID");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("Hakam.Models.UserModel", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("User_Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("User_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_ID");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
