﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project1.Models;

namespace Project1.Migrations
{
    [DbContext(typeof(AppointmentsContext))]
    [Migration("20210317144219_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("Project1.Models.Appointment", b =>
                {
                    b.Property<int>("ApptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ApptTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupEmail")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PhoneNum")
                        .HasColumnType("TEXT");

                    b.HasKey("ApptID");

                    b.ToTable("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
