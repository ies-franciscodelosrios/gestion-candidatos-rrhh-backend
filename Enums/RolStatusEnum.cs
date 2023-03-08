using System.Text.Json.Serialization;

namespace IGApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RolStatusEnum
    {
        OPEN,
        CLOSED,
        IN_PROCESS
    }
}
