using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class MomentTypeDto
{
    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("active_status")]
    [JsonPropertyName("active_status")]
    public string ActiveStatus { get; set; }

    [JsonProperty("description_e")]
    [JsonPropertyName("description_e")]
    public string DescriptionE { get; set; }

    [JsonProperty("name_l")]
    [JsonPropertyName("name_l")]
    public string NameL { get; set; }

    [JsonProperty("must_not_change_flag")]
    [JsonPropertyName("must_not_change_flag")]
    public bool MustNotChangeFlag { get; set; }

    [JsonProperty("gl_visit_type_override_flag")]
    [JsonPropertyName("gl_visit_type_override_flag")]
    public bool GlVisitTypeOverrideFlag { get; set; }

    [JsonProperty("description_l")]
    [JsonPropertyName("description_l")]
    public string DescriptionL { get; set; }

    [JsonProperty("source_table")]
    [JsonPropertyName("source_table")]
    public string SourceTable { get; set; }

    [JsonProperty("lu_updated")]
    [JsonPropertyName("lu_updated")]
    public DateTime LuUpdated { get; set; }

    [JsonProperty("name_e")]
    [JsonPropertyName("name_e")]
    public string NameE { get; set; }

    [JsonProperty("item_movement_type_rcd")]
    [JsonPropertyName("item_movement_type_rcd")]
    public string ItemMovementTypeRcd { get; set; }

    [JsonProperty("direction")]
    [JsonPropertyName("direction")]
    public int Direction { get; set; }
}