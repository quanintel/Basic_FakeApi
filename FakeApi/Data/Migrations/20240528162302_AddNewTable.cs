using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FakeApi.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WarehouseInput",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    TrackedFlag = table.Column<bool>(type: "bit", nullable: false),
                    StoreItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MinQty = table.Column<double>(type: "float", nullable: false),
                    BackOrderQty = table.Column<double>(type: "float", nullable: false),
                    StockCheckLockedFlag = table.Column<bool>(type: "bit", nullable: false),
                    LockedFlag = table.Column<bool>(type: "bit", nullable: false),
                    MaxQty = table.Column<double>(type: "float", nullable: false),
                    TargetQty = table.Column<double>(type: "float", nullable: false),
                    QtyOnHandCost = table.Column<double>(type: "float", nullable: false),
                    QtyOnHand = table.Column<double>(type: "float", nullable: false),
                    LuUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LeadTimeDays = table.Column<double>(type: "float", nullable: false),
                    ReorderPointQty = table.Column<double>(type: "float", nullable: false),
                    CompanyCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockUomRcd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageUnitCost = table.Column<double>(type: "float", nullable: false),
                    LuUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InTransitCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseInput", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WarehouseTransactionHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalRecords = table.Column<int>(type: "int", nullable: false),
                    LucCost = table.Column<double>(type: "float", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovementQty = table.Column<double>(type: "float", nullable: false),
                    ItemMovementId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QtyOnHand = table.Column<double>(type: "float", nullable: false),
                    SucCost = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActualCost = table.Column<double>(type: "float", nullable: false),
                    AucCost = table.Column<double>(type: "float", nullable: false),
                    SourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemMovementTypeRcd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WarehouseTransactionHistory", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WarehouseInput");

            migrationBuilder.DropTable(
                name: "WarehouseTransactionHistory");
        }
    }
}
