using System.Text.Json.Serialization;

namespace Cars.Models.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BrandEnums
    {
        Toyota = 1,
        Ford = 2,
        Honda = 3
    }
}