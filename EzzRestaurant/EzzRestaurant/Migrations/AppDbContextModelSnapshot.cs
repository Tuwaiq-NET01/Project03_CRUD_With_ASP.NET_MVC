﻿// <auto-generated />
using EzzRestaurant.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EzzRestaurant.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EzzRestaurant.Models.CategoryModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Img")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Img = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Main Meals"
                        },
                        new
                        {
                            Id = 2,
                            Img = "https://images.pexels.com/photos/209549/pexels-photo-209549.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Juices"
                        },
                        new
                        {
                            Id = 3,
                            Img = "https://images.pexels.com/photos/4577740/pexels-photo-4577740.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Entrees"
                        },
                        new
                        {
                            Id = 4,
                            Img = "https://images.pexels.com/photos/5591666/pexels-photo-5591666.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                            Name = "Breakfast"
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TotalPrice = 35.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            TotalPrice = 156.0,
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            TotalPrice = 21.0,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderProductsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderProduct");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OrderId = 1,
                            ProductId = 8
                        },
                        new
                        {
                            Id = 2,
                            OrderId = 1,
                            ProductId = 5
                        },
                        new
                        {
                            Id = 3,
                            OrderId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            Id = 4,
                            OrderId = 2,
                            ProductId = 3
                        },
                        new
                        {
                            Id = 5,
                            OrderId = 2,
                            ProductId = 5
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.ProductModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("img")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Name = "Steak",
                            Price = 100.0,
                            img = "https://images.pexels.com/photos/3535395/pexels-photo-3535395.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Name = "Pizza",
                            Price = 16.0,
                            img = "https://images.pexels.com/photos/825661/pexels-photo-825661.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Name = "spaghetti",
                            Price = 42.0,
                            img = "https://images.pexels.com/photos/41320/beef-cheese-cuisine-delicious-41320.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Name = "pasta",
                            Price = 34.0,
                            img = "https://images.pexels.com/photos/2703468/pexels-photo-2703468.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Name = "Orange",
                            Price = 14.0,
                            img = "https://images.pexels.com/photos/1002778/pexels-photo-1002778.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Name = "Mango",
                            Price = 14.0,
                            img = "https://images.pexels.com/photos/4023132/pexels-photo-4023132.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Name = "Entrees one",
                            Price = 21.0,
                            img = "https://images.pexels.com/photos/4669304/pexels-photo-4669304.jpeg?auto=compress&cs=tinysrgb&dpr=2&w=500"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 4,
                            Name = "Flafel",
                            Price = 21.0,
                            img = "https://images.pexels.com/photos/6275118/pexels-photo-6275118.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirthDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = "1997-5-31",
                            Fname = "Abdulaziz",
                            Lname = "Almohammadi",
                            PhoneNumber = 582215215
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = "1992-3-03",
                            Fname = "Hussain",
                            Lname = "Alghamdi",
                            PhoneNumber = 555488485
                        });
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderModel", b =>
                {
                    b.HasOne("EzzRestaurant.Models.UserModel", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("EzzRestaurant.Models.OrderProductsModel", b =>
                {
                    b.HasOne("EzzRestaurant.Models.OrderModel", "Order")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EzzRestaurant.Models.ProductModel", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EzzRestaurant.Models.ProductModel", b =>
                {
                    b.HasOne("EzzRestaurant.Models.CategoryModel", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EzzRestaurant.Models.CategoryModel", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("EzzRestaurant.Models.UserModel", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
