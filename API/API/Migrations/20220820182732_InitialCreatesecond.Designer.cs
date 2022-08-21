﻿// <auto-generated />
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220820182732_InitialCreatesecond")]
    partial class InitialCreatesecond
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("API.Entities.Supplier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("LastName")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("Id");

                    b.ToTable("Supplier");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "behzad",
                            LastName = "eskandari"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "majid",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 3,
                            FirstName = "hasan",
                            LastName = "hasani"
                        },
                        new
                        {
                            Id = 4,
                            FirstName = "reza",
                            LastName = "nazari"
                        },
                        new
                        {
                            Id = 5,
                            FirstName = "hasan",
                            LastName = "nazari"
                        },
                        new
                        {
                            Id = 6,
                            FirstName = "nazari",
                            LastName = "majid"
                        },
                        new
                        {
                            Id = 7,
                            FirstName = "reza",
                            LastName = "nazari"
                        },
                        new
                        {
                            Id = 8,
                            FirstName = "javad",
                            LastName = "nazari"
                        },
                        new
                        {
                            Id = 9,
                            FirstName = "behzad",
                            LastName = "behzadi"
                        },
                        new
                        {
                            Id = 10,
                            FirstName = "reza",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 11,
                            FirstName = "hasan",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 12,
                            FirstName = "abas",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 13,
                            FirstName = "reza",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 14,
                            FirstName = "mehdi",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 15,
                            FirstName = "javad",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 16,
                            FirstName = "nabi",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 17,
                            FirstName = "asghar",
                            LastName = "majidi"
                        },
                        new
                        {
                            Id = 18,
                            FirstName = "frozan",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 19,
                            FirstName = "mehdi",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 20,
                            FirstName = "behzad",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 21,
                            FirstName = "reza",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 22,
                            FirstName = "majid",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 23,
                            FirstName = "javad",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 24,
                            FirstName = "keyval",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 25,
                            FirstName = "ali",
                            LastName = "frozan"
                        },
                        new
                        {
                            Id = 26,
                            FirstName = "ali",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 27,
                            FirstName = "keyvan",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 28,
                            FirstName = "hesam",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 29,
                            FirstName = "behzad",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 30,
                            FirstName = "reza",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 31,
                            FirstName = "jaavad",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 32,
                            FirstName = "majid",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 33,
                            FirstName = "hasan",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 34,
                            FirstName = "abbas",
                            LastName = "vedadi"
                        },
                        new
                        {
                            Id = 35,
                            FirstName = "reza",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 36,
                            FirstName = "mehdi",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 37,
                            FirstName = "hasan",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 38,
                            FirstName = "majid",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 39,
                            FirstName = "javad",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 40,
                            FirstName = "mehdi",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 41,
                            FirstName = "morteza",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 42,
                            FirstName = "mojtaba",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 43,
                            FirstName = "amir",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 44,
                            FirstName = "ali",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 45,
                            FirstName = "amirhosen",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 46,
                            FirstName = "saeed",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 47,
                            FirstName = "pejman",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 48,
                            FirstName = "parham",
                            LastName = "javani"
                        },
                        new
                        {
                            Id = 49,
                            FirstName = "john",
                            LastName = "doe"
                        },
                        new
                        {
                            Id = 50,
                            FirstName = "Jack",
                            LastName = "doe"
                        },
                        new
                        {
                            Id = 51,
                            FirstName = "hasan",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 52,
                            FirstName = "reza",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 53,
                            FirstName = "mehdi",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 54,
                            FirstName = "majid",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 55,
                            FirstName = "abas",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 56,
                            FirstName = "banfshe",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 57,
                            FirstName = "asal",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 58,
                            FirstName = "maryam",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 59,
                            FirstName = "bahare",
                            LastName = "revvandi"
                        },
                        new
                        {
                            Id = 60,
                            FirstName = "majidreza",
                            LastName = "revvandi"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}