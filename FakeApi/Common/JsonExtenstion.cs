using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FakeApi.Common;

public static class JsonExtenstion
{
    /// <summary>
    /// Mặc định 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ToJson(this object obj)
    {
        return JsonConvert.SerializeObject(obj);
    }


    /// <summary>
    /// Đẩy ra JSON theo [JsonPropertyName("id")]
    /// DefaultContractResolver and simply overrides the JSON property name
    /// (https://www.newtonsoft.com/json/help/html/ContractResolver.htm)
    /// Dùng cho trường hợp những api viết thường, hoa khác với thệ thống
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string ToJsonWithProp(this object obj)
    {
        return JsonConvert.SerializeObject(obj,
            new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() });
    }

    public static T ToObject<T>(this string json)
    {
        return JsonConvert.DeserializeObject<T>(json,
            new JsonSerializerSettings { ContractResolver = new DefaultContractResolver() });
    }
}