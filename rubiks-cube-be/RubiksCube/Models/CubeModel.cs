using Newtonsoft.Json;

namespace RubiksCube.Models
{
    public class CubeModel
    {
        [JsonProperty("sides")]
        public Side[] Sides { get; set; }
    }

    public class Side
    {
        [JsonProperty("face")]
        public string Face { get; set; }

        [JsonProperty("colours")]
        public string[][] Colours { get; set; }
    }
}