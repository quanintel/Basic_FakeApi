using System.Text.Json.Serialization;
using FakeApi.Data.Dtos.Custom;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class HospitalDto : BaseDto
{
    [JsonProperty("company_id")]
    [JsonPropertyName("company_id")]
    public Guid CompanyId { get; set; }

    [JsonProperty("company_code")]
    [JsonPropertyName("company_code")]
    public string CompanyCode { get; set; }

    [JsonProperty("company_name_e")]
    [JsonPropertyName("company_name_e")]
    public string CompanyNameE { get; set; }

    [JsonProperty("company_name_l")]
    [JsonPropertyName("company_name_l")]
    public string CompanyNameL { get; set; }

    [JsonProperty("address_line_1_e")]
    [JsonPropertyName("address_line_1_e")]
    public string AddressLine1E { get; set; }

    [JsonProperty("address_line_1_l")]
    [JsonPropertyName("address_line_1_l")]
    public string AddressLine1L { get; set; }

    [JsonProperty("address_line_2_e")]
    [JsonPropertyName("address_line_2_e")]
    public string AddressLine2E { get; set; }

    [JsonProperty("address_line_2_l")]
    [JsonPropertyName("address_line_2_l")]
    public string AddressLine2L { get; set; }

    [JsonProperty("address_line_3_e")]
    [JsonPropertyName("address_line_3_e")]
    public string AddressLine3E { get; set; }

    [JsonProperty("address_line_3_l")]
    [JsonPropertyName("address_line_3_l")]
    public string AddressLine3L { get; set; }

    [JsonProperty("city")]
    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonProperty("post_code")]
    [JsonPropertyName("post_code")]
    public string PostCode { get; set; }

    [JsonProperty("active_flag")]
    [JsonPropertyName("active_flag")]
    public int ActiveFlag { get; set; }

    [JsonProperty("external_facility_id")]
    [JsonPropertyName("external_facility_id")]
    public Guid ExternalFacilityId { get; set; }
}