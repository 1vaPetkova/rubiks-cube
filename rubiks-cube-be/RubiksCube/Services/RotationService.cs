using Newtonsoft.Json;
using RubiksCube.Enums;
using RubiksCube.Models;
using RubiksCube.Utilities;

namespace RubiksCube.Services
{
    public static class RotationService
    {
        public static void Rotate(CubeRequestModel model)
        {

            var cube = model.Cube;
            Dictionary<Face, Colour[][]> sides = cube.Sides;
            string cubeSerialized = JsonConvert.SerializeObject(cube);
            Cube cubeCopy = JsonConvert.DeserializeObject<Cube>(cubeSerialized);
            Dictionary<Face, Colour[][]> sidesCopy = cubeCopy.Sides;

            RotateSide(model.Direction, sides, sidesCopy);
        }

        private static void RotateSide(Move direction, Dictionary<Face, Colour[][]> sides, Dictionary<Face, Colour[][]> sidesCopy)
        {
            IndexMove[][] moves = RotationUtilities.GetSideMoves(direction);

            foreach (IndexMove[] moveGroup in moves)
            {
                foreach (IndexMove move in moveGroup)
                {
                    Tile from;
                    Tile to;

                    if (direction.ToString().Contains("Prime", StringComparison.OrdinalIgnoreCase))
                    {
                        from = move.To;
                        to = move.From;
                    }
                    else
                    {
                        from = move.From;
                        to = move.To;
                    }

                    Colour colour = sidesCopy[from.Face][from.Position[0]][from.Position[1]];
                    sides[to.Face][to.Position[0]][to.Position[1]] = colour;

                }
            }
        }


    }
}