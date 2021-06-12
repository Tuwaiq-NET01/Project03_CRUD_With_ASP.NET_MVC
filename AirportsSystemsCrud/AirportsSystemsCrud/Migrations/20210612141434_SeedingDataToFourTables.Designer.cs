﻿// <auto-generated />
using AirportsSystemsCrud.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AirportsSystemsCrud.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612141434_SeedingDataToFourTables")]
    partial class SeedingDataToFourTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AirportsSystemsCrud.Models.AirportModel", b =>
                {
                    b.Property<int>("Airport_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Airport_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Airport_Short")
                        .HasMaxLength(5)
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("Country_City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gate")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Airport_ID");

                    b.ToTable("Airports");

                    b.HasData(
                        new
                        {
                            Airport_ID = 1,
                            Airport_Name = "ALAIN INTERNATIONAL AIRPORT",
                            Airport_Short = "ANN",
                            Country_City = "emirates",
                            Gate = "G11"
                        },
                        new
                        {
                            Airport_ID = 2,
                            Airport_Name = "KING HUSSAIN INTERNATIONAL AIRPORT",
                            Airport_Short = "AQJ",
                            Country_City = "JURDAN",
                            Gate = "G107"
                        },
                        new
                        {
                            Airport_ID = 3,
                            Airport_Name = "ABUDAHABI INTERNATIONAL AIRPORT",
                            Airport_Short = "AUH",
                            Country_City = "emirates",
                            Gate = "G07"
                        },
                        new
                        {
                            Airport_ID = 4,
                            Airport_Name = "BAHRAIN INTERNATIONAL AIRPORT",
                            Airport_Short = "BAH",
                            Country_City = "bahrain",
                            Gate = "G34"
                        },
                        new
                        {
                            Airport_ID = 5,
                            Airport_Name = "KING FAHD INTERNATIONAL AIRPORT",
                            Airport_Short = "DMM",
                            Country_City = "dammam",
                            Gate = "G2"
                        });
                });

            modelBuilder.Entity("AirportsSystemsCrud.Models.EmpolyeeModel", b =>
                {
                    b.Property<int>("employee_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("blood_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("employee_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("employee_no")
                        .HasColumnType("int");

                    b.Property<string>("job_title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.Property<int>("working_hours")
                        .HasColumnType("int");

                    b.HasKey("employee_ID");

                    b.ToTable("Empolyees");
                });

            modelBuilder.Entity("AirportsSystemsCrud.Models.PassengerModel", b =>
                {
                    b.Property<int>("Passenger_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Passport_NO")
                        .HasColumnType("int");

                    b.HasKey("Passenger_ID");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            Passenger_ID = 234567890,
                            First_Name = "Sou",
                            Gender = "Male",
                            Last_Name = "Hong",
                            Nationality = "Japanese",
                            Passport_NO = 10
                        },
                        new
                        {
                            Passenger_ID = 987654321,
                            First_Name = "Zaina",
                            Gender = "Female",
                            Last_Name = "Algmosh",
                            Nationality = "Egyptian",
                            Passport_NO = 12
                        },
                        new
                        {
                            Passenger_ID = 345678901,
                            First_Name = "Mohammed",
                            Gender = "Male",
                            Last_Name = "Alqahtani",
                            Nationality = "Saudi Arabia",
                            Passport_NO = 20
                        });
                });

            modelBuilder.Entity("AirportsSystemsCrud.Models.PlaneModel", b =>
                {
                    b.Property<int>("Plane_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Plane_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plane_Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Plane_ID");

                    b.ToTable("Planes");

                    b.HasData(
                        new
                        {
                            Plane_ID = 11,
                            Capacity = 500,
                            Plane_Name = "Airbus A300 / A310",
                            Plane_Type = "Airbus"
                        },
                        new
                        {
                            Plane_ID = 14,
                            Capacity = 350,
                            Plane_Name = "Airbus 350",
                            Plane_Type = "Airbus"
                        },
                        new
                        {
                            Plane_ID = 15,
                            Capacity = 250,
                            Plane_Name = "Airbus 380",
                            Plane_Type = "Airbus"
                        },
                        new
                        {
                            Plane_ID = 13,
                            Capacity = 340,
                            Plane_Name = "Airbus 340",
                            Plane_Type = "Airbus"
                        },
                        new
                        {
                            Plane_ID = 12,
                            Capacity = 200,
                            Plane_Name = "Airbus 330",
                            Plane_Type = "Airbus"
                        });
                });

            modelBuilder.Entity("AirportsSystemsCrud.Models.TripModel", b =>
                {
                    b.Property<int>("TripID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cabin_Class")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Road_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Take_Off_Time")
                        .HasColumnType("int");

                    b.Property<string>("Trip_Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("TripID");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripID = 61132,
                            Cabin_Class = "guest",
                            Destination = "dammam",
                            Duration = 3,
                            Price = 457,
                            Road_Type = "one-way",
                            Take_Off_Time = 22,
                            Trip_Type = "Internal",
                            Weight = 30
                        },
                        new
                        {
                            TripID = 61234,
                            Cabin_Class = "first",
                            Destination = "LA-USA",
                            Duration = 10,
                            Price = 7939,
                            Road_Type = "one-way",
                            Take_Off_Time = 23,
                            Trip_Type = "international",
                            Weight = 50
                        },
                        new
                        {
                            TripID = 61345,
                            Cabin_Class = "guest",
                            Destination = "Turkey",
                            Duration = 13,
                            Price = 4211,
                            Road_Type = "round-trip",
                            Take_Off_Time = 0,
                            Trip_Type = "international",
                            Weight = 40
                        },
                        new
                        {
                            TripID = 61456,
                            Cabin_Class = "guest",
                            Destination = "NewYork-USA",
                            Duration = 14,
                            Price = 5689,
                            Road_Type = "round-trip",
                            Take_Off_Time = 19,
                            Trip_Type = "international",
                            Weight = 40
                        },
                        new
                        {
                            TripID = 61567,
                            Cabin_Class = "guest",
                            Destination = "Bali",
                            Duration = 11,
                            Price = 2945,
                            Road_Type = "one-way",
                            Take_Off_Time = 2,
                            Trip_Type = "international",
                            Weight = 40
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
