using System.Text.Json.Serialization;

namespace FakeApi.Data.Dtos.Custom;

public class ApiResponse<T>
{
    [JsonPropertyName("items")] public ApiResponseBody<T> Items { get; set; }
}
