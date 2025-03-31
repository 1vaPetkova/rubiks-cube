
using RubiksCube.Enums;

namespace RubiksCube.Models
{
    public class Tile(Face face, int[] position)
    {
        public Face Face { get; set; } = face;
        public int[] Position { get; set; } = position;
    }


}