using System;
using System.Text.Json.Serialization;

namespace ReqresInAutotests.Autotests.Model;

[Serializable]
public class UpdateUserResponse
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("job")]
    public string? Job { get; set; }
    [JsonPropertyName("updatedAt")]
    public string? UpdatedAt { get; set; }
}
