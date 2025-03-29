using Newtonsoft.Json;

namespace RubiksCube.Models;
public class CubeModel
{
    [JsonProperty("sides")]
    public List<Side> Sides { get; set; }
}

public class Side
{
    [JsonProperty("face")]
    public string Face { get; set; }

    [JsonProperty("colours")]
    public List<List<string>> Colours { get; set; }
}