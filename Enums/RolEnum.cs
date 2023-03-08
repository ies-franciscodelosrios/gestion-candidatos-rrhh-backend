using System.Text.Json.Serialization;

namespace IGApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RolEnum
    {
        DEVELOPER,
        QA
    }
}
