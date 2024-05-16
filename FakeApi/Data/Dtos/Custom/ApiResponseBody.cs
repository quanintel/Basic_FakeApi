using System.Text.Json.Serialization;

namespace FakeApi.Data.Dtos.Custom;

public class ApiResponseBody<T>
{
    [JsonPropertyName("total")] public long Total { get; set; }

    [JsonPropertyName("item")] public List<T> Item { get; set; }
}