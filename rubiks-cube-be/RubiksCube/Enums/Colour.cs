using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RubiksCube.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Colour
    {
        [EnumMember(Value = "white")]
        White,

        [EnumMember(Value = "yellow")]
        Yellow,

        [EnumMember(Value = "blue")]
        Blue,

        [EnumMember(Value = "green")]
        Green,

        [EnumMember(Value = "red")]
        Red,

        [EnumMember(Value = "orange")]
        Orange
    }
}