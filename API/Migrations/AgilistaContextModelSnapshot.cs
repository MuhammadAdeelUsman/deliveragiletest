﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Agilistas.Migrations
{
    [DbContext(typeof(AgilistaContext))]
    partial class AgilistaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AgilistaTracker.Agilista", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("PrimaryFocusId");

                    b.Property<string>("TwitterHandle");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryFocusId");

                    b.ToTable("Agilistas");
                });

            modelBuilder.Entity("AgilistaTracker.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("AgilistaTracker.Agilista", b =>
                {
                    b.HasOne("AgilistaTracker.Category", "PrimaryFocus")
                        .WithMany()
                        .HasForeignKey("PrimaryFocusId");
                });
#pragma warning restore 612, 618
        }
    }
}
