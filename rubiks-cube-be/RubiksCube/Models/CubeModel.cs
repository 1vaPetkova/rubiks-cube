using Newtonsoft.Json;

namespace RubiksCube.Models
{
    public class CubeModel
    {
        [JsonProperty("sides")]
        public SideModel[] Sides { get; set; }
    }

    public class SideModel
    {
        [JsonProperty("face")]
        public string Face { get; set; }

        [JsonProperty("colours")]
        public string[][] Colours { get; set; }
    }
}