using System.Text.Json.Serialization;

namespace IGApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SubRolEnum
    {
        BE,
        FE,
        DATA
    }
}
