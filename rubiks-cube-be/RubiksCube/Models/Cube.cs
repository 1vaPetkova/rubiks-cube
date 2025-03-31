using Newtonsoft.Json;
using RubiksCube.Enums;

namespace RubiksCube.Models
{
    public class Cube
    {
        [JsonProperty("sides")]
        public Dictionary<Face, Colour[][]> Sides { get; set; }
    }


}