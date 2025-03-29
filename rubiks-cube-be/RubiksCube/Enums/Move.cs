using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace RubiksCube.Enums
{

    [JsonConverter(typeof(StringEnumConverter))]
    public enum Move
    {
        [EnumMember(Value = "F")]
        F,

        [EnumMember(Value = "F'")]
        FPrime,

        [EnumMember(Value = "R")]
        R,

        [EnumMember(Value = "R'")]
        RPrime,

        [EnumMember(Value = "U")]
        U,

        [EnumMember(Value = "U'")]
        UPrime,

        [EnumMember(Value = "B")]
        B,

        [EnumMember(Value = "B'")]
        BPrime,

        [EnumMember(Value = "L")]
        L,

        [EnumMember(Value = "L'")]
        LPrime,

        [EnumMember(Value = "D")]
        D,

        [EnumMember(Value = "D'")]
        DPrime
    }
}