﻿// <auto-generated />
using System;
using FakeApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FakeApi.Data.Migrations
{
    [DbContext(typeof(FakeContext))]
    [Migration("20240528162302_AddNewTable")]
    partial class AddNewTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FakeApi.Data.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyNameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hotline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.Hospital", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ActiveFlag")
                        .HasColumnType("int");

                    b.Property<string>("AddressLine1E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine1L")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2L")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3E")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine3L")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CompanyNameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyNameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExternalFacilityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PostCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hospital");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.MomentType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActiveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescriptionL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<bool>("GlVisitTypeOverrideFlag")
                        .HasColumnType("bit");

                    b.Property<string>("ItemMovementTypeRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LuUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MustNotChangeFlag")
                        .HasColumnType("bit");

                    b.Property<string>("NameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SourceTable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MomentType");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("IpdChargeableFlag")
                        .HasColumnType("bit");

                    b.Property<string>("ItemCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ItemGroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemTypeRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LuUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MandatoryCaregiverFlag")
                        .HasColumnType("bit");

                    b.Property<string>("NameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OpdChargeableFlag")
                        .HasColumnType("bit");

                    b.Property<string>("SubItemTypeRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.Property<string>("UomRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("UserChargeableFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("VariablePriceFlag")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.Unit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActiveStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayNameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisplayNameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LuUpdated")
                        .HasColumnType("datetime2");

                    b.Property<bool>("MustNotChangeFlag")
                        .HasColumnType("bit");

                    b.Property<string>("NameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OmitDenominatorFlag")
                        .HasColumnType("bit");

                    b.Property<string>("ShortCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortNameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortNameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.Property<string>("UomRcd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unit");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.Warehouse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("ActiveFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowNegativeStockFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("AllowSalesFlag")
                        .HasColumnType("bit");

                    b.Property<bool>("AutomaticStoreIssueReceiptFlag")
                        .HasColumnType("bit");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CostcentreCode")
                        .HasColumnType("float");

                    b.Property<Guid>("CostcentreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("LockDuringStockCheckFlag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LuUpdated")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameE")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StoreTypeRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WareHouse");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.WarehouseInput", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("AverageUnitCost")
                        .HasColumnType("float");

                    b.Property<double>("BackOrderQty")
                        .HasColumnType("float");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("InTransitCost")
                        .HasColumnType("float");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("LeadTimeDays")
                        .HasColumnType("float");

                    b.Property<bool>("LockedFlag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LuUpdated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("LuUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("MaxQty")
                        .HasColumnType("float");

                    b.Property<double>("MinQty")
                        .HasColumnType("float");

                    b.Property<double>("QtyOnHand")
                        .HasColumnType("float");

                    b.Property<double>("QtyOnHandCost")
                        .HasColumnType("float");

                    b.Property<double>("ReorderPointQty")
                        .HasColumnType("float");

                    b.Property<bool>("StockCheckLockedFlag")
                        .HasColumnType("bit");

                    b.Property<string>("StockUomRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TargetQty")
                        .HasColumnType("float");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.Property<bool>("TrackedFlag")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("WarehouseInput");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.WarehouseProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("BackOrderQty")
                        .HasColumnType("float");

                    b.Property<string>("BinLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("InTransitCost")
                        .HasColumnType("float");

                    b.Property<double>("InTransitQty")
                        .HasColumnType("float");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("LockedFlag")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LuUpdated")
                        .HasColumnType("datetime2");

                    b.Property<double>("MaxQty")
                        .HasColumnType("float");

                    b.Property<double>("MinQty")
                        .HasColumnType("float");

                    b.Property<double>("PendingIssuesIn")
                        .HasColumnType("float");

                    b.Property<double>("PendingIssuesOut")
                        .HasColumnType("float");

                    b.Property<double>("PendingRefillRequestQty")
                        .HasColumnType("float");

                    b.Property<double>("QtyOnHand")
                        .HasColumnType("float");

                    b.Property<double>("ReorderPointQty")
                        .HasColumnType("float");

                    b.Property<string>("ReplenishmentTypeRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("StockCheckLockedFlag")
                        .HasColumnType("bit");

                    b.Property<string>("StockUomRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("TargetQty")
                        .HasColumnType("float");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("WarehouseProduct");
                });

            modelBuilder.Entity("FakeApi.Data.Entities.WarehouseTransactionHistory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("ActualCost")
                        .HasColumnType("float");

                    b.Property<double>("AucCost")
                        .HasColumnType("float");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ItemId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ItemMovementId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ItemMovementTypeRcd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LucCost")
                        .HasColumnType("float");

                    b.Property<double>("MovementQty")
                        .HasColumnType("float");

                    b.Property<double>("QtyOnHand")
                        .HasColumnType("float");

                    b.Property<Guid>("SourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StoreId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("SucCost")
                        .HasColumnType("float");

                    b.Property<int>("TotalRecords")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("WarehouseTransactionHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
