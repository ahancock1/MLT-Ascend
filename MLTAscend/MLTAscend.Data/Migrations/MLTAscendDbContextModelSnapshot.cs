﻿// <auto-generated />
using System;
using MLTAscend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MLTAscend.Data.Migrations
{
    [DbContext(typeof(MLTAscendDbContext))]
    partial class MLTAscendDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MLTAscend.Domain.Models.Prediction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<DateTime>("CreationDate");

                    b.Property<double>("FiveYearPred");

                    b.Property<double>("OneDayPred");

                    b.Property<double>("OneMonthPred");

                    b.Property<double>("OneWeekPred");

                    b.Property<double>("OneYearPred");

                    b.Property<double>("SixMonthPred");

                    b.Property<double>("ThreeMonthPred");

                    b.Property<string>("Ticker");

                    b.Property<double>("TwoYearPred");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Predictions");
                });

            modelBuilder.Entity("MLTAscend.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MLTAscend.Domain.Models.Prediction", b =>
                {
                    b.HasOne("MLTAscend.Domain.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
