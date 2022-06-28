﻿// <auto-generated />
using System;
using Infrastructure.Context.General;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations.GeneralMigrations
{
    [DbContext(typeof(GeneralContext))]
    [Migration("20220628161109_GeneralCreate")]
    partial class GeneralCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Infrastructure.Entities.General.CityEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodeCountry")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("Infrastructure.Entities.General.CountryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CodeIso")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CodePhone")
                        .HasColumnType("int");

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("catalogCountry", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.General.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("catalogGender", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.General.PersonEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext");

                    b.Property<string>("AddressOptional")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("BusinessName")
                        .HasColumnType("longtext");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("CreateOnAudit")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("FullName")
                        .HasColumnType("longtext");

                    b.Property<int>("IdGener")
                        .HasColumnType("int");

                    b.Property<int?>("IdNationality")
                        .HasColumnType("int");

                    b.Property<int?>("IdTypeIdentification")
                        .HasColumnType("int");

                    b.Property<int?>("IdUserModifyAudit")
                        .HasColumnType("int");

                    b.Property<int>("IdUserRegisterAudit")
                        .HasColumnType("int");

                    b.Property<string>("Identification")
                        .HasColumnType("longtext");

                    b.Property<string>("IpPublicAudit")
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext");

                    b.Property<string>("LatitudeAudit")
                        .HasColumnType("longtext");

                    b.Property<string>("LongitudeAudit")
                        .HasColumnType("longtext");

                    b.Property<string>("MacAddressAudit")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifyOnAudit")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NameSecond")
                        .HasColumnType("longtext");

                    b.Property<string>("NanmeFirst")
                        .HasColumnType("longtext");

                    b.Property<int?>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("ProfilePhoto")
                        .HasColumnType("longtext");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("SureName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Infrastructure.Entities.General.TypeIdentification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("catalogTypeIdentification", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.General.TypePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("catalogTypePerson", (string)null);
                });

            modelBuilder.Entity("Infrastructure.Entities.General.TypeSubscription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte>("State")
                        .HasColumnType("tinyint unsigned");

                    b.HasKey("Id");

                    b.ToTable("catalosSubscription", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
