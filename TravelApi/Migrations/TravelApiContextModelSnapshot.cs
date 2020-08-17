﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Continent");

                    b.Property<string>("Country");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            City = "Portland",
                            Continent = "North_America",
                            Country = "USA"
                        },
                        new
                        {
                            LocationId = 2,
                            City = "Paris",
                            Continent = "Europe",
                            Country = "France"
                        },
                        new
                        {
                            LocationId = 3,
                            City = "Mexico City",
                            Continent = "North_America",
                            Country = "Mexico"
                        },
                        new
                        {
                            LocationId = 4,
                            City = "Tokyo",
                            Continent = "Asia",
                            Country = "Japan"
                        },
                        new
                        {
                            LocationId = 5,
                            City = "Rome",
                            Continent = "Europe",
                            Country = "Italy"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
