using System.Text.Json.Serialization;
using FakeApi.Data.Dtos.Custom;
using Newtonsoft.Json;

namespace FakeApi.Data.Dtos;

public class CompanyDto
{
    [JsonProperty("address_l")]
    [JsonPropertyName("address_l")]
    public string AddressL { get; set; }

    [JsonProperty("totalRecords")]
    [JsonPropertyName("totalRecords")]
    public int TotalRecords { get; set; }

    [JsonProperty("company_id")]
    [JsonPropertyName("company_id")]
    public string CompanyId { get; set; }

    [JsonProperty("company_name_l")]
    [JsonPropertyName("company_name_l")]
    public string CompanyNameL { get; set; }

    [JsonProperty("hotline")]
    [JsonPropertyName("hotline")]
    public string Hotline { get; set; }

    [JsonProperty("emergency")]
    [JsonPropertyName("emergency")]
    public string Emergency { get; set; }

    [JsonProperty("company_code")]
    [JsonPropertyName("company_code")]
    public string CompanyCode { get; set; }

    [JsonProperty("address_e")]
    [JsonPropertyName("address_e")]
    public string AddressE { get; set; }

    [JsonProperty("tel")]
    [JsonPropertyName("tel")]
    public string Tel { get; set; }

    [JsonProperty("company_name_e")]
    [JsonPropertyName("company_name_e")]
    public string CompanyNameE { get; set; }

    [JsonProperty("fax")]
    [JsonPropertyName("fax")]
    public string Fax { get; set; }
}