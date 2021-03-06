﻿// <auto-generated />
using System;
using EFCoreTest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreTest.Migrations
{
    [DbContext(typeof(ExternalJobContext))]
    [Migration("20200518174030_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreTest.Entities.Appliance", b =>
                {
                    b.Property<Guid>("ApplianceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ApplianceLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplianceType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChimneyType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GasCouncilNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsStoredInCompartment")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUnderContract")
                        .HasColumnType("bit");

                    b.Property<bool>("LandlordAppliance")
                        .HasColumnType("bit");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ModelQualifier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherApplianceLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SerialNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SystemType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplianceId");

                    b.ToTable("Appliances");
                });

            modelBuilder.Entity("EFCoreTest.Entities.Contract", b =>
                {
                    b.Property<Guid>("ContractId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BaseProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContractNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastServicedOn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ServiceDueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ContractId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("EFCoreTest.Entities.Customer", b =>
                {
                    b.Property<string>("CustomerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BusinessPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DoNotAllowSms")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVulnerable")
                        .HasColumnType("bit");

                    b.Property<string>("MobilePhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PreferredLetter")
                        .HasColumnType("int");

                    b.Property<int>("PreferredPhone")
                        .HasColumnType("int");

                    b.Property<string>("SpecialRequirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("VipMarker")
                        .HasColumnType("bit");

                    b.Property<string>("VulnerabilityReason")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EFCoreTest.Entities.Exclusion", b =>
                {
                    b.Property<string>("ExclusionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AffectedAppliance")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AffectedApplianceOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExcludedComponent")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExcludedComponentOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExclusionReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExclusionReasonOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocationOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ExclusionId");

                    b.ToTable("Exclusions");
                });

            modelBuilder.Entity("EFCoreTest.Entities.Property", b =>
                {
                    b.Property<Guid>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccessInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnershipType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegionBrand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantFullName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyId");

                    b.ToTable("Properties");
                });

            modelBuilder.Entity("EFCoreTest.Entities.WorkOrder", b =>
                {
                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AppointmentNumber")
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("ContractId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCallOutChargeable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCentralHeatingOperational")
                        .HasColumnType("bit");

                    b.Property<bool>("IsHotWaterOperational")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLabourChargeable")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPartsChargeable")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid?>("PropertyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Number");

                    b.HasIndex("ContractId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.HasIndex("PropertyId");

                    b.ToTable("WorkOrders");
                });

            modelBuilder.Entity("EFCoreTest.Entities.WorkOrder", b =>
                {
                    b.HasOne("EFCoreTest.Entities.Contract", null)
                        .WithMany()
                        .HasForeignKey("ContractId");

                    b.HasOne("EFCoreTest.Entities.Property", null)
                        .WithMany()
                        .HasForeignKey("PropertyId");
                });
#pragma warning restore 612, 618
        }
    }
}
