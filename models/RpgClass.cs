using System.Text.Json.Serialization;
namespace projectEf_1.models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        knight = 1,
        Mage = 2,
        Cleric = 3,
    }
}