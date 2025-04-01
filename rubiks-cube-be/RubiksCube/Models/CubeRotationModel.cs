using Newtonsoft.Json;
using RubiksCube.Enums;

namespace RubiksCube.Models
{
    public class CubeRotationModel
    {
        [JsonProperty("cube")]
        public required Cube Cube { get; set; }

        [JsonProperty("direction")]
        public Move Direction { get; set; }
    }
}