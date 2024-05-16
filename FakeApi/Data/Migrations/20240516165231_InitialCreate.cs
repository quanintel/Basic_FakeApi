using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Hotline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emergency = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyNameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyNameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyNameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyNameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine1L = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine2L = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3E = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressLine3L = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveFlag = table.Column<int>(type: "int", nullable: false),
                    ExternalFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MomentType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MustNotChangeFlag = table.Column<bool>(type: "bit", nullable: false),
                    GlVisitTypeOverrideFlag = table.Column<bool>(type: "bit", nullable: false),
                    DescriptionL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SourceTable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemMovementTypeRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direction = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MomentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemGroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemTypeRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubItemTypeRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UomRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MandatoryCaregiverFlag = table.Column<bool>(type: "bit", nullable: false),
                    UserChargeableFlag = table.Column<bool>(type: "bit", nullable: false),
                    OpdChargeableFlag = table.Column<bool>(type: "bit", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false),
                    IpdChargeableFlag = table.Column<bool>(type: "bit", nullable: false),
                    VariablePriceFlag = table.Column<bool>(type: "bit", nullable: false),
                    LuUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unit",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    ShortNameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UomRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortNameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayNameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActiveStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayNameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MustNotChangeFlag = table.Column<bool>(type: "bit", nullable: false),
                    LuUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OmitDenominatorFlag = table.Column<bool>(type: "bit", nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WareHouse",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    AllowSalesFlag = table.Column<bool>(type: "bit", nullable: false),
                    NameL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CostcentreCode = table.Column<double>(type: "float", nullable: false),
                    AutomaticStoreIssueReceiptFlag = table.Column<bool>(type: "bit", nullable: false),
                    CostcentreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActiveFlag = table.Column<bool>(type: "bit", nullable: false),
                    NameE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockDuringStockCheckFlag = table.Column<bool>(type: "bit", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AllowNegativeStockFlag = table.Column<bool>(type: "bit", nullable: false),
                    LuUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StoreTypeRcd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WareHouse", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    StoreItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PendingRefillRequestQty = table.Column<double>(type: "float", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MinQty = table.Column<double>(type: "float", nullable: false),
                    BackOrderQty = table.Column<double>(type: "float", nullable: false),
                    StockCheckLockedFlag = table.Column<bool>(type: "bit", nullable: false),
                    ReplenishmentTypeRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LockedFlag = table.Column<bool>(type: "bit", nullable: false),
                    MaxQty = table.Column<double>(type: "float", nullable: false),
                    TargetQty = table.Column<double>(type: "float", nullable: false),
                    InTransitQty = table.Column<double>(type: "float", nullable: false),
                    QtyOnHand = table.Column<double>(type: "float", nullable: false),
                    PendingIssuesIn = table.Column<double>(type: "float", nullable: false),
                    ReorderPointQty = table.Column<double>(type: "float", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockUomRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LuUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PendingIssuesOut = table.Column<double>(type: "float", nullable: false),
                    InTransitCost = table.Column<double>(type: "float", nullable: false),
                    BinLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseProduct", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "MomentType");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Unit");

            migrationBuilder.DropTable(
                name: "WareHouse");

            migrationBuilder.DropTable(
                name: "WarehouseProduct");
        }
    }
}
