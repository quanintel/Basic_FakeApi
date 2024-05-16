using System.Text.Json.Serialization;
using FakeApi.Data.Dtos.Custom;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class WarehouseProductDto : BaseDto
{
    [JsonProperty("store_id")]
    [JsonPropertyName("store_id")]
    public Guid StoreId { get; set; }

    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("store_item_id")]
    [JsonPropertyName("store_item_id")]
    public Guid StoreItemId { get; set; }

    [JsonProperty("pending_refill_request_qty")]
    [JsonPropertyName("pending_refill_request_qty")]
    public double PendingRefillRequestQty { get; set; }

    [JsonProperty("item_id")]
    [JsonPropertyName("item_id")]
    public Guid ItemId { get; set; }

    [JsonProperty("min_qty")]
    [JsonPropertyName("min_qty")]
    public double MinQty { get; set; }

    [JsonProperty("back_order_qty")]
    [JsonPropertyName("back_order_qty")]
    public double BackOrderQty { get; set; }

    [JsonProperty("stock_check_locked_flag")]
    [JsonPropertyName("stock_check_locked_flag")]
    public bool StockCheckLockedFlag { get; set; }

    [JsonProperty("replenishment_type_rcd")]
    [JsonPropertyName("replenishment_type_rcd")]
    public string ReplenishmentTypeRcd { get; set; }

    [JsonProperty("locked_flag")]
    [JsonPropertyName("locked_flag")]
    public bool LockedFlag { get; set; }

    [JsonProperty("max_qty")]
    [JsonPropertyName("max_qty")]
    public double MaxQty { get; set; }

    [JsonProperty("target_qty")]
    [JsonPropertyName("target_qty")]
    public double TargetQty { get; set; }

    [JsonProperty("in_transit_qty")]
    [JsonPropertyName("in_transit_qty")]
    public double InTransitQty { get; set; }

    [JsonProperty("qty_on_hand")]
    [JsonPropertyName("qty_on_hand")]
    public double QtyOnHand { get; set; }

    [JsonProperty("pending_issues_in")]
    [JsonPropertyName("pending_issues_in")]
    public double PendingIssuesIn { get; set; }

    [JsonProperty("reorder_point_qty")]
    [JsonPropertyName("reorder_point_qty")]
    public double ReorderPointQty { get; set; }

    [JsonProperty("company_code")]
    [JsonPropertyName("company_code")]
    public string CompanyCode { get; set; }

    [JsonProperty("stock_uom_rcd")]
    [JsonPropertyName("stock_uom_rcd")]
    public string StockUomRcd { get; set; }

    [JsonProperty("lu_updated")]
    [JsonPropertyName("lu_updated")]
    public DateTime LuUpdated { get; set; }

    [JsonProperty("pending_issues_out")]
    [JsonPropertyName("pending_issues_out")]
    public double PendingIssuesOut { get; set; }

    [JsonProperty("in_transit_cost")]
    [JsonPropertyName("in_transit_cost")]
    public double InTransitCost { get; set; }

    [JsonProperty("bin_location")]
    [JsonPropertyName("bin_location")]
    public string BinLocation { get; set; }
}