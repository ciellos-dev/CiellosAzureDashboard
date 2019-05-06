﻿// <auto-generated />
using System;
using CiellosAzureDashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CiellosAzureDashboard.Migrations
{
    [DbContext(typeof(CADContext))]
    [Migration("20190421175524_VMStatus")]
    partial class VMStatus
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("CiellosAzureDashboard.Model.Application", b =>
                {
                    b.Property<int>("AppId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId");

                    b.Property<string>("ClientSecret");

                    b.Property<string>("Description");

                    b.Property<string>("SubscriptionId");

                    b.Property<string>("TenantId");

                    b.Property<string>("Thumbprint");

                    b.HasKey("AppId");

                    b.ToTable("Applications");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.Dashboard", b =>
                {
                    b.Property<int>("DashboardId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DashboardAnonAccessCode");

                    b.Property<string>("DashboardLogoUrl");

                    b.Property<string>("DashboardName");

                    b.HasKey("DashboardId");

                    b.ToTable("Dashboards");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.DashboardApplication", b =>
                {
                    b.Property<int>("DashboardId");

                    b.Property<int>("ApplicationId");

                    b.HasKey("DashboardId", "ApplicationId");

                    b.HasAlternateKey("ApplicationId", "DashboardId");

                    b.ToTable("DashboardApplication");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.InactiveVM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DashboardId");

                    b.Property<string>("VMId");

                    b.HasKey("Id");

                    b.ToTable("InactiveVMs");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.Link", b =>
                {
                    b.Property<int>("linkId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DashboardId");

                    b.Property<string>("linkName");

                    b.Property<string>("linkUrl");

                    b.HasKey("linkId");

                    b.HasIndex("DashboardId");

                    b.ToTable("Link");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.Log", b =>
                {
                    b.Property<int>("logId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("city");

                    b.Property<string>("country");

                    b.Property<string>("ip");

                    b.Property<string>("key");

                    b.Property<string>("name");

                    b.Property<string>("region");

                    b.Property<string>("resourcegroup");

                    b.Property<string>("subscription");

                    b.Property<DateTime>("timestamp");

                    b.Property<string>("vmname");

                    b.HasKey("logId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.Setting", b =>
                {
                    b.Property<int>("settingId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MaxNumEventsLogStorePerVM");

                    b.Property<string>("certificateThumbprintStr");

                    b.HasKey("settingId");

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("DashboardId");

                    b.Property<bool>("IsSuperUser");

                    b.Property<string>("UserName");

                    b.Property<bool>("UserStatus");

                    b.HasKey("UserId");

                    b.HasIndex("DashboardId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.VM", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApplicationId");

                    b.Property<string>("PowerState");

                    b.Property<string>("ProvisioningState");

                    b.Property<string>("ResourceGroupName");

                    b.Property<string>("SubscriptionId");

                    b.Property<string>("Tags");

                    b.Property<string>("VMId");

                    b.Property<string>("VMName");

                    b.Property<string>("VMSize");

                    b.HasKey("Id");

                    b.ToTable("VMs");
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.DashboardApplication", b =>
                {
                    b.HasOne("CiellosAzureDashboard.Model.Application", "Application")
                        .WithMany("DashboardApplications")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CiellosAzureDashboard.Model.Dashboard", "Dashboard")
                        .WithMany("DashboardApplications")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.Link", b =>
                {
                    b.HasOne("CiellosAzureDashboard.Model.Dashboard", "Dashboard")
                        .WithMany("Links")
                        .HasForeignKey("DashboardId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CiellosAzureDashboard.Model.User", b =>
                {
                    b.HasOne("CiellosAzureDashboard.Model.Dashboard", "Dashboard")
                        .WithMany()
                        .HasForeignKey("DashboardId");
                });
#pragma warning restore 612, 618
        }
    }
}
