using System.Text.Json.Serialization;
using FakeApi.Data.Dtos.Custom;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class ProductDto : BaseDto
{
    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("item_code")]
    [JsonPropertyName("item_code")]
    public string ItemCode { get; set; }

    [JsonProperty("item_id")]
    [JsonPropertyName("item_id")]
    public Guid ItemId { get; set; }

    [JsonProperty("item_type_rcd")]
    [JsonPropertyName("item_type_rcd")]
    public string ItemTypeRcd { get; set; }

    [JsonProperty("item_group_id")]
    [JsonPropertyName("item_group_id")]
    public Guid ItemGroupId { get; set; }

    [JsonProperty("uom_rcd")]
    [JsonPropertyName("uom_rcd")]
    public string UomRcd { get; set; }

    [JsonProperty("name_e")]
    [JsonPropertyName("name_e")]
    public string NameE { get; set; }

    [JsonProperty("name_l")]
    [JsonPropertyName("name_l")]
    public string NameL { get; set; }

    [JsonProperty("mandatory_caregiver_flag")]
    [JsonPropertyName("mandatory_caregiver_flag")]
    public bool MandatoryCaregiverFlag { get; set; }

    [JsonProperty("sub_item_type_rcd")]
    [JsonPropertyName("sub_item_type_rcd")]
    public string SubItemTypeRcd { get; set; }

    [JsonProperty("user_chargeable_flag")]
    [JsonPropertyName("user_chargeable_flag")]
    public bool UserChargeableFlag { get; set; }

    [JsonProperty("opd_chargeable_flag")]
    [JsonPropertyName("opd_chargeable_flag")]
    public bool OpdChargeableFlag { get; set; }

    [JsonProperty("active_flag")]
    [JsonPropertyName("active_flag")]
    public bool ActiveFlag { get; set; }

    [JsonProperty("ipd_chargeable_flag")]
    [JsonPropertyName("ipd_chargeable_flag")]
    public bool IpdChargeableFlag { get; set; }

    [JsonProperty("variable_price_flag")]
    [JsonPropertyName("variable_price_flag")]
    public bool VariablePriceFlag { get; set; }

    [JsonProperty("lu_updated")]
    [JsonPropertyName("lu_updated")]
    public DateTime LuUpdated { get; set; }
}