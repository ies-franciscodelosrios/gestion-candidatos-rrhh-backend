using System.Text.Json.Serialization;

namespace IGApi.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CandidateStatusEnum
    {
        IN_PROCESS,
        PENDANT,
        REJECTED,
        HIRED,
        DOUBT
    }
}
