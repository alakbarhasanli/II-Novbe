﻿// <auto-generated />
using System;
using Inance_MVC_tASK.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Inance_MVC_tASK.Migrations
{
    [DbContext(typeof(InanceDbContext))]
    partial class InanceDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Inance_MVC_tASK.Models.Masters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceYear")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.ToTable("masters");
                });

            modelBuilder.Entity("Inance_MVC_tASK.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClienrtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClientSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("MasterId")
                        .HasColumnType("int");

                    b.Property<string>("Problem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MasterId");

                    b.HasIndex("ServiceId");

                    b.ToTable("orders");
                });

            modelBuilder.Entity("Inance_MVC_tASK.Models.Services", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("services");
                });

            modelBuilder.Entity("Inance_MVC_tASK.Models.Masters", b =>
                {
                    b.HasOne("Inance_MVC_tASK.Models.Services", "Service")
                        .WithMany("Master")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Inance_MVC_tASK.Models.Orders", b =>
                {
                    b.HasOne("Inance_MVC_tASK.Models.Masters", "Master")
                        .WithMany("order")
                        .HasForeignKey("MasterId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Inance_MVC_tASK.Models.Services", "Service")
                        .WithMany("order1")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Master");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Inance_MVC_tASK.Models.Masters", b =>
                {
                    b.Navigation("order");
                });

            modelBuilder.Entity("Inance_MVC_tASK.Models.Services", b =>
                {
                    b.Navigation("Master");

                    b.Navigation("order1");
                });
#pragma warning restore 612, 618
        }
    }
}