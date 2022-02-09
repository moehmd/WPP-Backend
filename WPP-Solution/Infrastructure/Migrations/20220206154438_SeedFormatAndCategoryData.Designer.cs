﻿// <auto-generated />
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(WPPContext))]
    [Migration("20220206154438_SeedFormatAndCategoryData")]
    partial class SeedFormatAndCategoryData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Domain.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Hybrid Work"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Hybrid Work Research"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Modern Collaboration"
                        },
                        new
                        {
                            CategoryId = 4,
                            Name = "Employee Experience"
                        },
                        new
                        {
                            CategoryId = 5,
                            Name = "Next Gen Endpoints and Devices"
                        });
                });

            modelBuilder.Entity("Domain.Format", b =>
                {
                    b.Property<int>("FormatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormatId");

                    b.ToTable("Format");

                    b.HasData(
                        new
                        {
                            FormatId = 1,
                            Name = "On-demand Videos"
                        },
                        new
                        {
                            FormatId = 2,
                            Name = "Events and Webinars"
                        },
                        new
                        {
                            FormatId = 3,
                            Name = "Articles and eBooks"
                        },
                        new
                        {
                            FormatId = 4,
                            Name = "Immersion Workshops"
                        },
                        new
                        {
                            FormatId = 5,
                            Name = "Technical Training"
                        },
                        new
                        {
                            FormatId = 6,
                            Name = "End User Training"
                        });
                });

            modelBuilder.Entity("Domain.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FormatId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("FormatId");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Domain.Item", b =>
                {
                    b.HasOne("Domain.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Format", "Format")
                        .WithMany("Items")
                        .HasForeignKey("FormatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Format");
                });

            modelBuilder.Entity("Domain.Category", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("Domain.Format", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
