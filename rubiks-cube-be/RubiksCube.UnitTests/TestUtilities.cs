using RubiksCube.Enums;
using RubiksCube.Models;

namespace RubiksCube.UnitTests
{
    internal static class TestUtilities
    {
        internal static Cube CreateBaseCube()
        {
            Dictionary<Face, Colour[][]> sides = new()
            {
                { Face.Left,  [ [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange] ] },

                { Face.Front, [ [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green] ] },

                { Face.Right, [ [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red] ] },

                { Face.Back,  [ [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue] ] },

                { Face.Top,   [ [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White] ] },

                { Face.Down,  [ [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow] ] },
            };
            Cube cube = new()
            {
                Sides = sides
            };

            return cube;
        }

        internal static void CompareColours(Cube expected, Cube actual)
        {
            Assert.IsNotNull(actual.Sides);
            Assert.AreEqual(expected.Sides.Count, actual.Sides.Count);

            foreach (Face face in Enum.GetValues<Face>())
            {
                Colour[][] expectedLine = expected.Sides[face];
                Colour[][] actualLine = actual.Sides[face];

                CollectionAssert.AreEqual(expectedLine[0], actualLine[0], $"The {expectedLine[0]} and {actualLine[0]} do not match");
                CollectionAssert.AreEqual(expectedLine[1], actualLine[1], $"The {expectedLine[1]} and {actualLine[1]} do not match");
                CollectionAssert.AreEqual(expectedLine[2], actualLine[2], $"The {expectedLine[2]} and {actualLine[2]} do not match");
            }
        }

        internal static readonly Cube FRotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Orange, Colour.Orange, Colour.Yellow],
                                [Colour.Orange, Colour.Orange, Colour.Yellow],
                                [Colour.Orange, Colour.Orange, Colour.Yellow] ] },

                { Face.Front, [ [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green] ] },

                { Face.Right, [ [Colour.White, Colour.Red, Colour.Red],
                                [Colour.White, Colour.Red, Colour.Red],
                                [Colour.White, Colour.Red, Colour.Red] ] },

                { Face.Back,  [ [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue] ] },

                { Face.Top,   [ [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White],
                                [Colour.Orange, Colour.Orange, Colour.Orange] ] },

                { Face.Down,  [ [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow] ] },
            }
        };

        internal static readonly Cube RPrimeRotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange] ] },

                { Face.Front, [ [Colour.Green, Colour.Green, Colour.White],
                                [Colour.Green, Colour.Green, Colour.White],
                                [Colour.Green, Colour.Green, Colour.White] ] },

                { Face.Right, [ [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red] ] },

                { Face.Back,  [ [Colour.Yellow, Colour.Blue, Colour.Blue],
                                [Colour.Yellow, Colour.Blue, Colour.Blue],
                                [Colour.Yellow, Colour.Blue, Colour.Blue] ] },

                { Face.Top,   [ [Colour.White, Colour.White, Colour.Blue],
                                [Colour.White, Colour.White, Colour.Blue],
                                [Colour.White, Colour.White, Colour.Blue] ] },

                { Face.Down,  [ [Colour.Yellow, Colour.Yellow, Colour.Green],
                                [Colour.Yellow, Colour.Yellow, Colour.Green],
                                [Colour.Yellow, Colour.Yellow, Colour.Green] ] },
            }
        };

        internal static readonly Cube URotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange] ] },

                { Face.Front, [ [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green] ] },

                { Face.Right, [ [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red] ] },

                { Face.Back,  [ [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue] ] },

                { Face.Top,   [ [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White] ] },

                { Face.Down,  [ [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow] ] },
            }
        };

        internal static readonly Cube BPrimeRotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Yellow, Colour.Orange, Colour.Orange],
                                [Colour.Yellow, Colour.Orange, Colour.Orange],
                                [Colour.Yellow, Colour.Orange, Colour.Orange] ] },

                { Face.Front, [ [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green] ] },

                { Face.Right, [ [Colour.Red, Colour.Red, Colour.White],
                                [Colour.Red, Colour.Red, Colour.White],
                                [Colour.Red, Colour.Red, Colour.White] ] },

                { Face.Back,  [ [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue] ] },

                { Face.Top,   [ [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White] ] },

                { Face.Down,  [ [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Red, Colour.Red, Colour.Red] ] },
            }
        };

        internal static readonly Cube LRotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange] ] },

                { Face.Front, [ [Colour.White, Colour.Green, Colour.Green],
                                [Colour.White, Colour.Green, Colour.Green],
                                [Colour.White, Colour.Green, Colour.Green] ] },

                { Face.Right, [ [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red] ] },

                { Face.Back,  [ [Colour.Blue, Colour.Blue, Colour.Yellow],
                                [Colour.Blue, Colour.Blue, Colour.Yellow],
                                [Colour.Blue, Colour.Blue, Colour.Yellow] ] },

                { Face.Top,   [ [Colour.Blue, Colour.White, Colour.White],
                                [Colour.Blue, Colour.White, Colour.White],
                                [Colour.Blue, Colour.White, Colour.White] ] },

                { Face.Down,  [ [Colour.Green, Colour.Yellow, Colour.Yellow],
                                [Colour.Green, Colour.Yellow, Colour.Yellow],
                                [Colour.Green, Colour.Yellow, Colour.Yellow] ] },
            }
        };

        internal static readonly Cube DPrimeRotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Orange, Colour.Orange, Colour.Orange],
                                [Colour.Green, Colour.Green, Colour.Green] ] },

                { Face.Front, [ [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Green, Colour.Green, Colour.Green],
                                [Colour.Red, Colour.Red, Colour.Red] ] },

                { Face.Right, [ [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Red, Colour.Red, Colour.Red],
                                [Colour.Blue, Colour.Blue, Colour.Blue] ] },

                { Face.Back,  [ [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Blue, Colour.Blue, Colour.Blue],
                                [Colour.Orange, Colour.Orange, Colour.Orange] ] },

                { Face.Top,   [ [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White],
                                [Colour.White, Colour.White, Colour.White] ] },

                { Face.Down,  [ [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.Yellow] ] },
            }
        };

        internal static readonly Cube CombinedRotatedCube = new()
        {
            Sides = new Dictionary<Face, Colour[][]>()
            {
                { Face.Left,  [ [Colour.Green, Colour.Yellow, Colour.Yellow],
                                [Colour.Orange, Colour.Orange, Colour.Green],
                                [Colour.Blue, Colour.Green, Colour.Orange] ] },

                { Face.Front, [ [Colour.Orange, Colour.Red, Colour.Red],
                                [Colour.Orange, Colour.Green, Colour.White],
                                [Colour.White, Colour.White, Colour.White] ] },

                { Face.Right, [ [Colour.Yellow, Colour.Blue, Colour.Orange],
                                [Colour.Red, Colour.Red, Colour.White],
                                [Colour.Orange, Colour.Yellow, Colour.Red] ] },

                { Face.Back,  [ [Colour.Yellow, Colour.Blue, Colour.White],
                                [Colour.Orange, Colour.Blue, Colour.Yellow],
                                [Colour.Yellow, Colour.Yellow, Colour.White] ] },

                { Face.Top,   [ [Colour.Red, Colour.Orange, Colour.Green],
                                [Colour.Blue, Colour.White, Colour.White],
                                [Colour.Blue, Colour.Blue, Colour.Blue] ] },

                { Face.Down,  [ [Colour.Green, Colour.Green, Colour.Blue],
                                [Colour.Red, Colour.Yellow, Colour.Red],
                                [Colour.Red, Colour.Green, Colour.Green] ] },
            }
        };
    }
}