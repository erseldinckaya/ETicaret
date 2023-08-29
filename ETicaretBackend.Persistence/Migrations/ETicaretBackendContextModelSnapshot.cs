﻿// <auto-generated />
using System;
using ETicaretBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ETicaretBackend.Persistence.Migrations
{
    [DbContext(typeof(ETicaretBackendContext))]
    partial class ETicaretBackendContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ETicaretBackend.Domain.Entities.Customer", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Guid");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("ETicaretBackend.Domain.Entities.Order", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Guid");

                    b.HasIndex("CustomerId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ETicaretBackend.Domain.Entities.Product", b =>
                {
                    b.Property<Guid>("Guid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("Price")
                        .HasColumnType("bigint");

                    b.Property<int>("Stock")
                        .HasColumnType("integer");

                    b.HasKey("Guid");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.Property<Guid>("OrdersGuid")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ProductsGuid")
                        .HasColumnType("uuid");

                    b.HasKey("OrdersGuid", "ProductsGuid");

                    b.HasIndex("ProductsGuid");

                    b.ToTable("OrderProduct");
                });

            modelBuilder.Entity("ETicaretBackend.Domain.Entities.Order", b =>
                {
                    b.HasOne("ETicaretBackend.Domain.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("OrderProduct", b =>
                {
                    b.HasOne("ETicaretBackend.Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrdersGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ETicaretBackend.Domain.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsGuid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ETicaretBackend.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}
