using System;
using System.Text.Json.Serialization;

namespace ReqresInAutotests.Autotests.Model;

[Serializable]
public class CreateUserResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("job")]
    public string? Job { get; set; }
    [JsonPropertyName("createdAt")]
    public DateTime CreatedAt { get; set; }
}
