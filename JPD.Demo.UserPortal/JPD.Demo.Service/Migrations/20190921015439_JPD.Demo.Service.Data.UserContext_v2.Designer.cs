﻿// <auto-generated />
using System;
using JPD.Demo.Service.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JPD.Demo.Service.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20190921015439_JPD.Demo.Service.Data.UserContext_v2")]
    partial class JPDDemoServiceDataUserContext_v2
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
