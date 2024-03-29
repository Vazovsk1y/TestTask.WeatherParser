﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestTask.DAL;

#nullable disable

namespace TestTask.DAL.Migrations
{
    [DbContext(typeof(TestTaskDbContext))]
    partial class TestTaskDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TestTask.DAL.Models.WeatherRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AirHumidity")
                        .HasColumnType("float");

                    b.Property<double>("AirPressure")
                        .HasColumnType("float");

                    b.Property<double>("AirTemperature")
                        .HasColumnType("float");

                    b.Property<double?>("Clouds")
                        .HasColumnType("float");

                    b.Property<double>("DewPoint")
                        .HasColumnType("float");

                    b.Property<double?>("HorizontalVisibility")
                        .HasColumnType("float");

                    b.Property<double?>("LowCloudBoundary")
                        .HasColumnType("float");

                    b.Property<string>("MainWindDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("MeasurementDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NaturalPhenomena")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondaryWindDirection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("WindSpeed")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WeatherRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
