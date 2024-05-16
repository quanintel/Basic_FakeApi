using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;

namespace FakeApi.Data.Dtos.Custom;

public class ApiInput
{
    [FromQuery(Name = "pageNumber")]
    [JsonPropertyName("pageNumber")]
    public int PageNumber { get; set; } = 1;

    [FromQuery(Name = "pageSize")]
    [JsonPropertyName("pageSize")]
    public int PageSize { get; set; } = 20;

    [FromQuery(Name = "fromDate")]
    [JsonPropertyName("fromDate")]
    public DateTime? FromDate { get; set; } = null;

    [FromQuery(Name = "toDate")]
    [JsonPropertyName("toDate")]
    public DateTime? ToDate { get; set; } = null;

    [FromQuery(Name = "keyword")]
    [JsonPropertyName("keyword")]
    public string Keyword { get; set; } = string.Empty;
}