﻿// <auto-generated />
using System;
using JPD.Demo.Service.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JPD.Demo.Service.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20190921020324_JPD.Demo.Service.Data.UserContext_v3")]
    partial class JPDDemoServiceDataUserContext_v3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("JPD.Demo.Service.Entities.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(250);

                    b.Property<int>("AddressType");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<Guid>("UserId");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("AddressId");

                    b.HasIndex("UserId");

                    b.ToTable("Address","dbo");
                });

            modelBuilder.Entity("JPD.Demo.Service.Entities.Interest", b =>
                {
                    b.Property<Guid>("InterestId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid?>("UserId");

                    b.HasKey("InterestId");

                    b.HasIndex("UserId");

                    b.ToTable("Interest","dbo");
                });

            modelBuilder.Entity("JPD.Demo.Service.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<short>("Age");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.HasKey("UserId");

                    b.ToTable("User","dbo");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("f59d81fb-92ec-4439-8b9e-71a9a755a3e4"),
                            Age = (short)54,
                            FirstName = "John",
                            LastName = "Bennett"
                        },
                        new
                        {
                            UserId = new Guid("32f51d22-170f-45a3-b5cb-7991c6fbd5cd"),
                            Age = (short)79,
                            FirstName = "Charles",
                            LastName = "Diaz"
                        },
                        new
                        {
                            UserId = new Guid("c76c83a1-b9a5-46a5-9c23-5b6b15b57874"),
                            Age = (short)31,
                            FirstName = "Sara",
                            LastName = "Hayes"
                        },
                        new
                        {
                            UserId = new Guid("bd3b3826-e476-4725-a8e6-1c379d939c81"),
                            Age = (short)34,
                            FirstName = "Evan",
                            LastName = "Rivera"
                        },
                        new
                        {
                            UserId = new Guid("cd3de9f6-f465-4738-92d7-a89ed8514d25"),
                            Age = (short)34,
                            FirstName = "Pedro",
                            LastName = "Roberts"
                        },
                        new
                        {
                            UserId = new Guid("9a393e36-7ffb-4b2d-9d6a-29c32f2dee60"),
                            Age = (short)54,
                            FirstName = "William",
                            LastName = "Anderson"
                        },
                        new
                        {
                            UserId = new Guid("36b233ca-220e-4ca0-9d14-990bb2d09d29"),
                            Age = (short)63,
                            FirstName = "Jennifer",
                            LastName = "Lee"
                        },
                        new
                        {
                            UserId = new Guid("ecae1480-5d08-4d30-a697-94669be44e53"),
                            Age = (short)41,
                            FirstName = "William",
                            LastName = "Collins"
                        },
                        new
                        {
                            UserId = new Guid("3a3d2c28-cac1-46b2-8e35-4af209f47fca"),
                            Age = (short)71,
                            FirstName = "Barbara",
                            LastName = "Lee"
                        },
                        new
                        {
                            UserId = new Guid("af1c9989-4d63-4b1e-b004-3594c8b35369"),
                            Age = (short)19,
                            FirstName = "William",
                            LastName = "Reed"
                        },
                        new
                        {
                            UserId = new Guid("1b51fee5-0a96-468b-ab38-f4f9e54b50b3"),
                            Age = (short)28,
                            FirstName = "Barbara",
                            LastName = "Hall"
                        },
                        new
                        {
                            UserId = new Guid("961c78ab-f929-468d-8832-1c980888f1a1"),
                            Age = (short)67,
                            FirstName = "Thomas",
                            LastName = "Garcia"
                        },
                        new
                        {
                            UserId = new Guid("17edbab4-ae5a-45a3-aae2-b296802fd065"),
                            Age = (short)24,
                            FirstName = "Evan",
                            LastName = "Anderson"
                        },
                        new
                        {
                            UserId = new Guid("e49521a7-32c2-44fe-9749-1ad418a1ec80"),
                            Age = (short)40,
                            FirstName = "Juan",
                            LastName = "Lee"
                        },
                        new
                        {
                            UserId = new Guid("a15b4190-a27b-4e0e-9973-385d9320ae95"),
                            Age = (short)32,
                            FirstName = "Jennifer",
                            LastName = "Anderson"
                        },
                        new
                        {
                            UserId = new Guid("4d759f7a-7f53-454a-bf43-baf419aef94e"),
                            Age = (short)43,
                            FirstName = "William",
                            LastName = "Martin"
                        },
                        new
                        {
                            UserId = new Guid("0b29cee9-53d6-4799-b277-6fffad7b933e"),
                            Age = (short)73,
                            FirstName = "Mary",
                            LastName = "Rivera"
                        },
                        new
                        {
                            UserId = new Guid("629b1824-1159-45aa-bdfd-f7afa1a3b16c"),
                            Age = (short)41,
                            FirstName = "Charles",
                            LastName = ""
                        },
                        new
                        {
                            UserId = new Guid("4f09315a-b0b6-474f-8094-f32b688e1c3f"),
                            Age = (short)41,
                            FirstName = "John",
                            LastName = "Hayes"
                        },
                        new
                        {
                            UserId = new Guid("b35fc2eb-d202-4b3a-8cb2-39677a651bd3"),
                            Age = (short)27,
                            FirstName = "Patricia",
                            LastName = "Rivera"
                        });
                });

            modelBuilder.Entity("JPD.Demo.Service.Entities.Address", b =>
                {
                    b.HasOne("JPD.Demo.Service.Entities.User", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JPD.Demo.Service.Entities.Interest", b =>
                {
                    b.HasOne("JPD.Demo.Service.Entities.User")
                        .WithMany("Interests")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}