using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RubiksCube.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SideFace
    {
        [EnumMember(Value = "front")]
        Front,

        [EnumMember(Value = "back")]
        Back,

        [EnumMember(Value = "left")]
        Left,

        [EnumMember(Value = "right")]
        Right,

        [EnumMember(Value = "top")]
        Top,

        [EnumMember(Value = "bottom")]
        Bottom
    }
}