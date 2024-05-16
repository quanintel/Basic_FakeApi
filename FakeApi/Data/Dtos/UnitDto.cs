using System.Text.Json.Serialization;
using FakeApi.Data.Dtos.Custom;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class UnitDto : BaseDto
{
    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("short_name_l")]
    [JsonPropertyName("short_name_l")]
    public string ShortNameL { get; set; }

    [JsonProperty("name_l")]
    [JsonPropertyName("name_l")]
    public string NameL { get; set; }

    [JsonProperty("uom_rcd")]
    [JsonPropertyName("uom_rcd")]
    public string UomRcd { get; set; }

    [JsonProperty("short_name_e")]
    [JsonPropertyName("short_name_e")]
    public string ShortNameE { get; set; }

    [JsonProperty("display_name_e")]
    [JsonPropertyName("display_name_e")]
    public string DisplayNameE { get; set; }

    [JsonProperty("name_e")]
    [JsonPropertyName("name_e")]
    public string NameE { get; set; }

    [JsonProperty("active_status")]
    [JsonPropertyName("active_status")]
    public string ActiveStatus { get; set; }

    [JsonProperty("display_name_l")]
    [JsonPropertyName("display_name_l")]
    public string DisplayNameL { get; set; }

    [JsonProperty("must_not_change_flag")]
    [JsonPropertyName("must_not_change_flag")]
    public bool MustNotChangeFlag { get; set; }

    [JsonProperty("lu_updated")]
    [JsonPropertyName("lu_updated")]
    public DateTime LuUpdated { get; set; }

    [JsonProperty("omit_denominator_flag")]
    [JsonPropertyName("omit_denominator_flag")]
    public bool OmitDenominatorFlag { get; set; }

    [JsonProperty("short_code")]
    [JsonPropertyName("short_code")]
    public string ShortCode { get; set; }
}