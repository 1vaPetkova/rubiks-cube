using Newtonsoft.Json;
using RubiksCube.Enums;
using RubiksCube.Models;


namespace RubiksCube.Services
{
    public static class RotationService
    {
        public static void Rotate(CubeRequestModel model, ILogger logger)
        {
            var cube = model.Cube;
            switch (model.Direction)
            {
                case Move.F: RotateFront(cube, logger); break;
                case Move.FPrime: RotateFront(cube); break;
                case Move.R: RotateFront(cube); break;
                case Move.RPrime: RotateFront(cube); break;
                case Move.U: RotateFront(cube); break;
                case Move.UPrime: RotateFront(cube); break;
                case Move.B: RotateFront(cube); break;
                case Move.BPrime: RotateFront(cube); break;
                case Move.L: RotateFront(cube); break;
                case Move.LPrime: RotateFront(cube); break;
                case Move.D: RotateFront(cube); break;
                case Move.DPrime: RotateFront(cube); break;
            }
        }


        private static void RotateFront(Cube cube, ILogger logger = null)
        {
            Dictionary<Face, Colour[][]> sides = cube.Sides;
            string cubeSerialized = JsonConvert.SerializeObject(cube);
            logger?.LogInformation(cubeSerialized);
            Cube cubeCopy = JsonConvert.DeserializeObject<Cube>(cubeSerialized);
            Dictionary<Face, Colour[][]> sidesCopy = cube.Sides;
            IndexMove[][] fMoves = FrontSideMoves();
            foreach (IndexMove[] moves in fMoves)
            {
                foreach (IndexMove m in moves)
                {
                    Tile from = m.From;
                    Tile to = m.To;

                    Colour colour = sidesCopy[from.Face][from.Position[0]][from.Position[1]];
                    sides[to.Face][to.Position[0]][to.Position[1]] = colour;
                }
            }
        }


        private static Dictionary<Face, Face[]> Neighbours()
        {
            return new()
            {
                { Face.Front, [Face.Top, Face.Right, Face.Down, Face.Left] },
                { Face.Right, [Face.Top, Face.Back, Face.Down, Face.Front] },
                { Face.Left, [Face.Top, Face.Front, Face.Down, Face.Back] },
                { Face.Top, [Face.Back, Face.Right, Face.Front, Face.Left] },
                { Face.Down, [Face.Front, Face.Right, Face.Back, Face.Left] },
                { Face.Back, [Face.Top, Face.Right, Face.Down, Face.Left] },
            };
        }


        private static IndexMove[][] FrontSideMoves()
        {
            IndexMove[] faceMoves = FaceMoves(Face.Front);

            IndexMove[] topMoves =
                [ new IndexMove(from: new Tile(Face.Top, [2, 0]), to: new Tile(Face.Right, [0,0])),
                  new IndexMove(from: new Tile(Face.Top, [2, 1]), to: new Tile(Face.Right,[1,0])),
                  new IndexMove(from: new Tile(Face.Top, [2, 2]), to: new Tile(Face.Right,[2,0]))
                ];

            IndexMove[] rightMoves =
                [ new IndexMove(from: new Tile(Face.Right,[0, 0]), to: new Tile(Face.Down,[0,2])),
                  new IndexMove(from: new Tile(Face.Right,[1, 0]), to: new Tile(Face.Down,[0,1])),
                  new IndexMove(from: new Tile(Face.Right,[2, 0]), to: new Tile(Face.Down,[0,0]))
                ];

            IndexMove[] downMoves =
                [ new IndexMove(from: new Tile(Face.Down,[0, 0]), to: new Tile(Face.Left,[2,2])),
                  new IndexMove(from: new Tile(Face.Down,[1, 0]), to: new Tile(Face.Left,[2,1])),
                  new IndexMove(from: new Tile(Face.Down,[2, 0]), to: new Tile(Face.Left,[2,0]))
                ];

            IndexMove[] leftMoves =
                [ new IndexMove(from: new Tile(Face.Left,[2, 0]), to: new Tile(Face.Top,[2,2])),
                  new IndexMove(from: new Tile(Face.Left,[2, 1]), to: new Tile(Face.Left,[2,1])),
                  new IndexMove(from: new Tile(Face.Left,[2, 2]), to: new Tile(Face.Left,[2,0]))
                ];
            return [faceMoves, topMoves, rightMoves, downMoves, leftMoves];
        }

        private static IndexMove[] FaceMoves(Face face)
        {
            return
              [ new IndexMove(from: new Tile(face, [0, 0]), to: new Tile(face, [0,2])),
                  new IndexMove(from: new Tile(face, [0, 1]), to: new Tile(face, [1,2])),
                  new IndexMove(from: new Tile(face, [0, 2]), to: new Tile(face, [2,2])),

                  new IndexMove(from: new Tile(face, [1, 0]), to: new Tile(face, [0,1])),
                  new IndexMove(from: new Tile(face, [1, 2]), to: new Tile(face, [2,1])),

                  new IndexMove(from: new Tile(face, [2, 0]), to: new Tile(face, [0,0])),
                  new IndexMove(from: new Tile(face, [2, 1]), to: new Tile(face, [1,0])),
                  new IndexMove(from: new Tile(face, [2, 2]), to: new Tile(face, [2,0]))
              ];
        }
    }

}