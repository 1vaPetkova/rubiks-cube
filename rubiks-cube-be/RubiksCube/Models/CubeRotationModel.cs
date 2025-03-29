using Newtonsoft.Json;

namespace RubiksCube.Models;

public class CubeRotationModel
{
    [JsonProperty("cube")]
    public required CubeModel Cube { get; set; }

    [JsonProperty("direction")]
    public Move Direction { get; }
}
