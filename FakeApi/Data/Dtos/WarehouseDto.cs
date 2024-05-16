using System.Text.Json.Serialization;
using FakeApi.Data.Dtos.Custom;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class WarehouseDto : BaseDto
{
    [JsonProperty("store_id")]
    [JsonPropertyName("store_id")]
    public Guid StoreId { get; set; }

    [JsonProperty("store_code")]
    [JsonPropertyName("store_code")]
    public string StoreCode { get; set; }

    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("allow_sales_flag")]
    [JsonPropertyName("allow_sales_flag")]
    public bool AllowSalesFlag { get; set; }

    [JsonProperty("name_l")]
    [JsonPropertyName("name_l")]
    public string NameL { get; set; }

    [JsonProperty("costcentre_code")]
    [JsonPropertyName("costcentre_code")]
    public double CostcentreCode { get; set; }

    [JsonProperty("automatic_store_issue_receipt_flag")]
    [JsonPropertyName("automatic_store_issue_receipt_flag")]
    public bool AutomaticStoreIssueReceiptFlag { get; set; }

    [JsonProperty("costcentre_id")]
    [JsonPropertyName("costcentre_id")]
    public Guid CostcentreId { get; set; }

    [JsonProperty("active_flag")]
    [JsonPropertyName("active_flag")]
    public bool ActiveFlag { get; set; }

    [JsonProperty("name_e")]
    [JsonPropertyName("name_e")]
    public string NameE { get; set; }

    [JsonProperty("lock_during_stock_check_flag")]
    [JsonPropertyName("lock_during_stock_check_flag")]
    public bool LockDuringStockCheckFlag { get; set; }

    [JsonProperty("company_code")]
    [JsonPropertyName("company_code")]
    public string CompanyCode { get; set; }

    [JsonProperty("allow_negative_stock_flag")]
    [JsonPropertyName("allow_negative_stock_flag")]
    public bool AllowNegativeStockFlag { get; set; }

    [JsonProperty("lu_updated")]
    [JsonPropertyName("lu_updated")]
    public DateTime LuUpdated { get; set; }

    [JsonProperty("store_type_rcd")]
    [JsonPropertyName("store_type_rcd")]
    public string StoreTypeRcd { get; set; }
}