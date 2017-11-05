﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TransCompanyApp.Models;

namespace TransCompanyApp.Migrations
{
    [DbContext(typeof(BaseContext))]
    [Migration("20171105170153_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TransCompanyApp.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("Avatar");

                    b.Property<int>("CompanyId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.Property<string>("Role");

                    b.Property<string>("Surname");

                    b.Property<string>("Token")
                        .IsRequired();

                    b.Property<bool>("Verificate");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("TransCompanyApp.Models.billing.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("TransCompanyApp.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<int>("BIK");

                    b.Property<string>("Country");

                    b.Property<int>("INN");

                    b.Property<int>("KPP");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("OGRN");

                    b.Property<string>("PostIndex");

                    b.Property<string>("Sity")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("TransCompanyApp.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<string>("Region");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("TransCompanyApp.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.Property<string>("Telephone");

                    b.HasKey("Id");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("TransCompanyApp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<int>("Status");

                    b.Property<string>("Surname")
                        .IsRequired();

                    b.Property<int>("TariffId");

                    b.Property<DateTime>("TimeCreate");

                    b.HasKey("Id");

                    b.HasIndex("TariffId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("TransCompanyApp.Models.Tariff", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("PricePerKm");

                    b.Property<string>("TariffName");

                    b.HasKey("Id");

                    b.ToTable("Tariffs");
                });

            modelBuilder.Entity("TransCompanyApp.Models.Account", b =>
                {
                    b.HasOne("TransCompanyApp.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("TransCompanyApp.Models.Order", b =>
                {
                    b.HasOne("TransCompanyApp.Models.Tariff", "Tariff")
                        .WithMany()
                        .HasForeignKey("TariffId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}