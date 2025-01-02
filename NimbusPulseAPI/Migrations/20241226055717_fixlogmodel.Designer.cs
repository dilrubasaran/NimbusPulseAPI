﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NimbusPulseAPI.Context;

#nullable disable

namespace NimbusPulseAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241226055717_fixlogmodel")]
    partial class fixlogmodel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("NimbusPulseAPI.DTOs.DeviceDTO", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HealthStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("DeviceDTO");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Application", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CpuUsagePercentage")
                        .HasColumnType("REAL");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("Duration")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("RamUsagePercentage")
                        .HasColumnType("REAL");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Device", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HealthStatus")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("IpAddress")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastReportDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("OperatingSystem")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("Uptime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LogLevel")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SentAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.ResourceUsage", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<double>("ApplicationsUsage")
                        .HasColumnType("REAL");

                    b.Property<double>("BackupsUsage")
                        .HasColumnType("REAL");

                    b.Property<double>("CpuUsagePercentage")
                        .HasColumnType("REAL");

                    b.Property<int>("DeviceId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("DiskUsagePercentage")
                        .HasColumnType("REAL");

                    b.Property<double>("RamUsagePercentage")
                        .HasColumnType("REAL");

                    b.Property<double>("SystemFilesUsage")
                        .HasColumnType("REAL");

                    b.Property<double>("TemporaryFilesUsage")
                        .HasColumnType("REAL");

                    b.Property<double>("UserFilesUsage")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("ResourceUsages");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Settings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LanguagePreference")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NotificationPreference")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Theme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SettingsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SettingsId")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Application", b =>
                {
                    b.HasOne("NimbusPulseAPI.Models.Device", "Device")
                        .WithMany("Applications")
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Notification", b =>
                {
                    b.HasOne("NimbusPulseAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.ResourceUsage", b =>
                {
                    b.HasOne("NimbusPulseAPI.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NimbusPulseAPI.Models.Device", null)
                        .WithOne("ResourceUsage")
                        .HasForeignKey("NimbusPulseAPI.Models.ResourceUsage", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Device");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.User", b =>
                {
                    b.HasOne("NimbusPulseAPI.Models.Settings", "Settings")
                        .WithOne("User")
                        .HasForeignKey("NimbusPulseAPI.Models.User", "SettingsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Settings");
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Device", b =>
                {
                    b.Navigation("Applications");

                    b.Navigation("ResourceUsage")
                        .IsRequired();
                });

            modelBuilder.Entity("NimbusPulseAPI.Models.Settings", b =>
                {
                    b.Navigation("User")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}