using RubiksCube.Enums;

namespace RubiksCube.Models
{
    public class IndexMove(Tile from, Tile to)
    {
        public Tile From { get; set; } = from;
        public Tile To { get; set; } = to;
    }
}