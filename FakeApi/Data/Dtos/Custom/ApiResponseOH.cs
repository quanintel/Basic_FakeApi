using System.Text.Json.Serialization;

namespace FakeApi.Data.Dtos.Custom;

public class ApiResponseOH<T>
{
    [JsonPropertyName("entries")] public ApiResponseOHBody<T> Entries { get; set; }
}

public class ApiResponseOHBody<T>
{
    [JsonPropertyName("entry")] public List<T> Entry { get; set; }
}

