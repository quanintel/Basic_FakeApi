using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class WarehouseTransactionHistoryDto
{
    [JsonProperty("store_id")]
    [JsonPropertyName("store_id")]
    public Guid StoreId { get; set; }

    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("luc_cost")]
    [JsonPropertyName("luc_cost")]
    public double LucCost { get; set; }

    [JsonProperty("item_id")]
    [JsonPropertyName("item_id")]
    public Guid ItemId { get; set; }

    [JsonProperty("movement_qty")]
    [JsonPropertyName("movement_qty")]
    public double MovementQty { get; set; }

    [JsonProperty("item_movement_id")]
    [JsonPropertyName("item_movement_id")]
    public Guid ItemMovementId { get; set; }

    [JsonProperty("qty_on_hand")]
    [JsonPropertyName("qty_on_hand")]
    public double QtyOnHand { get; set; }

    [JsonProperty("suc_cost")]
    [JsonPropertyName("suc_cost")]
    public double SucCost { get; set; }

    [JsonProperty("date_time")]
    [JsonPropertyName("date_time")]
    public DateTime DateTime { get; set; }

    [JsonProperty("user_id")]
    [JsonPropertyName("user_id")]
    public Guid UserId { get; set; }

    [JsonProperty("actual_cost")]
    [JsonPropertyName("actual_cost")]
    public double ActualCost { get; set; }

    [JsonProperty("auc_cost")]
    [JsonPropertyName("auc_cost")]
    public double AucCost { get; set; }

    [JsonProperty("source_id")]
    [JsonPropertyName("source_id")]
    public Guid SourceId { get; set; }

    [JsonProperty("item_movement_type_rcd")]
    [JsonPropertyName("item_movement_type_rcd")]
    public string ItemMovementTypeRcd { get; set; }
}